using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANTHUOC
{
    public partial class fMainForEmp : Form
    {
        public fMainForEmp()
        {
            InitializeComponent();
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

        private void taikhoan_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManagementAccount"))
                return;
            fManagementAccount f = new fManagementAccount();
            f.MdiParent = this;
            f.Show();
        }
    }
}
