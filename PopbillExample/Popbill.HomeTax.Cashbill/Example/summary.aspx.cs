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
    public partial class summary : System.Web.UI.Page
    {
        public String code;
        public String message;
        public HTCashbillSummary summaryInfo;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 전자세금계산서 매입/매출 내역의 수집 결과 요약정보를 조회합니다.
             * - 응답항목에 관한 정보는 "[홈택스연동 (전자세금계산서계산서) API 연동매뉴얼] >
             *   3.2.2. Summary(수집 결과 요약정보 조회)" 을 참고하시기 바랍니다.
             */
            
            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 수집 요청(requestJob API)시 반환반은 작업아이디(jobID)
            String jobID = "017032114000000005";

            // 현금영수증 형태 배열, N-일반 현금영수증, C-취소 현금영수증
            String[] TradeType = { "N", "C" };

            // 거래용도 배열, P-소득공제용, C-지출증빙용
            String[] TradeUsage = { "P", "C" };

            try
            {
                summaryInfo = Global.htCashbillService.Summary(testCorpNum, jobID, TradeType, TradeUsage);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
