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
    public partial class updateEmailConfig : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        //전자세금계산서 메일전송 항목에 대한 전송여부를 수정한다.
        //메일전송유형
        //[정발행]
        //TAX_ISSUE : 공급받는자에게 전자세금계산서 발행 메일 입니다.
        //TAX_ISSUE_INVOICER : 공급자에게 전자세금계산서 발행 메일 입니다.
        //TAX_CHECK : 공급자에게 전자세금계산서 수신확인 메일 입니다.
        //TAX_CANCEL_ISSUE : 공급받는자에게 전자세금계산서 발행취소 메일 입니다.

        //[발행예정]
        //TAX_SEND : 공급받는자에게 [발행예정] 세금계산서 발송 메일 입니다.
        //TAX_ACCEPT : 공급자에게 [발행예정] 세금계산서 승인 메일 입니다.
        //TAX_ACCEPT_ISSUE : 공급자에게 [발행예정] 세금계산서 자동발행 메일 입니다.
        //TAX_DENY : 공급자에게 [발행예정] 세금계산서 거부 메일 입니다.
        //TAX_CANCEL_SEND : 공급받는자에게 [발행예정] 세금계산서 취소 메일 입니다.

        //[역발행]
        //TAX_REQUEST : 공급자에게 세금계산서를 발행요청 메일 입니다.
        //TAX_CANCEL_REQUEST : 공급받는자에게 세금계산서 취소 메일 입니다.
        //TAX_REFUSE : 공급받는자에게 세금계산서 거부 메일 입니다.

        //[위수탁발행]
        //TAX_TRUST_ISSUE : 공급받는자에게 전자세금계산서 발행 메일 입니다.
        //TAX_TRUST_ISSUE_TRUSTEE : 수탁자에게 전자세금계산서 발행 메일 입니다.
        //TAX_TRUST_ISSUE_INVOICER : 공급자에게 전자세금계산서 발행 메일 입니다.
        //TAX_TRUST_CANCEL_ISSUE : 공급받는자에게 전자세금계산서 발행취소 메일 입니다.
        //TAX_TRUST_CANCEL_ISSUE_INVOICER : 공급자에게 전자세금계산서 발행취소 메일 입니다.

        //[위수탁 발행예정]
        //TAX_TRUST_SEND : 공급받는자에게 [발행예정] 세금계산서 발송 메일 입니다.
        //TAX_TRUST_ACCEPT : 수탁자에게 [발행예정] 세금계산서 승인 메일 입니다.
        //TAX_TRUST_ACCEPT_ISSUE : 수탁자에게 [발행예정] 세금계산서 자동발행 메일 입니다.
        //TAX_TRUST_DENY : 수탁자에게 [발행예정] 세금계산서 거부 메일 입니다.
        //TAX_TRUST_CANCEL_SEND : 공급받는자에게 [발행예정] 세금계산서 취소 메일 입니다.

        //[처리결과]
        //TAX_CLOSEDOWN : 거래처의 휴폐업 여부 확인 메일 입니다.
        //TAX_NTSFAIL_INVOICER : 전자세금계산서 국세청 전송실패 안내 메일 입니다.

        //[정기발송]
        //TAX_SEND_INFO : 전월 귀속분 [매출 발행 대기] 세금계산서 발행 메일 입니다.
        //ETC_CERT_EXPIRATION : 팝빌에서 이용중인 공인인증서의 갱신 메일 입니다.
        protected void Page_Load(object sender, EventArgs e)
        {

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            //메일전송유형
            String emailType = "TAX_ISSUE";

            //전송여부 (true-전송, false-미전송)
            Boolean sendYN = true;

            try
            {
                Response response = Global.taxinvoiceService.UpdateEmailConfig(testCorpNum, emailType, sendYN, testUserID);
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
