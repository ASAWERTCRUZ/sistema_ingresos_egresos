namespace sistema_ingresos_egresos
{
    partial class InicioSecion
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(80, 48);
            label1.Name = "label1";
            label1.Size = new Size(259, 30);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SECION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(149, 148);
            label2.Name = "label2";
            label2.Size = new Size(117, 30);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(80, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(80, 355);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 39);
            textBox2.TabIndex = 5;
            textBox2.Text = "\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 Blk BT", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(118, 301);
            label3.Name = "label3";
            label3.Size = new Size(171, 30);
            label3.TabIndex = 6;
            label3.Text = "Contraseña";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Swis721 Blk BT", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(118, 450);
            button1.Name = "button1";
            button1.Size = new Size(163, 52);
            button1.TabIndex = 7;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // InicioSecion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 577);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InicioSecion";
            Text = "InicioSecion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
    }
}