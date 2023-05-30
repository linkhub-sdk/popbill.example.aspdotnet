using System;
using System.Web.UI;

namespace Popbill.Message.Example
{
    public partial class checkAutoDenyNumber : Page
    {
        public String smsdenyNumber;
        public String regDT;

        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {

            /**
             * 팝빌회원에 등록된 080 수신거부 번호 정보를 확인합니다.
             * - https://developers.popbill.com/reference/sms/dotnet/api/info#CheckAutoDenyNumber
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String CorpNum = "1234567890";

            // 팝빌회원 아이디
            String UserID = "testkorea";

            try
            {
                AutoDenyNumberInfo info = Global.messageService.CheckAutoDenyNumber(CorpNum, UserID);
                smsdenyNumber = info.smsdenyNumber;
                regDT = info.regDT;
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }

        }
    }
}