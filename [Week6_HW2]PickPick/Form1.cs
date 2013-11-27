using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Week6_HW2_PickPick
{
    public partial class Form1 : Form
    {
        private int iOldEX = -1, iOldEY = -1;
        private bool bMainLeave = true, bPanelLeave = true, bZoomLeave = true;
        private Bitmap bitmap;
        private int iZoom = 8;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(this.pB_main.BackgroundImage);
            this.pB_zoom.Size = new Size(bitmap.Width * iZoom, bitmap.Height * iZoom);
            this.panel_zoom.Hide();
            this.ClientSize = new Size(pB_main.Width + panel_side.Width, pB_main.Height);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel_zoom.Show();
            if (e.X < 0 || e.X >= bitmap.Width || e.Y < 0 || e.Y >= bitmap.Height)
            {
                this.panel_zoom.Hide();
                this.pB_main.Refresh();
                this.Refresh();
                return;
            }

            int pX = Math.Max(0, Math.Min(this.pB_main.Width - this.panel_zoom.Width, e.X - this.panel_zoom.Width / 2)),
                pY = Math.Max(0, Math.Min(this.pB_main.Height - this.panel_zoom.Height, e.Y - this.panel_zoom.Height / 2));
            int pOX = pX - (e.X - this.panel_zoom.Width / 2),
                pOY = pY - (e.Y - this.panel_zoom.Height / 2);
            this.panel_zoom.Location = new Point(pX, pY);

            int zX = (int)(-iZoom * e.X + iZoom / 2 + this.panel_zoom.Width / 2 - pOX),
                zY = (int)(-iZoom * e.Y + iZoom / 2 + this.panel_zoom.Height / 2 - pOY);
            this.pB_zoom.Location = new Point(zX, zY);

            if (iOldEX != zX || iOldEY != zY)
            {
                iOldEX = e.X;
                iOldEY = e.Y;
                Color color = bitmap.GetPixel(e.X, e.Y);
                this.label_color.Text = String.Format("({0}, {1}, {2})", color.R, color.G, color.B);
                if ((e.X > this.pB_main.Width - this.label_color.Width - 5) &&
                    (e.Y > this.pB_main.Height - this.label_color.Height - 5))
                    this.label_color.Location = new Point(0,
                        this.panel_zoom.Height - this.label_color.Height);
                else
                    this.label_color.Location = new Point(this.panel_zoom.Width - this.label_color.Width + 1,
                        this.panel_zoom.Height - this.label_color.Height);

                this.panel_color.BackColor = color;
                this.label_R.Text = color.R.ToString();
                this.label_G.Text = color.G.ToString();
                this.label_B.Text = color.B.ToString();
                this.label_pos.Text = String.Format("({0}, {1})", e.X, e.Y);

                this.label_color.Refresh();
                this.pB_main.Refresh();
                this.pB_zoom.Refresh();
                this.panel_color.Refresh();
                this.label_R.Refresh();
                this.label_G.Refresh();
                this.label_B.Refresh();
                this.label_pos.Refresh();
            }
        }

        #region MouseLeave Event

        private void pB_main_MouseLeave(object sender, EventArgs e)
        {
            bMainLeave = true;
            if (bMainLeave && bPanelLeave && bZoomLeave)
                this.panel_zoom.Hide();
        }

        private void panel_zoom_MouseLeave(object sender, EventArgs e)
        {
            bPanelLeave = true;
            if (bMainLeave && bPanelLeave && bZoomLeave)
                this.panel_zoom.Hide();
        }

        private void pB_zoom_MouseLeave(object sender, EventArgs e)
        {
            bZoomLeave = true;
            if (bMainLeave && bPanelLeave && bZoomLeave)
                this.panel_zoom.Hide();
        }

        #endregion
        #region MouseEnter Event

        private void pB_main_MouseEnter(object sender, EventArgs e)
        {
            bMainLeave = false;
            this.panel_zoom.Show();
        }

        private void panel_zoom_MouseEnter(object sender, EventArgs e)
        {
            bPanelLeave = false;
            this.panel_zoom.Show();
        }

        private void pB_zoom_MouseEnter(object sender, EventArgs e)
        {
            bZoomLeave = false;
            this.panel_zoom.Show();
        }
        #endregion

        private void button_loading_Click(object sender, EventArgs e)
        {
            if (this.oFD_loading.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            try
            {
                Image img = Image.FromFile(this.oFD_loading.FileName);
                this.pB_main.BackgroundImage = img;
                this.pB_zoom.BackgroundImage = img;
                bitmap = new Bitmap(img);
                this.pB_zoom.Size = new Size(bitmap.Width * iZoom, bitmap.Height * iZoom);
            }
            catch (Exception err)
            {
                MessageBox.Show("Non Supported image file or file does not exist.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}