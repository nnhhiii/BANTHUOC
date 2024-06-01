using BANTHUOC;

namespace BANTHUOC
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btn_loai_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fDrugCategoryManagement"))
                return;
            fDrugCategoryManagement f = new fDrugCategoryManagement();
            f.MdiParent = this;
            f.Show();
        }

        private void btn_thuoc_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fDrugManagement"))
                return;
            fDrugManagement f = new fDrugManagement();
            f.MdiParent = this;
            f.Show();
        }




        private void taikhoan_Click_1(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManagementAccount"))
                return;
            fManagementAccount f = new fManagementAccount();
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

        private void banthuoc_Click(object sender, EventArgs e)
        {
            {
                if (Utility.IsOpeningForm("fManagementSellDrugs"))
                    return;
                fManagementSellDrugs f = new fManagementSellDrugs();
                f.MdiParent = this;
                f.Show();
            }

        }

    }
}
