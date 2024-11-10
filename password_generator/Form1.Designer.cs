namespace password_generator
{
    partial class Password_Generator_Label
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password_Generator_Label));
            GeneratePasswordBtn = new Button();
            MyPasswordsBtn = new Button();
            ExitBtn = new Button();
            PasswordGeneratorLabel = new Label();
            SuspendLayout();
            // 
            // GeneratePasswordBtn
            // 
            GeneratePasswordBtn.Anchor = AnchorStyles.None;
            GeneratePasswordBtn.AutoSize = true;
            GeneratePasswordBtn.BackColor = Color.Pink;
            GeneratePasswordBtn.Cursor = Cursors.Hand;
            GeneratePasswordBtn.Font = new Font("Arial Nova Cond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            GeneratePasswordBtn.Location = new Point(395, 102);
            GeneratePasswordBtn.Name = "GeneratePasswordBtn";
            GeneratePasswordBtn.Size = new Size(200, 75);
            GeneratePasswordBtn.TabIndex = 0;
            GeneratePasswordBtn.Text = "Generate Password";
            GeneratePasswordBtn.UseVisualStyleBackColor = false;
            // 
            // MyPasswordsBtn
            // 
            MyPasswordsBtn.Anchor = AnchorStyles.None;
            MyPasswordsBtn.AutoSize = true;
            MyPasswordsBtn.BackColor = Color.Pink;
            MyPasswordsBtn.Cursor = Cursors.Hand;
            MyPasswordsBtn.Font = new Font("Arial Nova Cond", 14.25F, FontStyle.Bold);
            MyPasswordsBtn.Location = new Point(395, 211);
            MyPasswordsBtn.Name = "MyPasswordsBtn";
            MyPasswordsBtn.Size = new Size(200, 75);
            MyPasswordsBtn.TabIndex = 1;
            MyPasswordsBtn.Text = "My Passwords";
            MyPasswordsBtn.UseVisualStyleBackColor = false;
            // 
            // ExitBtn
            // 
            ExitBtn.Anchor = AnchorStyles.None;
            ExitBtn.AutoSize = true;
            ExitBtn.BackColor = Color.Pink;
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.Font = new Font("Arial Nova Cond", 14.25F, FontStyle.Bold);
            ExitBtn.Location = new Point(395, 317);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(200, 75);
            ExitBtn.TabIndex = 2;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // PasswordGeneratorLabel
            // 
            PasswordGeneratorLabel.Anchor = AnchorStyles.None;
            PasswordGeneratorLabel.AutoSize = true;
            PasswordGeneratorLabel.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordGeneratorLabel.Location = new Point(264, 28);
            PasswordGeneratorLabel.Name = "PasswordGeneratorLabel";
            PasswordGeneratorLabel.RightToLeft = RightToLeft.No;
            PasswordGeneratorLabel.Size = new Size(458, 40);
            PasswordGeneratorLabel.TabIndex = 3;
            PasswordGeneratorLabel.Text = "PASSWORD GENERATOR";
            PasswordGeneratorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Password_Generator_Label
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(984, 461);
            Controls.Add(PasswordGeneratorLabel);
            Controls.Add(ExitBtn);
            Controls.Add(MyPasswordsBtn);
            Controls.Add(GeneratePasswordBtn);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Password_Generator_Label";
            Text = "Password Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GeneratePasswordBtn;
        private Button MyPasswordsBtn;
        private Button ExitBtn;
        private Label PasswordGeneratorLabel;
    }
}
