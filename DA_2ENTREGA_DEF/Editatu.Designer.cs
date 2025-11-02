namespace DA_ENTREGA2_DEF
{
    partial class Editatu
    {

        private System.ComponentModel.IContainer components = null;


        /// <param name="disposing">true si los recursos administrados deben ser eliminados; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtIzena = new System.Windows.Forms.TextBox();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.txtAbizena2 = new System.Windows.Forms.TextBox();
            this.txtJaiotzaData = new System.Windows.Forms.TextBox();
            this.txtAbizena1 = new System.Windows.Forms.TextBox();
            this.txtNan = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtHelbidea = new System.Windows.Forms.TextBox();
            this.editatu_BTN = new System.Windows.Forms.Button();

            System.Windows.Forms.Label lblIzena = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblAbizena1 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblAbizena2 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblJaiotza = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblNan = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblTelefono = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblHelbidea = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblPosta = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblTitulo = new System.Windows.Forms.Label();

            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editatu Datuak";
            this.Name = "editatu";

            //
            // lblTitulo
            //
            lblTitulo.Text = "Datuen Edizioa";
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(40, 40, 60);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new System.Drawing.Point(280, 30);

            //
            // Posiciones comunes
            //
            int y = 100;

            // Izena
            lblIzena.Text = "Izena:";
            lblIzena.Location = new System.Drawing.Point(100, y);
            lblIzena.AutoSize = true;
            this.txtIzena.Location = new System.Drawing.Point(280, y);
            this.txtIzena.Size = new System.Drawing.Size(350, 27);

            // 1. Abizena
            y += 40;
            lblAbizena1.Text = "1. Abizena:";
            lblAbizena1.Location = new System.Drawing.Point(100, y);
            lblAbizena1.AutoSize = true;
            this.txtAbizena1.Location = new System.Drawing.Point(280, y);
            this.txtAbizena1.Size = new System.Drawing.Size(350, 27);

            // 2. Abizena
            y += 40;
            lblAbizena2.Text = "2. Abizena:";
            lblAbizena2.Location = new System.Drawing.Point(100, y);
            lblAbizena2.AutoSize = true;
            this.txtAbizena2.Location = new System.Drawing.Point(280, y);
            this.txtAbizena2.Size = new System.Drawing.Size(350, 27);

            // Jaiotza Data
            y += 40;
            lblJaiotza.Text = "Jaiotze Data:";
            lblJaiotza.Location = new System.Drawing.Point(100, y);
            lblJaiotza.AutoSize = true;
            this.txtJaiotzaData.Location = new System.Drawing.Point(280, y);
            this.txtJaiotzaData.Size = new System.Drawing.Size(350, 27);
            this.txtJaiotzaData.TextChanged += new System.EventHandler(this.txtJaiotzaData_TextChanged);

            // NAN
            y += 40;
            lblNan.Text = "NAN:";
            lblNan.Location = new System.Drawing.Point(100, y);
            lblNan.AutoSize = true;
            this.txtNan.Location = new System.Drawing.Point(280, y);
            this.txtNan.Size = new System.Drawing.Size(350, 27);

            // Telefonoa
            y += 40;
            lblTelefono.Text = "Telefonoa:";
            lblTelefono.Location = new System.Drawing.Point(100, y);
            lblTelefono.AutoSize = true;
            this.txtTelefono.Location = new System.Drawing.Point(280, y);
            this.txtTelefono.Size = new System.Drawing.Size(350, 27);

            // Helbidea
            y += 40;
            lblHelbidea.Text = "Helbidea:";
            lblHelbidea.Location = new System.Drawing.Point(100, y);
            lblHelbidea.AutoSize = true;
            this.txtHelbidea.Location = new System.Drawing.Point(280, y);
            this.txtHelbidea.Size = new System.Drawing.Size(350, 27);

            // Posta
            y += 40;
            lblPosta.Text = "Posta Elektronikoa:";
            lblPosta.Location = new System.Drawing.Point(100, y);
            lblPosta.AutoSize = true;
            this.txtPosta.Location = new System.Drawing.Point(280, y);
            this.txtPosta.Size = new System.Drawing.Size(350, 27);

            //
            // editatu_BTN
            //
            this.editatu_BTN.Text = "Gorde";
            this.editatu_BTN.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.editatu_BTN.ForeColor = System.Drawing.Color.White;
            this.editatu_BTN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.editatu_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editatu_BTN.FlatAppearance.BorderSize = 0;
            this.editatu_BTN.Location = new System.Drawing.Point(280, 430);
            this.editatu_BTN.Size = new System.Drawing.Size(350, 40);
            this.editatu_BTN.Click += new System.EventHandler(this.editatu_BTN_Click);

            //
            // Añadir controles
            //
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblIzena);
            this.Controls.Add(lblAbizena1);
            this.Controls.Add(lblAbizena2);
            this.Controls.Add(lblJaiotza);
            this.Controls.Add(lblNan);
            this.Controls.Add(lblTelefono);
            this.Controls.Add(lblHelbidea);
            this.Controls.Add(lblPosta);
            this.Controls.Add(this.txtIzena);
            this.Controls.Add(this.txtAbizena1);
            this.Controls.Add(this.txtAbizena2);
            this.Controls.Add(this.txtJaiotzaData);
            this.Controls.Add(this.txtNan);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtHelbidea);
            this.Controls.Add(this.txtPosta);
            this.Controls.Add(this.editatu_BTN);
        }

        #endregion

        private System.Windows.Forms.TextBox txtIzena;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.TextBox txtAbizena2;
        private System.Windows.Forms.TextBox txtJaiotzaData;
        private System.Windows.Forms.TextBox txtAbizena1;
        private System.Windows.Forms.TextBox txtNan;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtHelbidea;
        private System.Windows.Forms.Button editatu_BTN;
    }
}
