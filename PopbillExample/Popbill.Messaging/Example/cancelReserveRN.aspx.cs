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

namespace Popbill.Message.Example
{
    public partial class cancelReserveRN : System.Web.UI.Page
    {

        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 파트너가 할당한 전송요청 번호를 통해 예약접수된 문자 전송을 취소합니다. (예약시간 10분 전까지 가능)
             * - https://docs.popbill.com/message/dotnet/api#CancelReserveRN
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 문자전송시 할당한 요청번호
            String requestNum = "";

            try
            {
                Response response = Global.messageService.CancelReserveRN(testCorpNum, requestNum);

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
