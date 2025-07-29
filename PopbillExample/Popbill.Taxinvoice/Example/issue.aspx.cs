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
    public partial class issue : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String ntsConfirmNum = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * "임시저장" 또는 "(역)발행대기" 상태의 세금계산서를 발행(전자서명)하며, "발행완료" 상태로 처리합니다.
             * - "발행완료"된 전자세금계산서는 국세청 전송 이전에 (CancelIssue API)함수로 국세청 신고 대상에서 제외할 수 있습니다.
             * - 세금계산서 국세청 전송 정책 : https://developers.popbill.com/guide/taxinvoice/dotnet/introduction/policy-of-send-to-nts
             * - https://developers.popbill.com/reference/taxinvoice/dotnet/api/issue#Issue
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 문서번호 유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 세금계산서 문서번호
            String mgtKey = "20220525-20220501";

            // 메모
            String memo = "발행메모";

            // 지연발행 강제여부, 기본값 - False
            // 발행마감일이 지난 세금계산서를 발행하는 경우, 가산세가 부과될 수 있습니다.
            // 지연발행 세금계산서를 신고해야 하는 경우 forceIssue 값을 True로 선언하여 발행(Issue API)을 호출할 수 있습니다.
            bool forceIssue = false;

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                IssueResponse response =
                    Global.taxinvoiceService.Issue(testCorpNum, KeyType, mgtKey, memo, forceIssue, testUserID);

                code = response.code.ToString();
                message = response.message;
                ntsConfirmNum = response.ntsConfirmNum;
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
