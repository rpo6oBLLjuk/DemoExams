namespace DemoExam2024.Forms
{
    partial class AdminPanel
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
            TitleLabel = new Label();
            RemoveRequestButton = new Button();
            ShowRequestsButton = new Button();
            AddRequestButton = new Button();
            Background.SuspendLayout();
            SuspendLayout();
            // 
            // Background
            // 
            Background.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Background.BackColor = SystemColors.Menu;
            Background.Controls.Add(ShowRequestsButton);
            Background.Controls.Add(RemoveRequestButton);
            Background.Controls.Add(AddRequestButton);
            Background.Controls.Add(TitleLabel);
            Background.Location = new Point(0, 0);
            Background.Margin = new Padding(0);
            Background.Name = "Background";
            Background.Size = new Size(782, 453);
            Background.TabIndex = 0;
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
            TitleLabel.Text = "Admin panel";
            TitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // RemoveRequestButton
            // 
            RemoveRequestButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            RemoveRequestButton.Location = new Point(300, 282);
            RemoveRequestButton.Name = "RemoveRequestButton";
            RemoveRequestButton.Size = new Size(200, 60);
            RemoveRequestButton.TabIndex = 6;
            RemoveRequestButton.Text = "Remove Request";
            RemoveRequestButton.UseVisualStyleBackColor = true;
            RemoveRequestButton.Click += RemoveRequestButton_Click;
            // 
            // ShowRequestsButton
            // 
            ShowRequestsButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ShowRequestsButton.Location = new Point(300, 216);
            ShowRequestsButton.Name = "ShowRequestsButton";
            ShowRequestsButton.Size = new Size(200, 60);
            ShowRequestsButton.TabIndex = 7;
            ShowRequestsButton.Text = "Show Requests";
            ShowRequestsButton.UseVisualStyleBackColor = true;
            ShowRequestsButton.Click += ShowRequestsButton_Click;
            // 
            // AddRequestButton
            // 
            AddRequestButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddRequestButton.Location = new Point(300, 150);
            AddRequestButton.Name = "AddRequestButton";
            AddRequestButton.Size = new Size(200, 60);
            AddRequestButton.TabIndex = 5;
            AddRequestButton.Text = "Add Request";
            AddRequestButton.UseVisualStyleBackColor = true;
            AddRequestButton.Click += AddRequestButton_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(Background);
            MinimumSize = new Size(800, 500);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            Background.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Background;
        private Label TitleLabel;
        private Button ShowRequestsButton;
        private Button RemoveRequestButton;
        private Button AddRequestButton;
    }
}