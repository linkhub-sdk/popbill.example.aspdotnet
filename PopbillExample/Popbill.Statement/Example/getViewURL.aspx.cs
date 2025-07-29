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
    public partial class getViewURL : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String url;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 전자명세서 1건의 팝업 URL을 반환합니다.
             * - https://developers.popbill.com/reference/statement/dotnet/api/view#GetViewURL
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 전자명세서 문서 유형 - 121(거래명세서), 122(청구서), 123(견적서), 124(발주서), 125(입금표), 126(영수증)
            int itemCode = 121;

            // 전자명세서 문서번호
            String mgtKey = "20220525-001";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                url = Global.statementService.GetViewURL(testCorpNum, itemCode, mgtKey, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
