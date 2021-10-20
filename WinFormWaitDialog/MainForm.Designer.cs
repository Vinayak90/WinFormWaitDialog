namespace WinFormWaitDialog
{
    partial class MainForm
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
            this.btnStatTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStatTask
            // 
            this.btnStatTask.Location = new System.Drawing.Point(171, 56);
            this.btnStatTask.Name = "btnStatTask";
            this.btnStatTask.Size = new System.Drawing.Size(75, 23);
            this.btnStatTask.TabIndex = 0;
            this.btnStatTask.Text = "Start Task";
            this.btnStatTask.UseVisualStyleBackColor = true;
            this.btnStatTask.Click += new System.EventHandler(this.btnStatTask_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 128);
            this.Controls.Add(this.btnStatTask);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStatTask;
    }
}

