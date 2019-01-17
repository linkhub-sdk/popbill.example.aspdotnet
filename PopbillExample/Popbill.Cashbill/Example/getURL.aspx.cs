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
             * 팝빌 현금영수증 문서함 팝업 URL을 반환합니다.
             * TOGO - TBOX-임시문서함, PBOX-발행문서함, WRITE-현금영수증 신규작성
             * 반환된 URL은 보안정책에 따라 30초의 유효시간을 갖습니다.
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