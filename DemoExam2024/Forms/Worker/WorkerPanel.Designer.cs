namespace DemoExam2024.Forms
{
    partial class WorkerPanel
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
            button2 = new Button();
            ChangeStatusButton = new Button();
            Background.SuspendLayout();
            SuspendLayout();
            // 
            // Background
            // 
            Background.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Background.BackColor = SystemColors.Menu;
            Background.Controls.Add(button2);
            Background.Controls.Add(ChangeStatusButton);
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
            TitleLabel.Text = "Worker panel";
            TitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(300, 260);
            button2.Name = "button2";
            button2.Size = new Size(200, 60);
            button2.TabIndex = 9;
            button2.Text = "Remove Request";
            button2.UseVisualStyleBackColor = true;
            // 
            // ChangeStatusButton
            // 
            ChangeStatusButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ChangeStatusButton.Location = new Point(300, 194);
            ChangeStatusButton.Name = "ChangeStatusButton";
            ChangeStatusButton.Size = new Size(200, 60);
            ChangeStatusButton.TabIndex = 8;
            ChangeStatusButton.Text = "Change Status";
            ChangeStatusButton.UseVisualStyleBackColor = true;
            ChangeStatusButton.Click += ChangeStatusButton_Click;
            // 
            // WorkerPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(Background);
            MinimumSize = new Size(800, 500);
            Name = "WorkerPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Worker Panel";
            Background.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Background;
        private Label TitleLabel;
        private Button button2;
        private Button ChangeStatusButton;
    }
}