namespace AssignmentDemo
{
    partial class Form1
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
            this.loadExamBtn = new System.Windows.Forms.Button();
            this.examIdTxt = new System.Windows.Forms.TextBox();
            this.answerPanel = new System.Windows.Forms.Panel();
            this.questionLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadExamBtn
            // 
            this.loadExamBtn.Location = new System.Drawing.Point(275, 20);
            this.loadExamBtn.Name = "loadExamBtn";
            this.loadExamBtn.Size = new System.Drawing.Size(128, 38);
            this.loadExamBtn.TabIndex = 0;
            this.loadExamBtn.Text = "Load Exam";
            this.loadExamBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadExamBtn.UseVisualStyleBackColor = true;
            this.loadExamBtn.Click += new System.EventHandler(this.loadExamBtn_Click);
            // 
            // examIdTxt
            // 
            this.examIdTxt.Location = new System.Drawing.Point(71, 20);
            this.examIdTxt.Name = "examIdTxt";
            this.examIdTxt.Size = new System.Drawing.Size(198, 31);
            this.examIdTxt.TabIndex = 1;
            // 
            // answerPanel
            // 
            this.answerPanel.Location = new System.Drawing.Point(71, 187);
            this.answerPanel.Name = "answerPanel";
            this.answerPanel.Size = new System.Drawing.Size(1098, 519);
            this.answerPanel.TabIndex = 2;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(64, 114);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(528, 42);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Ga co truoc hay trung co gtrc";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(1024, 803);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(145, 42);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(71, 803);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(110, 42);
            this.previousButton.TabIndex = 4;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 877);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.answerPanel);
            this.Controls.Add(this.examIdTxt);
            this.Controls.Add(this.loadExamBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadExamBtn;
        private System.Windows.Forms.TextBox examIdTxt;
        private System.Windows.Forms.Panel answerPanel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
    }
}

