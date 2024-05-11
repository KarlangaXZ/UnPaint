namespace UnPaint
{
    partial class PaintKarlangaxz
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintKarlangaxz));
            this.coloreses = new System.Windows.Forms.ColorDialog();
            this.barra = new System.Windows.Forms.Panel();
            this.rellenarAreaButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.lineWidth = new System.Windows.Forms.TrackBar();
            this.mostrarcolor = new System.Windows.Forms.PictureBox();
            this.selectcolor = new System.Windows.Forms.Button();
            this.lienso = new System.Windows.Forms.PictureBox();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarcolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lienso)).BeginInit();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.Gray;
            this.barra.Controls.Add(this.rellenarAreaButton);
            this.barra.Controls.Add(this.exportButton);
            this.barra.Controls.Add(this.lineWidth);
            this.barra.Controls.Add(this.mostrarcolor);
            this.barra.Controls.Add(this.selectcolor);
            this.barra.Location = new System.Drawing.Point(2, 2);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(881, 45);
            this.barra.TabIndex = 2;
            // 
            // rellenarAreaButton
            // 
            this.rellenarAreaButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rellenarAreaButton.Location = new System.Drawing.Point(34, 4);
            this.rellenarAreaButton.Name = "rellenarAreaButton";
            this.rellenarAreaButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rellenarAreaButton.Size = new System.Drawing.Size(64, 19);
            this.rellenarAreaButton.TabIndex = 1;
            this.rellenarAreaButton.Text = "Rellenar";
            this.rellenarAreaButton.UseVisualStyleBackColor = true;
            this.rellenarAreaButton.Click += new System.EventHandler(this.rellenarAreaButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(816, 0);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(65, 23);
            this.exportButton.TabIndex = 5;
            this.exportButton.Text = "Exportar";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // lineWidth
            // 
            this.lineWidth.BackColor = System.Drawing.Color.Gray;
            this.lineWidth.Location = new System.Drawing.Point(104, 3);
            this.lineWidth.Name = "lineWidth";
            this.lineWidth.Size = new System.Drawing.Size(118, 45);
            this.lineWidth.TabIndex = 6;
            this.lineWidth.Value = 1;
            // 
            // mostrarcolor
            // 
            this.mostrarcolor.BackColor = System.Drawing.Color.Red;
            this.mostrarcolor.Location = new System.Drawing.Point(2, 3);
            this.mostrarcolor.Name = "mostrarcolor";
            this.mostrarcolor.Size = new System.Drawing.Size(26, 24);
            this.mostrarcolor.TabIndex = 0;
            this.mostrarcolor.TabStop = false;
            this.mostrarcolor.Click += new System.EventHandler(this.mostrarcolor_Click);
            // 
            // selectcolor
            // 
            this.selectcolor.Location = new System.Drawing.Point(33, 26);
            this.selectcolor.Name = "selectcolor";
            this.selectcolor.Size = new System.Drawing.Size(65, 19);
            this.selectcolor.TabIndex = 4;
            this.selectcolor.Text = "Color";
            this.selectcolor.UseVisualStyleBackColor = true;
            this.selectcolor.Click += new System.EventHandler(this.selectcolor_click);
            // 
            // lienso
            // 
            this.lienso.BackColor = System.Drawing.Color.White;
            this.lienso.Location = new System.Drawing.Point(2, 2);
            this.lienso.Name = "lienso";
            this.lienso.Size = new System.Drawing.Size(881, 457);
            this.lienso.TabIndex = 3;
            this.lienso.TabStop = false;
            this.lienso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lienso_MouseClick);
            this.lienso.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lienso_MouseDown);
            this.lienso.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lienso_MouseMove);
            this.lienso.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lienso_MouseUp);
            // 
            // PaintKarlangaxz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.lienso);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PaintKarlangaxz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Karlangaxz";
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarcolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lienso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog coloreses;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.Button rellenarAreaButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.TrackBar lineWidth;
        private System.Windows.Forms.PictureBox mostrarcolor;
        private System.Windows.Forms.Button selectcolor;
        private System.Windows.Forms.PictureBox lienso;
    }
}

