
namespace UI
{
    partial class AltaJugador
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
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_dni = new System.Windows.Forms.TextBox();
            this.txb_goles = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.cbx_posicion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(344, 87);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.PlaceholderText = "Ingrese nombre";
            this.txb_nombre.Size = new System.Drawing.Size(100, 23);
            this.txb_nombre.TabIndex = 0;
            // 
            // txb_dni
            // 
            this.txb_dni.Location = new System.Drawing.Point(344, 145);
            this.txb_dni.Name = "txb_dni";
            this.txb_dni.PlaceholderText = "Ingrese dni";
            this.txb_dni.Size = new System.Drawing.Size(100, 23);
            this.txb_dni.TabIndex = 2;
            // 
            // txb_goles
            // 
            this.txb_goles.Location = new System.Drawing.Point(344, 174);
            this.txb_goles.Name = "txb_goles";
            this.txb_goles.PlaceholderText = "Ingrese goles";
            this.txb_goles.Size = new System.Drawing.Size(100, 23);
            this.txb_goles.TabIndex = 3;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(271, 214);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(442, 214);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cbx_posicion
            // 
            this.cbx_posicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_posicion.FormattingEnabled = true;
            this.cbx_posicion.Location = new System.Drawing.Point(335, 116);
            this.cbx_posicion.Name = "cbx_posicion";
            this.cbx_posicion.Size = new System.Drawing.Size(121, 23);
            this.cbx_posicion.TabIndex = 6;
            // 
            // AltaJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbx_posicion);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txb_goles);
            this.Controls.Add(this.txb_dni);
            this.Controls.Add(this.txb_nombre);
            this.Name = "AltaJugador";
            this.Text = "AltaJugador";
            this.Load += new System.EventHandler(this.AltaJugador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.TextBox txb_dni;
        private System.Windows.Forms.TextBox txb_goles;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox cbx_posicion;
    }
}