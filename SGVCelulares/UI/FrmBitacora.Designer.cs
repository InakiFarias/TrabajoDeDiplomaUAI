namespace UI
{
    partial class FrmBitacora
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
            grillaBitacora = new DataGridView();
            label1 = new Label();
            btnSalir = new Button();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbxModulo = new ComboBox();
            cbxEvento = new ComboBox();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            txtNombreUsuario = new TextBox();
            cbxCriticidad = new ComboBox();
            btnAplicar = new Button();
            btnLimpiar = new Button();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaBitacora).BeginInit();
            SuspendLayout();
            // 
            // grillaBitacora
            // 
            grillaBitacora.AllowUserToAddRows = false;
            grillaBitacora.AllowUserToDeleteRows = false;
            grillaBitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaBitacora.Location = new Point(40, 64);
            grillaBitacora.Name = "grillaBitacora";
            grillaBitacora.ReadOnly = true;
            grillaBitacora.Size = new Size(807, 216);
            grillaBitacora.TabIndex = 0;
            grillaBitacora.SelectionChanged += grillaBitacora_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 36);
            label1.Name = "label1";
            label1.Size = new Size(221, 25);
            label1.TabIndex = 1;
            label1.Text = "BITÁCORA DE EVENTOS";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(723, 36);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(124, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 299);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(462, 299);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(240, 296);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(126, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(533, 296);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(126, 23);
            txtApellido.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 356);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "LOGIN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 412);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 8;
            label5.Text = "MÓDULO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 356);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 9;
            label6.Text = "FECHA INICIO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 415);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 10;
            label7.Text = "EVENTO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(617, 356);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 11;
            label8.Text = "FECHA FIN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(617, 412);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 12;
            label9.Text = "CRITICIDAD";
            // 
            // cbxModulo
            // 
            cbxModulo.FormattingEnabled = true;
            cbxModulo.Location = new Point(173, 409);
            cbxModulo.Name = "cbxModulo";
            cbxModulo.Size = new Size(148, 23);
            cbxModulo.TabIndex = 13;
            // 
            // cbxEvento
            // 
            cbxEvento.FormattingEnabled = true;
            cbxEvento.Location = new Point(426, 407);
            cbxEvento.Name = "cbxEvento";
            cbxEvento.Size = new Size(148, 23);
            cbxEvento.TabIndex = 14;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(699, 350);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(148, 23);
            dtpFechaFin.TabIndex = 16;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(426, 350);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(148, 23);
            dtpFechaInicio.TabIndex = 17;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(173, 356);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(148, 23);
            txtNombreUsuario.TabIndex = 18;
            // 
            // cbxCriticidad
            // 
            cbxCriticidad.FormattingEnabled = true;
            cbxCriticidad.Location = new Point(699, 407);
            cbxCriticidad.Name = "cbxCriticidad";
            cbxCriticidad.Size = new Size(148, 23);
            cbxCriticidad.TabIndex = 19;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(853, 200);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(124, 23);
            btnAplicar.TabIndex = 21;
            btnAplicar.Text = "APLICAR";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(853, 229);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(124, 23);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(853, 258);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(124, 23);
            btnImprimir.TabIndex = 23;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // FrmBitacora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 459);
            Controls.Add(btnImprimir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAplicar);
            Controls.Add(cbxCriticidad);
            Controls.Add(txtNombreUsuario);
            Controls.Add(dtpFechaInicio);
            Controls.Add(dtpFechaFin);
            Controls.Add(cbxEvento);
            Controls.Add(cbxModulo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(grillaBitacora);
            Name = "FrmBitacora";
            Text = "Bitácora";
            Load += FrmBitacora_Load;
            ((System.ComponentModel.ISupportInitialize)grillaBitacora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaBitacora;
        private Label label1;
        private Button btnSalir;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cbxModulo;
        private ComboBox cbxEvento;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private TextBox txtNombreUsuario;
        private ComboBox cbxCriticidad;
        private Button btnAplicar;
        private Button btnLimpiar;
        private Button btnImprimir;
    }
}