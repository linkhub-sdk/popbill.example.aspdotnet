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
    public partial class getMessagesRN : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<MessageResult> result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 파트너가 할당한 전송요청 번호를 통해 문자 전송상태 및 결과를 확인합니다.
             * - https://docs.popbill.com/message/dotnet/api#GetMessageResultRN
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 문자전송시 할당한 요청번호
            String requestNum = "20210703-002";

            try
            {
                result = Global.messageService.GetMessageResultRN(testCorpNum, requestNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
