namespace DA_ENTREGA2
{
    partial class Menu
    {
        private System.ComponentModel.IContainer components = null;

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
            this.erabiltzaileakKudeatu_BTN = new System.Windows.Forms.Button();
            this.langileakKudeatu_BTN = new System.Windows.Forms.Button();
            this.atzera_BTN = new System.Windows.Forms.Button();
            this.erabiltzaileakEzabatu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // erabiltzaileakKudeatu_BTN
            // 
            this.erabiltzaileakKudeatu_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.erabiltzaileakKudeatu_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.erabiltzaileakKudeatu_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.erabiltzaileakKudeatu_BTN.ForeColor = System.Drawing.Color.White;
            this.erabiltzaileakKudeatu_BTN.Location = new System.Drawing.Point(461, 329);
            this.erabiltzaileakKudeatu_BTN.Name = "erabiltzaileakKudeatu_BTN";
            this.erabiltzaileakKudeatu_BTN.Size = new System.Drawing.Size(283, 203);
            this.erabiltzaileakKudeatu_BTN.TabIndex = 4;
            this.erabiltzaileakKudeatu_BTN.Text = "Erabiltzaileak Kudeatu";
            this.erabiltzaileakKudeatu_BTN.UseVisualStyleBackColor = false;
            this.erabiltzaileakKudeatu_BTN.Click += new System.EventHandler(this.erabiltzaileakKudeatu_BTN_Click);
            // 
            // langileakKudeatu_BTN
            // 
            this.langileakKudeatu_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.langileakKudeatu_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.langileakKudeatu_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.langileakKudeatu_BTN.ForeColor = System.Drawing.Color.White;
            this.langileakKudeatu_BTN.Location = new System.Drawing.Point(761, 329);
            this.langileakKudeatu_BTN.Name = "langileakKudeatu_BTN";
            this.langileakKudeatu_BTN.Size = new System.Drawing.Size(265, 203);
            this.langileakKudeatu_BTN.TabIndex = 5;
            this.langileakKudeatu_BTN.Text = "Langileak Kudeatu";
            this.langileakKudeatu_BTN.UseVisualStyleBackColor = false;
            this.langileakKudeatu_BTN.Click += new System.EventHandler(this.langileakKudeatu_BTN_Click);
            // 
            // atzera_BTN
            // 
            this.atzera_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.atzera_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atzera_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.atzera_BTN.ForeColor = System.Drawing.Color.White;
            this.atzera_BTN.Location = new System.Drawing.Point(1288, 702);
            this.atzera_BTN.Name = "atzera_BTN";
            this.atzera_BTN.Size = new System.Drawing.Size(150, 120);
            this.atzera_BTN.TabIndex = 6;
            this.atzera_BTN.Text = "Atera";
            this.atzera_BTN.UseVisualStyleBackColor = false;
            this.atzera_BTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // erabiltzaileakEzabatu
            // 
            this.erabiltzaileakEzabatu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.erabiltzaileakEzabatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.erabiltzaileakEzabatu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.erabiltzaileakEzabatu.ForeColor = System.Drawing.Color.White;
            this.erabiltzaileakEzabatu.Location = new System.Drawing.Point(613, 557);
            this.erabiltzaileakEzabatu.Name = "erabiltzaileakEzabatu";
            this.erabiltzaileakEzabatu.Size = new System.Drawing.Size(283, 203);
            this.erabiltzaileakEzabatu.TabIndex = 7;
            this.erabiltzaileakEzabatu.Text = "Erabiltzaileak Ezabatu";
            this.erabiltzaileakEzabatu.UseVisualStyleBackColor = false;
            this.erabiltzaileakEzabatu.Click += new System.EventHandler(this.erabiltzaileakEzabatu_Click);
            // 
            // Menu
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1758, 1055);
            this.Controls.Add(this.erabiltzaileakEzabatu);
            this.Controls.Add(this.erabiltzaileakKudeatu_BTN);
            this.Controls.Add(this.langileakKudeatu_BTN);
            this.Controls.Add(this.atzera_BTN);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TXT_menuPrintzipala;
        private System.Windows.Forms.Button erabiltzaileakKudeatu_BTN;
        private System.Windows.Forms.Button atzera_BTN;
        private System.Windows.Forms.Button langileakKudeatu_BTN;
        private System.Windows.Forms.Button erabiltzaileakEzabatu;
    }
}
