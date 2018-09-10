using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InstallData
{
    [RunInstaller(true)] //安装程序集时调用自定义操作安装程序  
    public partial class DBInstaller : System.Configuration.Install.Installer
    {
        public DBInstaller()
        {
            InitializeComponent();
        }
        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver);
            string path = this.Context.Parameters["targetdir"];
            frmDb dbForm = new frmDb(path);
            DialogResult DialogResult = dbForm.ShowDialog();
            if (dbForm.ShowDialog() == DialogResult.OK)
            {
            }
            else
            {
                throw new ApplicationException("应用程序安装失败");
            }         
        }
    }  
}
