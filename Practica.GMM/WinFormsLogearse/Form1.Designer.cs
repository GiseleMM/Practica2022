
namespace WinFormsLogearse
{
    partial class Fm_Formulario
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
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_rellenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_usuario
            // 
            this.txb_usuario.Location = new System.Drawing.Point(195, 68);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.PlaceholderText = "Ingrese usario";
            this.txb_usuario.Size = new System.Drawing.Size(418, 23);
            this.txb_usuario.TabIndex = 0;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(195, 113);
            this.txb_password.Name = "txb_password";
            this.txb_password.PasswordChar = '$';
            this.txb_password.PlaceholderText = "Ingrese clave";
            this.txb_password.Size = new System.Drawing.Size(418, 23);
            this.txb_password.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Logearse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_rellenar
            // 
            this.btn_rellenar.Location = new System.Drawing.Point(493, 192);
            this.btn_rellenar.Name = "btn_rellenar";
            this.btn_rellenar.Size = new System.Drawing.Size(120, 23);
            this.btn_rellenar.TabIndex = 3;
            this.btn_rellenar.Text = "rellenar";
            this.btn_rellenar.UseVisualStyleBackColor = true;
            this.btn_rellenar.Click += new System.EventHandler(this.btn_rellenar_Click);
            // 
            // Fm_Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_rellenar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fm_Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logearse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_rellenar;
    }
}

