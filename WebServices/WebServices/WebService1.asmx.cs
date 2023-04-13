using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Welcome Mark!";
        }
        [WebMethod]
        public DataTable GetTable()
        {
            DataTable dt = new DataTable();
            dt.TableName = "Mwlzx";
            dt.Columns.Add("ID",typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Sex", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            DataRow newRow = dt.NewRow();
            newRow["ID"] = 1;
            newRow["Name"] = "Mark";
            newRow["Sex"] = "男";
            newRow["Age"] = 24;
            dt.Rows.Add(newRow.ItemArray);
            dt.Rows.Add(new object[] {2,"Zx","女",25 });
            return dt;
        }
        /// <summary>
        /// 获取姓名
        /// </summary>
        /// <param name="Name">名称</param>
        /// <returns></returns>
        [WebMethod]
        public string GetName(string Name)
        {
            return "Welcome  "+Name+"!";
        }

        [WebMethod]
        public List<string> GetNames()//每次发布时需要注意配置iis的默认文档WebService1.asmx，以及目录浏览里边的操作是否启用
        {
            return new List<string>() {"张三","李四","王五","赵六" };
        }
    }
}
