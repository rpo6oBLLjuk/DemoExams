namespace DemoExam2024.Forms.Admin
{
    partial class RemoveRequest
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
            RemoveRequestText = new MaskedTextBox();
            RemoveRequestButton = new Button();
            requestLabel = new Label();
            TitleLabel = new Label();
            Background.SuspendLayout();
            SuspendLayout();
            // 
            // Background
            // 
            Background.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Background.BackColor = SystemColors.Menu;
            Background.Controls.Add(RemoveRequestText);
            Background.Controls.Add(RemoveRequestButton);
            Background.Controls.Add(requestLabel);
            Background.Controls.Add(TitleLabel);
            Background.Location = new Point(0, 0);
            Background.Margin = new Padding(0);
            Background.Name = "Background";
            Background.Size = new Size(782, 453);
            Background.TabIndex = 0;
            // 
            // RemoveRequestText
            // 
            RemoveRequestText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveRequestText.Location = new Point(250, 200);
            RemoveRequestText.Mask = "00000";
            RemoveRequestText.Name = "RemoveRequestText";
            RemoveRequestText.Size = new Size(300, 30);
            RemoveRequestText.TabIndex = 9;
            RemoveRequestText.ValidatingType = typeof(int);
            // 
            // RemoveRequestButton
            // 
            RemoveRequestButton.AutoSize = true;
            RemoveRequestButton.Location = new Point(649, 420);
            RemoveRequestButton.Name = "RemoveRequestButton";
            RemoveRequestButton.Size = new Size(130, 30);
            RemoveRequestButton.TabIndex = 1;
            RemoveRequestButton.Text = "Remove Request";
            RemoveRequestButton.UseVisualStyleBackColor = true;
            RemoveRequestButton.Click += RemoveRequestButton_Click;
            // 
            // requestLabel
            // 
            requestLabel.Location = new Point(137, 205);
            requestLabel.Name = "requestLabel";
            requestLabel.Size = new Size(107, 25);
            requestLabel.TabIndex = 7;
            requestLabel.Text = "Request:";
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
            TitleLabel.Text = "Remove Request";
            TitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // RemoveRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(Background);
            MinimumSize = new Size(800, 500);
            Name = "RemoveRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Remove Request";
            Background.ResumeLayout(false);
            Background.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Background;
        private Label TitleLabel;
        private Label requestLabel;
        private Button RemoveRequestButton;
        private MaskedTextBox RemoveRequestText;
    }
}