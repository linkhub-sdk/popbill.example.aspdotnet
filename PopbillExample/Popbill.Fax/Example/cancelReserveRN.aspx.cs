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

namespace Popbill.Fax.Example
{
    public partial class CancelReserveRN : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 파트너가 할당한 요청번호로 예약된 팩스를 전송 취소합니다. (예약일시 10분 전까지 가능)
             * - https://developers.popbill.com/reference/fax/dotnet/api/send#CancelReserveRN
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팩스 전송시 기재한 요청번호
            String requestNum = "";

            try
            {
                Response response = Global.faxService.CancelReserveRN(testCorpNum, requestNum);
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
