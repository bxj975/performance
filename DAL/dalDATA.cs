/*//using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DAL
{
    public class dalDATA
    { 
        public string ConnectionString; 
        private SqlConnection Conn; 
        private SqlCommand Comm; 
        public string StrSQL; 
        public string DataBaseName; 
        public string DataBase_MDF; 
        public string DataBase_LDF; 
        public string DataBaseOfBackupName; 
        public string DataBaseOfBackupPath; 
        private void Form1_Load(object sender, EventArgs e) 
        { 
            C; 
            DataBaseName = "risheng";
            DataBase_MDF = @ "E:\risheng_Data.MDF";
            DataBase_LDF = @ "E:\risheng_Log.LDF";
            AddDataBase(); 
        } 
        /// <summary> 
        /// 执行创建/修改数据库和表的操作 
        /// </summary> 
        public void DataBaseAndTableControl() 
        { 
            try 
            { 
                Conn = new SqlConnection(ConnectionString); 
                Conn.Open(); 
                Comm = new SqlCommand(); 
                Comm.Connection = Conn; 
                Comm.CommandText = StrSQL; 
                Comm.CommandType = CommandType.Text; 
                Comm.ExecuteNonQuery(); 
                MessageBox.Show( "数据库操作成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            finally 
            { 
                Conn.Close(); 
            } 
        } 
        /// <summary> 
        /// 附加数据库 
        /// </summary> 
        public void AddDataBase() 
        { 
            try 
            { 
                Conn = new SqlConnection(ConnectionString); 
                Conn.Open(); 
                Comm = new SqlCommand(); 
                Comm.Connection = Conn; 
                Comm.CommandText = "sp_attach_db";
                Comm.Parameters.Add(new SqlParameter(@ "dbname", SqlDbType.NVarChar));
                Comm.Parameters[@ "dbname"].Value = DataBaseName;
                Comm.Parameters.Add(new SqlParameter(@ "filename1", SqlDbType.NVarChar));
                Comm.Parameters[@ "filename1"].Value = DataBase_MDF;
                Comm.Parameters.Add(new SqlParameter(@ "filename2", SqlDbType.NVarChar));
                Comm.Parameters[@ "filename2"].Value = DataBase_LDF;
                Comm.CommandType = CommandType.StoredProcedure; 
                Comm.ExecuteNonQuery(); 
                MessageBox.Show( "附加数据库成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            finally 
            { 
                Conn.Close(); 
            } 
        } 
        /// <summary> 
        /// 分离数据库 
        /// </summary> 
        public void DeleteDataBase() 
        { 
            try 
            { 
                Conn = new SqlConnection(ConnectionString); 
                Conn.Open(); 
                Comm = new SqlCommand(); 
                Comm.Connection = Conn; 
                Comm.CommandText = @ "sp_detach_db";
                Comm.Parameters.Add(new SqlParameter(@ "dbname", SqlDbType.NVarChar));

                Comm.Parameters[@ "dbname"].Value = DataBaseName;
                Comm.CommandType = CommandType.StoredProcedure; 
                Comm.ExecuteNonQuery(); 
                MessageBox.Show( "分离数据库成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            finally 
            { 
                Conn.Close(); 
            } 
        } 
        /// <summary> 
        /// 备份数据库 
        /// </summary> 
        public void BackupDataBase() 
        { 
            try 
            { 
                Conn = new SqlConnection(ConnectionString); 
                Conn.Open(); 
                Comm = new SqlCommand(); 
                Comm.Connection = Conn; 
                Comm.CommandText = "use master;backup database @dbname to disk = @backupname;";
                Comm.Parameters.Add(new SqlParameter(@ "dbname", SqlDbType.NVarChar));
                Comm.Parameters[@ "dbname"].Value = DataBaseName;
                Comm.Parameters.Add(new SqlParameter(@ "backupname", SqlDbType.NVarChar));
                Comm.Parameters[@ "backupname"].Value = @DataBaseOfBackupPath + @DataBaseOfBackupName;
                Comm.CommandType = CommandType.Text; 
                Comm.ExecuteNonQuery(); 
                MessageBox.Show( "备份数据库成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            finally 
            { 
                Conn.Close(); 
            } 
        } 
        /// <summary> 
        /// 还原数据库 
        /// </summary> 
        public void ReplaceDataBase() 
        { 
            try 
            { 
                string BackupFile = @DataBaseOfBackupPath + @DataBaseOfBackupName; 
                Conn = new SqlConnection(ConnectionString); 
                Conn.Open(); 
                Comm = new SqlCommand(); 
                Comm.Connection = Conn; 
                Comm.CommandText = "use master;restore database @DataBaseName From disk = @BackupFile with replace;";
                Comm.Parameters.Add(new SqlParameter(@ "DataBaseName", SqlDbType.NVarChar));
                Comm.Parameters[@ "DataBaseName"].Value = DataBaseName;
                Comm.Parameters.Add(new SqlParameter(@ "BackupFile", SqlDbType.NVarChar));
                Comm.Parameters[@ "BackupFile"].Value = BackupFile;
                Comm.CommandType = CommandType.Text; 
                Comm.ExecuteNonQuery(); 
                MessageBox.Show( "还原数据库成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            finally 
            { 
                Conn.Close(); 
            } 
        } 
              //  还原数据库 
        private void button0_Click(object sender, EventArgs e) 
        { 
            C; 
            DataBaseName = "MyDatabase"; 
            DataBaseOfBackupName = @ "back.bak"; 
            DataBaseOfBackupPath = @ "D:\Program Files\Microsoft SQL Server\MSSQL\Data\"; 
            ReplaceDataBase(); 
        } 
          
          // 附加数据库 
        private void button1_Click_1(object sender, EventArgs e) 
        { 
            C; 
            DataBaseName = "MyDatabase"; 
            DataBase_MDF = @ "D:\Program Files\Microsoft SQL Server\MSSQL\Data\MyDatabase_Data.MDF"; 
            DataBase_LDF = @ "D:\Program Files\Microsoft SQL Server\MSSQL\Data\MyDatabase_Log.LDF"; 
            AddDataBase(); 
        } 
          
          // 备份数据库 
        private void button2_Click(object sender, EventArgs e) 
        { 
            C; 
            DataBaseName = "MyDatabase"; 
            DataBaseOfBackupName = @ "back.bak"; 
            DataBaseOfBackupPath = @ "D:\Program Files\Microsoft SQL Server\MSSQL\Data\"; 
            BackupDataBase(); 
        } 
          
          // 分离数据库 
        private void button3_Click(object sender, EventArgs e) 
        { 
            C; 
            DataBaseName = "MyDatabase"; 
            DeleteDataBase(); 
        } 
    } 
}*/


