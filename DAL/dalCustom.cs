using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
   public  class dalCustom
    {
        /// <summary>
        /// 返回一个DataSet数据集
        /// </summary>
        /// <param name="Sqlname">数据库名</param>
        /// <returns>包含结果的数据集</returns>
        public static DataSet c_DataSet(string Sqlname)     // 返回一个DataSet数据集
        {
            string cmdText = "select * from  " + Sqlname;
            SqlCommand cmd = new SqlCommand();              //创建一个SqlCommand对象，并对其进行初始化
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)        //判断连接的状态。如果是关闭状态，则打开
                conn.Open();
            cmd.Connection = conn;                         //cmd属性赋值
            cmd.CommandText = cmdText;
            SqlDataAdapter da = new SqlDataAdapter(cmd);    //创建SqlDataAdapter对象以及DataSet
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);                                 //填充ds
                return ds;                                   //返回ds
            }
            catch
            {
                conn.Close();                                  //关闭连接，抛出异常
                throw;
            }
        }

        public static string getTypeName(string UserID, string Sqlname, string T_Id, string T_Name)//返回一个类型名称
        {
            string TypeName;
            string cmdText = "select " + T_Name + " from  " + Sqlname + " where " + T_Id + "=" + UserID;                 
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText,conn);
            TypeName = (String)cmd.ExecuteScalar();
            return TypeName;
        }

        public static int createTypeName(string TypeName, string Sqlname, string T_Name)//新建分类 
        {
            string cmdText = "insert into  " + Sqlname + "(" + T_Name + ")  values('" + TypeName + "')";        
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = DBHelp.GetConnection;           
            if (conn.State != ConnectionState.Open)
                conn.Open();        
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            return cmd.ExecuteNonQuery();
        }

        public static int udateTypeName(string TypeName, string Sqlname, string T_Id, string T_Name, string UserID)//修改分类
        {
            string cmdText = "update " + Sqlname + "  set " + T_Name + "='" + TypeName + "' where " + T_Id + "=" + UserID;
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            return cmd.ExecuteNonQuery();
        }
        public static int deleteTypeName(int UserID, string Sqlname, string T_Id)//删除分类
        {
            string cmdText = "delete from " + Sqlname + " where " + T_Id + "=" + UserID;
                     
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            return cmd.ExecuteNonQuery();
        }
        public static DataSet getAllType(string typeSqlname)//取得类型DateSet
        {
            try
            {
                string strSql = "select * from " + typeSqlname;
                return DBHelp.ExecuteDataSet(strSql, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getType(string Sqlname, string T_Id, string T_Name)//取得类型DateTable
        {
            DataSet bookTypeDs = getAllType(Sqlname);
            DataTable newDataTable = new DataTable();//新表添加两列
            newDataTable.Columns.Add(T_Id);
            newDataTable.Columns.Add(T_Name);

            foreach (DataRow oldDR in bookTypeDs.Tables[0].Rows)
            {
                DataRow newDR = newDataTable.NewRow();
                newDR[0] = oldDR[T_Id].ToString();
                newDR[1] = oldDR[T_Name].ToString();
                newDataTable.Rows.InsertAt(newDR, newDataTable.Rows.Count);
            }
            DataRow dr = newDataTable.NewRow();
            dr[0] = "0";
            dr[1] = "请选择";
            newDataTable.Rows.InsertAt(dr, 0);
            return newDataTable;
        }

       /*public static DataTable getUser()    //取得用户DateTable
        {

            DataSet bookTypeDs = getAllType("U_UserInfo");
            DataTable newDataTable = new DataTable();
            newDataTable.Columns.Add("U_Id");
            newDataTable.Columns.Add("U_Name");

            foreach (DataRow oldDR in bookTypeDs.Tables[0].Rows)
            {
                DataRow newDR = newDataTable.NewRow();
                newDR[0] = oldDR["U_Id"].ToString();
                newDR[1] = oldDR["U_Name"].ToString();
                newDataTable.Rows.InsertAt(newDR, newDataTable.Rows.Count);
            }
            DataRow dr = newDataTable.NewRow();
            dr[0] = "0";
            dr[1] = "请选择";
            newDataTable.Rows.InsertAt(dr, 0);
            return newDataTable;
        }*/

        public static DataTable getCustom(string U_Id)     //取得客户DateTable
        {
            string cmdText = "select * from  U_Custom where U_Id=" + U_Id;         
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        public static DataSet getUserName(string Where,string where2) //取得用户DateSet
        {
            try
            {
                string strSql = "select U_Id ID,U_Number 编号,U_Name 姓名 from U_Custom where 1=1 " + Where + where2; 
                return DBHelp.ExecuteDataSet(strSql, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static bool AddFile(Model.Book book, string Sqlname)
        {
            string sql = "insert into " + Sqlname + "(U_Name,U_PsdType,U_Note,U_Image,U_LoginTime) values(@U_Name,@U_PsdType,@U_Note,@U_Image,@U_LoginTime)";
            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {
             new SqlParameter("@U_Name",SqlDbType.VarChar),
             new SqlParameter("@U_PsdType",SqlDbType.Int),
             new SqlParameter("@U_Note",SqlDbType.VarChar),
             new SqlParameter("@U_Image",SqlDbType.Image),
             new SqlParameter("@U_LoginTime",SqlDbType.DateTime)
            };
            /*给参数赋值*/
            parm[0].Value = book.bookName;
            parm[1].Value = book.bookType;
            parm[2].Value = book.note;
            parm[3].Value = book.bookPhoto;
            parm[4].Value = book.publishDate;
            /*执行sql进行添加*/
            return (DBHelp.ExecuteNonQuery(sql, parm) > 0) ? true : false;
        }

        public static bool AddWord(Model.Book book)
        {
            string sql = "insert into U_Word(U_Word,U_Chinese,U_Pronounce,U_Note) values(@U_Word,@U_Chinese,@U_Pronounce,@U_Note)";
            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {
             new SqlParameter("@U_Word",SqlDbType.VarChar),
             new SqlParameter("@U_Chinese",SqlDbType.VarChar),
             new SqlParameter("@U_Pronounce",SqlDbType.VarChar),
             new SqlParameter("@U_Note",SqlDbType.VarChar)
            };
            /*给参数赋值*/
            parm[0].Value = book.bookName;
            parm[1].Value = book.Name;
            parm[2].Value = book.move;
            parm[3].Value = book.address;
            /*执行sql进行添加*/
            return (DBHelp.ExecuteNonQuery(sql, parm) > 0) ? true : false;
        }
        public static Model.Book getSomeFile(string barcode, string Sqlname)
        {
            /*构建查询sql*/
            string sql = "select * from  " + Sqlname + " where U_id='" + barcode + "'";
            SqlDataReader DataRead = DBHelp.ExecuteReader(sql, null);
            Model.Book book = new Model.Book();
            /*如果查询存在记录，就包装到对象中返回*/
            if (DataRead.Read())
            {
                book.barcode = Convert.ToInt32(DataRead["U_Id"]);
                book.bookName = DataRead["U_Name"].ToString();
                book.bookType = Convert.ToInt32(DataRead["U_PsdType"]);
                book.note = DataRead["U_Note"].ToString();
                book.bookPhoto = (byte[])DataRead["U_Image"];
                book.publishDate = Convert.ToDateTime(DataRead["U_LoginTime"].ToString());
            }
            DataRead.Close();
            return book;
        }

        public static Model.Book getSomeWord(string barcode)
        {
            /*构建查询sql*/
            string sql = "select * from  U_Word where U_id='" + barcode + "'";
            SqlDataReader DataRead = DBHelp.ExecuteReader(sql, null);
            Model.Book book = new Model.Book();
            /*如果查询存在记录，就包装到对象中返回*/
            if (DataRead.Read())
            {
                book.barcode = Convert.ToInt32(DataRead["U_Id"]);
                book.bookName = DataRead["U_Word"].ToString();
                book.Name = DataRead["U_Chinese"].ToString();
                book.move = double.Parse(DataRead["U_Pronounce"].ToString());
                book.address = DataRead["U_Note"].ToString();
            }
            DataRead.Close();
            return book;
        }

        /*更新图书实现*/
        public static bool EditFile(Model.Book book, string Sqlname)
        {
            string sql = "update " + Sqlname + " set U_Name=@U_Name,U_PsdType=@U_PsdType,U_Note=@U_Note,U_Image=@U_Image,U_LoginTime=@U_LoginTime where U_Id=@U_Id";
            /*构建sql参数信息*/
            SqlParameter[] parm = new SqlParameter[] {
             new SqlParameter("@U_Id",SqlDbType.Int),
             new SqlParameter("@U_Name",SqlDbType.VarChar),
             new SqlParameter("@U_PsdType",SqlDbType.Int),
             new SqlParameter("@U_Note",SqlDbType.VarChar),
             new SqlParameter("@U_Image",SqlDbType.Image),
             new SqlParameter("@U_LoginTime",SqlDbType.DateTime)
            };
            /*为参数赋值*/
            parm[0].Value = book.barcode;
            parm[1].Value = book.bookName;
            parm[2].Value = book.bookType;
            parm[3].Value = book.note;
            parm[4].Value = book.bookPhoto;
            parm[5].Value = book.publishDate;
            /*执行更新*/
            return (DBHelp.ExecuteNonQuery(sql, parm) > 0) ? true : false;
        }

        /*更新图书实现*/
        public static bool EditWord(Model.Book book)
        {
            string sql = "update U_Word set U_Word=@U_Word,U_Chinese=@U_Chinese,U_Pronounce=@U_Pronounce,U_Note=@U_Note where U_Id=@U_Id";
            /*构建sql参数信息*/
            SqlParameter[] parm = new SqlParameter[] {
             new SqlParameter("@U_Id",SqlDbType.Int),
             new SqlParameter("@U_Word",SqlDbType.VarChar),
             new SqlParameter("@U_Chinese",SqlDbType.Int),
             new SqlParameter("@U_Pronounce",SqlDbType.VarChar),
             new SqlParameter("@U_Note",SqlDbType.Image)
            };
            /*为参数赋值*/
            parm[0].Value = book.barcode;
            parm[1].Value = book.bookName;
            parm[2].Value = book.Name;
            parm[3].Value = book.move;
            parm[4].Value = book.address;

            /*执行更新*/
            return (DBHelp.ExecuteNonQuery(sql, parm) > 0) ? true : false;
        }

        public static bool DelFile(string p, string Sqlname)
        {
            string sql = "";
            string[] ids = p.Split(',');
            for (int i = 0; i < ids.Length; i++)
            {
                if (i != ids.Length - 1)
                    sql += "'" + ids[i] + "',";
                else
                    sql += "'" + ids[i] + "'";
            }
            sql = "delete from " + Sqlname + " where U_Id in (" + sql + ")";
            return ((DBHelp.ExecuteNonQuery(sql, null)) > 0) ? true : false;
        }

        public static bool DelWrod(string p)
        {
            string sql = "";
            string[] ids = p.Split(',');
            for (int i = 0; i < ids.Length; i++)
            {
                if (i != ids.Length - 1)
                    sql += "'" + ids[i] + "',";
                else
                    sql += "'" + ids[i] + "'";
            }
            sql = "delete from U_Word where U_Id in (" + sql + ")";
            return ((DBHelp.ExecuteNonQuery(sql, null)) > 0) ? true : false;
        }

        /*查询图书*/
        public static System.Data.DataTable GetFile(int PageIndex, int PageSize, out int PageCount, out int RecordCount, string strWhere, string Sqlname, string TypeSqlname)
        {
            try
            {
                string strSql = " select " + Sqlname + ".*," + TypeSqlname + ".F_Name from  " + Sqlname + "," + TypeSqlname + "  where  " + Sqlname + ".U_PsdType=" + TypeSqlname + ".F_Id ";
                string strShow = "U_Id as 编号,U_Name as 标题,bookTypeName as 类别,convert(char(11),U_LoginTime,20) as 日期";
                return DAL.DBHelp.ExecutePagerWhenPrimaryIsString(PageIndex, PageSize, "U_Id", strShow, strSql, strWhere, " U_Id asc ", out PageCount, out RecordCount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static System.Data.DataTable GetWord(int PageIndex, int PageSize, out int PageCount, out int RecordCount, string strWhere)
        {
            try
            {
                string strSql = " select  * from U_Word ";
                string strShow = "U_Id as ID,U_Word as 单词,U_Chinese as 中文,U_Pronounce as 音标,U_Note as 备注";

                return DAL.DBHelp.ExecutePagerWhenPrimaryIsString(PageIndex, PageSize, "U_Id", strShow, strSql, strWhere, " U_Id asc ", out PageCount, out RecordCount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static System.Data.DataTable GetReport(int PageIndex, int PageSize, out int PageCount, out int RecordCount, string strWhere)
        {
            try
            {
                string strSql = " select U_Report.*,U_UserInfo.U_Name from U_Report,U_UserInfo where U_Report.U_ClerkType=U_UserInfo.U_Id";
                string strShow = "U_Id as 编码,U_A as 项目A,U_B as 项目B,U_C as 项目C,U_D as 项目D,U_E as 项目E,U_F as 项目F,U_G as 项目G,U_H as 项目H,U_I as 项目I,U_J as 项目J,U_Note as 备注,U_Name as 职员,convert(char(11),U_LoginTime,20) as 时间";
                return DAL.DBHelp.ExecutePagerWhenPrimaryIsString(PageIndex, PageSize, "U_Id", strShow, strSql, strWhere, " U_Id asc ", out PageCount, out RecordCount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static System.Data.DataTable Getwork(int PageIndex, int PageSize, out int PageCount, out int RecordCount, string strWhere)
        {
            try
            {
                string strSql = " select U_Work.*,U_Custom.U_Name,ModeType.M_Name from U_Work,U_Custom,ModeType where U_Work.U_Custom=U_Custom.U_Id and U_Work.U_ModeType=ModeType.M_Id";
                string strShow = "U_Id as 编码,U_Name as 客户,M_Name as 方式,U_Amount as 金额,convert(char(11),U_LoginTime,20) as 时间";
                return DAL.DBHelp.ExecutePagerWhenPrimaryIsString(PageIndex, PageSize, "U_Id", strShow, strSql, strWhere, " U_Id asc ", out PageCount, out RecordCount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static System.Data.DataTable GetPlan(int PageIndex, int PageSize, out int PageCount, out int RecordCount, string strWhere, string Sqlname)
        {
            try
            {
                string strSql = " select * from  " + Sqlname;
                string strShow = "U_Id as 编号,convert(char(11),U_LoginTime,20) as 日期";
                return DAL.DBHelp.ExecutePagerWhenPrimaryIsString(PageIndex, PageSize, "U_Id", strShow, strSql, strWhere, " U_Id asc ", out PageCount, out RecordCount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static System.Data.DataTable GetMessage(int PageIndex, int PageSize, out int PageCount, out int RecordCount, string strWhere)
        {
            try
            {
                string strSql = " select U_Message.*,U_UserInfo.U_Name from U_Message,U_UserInfo where U_Message.U_Send=U_UserInfo.U_Id";
                string strShow = "U_Id as 编码,U_Name as 发送人,convert(char(11),U_LoginTime,20) as 时间";
                return DAL.DBHelp.ExecutePagerWhenPrimaryIsString(PageIndex, PageSize, "U_Id", strShow, strSql, strWhere, " U_Id asc ", out PageCount, out RecordCount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int notenum()  //生成单据号码
        {
            SqlConnection DbConnection = DBHelp.GetConnection;
            if (DbConnection.State == ConnectionState.Closed)
            {
                DbConnection.Open();
            }
            SqlCommand command = new SqlCommand("notenum", DbConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@num", SqlDbType.Int);
            command.Parameters["@num"].Direction = ParameterDirection.Output;                        //并打开了连接     
            command.ExecuteNonQuery();
            int result = (int)command.Parameters["@num"].Value;
            DbConnection.Close();
            return result;
        }

        public int ExistsName(string U_Name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from U_Custom");
            strSql.Append(" where ");
            strSql.Append(" U_Number = @U_Name  ");
            SqlParameter[] parameters = {
					new SqlParameter("@U_Name", SqlDbType.VarChar,50)
                                        };

            parameters[0].Value = U_Name;

            return Convert.ToInt32(DBHelp.ExecuteScalar(strSql.ToString(), parameters));
        }
    }
}
