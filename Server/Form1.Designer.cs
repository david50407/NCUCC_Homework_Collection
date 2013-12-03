namespace Server
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataPanel1 = new ClassLibrary.DataPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 284);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Listen Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataPanel1
            // 
            this.dataPanel1.Location = new System.Drawing.Point(12, 12);
            this.dataPanel1.Name = "dataPanel1";
            this.dataPanel1.Size = new System.Drawing.Size(311, 284);
            this.dataPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataPanel1);
            this.Name = "Form1";
            this.Text = "Server 攻攻";
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary.DataPanel dataPanel1;
        private System.Windows.Forms.Button button1;
    }
}

