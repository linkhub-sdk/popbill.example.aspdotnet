using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Popbill.Fax.Example
{
    public partial class getURL : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String url;

        protected void Page_Load(object sender, EventArgs e)
        {
            String testCorpNum = "1234567890";

            String testUserID = "testkorea";

            try
            {
                url = Global.faxService.GetURL(testCorpNum, testUserID, "BOX");
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
