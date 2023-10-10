namespace LautaroFSQL
{
    partial class Tarjeta_de_Credito
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
            button1 = new Button();
            comboEstado = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMonto = new TextBox();
            txtSaldo = new TextBox();
            txtCredito = new TextBox();
            txtNumeroTar = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            txtMontoPag = new TextBox();
            button5 = new Button();
            button6 = new Button();
            Id = new DataGridViewTextBoxColumn();
            NumeroTarjeta = new DataGridViewTextBoxColumn();
            SaldoDisponible = new DataGridViewTextBoxColumn();
            MontoDeuda = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            LimiteCredito = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(25, 332);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // comboEstado
            // 
            comboEstado.FormattingEnabled = true;
            comboEstado.Items.AddRange(new object[] { "Activa", "Pausada", "Bloquear" });
            comboEstado.Location = new Point(25, 228);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(150, 23);
            comboEstado.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 157);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 50;
            label5.Text = "MontoDeuda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 210);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 49;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 113);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 48;
            label3.Text = "SaldoDisponible";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 69);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 47;
            label2.Text = "LimiteCredito";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 46;
            label1.Text = "NumeroTarjeta";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(25, 184);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(150, 23);
            txtMonto.TabIndex = 45;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(25, 131);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(150, 23);
            txtSaldo.TabIndex = 44;
            // 
            // txtCredito
            // 
            txtCredito.Location = new Point(25, 87);
            txtCredito.Name = "txtCredito";
            txtCredito.Size = new Size(150, 23);
            txtCredito.TabIndex = 43;
            // 
            // txtNumeroTar
            // 
            txtNumeroTar.Location = new Point(25, 43);
            txtNumeroTar.Name = "txtNumeroTar";
            txtNumeroTar.Size = new Size(150, 23);
            txtNumeroTar.TabIndex = 42;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, NumeroTarjeta, SaldoDisponible, MontoDeuda, Estado, LimiteCredito });
            dataGridView1.Location = new Point(194, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(591, 169);
            dataGridView1.TabIndex = 52;
            // 
            // button2
            // 
            button2.Location = new Point(254, 241);
            button2.Name = "button2";
            button2.Size = new Size(90, 31);
            button2.TabIndex = 53;
            button2.Text = "Pausar Tarjeta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(254, 278);
            button3.Name = "button3";
            button3.Size = new Size(90, 39);
            button3.TabIndex = 54;
            button3.Text = "Bloquear Tarjeta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(254, 200);
            button4.Name = "button4";
            button4.Size = new Size(90, 35);
            button4.TabIndex = 55;
            button4.Text = "Activar Tarjeta";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(457, 210);
            label6.Name = "label6";
            label6.Size = new Size(128, 15);
            label6.TabIndex = 56;
            label6.Text = "Monto que debe pagar";
            // 
            // txtMontoPag
            // 
            txtMontoPag.Location = new Point(469, 228);
            txtMontoPag.Name = "txtMontoPag";
            txtMontoPag.Size = new Size(100, 23);
            txtMontoPag.TabIndex = 57;
            // 
            // button5
            // 
            button5.Location = new Point(469, 257);
            button5.Name = "button5";
            button5.Size = new Size(100, 48);
            button5.TabIndex = 58;
            button5.Text = "Pagar monto";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(666, 278);
            button6.Name = "button6";
            button6.Size = new Size(119, 67);
            button6.TabIndex = 59;
            button6.Text = "Resumen de la Tarjeta";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // NumeroTarjeta
            // 
            NumeroTarjeta.DataPropertyName = "NumeroTarjeta";
            NumeroTarjeta.HeaderText = "NumeroTarjeta";
            NumeroTarjeta.Name = "NumeroTarjeta";
            NumeroTarjeta.ReadOnly = true;
            // 
            // SaldoDisponible
            // 
            SaldoDisponible.DataPropertyName = "SaldoDisponible";
            SaldoDisponible.HeaderText = "SaldoDisponible";
            SaldoDisponible.Name = "SaldoDisponible";
            SaldoDisponible.ReadOnly = true;
            // 
            // MontoDeuda
            // 
            MontoDeuda.DataPropertyName = "MontoDeuda";
            MontoDeuda.HeaderText = "MontoDeuda";
            MontoDeuda.Name = "MontoDeuda";
            MontoDeuda.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // LimiteCredito
            // 
            LimiteCredito.DataPropertyName = "LimiteCredito";
            LimiteCredito.HeaderText = "LimiteCredito";
            LimiteCredito.Name = "LimiteCredito";
            LimiteCredito.ReadOnly = true;
            // 
            // Tarjeta_de_Credito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(txtMontoPag);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(comboEstado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMonto);
            Controls.Add(txtSaldo);
            Controls.Add(txtCredito);
            Controls.Add(txtNumeroTar);
            Controls.Add(button1);
            Name = "Tarjeta_de_Credito";
            Text = "Tarjeta_de_Credito";
            Load += Tarjeta_de_Credito_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboEstado;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMonto;
        private TextBox txtSaldo;
        private TextBox txtCredito;
        private TextBox txtNumeroTar;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label6;
        private TextBox txtMontoPag;
        private Button button5;
        private Button button6;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NumeroTarjeta;
        private DataGridViewTextBoxColumn SaldoDisponible;
        private DataGridViewTextBoxColumn MontoDeuda;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn LimiteCredito;
    }
}