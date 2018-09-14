using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BlokForm
{
    public partial class fmVhod : Form
    {
        SqlConnection conect = BDUtils.GetDBConnection2();
        SqlCommand cmd=new SqlCommand();
        string commandText = "SELECT Nomer,Data,NaimenovanieZakaza,Zakazchik FROM Zakaz";
        string commandText2 = "Select FIO,Login,Role FROM Users";
        public fmVhod()
        {
            InitializeComponent();
            SqlConnection conect = BDUtils.GetDBConnection2();
            SqlCommand myCommand = new SqlCommand();

            myCommand.Connection = conect;
            myCommand.CommandText = commandText;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = myCommand;
            conect.Open();
            DataSet ds = new DataSet();
            dataAdapter.TableMappings.Add("Table", "Zakaz");
            //dataAdapter.Fill(ds);

            SqlCommand myCommand2 = new SqlCommand();
            //myCommand2.Connection = conect;
            //myCommand2.CommandText = commandText2;
            //SqlDataAdapter dataAdapter2 = new SqlDataAdapter();
            //dataAdapter2.SelectCommand = myCommand2;
            dataAdapter.TableMappings.Add("Table1", "Users");
            dataAdapter.Fill(ds);
            
            DataRelation dataRelation = new DataRelation("Дополнительная информация", ds.Tables["Users"].Columns["Login"], ds.Tables["Zakaz"].Columns["OtvetstvenniyManager"]);
            ds.Relations.Add(dataRelation);
            DataViewManager dsview = ds.DefaultViewManager;
            dgv.DataSource = dsview;
            dgv.DataMember = "Zakaz";
            conect.Close();
        }
    }
}
