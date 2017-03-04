namespace FBDialogDemo
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
            this.bFBLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.tbScopes = new System.Windows.Forms.TextBox();
            this.tbAppID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bFBLogin
            // 
            this.bFBLogin.Location = new System.Drawing.Point(521, 60);
            this.bFBLogin.Name = "bFBLogin";
            this.bFBLogin.Size = new System.Drawing.Size(133, 23);
            this.bFBLogin.TabIndex = 0;
            this.bFBLogin.Text = "FB Login...";
            this.bFBLogin.UseVisualStyleBackColor = true;
            this.bFBLogin.Click += new System.EventHandler(this.bFBLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "AppID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Scopes:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(31, 25);
            this.linkLabel1.Location = new System.Drawing.Point(7, 240);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(284, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Written by Kristofer Källsbo - http://www.hackviking.com";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(8, 89);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(646, 147);
            this.lbResult.TabIndex = 5;
            // 
            // tbScopes
            // 
            this.tbScopes.Location = new System.Drawing.Point(54, 34);
            this.tbScopes.Name = "tbScopes";
            this.tbScopes.Size = new System.Drawing.Size(600, 20);
            this.tbScopes.TabIndex = 6;
            this.tbScopes.Text = "user_photos,user_videos";
            // 
            // tbAppID
            // 
            this.tbAppID.Location = new System.Drawing.Point(54, 8);
            this.tbAppID.Name = "tbAppID";
            this.tbAppID.Size = new System.Drawing.Size(600, 20);
            this.tbAppID.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 262);
            this.Controls.Add(this.tbAppID);
            this.Controls.Add(this.tbScopes);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bFBLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "FB Dialog Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFBLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.TextBox tbScopes;
        private System.Windows.Forms.TextBox tbAppID;
    }
}

