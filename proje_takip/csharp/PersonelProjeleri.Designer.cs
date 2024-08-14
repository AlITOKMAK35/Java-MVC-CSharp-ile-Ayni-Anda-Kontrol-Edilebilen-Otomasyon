namespace Prpje_Takip
{
    partial class PersonelProjeleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelProjeleriIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projeBaslikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projeAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olusturulmaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oncelikDurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamamlanmaOraniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamamlanmaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamamlanmaDurumuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personelProjelerisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJETAKIPDBDataSet3 = new Prpje_Takip.PROJETAKIPDBDataSet3();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.personelProjelerisTableAdapter = new Prpje_Takip.PROJETAKIPDBDataSet3TableAdapters.PersonelProjelerisTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelProjelerisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETAKIPDBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proje Başlık :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proje Açıklama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Oluşturulma Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tamamlanma Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tamamlanma Oranı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Oluşturulma Durumu :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tamamkanma Durumu :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(45, 398);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelProjeleriIdDataGridViewTextBoxColumn,
            this.projeBaslikDataGridViewTextBoxColumn,
            this.projeAciklamaDataGridViewTextBoxColumn,
            this.olusturulmaTarihiDataGridViewTextBoxColumn,
            this.oncelikDurumuDataGridViewTextBoxColumn,
            this.tamamlanmaOraniDataGridViewTextBoxColumn,
            this.tamamlanmaTarihiDataGridViewTextBoxColumn,
            this.tamamlanmaDurumuDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.personelProjelerisBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 75);
            this.dataGridView1.TabIndex = 0;
            // 
            // personelProjeleriIdDataGridViewTextBoxColumn
            // 
            this.personelProjeleriIdDataGridViewTextBoxColumn.DataPropertyName = "PersonelProjeleriId";
            this.personelProjeleriIdDataGridViewTextBoxColumn.HeaderText = "PersonelProjeleriId";
            this.personelProjeleriIdDataGridViewTextBoxColumn.Name = "personelProjeleriIdDataGridViewTextBoxColumn";
            this.personelProjeleriIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projeBaslikDataGridViewTextBoxColumn
            // 
            this.projeBaslikDataGridViewTextBoxColumn.DataPropertyName = "ProjeBaslik";
            this.projeBaslikDataGridViewTextBoxColumn.HeaderText = "ProjeBaslik";
            this.projeBaslikDataGridViewTextBoxColumn.Name = "projeBaslikDataGridViewTextBoxColumn";
            // 
            // projeAciklamaDataGridViewTextBoxColumn
            // 
            this.projeAciklamaDataGridViewTextBoxColumn.DataPropertyName = "ProjeAciklama";
            this.projeAciklamaDataGridViewTextBoxColumn.HeaderText = "ProjeAciklama";
            this.projeAciklamaDataGridViewTextBoxColumn.Name = "projeAciklamaDataGridViewTextBoxColumn";
            // 
            // olusturulmaTarihiDataGridViewTextBoxColumn
            // 
            this.olusturulmaTarihiDataGridViewTextBoxColumn.DataPropertyName = "OlusturulmaTarihi";
            this.olusturulmaTarihiDataGridViewTextBoxColumn.HeaderText = "OlusturulmaTarihi";
            this.olusturulmaTarihiDataGridViewTextBoxColumn.Name = "olusturulmaTarihiDataGridViewTextBoxColumn";
            // 
            // oncelikDurumuDataGridViewTextBoxColumn
            // 
            this.oncelikDurumuDataGridViewTextBoxColumn.DataPropertyName = "OncelikDurumu";
            this.oncelikDurumuDataGridViewTextBoxColumn.HeaderText = "OncelikDurumu";
            this.oncelikDurumuDataGridViewTextBoxColumn.Name = "oncelikDurumuDataGridViewTextBoxColumn";
            // 
            // tamamlanmaOraniDataGridViewTextBoxColumn
            // 
            this.tamamlanmaOraniDataGridViewTextBoxColumn.DataPropertyName = "TamamlanmaOrani";
            this.tamamlanmaOraniDataGridViewTextBoxColumn.HeaderText = "TamamlanmaOrani";
            this.tamamlanmaOraniDataGridViewTextBoxColumn.Name = "tamamlanmaOraniDataGridViewTextBoxColumn";
            // 
            // tamamlanmaTarihiDataGridViewTextBoxColumn
            // 
            this.tamamlanmaTarihiDataGridViewTextBoxColumn.DataPropertyName = "TamamlanmaTarihi";
            this.tamamlanmaTarihiDataGridViewTextBoxColumn.HeaderText = "TamamlanmaTarihi";
            this.tamamlanmaTarihiDataGridViewTextBoxColumn.Name = "tamamlanmaTarihiDataGridViewTextBoxColumn";
            // 
            // tamamlanmaDurumuDataGridViewCheckBoxColumn
            // 
            this.tamamlanmaDurumuDataGridViewCheckBoxColumn.DataPropertyName = "TamamlanmaDurumu";
            this.tamamlanmaDurumuDataGridViewCheckBoxColumn.HeaderText = "TamamlanmaDurumu";
            this.tamamlanmaDurumuDataGridViewCheckBoxColumn.Name = "tamamlanmaDurumuDataGridViewCheckBoxColumn";
            // 
            // personelProjelerisBindingSource
            // 
            this.personelProjelerisBindingSource.DataMember = "PersonelProjeleris";
            this.personelProjelerisBindingSource.DataSource = this.pROJETAKIPDBDataSet3;
            // 
            // pROJETAKIPDBDataSet3
            // 
            this.pROJETAKIPDBDataSet3.DataSetName = "PROJETAKIPDBDataSet3";
            this.pROJETAKIPDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(248, 246);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(248, 145);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox2.TabIndex = 9;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(248, 337);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox3.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(248, 192);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(248, 292);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 14;
            // 
            // personelProjelerisTableAdapter
            // 
            this.personelProjelerisTableAdapter.ClearBeforeFill = true;
            // 
            // PersonelProjeleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 552);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PersonelProjeleri";
            this.Text = "PersonelProjeleri";
            this.Load += new System.EventHandler(this.PersonelProjeleri_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelProjelerisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETAKIPDBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PROJETAKIPDBDataSet3 pROJETAKIPDBDataSet3;
        private System.Windows.Forms.BindingSource personelProjelerisBindingSource;
        private PROJETAKIPDBDataSet3TableAdapters.PersonelProjelerisTableAdapter personelProjelerisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelProjeleriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projeBaslikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projeAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olusturulmaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oncelikDurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamamlanmaOraniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamamlanmaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tamamlanmaDurumuDataGridViewCheckBoxColumn;
    }
}