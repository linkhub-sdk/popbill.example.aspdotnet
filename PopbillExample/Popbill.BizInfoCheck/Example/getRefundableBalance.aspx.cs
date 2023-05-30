using System;
using System.Web.UI;

namespace Popbill.BizInfoCheck.Example
{
    public partial class getRefundableBalance : Page
    {
        public Double refundableBalance;
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 환불 가능한 포인트를 확인합니다. (보너스 포인트는 환불가능포인트에서 제외됩니다.)
             * - https://developers.popbill.com/reference/bizinfocheck/dotnet/api/point#GetRefundableBalance
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String CorpNum = "1234567890";

            // 팝빌회원 아이디
            String UserID = "testkorea";

            try
            {
                refundableBalance = Global.bizInfoCheckService.GetRefundableBalance(CorpNum, UserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}