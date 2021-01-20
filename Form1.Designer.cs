namespace Notaciones
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.expresionTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.resultadoPrefija = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.resultadoPostfija = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.expresionIngresada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Notaciones.Properties.Resources.fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // expresionTxt
            // 
            this.expresionTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.expresionTxt.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.expresionTxt.BorderColorIdle = System.Drawing.Color.DeepSkyBlue;
            this.expresionTxt.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue;
            this.expresionTxt.BorderThickness = 3;
            this.expresionTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expresionTxt.Font = new System.Drawing.Font("Heavitas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expresionTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.expresionTxt.isPassword = false;
            this.expresionTxt.Location = new System.Drawing.Point(233, 161);
            this.expresionTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.expresionTxt.Name = "expresionTxt";
            this.expresionTxt.Size = new System.Drawing.Size(367, 44);
            this.expresionTxt.TabIndex = 2;
            this.expresionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Heavitas", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese la expresión:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.btnConvertir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertir.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConvertir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConvertir.BorderRadius = 0;
            this.btnConvertir.ButtonText = "Convertir";
            this.btnConvertir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertir.DisabledColor = System.Drawing.Color.Gray;
            this.btnConvertir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConvertir.Iconimage = null;
            this.btnConvertir.Iconimage_right = null;
            this.btnConvertir.Iconimage_right_Selected = null;
            this.btnConvertir.Iconimage_Selected = null;
            this.btnConvertir.IconMarginLeft = 0;
            this.btnConvertir.IconMarginRight = 0;
            this.btnConvertir.IconRightVisible = true;
            this.btnConvertir.IconRightZoom = 0D;
            this.btnConvertir.IconVisible = true;
            this.btnConvertir.IconZoom = 90D;
            this.btnConvertir.IsTab = false;
            this.btnConvertir.Location = new System.Drawing.Point(232, 213);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.btnConvertir.OnHovercolor = System.Drawing.Color.Black;
            this.btnConvertir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConvertir.selected = false;
            this.btnConvertir.Size = new System.Drawing.Size(367, 45);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConvertir.Textcolor = System.Drawing.Color.White;
            this.btnConvertir.TextFont = new System.Drawing.Font("Heavitas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Heavitas", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultados";
            // 
            // resultadoPrefija
            // 
            this.resultadoPrefija.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resultadoPrefija.AutoSize = true;
            this.resultadoPrefija.BackColor = System.Drawing.Color.White;
            this.resultadoPrefija.Font = new System.Drawing.Font("Heavitas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoPrefija.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.resultadoPrefija.Location = new System.Drawing.Point(229, 405);
            this.resultadoPrefija.Name = "resultadoPrefija";
            this.resultadoPrefija.Size = new System.Drawing.Size(189, 21);
            this.resultadoPrefija.TabIndex = 6;
            this.resultadoPrefija.Text = "Resultado prefija";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Heavitas", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Postfija:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(318, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 2);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Heavitas", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Prefija:";
            // 
            // resultadoPostfija
            // 
            this.resultadoPostfija.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resultadoPostfija.AutoSize = true;
            this.resultadoPostfija.BackColor = System.Drawing.Color.White;
            this.resultadoPostfija.Font = new System.Drawing.Font("Heavitas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoPostfija.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.resultadoPostfija.Location = new System.Drawing.Point(229, 463);
            this.resultadoPostfija.Name = "resultadoPostfija";
            this.resultadoPostfija.Size = new System.Drawing.Size(201, 21);
            this.resultadoPostfija.TabIndex = 10;
            this.resultadoPostfija.Text = "resultado postfija";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Heavitas", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Expresión ingresada:";
            // 
            // expresionIngresada
            // 
            this.expresionIngresada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.expresionIngresada.AutoSize = true;
            this.expresionIngresada.BackColor = System.Drawing.Color.White;
            this.expresionIngresada.Font = new System.Drawing.Font("Heavitas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expresionIngresada.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.expresionIngresada.Location = new System.Drawing.Point(226, 351);
            this.expresionIngresada.Name = "expresionIngresada";
            this.expresionIngresada.Size = new System.Drawing.Size(109, 21);
            this.expresionIngresada.TabIndex = 11;
            this.expresionIngresada.Text = "Expresión";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expresionIngresada);
            this.Controls.Add(this.resultadoPostfija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultadoPrefija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expresionTxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox expresionTxt;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnConvertir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultadoPrefija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultadoPostfija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label expresionIngresada;
    }
}

