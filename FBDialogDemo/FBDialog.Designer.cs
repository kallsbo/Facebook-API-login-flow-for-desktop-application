namespace FBDialogDemo
{
    partial class FBDialog
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
            this.FBwebBrowser = new ExtendedWebBrowser();
            this.SuspendLayout();
            // 
            // FBwebBrowser
            // 
            this.FBwebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FBwebBrowser.Location = new System.Drawing.Point(0, 0);
            this.FBwebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.FBwebBrowser.Name = "FBwebBrowser";
            this.FBwebBrowser.Size = new System.Drawing.Size(513, 398);
            this.FBwebBrowser.TabIndex = 0;
            // 
            // FBDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 398);
            this.Controls.Add(this.FBwebBrowser);
            this.Name = "FBDialog";
            this.Text = "FBDialog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FBDialog_FormClosed);
            this.Load += new System.EventHandler(this.FBDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedWebBrowser FBwebBrowser;


    }
}