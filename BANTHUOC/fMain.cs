using BANTHUOC;

namespace BANTHUOC
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btn_nv_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageStaff"))
                return;
            fManageStaff f = new fManageStaff();
            f.MdiParent = this;
            f.Show();
        }
        private void btn_ncc_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageSupplier"))
                return;
            fManageSupplier f = new fManageSupplier();
            f.MdiParent = this;
            f.Show();
        }
        private void btn_loai_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageDrugCategory"))
                return;
            fManageDrugCategory f = new fManageDrugCategory();
            f.MdiParent = this;
            f.Show();
        }

        private void btn_thuoc_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageDrug"))
                return;
            fManageDrug f = new fManageDrug();
            f.MdiParent = this;
            f.Show();
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fReceivedGood"))
                return;
            fReceivedGood f = new fReceivedGood();
            f.MdiParent = this;
            f.Show();
        }

        private void btn_thongke_nhap_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fStatisticImport"))
                return;
            fStatisticImport f = new fStatisticImport();
            f.MdiParent = this;
            f.Show();
        }

        private void btn_thongke_ban_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fStatisticSale"))
                return;
            fStatisticSale f = new fStatisticSale();
            f.MdiParent = this;
            f.Show();
        }

        private void btn_thongke_kho_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fStatisticInventory"))
                return;
            fStatisticInventory f = new fStatisticInventory();
            f.MdiParent = this;
            f.Show();
        }
    }
}
