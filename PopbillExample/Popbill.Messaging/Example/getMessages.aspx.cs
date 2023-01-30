using System;
using System.Collections;
using System.Collections.Generic;
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
    public partial class getMessages : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<MessageResult> result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌에서 반환받은 접수번호를 통해 문자 전송상태 및 결과를 확인합니다.
             * - https://developers.popbill.com/reference/sms/dotnet/api/info#GetMessageResult
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 문자전송 요청시 발급받은 접수번호
            String receiptNum = "021010809000000005";

            try
            {
                result = Global.messageService.GetMessageResult(testCorpNum, receiptNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
