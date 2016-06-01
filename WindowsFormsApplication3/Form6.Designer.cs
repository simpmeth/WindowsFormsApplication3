namespace shop
{
    partial class Dok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dok));
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAdresClient = new System.Windows.Forms.Label();
            this.labelKodClient = new System.Windows.Forms.Label();
            this.labelAdresUser = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelKod = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Summa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.goodsTableAdapter = new shop.dbDataSetTableAdapters.goodsTableAdapter();
            this.clientTableAdapter = new shop.dbDataSetTableAdapters.clientTableAdapter();
            this.dokTableAdapter = new shop.dbDataSetTableAdapters.dokTableAdapter();
            this.userTableAdapter = new shop.dbDataSetTableAdapters.userTableAdapter();
            this.butDelete = new System.Windows.Forms.Button();
            this.nomenklaturaTableAdapter = new shop.dbDataSetTableAdapters.nomenklaturaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.харкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодЕдИЗDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.едИзDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new shop.dbDataSet();
            this.skladTableAdapter = new shop.dbDataSetTableAdapters.skladTableAdapter();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomenklaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new shop.dbDataSetTableAdapters.TableAdapterManager();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomenklaturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(245, 22);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(197, 20);
            this.date.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Общий ИД:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "номер:";
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(15, 98);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(197, 21);
            this.comboClient.TabIndex = 3;
            this.comboClient.Text = "  ";
            this.comboClient.SelectionChangeCommitted += new System.EventHandler(this.comboClient_SelectionChangeCommitted);
            this.comboClient.SelectedValueChanged += new System.EventHandler(this.comboClient_SelectedValueChanged);
            this.comboClient.Click += new System.EventHandler(this.comboClient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Покупатель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Адрес: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Код";
            // 
            // labelAdresClient
            // 
            this.labelAdresClient.AutoSize = true;
            this.labelAdresClient.Location = new System.Drawing.Point(108, 134);
            this.labelAdresClient.Name = "labelAdresClient";
            this.labelAdresClient.Size = new System.Drawing.Size(0, 13);
            this.labelAdresClient.TabIndex = 9;
            // 
            // labelKodClient
            // 
            this.labelKodClient.AutoSize = true;
            this.labelKodClient.Location = new System.Drawing.Point(108, 163);
            this.labelKodClient.Name = "labelKodClient";
            this.labelKodClient.Size = new System.Drawing.Size(0, 13);
            this.labelKodClient.TabIndex = 10;
            // 
            // labelAdresUser
            // 
            this.labelAdresUser.AutoSize = true;
            this.labelAdresUser.Location = new System.Drawing.Point(338, 134);
            this.labelAdresUser.Name = "labelAdresUser";
            this.labelAdresUser.Size = new System.Drawing.Size(0, 13);
            this.labelAdresUser.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(242, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Адрес: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(242, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Кладовщик";
            // 
            // comboUser
            // 
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Location = new System.Drawing.Point(245, 98);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(197, 21);
            this.comboUser.TabIndex = 11;
            this.comboUser.SelectionChangeCommitted += new System.EventHandler(this.comboUser_SelectionChangeCommitted);
            this.comboUser.SelectedValueChanged += new System.EventHandler(this.comboUser_SelectedValueChanged);
            this.comboUser.Click += new System.EventHandler(this.comboUser_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(84, 22);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 13);
            this.labelId.TabIndex = 18;
            // 
            // labelKod
            // 
            this.labelKod.AutoSize = true;
            this.labelKod.Location = new System.Drawing.Point(84, 48);
            this.labelKod.Name = "labelKod";
            this.labelKod.Size = new System.Drawing.Size(0, 13);
            this.labelKod.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Добавить товар";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Summa
            // 
            this.Summa.AutoSize = true;
            this.Summa.BackColor = System.Drawing.Color.Red;
            this.Summa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Summa.Location = new System.Drawing.Point(511, 250);
            this.Summa.Name = "Summa";
            this.Summa.Size = new System.Drawing.Size(18, 20);
            this.Summa.TabIndex = 22;
            this.Summa.Text = "0";
            this.Summa.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(449, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "итого:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(245, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Сохранить накладную";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // dokTableAdapter
            // 
            this.dokTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(131, 224);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(107, 23);
            this.butDelete.TabIndex = 26;
            this.butDelete.Text = "Удалить товар";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // nomenklaturaTableAdapter
            // 
            this.nomenklaturaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.кодПродуктаDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.харкаDataGridViewTextBoxColumn,
            this.колDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.кодЕдИЗDataGridViewTextBoxColumn,
            this.едИзDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.skladBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(549, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Width = 50;
            // 
            // кодПродуктаDataGridViewTextBoxColumn
            // 
            this.кодПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Код Продукта";
            this.кодПродуктаDataGridViewTextBoxColumn.HeaderText = "Код Продукта";
            this.кодПродуктаDataGridViewTextBoxColumn.Name = "кодПродуктаDataGridViewTextBoxColumn";
            this.кодПродуктаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // харкаDataGridViewTextBoxColumn
            // 
            this.харкаDataGridViewTextBoxColumn.DataPropertyName = "Хар-ка";
            this.харкаDataGridViewTextBoxColumn.HeaderText = "Хар-ка";
            this.харкаDataGridViewTextBoxColumn.Name = "харкаDataGridViewTextBoxColumn";
            this.харкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // колDataGridViewTextBoxColumn
            // 
            this.колDataGridViewTextBoxColumn.DataPropertyName = "Кол";
            this.колDataGridViewTextBoxColumn.HeaderText = "Кол";
            this.колDataGridViewTextBoxColumn.Name = "колDataGridViewTextBoxColumn";
            this.колDataGridViewTextBoxColumn.ReadOnly = true;
            this.колDataGridViewTextBoxColumn.Width = 50;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            this.ценаDataGridViewTextBoxColumn.Width = 50;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            this.стоимостьDataGridViewTextBoxColumn.Width = 50;
            // 
            // кодЕдИЗDataGridViewTextBoxColumn
            // 
            this.кодЕдИЗDataGridViewTextBoxColumn.DataPropertyName = "Код Ед ИЗ";
            this.кодЕдИЗDataGridViewTextBoxColumn.HeaderText = "Код Ед ИЗ";
            this.кодЕдИЗDataGridViewTextBoxColumn.Name = "кодЕдИЗDataGridViewTextBoxColumn";
            this.кодЕдИЗDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // едИзDataGridViewTextBoxColumn
            // 
            this.едИзDataGridViewTextBoxColumn.DataPropertyName = "Ед Из";
            this.едИзDataGridViewTextBoxColumn.HeaderText = "Ед Из";
            this.едИзDataGridViewTextBoxColumn.Name = "едИзDataGridViewTextBoxColumn";
            this.едИзDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // skladBindingSource
            // 
            this.skladBindingSource.DataMember = "sklad";
            this.skladBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skladTableAdapter
            // 
            this.skladTableAdapter.ClearBeforeFill = true;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "goods";
            this.goodsBindingSource.DataSource = this.dbDataSet;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.dbDataSet;
            // 
            // dokBindingSource
            // 
            this.dokBindingSource.DataMember = "dok";
            this.dokBindingSource.DataSource = this.dbDataSet;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.dbDataSet;
            // 
            // nomenklaturaBindingSource
            // 
            this.nomenklaturaBindingSource.DataMember = "nomenklatura";
            this.nomenklaturaBindingSource.DataSource = this.dbDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.dokTableAdapter = null;
            this.tableAdapterManager.goodsTableAdapter = null;
            this.tableAdapterManager.nomenklaturaTableAdapter = null;
            this.tableAdapterManager.skladTableAdapter = null;
            this.tableAdapterManager.Table_1TableAdapter = null;
            this.tableAdapterManager.unitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = shop.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(242, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Заполните все поля";
            this.label7.Visible = false;
            // 
            // Dok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 443);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Summa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelKod);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelAdresUser);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboUser);
            this.Controls.Add(this.labelKodClient);
            this.Controls.Add(this.labelAdresClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dok";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dok_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dok_FormClosed);
            this.Load += new System.EventHandler(this.Dok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomenklaturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAdresClient;
        private System.Windows.Forms.Label labelKodClient;
        private System.Windows.Forms.Label labelAdresUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboUser;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelKod;
        private System.Windows.Forms.Button button1;
        private dbDataSet dbDataSet;
        private dbDataSetTableAdapters.skladTableAdapter skladTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn весDataGridViewTextBoxColumn;
        private dbDataSetTableAdapters.goodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private dbDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource dokBindingSource;
        private dbDataSetTableAdapters.dokTableAdapter dokTableAdapter;
        private dbDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label Summa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.BindingSource nomenklaturaBindingSource;
        private dbDataSetTableAdapters.nomenklaturaTableAdapter nomenklaturaTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn харкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЕдИЗDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn едИзDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
    }
}