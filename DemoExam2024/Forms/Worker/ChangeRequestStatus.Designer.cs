namespace DemoExam2024.Forms.Worker
{
    partial class ChangeRequestStatus
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
            StatusComboBox = new ComboBox();
            RequestNumberText = new MaskedTextBox();
            statusLabel = new Label();
            requestNumberLabel = new Label();
            ApplyStatusButton = new Button();
            TitleLabel = new Label();
            Background.SuspendLayout();
            SuspendLayout();
            // 
            // Background
            // 
            Background.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Background.BackColor = SystemColors.Menu;
            Background.Controls.Add(StatusComboBox);
            Background.Controls.Add(RequestNumberText);
            Background.Controls.Add(statusLabel);
            Background.Controls.Add(requestNumberLabel);
            Background.Controls.Add(ApplyStatusButton);
            Background.Controls.Add(TitleLabel);
            Background.Location = new Point(0, 0);
            Background.Margin = new Padding(0);
            Background.Name = "Background";
            Background.Size = new Size(782, 453);
            Background.TabIndex = 0;
            // 
            // StatusComboBox
            // 
            StatusComboBox.AllowDrop = true;
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(250, 270);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(300, 31);
            StatusComboBox.TabIndex = 1;
            // 
            // RequestNumberText
            // 
            RequestNumberText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RequestNumberText.Location = new Point(250, 200);
            RequestNumberText.Mask = "00000";
            RequestNumberText.Name = "RequestNumberText";
            RequestNumberText.RejectInputOnFirstFailure = true;
            RequestNumberText.Size = new Size(300, 30);
            RequestNumberText.SkipLiterals = false;
            RequestNumberText.TabIndex = 15;
            RequestNumberText.ValidatingType = typeof(int);
            // 
            // statusLabel
            // 
            statusLabel.Location = new Point(137, 271);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(107, 30);
            statusLabel.TabIndex = 11;
            statusLabel.Text = "Status:";
            // 
            // requestNumberLabel
            // 
            requestNumberLabel.Location = new Point(137, 183);
            requestNumberLabel.Name = "requestNumberLabel";
            requestNumberLabel.Size = new Size(107, 47);
            requestNumberLabel.TabIndex = 9;
            requestNumberLabel.Text = "Request Number:";
            // 
            // ApplyStatusButton
            // 
            ApplyStatusButton.AutoSize = true;
            ApplyStatusButton.Location = new Point(664, 420);
            ApplyStatusButton.Name = "ApplyStatusButton";
            ApplyStatusButton.Size = new Size(115, 30);
            ApplyStatusButton.TabIndex = 2;
            ApplyStatusButton.Text = "Apply Status";
            ApplyStatusButton.UseVisualStyleBackColor = true;
            ApplyStatusButton.Click += ApplyStatusButton_Click;
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
            TitleLabel.Text = "Change Request Status";
            TitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChangeRequestStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(Background);
            MinimumSize = new Size(800, 500);
            Name = "ChangeRequestStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Request Status";
            Background.ResumeLayout(false);
            Background.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Background;
        private Label TitleLabel;
        private Button ApplyStatusButton;
        private Label requestNumberLabel;
        private Label statusLabel;
        private MaskedTextBox RequestNumberText;
        private ComboBox StatusComboBox;
    }
}