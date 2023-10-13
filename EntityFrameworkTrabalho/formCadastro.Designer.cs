namespace EntityFrameworkTrabalho
{
    partial class formCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastro));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 140);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(276, 140);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(69, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(347, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 192);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(276, 247);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 27);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 250);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 4;
            label3.Text = "Data de Nascimento";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(276, 298);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(175, 27);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 298);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 6;
            label4.Text = "Estado Civil";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(276, 360);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(347, 27);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(183, 367);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(276, 422);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(158, 27);
            textBox6.TabIndex = 11;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(173, 422);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 10;
            label6.Text = "Telefone";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(276, 478);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(347, 27);
            textBox7.TabIndex = 13;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(173, 478);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 12;
            label7.Text = "Cidade";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(932, 27);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "Salvar";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(73, 24);
            toolStripButton1.Text = "Salvar";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(76, 24);
            toolStripButton2.Text = "Excluir";
            toolStripButton2.Visible = false;
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // formCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 594);
            Controls.Add(toolStrip1);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "formCadastro";
            Text = "Cadastro de Formulário";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
    }
}