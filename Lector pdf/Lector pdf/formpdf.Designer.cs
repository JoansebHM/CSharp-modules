namespace Lector_pdf
{
    partial class formpdf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formpdf));
            this.pdfreader = new AxAcroPDFLib.AxAcroPDF();
            this.btnabrir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pdfreader)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfreader
            // 
            this.pdfreader.Enabled = true;
            this.pdfreader.Location = new System.Drawing.Point(-1, 1);
            this.pdfreader.Name = "pdfreader";
            this.pdfreader.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfreader.OcxState")));
            this.pdfreader.Size = new System.Drawing.Size(487, 451);
            this.pdfreader.TabIndex = 0;
            // 
            // btnabrir
            // 
            this.btnabrir.Location = new System.Drawing.Point(514, 76);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(75, 23);
            this.btnabrir.TabIndex = 1;
            this.btnabrir.Text = "abrir";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.pdfreader);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pdfreader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF pdfreader;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

