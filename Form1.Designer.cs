namespace multithreaded_code
{
    partial class Multithreading
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.prbProcessProgress = new System.Windows.Forms.ProgressBar();
            this.btnShowMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("NSimSun", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(131, 32);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(312, 28);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "MULTITHREADING IN C#";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(136, 130);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(307, 69);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "RUN PROCESS";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // prbProcessProgress
            // 
            this.prbProcessProgress.Location = new System.Drawing.Point(136, 219);
            this.prbProcessProgress.Name = "prbProcessProgress";
            this.prbProcessProgress.Size = new System.Drawing.Size(307, 69);
            this.prbProcessProgress.TabIndex = 2;
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.Location = new System.Drawing.Point(136, 309);
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.Size = new System.Drawing.Size(307, 69);
            this.btnShowMessage.TabIndex = 3;
            this.btnShowMessage.Text = "SHOW MESSAGE";
            this.btnShowMessage.UseVisualStyleBackColor = true;
            this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
            // 
            // Multithreading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 461);
            this.Controls.Add(this.btnShowMessage);
            this.Controls.Add(this.prbProcessProgress);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblHeading);
            this.Name = "Multithreading";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ProgressBar prbProcessProgress;
        private System.Windows.Forms.Button btnShowMessage;
    }
}

