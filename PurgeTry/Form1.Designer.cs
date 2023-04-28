namespace PurgeTry
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
            this.Delete = new System.Windows.Forms.Button();
            this.myLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.IndianRed;
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.Location = new System.Drawing.Point(19, 96);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(259, 85);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // myLabel
            // 
            this.myLabel.Location = new System.Drawing.Point(65, 20);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(154, 52);
            this.myLabel.TabIndex = 1;
            this.myLabel.Text = "Show\r\n";
            this.myLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 207);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.Delete);
            this.Name = "Form1";
            this.Text = "Purge";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label myLabel;
    }
}

