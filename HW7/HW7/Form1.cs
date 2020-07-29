using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7
{
    public partial class Doubler : Form
    {
        Stack<int> temp = new Stack<int>();
        public Doubler()
        {
            InitializeComponent();
        
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            
            lblNumber.Text = Convert.ToString((int.Parse(lblNumber.Text) + 1));
            lblCount.Text = Convert.ToString((int.Parse(lblCount.Text) + 1));
            temp.Push(int.Parse(lblNumber.Text));
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = Convert.ToString((int.Parse(lblNumber.Text) * 2));
            lblCount.Text = Convert.ToString((int.Parse(lblCount.Text) + 1));
            temp.Push(int.Parse(lblNumber.Text));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            lblCount.Text = "0";
            target.Text = "0";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Random newTarget = new Random();
            lblNumber.Text = "0";
            lblCount.Text = "0";
            int rndNum = newTarget.Next(1, 500);
            MessageBox.Show($"Your target number is {rndNum}","", MessageBoxButtons.OK);
            target.Text = Convert.ToString(rndNum);

        }

        private void lblNumber_TextChanged(object sender, EventArgs e)
        {
            if ((int.Parse(target.Text) != 0) && (int.Parse(target.Text) == int.Parse(lblNumber.Text)))
            {
                MessageBox.Show("Congratulation!", "", MessageBoxButtons.OK);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            temp.Pop();
            lblNumber.Text = Convert.ToString(temp.Peek());
        }
    }
}
