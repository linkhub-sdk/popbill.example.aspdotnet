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

namespace Popbill.Taxinvoice.Example
{
    public partial class checkIsMember : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {         
            // 팝빌회원 사업자번호
            String testCorpNum = "1234567890";

            String LinkID = "TESTER";

            try
            {
                Response response = Global.taxinvoiceService.CheckIsMember(testCorpNum, LinkID);

                code = response.code.ToString();
                message = response.message;
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
