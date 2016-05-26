using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace PrintBarCode
{
    class PrintDal
    {
        private static string SQL_SELECT_PRINTBYCOCND = "select Sid,WH_No,WH_Name,WH_Name,Var1,Var2,Var3,Var4,IsPrint from Wh where 1=1";
        //取得所有打印记录
        public static WH.WhDataTable GetPrint(string cond)
        {
            WH.WhDataTable data = new WH.WhDataTable();
            string strsql = SQL_SELECT_PRINTBYCOCND + cond;
            data.Load(AccessHelper.ExecuteReader(strsql));
            return data;
        }


        private static string SQL_INSERT_PRINT = "select * from Wh";
        public static bool SavePrint(DataTable result)
        {
            try
            {
                if (result.DataSet == null)
                {
                    DataSet ds = new DataSet();
                    ds.Tables.Add(result);
                }

                return (AccessHelper.UpdateDate(SQL_INSERT_PRINT, result.DataSet, result.TableName) > 0);
            }
            catch(Exception ex)
            {
                throw ex;
                //return false;
            }
        }

        public static bool SavePrint(DataTable result,string strsql)
        {
            try
            {
                if (result.DataSet == null)
                {
                    DataSet ds = new DataSet();
                    ds.Tables.Add(result);
                }

                return (AccessHelper.UpdateDate(strsql, result.DataSet, result.TableName) > 0);
            }
            catch (Exception ex)
            {
                throw ex;
                //return false;
            }
        }
    }
}
