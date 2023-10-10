namespace LautaroFSQL
{
    partial class Cliente
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
            listBox1 = new ListBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label3 = new Label();
            apellidotxt = new TextBox();
            label4 = new Label();
            dnitxt = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(558, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(179, 199);
            listBox1.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(47, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(118, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 42);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 103);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // apellidotxt
            // 
            apellidotxt.Location = new Point(47, 121);
            apellidotxt.Name = "apellidotxt";
            apellidotxt.Size = new Size(100, 23);
            apellidotxt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 158);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 8;
            label4.Text = "DNI";
            // 
            // dnitxt
            // 
            dnitxt.Location = new Point(47, 176);
            dnitxt.Name = "dnitxt";
            dnitxt.Size = new Size(100, 23);
            dnitxt.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(321, 261);
            button1.Name = "button1";
            button1.Size = new Size(137, 39);
            button1.TabIndex = 9;
            button1.Text = "Agregar Cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(dnitxt);
            Controls.Add(label3);
            Controls.Add(apellidotxt);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(listBox1);
            Name = "Cliente";
            Text = "Cliente";
            Load += Cliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox txtNombre;
        private Label label1;
        private Label label3;
        private TextBox apellidotxt;
        private Label label4;
        private TextBox dnitxt;
        private Button button1;
    }
}