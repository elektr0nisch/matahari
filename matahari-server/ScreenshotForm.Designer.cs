namespace Matahari
{
    partial class ScreenshotForm
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
            this.screenshot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.screenshot)).BeginInit();
            this.SuspendLayout();
            // 
            // screenshot
            // 
            this.screenshot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.screenshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenshot.Location = new System.Drawing.Point(0, 0);
            this.screenshot.Name = "screenshot";
            this.screenshot.Size = new System.Drawing.Size(800, 450);
            this.screenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screenshot.TabIndex = 0;
            this.screenshot.TabStop = false;
            this.screenshot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenshotMouseDown);
            this.screenshot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenshotMouseUp);
            // 
            // ScreenshotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.screenshot);
            this.Name = "ScreenshotForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenshotKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ScreenshotKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.screenshot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox screenshot;
    }
}