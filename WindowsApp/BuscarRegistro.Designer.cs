namespace WindowsApp
{
    partial class BuscarRegistro
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
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.gboBuscar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboRegistro = new System.Windows.Forms.GroupBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.txtCampus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.gboBuscar.SuspendLayout();
            this.gboRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(102, 40);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(127, 22);
            this.txtMatricula.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(123, 68);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(148, 21);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(150, 22);
            this.txtNombres.TabIndex = 3;
            // 
            // gboBuscar
            // 
            this.gboBuscar.Controls.Add(this.btnBuscar);
            this.gboBuscar.Controls.Add(this.txtMatricula);
            this.gboBuscar.Controls.Add(this.label1);
            this.gboBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboBuscar.Location = new System.Drawing.Point(12, 12);
            this.gboBuscar.Name = "gboBuscar";
            this.gboBuscar.Size = new System.Drawing.Size(324, 100);
            this.gboBuscar.TabIndex = 4;
            this.gboBuscar.TabStop = false;
            this.gboBuscar.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres";
            // 
            // gboRegistro
            // 
            this.gboRegistro.Controls.Add(this.lblCorreo);
            this.gboRegistro.Controls.Add(this.txtCorreo);
            this.gboRegistro.Controls.Add(this.txtGrado);
            this.gboRegistro.Controls.Add(this.lblGrado);
            this.gboRegistro.Controls.Add(this.lblPassword1);
            this.gboRegistro.Controls.Add(this.txtPassword1);
            this.gboRegistro.Controls.Add(this.txtCarrera);
            this.gboRegistro.Controls.Add(this.lblCarrera);
            this.gboRegistro.Controls.Add(this.txtCampus);
            this.gboRegistro.Controls.Add(this.label3);
            this.gboRegistro.Controls.Add(this.txtApellido2);
            this.gboRegistro.Controls.Add(this.lblApellidoM);
            this.gboRegistro.Controls.Add(this.txtApellido1);
            this.gboRegistro.Controls.Add(this.lblApellidoP);
            this.gboRegistro.Controls.Add(this.txtNombres);
            this.gboRegistro.Controls.Add(this.label2);
            this.gboRegistro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboRegistro.Location = new System.Drawing.Point(12, 118);
            this.gboRegistro.Name = "gboRegistro";
            this.gboRegistro.Size = new System.Drawing.Size(324, 254);
            this.gboRegistro.TabIndex = 5;
            this.gboRegistro.TabStop = false;
            this.gboRegistro.Text = "Registro";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(148, 49);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(150, 22);
            this.txtApellido1.TabIndex = 4;
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Location = new System.Drawing.Point(27, 52);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(108, 17);
            this.lblApellidoP.TabIndex = 5;
            this.lblApellidoP.Text = "Apellido Paterno";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(148, 77);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(150, 22);
            this.txtApellido2.TabIndex = 6;
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(27, 82);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(112, 17);
            this.lblApellidoM.TabIndex = 7;
            this.lblApellidoM.Text = "Apellido Materno";
            // 
            // txtCampus
            // 
            this.txtCampus.Location = new System.Drawing.Point(148, 105);
            this.txtCampus.Name = "txtCampus";
            this.txtCampus.Size = new System.Drawing.Size(150, 22);
            this.txtCampus.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Campus";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(148, 133);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(150, 22);
            this.txtCarrera.TabIndex = 10;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(27, 138);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(53, 17);
            this.lblCarrera.TabIndex = 11;
            this.lblCarrera.Text = "Carrera";
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(148, 189);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(150, 22);
            this.txtPassword1.TabIndex = 12;
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.Location = new System.Drawing.Point(27, 194);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(63, 17);
            this.lblPassword1.TabIndex = 13;
            this.lblPassword1.Text = "Password";
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(148, 161);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(150, 22);
            this.txtGrado.TabIndex = 14;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(27, 166);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(46, 17);
            this.lblGrado.TabIndex = 15;
            this.lblGrado.Text = "Grado";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(27, 222);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(49, 17);
            this.lblCorreo.TabIndex = 17;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(148, 217);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(150, 22);
            this.txtCorreo.TabIndex = 16;
            // 
            // BuscarRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 384);
            this.Controls.Add(this.gboRegistro);
            this.Controls.Add(this.gboBuscar);
            this.Name = "BuscarRegistro";
            this.Text = "Buscar Registro";
            this.gboBuscar.ResumeLayout(false);
            this.gboBuscar.PerformLayout();
            this.gboRegistro.ResumeLayout(false);
            this.gboRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.GroupBox gboBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboRegistro;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblPassword1;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtCampus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label lblApellidoP;
    }
}