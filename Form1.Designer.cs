namespace Examen
{
    partial class frm_Imagenes
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
            this.pbx_Original = new System.Windows.Forms.PictureBox();
            this.pbx_Procesada = new System.Windows.Forms.PictureBox();
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.btn_Reiniciar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbx_Modo = new System.Windows.Forms.GroupBox();
            this.rbt_Expandido = new System.Windows.Forms.RadioButton();
            this.rbt_Zoom = new System.Windows.Forms.RadioButton();
            this.rbt_Normal = new System.Windows.Forms.RadioButton();
            this.rbt_Centrado = new System.Windows.Forms.RadioButton();
            this.tkb_Brillo = new System.Windows.Forms.TrackBar();
            this.tkb_Contraste = new System.Windows.Forms.TrackBar();
            this.tkb_Saturacion = new System.Windows.Forms.TrackBar();
            this.tkb_Zoom = new System.Windows.Forms.TrackBar();
            this.lbl_Brillo = new System.Windows.Forms.Label();
            this.lbl_Zoom = new System.Windows.Forms.Label();
            this.lbl_Saturacion = new System.Windows.Forms.Label();
            this.lbl_Contraste = new System.Windows.Forms.Label();
            this.nvl_Brillo = new System.Windows.Forms.Label();
            this.nvl_Contraste = new System.Windows.Forms.Label();
            this.nvl_Saturacion = new System.Windows.Forms.Label();
            this.nvl_Zoom = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Procesada)).BeginInit();
            this.gbx_Modo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_Brillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_Contraste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_Saturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_Zoom)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_Original
            // 
            this.pbx_Original.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbx_Original.Location = new System.Drawing.Point(18, 18);
            this.pbx_Original.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbx_Original.Name = "pbx_Original";
            this.pbx_Original.Size = new System.Drawing.Size(825, 538);
            this.pbx_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Original.TabIndex = 0;
            this.pbx_Original.TabStop = false;
            // 
            // pbx_Procesada
            // 
            this.pbx_Procesada.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbx_Procesada.Location = new System.Drawing.Point(870, 18);
            this.pbx_Procesada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbx_Procesada.Name = "pbx_Procesada";
            this.pbx_Procesada.Size = new System.Drawing.Size(390, 277);
            this.pbx_Procesada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Procesada.TabIndex = 1;
            this.pbx_Procesada.TabStop = false;
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Cargar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cargar.Location = new System.Drawing.Point(18, 589);
            this.btn_Cargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(225, 77);
            this.btn_Cargar.TabIndex = 2;
            this.btn_Cargar.Text = "Cargar";
            this.btn_Cargar.UseVisualStyleBackColor = false;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
            // 
            // btn_Reiniciar
            // 
            this.btn_Reiniciar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Reiniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reiniciar.Location = new System.Drawing.Point(315, 589);
            this.btn_Reiniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Reiniciar.Name = "btn_Reiniciar";
            this.btn_Reiniciar.Size = new System.Drawing.Size(225, 77);
            this.btn_Reiniciar.TabIndex = 3;
            this.btn_Reiniciar.Text = "Reiniciar";
            this.btn_Reiniciar.UseVisualStyleBackColor = false;
            this.btn_Reiniciar.Click += new System.EventHandler(this.btn_Reiniciar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Guardar.Location = new System.Drawing.Point(618, 589);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(225, 77);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gbx_Modo
            // 
            this.gbx_Modo.Controls.Add(this.rbt_Expandido);
            this.gbx_Modo.Controls.Add(this.rbt_Zoom);
            this.gbx_Modo.Controls.Add(this.rbt_Normal);
            this.gbx_Modo.Controls.Add(this.rbt_Centrado);
            this.gbx_Modo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbx_Modo.Location = new System.Drawing.Point(870, 308);
            this.gbx_Modo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbx_Modo.Name = "gbx_Modo";
            this.gbx_Modo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbx_Modo.Size = new System.Drawing.Size(375, 92);
            this.gbx_Modo.TabIndex = 5;
            this.gbx_Modo.TabStop = false;
            this.gbx_Modo.Text = "Modo";
            this.gbx_Modo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbt_Expandido
            // 
            this.rbt_Expandido.Checked = true;
            this.rbt_Expandido.Location = new System.Drawing.Point(183, 57);
            this.rbt_Expandido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbt_Expandido.Name = "rbt_Expandido";
            this.rbt_Expandido.Size = new System.Drawing.Size(165, 26);
            this.rbt_Expandido.TabIndex = 3;
            this.rbt_Expandido.TabStop = true;
            this.rbt_Expandido.Text = "Expandido";
            this.rbt_Expandido.UseVisualStyleBackColor = true;
            this.rbt_Expandido.CheckedChanged += new System.EventHandler(this.rbt_Expandido_CheckedChanged);
            // 
            // rbt_Zoom
            // 
            this.rbt_Zoom.Location = new System.Drawing.Point(9, 57);
            this.rbt_Zoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbt_Zoom.Name = "rbt_Zoom";
            this.rbt_Zoom.Size = new System.Drawing.Size(165, 26);
            this.rbt_Zoom.TabIndex = 2;
            this.rbt_Zoom.Text = "Zoom";
            this.rbt_Zoom.UseVisualStyleBackColor = true;
            this.rbt_Zoom.CheckedChanged += new System.EventHandler(this.rbt_Zoom_CheckedChanged);
            // 
            // rbt_Normal
            // 
            this.rbt_Normal.Location = new System.Drawing.Point(183, 29);
            this.rbt_Normal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbt_Normal.Name = "rbt_Normal";
            this.rbt_Normal.Size = new System.Drawing.Size(165, 26);
            this.rbt_Normal.TabIndex = 1;
            this.rbt_Normal.Text = "Normal";
            this.rbt_Normal.UseVisualStyleBackColor = true;
            this.rbt_Normal.CheckedChanged += new System.EventHandler(this.rbt_Normal_CheckedChanged);
            // 
            // rbt_Centrado
            // 
            this.rbt_Centrado.Location = new System.Drawing.Point(9, 29);
            this.rbt_Centrado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbt_Centrado.Name = "rbt_Centrado";
            this.rbt_Centrado.Size = new System.Drawing.Size(165, 26);
            this.rbt_Centrado.TabIndex = 0;
            this.rbt_Centrado.Text = "Centrado";
            this.rbt_Centrado.UseVisualStyleBackColor = true;
            this.rbt_Centrado.CheckedChanged += new System.EventHandler(this.rbt_Centrado_CheckedChanged);
            // 
            // tkb_Brillo
            // 
            this.tkb_Brillo.AutoSize = false;
            this.tkb_Brillo.Location = new System.Drawing.Point(870, 409);
            this.tkb_Brillo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tkb_Brillo.Maximum = 100;
            this.tkb_Brillo.Minimum = -100;
            this.tkb_Brillo.Name = "tkb_Brillo";
            this.tkb_Brillo.Size = new System.Drawing.Size(375, 31);
            this.tkb_Brillo.TabIndex = 4;
            this.tkb_Brillo.Scroll += new System.EventHandler(this.tkb_Brillo_Scroll);
            // 
            // tkb_Contraste
            // 
            this.tkb_Contraste.AutoSize = false;
            this.tkb_Contraste.Location = new System.Drawing.Point(870, 480);
            this.tkb_Contraste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tkb_Contraste.Maximum = 100;
            this.tkb_Contraste.Minimum = -100;
            this.tkb_Contraste.Name = "tkb_Contraste";
            this.tkb_Contraste.Size = new System.Drawing.Size(375, 31);
            this.tkb_Contraste.TabIndex = 6;
            this.tkb_Contraste.Scroll += new System.EventHandler(this.tkb_Contraste_Scroll);
            // 
            // tkb_Saturacion
            // 
            this.tkb_Saturacion.AutoSize = false;
            this.tkb_Saturacion.Location = new System.Drawing.Point(870, 551);
            this.tkb_Saturacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tkb_Saturacion.Maximum = 100;
            this.tkb_Saturacion.Minimum = -100;
            this.tkb_Saturacion.Name = "tkb_Saturacion";
            this.tkb_Saturacion.Size = new System.Drawing.Size(375, 31);
            this.tkb_Saturacion.TabIndex = 7;
            this.tkb_Saturacion.Scroll += new System.EventHandler(this.tkb_Saturacion_Scroll);
            // 
            // tkb_Zoom
            // 
            this.tkb_Zoom.AutoSize = false;
            this.tkb_Zoom.Location = new System.Drawing.Point(870, 625);
            this.tkb_Zoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tkb_Zoom.Maximum = 100;
            this.tkb_Zoom.Minimum = -100;
            this.tkb_Zoom.Name = "tkb_Zoom";
            this.tkb_Zoom.Size = new System.Drawing.Size(375, 31);
            this.tkb_Zoom.TabIndex = 8;
            this.tkb_Zoom.Scroll += new System.EventHandler(this.tkb_Zoom_Scroll);
            // 
            // lbl_Brillo
            // 
            this.lbl_Brillo.AutoSize = true;
            this.lbl_Brillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brillo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Brillo.Location = new System.Drawing.Point(874, 445);
            this.lbl_Brillo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Brillo.Name = "lbl_Brillo";
            this.lbl_Brillo.Size = new System.Drawing.Size(69, 29);
            this.lbl_Brillo.TabIndex = 9;
            this.lbl_Brillo.Text = "Brillo";
            // 
            // lbl_Zoom
            // 
            this.lbl_Zoom.AutoSize = true;
            this.lbl_Zoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Zoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Zoom.Location = new System.Drawing.Point(874, 660);
            this.lbl_Zoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Zoom.Name = "lbl_Zoom";
            this.lbl_Zoom.Size = new System.Drawing.Size(75, 29);
            this.lbl_Zoom.TabIndex = 10;
            this.lbl_Zoom.Text = "Zoom";
            // 
            // lbl_Saturacion
            // 
            this.lbl_Saturacion.AutoSize = true;
            this.lbl_Saturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saturacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Saturacion.Location = new System.Drawing.Point(874, 589);
            this.lbl_Saturacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Saturacion.Name = "lbl_Saturacion";
            this.lbl_Saturacion.Size = new System.Drawing.Size(127, 29);
            this.lbl_Saturacion.TabIndex = 11;
            this.lbl_Saturacion.Text = "Saturacion";
            // 
            // lbl_Contraste
            // 
            this.lbl_Contraste.AutoSize = true;
            this.lbl_Contraste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contraste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Contraste.Location = new System.Drawing.Point(874, 515);
            this.lbl_Contraste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Contraste.Name = "lbl_Contraste";
            this.lbl_Contraste.Size = new System.Drawing.Size(116, 29);
            this.lbl_Contraste.TabIndex = 12;
            this.lbl_Contraste.Text = "Contraste";
            // 
            // nvl_Brillo
            // 
            this.nvl_Brillo.AutoSize = true;
            this.nvl_Brillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvl_Brillo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nvl_Brillo.Location = new System.Drawing.Point(1194, 449);
            this.nvl_Brillo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nvl_Brillo.Name = "nvl_Brillo";
            this.nvl_Brillo.Size = new System.Drawing.Size(23, 25);
            this.nvl_Brillo.TabIndex = 13;
            this.nvl_Brillo.Text = "0";
            this.nvl_Brillo.Click += new System.EventHandler(this.label1_Click);
            // 
            // nvl_Contraste
            // 
            this.nvl_Contraste.AutoSize = true;
            this.nvl_Contraste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvl_Contraste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nvl_Contraste.Location = new System.Drawing.Point(1194, 520);
            this.nvl_Contraste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nvl_Contraste.Name = "nvl_Contraste";
            this.nvl_Contraste.Size = new System.Drawing.Size(23, 25);
            this.nvl_Contraste.TabIndex = 14;
            this.nvl_Contraste.Text = "0";
            // 
            // nvl_Saturacion
            // 
            this.nvl_Saturacion.AutoSize = true;
            this.nvl_Saturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvl_Saturacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nvl_Saturacion.Location = new System.Drawing.Point(1194, 594);
            this.nvl_Saturacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nvl_Saturacion.Name = "nvl_Saturacion";
            this.nvl_Saturacion.Size = new System.Drawing.Size(23, 25);
            this.nvl_Saturacion.TabIndex = 15;
            this.nvl_Saturacion.Text = "0";
            // 
            // nvl_Zoom
            // 
            this.nvl_Zoom.AutoSize = true;
            this.nvl_Zoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvl_Zoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nvl_Zoom.Location = new System.Drawing.Point(1194, 665);
            this.nvl_Zoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nvl_Zoom.Name = "nvl_Zoom";
            this.nvl_Zoom.Size = new System.Drawing.Size(41, 25);
            this.nvl_Zoom.TabIndex = 16;
            this.nvl_Zoom.Text = "0%";
            this.nvl_Zoom.Click += new System.EventHandler(this.nvl_Zoom_Click);
            // 
            // frm_Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.nvl_Zoom);
            this.Controls.Add(this.nvl_Saturacion);
            this.Controls.Add(this.nvl_Contraste);
            this.Controls.Add(this.nvl_Brillo);
            this.Controls.Add(this.lbl_Contraste);
            this.Controls.Add(this.lbl_Saturacion);
            this.Controls.Add(this.lbl_Zoom);
            this.Controls.Add(this.lbl_Brillo);
            this.Controls.Add(this.tkb_Zoom);
            this.Controls.Add(this.tkb_Saturacion);
            this.Controls.Add(this.tkb_Contraste);
            this.Controls.Add(this.tkb_Brillo);
            this.Controls.Add(this.gbx_Modo);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Reiniciar);
            this.Controls.Add(this.btn_Cargar);
            this.Controls.Add(this.pbx_Procesada);
            this.Controls.Add(this.pbx_Original);
            this.Name = "frm_Imagenes";
            this.Text = "Imagenes";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Procesada)).EndInit();
            this.gbx_Modo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tkb_Brillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_Contraste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_Saturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_Zoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Original;
        private System.Windows.Forms.PictureBox pbx_Procesada;
        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.Button btn_Reiniciar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gbx_Modo;
        private System.Windows.Forms.RadioButton rbt_Expandido;
        private System.Windows.Forms.RadioButton rbt_Zoom;
        private System.Windows.Forms.RadioButton rbt_Normal;
        private System.Windows.Forms.RadioButton rbt_Centrado;
        private System.Windows.Forms.TrackBar tkb_Brillo;
        private System.Windows.Forms.TrackBar tkb_Contraste;
        private System.Windows.Forms.TrackBar tkb_Saturacion;
        private System.Windows.Forms.TrackBar tkb_Zoom;
        private System.Windows.Forms.Label lbl_Brillo;
        private System.Windows.Forms.Label lbl_Zoom;
        private System.Windows.Forms.Label lbl_Saturacion;
        private System.Windows.Forms.Label lbl_Contraste;
        private System.Windows.Forms.Label nvl_Brillo;
        private System.Windows.Forms.Label nvl_Contraste;
        private System.Windows.Forms.Label nvl_Saturacion;
        private System.Windows.Forms.Label nvl_Zoom;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

