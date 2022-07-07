namespace Examinatin_system.Forms
{
    partial class Question
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Question_body = new System.Windows.Forms.RichTextBox();
            this.CB_Question_type = new System.Windows.Forms.ComboBox();
            this.CB_Question_course = new System.Windows.Forms.ComboBox();
            this.Lable_ans_1 = new System.Windows.Forms.Label();
            this.Lable_ans_4 = new System.Windows.Forms.Label();
            this.Lable_ans_3 = new System.Windows.Forms.Label();
            this.Lable_ans_2 = new System.Windows.Forms.Label();
            this.choice2 = new System.Windows.Forms.TextBox();
            this.choice3 = new System.Windows.Forms.TextBox();
            this.choice4 = new System.Windows.Forms.TextBox();
            this.choice1 = new System.Windows.Forms.TextBox();
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question Body";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Question Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Question Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model Answer";
            // 
            // txt_Question_body
            // 
            this.txt_Question_body.Location = new System.Drawing.Point(322, 12);
            this.txt_Question_body.Name = "txt_Question_body";
            this.txt_Question_body.Size = new System.Drawing.Size(439, 96);
            this.txt_Question_body.TabIndex = 4;
            this.txt_Question_body.Text = "";
            // 
            // CB_Question_type
            // 
            this.CB_Question_type.FormattingEnabled = true;
            this.CB_Question_type.Location = new System.Drawing.Point(322, 168);
            this.CB_Question_type.Name = "CB_Question_type";
            this.CB_Question_type.Size = new System.Drawing.Size(121, 21);
            this.CB_Question_type.TabIndex = 5;
            // 
            // CB_Question_course
            // 
            this.CB_Question_course.FormattingEnabled = true;
            this.CB_Question_course.Location = new System.Drawing.Point(322, 329);
            this.CB_Question_course.Name = "CB_Question_course";
            this.CB_Question_course.Size = new System.Drawing.Size(121, 21);
            this.CB_Question_course.TabIndex = 6;
            // 
            // Lable_ans_1
            // 
            this.Lable_ans_1.AutoSize = true;
            this.Lable_ans_1.Location = new System.Drawing.Point(153, 213);
            this.Lable_ans_1.Name = "Lable_ans_1";
            this.Lable_ans_1.Size = new System.Drawing.Size(49, 13);
            this.Lable_ans_1.TabIndex = 7;
            this.Lable_ans_1.Text = "Choice 1";
            // 
            // Lable_ans_4
            // 
            this.Lable_ans_4.AutoSize = true;
            this.Lable_ans_4.Location = new System.Drawing.Point(153, 301);
            this.Lable_ans_4.Name = "Lable_ans_4";
            this.Lable_ans_4.Size = new System.Drawing.Size(48, 13);
            this.Lable_ans_4.TabIndex = 8;
            this.Lable_ans_4.Text = "choice 4";
            // 
            // Lable_ans_3
            // 
            this.Lable_ans_3.AutoSize = true;
            this.Lable_ans_3.Location = new System.Drawing.Point(153, 272);
            this.Lable_ans_3.Name = "Lable_ans_3";
            this.Lable_ans_3.Size = new System.Drawing.Size(49, 13);
            this.Lable_ans_3.TabIndex = 9;
            this.Lable_ans_3.Text = "Choice 3";
            // 
            // Lable_ans_2
            // 
            this.Lable_ans_2.AutoSize = true;
            this.Lable_ans_2.Location = new System.Drawing.Point(153, 241);
            this.Lable_ans_2.Name = "Lable_ans_2";
            this.Lable_ans_2.Size = new System.Drawing.Size(49, 13);
            this.Lable_ans_2.TabIndex = 10;
            this.Lable_ans_2.Text = "Choice 2";
            // 
            // choice2
            // 
            this.choice2.Location = new System.Drawing.Point(322, 234);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(100, 20);
            this.choice2.TabIndex = 11;
            // 
            // choice3
            // 
            this.choice3.Location = new System.Drawing.Point(322, 265);
            this.choice3.Name = "choice3";
            this.choice3.Size = new System.Drawing.Size(100, 20);
            this.choice3.TabIndex = 12;
            // 
            // choice4
            // 
            this.choice4.Location = new System.Drawing.Point(322, 298);
            this.choice4.Name = "choice4";
            this.choice4.Size = new System.Drawing.Size(100, 20);
            this.choice4.TabIndex = 13;
            // 
            // choice1
            // 
            this.choice1.Location = new System.Drawing.Point(322, 206);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(100, 20);
            this.choice1.TabIndex = 14;
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(322, 426);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(100, 20);
            this.txt_answer.TabIndex = 15;
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.choice1);
            this.Controls.Add(this.choice4);
            this.Controls.Add(this.choice3);
            this.Controls.Add(this.choice2);
            this.Controls.Add(this.Lable_ans_2);
            this.Controls.Add(this.Lable_ans_3);
            this.Controls.Add(this.Lable_ans_4);
            this.Controls.Add(this.Lable_ans_1);
            this.Controls.Add(this.CB_Question_course);
            this.Controls.Add(this.CB_Question_type);
            this.Controls.Add(this.txt_Question_body);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Question";
            this.Text = "Question";
            this.Load += new System.EventHandler(this.Question_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txt_Question_body;
        private System.Windows.Forms.ComboBox CB_Question_type;
        private System.Windows.Forms.ComboBox CB_Question_course;
        private System.Windows.Forms.Label Lable_ans_1;
        private System.Windows.Forms.Label Lable_ans_4;
        private System.Windows.Forms.Label Lable_ans_3;
        private System.Windows.Forms.Label Lable_ans_2;
        private System.Windows.Forms.TextBox choice2;
        private System.Windows.Forms.TextBox choice3;
        private System.Windows.Forms.TextBox choice4;
        private System.Windows.Forms.TextBox choice1;
        private System.Windows.Forms.TextBox txt_answer;
    }
}