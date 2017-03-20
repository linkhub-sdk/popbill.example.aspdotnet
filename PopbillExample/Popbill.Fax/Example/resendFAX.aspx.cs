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
            * 팩스를 재전송합니다.
            * - 전송일로부터 180일이 경과된 경우 재전송할 수 없습니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 팩스전송 요청시 발급받은 접수번호
            String preReceiptNum = "017032013534100001";

            // 발신번호, 공백으로 처리시 기존전송정보로 전송
            String senderNum = "";

            // 발신자명, 공백으로 처리시 기존전송정보로 전송
            String senderName = "";

            // 수신번호/수신자명을 공백으로 처리시 기존전송정보로 전송
            // 수신번호
            String receiverNum = "";

            // 수신자명 
            String receiverName = "";

            // 예약전송일시(yyyyMMddHHmmss), null인 경우 즉시전송
            String reserveDTStr = "";

            DateTime? reserveDT = null;

            if (reserveDTStr != null && reserveDTStr != "")
            {
                reserveDT = DateTime.ParseExact(reserveDTStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
            }

            try
            {
                receiptNum = Global.faxService.ResendFAX(testCorpNum, preReceiptNum,
                    senderNum, senderName, receiverNum, receiverName, reserveDT, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
