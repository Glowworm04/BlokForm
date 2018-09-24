using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class fmData : Form
    {
        public fmData()
        {
            InitializeComponent();
        }

        private void fmData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wSRDataSet.Data". При необходимости она может быть перемещена или удалена.
            this.dataTableAdapter.Fill(this.wSRDataSet.Data);

        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnPoisk_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(dtp.Value);
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Selected = false;
                for (int j = 0; j < dgv.ColumnCount; j++)
                    if (dgv.Rows[i].Cells[j].Value != null)
                        if (dgv.Rows[i].Cells[j].Value.ToString().Contains(dtp.Text))
                        {
                            dgv.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
