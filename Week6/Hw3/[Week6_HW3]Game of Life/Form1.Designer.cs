namespace _Week6_HW3_Game_of_Life
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
            this.components = new System.ComponentModel.Container();
            this.tLP_main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_side = new System.Windows.Forms.Panel();
            this.button_Run = new System.Windows.Forms.Button();
            this.button_Step = new System.Windows.Forms.Button();
            this.panel_container = new System.Windows.Forms.Panel();
            this.timer_world = new System.Windows.Forms.Timer(this.components);
            this.trackBar_tick = new System.Windows.Forms.TrackBar();
            this.label_tick = new System.Windows.Forms.Label();
            this.tLP_main.SuspendLayout();
            this.panel_side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_tick)).BeginInit();
            this.SuspendLayout();
            // 
            // tLP_main
            // 
            this.tLP_main.ColumnCount = 2;
            this.tLP_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tLP_main.Controls.Add(this.panel_side, 1, 0);
            this.tLP_main.Controls.Add(this.panel_container, 0, 0);
            this.tLP_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_main.Location = new System.Drawing.Point(0, 0);
            this.tLP_main.Name = "tLP_main";
            this.tLP_main.RowCount = 1;
            this.tLP_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 433F));
            this.tLP_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 433F));
            this.tLP_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 433F));
            this.tLP_main.Size = new System.Drawing.Size(636, 433);
            this.tLP_main.TabIndex = 0;
            // 
            // panel_side
            // 
            this.panel_side.Controls.Add(this.label_tick);
            this.panel_side.Controls.Add(this.trackBar_tick);
            this.panel_side.Controls.Add(this.button_Run);
            this.panel_side.Controls.Add(this.button_Step);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_side.Location = new System.Drawing.Point(536, 0);
            this.panel_side.Margin = new System.Windows.Forms.Padding(0);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(100, 433);
            this.panel_side.TabIndex = 1;
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(10, 32);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(75, 23);
            this.button_Run.TabIndex = 1;
            this.button_Run.Text = "Play";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // button_Step
            // 
            this.button_Step.Location = new System.Drawing.Point(10, 3);
            this.button_Step.Name = "button_Step";
            this.button_Step.Size = new System.Drawing.Size(75, 23);
            this.button_Step.TabIndex = 0;
            this.button_Step.Text = "Step";
            this.button_Step.UseVisualStyleBackColor = true;
            this.button_Step.Click += new System.EventHandler(this.button_Step_Click);
            // 
            // panel_container
            // 
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Margin = new System.Windows.Forms.Padding(0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(536, 433);
            this.panel_container.TabIndex = 2;
            // 
            // timer_world
            // 
            this.timer_world.Interval = 1000;
            this.timer_world.Tick += new System.EventHandler(this.timer_world_Tick);
            // 
            // trackBar_tick
            // 
            this.trackBar_tick.LargeChange = 2;
            this.trackBar_tick.Location = new System.Drawing.Point(0, 62);
            this.trackBar_tick.Maximum = 20;
            this.trackBar_tick.Minimum = 2;
            this.trackBar_tick.Name = "trackBar_tick";
            this.trackBar_tick.Size = new System.Drawing.Size(100, 45);
            this.trackBar_tick.TabIndex = 2;
            this.trackBar_tick.TickFrequency = 2;
            this.trackBar_tick.Value = 10;
            this.trackBar_tick.Scroll += new System.EventHandler(this.trackBar_tick_Scroll);
            // 
            // label_tick
            // 
            this.label_tick.AutoSize = true;
            this.label_tick.Location = new System.Drawing.Point(7, 94);
            this.label_tick.Name = "label_tick";
            this.label_tick.Size = new System.Drawing.Size(74, 13);
            this.label_tick.TabIndex = 3;
            this.label_tick.Text = "Tick: 1000 ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 433);
            this.Controls.Add(this.tLP_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Game of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tLP_main.ResumeLayout(false);
            this.panel_side.ResumeLayout(false);
            this.panel_side.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_tick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_main;
        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.Button button_Step;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Timer timer_world;
        private System.Windows.Forms.TrackBar trackBar_tick;
        private System.Windows.Forms.Label label_tick;
    }
}

