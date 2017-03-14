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
    public partial class sendfax : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            String testCorpNum = "1234567890";

            String testUserID = "testkorea";
            
            // 세금계산서 발행유형 
            MgtKeyType KeyType = MgtKeyType.SELL;

            String mgtKey = "20170314-05";

            // 발신번호
            String senderNum = "070-4304-2991";

            // 수신팩스번호
            String receiverNum = "070-111-222";

            try
            {
                Response response = Global.taxinvoiceService.SendFAX(testCorpNum, KeyType, mgtKey, senderNum, receiverNum, testUserID);

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
