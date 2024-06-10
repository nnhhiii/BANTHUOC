using BANTHUOC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BANTHUOC.Models;

namespace BANTHUOC
{
    public partial class fMainForEmp : Form
    {
        private Staff loggedInEmployee;
        public fMainForEmp(Staff employee)
        {
            InitializeComponent();
            this.loggedInEmployee = employee;
        }

        private void banthuoc_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageSellDrug"))
                return;
            fManageSellDrug f = new fManageSellDrug(loggedInEmployee);
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
            if (Utility.IsOpeningForm("fManageAccount"))
                return;
            fManageAccount f = new fManageAccount(loggedInEmployee);
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
    }
}

