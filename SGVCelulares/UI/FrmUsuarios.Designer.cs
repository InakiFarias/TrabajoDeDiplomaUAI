namespace UI
{
    partial class FrmUsuarios
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
            grillaUsuarios = new DataGridView();
            label1 = new Label();
            btnCrearUsuario = new Button();
            btnDesbloquearUsuario = new Button();
            btnModificarUsuario = new Button();
            btnActivarUsuario = new Button();
            btnAplicarCambios = new Button();
            btnCancelarCambios = new Button();
            btnSalir = new Button();
            lblNumeroUsuarios = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            label5 = new Label();
            txtNombreUsuario = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)grillaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // grillaUsuarios
            // 
            grillaUsuarios.AllowUserToAddRows = false;
            grillaUsuarios.AllowUserToDeleteRows = false;
            grillaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaUsuarios.Location = new Point(32, 102);
            grillaUsuarios.Name = "grillaUsuarios";
            grillaUsuarios.ReadOnly = true;
            grillaUsuarios.Size = new Size(787, 197);
            grillaUsuarios.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 53);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 1;
            label1.Text = "USUARIOS";
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Location = new Point(839, 104);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(148, 23);
            btnCrearUsuario.TabIndex = 2;
            btnCrearUsuario.Text = "Crear";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // btnDesbloquearUsuario
            // 
            btnDesbloquearUsuario.Location = new Point(839, 133);
            btnDesbloquearUsuario.Name = "btnDesbloquearUsuario";
            btnDesbloquearUsuario.Size = new Size(148, 23);
            btnDesbloquearUsuario.TabIndex = 3;
            btnDesbloquearUsuario.Text = "Desbloquear";
            btnDesbloquearUsuario.UseVisualStyleBackColor = true;
            btnDesbloquearUsuario.Click += btnDesbloquearUsuario_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(839, 162);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(148, 23);
            btnModificarUsuario.TabIndex = 4;
            btnModificarUsuario.Text = "Modificar";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // btnActivarUsuario
            // 
            btnActivarUsuario.Location = new Point(839, 191);
            btnActivarUsuario.Name = "btnActivarUsuario";
            btnActivarUsuario.Size = new Size(148, 23);
            btnActivarUsuario.TabIndex = 5;
            btnActivarUsuario.Text = "Activar/Desactivar";
            btnActivarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAplicarCambios
            // 
            btnAplicarCambios.Location = new Point(839, 220);
            btnAplicarCambios.Name = "btnAplicarCambios";
            btnAplicarCambios.Size = new Size(148, 23);
            btnAplicarCambios.TabIndex = 6;
            btnAplicarCambios.Text = "Aplicar";
            btnAplicarCambios.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCambios
            // 
            btnCancelarCambios.Location = new Point(839, 249);
            btnCancelarCambios.Name = "btnCancelarCambios";
            btnCancelarCambios.Size = new Size(148, 23);
            btnCancelarCambios.TabIndex = 7;
            btnCancelarCambios.Text = "Cancelar";
            btnCancelarCambios.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(839, 278);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(148, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblNumeroUsuarios
            // 
            lblNumeroUsuarios.AutoSize = true;
            lblNumeroUsuarios.Location = new Point(839, 63);
            lblNumeroUsuarios.Name = "lblNumeroUsuarios";
            lblNumeroUsuarios.Size = new Size(117, 15);
            lblNumeroUsuarios.TabIndex = 9;
            lblNumeroUsuarios.Text = "Número de usuarios:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(413, 77);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(64, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Activos";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(483, 77);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(56, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Todos";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 325);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 12;
            label2.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(148, 322);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(177, 23);
            txtDni.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(148, 351);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(177, 23);
            txtNombre.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 354);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 14;
            label3.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(148, 380);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(177, 23);
            txtApellido.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 383);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 16;
            label4.Text = "Apellido";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(148, 409);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(177, 23);
            txtCorreo.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 412);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 18;
            label5.Text = "Correo";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(148, 438);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(177, 23);
            txtNombreUsuario.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 441);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 20;
            label6.Text = "Nombre Usuario";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 484);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(lblNumeroUsuarios);
            Controls.Add(btnSalir);
            Controls.Add(btnCancelarCambios);
            Controls.Add(btnAplicarCambios);
            Controls.Add(btnActivarUsuario);
            Controls.Add(btnModificarUsuario);
            Controls.Add(btnDesbloquearUsuario);
            Controls.Add(btnCrearUsuario);
            Controls.Add(label1);
            Controls.Add(grillaUsuarios);
            Name = "FrmUsuarios";
            Text = "Usuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)grillaUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaUsuarios;
        private Label label1;
        private Button btnCrearUsuario;
        private Button btnDesbloquearUsuario;
        private Button btnModificarUsuario;
        private Button btnActivarUsuario;
        private Button btnAplicarCambios;
        private Button btnCancelarCambios;
        private Button btnSalir;
        private Label lblNumeroUsuarios;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private TextBox txtDni;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtCorreo;
        private Label label5;
        private TextBox txtNombreUsuario;
        private Label label6;
    }
}