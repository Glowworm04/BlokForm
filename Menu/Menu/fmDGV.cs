using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//объявляем псевдоним для работы с Excel
using Excel = Microsoft.Office.Interop.Excel;

namespace Menu
{
    public partial class fmDGV : Form
    {
        double sum;

        public fmDGV()
        {
            InitializeComponent();
        }

        private void fmDGV_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetTovaraDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.uchetTovaraDataSet.Tovar);

            //чётные
            dgv.RowsDefaultCellStyle.BackColor = Color.Blue;
            //нечётные
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Red;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //объявляем приложение
            Excel.Application ex = new Excel.Application();

            //Excel._Worksheet worksheet = ex.ActiveSheet;



            ////объявляем приложение
            //Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook ExcelWorkBook;
            Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ex.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
                        
            DateTime date = DateTime.Today;
            string dateWorkShet = date.ToString("dd.MM.yyyy");
            //название листа
            ExcelWorkSheet.Name = "Отчет "+ dateWorkShet;
            
            for (int i = 0; i < 8; i++)
            {
                //жирный шрифт прервой строки
                ExcelWorkSheet.Cells[i + 1].Font.Bold = true;

                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    //выравнивание текста в ячейке
                    (ExcelWorkSheet.Cells[i+1, j+1] as Excel.Range).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    //размер и шрифт текста
                    ExcelWorkSheet.Cells[i + 1, j + 1].Font.Size = 14;
                    ExcelWorkSheet.Cells[i + 1, j + 1].Font.Name = "Monotype Corsiva";
                }
            }

            
            int cellRowIndex = 2;
            int cellColumnIndex = 1;

            for (int j = 0; j < dgv.Columns.Count; j++)
            {
                ex.Cells[j+1] = dgv.Columns[j].HeaderText;
            }

            

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (cellRowIndex == 0)
                    {
                        
                    }
                    else
                    {
                        ex.Cells[cellRowIndex, cellColumnIndex].EntireColumn.AutoFit();
                        ex.Cells[cellRowIndex, cellColumnIndex] = dgv.Rows[i].Cells[j].Value;
                    }
                    cellColumnIndex++;
                    
                }
                Excel.Range Rng = ex.get_Range("D:D");
                sum = ex.WorksheetFunction.Sum(Rng);
                

                cellColumnIndex = 1;
                cellRowIndex++;
            }

            ex.Cells[dgv.Rows.Count + 1, dgv.Columns.Count-4] = sum;

            ////Вызываем нашу созданную эксельку.
            ex.Visible = true;
            ex.UserControl = true;

            //// Вычисляем сумму этих чисел
            //Excel.Range rng = workSheet.Range["A2"];
            //rng.Formula = "=SUM(A1:L1)";
            //rng.FormulaHidden = false;
        }
    }
}
