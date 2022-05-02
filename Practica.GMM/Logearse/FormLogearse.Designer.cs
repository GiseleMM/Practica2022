
namespace Logearse
{
    partial class FormLogearse
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
            this.btn_logearse = new System.Windows.Forms.Button();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.txb_clave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_logearse
            // 
            this.btn_logearse.Location = new System.Drawing.Point(328, 120);
            this.btn_logearse.Name = "btn_logearse";
            this.btn_logearse.Size = new System.Drawing.Size(122, 103);
            this.btn_logearse.TabIndex = 0;
            this.btn_logearse.Text = "Logearse";
            this.btn_logearse.UseVisualStyleBackColor = true;
            this.btn_logearse.Click += new System.EventHandler(this.btn_logearse_Click);
            // 
            // txb_usuario
            // 
            this.txb_usuario.Location = new System.Drawing.Point(332, 34);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.PlaceholderText = "usuario";
            this.txb_usuario.Size = new System.Drawing.Size(118, 23);
            this.txb_usuario.TabIndex = 1;
            // 
            // txb_clave
            // 
            this.txb_clave.Location = new System.Drawing.Point(332, 91);
            this.txb_clave.Name = "txb_clave";
            this.txb_clave.PasswordChar = '*';
            this.txb_clave.PlaceholderText = "clave";
            this.txb_clave.Size = new System.Drawing.Size(118, 23);
            this.txb_clave.TabIndex = 2;
            // 
            // FormLogearse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_clave);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.btn_logearse);
            this.Name = "FormLogearse";
            this.Text = "Form Practica Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logearse;
        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.TextBox txb_clave;
    }
}

