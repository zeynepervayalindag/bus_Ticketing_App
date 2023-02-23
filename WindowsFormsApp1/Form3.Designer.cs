namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kADINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eRKEKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kADINToolStripMenuItem,
            this.eRKEKToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.Size = new System.Drawing.Size(271, 101);
            // 
            // kADINToolStripMenuItem
            // 
            this.kADINToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.kADINToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kADINToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kADINToolStripMenuItem.Image")));
            this.kADINToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kADINToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.kADINToolStripMenuItem.Name = "kADINToolStripMenuItem";
            this.kADINToolStripMenuItem.Size = new System.Drawing.Size(270, 32);
            this.kADINToolStripMenuItem.Text = "KADIN";
            this.kADINToolStripMenuItem.Click += new System.EventHandler(this.kADINToolStripMenuItem_Click_1);
            // 
            // eRKEKToolStripMenuItem
            // 
            this.eRKEKToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.eRKEKToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.eRKEKToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eRKEKToolStripMenuItem.Image")));
            this.eRKEKToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.eRKEKToolStripMenuItem.Name = "eRKEKToolStripMenuItem";
            this.eRKEKToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.eRKEKToolStripMenuItem.Text = "ERKEK";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kADINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eRKEKToolStripMenuItem;
    }
}