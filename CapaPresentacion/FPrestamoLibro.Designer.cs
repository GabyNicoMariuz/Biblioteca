namespace CapaPresentacion
{
    partial class FPrestamoLibro
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
            this.lTitulo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbLibro = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbEjemplares = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbSocio = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gbLibro.SuspendLayout();
            this.gbSocio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(288, 44);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(275, 24);
            this.lTitulo.TabIndex = 0;
            this.lTitulo.Text = "Seleccionar fecha del prestamo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(313, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // gbLibro
            // 
            this.gbLibro.Controls.Add(this.button1);
            this.gbLibro.Controls.Add(this.tbEjemplares);
            this.gbLibro.Controls.Add(this.tbAutor);
            this.gbLibro.Controls.Add(this.tbGenero);
            this.gbLibro.Controls.Add(this.tbTitulo);
            this.gbLibro.Controls.Add(this.label4);
            this.gbLibro.Controls.Add(this.label3);
            this.gbLibro.Controls.Add(this.label2);
            this.gbLibro.Controls.Add(this.label1);
            this.gbLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLibro.Location = new System.Drawing.Point(30, 156);
            this.gbLibro.Name = "gbLibro";
            this.gbLibro.Size = new System.Drawing.Size(390, 306);
            this.gbLibro.TabIndex = 2;
            this.gbLibro.TabStop = false;
            this.gbLibro.Text = "Libro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "Seleccionar un libro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbEjemplares
            // 
            this.tbEjemplares.Location = new System.Drawing.Point(223, 180);
            this.tbEjemplares.Name = "tbEjemplares";
            this.tbEjemplares.ReadOnly = true;
            this.tbEjemplares.Size = new System.Drawing.Size(100, 26);
            this.tbEjemplares.TabIndex = 7;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(115, 133);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.ReadOnly = true;
            this.tbAutor.Size = new System.Drawing.Size(100, 26);
            this.tbAutor.TabIndex = 6;
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(115, 89);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.ReadOnly = true;
            this.tbGenero.Size = new System.Drawing.Size(100, 26);
            this.tbGenero.TabIndex = 5;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(115, 40);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.ReadOnly = true;
            this.tbTitulo.Size = new System.Drawing.Size(100, 26);
            this.tbTitulo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ejemplares disponibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Género";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 56);
            this.button2.TabIndex = 8;
            this.button2.Text = "Seleccionar un Socio";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(133, 148);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 26);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(133, 104);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 26);
            this.textBox7.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(133, 55);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 26);
            this.textBox8.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "DNI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre";
            // 
            // gbSocio
            // 
            this.gbSocio.Controls.Add(this.button2);
            this.gbSocio.Controls.Add(this.textBox6);
            this.gbSocio.Controls.Add(this.textBox7);
            this.gbSocio.Controls.Add(this.textBox8);
            this.gbSocio.Controls.Add(this.label6);
            this.gbSocio.Controls.Add(this.label7);
            this.gbSocio.Controls.Add(this.label8);
            this.gbSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSocio.Location = new System.Drawing.Point(470, 156);
            this.gbSocio.Name = "gbSocio";
            this.gbSocio.Size = new System.Drawing.Size(390, 306);
            this.gbSocio.TabIndex = 3;
            this.gbSocio.TabStop = false;
            this.gbSocio.Text = "Socio";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(253, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(521, 533);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 39);
            this.button4.TabIndex = 5;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // FPrestamoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 613);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gbSocio);
            this.Controls.Add(this.gbLibro);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lTitulo);
            this.Name = "FPrestamoLibro";
            this.Text = "FPrestamoLibro";
            this.gbLibro.ResumeLayout(false);
            this.gbLibro.PerformLayout();
            this.gbSocio.ResumeLayout(false);
            this.gbSocio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbLibro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEjemplares;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbSocio;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}