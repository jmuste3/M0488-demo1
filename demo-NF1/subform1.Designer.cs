namespace demo_NF1
{
    partial class subform1
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
            button1 = new Button();
            PASSWORD = new TextBox();
            USUARI = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(106, 128);
            label1.TabIndex = 0;
            label1.Text = "1";
            // 
            // button1
            // 
            button1.Location = new Point(280, 136);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            // 
            // PASSWORD
            // 
            PASSWORD.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PASSWORD.ForeColor = Color.Red;
            PASSWORD.Location = new Point(267, 80);
            PASSWORD.Name = "PASSWORD";
            PASSWORD.Size = new Size(100, 41);
            PASSWORD.TabIndex = 8;
            PASSWORD.Text = "usuari";
            PASSWORD.UseSystemPasswordChar = true;
            // 
            // USUARI
            // 
            USUARI.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            USUARI.ForeColor = Color.Red;
            USUARI.Location = new Point(267, 33);
            USUARI.Name = "USUARI";
            USUARI.Size = new Size(100, 41);
            USUARI.TabIndex = 7;
            USUARI.Text = "usuari";
            // 
            // subform1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(button1);
            Controls.Add(PASSWORD);
            Controls.Add(USUARI);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "subform1";
            Text = "subform1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox PASSWORD;
        private TextBox USUARI;
    }
}