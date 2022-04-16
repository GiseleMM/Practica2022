
namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_texto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_igresoDatos = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.BackColor = System.Drawing.SystemColors.WindowText;
            this.lb_texto.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_texto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_texto.Location = new System.Drawing.Point(167, 20);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(462, 37);
            this.lb_texto.TabIndex = 0;
            this.lb_texto.Text = "Texto modificado con propiedad Text ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostrar Mensaje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_igresoDatos
            // 
            this.txb_igresoDatos.Location = new System.Drawing.Point(106, 184);
            this.txb_igresoDatos.Name = "txb_igresoDatos";
            this.txb_igresoDatos.PlaceholderText = "Ingrese Mensaje";
            this.txb_igresoDatos.Size = new System.Drawing.Size(247, 23);
            this.txb_igresoDatos.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txb_igresoDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_texto);
            this.Name = "Form1";
            this.Text = "CambioTituloForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_igresoDatos;
        private System.Windows.Forms.Button button2;
    }
}

