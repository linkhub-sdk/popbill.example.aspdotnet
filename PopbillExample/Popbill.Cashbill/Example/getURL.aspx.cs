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

namespace Popbill.Cashbill.Example
{
    public partial class getURL : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String url;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 현금영수증 문서함의 팝업 URL을 반환합니다.
             * - https://developers.popbill.com/reference/cashbill/dotnet/api/info#GetURL
             */

            String testCorpNum = "1234567890";

            String testUserID = "testkorea";

            // TBOX[임시문서함], PBOX[발행문서함], WRITE[현금영수증 신규작성]
            String TOGO = "TBOX";

            try
            {
                url = Global.cashbillService.GetURL(testCorpNum, testUserID, TOGO);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}