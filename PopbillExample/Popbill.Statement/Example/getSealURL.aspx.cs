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
    public partial class getSealURL : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String url = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 전자명세서에 첨부될 인감, 사업자등록증, 통장사본을 등록하는 팝업 URL을 반환합니다.
             * - https://developers.popbill.com/reference/statement/dotnet/api/etc#GetSealURL
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                url = Global.statementService.GetSealURL(testCorpNum, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
