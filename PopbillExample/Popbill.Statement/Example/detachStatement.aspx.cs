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
    public partial class detachStatement : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 전자명세서에 첨부된 다른 전자명세서를 첨부해제합니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 명세서 종류 코드 - 121(거래명세서), 122(청구서), 123(견적서) 124(발주서), 125(입금표), 126(영수증)
            int itemCode = 121;

            // 전자명세서 문서관리번호
            String mgtKey = "20170316-01";

            // 첨부해제할 명세서 종류 코드 - 121(거래명세서), 122(청구서), 123(견적서) 124(발주서), 125(입금표), 126(영수증)
            int SubItemCode = 121;

            // 첨부해제할 명세서 관리번호 
            String SubMgtKey = "20160202-03";

            try
            {
                Response response = Global.statementService.DetachStatement(testCorpNum, itemCode, mgtKey, SubItemCode, SubMgtKey);

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
