namespace MagazaDuzen
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokKontrolDataSet2 = new MagazaDuzen.StokKontrolDataSet2();
            this.computerInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerInformationTableAdapter = new MagazaDuzen.StokKontrolDataSet2TableAdapters.ComputerInformationTableAdapter();
            this.deviceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicestockDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deviceprizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicememoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicescreenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicefromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokKontrolDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(451, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Taxson Technology";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(820, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bilgisayar Güncel Stok Durumu İçin Tıklayınız";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(886, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Bilgisayar Güncel Stok Durumu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(1, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1267, 259);
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
            this.deviceprizeDataGridViewTextBoxColumn,
            this.deviceramDataGridViewTextBoxColumn,
            this.devicememoryDataGridViewTextBoxColumn,
            this.devicescreenDataGridViewTextBoxColumn,
            this.devicefromDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.computerInformationBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1261, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // stokKontrolDataSet2
            // 
            this.stokKontrolDataSet2.DataSetName = "StokKontrolDataSet2";
            this.stokKontrolDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // computerInformationBindingSource
            // 
            this.computerInformationBindingSource.DataMember = "ComputerInformation";
            this.computerInformationBindingSource.DataSource = this.stokKontrolDataSet2;
            // 
            // computerInformationTableAdapter
            // 
            this.computerInformationTableAdapter.ClearBeforeFill = true;
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
            // deviceprizeDataGridViewTextBoxColumn
            // 
            this.deviceprizeDataGridViewTextBoxColumn.DataPropertyName = "Deviceprize";
            this.deviceprizeDataGridViewTextBoxColumn.HeaderText = "Deviceprize";
            this.deviceprizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deviceprizeDataGridViewTextBoxColumn.Name = "deviceprizeDataGridViewTextBoxColumn";
            this.deviceprizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // deviceramDataGridViewTextBoxColumn
            // 
            this.deviceramDataGridViewTextBoxColumn.DataPropertyName = "Deviceram";
            this.deviceramDataGridViewTextBoxColumn.HeaderText = "Deviceram";
            this.deviceramDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deviceramDataGridViewTextBoxColumn.Name = "deviceramDataGridViewTextBoxColumn";
            this.deviceramDataGridViewTextBoxColumn.Width = 125;
            // 
            // devicememoryDataGridViewTextBoxColumn
            // 
            this.devicememoryDataGridViewTextBoxColumn.DataPropertyName = "Devicememory";
            this.devicememoryDataGridViewTextBoxColumn.HeaderText = "Devicememory";
            this.devicememoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.devicememoryDataGridViewTextBoxColumn.Name = "devicememoryDataGridViewTextBoxColumn";
            this.devicememoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // devicescreenDataGridViewTextBoxColumn
            // 
            this.devicescreenDataGridViewTextBoxColumn.DataPropertyName = "Devicescreen";
            this.devicescreenDataGridViewTextBoxColumn.HeaderText = "Devicescreen";
            this.devicescreenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.devicescreenDataGridViewTextBoxColumn.Name = "devicescreenDataGridViewTextBoxColumn";
            this.devicescreenDataGridViewTextBoxColumn.Width = 125;
            // 
            // devicefromDataGridViewTextBoxColumn
            // 
            this.devicefromDataGridViewTextBoxColumn.DataPropertyName = "Devicefrom";
            this.devicefromDataGridViewTextBoxColumn.HeaderText = "Devicefrom";
            this.devicefromDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.devicefromDataGridViewTextBoxColumn.Name = "devicefromDataGridViewTextBoxColumn";
            this.devicefromDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1271, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokKontrolDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerInformationBindingSource)).EndInit();
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
        private StokKontrolDataSet2 stokKontrolDataSet2;
        private System.Windows.Forms.BindingSource computerInformationBindingSource;
        private StokKontrolDataSet2TableAdapters.ComputerInformationTableAdapter computerInformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn devicestockDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceprizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicememoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicescreenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicefromDataGridViewTextBoxColumn;
    }
}