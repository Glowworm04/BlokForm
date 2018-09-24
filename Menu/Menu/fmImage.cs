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
using System.IO;

namespace Menu
{
    public partial class fmImage : Form
    {

        

        SqlConnection con = new SqlConnection(@"Data Source=K218PREP;Initial Catalog=WSR;Integrated Security=True");
        

        public fmImage()
        {
            InitializeComponent();
        }

        private void btnZagr_Click(object sender, EventArgs e)
        {
            con.Open();

                string commandText = "INSERT INTO Image (Name, Picture) VALUES(@Name, @Picture)"; // запрос на вставку
                SqlCommand cmd = new SqlCommand(commandText, con);
                FileStream fStream = new FileStream("C:\\000101.jpg", FileMode.Open, FileAccess.Read);

                Byte[] imageBytes = new byte[fStream.Length];
                fStream.Read(imageBytes, 0, imageBytes.Length);

                cmd.Parameters.AddWithValue("Name","Картинка");
                cmd.Parameters.AddWithValue("Picture",imageBytes);

                cmd.ExecuteNonQuery();

                con.Close();

                //SqlParameter par = new SqlParameter("@ID", SqlDbType.UniqueIdentifier);
                //par.Value = Guid.NewGuid();
                //par.Direction = ParameterDirection.Input;
                //cmd.Parameters.Add(par);

                //par = new SqlParameter("@Picture", SqlDbType.Image);
                //par.Value = imageBytes;
                //cmd.Parameters.Add(par);

                //par = new SqlParameter("@Name", SqlDbType.NVarChar);
                //par.Value = "Просто картинка";
                //cmd.Parameters.Add(par);

                //if (imageBytes.Length > 8000)
                //{
                //    MessageBox.Show("Длина строки больше 8000 символов");
                //}
                //else
                //{
                    
                //    sqlConnection.Open();
                //    cmd.ExecuteNonQuery();
                //    sqlConnection.Dispose();

                //}

                
            
        }
    



        


        private void btnVivod_Click(object sender, EventArgs e)
        {
            List<Image> images = new List<Image>();
            
                con.Open();
                string sql = "SELECT * FROM Image";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string filename = reader.GetString(1);
                    string title = reader.GetString(2);
                    byte[] data = (byte[])reader.GetValue(3);


                    Image image = new Image(id, filename, title, data);

                    images.Add(image);
                }
            
            // сохраним первый файл из списка
            if (images.Count > 0)
            {
                using (System.IO.FileStream fs = new System.IO.FileStream(images[0].FileName, FileMode.OpenOrCreate))
                {
                    fs.Write(images[0].Data, 0, images[0].Data.Length);
                    Console.WriteLine("Изображение '{0}' сохранено", images[0].Title);
                }
            }
        }

        private void fmImage_Load(object sender, EventArgs e)
        {
            
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbImage_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }
    }
    public class Image
    {
        public Image(int id, string filename, string title, byte[] data)
        {
            Id = id;
            FileName = filename;
            Title = title;
            Data = data;
        }
        public int Id { get; private set; }
        public string FileName { get; private set; }
        public string Title { get; private set; }
        public byte[] Data { get; private set; }

        internal static System.Drawing.Image FromFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
