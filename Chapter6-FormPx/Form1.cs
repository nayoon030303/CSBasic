using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter6_FormPx
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            IsMdiContainer = true;
          
            InitializeComponent();
        }

        private void btnDialogBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.None;
            if (sender == btnDialogBox1)
            {
               result = MessageBox.Show("안녕하세요");
            }
            else if (sender == btnDialogBox2)
            {
                result = MessageBox.Show("안녕하세요","환영인사");
            }
            else if (sender == btnDialogBox2)
            {
                result = MessageBox.Show("안녕하세요","환영인사",MessageBoxButtons.YesNo,
                    MessageBoxIcon.Hand);
            }

            switch(result)
            {
                case DialogResult.OK:
                case DialogResult.Yes:
                    MessageBox.Show("좋은 하루");
                        break;
                case DialogResult.No:
                    MessageBox.Show("가서 쉬세요!", "시스템");
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnModeless_click(object sender, EventArgs e)
        {
            Form form = new Form2();
           
            if(sender == btnModeless)
            {
                form.MdiParent = this;
                form.Show();
            }else if(sender == btnModal)
            {
                form.ShowDialog();
            }
        }
    }
}
