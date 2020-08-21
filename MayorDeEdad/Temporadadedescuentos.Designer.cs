namespace MayorDeEdad
{
    partial class Temporadadedescuentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pBHalloween = new System.Windows.Forms.PictureBox();
            this.pBDiciembre = new System.Windows.Forms.PictureBox();
            this.pBEscolar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBHalloween)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDiciembre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBEscolar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temporada de grandes descuentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escoje una imagen segun la temporada";
            // 
            // pBHalloween
            // 
            this.pBHalloween.Image = global::MayorDeEdad.Properties.Resources.Halloween;
            this.pBHalloween.Location = new System.Drawing.Point(296, 167);
            this.pBHalloween.Name = "pBHalloween";
            this.pBHalloween.Size = new System.Drawing.Size(211, 173);
            this.pBHalloween.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHalloween.TabIndex = 6;
            this.pBHalloween.TabStop = false;
            this.pBHalloween.Click += new System.EventHandler(this.pBHalloween_Click);
            // 
            // pBDiciembre
            // 
            this.pBDiciembre.Image = global::MayorDeEdad.Properties.Resources.diciembre;
            this.pBDiciembre.Location = new System.Drawing.Point(545, 167);
            this.pBDiciembre.Name = "pBDiciembre";
            this.pBDiciembre.Size = new System.Drawing.Size(223, 173);
            this.pBDiciembre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBDiciembre.TabIndex = 5;
            this.pBDiciembre.TabStop = false;
            this.pBDiciembre.Click += new System.EventHandler(this.pBDiciembre_Click);
            // 
            // pBEscolar
            // 
            this.pBEscolar.Image = global::MayorDeEdad.Properties.Resources.Escolar;
            this.pBEscolar.Location = new System.Drawing.Point(30, 167);
            this.pBEscolar.Name = "pBEscolar";
            this.pBEscolar.Size = new System.Drawing.Size(230, 173);
            this.pBEscolar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBEscolar.TabIndex = 4;
            this.pBEscolar.TabStop = false;
            this.pBEscolar.Click += new System.EventHandler(this.pBEscolar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(341, 364);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 74);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Temporadadedescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pBHalloween);
            this.Controls.Add(this.pBDiciembre);
            this.Controls.Add(this.pBEscolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Temporadadedescuentos";
            this.Text = "Temporadadedescuentos";
            ((System.ComponentModel.ISupportInitialize)(this.pBHalloween)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDiciembre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBEscolar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pBEscolar;
        private System.Windows.Forms.PictureBox pBDiciembre;
        private System.Windows.Forms.PictureBox pBHalloween;
        private System.Windows.Forms.Button btnSalir;
    }
}