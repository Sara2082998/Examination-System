using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examinatin_system.Forms;
namespace Examinatin_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panl_main_container_Paint(object sender, PaintEventArgs e)
        {
            
        }


      
        private void btn_add_Question_Click(object sender, EventArgs e)
        {
            loadForm(new Question());
        }



        void loadForm(Form f)
        {
            if (this.panl_main_container.Controls.Count > 0)
                this.panl_main_container.Controls.RemoveAt(0);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panl_main_container.Controls.Add(f);
            this.panl_main_container.Tag = f;
            f.Show();
        }

        private void btn_add_exam_Click(object sender, EventArgs e)
        {
            loadForm(new Exam());
        }
    }
}
