using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DAL
{
    public class Access
    {
        public static OleDbConnection getcon()
        {
            string m_str_strsql = "provider=microsoft.Jet.OleDb.4.0;Data source=JingranCRM.mdb;Jet OLEDB:DataBase password=4000676018;";
            OleDbConnection con = new OleDbConnection(m_str_strsql);
            con.Open();
            return con;
        }
        public DataSet getds(string m_str_sql, string m_str_table)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(m_str_sql, getcon());
            DataSet ds = new DataSet();
            da.Fill(ds, m_str_table);
            return ds;
        }

        public static object ExecuteScalar(string strSql)  //返回第一行第一列的值 sql语句不带参数(查询)
        {
            OleDbCommand cmd =new OleDbCommand(strSql, getcon());
            return cmd.ExecuteScalar();
        }
        public static int ExecuteNonQuery(string strSql)  //返回受影响的行数 sql语句不带参数(更新 添加 删除)
        {
            OleDbCommand cmd = new OleDbCommand(strSql, getcon());
            return cmd.ExecuteNonQuery();
        }
    }
}
