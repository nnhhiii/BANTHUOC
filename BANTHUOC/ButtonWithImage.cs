
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BANTHUOC
{
    public class ButtonWithImage : Button
    {
        public Image ImageSource { get; set; }

        private void InitializeComponent()
        {
            SuspendLayout();
            ResumeLayout(false);
        }
    }
}
