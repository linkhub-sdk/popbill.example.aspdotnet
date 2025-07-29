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

namespace Popbill.Message.Example
{
    public partial class getChargeInfo : System.Web.UI.Page
    {
        public String code;
        public String message;
        public ChargeInfo chrgInfo = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌 문자 API 서비스 과금정보를 확인합니다.
             * - https://developers.popbill.com/reference/sms/dotnet/common-api/point#GetChargeInfo
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 문자 유형,SMS-단문, LMS-장문, MMS-포토
            MessageType msgType = MessageType.SMS; 

            try
            {
                chrgInfo = Global.messageService.GetChargeInfo(testCorpNum, msgType);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
