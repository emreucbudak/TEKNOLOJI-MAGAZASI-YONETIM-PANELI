namespace MagazaDuzen
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokKontrolDataSet1 = new MagazaDuzen.StokKontrolDataSet1();
            this.whiteInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.whiteInformationTableAdapter = new MagazaDuzen.StokKontrolDataSet1TableAdapters.WhiteInformationTableAdapter();
            this.deviceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicestockDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deviceaddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceprizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicefromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicecapasityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokKontrolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(367, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Taxon Technology";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(-3, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(719, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Güncel Beyaz Eşya Stok Durumu İçin Tıklayınız";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(785, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(439, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = " Güncel Stok";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(4, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1230, 290);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deviceidDataGridViewTextBoxColumn,
            this.devicenameDataGridViewTextBoxColumn,
            this.devicestockDataGridViewCheckBoxColumn,
            this.deviceaddDataGridViewTextBoxColumn,
            this.deviceprizeDataGridViewTextBoxColumn,
            this.devicefromDataGridViewTextBoxColumn,
            this.devicecapasityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.whiteInformationBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1224, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // stokKontrolDataSet1
            // 
            this.stokKontrolDataSet1.DataSetName = "StokKontrolDataSet1";
            this.stokKontrolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // whiteInformationBindingSource
            // 
            this.whiteInformationBindingSource.DataMember = "WhiteInformation";
            this.whiteInformationBindingSource.DataSource = this.stokKontrolDataSet1;
            // 
            // whiteInformationTableAdapter
            // 
            this.whiteInformationTableAdapter.ClearBeforeFill = true;
            // 
            // deviceidDataGridViewTextBoxColumn
            // 
            this.deviceidDataGridViewTextBoxColumn.DataPropertyName = "Deviceid";
            this.deviceidDataGridViewTextBoxColumn.HeaderText = "Deviceid";
            this.deviceidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deviceidDataGridViewTextBoxColumn.Name = "deviceidDataGridViewTextBoxColumn";
            this.deviceidDataGridViewTextBoxColumn.ReadOnly = true;
            this.deviceidDataGridViewTextBoxColumn.Width = 125;
            // 
            // devicenameDataGridViewTextBoxColumn
            // 
            this.devicenameDataGridViewTextBoxColumn.DataPropertyName = "Devicename";
            this.devicenameDataGridViewTextBoxColumn.HeaderText = "Devicename";
            this.devicenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.devicenameDataGridViewTextBoxColumn.Name = "devicenameDataGridViewTextBoxColumn";
            this.devicenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // devicestockDataGridViewCheckBoxColumn
            // 
            this.devicestockDataGridViewCheckBoxColumn.DataPropertyName = "Devicestock";
            this.devicestockDataGridViewCheckBoxColumn.HeaderText = "Devicestock";
            this.devicestockDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.devicestockDataGridViewCheckBoxColumn.Name = "devicestockDataGridViewCheckBoxColumn";
            this.devicestockDataGridViewCheckBoxColumn.Width = 125;
            // 
            // deviceaddDataGridViewTextBoxColumn
            // 
            this.deviceaddDataGridViewTextBoxColumn.DataPropertyName = "Deviceadd";
            this.deviceaddDataGridViewTextBoxColumn.HeaderText = "Deviceadd";
            this.deviceaddDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deviceaddDataGridViewTextBoxColumn.Name = "deviceaddDataGridViewTextBoxColumn";
            this.deviceaddDataGridViewTextBoxColumn.Width = 125;
            // 
            // deviceprizeDataGridViewTextBoxColumn
            // 
            this.deviceprizeDataGridViewTextBoxColumn.DataPropertyName = "Deviceprize";
            this.deviceprizeDataGridViewTextBoxColumn.HeaderText = "Deviceprize";
            this.deviceprizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deviceprizeDataGridViewTextBoxColumn.Name = "deviceprizeDataGridViewTextBoxColumn";
            this.deviceprizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // devicefromDataGridViewTextBoxColumn
            // 
            this.devicefromDataGridViewTextBoxColumn.DataPropertyName = "Devicefrom";
            this.devicefromDataGridViewTextBoxColumn.HeaderText = "Devicefrom";
            this.devicefromDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.devicefromDataGridViewTextBoxColumn.Name = "devicefromDataGridViewTextBoxColumn";
            this.devicefromDataGridViewTextBoxColumn.Width = 125;
            // 
            // devicecapasityDataGridViewTextBoxColumn
            // 
            this.devicecapasityDataGridViewTextBoxColumn.DataPropertyName = "Devicecapasity";
            this.devicecapasityDataGridViewTextBoxColumn.HeaderText = "Devicecapasity";
            this.devicecapasityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.devicecapasityDataGridViewTextBoxColumn.Name = "devicecapasityDataGridViewTextBoxColumn";
            this.devicecapasityDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1236, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Beyaz Eşya";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokKontrolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteInformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StokKontrolDataSet1 stokKontrolDataSet1;
        private System.Windows.Forms.BindingSource whiteInformationBindingSource;
        private StokKontrolDataSet1TableAdapters.WhiteInformationTableAdapter whiteInformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn devicestockDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceaddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceprizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicefromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicecapasityDataGridViewTextBoxColumn;
    }
}