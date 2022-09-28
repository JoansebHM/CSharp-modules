namespace Aplicación_web
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmBackwards = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmForward = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 426);
            this.webBrowser1.TabIndex = 0;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 24);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(800, 426);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBackwards,
            this.tsmForward,
            this.tsmRefresh,
            this.tsmHome,
            this.tsmSearch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmBackwards
            // 
            this.tsmBackwards.Name = "tsmBackwards";
            this.tsmBackwards.Size = new System.Drawing.Size(27, 20);
            this.tsmBackwards.Text = "<";
            this.tsmBackwards.Click += new System.EventHandler(this.tsmBackwards_Click);
            // 
            // tsmForward
            // 
            this.tsmForward.Name = "tsmForward";
            this.tsmForward.Size = new System.Drawing.Size(27, 20);
            this.tsmForward.Text = ">";
            this.tsmForward.Click += new System.EventHandler(this.tsmForward_Click);
            // 
            // tsmRefresh
            // 
            this.tsmRefresh.Name = "tsmRefresh";
            this.tsmRefresh.Size = new System.Drawing.Size(58, 20);
            this.tsmRefresh.Text = "Refresh";
            this.tsmRefresh.Click += new System.EventHandler(this.tsmRefresh_Click);
            // 
            // tsmHome
            // 
            this.tsmHome.Name = "tsmHome";
            this.tsmHome.Size = new System.Drawing.Size(52, 20);
            this.tsmHome.Text = "Home";
            this.tsmHome.Click += new System.EventHandler(this.tsmHome_Click);
            // 
            // tsmSearch
            // 
            this.tsmSearch.Name = "tsmSearch";
            this.tsmSearch.Size = new System.Drawing.Size(54, 20);
            this.tsmSearch.Text = "Search";
            this.tsmSearch.Click += new System.EventHandler(this.tsmSearch_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(219, 4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(492, 20);
            this.txtBusqueda.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmBackwards;
        private System.Windows.Forms.ToolStripMenuItem tsmForward;
        private System.Windows.Forms.ToolStripMenuItem tsmRefresh;
        private System.Windows.Forms.ToolStripMenuItem tsmHome;
        private System.Windows.Forms.ToolStripMenuItem tsmSearch;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}

