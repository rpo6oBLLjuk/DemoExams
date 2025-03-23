namespace DemoExam2024
{
    partial class MainMenuForm
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
            Background = new Panel();
            AuthPanel = new Panel();
            AuthButton = new Button();
            passwordTextBox = new MaskedTextBox();
            loginTextBox = new TextBox();
            PasswordLabel = new Label();
            LoginLabel = new Label();
            TitleLabel = new Label();
            Background.SuspendLayout();
            AuthPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Background
            // 
            Background.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Background.BackColor = SystemColors.Menu;
            Background.Controls.Add(AuthPanel);
            Background.Controls.Add(TitleLabel);
            Background.Location = new Point(0, 0);
            Background.Margin = new Padding(0);
            Background.Name = "Background";
            Background.Size = new Size(782, 453);
            Background.TabIndex = 0;
            // 
            // AuthPanel
            // 
            AuthPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AuthPanel.BackColor = SystemColors.Window;
            AuthPanel.BorderStyle = BorderStyle.FixedSingle;
            AuthPanel.Controls.Add(AuthButton);
            AuthPanel.Controls.Add(passwordTextBox);
            AuthPanel.Controls.Add(loginTextBox);
            AuthPanel.Controls.Add(PasswordLabel);
            AuthPanel.Controls.Add(LoginLabel);
            AuthPanel.Location = new Point(200, 76);
            AuthPanel.Name = "AuthPanel";
            AuthPanel.Size = new Size(400, 350);
            AuthPanel.TabIndex = 1;
            // 
            // AuthButton
            // 
            AuthButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AuthButton.Location = new Point(150, 300);
            AuthButton.Name = "AuthButton";
            AuthButton.Size = new Size(100, 30);
            AuthButton.TabIndex = 4;
            AuthButton.Text = "Auth";
            AuthButton.UseVisualStyleBackColor = true;
            AuthButton.Click += AuthButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(122, 172);
            passwordTextBox.Margin = new Padding(0);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(200, 27);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginTextBox
            // 
            loginTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loginTextBox.Location = new Point(122, 130);
            loginTextBox.Margin = new Padding(0);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(200, 27);
            loginTextBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(18, 172);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(70, 20);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password";
            // 
            // LoginLabel
            // 
            LoginLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(18, 130);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(46, 20);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Login";
            // 
            // TitleLabel
            // 
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Margin = new Padding(0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(782, 453);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Authorization";
            TitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(Background);
            MinimumSize = new Size(800, 500);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            Background.ResumeLayout(false);
            AuthPanel.ResumeLayout(false);
            AuthPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Background;
        private Label TitleLabel;
        private Panel AuthPanel;
        private Label LoginLabel;
        private Label PasswordLabel;
        private MaskedTextBox passwordTextBox;
        private TextBox loginTextBox;
        private Button AuthButton;
    }
}