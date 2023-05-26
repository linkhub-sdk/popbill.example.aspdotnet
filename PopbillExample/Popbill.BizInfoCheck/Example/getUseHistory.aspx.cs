using System;
using System.Web.UI;

namespace Popbill.BizInfoCheck.Example
{
    public partial class getUseHistory : Page
    {
        public UseHistoryResult result = null;
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 연동회원의 포인트 사용내역을 확인합니다.
             * - https://developers.popbill.com/reference/bizinfocheck/dotnet/api/point#GetUseHistory
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String CorpNum = "1234567890";

            // 조회 기간의 시작일자 (형식 : yyyyMMdd)
            String SDate = "20230501";

            // 조회 기간의 종료일자 (형식 : yyyyMMdd)
            String EDate = "20230530";

            // 목록 페이지번호 (기본값 1)
            int Page = 1;

            // 페이지당 표시할 목록 개수 (기본값 500, 최대 1,000)
            int PerPage = 500;

            // 거래일자를 기준으로 하는 목록 정렬 방향 : "D" / "A" 중 택 1
            String Order = "D";

            // 팝빌회원 아이디
            String UserID = "testkorea";

            try
            {
                result = Global.bizInfoCheckService.GetUseHistory(CorpNum, SDate, EDate, Page, PerPage, Order, UserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}