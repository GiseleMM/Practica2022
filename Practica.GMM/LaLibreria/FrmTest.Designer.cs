
namespace LaLibreria
{
    partial class FrmTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_Stock = new System.Windows.Forms.ListBox();
            this.btn_vender = new System.Windows.Forms.Button();
            this.btn_verInforme = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.rtb_Informe = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_Stock);
            this.groupBox1.Controls.Add(this.btn_vender);
            this.groupBox1.Controls.Add(this.btn_verInforme);
            this.groupBox1.Controls.Add(this.btn_salir);
            this.groupBox1.Controls.Add(this.rtb_Informe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 433);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lst_Stock
            // 
            this.lst_Stock.FormattingEnabled = true;
            this.lst_Stock.ItemHeight = 15;
            this.lst_Stock.Location = new System.Drawing.Point(44, 30);
            this.lst_Stock.Name = "lst_Stock";
            this.lst_Stock.Size = new System.Drawing.Size(286, 214);
            this.lst_Stock.TabIndex = 2;
         //BORRADO   this.lst_Stock.SelectedIndexChanged += new System.EventHandler(this.lst_Stock_SelectedIndexChanged);
            // 
            // btn_vender
            // 
            this.btn_vender.Location = new System.Drawing.Point(44, 267);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(286, 32);
            this.btn_vender.TabIndex = 3;
            this.btn_vender.Text = "Vender";
            this.btn_vender.UseVisualStyleBackColor = true;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // btn_verInforme
            // 
            this.btn_verInforme.Location = new System.Drawing.Point(44, 312);
            this.btn_verInforme.Name = "btn_verInforme";
            this.btn_verInforme.Size = new System.Drawing.Size(286, 32);
            this.btn_verInforme.TabIndex = 4;
            this.btn_verInforme.Text = "Ver Informe";
            this.btn_verInforme.UseVisualStyleBackColor = true;
            this.btn_verInforme.Click += new System.EventHandler(this.btn_verInforme_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(44, 355);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(286, 32);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // rtb_Informe
            // 
            this.rtb_Informe.Location = new System.Drawing.Point(350, 30);
            this.rtb_Informe.Name = "rtb_Informe";
            this.rtb_Informe.Size = new System.Drawing.Size(382, 357);
            this.rtb_Informe.TabIndex = 6;
            this.rtb_Informe.Text = "";
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TesterApp de Gisele Medina 2A";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_Stock;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.Button btn_verInforme;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.RichTextBox rtb_Informe;
    }
}

