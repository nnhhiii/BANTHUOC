namespace BANTHUOC
{
    partial class fManageSellDrug
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
            tenThuoc = new ComboBox();
            label1 = new Label();
            donGia = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            soLuongTon = new TextBox();
            soLuong = new NumericUpDown();
            dataGridView1 = new DataGridView();
            drug_id = new DataGridViewTextBoxColumn();
            drug_name = new DataGridViewTextBoxColumn();
            supplier_name = new DataGridViewTextBoxColumn();
            content = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            unit_name = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            tongThanhTien = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAdd = new Button();
            donVi = new TextBox();
            btnClose = new Button();
            toolTip1 = new ToolTip(components);
            btnThanhToan = new Button();
            ((System.ComponentModel.ISupportInitialize)soLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tenThuoc
            // 
            tenThuoc.FormattingEnabled = true;
            tenThuoc.Location = new Point(151, 202);
            tenThuoc.Name = "tenThuoc";
            tenThuoc.Size = new Size(209, 28);
            tenThuoc.TabIndex = 107;
            tenThuoc.SelectedIndexChanged += tenThuoc_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 179);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 108;
            label1.Text = "Chọn thuốc";
            // 
            // donGia
            // 
            donGia.Enabled = false;
            donGia.Location = new Point(151, 278);
            donGia.Name = "donGia";
            donGia.Size = new Size(209, 27);
            donGia.TabIndex = 109;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // soLuongTon
            // 
            soLuongTon.Enabled = false;
            soLuongTon.Location = new Point(751, 278);
            soLuongTon.Name = "soLuongTon";
            soLuongTon.Size = new Size(209, 27);
            soLuongTon.TabIndex = 111;
            // 
            // soLuong
            // 
            soLuong.Location = new Point(446, 202);
            soLuong.Name = "soLuong";
            soLuong.Size = new Size(209, 27);
            soLuong.TabIndex = 114;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { drug_id, drug_name, supplier_name, content, price, quantity, unit_name, amount, delete });
            dataGridView1.Location = new Point(76, 336);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1402, 298);
            dataGridView1.TabIndex = 115;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // drug_id
            // 
            drug_id.DataPropertyName = "MaThuoc";
            drug_id.HeaderText = "Mã Thuốc";
            drug_id.MinimumWidth = 6;
            drug_id.Name = "drug_id";
            drug_id.Width = 125;
            // 
            // drug_name
            // 
            drug_name.DataPropertyName = "DrugName";
            drug_name.HeaderText = "Tên Thuốc";
            drug_name.MinimumWidth = 6;
            drug_name.Name = "drug_name";
            drug_name.Width = 125;
            // 
            // supplier_name
            // 
            supplier_name.DataPropertyName = "SupplierName";
            supplier_name.HeaderText = "Hãng Sản Xuất";
            supplier_name.MinimumWidth = 6;
            supplier_name.Name = "supplier_name";
            supplier_name.Width = 125;
            // 
            // content
            // 
            content.DataPropertyName = "Content";
            content.HeaderText = "Hàm Lượng";
            content.MinimumWidth = 6;
            content.Name = "content";
            content.Width = 125;
            // 
            // price
            // 
            price.DataPropertyName = "Price";
            price.HeaderText = "Giá Bán";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Width = 125;
            // 
            // quantity
            // 
            quantity.DataPropertyName = "Quantity";
            quantity.HeaderText = "Số lượng";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.Width = 125;
            // 
            // unit_name
            // 
            unit_name.DataPropertyName = "UnitName";
            unit_name.HeaderText = "Đơn Vị";
            unit_name.MinimumWidth = 6;
            unit_name.Name = "unit_name";
            unit_name.Width = 125;
            // 
            // amount
            // 
            amount.DataPropertyName = "Amount";
            amount.HeaderText = "Thành Tiền";
            amount.MinimumWidth = 6;
            amount.Name = "amount";
            amount.Width = 125;
            // 
            // delete
            // 
            delete.HeaderText = "Xóa";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.Text = "Xóa";
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 125;
            // 
            // tongThanhTien
            // 
            tongThanhTien.Enabled = false;
            tongThanhTien.Location = new Point(101, 756);
            tongThanhTien.Name = "tongThanhTien";
            tongThanhTien.Size = new Size(209, 27);
            tongThanhTien.TabIndex = 116;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(101, 724);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 117;
            label2.Text = "Tổng thành tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 178);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 119;
            label4.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(751, 255);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 120;
            label5.Text = "Số lượng tồn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(446, 254);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 121;
            label6.Text = "Đơn vị";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(151, 255);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 122;
            label7.Text = "Đơn giá ";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.save;
            btnAdd.Location = new Point(1141, 238);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 55);
            btnAdd.TabIndex = 123;
            btnAdd.Text = "Thêm";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // donVi
            // 
            donVi.Enabled = false;
            donVi.Location = new Point(446, 278);
            donVi.Name = "donVi";
            donVi.Size = new Size(209, 27);
            donVi.TabIndex = 125;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1186, 736);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(176, 66);
            btnClose.TabIndex = 127;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(965, 736);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(183, 66);
            btnThanhToan.TabIndex = 124;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // fManageSellDrug
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 843);
            Controls.Add(btnClose);
            Controls.Add(donVi);
            Controls.Add(btnThanhToan);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(tongThanhTien);
            Controls.Add(dataGridView1);
            Controls.Add(soLuong);
            Controls.Add(soLuongTon);
            Controls.Add(donGia);
            Controls.Add(label1);
            Controls.Add(tenThuoc);
            Name = "fManageSellDrug";
            Text = "QUẢN LÝ BÁN HÀNG";
            WindowState = FormWindowState.Maximized;
            Load += fManageSellDrug_Load;
            ((System.ComponentModel.ISupportInitialize)soLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox tenThuoc;
        private Label label1;
        private TextBox donGia;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox soLuongTon;
        private NumericUpDown soLuong;
        private DataGridView dataGridView1;
        private TextBox tongThanhTien;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAdd;
        private TextBox donVi;
        private Button btnClose;
        private ToolTip toolTip1;
        private Button btnThanhToan;
        private DataGridViewTextBoxColumn drug_id;
        private DataGridViewTextBoxColumn drug_name;
        private DataGridViewTextBoxColumn supplier_name;
        private DataGridViewTextBoxColumn content;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn unit_name;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewButtonColumn delete;
    }
}