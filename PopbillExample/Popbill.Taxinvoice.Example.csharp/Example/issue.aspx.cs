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

namespace Popbill.Taxinvoice
{
    public partial class issue : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {

            /**
            *[발행완료] 상태의 세금계산서를 [발행취소] 처리합니다.
            * - [발행취소]는 국세청 전송전에만 가능합니다.
            * - 발행취소된 세금계산서는 국세청에 전송되지 않습니다.
            * - 발행취소 세금계산서에 기재된 문서관리번호를 재사용 하기 위해서는
            *   삭제(Delete API)를 호출하여 [삭제] 처리 하셔야 합니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 세금계산서 발행유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 세금계산서 문서관리번호
            String mgtKey = "20170314-05";

            // 메모
            String memo = "발행메모";

            // 지연발행 강제여부, 기본값 - False
            // 발행마감일이 지난 세금계산서를 발행하는 경우, 가산세가 부과될 수 있습니다.
            // 지연발행 세금계산서를 신고해야 하는 경우 forceIssue 값을 True로 선언하여 발행(Issue API)을 호출할 수 있습니다.
            bool forceIssue = false;

            try
            {
                Response response = Global.taxinvoiceService.Issue(testCorpNum, KeyType, mgtKey, memo, forceIssue, testUserID);

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
