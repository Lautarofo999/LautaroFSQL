namespace LautaroFSQL
{
    partial class Cuenta_Bancaria
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumcuenta = new TextBox();
            txtSaldo = new TextBox();
            txtTipo = new TextBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NumCuenta = new DataGridViewTextBoxColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            button1 = new Button();
            txtDepositar = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            txtRetirar = new TextBox();
            label6 = new Label();
            txtTransferencia = new TextBox();
            label7 = new Label();
            txtOrigen = new TextBox();
            txtDestino = new TextBox();
            label8 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 21);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "NumeroCuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 93);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Saldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 178);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo";
            // 
            // txtNumcuenta
            // 
            txtNumcuenta.Location = new Point(26, 48);
            txtNumcuenta.Name = "txtNumcuenta";
            txtNumcuenta.Size = new Size(100, 23);
            txtNumcuenta.TabIndex = 3;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(26, 120);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(100, 23);
            txtSaldo.TabIndex = 4;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(26, 202);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, NumCuenta, Saldo, Tipo });
            dataGridView1.Location = new Point(315, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(453, 213);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // NumCuenta
            // 
            NumCuenta.DataPropertyName = "NumeroCuenta";
            NumCuenta.HeaderText = "NumeroCuenta";
            NumCuenta.Name = "NumCuenta";
            NumCuenta.ReadOnly = true;
            // 
            // Saldo
            // 
            Saldo.DataPropertyName = "Saldo";
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            Saldo.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(150, 106);
            button1.Name = "button1";
            button1.Size = new Size(106, 49);
            button1.TabIndex = 7;
            button1.Text = "Agregar Cuenta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDepositar
            // 
            txtDepositar.Location = new Point(204, 260);
            txtDepositar.Name = "txtDepositar";
            txtDepositar.Size = new Size(100, 23);
            txtDepositar.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 242);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 9;
            label4.Text = "Monto ";
            // 
            // button2
            // 
            button2.Location = new Point(215, 289);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Depositar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(344, 289);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Retirar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 242);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 12;
            label5.Text = "Monto ";
            // 
            // txtRetirar
            // 
            txtRetirar.Location = new Point(333, 260);
            txtRetirar.Name = "txtRetirar";
            txtRetirar.Size = new Size(100, 23);
            txtRetirar.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(568, 242);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 14;
            label6.Text = "Monto a transferir";
            // 
            // txtTransferencia
            // 
            txtTransferencia.Location = new Point(553, 260);
            txtTransferencia.Name = "txtTransferencia";
            txtTransferencia.Size = new Size(134, 23);
            txtTransferencia.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(713, 242);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 16;
            label7.Text = "Id de origen";
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(718, 260);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(54, 23);
            txtOrigen.TabIndex = 17;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(718, 301);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(54, 23);
            txtDestino.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(713, 284);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 18;
            label8.Text = "Id de destino";
            label8.Click += label8_Click;
            // 
            // button4
            // 
            button4.Location = new Point(568, 301);
            button4.Name = "button4";
            button4.Size = new Size(127, 35);
            button4.TabIndex = 20;
            button4.Text = "Transferir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Cuenta_Bancaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(txtDestino);
            Controls.Add(label8);
            Controls.Add(txtOrigen);
            Controls.Add(label7);
            Controls.Add(txtTransferencia);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(txtRetirar);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(txtDepositar);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtTipo);
            Controls.Add(txtSaldo);
            Controls.Add(txtNumcuenta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cuenta_Bancaria";
            Text = "Cuenta_Bancaria";
            Load += Cuenta_Bancaria_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumcuenta;
        private TextBox txtSaldo;
        private TextBox txtTipo;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NumCuenta;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewTextBoxColumn Tipo;
        private TextBox txtDepositar;
        private Label label4;
        private Button button2;
        private Button button3;
        private Label label5;
        private TextBox txtRetirar;
        private Label label6;
        private TextBox txtTransferencia;
        private Label label7;
        private TextBox txtOrigen;
        private TextBox txtDestino;
        private Label label8;
        private Button button4;
    }
}