namespace DA_2ENTREGA_DEF
{
    partial class LangileaEditatu
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
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "langileaEditatu";
            this.Load += new System.EventHandler(this.langileaEditatu_Load);
            this.ResumeLayout(false);

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