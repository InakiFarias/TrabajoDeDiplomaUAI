namespace UI
{
    partial class FrmVenta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            textBox6 = new TextBox();
            groupBox3 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(220, 47);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(326, 47);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 29);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 29);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 29);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 29);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 7;
            label4.Text = "Telefono";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 90);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "CLIENTE";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(432, 47);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(432, 29);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(669, 245);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seleccion de productos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Modelo, Marca, Stock, Precio, Cantidad });
            dataGridView1.Location = new Point(8, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(641, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(8, 41);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(248, 23);
            textBox6.TabIndex = 1;
            textBox6.Text = "Buscar producto";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(20, 413);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(402, 137);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Metodo de pago";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 46);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 0;
            label6.Text = "Tarjeta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(286, 46);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 1;
            label7.Text = "Mercado pago";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 88);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 2;
            label8.Text = "Efectivo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(298, 88);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 3;
            label9.Text = "Cuotas";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(label21);
            groupBox4.Controls.Add(label22);
            groupBox4.Controls.Add(label23);
            groupBox4.Controls.Add(label24);
            groupBox4.Controls.Add(label25);
            groupBox4.Controls.Add(label26);
            groupBox4.Controls.Add(label27);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(803, 143);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 365);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Resumen";
            // 
            // button1
            // 
            button1.Location = new Point(6, 302);
            button1.Name = "button1";
            button1.Size = new Size(188, 23);
            button1.TabIndex = 0;
            button1.Text = "Confirmar venta";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 331);
            button2.Name = "button2";
            button2.Size = new Size(188, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 26);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 2;
            label10.Text = "Bla: dawddwa";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 41);
            label11.Name = "label11";
            label11.Size = new Size(80, 15);
            label11.TabIndex = 3;
            label11.Text = "Bla: dawddwa";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 56);
            label12.Name = "label12";
            label12.Size = new Size(80, 15);
            label12.TabIndex = 4;
            label12.Text = "Bla: dawddwa";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 71);
            label13.Name = "label13";
            label13.Size = new Size(80, 15);
            label13.TabIndex = 5;
            label13.Text = "Bla: dawddwa";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 86);
            label14.Name = "label14";
            label14.Size = new Size(80, 15);
            label14.TabIndex = 6;
            label14.Text = "Bla: dawddwa";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(16, 101);
            label15.Name = "label15";
            label15.Size = new Size(80, 15);
            label15.TabIndex = 7;
            label15.Text = "Bla: dawddwa";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(16, 116);
            label16.Name = "label16";
            label16.Size = new Size(80, 15);
            label16.TabIndex = 8;
            label16.Text = "Bla: dawddwa";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(16, 146);
            label17.Name = "label17";
            label17.Size = new Size(80, 15);
            label17.TabIndex = 9;
            label17.Text = "Bla: dawddwa";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(16, 131);
            label18.Name = "label18";
            label18.Size = new Size(80, 15);
            label18.TabIndex = 9;
            label18.Text = "Bla: dawddwa";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(16, 266);
            label19.Name = "label19";
            label19.Size = new Size(80, 15);
            label19.TabIndex = 17;
            label19.Text = "Bla: dawddwa";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(16, 281);
            label20.Name = "label20";
            label20.Size = new Size(80, 15);
            label20.TabIndex = 18;
            label20.Text = "Bla: dawddwa";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(16, 251);
            label21.Name = "label21";
            label21.Size = new Size(80, 15);
            label21.TabIndex = 16;
            label21.Text = "Bla: dawddwa";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(16, 236);
            label22.Name = "label22";
            label22.Size = new Size(80, 15);
            label22.TabIndex = 15;
            label22.Text = "Bla: dawddwa";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(16, 221);
            label23.Name = "label23";
            label23.Size = new Size(80, 15);
            label23.TabIndex = 14;
            label23.Text = "Bla: dawddwa";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(16, 206);
            label24.Name = "label24";
            label24.Size = new Size(80, 15);
            label24.TabIndex = 13;
            label24.Text = "Bla: dawddwa";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(16, 191);
            label25.Name = "label25";
            label25.Size = new Size(80, 15);
            label25.TabIndex = 12;
            label25.Text = "Bla: dawddwa";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(16, 176);
            label26.Name = "label26";
            label26.Size = new Size(80, 15);
            label26.TabIndex = 11;
            label26.Text = "Bla: dawddwa";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(16, 161);
            label27.Name = "label27";
            label27.Size = new Size(80, 15);
            label27.TabIndex = 10;
            label27.Text = "Bla: dawddwa";
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 631);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmVenta";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private Label label5;
        private GroupBox groupBox2;
        private TextBox textBox6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private GroupBox groupBox3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private GroupBox groupBox4;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button button2;
        private Button button1;
    }
}
