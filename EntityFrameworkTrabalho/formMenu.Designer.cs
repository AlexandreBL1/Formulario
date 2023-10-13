namespace EntityFrameworkTrabalho
{
    partial class formMenu
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
        DataContext dataContext = new DataContext();
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button3 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(369, 264);
            button3.Name = "button3";
            button3.Size = new Size(391, 98);
            button3.TabIndex = 2;
            button3.Text = "Formulário";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // formMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 671);
            Controls.Add(button3);
            Name = "formMenu";
            Text = "Formulário";
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
    }
}