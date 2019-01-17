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
    public partial class search : System.Web.UI.Page
    {
        public String code;
        public String message;
        public HTCashbillSearch result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 현금영수증 매입/매출 내역의 수집 결과를 조회합니다.
             * - 응답항목에 관한 정보는 "[홈택스연동 (현금영수증) API 연동매뉴얼] >
             *  3.2.1. Search(수집 결과 조회)" 을 참고하시기 바랍니다.
             */
            
            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 수집 요청(requestJob API)시 반환반은 작업아이디(jobID)
            String jobID = "017032114000000005";

            // 현금영수증 형태 배열, N-일반 현금영수증, C-취소 현금영수증
            String[] TradeType = { "N", "C" };

            // 거래용도 배열, P-소득공제용, C-지출증빙용
            String[] TradeUsage = { "P", "C" };

            // 페이지번호
            int Page = 1;

            // 페이지당 목록개수, 최대 1000건
            int PerPage = 10;

            // 정렬방향 D-내림차순, A-오름차순
            String Order = "D";

            try
            {
                result = Global.htCashbillService.Search(testCorpNum, jobID, TradeType, TradeUsage, Page, PerPage, Order, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;                
            }
        }
    }
}
