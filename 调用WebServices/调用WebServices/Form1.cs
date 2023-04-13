using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 调用WebServices
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHQ_Click(object sender, EventArgs e)
        {
            WebReference.WebService1 web = new WebReference.WebService1();
            txt.Text = web.HelloWorld();
            txt.Text +="\r\n"+ web.GetName("马文磊");
            foreach (string item in web.GetNames())
            {
                txt.Text += "\r\n"+item;
            }
            DataTable dt = web.GetTable();
            tlMain.DataSource = dt;
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            ServerWebservices.WSindex web = new ServerWebservices.WSindex();
            txt.Text = web.HelloWorld();
            txt.Text += "\r\n" + web.GetName("马文磊");
            DataTable dt = web.GetTable();
            tlMain.DataSource = dt;
        }
    }
}
