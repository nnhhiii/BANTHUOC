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
            loggedInEmployee = employee;
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

        private void taikhoan_Click_1(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManagementAccount"))
                return;
            fManagementAccount f = new fManagementAccount(loggedInEmployee); // Chuy?n thông tin nhân viên ?ã ??ng nh?p
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
            if (Utility.IsOpeningForm("fManagementDrugInfo"))
                return;
            fManagementDrugInfo f = new fManagementDrugInfo();
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
            if (Utility.IsOpeningForm("fManagementSellDrugs"))
                return;
            fManagementSellDrugs f = new fManagementSellDrugs();
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
