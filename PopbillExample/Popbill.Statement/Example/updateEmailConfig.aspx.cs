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

namespace Popbill.Statement.Example
{
    public partial class updateEmailConfig : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {

            /**
             * 전자명세서 관련 메일 항목에 대한 발송설정을 수정합니다.
             * - https://docs.popbill.com/statement/dotnet/api#UpdateEmailConfig
             *
             * 메일전송유형
             * SMT_ISSUE : 공급받는자에게 전자명세서가 발행 되었음을 알려주는 메일입니다.
             * SMT_ACCEPT : 공급자에게 전자명세서가 승인 되었음을 알려주는 메일입니다.
             * SMT_DENY : 공급자에게 전자명세서가 거부 되었음을 알려주는 메일입니다.
             * SMT_CANCEL : 공급받는자에게 전자명세서가 취소 되었음을 알려주는 메일입니다.
             * SMT_CANCEL_ISSUE : 공급받는자에게 전자명세서가 발행취소 되었음을 알려주는 메일입니다.
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            //메일전송유형
            String emailType = "SMT_ISSUE";

            //전송여부 (true-전송, false-미전송)
            Boolean sendYN = true;

            try
            {
                Response response = Global.statementService.UpdateEmailConfig(testCorpNum, emailType, sendYN);
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
