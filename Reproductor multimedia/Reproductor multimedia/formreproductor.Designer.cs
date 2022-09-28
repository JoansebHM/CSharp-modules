namespace Reproductor_multimedia
{
    partial class formultimedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formultimedia));
            this.btnabrir = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnparar = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.abrir = new System.Windows.Forms.OpenFileDialog();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnstop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnabrir
            // 
            this.btnabrir.Location = new System.Drawing.Point(60, 300);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(70, 23);
            this.btnabrir.TabIndex = 1;
            this.btnabrir.Text = "Abrir";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(141, 300);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(70, 23);
            this.btnplay.TabIndex = 2;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(222, 300);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(70, 23);
            this.btnsiguiente.TabIndex = 3;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Location = new System.Drawing.Point(303, 300);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(70, 23);
            this.btnanterior.TabIndex = 4;
            this.btnanterior.Text = "Anterior";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnparar
            // 
            this.btnparar.Location = new System.Drawing.Point(384, 300);
            this.btnparar.Name = "btnparar";
            this.btnparar.Size = new System.Drawing.Size(70, 23);
            this.btnparar.TabIndex = 5;
            this.btnparar.Text = "Pausa";
            this.btnparar.UseVisualStyleBackColor = true;
            this.btnparar.Click += new System.EventHandler(this.btnparar_Click);
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(22, 339);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(585, 108);
            this.Lista.TabIndex = 7;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // abrir
            // 
            this.abrir.FileName = "openFileDialog1";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(595, 266);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(460, 300);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(75, 23);
            this.btnstop.TabIndex = 8;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // formultimedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 469);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.btnparar);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "formultimedia";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnparar;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.OpenFileDialog abrir;
        private System.Windows.Forms.Button btnstop;
    }
}

