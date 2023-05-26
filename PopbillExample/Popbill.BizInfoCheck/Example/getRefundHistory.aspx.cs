using System;
using System.Web.UI;

namespace Popbill.BizInfoCheck.Example
{
    public partial class getRefundHistory : Page
    {
        public RefundHistoryResult result = null;
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 연동회원의 포인트 환불신청내역을 확인합니다.
             * - https://developers.popbill.com/reference/bizinfocheck/dotnet/api/point#GetRefundHistory
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String CorpNum = "1234567890";

            // 목록 페이지번호 (기본값 1)
            int Page = 1;

            // 페이지당 표시할 목록 개수 (기본값 500, 최대 1,000)
            int PerPage = 500;

            // 팝빌회원 아이디
            String UserID = "testkorea";

            try
            {
                result = Global.bizInfoCheckService.GetRefundHistory(CorpNum, Page, PerPage, UserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}