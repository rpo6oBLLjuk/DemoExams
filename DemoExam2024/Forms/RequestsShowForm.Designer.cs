namespace DemoExam2024
{
    partial class RequestsShowForm
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
        private void InitializeComponent()
        {
            TitlePanel = new Panel();
            TitleLabel = new Label();
            dataGridView1 = new DataGridView();
            ApplyButton = new Button();
            TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.AutoSize = true;
            TitlePanel.BackColor = SystemColors.ActiveCaption;
            TitlePanel.Controls.Add(TitleLabel);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Margin = new Padding(0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(782, 85);
            TitlePanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Margin = new Padding(0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(782, 85);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Requests";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(782, 319);
            dataGridView1.TabIndex = 1;
            // 
            // ApplyButton
            // 
            ApplyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ApplyButton.AutoSize = true;
            ApplyButton.Location = new Point(668, 411);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(102, 30);
            ApplyButton.TabIndex = 2;
            ApplyButton.Text = "ApplyButton";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // RequestsShowForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(782, 453);
            Controls.Add(ApplyButton);
            Controls.Add(dataGridView1);
            Controls.Add(TitlePanel);
            MinimumSize = new Size(800, 500);
            Name = "RequestsShowForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Requests Show";
            WindowState = FormWindowState.Maximized;
            TitlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TitlePanel;
        private Label TitleLabel;
        private DataGridView dataGridView1;
        private Button ApplyButton;
    }
}
