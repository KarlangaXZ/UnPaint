using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace UnPaint
{
    public partial class PaintKarlangaxz : Form
    {
        Graphics g;
        Bitmap bm;
        int x = -1;
        int y = -1;
        Pen pen;
        Acciones accion = Acciones.Nada;

        enum Acciones {
            Nada,
            Dibujando,
            Rellenando
        }

        public PaintKarlangaxz()
        {
            InitializeComponent();
            bm = new Bitmap(lienso.Width, lienso.Height);
            g = Graphics.FromImage(bm);
            lienso.Image = bm;
            g.SmoothingMode = SmoothingMode.AntiAlias; //La textura de la linea mejor.
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = LineCap.Round;
            // para establecer el uso extremo a nuestro lapiz (pen) al inicio (Starcap) y al final (Endcap)
        }

        private void mostrarcolor_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void lienso_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pen = new Pen(mostrarcolor.BackColor, (float)lineWidth.Value);
                x = e.X;
                y = e.Y;
                lienso.Cursor = Cursors.Cross;
            }
        }

        private void lienso_MouseMove(object sender, MouseEventArgs e)
        {
            if (accion == Acciones.Dibujando && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }

            lienso.Refresh();
        }


        private void lienso_MouseUp(object sender, MouseEventArgs e)
        {
            x = -1;
            y = -1;
            lienso.Cursor = Cursors.Default;
            accion = Acciones.Dibujando;
        }

        private void selectcolor_click(object sender, EventArgs e)
        {
            if (coloreses.ShowDialog() == DialogResult.OK)
            {
                mostrarcolor.BackColor = coloreses.Color;
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            string html = "<html>" +
                          "<head>" +
                          "<title>Dibujo en Canvas</title>"+
                          "</head>";

            var image = GetImage(lienso.Image);
            html += "<body>" +
                    "<img src='"+image+"' />"+
                    "</body>" +
                    "</html>";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos HTML (*.html)|*.html";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, html);
                }
            }

            MessageBox.Show("Ya fue guardado");
        }

        private string GetImage(Image image)
        {//stream en memoria para almacenar la imagen en bytes.
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, ImageFormat.Png);
                var imagebytes = memoryStream.GetBuffer();
                return "data:image/png;base64," + Convert.ToBase64String(imagebytes);
            } 
        }

        private void rellenarAreaButton_Click(object sender, EventArgs e)
        {
            //if ternario
            accion = accion == Acciones.Rellenando? Acciones.Dibujando: Acciones.Rellenando;
        }
        
        private void lienso_MouseClick(object sender, MouseEventArgs e)
        {
            if(accion == Acciones.Rellenando)
            {
                Point point = set_Point(lienso, e.Location);
                Fill(bm, point.X, point.Y, pen.Color);
            }
        }

        static Point set_Point(PictureBox pb, Point pt)
        {
            float px = 1f * pb.Width / pb.Width;
            float py = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }

        private void Validate(Bitmap bm, Stack<Point>sp,int x, int y, Color Old_color, Color New_Color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == Old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, New_Color);
            }
        }

        private void Fill(Bitmap bm, int x, int y, Color New_Clr)
        {
            Color Old_Color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, New_Clr);

            if(Old_Color == New_Clr) { return; }

            while(pixel.Count>0)
            {
                Point pt = (Point)pixel.Pop();
                if(pt.X>0 && pt.Y>0 && pt.X<bm.Width-1 && pt.Y<bm.Height-1)
                {
                    Validate(bm, pixel, pt.X - 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y - 1, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X + 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y + 1, Old_Color, New_Clr);
                }
            }

            accion = Acciones.Dibujando;
        }
    }
} 




