namespace BANTHUOC
{
    partial class fImportGood
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
            components = new System.ComponentModel.Container();
            soLuongTheoDonViBan = new NumericUpDown();
            hanSuDung = new DateTimePicker();
            btnClose = new Button();
            btnSave = new Button();
            label11 = new Label();
            label10 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            openFileDialog1 = new OpenFileDialog();
            giaNhap = new NumericUpDown();
            label2 = new Label();
            tenThuoc = new ComboBox();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            ImportID = new DataGridViewTextBoxColumn();
            drug_id = new DataGridViewTextBoxColumn();
            import_price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            expiry_date = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            btnAdd = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)soLuongTheoDonViBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)giaNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // soLuongTheoDonViBan
            // 
            soLuongTheoDonViBan.Location = new Point(570, 272);
            soLuongTheoDonViBan.Name = "soLuongTheoDonViBan";
            soLuongTheoDonViBan.Size = new Size(186, 27);
            soLuongTheoDonViBan.TabIndex = 101;
            // 
            // hanSuDung
            // 
            hanSuDung.Format = DateTimePickerFormat.Short;
            hanSuDung.Location = new Point(570, 347);
            hanSuDung.Name = "hanSuDung";
            hanSuDung.Size = new Size(186, 27);
            hanSuDung.TabIndex = 99;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1103, 699);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 55);
            btnClose.TabIndex = 89;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(931, 699);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 55);
            btnSave.TabIndex = 88;
            btnSave.Text = "Lưu";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label11
            // 
            label11.Location = new Point(570, 246);
            label11.Name = "label11";
            label11.Size = new Size(214, 23);
            label11.TabIndex = 85;
            label11.Text = "Số lượng nhập";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(570, 324);
            label10.Name = "label10";
            label10.Size = new Size(93, 20);
            label10.TabIndex = 84;
            label10.Text = "Hạn sử dụng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 249);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 75;
            label1.Text = "Tên thuốc";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // giaNhap
            // 
            giaNhap.Location = new Point(224, 352);
            giaNhap.Name = "giaNhap";
            giaNhap.Size = new Size(209, 27);
            giaNhap.TabIndex = 105;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 329);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 104;
            label2.Text = "Giá nhập";
            // 
            // tenThuoc
            // 
            tenThuoc.FormattingEnabled = true;
            tenThuoc.Location = new Point(224, 272);
            tenThuoc.Name = "tenThuoc";
            tenThuoc.Size = new Size(209, 28);
            tenThuoc.TabIndex = 106;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, ImportID, drug_id, import_price, Quantity, Amount, expiry_date, Delete });
            dataGridView1.Location = new Point(145, 407);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1086, 236);
            dataGridView1.TabIndex = 107;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Mã CTHD";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // ImportID
            // 
            ImportID.DataPropertyName = "import_invoice_id";
            ImportID.HeaderText = "Mã Hóa Đơn Nhập";
            ImportID.MinimumWidth = 6;
            ImportID.Name = "ImportID";
            ImportID.Width = 125;
            // 
            // drug_id
            // 
            drug_id.DataPropertyName = "drug_id";
            drug_id.HeaderText = "Mã Thuốc";
            drug_id.MinimumWidth = 6;
            drug_id.Name = "drug_id";
            drug_id.Width = 125;
            // 
            // import_price
            // 
            import_price.DataPropertyName = "import_price";
            import_price.HeaderText = "Giá Nhập";
            import_price.MinimumWidth = 6;
            import_price.Name = "import_price";
            import_price.Width = 125;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "quantity";
            Quantity.HeaderText = "Số lượng nhập";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "amount";
            Amount.HeaderText = "Thành tiền";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 125;
            // 
            // expiry_date
            // 
            expiry_date.DataPropertyName = "expiry_date";
            expiry_date.HeaderText = "Hạn sử dụng";
            expiry_date.MinimumWidth = 6;
            expiry_date.Name = "expiry_date";
            expiry_date.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 125;
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.save;
            btnAdd.Location = new Point(957, 329);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 55);
            btnAdd.TabIndex = 108;
            btnAdd.Text = "Nhập";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(518, 168);
            label3.Name = "label3";
            label3.Size = new Size(337, 35);
            label3.TabIndex = 109;
            label3.Text = "NHẬP THUỐC TRONG KHO";
            // 
            // fImportGood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 878);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(tenThuoc);
            Controls.Add(giaNhap);
            Controls.Add(label2);
            Controls.Add(soLuongTheoDonViBan);
            Controls.Add(hanSuDung);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label1);
            Name = "fImportGood";
            Text = "Nhập hàng trong kho";
            WindowState = FormWindowState.Maximized;
            Load += fImportGood_Load;
            ((System.ComponentModel.ISupportInitialize)soLuongTheoDonViBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)giaNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown soLuongTheoDonViBan;
        private DateTimePicker hanSuDung;
        private Button btnClose;
        private Button btnSave;
        private Label label11;
        private Label label10;
        private Label label1;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog1;
        private NumericUpDown giaNhap;
        private Label label2;
        private ComboBox tenThuoc;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn ImportID;
        private DataGridViewTextBoxColumn drug_id;
        private DataGridViewTextBoxColumn import_price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn expiry_date;
        private DataGridViewButtonColumn Delete;
        private Label label3;
    }
}