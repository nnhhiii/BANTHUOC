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

     
    }
}
