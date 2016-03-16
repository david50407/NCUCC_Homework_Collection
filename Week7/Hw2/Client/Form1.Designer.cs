namespace Client
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
            this.dataPanel1 = new ClassLibrary.DataPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataPanel1
            // 
            this.dataPanel1.Location = new System.Drawing.Point(12, 12);
            this.dataPanel1.Name = "dataPanel1";
            this.dataPanel1.Size = new System.Drawing.Size(270, 326);
            this.dataPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 326);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send Class Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Client  小受";
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary.DataPanel dataPanel1;
        private System.Windows.Forms.Button button1;
    }
}

