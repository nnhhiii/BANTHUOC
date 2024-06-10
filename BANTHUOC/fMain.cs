using BANTHUOC;
using BANTHUOC.Models;

namespace BANTHUOC
{
    public partial class fMain : Form
    {
        private Staff loggedInEmployee;

        public fMain(Staff employee)
        {
            InitializeComponent();
            this.loggedInEmployee = employee;
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
            if (Utility.IsOpeningForm("fImportGood"))
                return;
            fImportGood f = new fImportGood();
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
        private void thongtinThuoc_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageDrugInfo"))
                return;
            fManageDrugInfo f = new fManageDrugInfo();
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
        private void banthuoc_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageSellDrug"))
                return;
            fManageSellDrug f = new fManageSellDrug(loggedInEmployee);
            f.MdiParent = this;
            f.Show();
        }
        private void taikhoan_Click_1(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageAccount"))
                return;
            fManageAccount f = new fManageAccount(loggedInEmployee);
            f.MdiParent = this;
            f.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            fLogin loginForm = new fLogin();
            loginForm.Show();

            this.Close();
        }
    }
}
