using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicalTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonTestEventRegister_Click(object sender, EventArgs e)
        {
            using (var f = new TestEventRegister())
            {
                f.ShowDialog();
            }
        }

        private void buttonExamineeList_Click(object sender, EventArgs e)
        {
            using (var f = new ExamineeList())
            {
                f.ShowDialog();
            }
        }

        private void buttonTestResult_Click(object sender, EventArgs e)
        {
            using (var f = new TestResultList())
            {
                f.ShowDialog();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
