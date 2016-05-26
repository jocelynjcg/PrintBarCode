using LabelManager2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using static PrintBarCode.WH;

namespace PrintBarCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SetValue(""); //初始化页面
                DgvStyle.BindReadDataGridViewStyle(this.dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统错误--->" + ex.Message);
            }
        }


        private void SetValue(string whNo)
        {
            try
            {
                button1_Click_1(null, null);
                if (dataGridView1.Rows.Count > 0)
                {
                    CommFun.SetSelectRow(dataGridView1, "wHNoDataGridViewTextBoxColumn", whNo);
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("系统错误--->" + ex2.Message);
                return;
            }
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
        }

        //保存
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.EndEdit();
                DataTable dt = (DataTable)this.dataGridView1.DataSource;
                PrintDal.SavePrint(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败===>"+ex.Message);
            }
        }

        //查询
        private void button1_Click_1(object sender, EventArgs e)
        {
            string cond = "";
            if (!string.IsNullOrEmpty(txtNo.Text.Trim()))
            {
                cond += " and WH_No like '%" + txtNo.Text.Trim() + "%'";
            }

            if (!string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                cond += " and WH_Name like '%" + txtName.Text.Trim() + "%'";
            }

            if (!string.IsNullOrEmpty(txtMan.Text.Trim()))
            {
                cond += " and WH_Man like '%" + txtMan.Text.Trim() + "%'";
            }
            WH.WhDataTable table = PrintDal.GetPrint(cond);
            this.dataGridView1.DataSource = table;
        }

        //导入
        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePath();
            if (string.IsNullOrEmpty(filePath)) return;

            try
            {
                DataTable dt = GetDataFromExcelByConn(filePath);
                if (dt == null || dt.Rows.Count == 0) return;
                foreach(DataRow row in dt.Rows) { row.SetAdded(); }
                


                PrintDal.SavePrint(dt,"select WH_No from Wh");

                button1_Click_1(null,null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败===>" + ex.Message);
            }
        }

        private string GetFilePath()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Excel(*.xlsx;*.xls)|*.xlsx;*.xls";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFile.Multiselect = false;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.Cancel) return "";
            string filePath = openFile.FileName;
            string fileType = System.IO.Path.GetExtension(filePath);
            if (string.IsNullOrEmpty(fileType)) return "";

            return filePath;
        }


        private DataTable GetDataFromExcelByConn(string filePath)
        {
            try
            {
                string fileType = System.IO.Path.GetExtension(filePath);

                string strCon = "";
                using (DataSet ds = new DataSet())
                {
                    switch (fileType)
                    {
                        case ".xls":
                            strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                        case ".xlsx":
                            strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                            break;
                        default:
                            strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                    }

                    //只选列
                    string strCom = "SELECT WH_No FROM [Sheet1$]";
                    using (OleDbConnection myConn = new OleDbConnection(strCon))
                    using (OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn))
                    {
                        myConn.Open();
                        myCommand.Fill(ds);
                    }
                    if (ds == null || ds.Tables.Count <= 0) return null;
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetDataFromExcelByConn====>" + ex.Message);
                return null;
            }
        }

        //打印
        private void button4_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();

            LabelManager2.ApplicationClass print = new LabelManager2.ApplicationClass();
            string path = System.Windows.Forms.Application.StartupPath + @"\WhCode.Lab";
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                MessageBox.Show("先在系统设置中设置套版路径");
                return;
            }

            try
            {
                print.Documents.Open(path, false);
                print.Dialogs.Item(LabelManager2.enumDialogType.lppxPrinterSelectDialog).Show();

                Document doc = print.ActiveDocument;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["check"].Value!=null && CommFun.Obj2Bool(row.Cells["check"].Value))//选中
                    {
                        doc.Variables.Item("Wh_No").Value = CommFun.Obj2Str(row.Cells["wHNoDataGridViewTextBoxColumn"].Value);
                        doc.Variables.Item("Wh_Name").Value = CommFun.Obj2Str(row.Cells["wHNameDataGridViewTextBoxColumn"].Value);
                        doc.Variables.Item("Wh_Man").Value = CommFun.Obj2Str(row.Cells["wHManDataGridViewTextBoxColumn"].Value);
                        doc.PrintLabel(1, 1, 1, 1, 0, "");
                    }
                }

                doc.FormFeed();
            }
            catch (Exception ex)
            {
                MessageBox.Show("打印失败：" + ex.Message);
            }
            finally
            {
                print.Quit();
                SetValue("");
            }
        }

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("check"))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["check"].Value = row.Cells["check"].Value==null?false: !CommFun.Obj2Bool(row.Cells["check"].Value);//选中
                }
            }
        }
    }
}
