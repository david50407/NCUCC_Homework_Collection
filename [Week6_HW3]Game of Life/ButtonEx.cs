using System.Drawing;
using System.Windows.Forms;

namespace _Week6_HW3_Game_of_Life
{
    public partial class ButtonEx : Button
    {
        public bool __checked;
        public ButtonEx(int r, int c)
            : base()
        {
            Row = r;
            Col = c;
            Checked = false;
            this.BackColor = Color.White;
            this.Width = this.Height = 14;
            this.Location = new Point(c * 13 + 3, r * 13 + 3);
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            this.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            this.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            SetStyle(ControlStyles.Selectable, false);
        }
        public int Row { get; set; }
        public int Col { get; set; }
        public bool Checked
        {
            get
            {
                return __checked;
            }
            set
            {
                if (value == __checked)
                    return;

                __checked = value;
                this.BackColor = value ? Color.Black : Color.White;
                this.FlatAppearance.MouseOverBackColor = value ? Color.DarkCyan : Color.LightSkyBlue;
                this.FlatAppearance.MouseDownBackColor = value ? Color.LightSkyBlue : Color.DarkCyan;
                this.Refresh();
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            this.Checked = !this.Checked;
            base.OnMouseClick(e);
        }
    }
}
