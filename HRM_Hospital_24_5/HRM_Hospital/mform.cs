using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_Hospital
{
    public partial class mform : Form
    {

        MessageString msg = new MessageString();
        public mform(DevExpress.XtraTab.XtraTabPage tabpage)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = false;
            this.Parent = tabpage;
            this.BringToFront();
        }
        public void Update_ProgessBar(int n)
        {
            if (this.progressBar1.Value + n > this.progressBar1.Maximum)
                this.progressBar1.Value = this.progressBar1.Maximum;
            else
                this.progressBar1.Value += n;

            if(this.progressBar1.Value ==100)
                MessageBox.Show(msg.finish, "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            this.Validate();
        }
    }
}
