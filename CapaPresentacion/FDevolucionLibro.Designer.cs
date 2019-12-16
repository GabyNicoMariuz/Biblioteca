namespace CapaPresentacion
{
    partial class FDevolucionLibro
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
            this.bprestamo = new System.Windows.Forms.Button();
            this.tbFD = new System.Windows.Forms.TextBox();
            this.tbFP = new System.Windows.Forms.TextBox();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbPrestamo = new System.Windows.Forms.GroupBox();
            this.tbFActual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lAviso = new System.Windows.Forms.Label();
            this.gbPrestamo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar devolución";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bprestamo
            // 
            this.bprestamo.Location = new System.Drawing.Point(436, 80);
            this.bprestamo.Name = "bprestamo";
            this.bprestamo.Size = new System.Drawing.Size(134, 32);
            this.bprestamo.TabIndex = 1;
            this.bprestamo.Text = "Buscar préstamo";
            this.bprestamo.UseVisualStyleBackColor = true;
            this.bprestamo.Click += new System.EventHandler(this.Bprestamo_Click);
            // 
            // tbFD
            // 
            this.tbFD.Location = new System.Drawing.Point(181, 136);
            this.tbFD.Name = "tbFD";
            this.tbFD.ReadOnly = true;
            this.tbFD.Size = new System.Drawing.Size(100, 26);
            this.tbFD.TabIndex = 6;
            // 
            // tbFP
            // 
            this.tbFP.Location = new System.Drawing.Point(181, 89);
            this.tbFP.Name = "tbFP";
            this.tbFP.ReadOnly = true;
            this.tbFP.Size = new System.Drawing.Size(100, 26);
            this.tbFP.TabIndex = 5;
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(181, 49);
            this.tbNum.Name = "tbNum";
            this.tbNum.ReadOnly = true;
            this.tbNum.Size = new System.Drawing.Size(100, 26);
            this.tbNum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de devolución";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de prestamo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "N° Prestamo";
            // 
            // gbPrestamo
            // 
            this.gbPrestamo.Controls.Add(this.tbFActual);
            this.gbPrestamo.Controls.Add(this.tbFD);
            this.gbPrestamo.Controls.Add(this.tbFP);
            this.gbPrestamo.Controls.Add(this.tbNum);
            this.gbPrestamo.Controls.Add(this.label5);
            this.gbPrestamo.Controls.Add(this.label3);
            this.gbPrestamo.Controls.Add(this.label2);
            this.gbPrestamo.Controls.Add(this.label4);
            this.gbPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrestamo.Location = new System.Drawing.Point(12, 146);
            this.gbPrestamo.Name = "gbPrestamo";
            this.gbPrestamo.Size = new System.Drawing.Size(337, 256);
            this.gbPrestamo.TabIndex = 3;
            this.gbPrestamo.TabStop = false;
            this.gbPrestamo.Text = "Prestamo";
            // 
            // tbFActual
            // 
            this.tbFActual.Location = new System.Drawing.Point(181, 180);
            this.tbFActual.Name = "tbFActual";
            this.tbFActual.ReadOnly = true;
            this.tbFActual.Size = new System.Drawing.Size(100, 26);
            this.tbFActual.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha actual";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrar devolución";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDNI);
            this.groupBox1.Controls.Add(this.tbApellido);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(370, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 256);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Socio";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(132, 173);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.ReadOnly = true;
            this.tbDNI.Size = new System.Drawing.Size(100, 26);
            this.tbDNI.TabIndex = 6;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(132, 116);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.ReadOnly = true;
            this.tbApellido.Size = new System.Drawing.Size(100, 26);
            this.tbApellido.TabIndex = 5;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(132, 55);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(100, 26);
            this.tbNombre.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "DNI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbAutor);
            this.groupBox2.Controls.Add(this.tbGenero);
            this.groupBox2.Controls.Add(this.tbTitulo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(662, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 256);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Libro";
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(132, 173);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.ReadOnly = true;
            this.tbAutor.Size = new System.Drawing.Size(100, 26);
            this.tbAutor.TabIndex = 6;
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(132, 116);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.ReadOnly = true;
            this.tbGenero.Size = new System.Drawing.Size(100, 26);
            this.tbGenero.TabIndex = 5;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(132, 55);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.ReadOnly = true;
            this.tbTitulo.Size = new System.Drawing.Size(100, 26);
            this.tbTitulo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Autor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Género";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Título";
            // 
            // lAviso
            // 
            this.lAviso.AutoSize = true;
            this.lAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAviso.ForeColor = System.Drawing.Color.Red;
            this.lAviso.Location = new System.Drawing.Point(305, 418);
            this.lAviso.Name = "lAviso";
            this.lAviso.Size = new System.Drawing.Size(400, 20);
            this.lAviso.TabIndex = 15;
            this.lAviso.Text = "El ejemplar está siendo devuelto fuera de temino";
            // 
            // FDevolucionLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 559);
            this.Controls.Add(this.lAviso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbPrestamo);
            this.Controls.Add(this.bprestamo);
            this.Controls.Add(this.label1);
            this.Name = "FDevolucionLibro";
            this.Text = "FDevolucionLibro";
            this.gbPrestamo.ResumeLayout(false);
            this.gbPrestamo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bprestamo;
        private System.Windows.Forms.TextBox tbFD;
        private System.Windows.Forms.TextBox tbFP;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbPrestamo;
        private System.Windows.Forms.TextBox tbFActual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lAviso;
    }
}