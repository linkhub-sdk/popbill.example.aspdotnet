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

namespace Popbill.Statement.Example
{
    public partial class paymentRequest : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String settleCode;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 연동회원 포인트 충전을 위해 무통장입금을 신청합니다.
             * - https://developers.popbill.com/reference/statement/dotnet/api/point#PaymentRequest
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String CorpNum = "1234567890";

            // 입금신청 객체정보
            PaymentForm paymentForm = new PaymentForm();

            // 담당자명
            paymentForm.settlerName = "테스트_담당자명";

            // 담당자 이메일
            paymentForm.settlerEmail = "테스트_담당자 이메일";

            // 담당자 휴대폰
            paymentForm.notifyHP = "테스트_담당자 휴대폰";

            // 입금자명
            paymentForm.paymentName = "테스트_입금자명";

            // 결제금액
            paymentForm.settleCost = "1000";

            // 팝빌회원 아이디
            String UserID = "testkorea";



            try
            {
                PaymentResponse result = Global.statementService.PaymentRequest(CorpNum, paymentForm, UserID);

                code = result.code.ToString();
                message = result.message;
                settleCode = result.settleCode;
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
