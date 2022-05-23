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
             * 수집 상태 확인(GetJobState API) 함수를 통해 상태 정보가 확인된 작업아이디를 활용하여 수집된 현금영수증 매입/매출 내역의 요약 정보를 조회합니다.
             * - 요약 정보 : 현금영수증 수집 건수, 공급가액 합계, 세액 합계, 봉사료 합계, 합계 금액
             * - https://docs.popbill.com/htcashbill/dotnet/api#Summary
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 수집 요청(requestJob API)시 반환반은 작업아이디(jobID)
            String jobID = "021032114000000005";

            // 문서형태 배열 ("N" 와 "C" 중 선택, 다중 선택 가능)
            // └ N = 일반 현금영수증 , C = 취소현금영수증
            // └ 미입력시 전체조회
            String[] TradeType = { "N", "C" };

            // 거래구분 배열 ("P" 와 "C" 중 선택, 다중 선택 가능)
            // └ P = 소득공제용 , C = 지출증빙용
            // └ 미입력시 전체조회
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
