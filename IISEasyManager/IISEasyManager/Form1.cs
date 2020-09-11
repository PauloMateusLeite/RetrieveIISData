using IISEasyManager.Business;
using IISEasyManager.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IISEasyManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IISSitesProvider sp = new IISSitesProvider();
            GridDataProvider grid = new GridDataProvider(sp);
            GridViewExpositor gridExpositor = new GridViewExpositor(grid);

            WebSitesGrid.DataSource = gridExpositor.GetGridData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
