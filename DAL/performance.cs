using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace DAL
{
    public class performance
    {
        public static decimal getRateC(string T_Name, int UID) //从客户分类返回系数（decimal）
        {
            string cmdText = "select " + T_Name + " from  CustomType  where C_Id=" + UID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            decimal TypeName = (decimal)cmd.ExecuteScalar();
            return TypeName;
        }

        public static string getName(string UserID)
        {
            string TypeName;
            string cmdText = "select U_Number from  U_Custom where U_Id=" + UserID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            TypeName = (String)cmd.ExecuteScalar();
            return TypeName;
        }

        public static string getNameC(int UID)                //从客户分类返回客户名称（string）
        {

            string cmdText = "select C_Name from  CustomType  where C_Id=" + UID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            string TypeName = (string)cmd.ExecuteScalar();
            return TypeName;
        }

        public static decimal getRateP(string T_Name, int UID)   //从产品分类返回系数（decimal）
        {

            string cmdText = "select " + T_Name + " from  ProductType  where P_Id=" + UID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            decimal TypeName = (decimal)cmd.ExecuteScalar();
            return TypeName;
        }


        public static decimal getDecimal(string T_Name, int UserID)   //从会员表返回（decimal）
        {

            string cmdText = "select " + T_Name + " from  U_Custom  where U_Id=" + UserID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            decimal TypeName = (decimal)cmd.ExecuteScalar();
            return TypeName;
        }

        public static int getInt(string T_Name, int UserID)          //从会员表返回（int）
        {

            string cmdText = "select " + T_Name + " from  U_Custom  where U_Id=" + UserID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            int TypeName = (int)cmd.ExecuteScalar();
            return TypeName;
        }

        public static string getString(string T_Name, int UserID)      //从会员表返回（string)
        {
            string cmdText = "select " + T_Name + " from  U_Custom  where U_Id=" + UserID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            string TypeName = (string)cmd.ExecuteScalar();
            return TypeName;
        }

        public static bool getBool(string T_Name, int UserID)            //从会员表返回（bool）
        {
            string cmdText = "select " + T_Name + " from  U_Custom  where U_Id=" + UserID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            bool TypeName = (bool)cmd.ExecuteScalar();
            return TypeName;
        }

        public static int UpdateC(string T_Name, string T_New, int UserID)    //更新会员表UpdateC("U_Lower", lower, IntrN);
        {
            string sql = "update U_Custom set " + T_Name + "=" + T_New + " where U_Id=" + UserID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int num = cmd.ExecuteNonQuery();
            return num;
        }

        public static int UpdateString(string T_Name, string T_New, int UserID)    //更新会员表UpdateC("U_Lower", lower, IntrN);
        {
            string sql = "update U_Custom set " + T_Name + "='" + T_New + "' where U_Id=" + UserID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int num = cmd.ExecuteNonQuery();
            return num;
        }

        public static int UpdateRank(string T_Name, int UserID)                //更新会员表客户级别
        {
            string sql = "update U_Custom set U_Grade=" + T_Name + " where U_Id=" + UserID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int num = cmd.ExecuteNonQuery();
            return num;
        }

        public static int UpdateBit(string T_Name, int UserID)                 //更新会员表bool
        {
            string sql = "update U_Custom set " + T_Name + "=1 where U_Id=" + UserID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int num = cmd.ExecuteNonQuery();
            return num;
        }

        public static string getGrade(string UserID)                         //会员ID获得级别名称
        {
            string TypeName;
            int Uid;
            string cmdText = "select U_Grade from  U_Custom where U_Id=" + UserID;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            Uid = (int)cmd.ExecuteScalar();
            string cmdText2 = "select C_Name from CustomType where C_Id=" + Uid;
            SqlConnection conn2 = DBHelp.GetConnection;
            if (conn2.State != ConnectionState.Open)
                conn2.Open();
            SqlCommand cmd2 = new SqlCommand(cmdText2, conn);
            TypeName = (string)cmd2.ExecuteScalar();
            return TypeName;
        }

        public static int getC_ID(string T_Name)          //会员编号--会员名（int）
        {

            string cmdText = "select U_Id from U_Custom where U_Number=" + T_Name;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            int TypeName = (int)cmd.ExecuteScalar();
            return TypeName;
        }

        /*public static int getBegin()//返回一个类型名称
        {

            string cmdText = "select top 1 U_Id from U_Custom order by U_Id asc";
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            int TypeName = (int)cmd.ExecuteScalar();
            return TypeName;
        }

        public static int getEnd()//返回一个类型名称
        {

            string cmdText = "select top 1 U_Id from U_Custom order by U_Id desc";
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            int TypeName = (int)cmd.ExecuteScalar();
            return TypeName;
        }*/

        public static int getCount()                   //客户表总行数
        {

            string cmdText = "select count(*) from U_Custom";
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            int TypeName = (int)cmd.ExecuteScalar();
            return TypeName;
        }

        public static int getUId(int Id)                //第几行获得客户ID
        {
            string SId = Id.ToString();
            string SId2 = (Id - 1).ToString();
            string cmdText = "select U_Id from (select top " + SId + " U_Id from U_custom ) topmax  where U_Id not in (select top " + SId2 + " U_Id from U_custom )";
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            int TypeName = (int)cmd.ExecuteScalar();
            return TypeName;
        }

        public static int UpdateReset()                                       //会员表数据清零
        {
            string sql = "update U_Custom set U_Total=0,U_TeamSum=0";
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int num = cmd.ExecuteNonQuery();
            return num;
        }

        public static decimal getAmount(int No)   //从业绩核算表返回总数（decimal）
        {
            string cmdText = "select sum(U_Reward) from  U_Reward  where U_No=" + No;
            SqlConnection conn = DBHelp.GetConnection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            decimal TypeName = (decimal)cmd.ExecuteScalar();
            return TypeName;
        }
        public static int addCust(int Uid,string Uname)
        {
            string lower="";
            int time = 0,IntrN=0;
            if (Uid != 0)
            {
                IntrN = Uid ;
                while (IntrN != 0)
                {
                    time += 1;
                    string Stime = time.ToString();
                    lower = getString("U_Lower", IntrN);
                    lower = lower + Uname + "-" + Stime + "/";
                    UpdateString("U_Lower", lower, IntrN);
                    IntrN = getInt("U_Introduce", IntrN);
                }
            }
            return time;
        }

        public static bool AddAdjust(Model.Adjust book)                       //添加调整单
        {
            string sql = "insert into U_Adjust(U_No,U_Adjust,U_Custom,U_Amount,U_Clerk,U_Note,U_LoginTime,U_Type) values(@U_Number,@U_Adjust,@U_Custom,@U_Amount,@U_ClerkType,@U_Note,@U_LoginTime,@U_Type)";
            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {
             new SqlParameter("@U_Number",SqlDbType.Int),
             new SqlParameter("@U_Adjust",SqlDbType.NVarChar,20),
             new SqlParameter("@U_Custom",SqlDbType.Int),
             new SqlParameter("@U_Amount",SqlDbType.Decimal),
             new SqlParameter("@U_ClerkType",SqlDbType.Int),
             new SqlParameter("@U_Note",SqlDbType.NVarChar,200),
             new SqlParameter("@U_LoginTime",SqlDbType.DateTime),
             new SqlParameter("@U_Type",SqlDbType.NVarChar,20)
            };
            /*给参数赋值*/
            parm[0].Value = book.No;
            parm[1].Value = book.adjust;
            parm[2].Value = book.custom;
            parm[3].Value = book.amount;
            parm[4].Value = book.clerk;
            parm[5].Value = book.note;
            parm[6].Value = book.publishDate;
            parm[7].Value = book.rank;
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

        public static bool AddAdjust2(Model.Adjust book)                         //添加调整单2
        {
            int Uid = book.custom;
            decimal Uamount = book.amount;
            string Uadjust = book.adjust;
            string Utype = book.rank;
            decimal Ucount ;
            decimal Usum ;
            int num=0;
            switch (Utype)
            {
                case "业绩核算调整":
                    {
                        Ucount = getDecimal("U_Count", Uid);
                        Usum = getDecimal("U_Sum", Uid);
                        if (Uadjust == "增加")
                        {
                            Ucount += Uamount;
                            Usum += Uamount;
                        }
                        else
                        {
                            Ucount -= Uamount;
                            Usum -= Uamount;
                        }
                        string U_Count = Ucount.ToString();
                        string U_Sum = Usum.ToString();
                        num = UpdateC("U_Count", U_Count, Uid) + UpdateC("U_Sum", U_Sum, Uid);
                        break;
                    }
                case "业绩合计调整":
                    {
                        Ucount = getDecimal("U_Total", Uid);
                        if (Uadjust == "增加")
                        {
                            Ucount += Uamount;
                        }
                        else
                        {
                            Ucount -= Uamount;
                        }
                        string U_Count = Ucount.ToString();
                        num = UpdateC("U_Total", U_Count, Uid) + 1;
                        break;
                    }
                case "团队业绩调整":
                    {
                        Ucount = getDecimal("U_TeamSum", Uid);
                        if (Uadjust == "增加")
                        {
                            Ucount += Uamount;
                        }
                        else
                        {
                            Ucount -= Uamount;
                        }
                        string U_Count = Ucount.ToString();
                        num = UpdateC("U_TeamSum", U_Count, Uid) + 1;
                        break;
                    }
            }      
            if (num == 2)
                return true;
            else
                return false;
        }

        public static bool AddSettle(Model.Adjust book)                         //添加月结单
        {
            string sql = "insert into U_Settle(R_Month,R_Clerk,R_LoginDate) values(@U_Adjust,@U_ClerkType,@U_LoginTime)";
            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {
             new SqlParameter("@U_Adjust",SqlDbType.NVarChar,20),
             new SqlParameter("@U_ClerkType",SqlDbType.Int),
             new SqlParameter("@U_LoginTime",SqlDbType.DateTime)    
            };
            /*给参数赋值*/
            parm[0].Value = book.note;
            parm[1].Value = book.clerk;
            parm[2].Value = book.publishDate;
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

        public static bool AddPay(Model.Adjust book)                               //添加兑现单
        {
            string sql = "insert into U_Pay(U_No,U_Custom,U_Amount,U_Clerk,U_Note,U_LoginTime) values(@U_Number,@U_Custom,@U_Amount,@U_ClerkType,@U_Note,@U_LoginTime)";
            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {
             new SqlParameter("@U_Number",SqlDbType.Int),
             new SqlParameter("@U_Custom",SqlDbType.Int),
             new SqlParameter("@U_Amount",SqlDbType.Decimal),
             new SqlParameter("@U_ClerkType",SqlDbType.Int),
             new SqlParameter("@U_Note",SqlDbType.NVarChar,200),
             new SqlParameter("@U_LoginTime",SqlDbType.DateTime)    
            };
            /*给参数赋值*/
            parm[0].Value = book.No;
            parm[1].Value = book.custom;
            parm[2].Value = book.amount;
            parm[3].Value = book.clerk;
            parm[4].Value = book.note;
            parm[5].Value = book.publishDate;
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

        public static bool AddPay2(Model.Adjust book)                               //添加兑现单2
        {
            int Uid = book.custom;
            decimal Uamount = book.amount;
            decimal Upay = getDecimal("U_Pay",Uid);
            decimal Usum = getDecimal("U_Sum", Uid);
            Upay = Upay + Uamount;
            Usum = Usum - Uamount;
            string U_Pay=Upay.ToString();
            string U_Sum = Usum.ToString();
            int num = UpdateC("U_Pay", U_Pay, Uid) + UpdateC("U_Sum", U_Sum, Uid);
            if (num == 2)
                return true;
            else
                return false;
        }

        public static bool AddPerformance(Model.Adjust book)                            //添加业绩提交单
        {
            string sql = "insert into U_Performance(U_No,U_Product,U_Custom,N_Number,U_Clerk,U_Note,U_LoginTime,U_Custom2) values(@U_Number,@U_Adjust,@U_Custom,@U_Amount,@U_ClerkType,@U_Note,@U_LoginTime,@U_Custom2)";
            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {
             new SqlParameter("@U_Number",SqlDbType.Int),
             new SqlParameter("@U_Adjust",SqlDbType.Int ),
             new SqlParameter("@U_Custom",SqlDbType.Int),
             new SqlParameter("@U_Amount",SqlDbType.Decimal),
             new SqlParameter("@U_ClerkType",SqlDbType.Int),
             new SqlParameter("@U_Note",SqlDbType.NVarChar,200),
             new SqlParameter("@U_LoginTime",SqlDbType.DateTime),
             new SqlParameter("@U_Custom2",SqlDbType.NVarChar,20)
            };
            /*给参数赋值*/
            parm[0].Value = book.No;
            parm[1].Value = book.product;
            parm[2].Value = book.custom;
            parm[3].Value = book.amount;
            parm[4].Value = book.clerk;
            parm[5].Value = book.note;
            parm[6].Value = book.publishDate;
            parm[7].Value = book.custom2;
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

        public static void AddPerfRank(Model.Adjust book)                            //业绩提交单更改会员级别
        {
            int Uid = book.custom;
            int Pro = book.product;
            switch (Pro)
            {
                case 4:
                    UpdateRank("11", Uid);
                    break;
                case 6:
                    UpdateRank("14", Uid);
                    break;
                case 7:
                    UpdateRank("15", Uid);
                    break;
                default:
                    break;
            }
        }

        public static bool AddReward(Model.Reward book)                               //添加业绩核算单 
        {
            string sql = "insert into U_Reward(U_No,U_Count,U_Custom,U_Reward,U_Rate,U_LoginTime) values(@U_Number,@U_Adjust,@U_Custom,@U_Amount,@U_ClerkType,@U_LoginTime)";
            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {
             new SqlParameter("@U_Number",SqlDbType.Int),
             new SqlParameter("@U_Adjust",SqlDbType.Decimal ),
             new SqlParameter("@U_Custom",SqlDbType.Int),
             new SqlParameter("@U_Amount",SqlDbType.Decimal),
             new SqlParameter("@U_ClerkType",SqlDbType.NVarChar,20 ),
             new SqlParameter("@U_LoginTime",SqlDbType.DateTime)    
            };
            /*给参数赋值*/
            parm[0].Value = book.No;
            parm[1].Value = book.count;
            parm[2].Value = book.custom;
            parm[3].Value = book.reward;
            parm[4].Value = book.rate;
            parm[5].Value = book.publishDate;
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
            
        private static decimal P_A_4 = getRateP("P_Amount", 4);  //
        private static decimal P_R1_4 = getRateP("P_RateA", 4);
        private static decimal P_R2_4 = getRateP("P_RateB", 4);
        private static decimal P_A_5 = getRateP("P_Amount", 5);
        private static decimal P_R1_5 = getRateP("P_RateA", 5);
        private static decimal P_R2_5 = getRateP("P_RateB", 5);
        private static decimal P_A_6 = getRateP("P_Amount", 6);
        private static decimal P_A_7 = getRateP("P_Amount", 7);
            
        public static int AddPerformance2(Model.Adjust book)                         //添加业绩核算单2
        {
            decimal count = 0, reward1, reward2, rate1, rate2; // 总金额，业绩1，业绩2，系数1，系数2
            int Pro = book.product;                    //产品类别
            decimal Amout = book.amount;               //产品数量
            int Uid = book.custom;                     //会员ID
            switch (Pro)
            {
                case 4:
                    count = P_A_4 * Amout;
                    break;
                case 5:
                    count = P_A_5 * Amout;
                    break;
                case 6:
                    count = P_A_6;
                    break;
                case 7:
                    count = P_A_7;
                    break;
            }
            decimal total0 = getDecimal("U_Total", Uid);
            total0 += count;
            string Stotal0 = total0.ToString();
            UpdateC("U_Total", Stotal0, Uid);

            decimal Team20 = getDecimal("U_TeamSum", Uid);
            Team20 += count;
            string STeam20 = Team20.ToString();
            UpdateC("U_TeamSum", STeam20, Uid);

            //第一步 算上一级业绩
            int Intr1 = getInt("U_Introduce", Uid);
            int CRank0 = getInt("U_Grade", Uid);           //提交人级别
            if (Intr1 != 0 && Pro != 6 && Pro != 7)        //0是第一级 或 百万代理商就结束
            {
                int CRank1 = getInt("U_Grade", Intr1);     //上一级会员级别

                if (CRank0 == 10 || CRank0 == 11)             //提交人级别是代理商就结束
                {
                    if (CRank1 == 10)                        //上一级级别决定系数
                    {
                        rate1 = P_R1_5;
                    }
                    else
                    {
                        rate1 = P_R1_4;
                    }
                    reward1 = count * rate1;
                    Reward rew = new Reward();
                    rew.No = book.No;
                    rew.count = count;
                    rew.custom = Intr1;
                    rew.rate = (rate1 * 100).ToString() + "%";
                    rew.reward = reward1;
                    rew.publishDate = DateTime.Now;
                    AddReward(rew);

                    decimal total = getDecimal("U_Total", Intr1);
                    total += count;
                    string Stotal = total.ToString();
                    UpdateC("U_Total", Stotal, Intr1);

                    decimal count_P = getDecimal("U_Count", Intr1);
                    count_P += reward1;
                    string Scount_P = count_P.ToString();
                    UpdateC("U_Count", Scount_P, Intr1);

                    decimal Pay2 = getDecimal("U_Sum", Intr1);
                    Pay2 += reward1;
                    string SPay2 = Pay2.ToString();
                    UpdateC("U_Sum", SPay2, Intr1);

                    int Intr2 = getInt("U_Introduce", Intr1);
                    if (Intr2 != 0)
                    {
                        int CRank2 = getInt("U_Grade", Intr2);     //上二级级别
                        if (CRank1 == 10 || CRank1 == 11)          //上一级级别是代理商就结束
                        {
                            if (CRank2 == 10)                        //上二级级别决定系数     
                            {
                                rate2 = P_R2_5;
                            }
                            else
                            {
                                rate2 = P_R2_4;
                            }
                            reward2 = count * rate2;
                            Reward rew2 = new Reward();
                            rew2.No = book.No;
                            rew2.count = count;
                            rew2.custom = Intr2;
                            rew2.rate = (rate2 * 100).ToString() + "%";
                            rew2.reward = reward2;
                            rew2.publishDate = DateTime.Now;
                            AddReward(rew2);

                            decimal count_P2 = getDecimal("U_Count", Intr2);
                            count_P2 += reward2;
                            string Scount_P2 = count_P2.ToString();
                            UpdateC("U_Count", Scount_P2, Intr2);

                            decimal Pay22 = getDecimal("U_Sum", Intr2);
                            Pay22 += reward2;
                            string SPay22 = Pay22.ToString();
                            UpdateC("U_Sum", SPay22, Intr2);
                            return 2;
                        }
                        else
                            return 1;
                    }
                    else
                        return 1;
                }
                else
                    return 0;
            }
            else
                return 0;
        }
          
        public static int AddPerformance3(Model.Adjust book)                          //添加业绩核算单3 
        {
            decimal count=0; // 总金额，业绩1，业绩2，系数1，系数2
            int Pro = book.product;                    //产品类别
            decimal Amout = book.amount;               //产品数量
            int Uid = book.custom;                     //会员ID
            int Result = 0;
            switch (Pro)
            {
                case 4:
                    count = P_A_4 * Amout;
                    break;
                case 5:
                    count = P_A_5 * Amout;
                    break;
                case 6:
                    count = P_A_6;
                    break;
                case 7:
                    count = P_A_7;
                    break;
            }
            
            // 更新所有上一级团队业绩
            int IntrN = getInt("U_Introduce", Uid);
            while (IntrN != 0 && Pro != 6 && Pro != 7)
            {
                decimal Team2 = getDecimal("U_TeamSum", IntrN);
                Team2 += count;
                string STeam2 = Team2.ToString();
                UpdateC("U_TeamSum", STeam2, IntrN);
                Result += 1;

                IntrN = getInt("U_Introduce", IntrN);
            }
            return Result;
        }
        public static int AddPerformance4(Model.Adjust book)                       //添加业绩核算单4
        {
            int Pro = book.product;                    //产品类别
            int Uid = book.custom;                     //会员ID
            if (Pro !=5 )
            {
                int Intrn = Uid, time = 0;
                while (Intrn != 0)
                {
                    Intrn = getInt("U_Introduce", Intrn);
                    if (Intrn != 0)
                    {  
                        time += 1;
                    }
                }
                if (time > 4)
                {
                    int i = 0, n = 0;
                    int Intrx = Uid;
                    for (i = 0; i < time; i++)
                    {
                        int type = 0;
                        if (Intrx != 0)
                        {
                            type = getInt("U_Grade", Intrx); 
                            Intrx = getInt("U_Introduce", Intrx);
                        }
                        if (type!=10) n += 1;
                        if (n == 5) break;
                    }
                    bool team = false;
                    int Type = 0 ;
                    if (Intrx != 0)
                    {
                        team = getBool("U_Team", Intrx);
                        Type = getInt("U_Grade", Intrx); 
                    }
                    if (n == 5 && team==false && Type!=10)
                    {
                        Reward rew = new Reward();
                        rew.No = book.No;
                        rew.count = 0;
                        rew.custom = Intrx;
                        rew.rate = "";
                        rew.reward = 3000;
                        rew.publishDate = DateTime.Now;
                        AddReward(rew);

                        decimal count_P = getDecimal("U_Count", Intrx);
                        count_P += 3000;
                        string Scount_P = count_P.ToString();
                        UpdateC("U_Count", Scount_P, Intrx);

                        decimal Pay2 = getDecimal("U_Sum", Intrx);
                        Pay2 += 3000;
                        string SPay2 = Pay2.ToString();
                        UpdateC("U_Sum", SPay2, Intrx);
                        
                        UpdateBit("U_Team", Intrx);//未获得 改为 已领取
                        return Intrx;
                    }
                    else
                        return 0;
                }
                else
                    return 0;
            }
            else 
                return 0;
        }

        private static decimal C_A_15 = getRateC("C_Amount", 15);
        private static decimal C_R_15 = getRateC("C_Rate", 15);
        private static decimal C_A_14 = getRateC("C_Amount", 14);
        private static decimal C_R_14 = getRateC("C_Rate", 14);
        private static decimal C_A_13 = getRateC("C_Amount", 13);
        private static decimal C_R_13 = getRateC("C_Rate", 13);
        private static decimal C_A_12 = getRateC("C_Amount", 12);
        private static decimal C_R_12 = getRateC("C_Rate", 12);
        private static decimal C_A_11 = getRateC("C_Amount", 11);
        private static decimal C_R_11 = getRateC("C_Rate", 11);
        private static decimal C_A_10 = getRateC("C_Amount", 10);
        private static decimal C_R_10 = getRateC("C_Rate", 10);

        public static int AddSettle2(Model.Adjust book)                                        //添加月结单2
        {
            decimal count = 0, reward1, reward2, rate1, rate2=0; // 总金额，业绩1，业绩2，系数1，系数2
            int Pro = book.product;                    //产品类别
            decimal Amout = book.amount;               //产品数量
            int Uid = book.custom;                     //会员ID
            switch (Pro)
            {
                case 4:
                    count = P_A_4 * Amout;
                    break;
                case 5:
                    count = P_A_5 * Amout;
                    break;
                case 6:
                    count = P_A_6;
                    break;
                case 7:
                    count = P_A_7;
                    break;
            }
            int IntrN = Uid, Time = 0;
            while (IntrN != 0 && Pro != 6 && Pro != 7)
            {
                int CRankN = getInt("U_Grade", IntrN);
                if (CRankN == 10 || CRankN == 11)             //提交人级别是代理商就结束
                {
                    IntrN = getInt("U_Introduce", IntrN);
                }
                else break;
                Time = +1;
            }

            if (IntrN != 0 && Time != 0)   
            {
                int CRank0 = getInt("U_Grade", IntrN);
                if (CRank0 == 12)
                    rate1 = C_R_12;
                else
                    rate1 = C_R_13 + C_R_12;

                reward1 = count * rate1;
                Reward rew = new Reward();
                rew.No = book.No;
                rew.count = count;
                rew.custom = IntrN;
                rew.rate = (rate1 * 100).ToString() + "%";
                rew.reward = reward1;
                rew.publishDate = DateTime.Now;
                AddReward(rew);

                decimal count_P = getDecimal("U_Count", IntrN);
                count_P += reward1;
                string Scount_P = count_P.ToString();
                UpdateC("U_Count", Scount_P, IntrN);

                decimal Pay2 = getDecimal("U_Sum", IntrN);
                Pay2 += reward1;
                string SPay2 = Pay2.ToString();
                UpdateC("U_Sum", SPay2, IntrN);

                int Intr1 = getInt("U_Introduce", IntrN);
                if (Intr1 != 0)
                {
                    int CRank1 = getInt("U_Grade", Intr1);
                    if (CRank1 == 13 && CRank0 == 12)
                        rate2 = C_R_13;
                    if(Time == 1)
                        rate2 += 0.01m;
                    if (rate2 != 0)
                    {
                        reward2 = count * rate2;//
                        Reward rew2 = new Reward();
                        rew2.No = book.No;
                        rew2.count = count;
                        rew2.custom = Intr1;
                        rew2.rate = (rate2 * 100).ToString() + "%";
                        rew2.reward = reward2;
                        rew2.publishDate = DateTime.Now;
                        AddReward(rew2);

                        decimal count_P2 = getDecimal("U_Count", Intr1);
                        count_P += reward2;
                        string Scount_P2 = count_P2.ToString();
                        UpdateC("U_Count", Scount_P2, Intr1);

                        decimal Pay22 = getDecimal("U_Sum", Intr1);
                        Pay22 += reward2;
                        string SPay22 = Pay22.ToString();
                        UpdateC("U_Sum", SPay22, Intr1);
                        return 2;
                    }
                    else
                    return 1;
                }               
                else
                    return 1;
            }
            else 
                return 0;
        }
        public static int AddSettle3(Model.Adjust book)       //代理商核算
        {
            decimal count = 0, reward1, reward2; // 总金额，业绩1，业绩2，系数1，系数2
            int Pro = book.product;                    //产品类别
            decimal Amout = book.amount;               //产品数量
            int Uid = book.custom;                     //会员ID
            int Cust = book.custom1;            
            switch (Pro)
            {
                case 4:
                    count = P_A_4 * Amout;
                    break;
                case 5:
                    count = P_A_5 * Amout;
                    break;
                case 6:
                    count = P_A_6;
                    break;
                case 7:
                    count = P_A_7;
                    break;
            }

            if (Cust != 0)
            {
                int No=book.No ;
                reward2 = getAmount(No);
                reward1 = count - reward2;
                
                Reward rew = new Reward();
                rew.No = book.No;
                rew.count = 0;
                rew.custom = Cust;
                rew.rate = "0";
                rew.reward = reward1;
                rew.publishDate = DateTime.Now;
                AddReward(rew);

                decimal count_P = getDecimal("U_Count", Cust);
                count_P += reward1;
                string Scount_P = count_P.ToString();
                UpdateC("U_Count", Scount_P, Cust);

                decimal Pay2 = getDecimal("U_Sum", Cust);
                Pay2 += reward1;
                string SPay2 = Pay2.ToString();
                UpdateC("U_Sum", SPay2, Cust);
                             
                return 1;           
            }
            else 
                return 0;

            /*int count = getCount();
            int i = 1, n = 0, Uid;
            decimal rate;
            for (i = 1; i <= count; i++)
            {
                Uid = getUId(i);
                bool type = getBool("U_Type", Uid);
                int rank = getInt("U_Grade", Uid);
                if (rank == 12) 
                {
                    rate = C_R_12;
                }
                else
                    rate = C_R_11;

                decimal total = getDecimal("U_TeamSum", Uid);
                if (type && rank != 10)
                {
                    decimal reward = total * rate;
                    Reward rew = new Reward();
                    rew.No = 99;
                    rew.count = total;
                    rew.custom = Uid;
                    rew.rate = (rate * 100).ToString() + "%";
                    rew.reward = reward;
                    rew.publishDate = DateTime.Now;
                    AddReward(rew);

                    decimal count_P = getDecimal("U_Count", Uid);
                    count_P += reward;
                    string Scount_P = count_P.ToString();
                    UpdateC("U_Count", Scount_P, Uid);

                    decimal Pay2 = getDecimal("U_Sum", Uid);
                    Pay2 += reward;
                    string SPay2 = Pay2.ToString();
                    UpdateC("U_Sum", SPay2, Uid);
                    n += 1;
                }
            }
            return n;*/
        }

        public static string AddSettle4()         //根据业绩金额更改会员为市级或省级
        {
            int count = getCount();
            int i = 1, m = 0, n = 0, Uid;
            decimal amount1 = C_A_13, amount2 = C_A_12;
            for (i = 1; i <= count; i++)
            {
                Uid = getUId(i);
                int rank = getInt("U_Grade", Uid);
                decimal total = getDecimal("U_TeamSum", Uid);
                if (rank != 10 && rank != 13)
                {
                    if (total >= amount1)
                    {
                        UpdateC("U_Grade", "13", Uid);
                        AddGrade2(13, Uid);
                        m += 1;
                    }
                    if (total >= amount2 && total < amount1 && rank == 11)
                    {
                        UpdateC("U_Grade", "12", Uid);
                        AddGrade2(12, Uid);
                        n += 1;
                    }                              
                }
            }
            string Sm = m.ToString();
            string Sn = n.ToString();
            return Sm + "升级省级代理商/" + Sn + "升级市级代理商/";
        }
        
        public static bool AddGrade2(int Grade,int Uid)                          //添加级别调整单
        {
            string sql = "insert into U_Grade(U_No,U_Grade,U_Custom,U_Clerk,U_Note,U_LoginTime) values(@U_Number,@U_Adjust,@U_Custom,@U_ClerkType,@U_Note,getdate())";
            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {
             new SqlParameter("@U_Number",SqlDbType.Int),
             new SqlParameter("@U_Adjust",SqlDbType.Int ),
             new SqlParameter("@U_Custom",SqlDbType.Int),
             new SqlParameter("@U_ClerkType",SqlDbType.Int),
             new SqlParameter("@U_Note",SqlDbType.NVarChar,200)
             //new SqlParameter("@U_LoginTime",SqlDbType.DateTime)    
            };
            /*给参数赋值*/
            parm[0].Value = 77;
            parm[1].Value = Grade;
            parm[2].Value = Uid;
            parm[3].Value = 1;
            parm[4].Value = "系统生成";
            //parm[5].Value = DateTime.Now ;
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


        public static bool AddGrade(Model.Adjust book)                          //添加级别调整单
        {
            string sql = "insert into U_Grade(U_No,U_Grade,U_Custom,U_Clerk,U_Note,U_LoginTime) values(@U_Number,@U_Adjust,@U_Custom,@U_ClerkType,@U_Note,@U_LoginTime)";
            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {
             new SqlParameter("@U_Number",SqlDbType.Int),
             new SqlParameter("@U_Adjust",SqlDbType.Int ),
             new SqlParameter("@U_Custom",SqlDbType.Int),
             new SqlParameter("@U_ClerkType",SqlDbType.Int),
             new SqlParameter("@U_Note",SqlDbType.NVarChar,200),
             new SqlParameter("@U_LoginTime",SqlDbType.DateTime)    
            };
            /*给参数赋值*/
            parm[0].Value = book.No;
            parm[1].Value = book.product;
            parm[2].Value = book.custom;
            parm[3].Value = book.clerk;
            parm[4].Value = book.note;
            parm[5].Value = book.publishDate;
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

        public static bool AddGrade2(Model.Adjust book)
        {
            string sql = "update U_Custom set U_Grade=@U_Adjust where U_Id=@U_Custom";

            /*构建sql参数*/
            SqlParameter[] parm = new SqlParameter[] {
             new SqlParameter("@U_Adjust",SqlDbType.Int ),
             new SqlParameter("@U_Custom",SqlDbType.Int),
            };
            /*给参数赋值*/
            parm[0].Value = book.product;
            parm[1].Value = book.custom;
          
            /*执行更新*/
            return (DBHelp.ExecuteNonQuery(sql, parm) > 0) ? true : false;
        }

        public static System.Data.DataTable GetPay(int PageIndex, int PageSize, out int PageCount, out int RecordCount, string strWhere)
        {
            try
            {
                string strSql = " select U_Pay.*,U_Custom.U_Number,U_Custom.U_Name,U_UserInfo.U_Name2 from U_Pay,U_Custom,U_UserInfo where U_Pay.U_Custom=U_Custom.U_Id and U_Pay.U_Clerk=U_UserInfo.U_Id ";
                string strShow = "U_Id as ID,U_No as 单号,U_Number as 会员编号,U_Name as 会员姓名,U_Amount as 金额,U_Name2 as 制单人,convert(char(11),U_LoginTime,20) as 时间,U_Note as 备注";
                return DAL.DBHelp.ExecutePagerWhenPrimaryIsString(PageIndex, PageSize, "U_Id", strShow, strSql, strWhere, " U_Id desc ", out PageCount, out RecordCount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static System.Data.DataTable GetAdjust(int PageIndex, int PageSize, out int PageCount, out int RecordCount, string strWhere)
        {
            try
            {
                string strSql = " select U_Adjust.*,U_Custom.U_Number,U_Custom.U_Name,U_UserInfo.U_Name2 from U_Adjust,U_Custom,U_UserInfo where U_Adjust.U_Custom=U_Custom.U_Id and U_Adjust.U_Clerk=U_UserInfo.U_Id ";
                string strShow = "U_Id as ID,U_No as 单号,U_Number as 会员编号,U_Name as 会员姓名,U_Type as 类型,U_Adjust as 增减,U_Amount as 金额,U_Name2 as 制单人,convert(char(11),U_LoginTime,20) as 时间,U_Note as 备注";
                return DAL.DBHelp.ExecutePagerWhenPrimaryIsString(PageIndex, PageSize, "U_Id", strShow, strSql, strWhere, " U_Id desc ", out PageCount, out RecordCount);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static System.Data.DataTable GetSubmit(int PageIndex, int PageSize, out int PageCount, out int RecordCount, string strWhere)
        {
            try
            {
                string strSql = " select U_Performance.*,U_Custom.U_Number,U_Custom.U_Name,U_UserInfo.U_Name2,ProductType.P_Name,ProductType.P_Amount from U_Performance,U_Custom,U_UserInfo,ProductType where U_Performance.U_Custom=U_Custom.U_Id and U_Performance.U_Clerk=U_UserInfo.U_Id and U_Performance.U_Product=ProductType.P_Id";
                string strShow = "U_Id as ID,U_No as 单号,U_Number as 会员编号,U_Name as 会员姓名,P_Name as 产品,N_Number as 数量,N_Number*P_Amount 金额,U_Custom2 as 代理商,U_Name2 as 制单人,convert(char(11),U_LoginTime,20) as 时间,U_Note as 备注";
                return DAL.DBHelp.ExecutePagerWhenPrimaryIsString(PageIndex, PageSize, "U_Id", strShow, strSql, strWhere, " U_Id desc ", out PageCount, out RecordCount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static System.Data.DataTable GetReward(int PageIndex, int PageSize, out int PageCount, out int RecordCount, string strWhere)
        {
            try
            {
                string strSql = " select U_Reward.*,U_Custom.U_Number,U_Custom.U_Name from U_Reward,U_Custom where U_Reward.U_Custom=U_Custom.U_Id ";
                string strShow = "U_Id as ID,U_No as 单号,U_Number as 会员编号,U_Name as 会员名,U_Count as 业绩,U_Rate as 系数,U_Reward as 金额,convert(char(11),U_LoginTime,20) as 时间";
                return DAL.DBHelp.ExecutePagerWhenPrimaryIsString(PageIndex, PageSize, "U_Id", strShow, strSql, strWhere, " U_Id desc ", out PageCount, out RecordCount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static System.Data.DataTable GetGrade(int PageIndex, int PageSize, out int PageCount, out int RecordCount, string strWhere)
        {
            try
            {
                string strSql = " select U_Grade.*,U_Custom.U_Number,U_Custom.U_Name,U_UserInfo.U_Name2,CustomType.C_Name from U_Grade,U_Custom,U_UserInfo,CustomType where U_Grade.U_Custom=U_Custom.U_Id and U_Grade.U_Clerk=U_UserInfo.U_Id and U_Grade.U_Grade=CustomType.C_Id";
                string strShow = "U_Id as ID,U_No as 单号,U_Number as 会员编号,U_Name as 会员姓名,C_Name as 级别,U_Name2 as 制单人,convert(char(11),U_LoginTime,20) as 时间,U_Note as 备注";
                return DAL.DBHelp.ExecutePagerWhenPrimaryIsString(PageIndex, PageSize, "U_Id", strShow, strSql, strWhere, " U_Id desc ", out PageCount, out RecordCount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataSet S_DataSet()     // 返回一个DataSet数据集
        {
            string cmdText = "select U_Settle.R_ID ID,U_Settle.R_Month 月份,U_UserInfo.U_Name2 制单人,convert(char(11),R_LoginDate,20) 时间 from U_Settle,U_UserInfo where  U_Settle.R_Clerk=U_UserInfo.U_Id";
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

    }
}
