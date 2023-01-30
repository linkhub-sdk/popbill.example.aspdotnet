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

namespace Popbill.EasyFin.Bank.Example
{
    public partial class search : System.Web.UI.Page
    {
        public String code;
        public String message;
        public EasyFinBankSearchResult result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 수집 상태 확인(GetJobState API) 함수를 통해 상태 정보가 확인된 작업아이디를 활용하여 계좌 거래 내역을 조회합니다.
             * - https://developers.popbill.com/reference/easyfinbank/dotnet/api/search#Search
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 수집 요청(requestJob API)시 반환반은 작업아이디(jobID)
            String jobID = "020080618000000001";

            // 거래유형 배열 ("I" 와 "O" 중 선택, 다중 선택 가능)
            // └ I = 입금 , O = 출금
            // - 미입력 시 전체조회
            String[] TradeType = { "I", "O" };

            // "입·출금액" / "메모" / "비고" 중 검색하고자 하는 값 입력
            // - 메모 = 거래내역 메모저장(SaveMemo)을 사용하여 저장한 값
            // - 비고 = EasyFinBankSearchDetail의 remark1, remark2, remark3 값
            // - 미입력시 전체조회
            String SearchString = "";

            // 페이지번호
            int Page = 1;

            // 페이지당 목록개수, 최대 1000건
            int PerPage = 10;

            // 정렬방향 D-내림차순, A-오름차순
            String Order = "D";

            try
            {
                result = Global.easyFinBankService.Search(testCorpNum, jobID,
                    TradeType, SearchString, Page, PerPage, Order);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
