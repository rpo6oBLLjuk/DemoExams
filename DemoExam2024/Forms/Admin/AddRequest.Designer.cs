namespace DemoExam2024.Forms.Admin
{
    partial class AddRequest
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
            ClientText = new TextBox();
            clientLabel = new Label();
            ProblemDescriptionText = new TextBox();
            problemDescriptionLabel = new Label();
            FaultTypeText = new TextBox();
            faultTypeLabel = new Label();
            EquipmentText = new TextBox();
            equipmentLabel = new Label();
            TitleLabel = new Label();
            ApplyRequestButton = new Button();
            Background.SuspendLayout();
            SuspendLayout();
            // 
            // Background
            // 
            Background.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Background.BackColor = SystemColors.Menu;
            Background.Controls.Add(ApplyRequestButton);
            Background.Controls.Add(ClientText);
            Background.Controls.Add(clientLabel);
            Background.Controls.Add(ProblemDescriptionText);
            Background.Controls.Add(problemDescriptionLabel);
            Background.Controls.Add(FaultTypeText);
            Background.Controls.Add(faultTypeLabel);
            Background.Controls.Add(EquipmentText);
            Background.Controls.Add(equipmentLabel);
            Background.Controls.Add(TitleLabel);
            Background.Location = new Point(0, 0);
            Background.Margin = new Padding(0);
            Background.Name = "Background";
            Background.Size = new Size(782, 453);
            Background.TabIndex = 0;
            // 
            // ClientText
            // 
            ClientText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClientText.Location = new Point(250, 400);
            ClientText.Name = "ClientText";
            ClientText.Size = new Size(300, 30);
            ClientText.TabIndex = 8;
            // 
            // clientLabel
            // 
            clientLabel.Location = new Point(137, 405);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new Size(107, 25);
            clientLabel.TabIndex = 7;
            clientLabel.Text = "Client:";
            // 
            // ProblemDescriptionText
            // 
            ProblemDescriptionText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ProblemDescriptionText.Location = new Point(250, 300);
            ProblemDescriptionText.Name = "ProblemDescriptionText";
            ProblemDescriptionText.Size = new Size(300, 30);
            ProblemDescriptionText.TabIndex = 6;
            // 
            // problemDescriptionLabel
            // 
            problemDescriptionLabel.Location = new Point(137, 284);
            problemDescriptionLabel.Name = "problemDescriptionLabel";
            problemDescriptionLabel.Size = new Size(107, 46);
            problemDescriptionLabel.TabIndex = 5;
            problemDescriptionLabel.Text = "Problem Description:";
            // 
            // FaultTypeText
            // 
            FaultTypeText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FaultTypeText.Location = new Point(250, 200);
            FaultTypeText.Name = "FaultTypeText";
            FaultTypeText.Size = new Size(300, 30);
            FaultTypeText.TabIndex = 4;
            // 
            // faultTypeLabel
            // 
            faultTypeLabel.Location = new Point(137, 205);
            faultTypeLabel.Name = "faultTypeLabel";
            faultTypeLabel.Size = new Size(107, 25);
            faultTypeLabel.TabIndex = 3;
            faultTypeLabel.Text = "FaultType:";
            // 
            // EquipmentText
            // 
            EquipmentText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EquipmentText.Location = new Point(250, 100);
            EquipmentText.Name = "EquipmentText";
            EquipmentText.Size = new Size(300, 30);
            EquipmentText.TabIndex = 2;
            // 
            // equipmentLabel
            // 
            equipmentLabel.Location = new Point(137, 105);
            equipmentLabel.Name = "equipmentLabel";
            equipmentLabel.Size = new Size(107, 30);
            equipmentLabel.TabIndex = 1;
            equipmentLabel.Text = "Equipment:";
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
            TitleLabel.Text = "Add Request";
            TitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ApplyRequestButton
            // 
            ApplyRequestButton.AutoSize = true;
            ApplyRequestButton.Location = new Point(664, 420);
            ApplyRequestButton.Name = "ApplyRequestButton";
            ApplyRequestButton.Size = new Size(115, 30);
            ApplyRequestButton.TabIndex = 1;
            ApplyRequestButton.Text = "Apply Request";
            ApplyRequestButton.UseVisualStyleBackColor = true;
            ApplyRequestButton.Click += ApplyRequestButton_Click;
            // 
            // AddRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(Background);
            MinimumSize = new Size(800, 500);
            Name = "AddRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Request";
            Background.ResumeLayout(false);
            Background.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Background;
        private Label TitleLabel;
        private Label equipmentLabel;
        private TextBox EquipmentText;
        private TextBox ClientText;
        private Label clientLabel;
        private TextBox ProblemDescriptionText;
        private Label problemDescriptionLabel;
        private TextBox FaultTypeText;
        private Label faultTypeLabel;
        private Button ApplyRequestButton;
    }
}