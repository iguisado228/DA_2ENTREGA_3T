namespace DA_2ENTREGA_DEF
{
    partial class LangileaEditatu
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Limpieza de recursos
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtIzena = new System.Windows.Forms.TextBox();
            this.txtAbizena1 = new System.Windows.Forms.TextBox();
            this.txtAbizena2 = new System.Windows.Forms.TextBox();
            this.txtNan = new System.Windows.Forms.TextBox();
            this.txtJaiotzaData = new System.Windows.Forms.TextBox();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtHelbidea = new System.Windows.Forms.TextBox();
            this.editatu_BTN = new System.Windows.Forms.Button();

            // Labels
            this.lblIzena = new System.Windows.Forms.Label();
            this.lblAbizena1 = new System.Windows.Forms.Label();
            this.lblAbizena2 = new System.Windows.Forms.Label();
            this.lblNan = new System.Windows.Forms.Label();
            this.lblJaiotzaData = new System.Windows.Forms.Label();
            this.lblPosta = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblHelbidea = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // === FORM ===
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Text = "Langilea Editatu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            int leftLabel = 100;
            int leftText = 250;
            int top = 50;
            int spacing = 40;

            // === Labels y TextBoxes ===
            // Izena
            this.lblIzena.Text = "Izena:";
            this.lblIzena.Location = new System.Drawing.Point(leftLabel, top);
            this.lblIzena.AutoSize = true;

            this.txtIzena.Location = new System.Drawing.Point(leftText, top - 3);
            this.txtIzena.Size = new System.Drawing.Size(300, 22);

            // Abizena1
            this.lblAbizena1.Text = "Lehen abizena:";
            this.lblAbizena1.Location = new System.Drawing.Point(leftLabel, top + spacing);
            this.lblAbizena1.AutoSize = true;

            this.txtAbizena1.Location = new System.Drawing.Point(leftText, top + spacing - 3);
            this.txtAbizena1.Size = new System.Drawing.Size(300, 22);

            // Abizena2
            this.lblAbizena2.Text = "Bigarren abizena:";
            this.lblAbizena2.Location = new System.Drawing.Point(leftLabel, top + spacing * 2);
            this.lblAbizena2.AutoSize = true;

            this.txtAbizena2.Location = new System.Drawing.Point(leftText, top + spacing * 2 - 3);
            this.txtAbizena2.Size = new System.Drawing.Size(300, 22);

            // NAN
            this.lblNan.Text = "NAN:";
            this.lblNan.Location = new System.Drawing.Point(leftLabel, top + spacing * 3);
            this.lblNan.AutoSize = true;

            this.txtNan.Location = new System.Drawing.Point(leftText, top + spacing * 3 - 3);
            this.txtNan.Size = new System.Drawing.Size(300, 22);

            // Jaiotza data
            this.lblJaiotzaData.Text = "Jaiotza data:";
            this.lblJaiotzaData.Location = new System.Drawing.Point(leftLabel, top + spacing * 4);
            this.lblJaiotzaData.AutoSize = true;

            this.txtJaiotzaData.Location = new System.Drawing.Point(leftText, top + spacing * 4 - 3);
            this.txtJaiotzaData.Size = new System.Drawing.Size(300, 22);

            // Posta
            this.lblPosta.Text = "Posta elektronikoa:";
            this.lblPosta.Location = new System.Drawing.Point(leftLabel, top + spacing * 5);
            this.lblPosta.AutoSize = true;

            this.txtPosta.Location = new System.Drawing.Point(leftText, top + spacing * 5 - 3);
            this.txtPosta.Size = new System.Drawing.Size(300, 22);

            // Telefono
            this.lblTelefono.Text = "Telefono zenbakia:";
            this.lblTelefono.Location = new System.Drawing.Point(leftLabel, top + spacing * 6);
            this.lblTelefono.AutoSize = true;

            this.txtTelefono.Location = new System.Drawing.Point(leftText, top + spacing * 6 - 3);
            this.txtTelefono.Size = new System.Drawing.Size(300, 22);

            // Helbidea
            this.lblHelbidea.Text = "Helbidea:";
            this.lblHelbidea.Location = new System.Drawing.Point(leftLabel, top + spacing * 7);
            this.lblHelbidea.AutoSize = true;

            this.txtHelbidea.Location = new System.Drawing.Point(leftText, top + spacing * 7 - 3);
            this.txtHelbidea.Size = new System.Drawing.Size(300, 22);

            // === Botón ===
            this.editatu_BTN.Text = "Eguneratu";
            this.editatu_BTN.Location = new System.Drawing.Point(250, top + spacing * 9);
            this.editatu_BTN.Size = new System.Drawing.Size(200, 35);
            this.editatu_BTN.Click += new System.EventHandler(this.editatu_BTN_Click);

            // === Añadir controles ===
            this.Controls.Add(this.lblIzena);
            this.Controls.Add(this.txtIzena);
            this.Controls.Add(this.lblAbizena1);
            this.Controls.Add(this.txtAbizena1);
            this.Controls.Add(this.lblAbizena2);
            this.Controls.Add(this.txtAbizena2);
            this.Controls.Add(this.lblNan);
            this.Controls.Add(this.txtNan);
            this.Controls.Add(this.lblJaiotzaData);
            this.Controls.Add(this.txtJaiotzaData);
            this.Controls.Add(this.lblPosta);
            this.Controls.Add(this.txtPosta);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblHelbidea);
            this.Controls.Add(this.txtHelbidea);
            this.Controls.Add(this.editatu_BTN);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtIzena;
        private System.Windows.Forms.TextBox txtAbizena1;
        private System.Windows.Forms.TextBox txtAbizena2;
        private System.Windows.Forms.TextBox txtNan;
        private System.Windows.Forms.TextBox txtJaiotzaData;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtHelbidea;
        private System.Windows.Forms.Button editatu_BTN;

        private System.Windows.Forms.Label lblIzena;
        private System.Windows.Forms.Label lblAbizena1;
        private System.Windows.Forms.Label lblAbizena2;
        private System.Windows.Forms.Label lblNan;
        private System.Windows.Forms.Label lblJaiotzaData;
        private System.Windows.Forms.Label lblPosta;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblHelbidea;
    }
}
