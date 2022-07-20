
namespace Navegador
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
            this.bBuscar = new System.Windows.Forms.Button();
            this.tBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bVer = new System.Windows.Forms.Button();
            this.bVerde = new System.Windows.Forms.Button();
            this.bAzul = new System.Windows.Forms.Button();
            this.bRojo = new System.Windows.Forms.Button();
            this.bLetraRosa = new System.Windows.Forms.Button();
            this.bLetraAmarillo = new System.Windows.Forms.Button();
            this.bIr = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bWebBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bBuscar.Location = new System.Drawing.Point(161, 51);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(167, 32);
            this.bBuscar.TabIndex = 0;
            this.bBuscar.Text = "Buscar en Google";
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // tBuscar
            // 
            this.tBuscar.Location = new System.Drawing.Point(143, 25);
            this.tBuscar.Name = "tBuscar";
            this.tBuscar.Size = new System.Drawing.Size(472, 20);
            this.tBuscar.TabIndex = 1;
            this.tBuscar.TextChanged += new System.EventHandler(this.tBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bVer
            // 
            this.bVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(227)))), ((int)(((byte)(204)))));
            this.bVer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bVer.Location = new System.Drawing.Point(909, 19);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(109, 40);
            this.bVer.TabIndex = 3;
            this.bVer.Text = "Ocultar botón Buscar";
            this.bVer.UseVisualStyleBackColor = false;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // bVerde
            // 
            this.bVerde.BackColor = System.Drawing.Color.LimeGreen;
            this.bVerde.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bVerde.Location = new System.Drawing.Point(910, 142);
            this.bVerde.Name = "bVerde";
            this.bVerde.Size = new System.Drawing.Size(91, 29);
            this.bVerde.TabIndex = 4;
            this.bVerde.Text = "Fondo Verde";
            this.bVerde.UseVisualStyleBackColor = false;
            this.bVerde.Click += new System.EventHandler(this.button2_Click);
            // 
            // bAzul
            // 
            this.bAzul.BackColor = System.Drawing.Color.Blue;
            this.bAzul.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bAzul.Location = new System.Drawing.Point(909, 188);
            this.bAzul.Name = "bAzul";
            this.bAzul.Size = new System.Drawing.Size(92, 29);
            this.bAzul.TabIndex = 5;
            this.bAzul.Text = "Fondo Azul";
            this.bAzul.UseVisualStyleBackColor = false;
            this.bAzul.Click += new System.EventHandler(this.bAzul_Click);
            // 
            // bRojo
            // 
            this.bRojo.BackColor = System.Drawing.Color.Red;
            this.bRojo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bRojo.Location = new System.Drawing.Point(909, 95);
            this.bRojo.Name = "bRojo";
            this.bRojo.Size = new System.Drawing.Size(92, 30);
            this.bRojo.TabIndex = 6;
            this.bRojo.Text = "Fondo Rojo";
            this.bRojo.UseVisualStyleBackColor = false;
            this.bRojo.Click += new System.EventHandler(this.button4_Click);
            // 
            // bLetraRosa
            // 
            this.bLetraRosa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(200)))));
            this.bLetraRosa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bLetraRosa.Location = new System.Drawing.Point(910, 241);
            this.bLetraRosa.Name = "bLetraRosa";
            this.bLetraRosa.Size = new System.Drawing.Size(91, 33);
            this.bLetraRosa.TabIndex = 7;
            this.bLetraRosa.Text = "Letra Rosa";
            this.bLetraRosa.UseVisualStyleBackColor = false;
            this.bLetraRosa.Click += new System.EventHandler(this.bLetraRosa_Click);
            // 
            // bLetraAmarillo
            // 
            this.bLetraAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.bLetraAmarillo.Location = new System.Drawing.Point(910, 293);
            this.bLetraAmarillo.Name = "bLetraAmarillo";
            this.bLetraAmarillo.Size = new System.Drawing.Size(91, 31);
            this.bLetraAmarillo.TabIndex = 8;
            this.bLetraAmarillo.Text = "Letra Amarilla";
            this.bLetraAmarillo.UseVisualStyleBackColor = false;
            this.bLetraAmarillo.Click += new System.EventHandler(this.bLetraAmarillo_Click);
            // 
            // bIr
            // 
            this.bIr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bIr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bIr.Location = new System.Drawing.Point(414, 51);
            this.bIr.Name = "bIr";
            this.bIr.Size = new System.Drawing.Size(170, 32);
            this.bIr.TabIndex = 9;
            this.bIr.Text = "IR a la URL";
            this.bIr.UseVisualStyleBackColor = false;
            this.bIr.Click += new System.EventHandler(this.bIr_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(18, 95);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(861, 333);
            this.webBrowser1.TabIndex = 10;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // bWebBrowser
            // 
            this.bWebBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bWebBrowser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bWebBrowser.Location = new System.Drawing.Point(910, 344);
            this.bWebBrowser.Name = "bWebBrowser";
            this.bWebBrowser.Size = new System.Drawing.Size(91, 44);
            this.bWebBrowser.TabIndex = 11;
            this.bWebBrowser.Text = "webBrowser Violeta";
            this.bWebBrowser.UseVisualStyleBackColor = false;
            this.bWebBrowser.Click += new System.EventHandler(this.bWebBrowser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1030, 440);
            this.Controls.Add(this.bWebBrowser);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.bIr);
            this.Controls.Add(this.bLetraAmarillo);
            this.Controls.Add(this.bLetraRosa);
            this.Controls.Add(this.bRojo);
            this.Controls.Add(this.bAzul);
            this.Controls.Add(this.bVerde);
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBuscar);
            this.Controls.Add(this.bBuscar);
            this.Name = "Form1";
            this.Text = "Buscador de Google";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox tBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bVer;
        private System.Windows.Forms.Button bVerde;
        private System.Windows.Forms.Button bAzul;
        private System.Windows.Forms.Button bRojo;
        private System.Windows.Forms.Button bLetraRosa;
        private System.Windows.Forms.Button bLetraAmarillo;
        private System.Windows.Forms.Button bIr;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button bWebBrowser;
    }
}

