namespace MultiplicationGame
{
    partial class multiplicationGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(multiplicationGame));
            questionLabel = new Label();
            ansLabel = new Label();
            ansTxtBox = new TextBox();
            errMsg = new Label();
            streakLabel = new Label();
            highScoreLabel = new Label();
            checkBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            questionLabel.Location = new Point(741, 263);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(438, 65);
            questionLabel.TabIndex = 1;
            questionLabel.Text = "[QUESTION HERE]";
            // 
            // ansLabel
            // 
            ansLabel.AutoSize = true;
            ansLabel.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            ansLabel.Location = new Point(561, 530);
            ansLabel.Name = "ansLabel";
            ansLabel.Size = new Size(157, 50);
            ansLabel.TabIndex = 2;
            ansLabel.Text = "Answer:";
            // 
            // ansTxtBox
            // 
            ansTxtBox.BorderStyle = BorderStyle.None;
            ansTxtBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ansTxtBox.Location = new Point(848, 550);
            ansTxtBox.Name = "ansTxtBox";
            ansTxtBox.Size = new Size(224, 26);
            ansTxtBox.TabIndex = 3;
            ansTxtBox.KeyPress += ansTxtBox_KeyPress;
            // 
            // errMsg
            // 
            errMsg.AutoSize = true;
            errMsg.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            errMsg.ForeColor = Color.FromArgb(192, 0, 0);
            errMsg.Location = new Point(883, 787);
            errMsg.Name = "errMsg";
            errMsg.Size = new Size(155, 32);
            errMsg.TabIndex = 4;
            errMsg.Text = "ERROR MSG";
            // 
            // streakLabel
            // 
            streakLabel.AutoSize = true;
            streakLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            streakLabel.Location = new Point(1669, 64);
            streakLabel.Name = "streakLabel";
            streakLabel.Size = new Size(152, 47);
            streakLabel.TabIndex = 5;
            streakLabel.Text = "Streak: 0";
            // 
            // highScoreLabel
            // 
            highScoreLabel.AutoSize = true;
            highScoreLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            highScoreLabel.Location = new Point(1669, 3);
            highScoreLabel.Name = "highScoreLabel";
            highScoreLabel.Size = new Size(239, 47);
            highScoreLabel.TabIndex = 6;
            highScoreLabel.Text = "Hight Score: 0";
            // 
            // checkBtn
            // 
            checkBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBtn.Location = new Point(1644, 945);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(264, 123);
            checkBtn.TabIndex = 0;
            checkBtn.Text = "Check";
            checkBtn.UseVisualStyleBackColor = true;
            checkBtn.Click += checkBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtn.Location = new Point(12, 945);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(264, 123);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // multiplicationGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(exitBtn);
            Controls.Add(highScoreLabel);
            Controls.Add(streakLabel);
            Controls.Add(errMsg);
            Controls.Add(ansTxtBox);
            Controls.Add(ansLabel);
            Controls.Add(questionLabel);
            Controls.Add(checkBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "multiplicationGame";
            Text = "Multiplication Game";
            WindowState = FormWindowState.Maximized;
            Load += multiplicationGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label questionLabel;
        private Label ansLabel;
        private TextBox ansTxtBox;
        private Label errMsg;
        private Label streakLabel;
        private Label highScoreLabel;
        private Button checkBtn;
        private Button exitBtn;
    }
}