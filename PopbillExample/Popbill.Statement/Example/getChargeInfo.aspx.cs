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
    public partial class getChargeInfo : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public ChargeInfo chrgInfo = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 전자명세서 API 서비스 과금정보를 확인합니다.
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 명세서 코드 - 121(거래명세서), 122(청구서), 123(견적서), 124(발주서), 125(입금표), 126(영수증)
            int itemCode = 121;

            try
            {
                chrgInfo = Global.statementService.GetChargeInfo(testCorpNum, itemCode);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
