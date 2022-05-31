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
    public partial class checkSenderNumber : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 문자 발신번호 등록여부를 확인합니다.
             * - 발신번호 상태가 '승인'인 경우에만 리턴값 'Response'의 변수 'code'가 1로 반환됩니다.
             * - https://docs.popbill.com/message/dotnet/api#CheckSenderNumber
             */

            // 사업자번호
            String testCorpNum = "1234567890";

            // 확인할 발신번호
            String SenderNumber = "";

            try
            {
                Response response = Global.messageService.CheckSenderNumber(testCorpNum, SenderNumber);

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
