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
    public partial class getContactInfo : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public Contact contactInfo = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 연동회원 사업자번호에 등록된 담당자(팝빌 로그인 계정) 정보를 확인합니다.
             * - https://docs.popbill.com/statement/dotnet/api#GetContactInfo
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 확인할 담당자 아아디
            String contactID = "checkContact";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                contactInfo = Global.statementService.GetContactInfo(testCorpNum, contactID, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
