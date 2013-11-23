using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Week6_HW3_Game_of_Life
{
    public partial class Form1 : Form
    {
        private ButtonEx[,] bex = new ButtonEx[50, 50];
        private bool[,] ap = new bool[50, 50];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; ++i)
                for (int j = 0; j < 50; ++j)
                {
                    bex[i, j] = new ButtonEx(i, j);
                    this.panel_container.Controls.Add(bex[i, j]);
                }

            this.ClientSize = new Size(50 * (bex[0, 0].Width - 1) + 6 + this.panel_side.Width,
                50 * (bex[0, 0].Height - 1) + 6);
        }

        private void button_Step_Click(object sender, EventArgs e)
        {
            if (this.timer_world.Enabled)
                return;
            step();
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            this.timer_world.Enabled = !this.timer_world.Enabled;
            if (this.timer_world.Enabled)
            {
                this.button_Run.Text = "Stop";
                this.button_Step.Enabled = false;
                this.trackBar_tick.Enabled = false;
            }
            else
            {
                this.button_Run.Text = "Play";
                this.button_Step.Enabled = true;
                this.trackBar_tick.Enabled = true;
            }
        }

        private void trackBar_tick_Scroll(object sender, EventArgs e)
        {
            this.timer_world.Interval = this.trackBar_tick.Value * 100;
            this.label_tick.Text = String.Format("Tick: {0} ms", this.timer_world.Interval);
        }

        private void timer_world_Tick(object sender, EventArgs e)
        {
            step();
        }

        private void step()
        {
            for (int i = 0; i < 50; ++i)
                for (int j = 0; j < 50; ++j)
                {
                    int c = 0;
                    for (int x = -1; x <= 1; ++x)
                        for (int y = -1; y <= 1; ++y)
                            if (x == 0 && y == 0)
                                continue;
                            else if (i + x < 0 || i + x >= 50 || j + y < 0 || j + y >= 50)
                                continue;
                            else if (bex[i + x, j + y].Checked)
                                ++c;

                    ap[i, j] = (c == 3 || (bex[i, j].Checked && c == 2));
                }

            for (int i = 0; i < 50; ++i)
                for (int j = 0; j < 50; ++j)
                    bex[i, j].Checked = ap[i, j];
        }
    }
}
