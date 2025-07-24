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
    public partial class resendFAX : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String receiptNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌에서 반환받은 접수번호를 통해 팩스 1건을 재전송합니다.
             * - https://developers.popbill.com/reference/fax/dotnet/api/send#ResendFAX
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 팩스전송 요청시 발급받은 접수번호
            String preReceiptNum = "017071713224800001";

            // 발신번호, 공백으로 처리시 기존전송정보로 전송
            String senderNum = "";

            // 발신자명, 공백으로 처리시 기존전송정보로 전송
            String senderName = "";

            // 수신번호, 공백으로 처리시 기존전송정보로 전송
            String receiverNum = "";

            // 수신자명, 공백으로 처리시 기존전송정보로 전송
            String receiverName = "";

            // 예약전송일시(yyyyMMddHHmmss), null인 경우 즉시전송
            String reserveDTStr = "";

            DateTime? reserveDT = null;

            if (reserveDTStr != null && reserveDTStr != "")
            {
                reserveDT = DateTime.ParseExact(reserveDTStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
            }

            // 팩스제목
            String title = "팩스 재전송 제목";

            try
            {
                receiptNum = Global.faxService.ResendFAX(testCorpNum, preReceiptNum,
                    senderNum, senderName, receiverNum, receiverName, reserveDT, testUserID, title);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
