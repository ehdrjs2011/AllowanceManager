using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AllowanceManager
{
    public partial class MainDlg : Form
    {

        public static OleDbConnection DBCon
        {
            private set;
            get;
        }
        private UserControl[] Pages = { new MainPage(), new StatisPage() };

        public MainDlg()
        {
            InitializeComponent();

            string connstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\maindb.accdb";
            DBCon = new OleDbConnection(connstr);

            DBCon.Open();

            btnPage_Click(btnMain, null);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("끝내시겠습니까?", "끝", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void btnPage_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null)
                return;

            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(Pages[int.Parse(btn.Tag.ToString())]);
        }
    }
}
