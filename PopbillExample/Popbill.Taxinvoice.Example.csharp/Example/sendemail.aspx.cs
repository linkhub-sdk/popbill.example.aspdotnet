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
    public partial class sendemail : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {

            String testCorpNum = "1234567890";
            String testUserID = "testkorea";
            String mgtKey = "20170314-05";

            // 세금계산서 발행유형 
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 수신메일주소
            String email = "test@test.com";

            try
            {
                Response response = Global.taxinvoiceService.SendEmail(testCorpNum, KeyType, mgtKey, email, testUserID);

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
