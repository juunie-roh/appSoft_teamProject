﻿namespace WindowsFormsApp1
{
    partial class Compare
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(765, 505);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://search.naver.com/search.naver?where=nexearch&sm=top_sug.pre&fbm=0&acr=2&a" +
        "cq=%EC%BD%94%EB%A1%9C%EB%82%98+%ED%98%84%ED%99%A9&qdt=0&ie=utf8&query=%EC%BD%94%" +
        "EB%A1%9C%EB%82%98+%ED%98%84%ED%99%A9", System.UriKind.Absolute);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScrollBarsEnabled = false;
            this.webBrowser2.Size = new System.Drawing.Size(765, 505);
            this.webBrowser2.TabIndex = 1;
            this.webBrowser2.Url = new System.Uri("https://search.naver.com/search.naver?where=nexearch&sm=top_sug.pre&fbm=0&acr=2&a" +
        "cq=%EC%BD%94%EB%A1%9C%EB%82%98+%ED%98%84%ED%99%A9&qdt=0&ie=utf8&query=%EC%BD%94%" +
        "EB%A1%9C%EB%82%98+%ED%98%84%ED%99%A9", System.UriKind.Absolute);
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 505);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Compare";
            this.Text = "Compare";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
    }
}