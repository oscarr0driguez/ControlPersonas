
namespace ControlPersonas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDpi = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.TxtApe = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnIngreso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LblDpi = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.LblApe = new System.Windows.Forms.Label();
            this.LblFe = new System.Windows.Forms.Label();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnMayu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LblEdad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DPI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // TxtDpi
            // 
            this.TxtDpi.Location = new System.Drawing.Point(179, 43);
            this.TxtDpi.Name = "TxtDpi";
            this.TxtDpi.Size = new System.Drawing.Size(100, 20);
            this.TxtDpi.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // TxtApe
            // 
            this.TxtApe.Location = new System.Drawing.Point(179, 104);
            this.TxtApe.Name = "TxtApe";
            this.TxtApe.Size = new System.Drawing.Size(100, 20);
            this.TxtApe.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.Location = new System.Drawing.Point(62, 247);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(151, 23);
            this.BtnIngreso.TabIndex = 8;
            this.BtnIngreso.Text = "Ingresar Personas";
            this.BtnIngreso.UseVisualStyleBackColor = true;
            this.BtnIngreso.Click += new System.EventHandler(this.BtnIngreso_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblDpi
            // 
            this.LblDpi.AutoSize = true;
            this.LblDpi.Location = new System.Drawing.Point(489, 43);
            this.LblDpi.Name = "LblDpi";
            this.LblDpi.Size = new System.Drawing.Size(35, 13);
            this.LblDpi.TabIndex = 10;
            this.LblDpi.Text = "label5";
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(489, 75);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(35, 13);
            this.LblNom.TabIndex = 11;
            this.LblNom.Text = "label6";
            // 
            // LblApe
            // 
            this.LblApe.AutoSize = true;
            this.LblApe.Location = new System.Drawing.Point(489, 104);
            this.LblApe.Name = "LblApe";
            this.LblApe.Size = new System.Drawing.Size(35, 13);
            this.LblApe.TabIndex = 12;
            this.LblApe.Text = "label7";
            // 
            // LblFe
            // 
            this.LblFe.AutoSize = true;
            this.LblFe.Location = new System.Drawing.Point(489, 142);
            this.LblFe.Name = "LblFe";
            this.LblFe.Size = new System.Drawing.Size(35, 13);
            this.LblFe.TabIndex = 13;
            this.LblFe.Text = "label8";
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(235, 247);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 14;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnMayu
            // 
            this.BtnMayu.Location = new System.Drawing.Point(62, 286);
            this.BtnMayu.Name = "BtnMayu";
            this.BtnMayu.Size = new System.Drawing.Size(151, 23);
            this.BtnMayu.TabIndex = 15;
            this.BtnMayu.Text = "Primera Mayuscula";
            this.BtnMayu.UseVisualStyleBackColor = true;
            this.BtnMayu.Click += new System.EventHandler(this.BtnMayu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Edad";
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Location = new System.Drawing.Point(492, 182);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(35, 13);
            this.LblEdad.TabIndex = 18;
            this.LblEdad.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblEdad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnMayu);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.LblFe);
            this.Controls.Add(this.LblApe);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.LblDpi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnIngreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TxtApe);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.TxtDpi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDpi;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox TxtApe;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnIngreso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblDpi;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblApe;
        private System.Windows.Forms.Label LblFe;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnMayu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblEdad;
    }
}

