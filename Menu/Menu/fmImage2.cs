using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Menu
{
    public partial class fmImage2 : Form
    {
        public byte[] data = null;
        public fmImage2()
        {
            InitializeComponent();
        }

        
        private void btnZagr_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=K218PREP;Initial Catalog=WSR;Integrated Security=True");
            //SqlCommand sqlCommand = new SqlCommand("INSERT INTO Image (Picture) VALUES ( @Picture )", sqlConnection);
            //SqlParameter sqlParameter = new SqlParameter("@Picture", SqlDbType.VarBinary);
            //string fileName = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Alien 1.bmp";                  //Путь к файлу
            //Image image = Image.FromFile(fileName);                                                                               //Изображение из файла.
            //MemoryStream memoryStream = new MemoryStream();                                                                       //Поток в который запишем изображение
            //image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
            //sqlParameter.Value = memoryStream.ToArray();
            //sqlCommand.Parameters.Add(sqlParameter);
            //sqlConnection.Open();
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
            //memoryStream.Dispose();
        } 

        
        

        
    }
}
