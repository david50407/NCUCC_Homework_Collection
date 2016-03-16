using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Week6_HW1_CheckCheck
{
    public partial class Form1 : Form
    {
        private bool bCheckChecking = false;
        private int iCheckCheckingTime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (CheckBox ch in this.fLP_checkcheck.Controls)
            {
                ch.Checked = false;
                ch.Enabled = false;
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (bCheckChecking)
                return;

            bCheckChecking = true;
            iCheckCheckingTime = 0;
            this.button_Start.Text = "5";
            foreach (CheckBox ch in this.fLP_checkcheck.Controls)
            {
                ch.Checked = false;
                ch.Enabled = true;
            }
            this.timer_checkcheck.Start();
        }

        private void timer_checkcheck_Tick(object sender, EventArgs e)
        {
            ++iCheckCheckingTime;
            this.button_Start.Text = (5 - iCheckCheckingTime).ToString();
            if (iCheckCheckingTime < 5)
                return;

            this.timer_checkcheck.Stop();
            int iCheckCheckCount = 0;
            foreach (CheckBox ch in this.fLP_checkcheck.Controls)
                if (ch.Checked)
                    ++iCheckCheckCount;
            MessageBox.Show(String.Format("你得到 {0} 分 >.0", iCheckCheckCount), "時間到~", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (CheckBox ch in this.fLP_checkcheck.Controls)
            {
                ch.Enabled = false;
            }
            this.button_Start.Text = "開始嚕~";
            bCheckChecking = false;
        }
    }
}
