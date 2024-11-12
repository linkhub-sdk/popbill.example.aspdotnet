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
        public String code;
        public String message;

        /**
         * 세금계산서 관련 메일 항목에 대한 발송설정을 수정합니다.
         * - https://developers.popbill.com/reference/taxinvoice/dotnet/api/etc#UpdateEmailConfig
         *
         * 메일전송유형
         * [정발행]
         * TAX_ISSUE_INVOICER : 공급자에게 전자세금계산서 발행 사실을 안내하는 메일
         * TAX_CHECK : 공급자에게 전자세금계산서 수신확인 사실을 안내하는 메일
         * TAX_CANCEL_ISSUE : 공급받는자에게 전자세금계산서 발행취소 사실을 안내하는 메일
         *
         * [역발행]
         * TAX_REQUEST : 공급자에게 전자세금계산서를 발행을 요청하는 메일
         * TAX_CANCEL_REQUEST : 공급받는자에게 전자세금계산서 취소 사실을 안내하는 메일
         * TAX_REFUSE : 공급받는자에게 전자세금계산서 거부 사실을 안내하는 메일
         * TAX_REVERSE_ISSUE : 공급받는자에게 전자세금계산서 발행 사실을 안내하는 메일
         *
         * [위수탁발행]
         * TAX_TRUST_ISSUE : 공급받는자에게 전자세금계산서 발행 사실을 안내하는 메일
         * TAX_TRUST_ISSUE_TRUSTEE : 수탁자에게 전자세금계산서 발행 사실을 안내하는 메일
         * TAX_TRUST_ISSUE_INVOICER : 공급자에게 전자세금계산서 발행 사실을 안내하는 메일
         * TAX_TRUST_CANCEL_ISSUE : 공급받는자에게 전자세금계산서 발행취소 사실을 안내하는 메일
         * TAX_TRUST_CANCEL_ISSUE_INVOICER : 공급자에게 전자세금계산서 발행취소 사실을 안내하는 메일
         *
         * [처리결과]
         * TAX_CLOSEDOWN : 거래처의 사업자등록상태(휴폐업)를 확인하여 안내하는 메일
         * TAX_NTSFAIL_INVOICER : 전자세금계산서 국세청 전송실패를 안내하는 메일
         *
         * [정기발송]
         * ETC_CERT_EXPIRATION : 팝빌에 등록된 인증서의 만료예정을 안내하는 메일
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            //메일전송유형
            String emailType = "TAX_ISSUE_INVOICER";

            //전송여부 (true-전송, false-미전송)
            Boolean sendYN = true;

            try
            {
                Response response =
                    Global.taxinvoiceService.UpdateEmailConfig(testCorpNum, emailType, sendYN);
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
