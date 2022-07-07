namespace Examinatin_system
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
            this.panl_side_Navigator = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_add_student = new System.Windows.Forms.Button();
            this.btn_add_Class = new System.Windows.Forms.Button();
            this.btn_add_exam = new System.Windows.Forms.Button();
            this.btn_add_Question = new System.Windows.Forms.Button();
            this.panl_main_container = new System.Windows.Forms.Panel();
            this.panl_side_Navigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_side_Navigator
            // 
            this.panl_side_Navigator.Controls.Add(this.button5);
            this.panl_side_Navigator.Controls.Add(this.btn_add_student);
            this.panl_side_Navigator.Controls.Add(this.btn_add_Class);
            this.panl_side_Navigator.Controls.Add(this.btn_add_exam);
            this.panl_side_Navigator.Controls.Add(this.btn_add_Question);
            this.panl_side_Navigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.panl_side_Navigator.Location = new System.Drawing.Point(0, 0);
            this.panl_side_Navigator.Name = "panl_side_Navigator";
            this.panl_side_Navigator.Size = new System.Drawing.Size(200, 450);
            this.panl_side_Navigator.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(50, 299);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_add_student
            // 
            this.btn_add_student.Location = new System.Drawing.Point(3, 173);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(191, 23);
            this.btn_add_student.TabIndex = 3;
            this.btn_add_student.Text = "Student";
            this.btn_add_student.UseVisualStyleBackColor = true;
            // 
            // btn_add_Class
            // 
            this.btn_add_Class.Location = new System.Drawing.Point(3, 131);
            this.btn_add_Class.Name = "btn_add_Class";
            this.btn_add_Class.Size = new System.Drawing.Size(191, 23);
            this.btn_add_Class.TabIndex = 2;
            this.btn_add_Class.Text = "Class";
            this.btn_add_Class.UseVisualStyleBackColor = true;
            // 
            // btn_add_exam
            // 
            this.btn_add_exam.Location = new System.Drawing.Point(3, 85);
            this.btn_add_exam.Name = "btn_add_exam";
            this.btn_add_exam.Size = new System.Drawing.Size(191, 23);
            this.btn_add_exam.TabIndex = 1;
            this.btn_add_exam.Text = "Exam";
            this.btn_add_exam.UseVisualStyleBackColor = true;
            this.btn_add_exam.Click += new System.EventHandler(this.btn_add_exam_Click);
            // 
            // btn_add_Question
            // 
            this.btn_add_Question.Location = new System.Drawing.Point(3, 35);
            this.btn_add_Question.Name = "btn_add_Question";
            this.btn_add_Question.Size = new System.Drawing.Size(191, 23);
            this.btn_add_Question.TabIndex = 0;
            this.btn_add_Question.Text = "Question";
            this.btn_add_Question.UseVisualStyleBackColor = true;
            this.btn_add_Question.Click += new System.EventHandler(this.btn_add_Question_Click);
            // 
            // panl_main_container
            // 
            this.panl_main_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panl_main_container.Location = new System.Drawing.Point(200, 0);
            this.panl_main_container.Name = "panl_main_container";
            this.panl_main_container.Size = new System.Drawing.Size(600, 450);
            this.panl_main_container.TabIndex = 1;
            this.panl_main_container.Paint += new System.Windows.Forms.PaintEventHandler(this.panl_main_container_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panl_main_container);
            this.Controls.Add(this.panl_side_Navigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panl_side_Navigator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panl_side_Navigator;
        private System.Windows.Forms.Panel panl_main_container;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_add_student;
        private System.Windows.Forms.Button btn_add_Class;
        private System.Windows.Forms.Button btn_add_exam;
        private System.Windows.Forms.Button btn_add_Question;
    }
}

