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

namespace Popbill.HomeTax.Cashbill.Example
{
    public partial class refund : System.Web.UI.Page
    {
        public RefundResponse result;
        public String code;
        public String message;
        public String refundCode;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 연동회원 포인트를 환불 신청합니다.
             * - https://developers.popbill.com/reference/htcashbill/dotnet/api/point#Refund
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String CorpNum = "1234567890";

            // 환불 신청 객체 정보
            RefundForm refundForm = new RefundForm();

            // 담당자명
            refundForm.ContactName = "담당자명";

            // 담당자 연락처
            refundForm.TEL = "01077777777";

            // 환불 신청 포인트
            refundForm.RequestPoint = "10";

            // 은행명
            refundForm.AccountBank = "국민";

            // 계좌번호
            refundForm.AccountNum = "123123123-123";

            // 예금주명
            refundForm.AccountName = "예금주명";

            // 환불사유
            refundForm.Reason = "환불사유";

            // 팝빌회원 아이디
            String UserID = "testkorea";

            try
            {
                result = Global.htCashbillService.Refund(CorpNum, refundForm, UserID);

                code = result.code.ToString();
                message = result.message;
                refundCode = result.refundCode;
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}