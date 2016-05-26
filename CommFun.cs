using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PrintBarCode
{
    public class CommFun
    {
        #region 读写app.config

        //取得appkey
        public static string GetAppStrByKey(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        //设置appkey
        public static void SetAppStrByKey(string key, string value)
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings.Remove(key); cfa.AppSettings.Settings.Add(key, value);
            cfa.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        #endregion

        #region 字符串转换
        //字符串转流
        public static MemoryStream StringToStream(string s)
        {
            // convert string to stream            
            byte[] byteArray = Encoding.Unicode.GetBytes(s);
            MemoryStream stream = new MemoryStream(byteArray);
            return stream;
        }

        //流转字符串
        public static string StreamToString(Stream stream)
        {
            StreamReader reader = new StreamReader(stream);
            string text = reader.ReadToEnd();
            return text;
        }

        //字符串转字节数组
        public static Byte[] StringToByteArray(string s)
        {
            return Encoding.Unicode.GetBytes(s);
        }

        //字节数组转字符串
        public static string ByteArrayToString(Byte[] bytes)
        {
            return Encoding.Unicode.GetString(bytes);
        }

        //转string
        public static string Obj2Str(object obj)
        {
            try
            {
                return obj.ToString();
            }
            catch
            {
                return "";
            }
        }

        //转Int
        public static int Obj2Int(object obj)
        {
            try
            {
                return int.Parse(Obj2Str(obj));
            }
            catch
            {
                return 0;
            }
        }

        public static short Obj2Short(object obj)
        {
            try
            {
                return short.Parse(Obj2Str(obj));
            }
            catch
            {
                return 0;
            }
        }

        public static decimal Obj2Decimal(object obj)
        {
            try
            {
                return decimal.Parse(Obj2Str(obj));
            }
            catch
            {
                return 0;
            }
        }

        public static string Obj2DecimalStr(object obj)
        {
            try
            {
                return decimal.Parse(Obj2Str(obj)).ToString("0.########");
            }
            catch
            {
                return "0";
            }
        }

        public static DateTime Obj2DateTime(object obj)
        {
            try
            {
                return DateTime.Parse(Obj2Str(obj));
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        public static bool Obj2Bool(object obj)
        {
            try
            {
                return bool.Parse(Obj2Str(obj));
            }
            catch
            {
                return false;
            }
        }

        #endregion
                
        /// <summary>
        /// 设置工具栏按钮
        /// </summary>
        /// <param name="status">0:新增 1:编辑 2:正常</param>
        /// <param name="toolStripButton1">新增</param>
        /// <param name="toolStripButton2">编辑</param>
        /// <param name="toolStripButton3">删除</param>
        /// <param name="toolStripButton4">保存</param>
        /// <param name="toolStripButton5">取消</param>
        public static void SetToolBtn(int status, ToolStripButton toolStripButton1, ToolStripButton toolStripButton2, ToolStripButton toolStripButton3, ToolStripButton toolStripButton4, ToolStripButton toolStripButton5)
        {
            if (status == 0)//新增
            {
                toolStripButton5.Enabled = true;//取消
                toolStripButton4.Enabled = true;//保存
                toolStripButton3.Enabled = false;//删除
                toolStripButton2.Enabled = false;//编辑
                toolStripButton1.Enabled = false;//新增
            }
            else if (status == 1)//编辑
            {
                toolStripButton5.Enabled = true;//取消
                toolStripButton4.Enabled = true;//保存
                toolStripButton3.Enabled = false;//删除
                toolStripButton2.Enabled = false;//编辑
                toolStripButton1.Enabled = false;//编辑
            }
            else
            {
                toolStripButton5.Enabled = false;//取消
                toolStripButton4.Enabled = false;//保存
                toolStripButton3.Enabled = true;//删除
                toolStripButton2.Enabled = true;//编辑
                toolStripButton1.Enabled = true;//编辑
            }
        }

        #region 第一/前一/后一/最后按钮操作

        /// <summary>
        /// 设置选中行
        /// </summary>
        /// <param name="dataGrid">操作Grid</param>
        /// <param name="colName">比较用列名</param>
        /// <param name="value">查询值</param>
        public static void SetSelectRow(DataGridView dataGrid, string columnName, string value)
        {
            int nCount = dataGrid.RowCount;
            bool hasFind = false;
            for (int i = 0; i < nCount; i++)
            {
                if (value.Equals(Obj2Str(dataGrid.Rows[i].Cells[columnName].Value)))
                {
                    dataGrid.Rows[i].Selected = true;
                    hasFind = true;
                    break;
                }
            }
            if (!hasFind)
            {
                dataGrid.Rows[nCount - 1].Selected = true;
                //dataGrid.CurrentCell = dataGrid.SelectedRows[0].Cells[0];
            }
        }

        public static void SetFirst(DataGridView dataGridView1)
        {
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows[0].Selected = true;
            }
        }

        public static void SetPreview(DataGridView dataGridView1)
        {
            //没有数据
            int nCount = dataGridView1.RowCount;
            if (nCount == 0) return;

            int nSelect = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                nSelect = dataGridView1.SelectedRows[0].Index;
            }
            //没有选中行或者第一行选中
            if (nSelect == 0)
            {
                dataGridView1.Rows[0].Selected = true;
                return;
            }

            dataGridView1.Rows[nSelect - 1].Selected = true;
        }

        public static void SetNext(DataGridView dataGridView1)
        {
            //没有数据
            int nCount = dataGridView1.RowCount;
            if (nCount == 0) return;

            int nSelect = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                nSelect = dataGridView1.SelectedRows[0].Index;
            }
            //最后一行选中
            if (nSelect == (nCount - 1))
            {
                dataGridView1.Rows[nSelect].Selected = true;
                return;
            }

            dataGridView1.Rows[nSelect + 1].Selected = true;
        }

        public static void SetLast(DataGridView dataGridView1)
        {
            int nCount = dataGridView1.RowCount;
            if (nCount > 0)
            {
                dataGridView1.Rows[nCount - 1].Selected = true;
            }
        }
        #endregion

    }
}
