namespace DA_2ENTREGA_DEF
{
    partial class langileakKudeatu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sortu_BTN;
        private System.Windows.Forms.Button editatu_BTN;
        private System.Windows.Forms.Button ezabatu_BTN;
        private System.Windows.Forms.Button atzera_BTN;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelBotones;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sortu_BTN = new System.Windows.Forms.Button();
            this.editatu_BTN = new System.Windows.Forms.Button();
            this.ezabatu_BTN = new System.Windows.Forms.Button();
            this.atzera_BTN = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 740);
            this.dataGridView1.TabIndex = 0;
            // 
            // sortu_BTN
            // 
            this.sortu_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
            this.sortu_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.sortu_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortu_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.sortu_BTN.ForeColor = System.Drawing.Color.White;
            this.sortu_BTN.Location = new System.Drawing.Point(0, 0);
            this.sortu_BTN.Name = "sortu_BTN";
            this.sortu_BTN.Size = new System.Drawing.Size(200, 60);
            this.sortu_BTN.TabIndex = 3;
            this.sortu_BTN.Text = "➕ Sortu";
            this.sortu_BTN.UseVisualStyleBackColor = false;
            this.sortu_BTN.Click += new System.EventHandler(this.sortu_BTN_Click);
            // 
            // editatu_BTN
            // 
            this.editatu_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.editatu_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.editatu_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editatu_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.editatu_BTN.ForeColor = System.Drawing.Color.White;
            this.editatu_BTN.Location = new System.Drawing.Point(0, 60);
            this.editatu_BTN.Name = "editatu_BTN";
            this.editatu_BTN.Size = new System.Drawing.Size(200, 60);
            this.editatu_BTN.TabIndex = 2;
            this.editatu_BTN.Text = "✏️ Editatu";
            this.editatu_BTN.UseVisualStyleBackColor = false;
            this.editatu_BTN.Click += new System.EventHandler(this.editatu_BTN_Click);
            // 
            // ezabatu_BTN
            // 
            this.ezabatu_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ezabatu_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ezabatu_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ezabatu_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ezabatu_BTN.ForeColor = System.Drawing.Color.White;
            this.ezabatu_BTN.Location = new System.Drawing.Point(0, 120);
            this.ezabatu_BTN.Name = "ezabatu_BTN";
            this.ezabatu_BTN.Size = new System.Drawing.Size(200, 60);
            this.ezabatu_BTN.TabIndex = 1;
            this.ezabatu_BTN.Text = "Ezabatu";
            this.ezabatu_BTN.UseVisualStyleBackColor = false;
            this.ezabatu_BTN.Click += new System.EventHandler(this.ezabatu_BTN_Click);
            // 
            // atzera_BTN
            // 
            this.atzera_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.atzera_BTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.atzera_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atzera_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.atzera_BTN.ForeColor = System.Drawing.Color.Black;
            this.atzera_BTN.Location = new System.Drawing.Point(0, 680);
            this.atzera_BTN.Name = "atzera_BTN";
            this.atzera_BTN.Size = new System.Drawing.Size(200, 60);
            this.atzera_BTN.TabIndex = 0;
            this.atzera_BTN.Text = "Atzera";
            this.atzera_BTN.UseVisualStyleBackColor = false;
            this.atzera_BTN.Click += new System.EventHandler(this.atzera_BTN_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1200, 60);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Langileen kudeaketa";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelBotones.Controls.Add(this.atzera_BTN);
            this.panelBotones.Controls.Add(this.ezabatu_BTN);
            this.panelBotones.Controls.Add(this.editatu_BTN);
            this.panelBotones.Controls.Add(this.sortu_BTN);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotones.Location = new System.Drawing.Point(1000, 60);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(200, 740);
            this.panelBotones.TabIndex = 1;
            // 
            // langileakKudeatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "langileakKudeatu";
            this.Text = "Langileak Kudeatu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

    }
}