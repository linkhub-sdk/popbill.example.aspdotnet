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
    public partial class getUnitCost : System.Web.UI.Page
    {
        public String code;
        public String message;
        public float unitCost;


        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 문자 전송시 과금되는 포인트 단가를 확인합니다.
             * - https://docs.popbill.com/message/dotnet/api#GetUnitCost
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 문자 전송유형 MessageType.SMS(단문), MessageType.LMS(장문), MessageType.MMS(포토)
            MessageType msgType = MessageType.SMS;

            try
            {
                unitCost = Global.messageService.GetUnitCost(testCorpNum, msgType);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
