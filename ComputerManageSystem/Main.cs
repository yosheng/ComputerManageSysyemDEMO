using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerManageSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void InfoImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Child child = new Child();
            child.MdiParent = this; //指定窗口父窗体
            child.Show();
        }
    }
}
