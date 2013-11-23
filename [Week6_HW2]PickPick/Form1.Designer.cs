namespace _Week6_HW2_PickPick
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
            this.pB_zoom = new System.Windows.Forms.PictureBox();
            this.panel_zoom = new System.Windows.Forms.Panel();
            this.label_color = new System.Windows.Forms.Label();
            this.pB_main = new System.Windows.Forms.PictureBox();
            this.oFD_loading = new System.Windows.Forms.OpenFileDialog();
            this.panel_side = new System.Windows.Forms.Panel();
            this.button_loading = new System.Windows.Forms.Button();
            this.label_pos = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label_G = new System.Windows.Forms.Label();
            this.label_R = new System.Windows.Forms.Label();
            this.panel_color = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pB_zoom)).BeginInit();
            this.panel_zoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_main)).BeginInit();
            this.panel_side.SuspendLayout();
            this.SuspendLayout();
            // 
            // pB_zoom
            // 
            this.pB_zoom.BackgroundImage = global::_Week6_HW2_PickPick.Resource1.Example;
            this.pB_zoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pB_zoom.Location = new System.Drawing.Point(3, 3);
            this.pB_zoom.Name = "pB_zoom";
            this.pB_zoom.Size = new System.Drawing.Size(100, 50);
            this.pB_zoom.TabIndex = 0;
            this.pB_zoom.TabStop = false;
            this.pB_zoom.MouseEnter += new System.EventHandler(this.pB_zoom_MouseEnter);
            this.pB_zoom.MouseLeave += new System.EventHandler(this.pB_zoom_MouseLeave);
            this.pB_zoom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // panel_zoom
            // 
            this.panel_zoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_zoom.Controls.Add(this.label_color);
            this.panel_zoom.Controls.Add(this.pB_zoom);
            this.panel_zoom.Location = new System.Drawing.Point(699, 278);
            this.panel_zoom.Name = "panel_zoom";
            this.panel_zoom.Size = new System.Drawing.Size(160, 160);
            this.panel_zoom.TabIndex = 1;
            this.panel_zoom.MouseEnter += new System.EventHandler(this.panel_zoom_MouseEnter);
            this.panel_zoom.MouseLeave += new System.EventHandler(this.panel_zoom_MouseLeave);
            this.panel_zoom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.BackColor = System.Drawing.Color.White;
            this.label_color.Location = new System.Drawing.Point(102, 147);
            this.label_color.Margin = new System.Windows.Forms.Padding(0);
            this.label_color.Name = "label_color";
            this.label_color.Padding = new System.Windows.Forms.Padding(3);
            this.label_color.Size = new System.Drawing.Size(64, 19);
            this.label_color.TabIndex = 1;
            this.label_color.Text = "label_color";
            // 
            // pB_main
            // 
            this.pB_main.BackgroundImage = global::_Week6_HW2_PickPick.Resource1.Example;
            this.pB_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pB_main.Location = new System.Drawing.Point(0, 0);
            this.pB_main.Margin = new System.Windows.Forms.Padding(0);
            this.pB_main.Name = "pB_main";
            this.pB_main.Size = new System.Drawing.Size(961, 541);
            this.pB_main.TabIndex = 2;
            this.pB_main.TabStop = false;
            this.pB_main.MouseEnter += new System.EventHandler(this.pB_main_MouseEnter);
            this.pB_main.MouseLeave += new System.EventHandler(this.pB_main_MouseLeave);
            this.pB_main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // oFD_loading
            // 
            this.oFD_loading.Filter = "All Supported files|*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.tif;*.tiff|BMP files|*.bmp|G" +
    "IF files|*.gif|JPEG files|*.jpg;*.jpeg|PNG files|*.png|TIFF files|*.tif;*.tiff|A" +
    "ll files|*.*";
            // 
            // panel_side
            // 
            this.panel_side.Controls.Add(this.button_loading);
            this.panel_side.Controls.Add(this.label_pos);
            this.panel_side.Controls.Add(this.label_B);
            this.panel_side.Controls.Add(this.label_G);
            this.panel_side.Controls.Add(this.label_R);
            this.panel_side.Controls.Add(this.panel_color);
            this.panel_side.Location = new System.Drawing.Point(961, 0);
            this.panel_side.Margin = new System.Windows.Forms.Padding(0);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(200, 541);
            this.panel_side.TabIndex = 3;
            // 
            // button_loading
            // 
            this.button_loading.Location = new System.Drawing.Point(12, 509);
            this.button_loading.Name = "button_loading";
            this.button_loading.Size = new System.Drawing.Size(176, 23);
            this.button_loading.TabIndex = 5;
            this.button_loading.Text = "載入其他圖片...";
            this.button_loading.UseVisualStyleBackColor = true;
            this.button_loading.Click += new System.EventHandler(this.button_loading_Click);
            // 
            // label_pos
            // 
            this.label_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_pos.Location = new System.Drawing.Point(7, 278);
            this.label_pos.Name = "label_pos";
            this.label_pos.Size = new System.Drawing.Size(181, 29);
            this.label_pos.TabIndex = 4;
            this.label_pos.Text = "label1";
            this.label_pos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_B
            // 
            this.label_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B.ForeColor = System.Drawing.Color.Blue;
            this.label_B.Location = new System.Drawing.Point(7, 249);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(181, 29);
            this.label_B.TabIndex = 3;
            this.label_B.Text = "label1";
            this.label_B.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_G
            // 
            this.label_G.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_G.ForeColor = System.Drawing.Color.Green;
            this.label_G.Location = new System.Drawing.Point(7, 220);
            this.label_G.Name = "label_G";
            this.label_G.Size = new System.Drawing.Size(181, 29);
            this.label_G.TabIndex = 2;
            this.label_G.Text = "label1";
            this.label_G.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_R
            // 
            this.label_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_R.ForeColor = System.Drawing.Color.Red;
            this.label_R.Location = new System.Drawing.Point(7, 191);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(181, 29);
            this.label_R.TabIndex = 1;
            this.label_R.Text = "label1";
            this.label_R.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_color
            // 
            this.panel_color.Location = new System.Drawing.Point(12, 12);
            this.panel_color.Name = "panel_color";
            this.panel_color.Size = new System.Drawing.Size(176, 176);
            this.panel_color.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 544);
            this.Controls.Add(this.panel_side);
            this.Controls.Add(this.panel_zoom);
            this.Controls.Add(this.pB_main);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PickPick";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB_zoom)).EndInit();
            this.panel_zoom.ResumeLayout(false);
            this.panel_zoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_main)).EndInit();
            this.panel_side.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_zoom;
        private System.Windows.Forms.Panel panel_zoom;
        private System.Windows.Forms.PictureBox pB_main;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.OpenFileDialog oFD_loading;
        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_G;
        private System.Windows.Forms.Label label_R;
        private System.Windows.Forms.Panel panel_color;
        private System.Windows.Forms.Label label_pos;
        private System.Windows.Forms.Button button_loading;
    }
}

