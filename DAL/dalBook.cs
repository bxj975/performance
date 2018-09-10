using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    /*图书业务逻辑层实现*/
    public class dalBook
    {
        /*待执行的sql语句*/
        public static string sql = "";

        /*添加图书实现*/
        public static bool AddBook(Model.Book book)
        {
            string sql = "insert into U_Custom(U_Number,U_Name,U_Sex,U_Tel,U_Introduce,U_ClerkType,U_Note,U_LoginDate,U_Grade,U_Team,U_Bank,U_BankN,U_BankName,U_Lower) values(@U_Number,@U_Name,@U_Sex,@U_Tel,@U_Introduce,@U_ClerkType,@U_Note,@U_LoginTime,@U_Grade,@U_Team,@U_Bank1,@U_Bank2,@U_Bank3,@U_Lower)";
            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {
             new SqlParameter("@U_Number",SqlDbType.VarChar),
             new SqlParameter("@U_Name",SqlDbType.VarChar,50),
             new SqlParameter("@U_Sex",SqlDbType.VarChar,50),
             new SqlParameter("@U_Tel",SqlDbType.VarChar,50),
             new SqlParameter("@U_Introduce",SqlDbType.Int),
             new SqlParameter("@U_ClerkType",SqlDbType.Int),
             new SqlParameter("@U_Note",SqlDbType.NVarChar,200),
             new SqlParameter("@U_LoginTime",SqlDbType.DateTime),
             new SqlParameter("@U_Grade",SqlDbType.Int),
             new SqlParameter("@U_Team",SqlDbType.Bit),
             new SqlParameter("@U_Bank1",SqlDbType.VarChar,50),
             new SqlParameter("@U_Bank2",SqlDbType.VarChar,50),
             new SqlParameter("@U_Bank3",SqlDbType.VarChar,50),             
             new SqlParameter("@U_Lower",SqlDbType.NVarChar,500)
            };
            /*给参数赋值*/
            parm[0].Value = book.bookName; 
            parm[1].Value = book.Name;
            parm[2].Value = book.area;
            parm[3].Value = book.tele;
            parm[4].Value = book.recommend;
            parm[5].Value = book.clerk; 
            parm[6].Value = book.note; 
            parm[7].Value = book.publishDate;
            parm[8].Value = 10;
            parm[9].Value = false;
            parm[10].Value = book.bank;
            parm[11].Value = book.bankn;
            parm[12].Value = book.bankname;
            parm[13].Value = "会员：";  
            foreach (SqlParameter p in parm)   //没有对传入的数据作空值的处理
            {
                if (p.Value  == null)
                {
                    p.Value = DBNull.Value;
                }
            }
            /*执行sql进行添加*/
            return (DBHelp.ExecuteNonQuery(sql, parm) > 0) ? true : false;
        }
       
        /*根据barcode获取某条图书记录*/
        public static Model.Book getSomeBook(string barcode)
        {
            /*构建查询sql*/
            string sql = "select * from U_Custom where U_id=" + barcode;
            SqlDataReader DataRead = DBHelp.ExecuteReader(sql, null);
            Model.Book book = new Model.Book();
            /*如果查询存在记录，就包装到对象中返回*/
            if (DataRead.Read())
            {
                book.barcode = Convert.ToInt32(DataRead["U_Id"]);
                book.bookType = Convert.ToInt32(DataRead["U_Grade"]);
                book.bookName = DataRead["U_Number"].ToString();
                book.Name = DataRead["U_Name"].ToString();
                book.email = double.Parse(DataRead["U_Pay"].ToString());
                book.qq = double.Parse(DataRead["U_Total"].ToString());
                book.move = double.Parse(DataRead["U_TeamSum"].ToString());
                book.tele = DataRead["U_Tel"].ToString();
                book.weixin = double.Parse(DataRead["U_Count"].ToString());
                book.recommend = Convert.ToInt32(DataRead["U_Introduce"]);
                book.area = DataRead["U_Sex"].ToString();
                book.clerk = Convert.ToInt32(DataRead["U_ClerkType"]);
                book.address = DataRead["U_Lower"].ToString();
                book.www = double.Parse(DataRead["U_Sum"].ToString());
                book.note = DataRead["U_Note"].ToString();
                book.publishDate = Convert.ToDateTime(DataRead["U_LoginDate"].ToString());
                book.team = (bool)DataRead["U_Team"];
                book.bank = DataRead["U_Bank"].ToString();
                book.bankn = DataRead["U_BankN"].ToString();
                book.bankname = DataRead["U_BankName"].ToString();
            }
            DataRead.Close();
            return book;
        }       

        /*更新图书实现*/
        public static bool EditBook(Model.Book book)
        {
            string sql = "update U_Custom set U_Name=@U_Name,U_Sex=@U_Sex,U_Tel=@U_Tel,U_Note=@U_Note,U_Bank=@U_Bank1,U_BankN=@U_Bank2,U_BankName=@U_Bank3 where U_Id=@U_Id";
                        
            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {     
             new SqlParameter("@U_Name",SqlDbType.VarChar),
             new SqlParameter("@U_Sex",SqlDbType.VarChar),
             new SqlParameter("@U_Tel",SqlDbType.VarChar),
             new SqlParameter("@U_Id",SqlDbType.Int),
             new SqlParameter("@U_Note",SqlDbType.VarChar,200),
             new SqlParameter("@U_Bank1",SqlDbType.VarChar,50),
             new SqlParameter("@U_Bank2",SqlDbType.VarChar,50),
             new SqlParameter("@U_Bank3",SqlDbType.VarChar,50)
            };
            /*给参数赋值*/
            parm[0].Value = book.Name;
            parm[1].Value = book.area;
            parm[2].Value = book.tele;
            parm[3].Value = book.barcode;
            parm[4].Value = book.note;
            parm[5].Value = book.bank;
            parm[6].Value = book.bankn;
            parm[7].Value = book.bankname;
            /*执行更新*/
            return (DBHelp.ExecuteNonQuery(sql, parm) > 0) ? true : false;
        }
     
        /*删除图书*/
        public static bool DelBook(string p)
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
            sql = "delete from U_Custom where U_Id in (" + sql + ")";
            return ((DBHelp.ExecuteNonQuery(sql, null)) > 0) ? true : false;
        }      
        
        /*查询图书*/
        public static System.Data.DataTable GetBook(int PageIndex, int PageSize, out int PageCount, out int RecordCount, string strWhere)
        {
            try
            {
                string strSql = " select U_Custom.*,CustomType.C_Name from U_Custom,CustomType where  U_Custom.U_Grade=CustomType.C_Id ";
                string strShow = "U_Id as ID,U_Number as 编码,U_Name as 会员名,U_Tel as 电话,C_Name as 级别,convert(char(11),U_LoginDate,20) as 时间";
                return DAL.DBHelp.ExecutePagerWhenPrimaryIsString(PageIndex, PageSize, "U_Id", strShow, strSql, strWhere, " U_Id asc ", out PageCount, out RecordCount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
   
        public static DataSet getAllBook()
        {
            try
            {
                string strSql = "select * from Book";
                return DBHelp.ExecuteDataSet(strSql, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool AddType(Model.BookType book)
        {
            string sql = "insert into ProductType(P_Number,P_Name,P_Amount,P_RateA,P_RateB) values(@U_Number,@U_Name,@U_Sex,@U_Tel,@U_Introduce)";
            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {
             new SqlParameter("@U_Number",SqlDbType.VarChar),
             new SqlParameter("@U_Name",SqlDbType.VarChar,50),
             new SqlParameter("@U_Sex",SqlDbType.Decimal),
             new SqlParameter("@U_Tel",SqlDbType.Decimal),
             new SqlParameter("@U_Introduce",SqlDbType.Decimal)
            };
            /*给参数赋值*/
            parm[0].Value = book.Number;
            parm[1].Value = book.Name;
            parm[2].Value = book.amount;
            parm[3].Value = book.rateA;
            parm[4].Value = book.rateB;
            foreach (SqlParameter p in parm)   //没有对传入的数据作空值的处理
            {
                if (p.Value == null)
                {
                    p.Value = DBNull.Value;
                }
            }
            /*执行sql进行添加*/
            return (DBHelp.ExecuteNonQuery(sql, parm) > 0) ? true : false;
        }

        public static bool EditType(Model.BookType book)
        {
            string sql = "update ProductType set P_Number=@U_Number,P_Name=@U_Name,P_Amount=@U_Sex,P_RateA=@U_Tel,P_RateB=@U_Introduce  where P_Id=@U_Id";

            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {     
             new SqlParameter("@U_Number",SqlDbType.VarChar),
             new SqlParameter("@U_Name",SqlDbType.VarChar,50),
             new SqlParameter("@U_Sex",SqlDbType.Decimal),
             new SqlParameter("@U_Tel",SqlDbType.Decimal),
             new SqlParameter("@U_Introduce",SqlDbType.Decimal),
              new SqlParameter("@U_Id",SqlDbType.Int)
            };
            /*给参数赋值*/
            parm[0].Value = book.Number;
            parm[1].Value = book.Name;
            parm[2].Value = book.amount;
            parm[3].Value = book.rateA;
            parm[4].Value = book.rateB;
            parm[5].Value = book.Id;
            /*执行更新*/
            return (DBHelp.ExecuteNonQuery(sql, parm) > 0) ? true : false;
        }
        public static Model.BookType getSomeType(string barcode)
        {
            /*构建查询sql*/
            string sql = "select * from ProductType where P_id=" + barcode;
            SqlDataReader DataRead = DBHelp.ExecuteReader(sql, null);
            Model.BookType book = new Model.BookType();
            /*如果查询存在记录，就包装到对象中返回*/
            if (DataRead.Read())
            {
                book.Id = Convert.ToInt32(DataRead["P_Id"]);
                book.Number = DataRead["P_Number"].ToString();
                book.Name = DataRead["P_Name"].ToString();
                book.amount = double.Parse(DataRead["P_Amount"].ToString());
                book.rateA = double.Parse(DataRead["P_RateA"].ToString());
                book.rateB = double.Parse(DataRead["P_RateB"].ToString());
            }
            DataRead.Close();
            return book;
        }

        public static bool AddRank(Model.BookType book)
        {
            string sql = "insert into CustomType(C_Number,C_Name,C_Amount,C_Rate) values(@U_Number,@U_Name,@U_Sex,@U_Tel)";
            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {
             new SqlParameter("@U_Number",SqlDbType.VarChar),
             new SqlParameter("@U_Name",SqlDbType.VarChar,50),
             new SqlParameter("@U_Sex",SqlDbType.Decimal),
             new SqlParameter("@U_Tel",SqlDbType.Decimal),
            };
            /*给参数赋值*/
            parm[0].Value = book.Number;
            parm[1].Value = book.Name;
            parm[2].Value = book.amount;
            parm[3].Value = book.rateA;
            
            foreach (SqlParameter p in parm)   //没有对传入的数据作空值的处理
            {
                if (p.Value == null)
                {
                    p.Value = DBNull.Value;
                }
            }
            /*执行sql进行添加*/
            return (DBHelp.ExecuteNonQuery(sql, parm) > 0) ? true : false;
        }

        public static bool EditRank(Model.BookType book)
        {
            string sql = "update CustomType set C_Number=@U_Number,C_Name=@U_Name,C_Amount=@U_Sex,C_Rate=@U_Tel  where C_Id=@U_Id";

            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {     
             new SqlParameter("@U_Number",SqlDbType.VarChar),
             new SqlParameter("@U_Name",SqlDbType.VarChar,50),
             new SqlParameter("@U_Sex",SqlDbType.Decimal),
             new SqlParameter("@U_Tel",SqlDbType.Decimal),
             new SqlParameter("@U_Id",SqlDbType.Int)
            };
            /*给参数赋值*/
            parm[0].Value = book.Number;
            parm[1].Value = book.Name;
            parm[2].Value = book.amount;
            parm[3].Value = book.rateA;
            parm[4].Value = book.Id;
            /*执行更新*/
            return (DBHelp.ExecuteNonQuery(sql, parm) > 0) ? true : false;
        }
        public static Model.BookType getSomeRank(string barcode)
        {
            /*构建查询sql*/
            string sql = "select * from CustomType where C_id=" + barcode;
            SqlDataReader DataRead = DBHelp.ExecuteReader(sql, null);
            Model.BookType book = new Model.BookType();
            /*如果查询存在记录，就包装到对象中返回*/
            if (DataRead.Read())
            {
                book.Id = Convert.ToInt32(DataRead["C_Id"]);
                book.Number = DataRead["C_Number"].ToString();
                book.Name = DataRead["C_Name"].ToString();
                book.amount = double.Parse(DataRead["C_Amount"].ToString());
                book.rateA = double.Parse(DataRead["C_Rate"].ToString());
            }
            DataRead.Close();
            return book;
        }

        public static string getString(int UserID)//返回一个类型名称
        {
            string cmdText = "select U_Row from  U_Row  where U_Id=" + UserID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            string TypeName = (string)cmd.ExecuteScalar();
            return TypeName;
        }

        public static bool getBool(int UserID)//返回一个类型名称
        {
            string cmdText = "select U_Check from  U_Row  where U_Id=" + UserID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            bool TypeName = (bool)cmd.ExecuteScalar();
            return TypeName;
        }

        public static int Update(string T_Name, string New, int UserID)
        {
            string sql = "update U_Row set " + T_Name + "=" + New + " where U_Id=" + UserID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int num = cmd.ExecuteNonQuery();
            return num;
        }

        public static bool IsIntNum(string str)
        {
            System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(@"^[-]?[1-9]{1}\d*$|^[0]{1}$");          
            bool ismatch = reg1.IsMatch(str);
            //if (!ismatch)
                //Show("您输入的数字不是整数！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return ismatch;
        }

    }
}
