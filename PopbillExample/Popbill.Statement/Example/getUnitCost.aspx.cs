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
    public partial class getUnitCost : System.Web.UI.Page
    {
        public String code;
        public String message;
        public float unitCost;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 전자명세서 발행시 과금되는 포인트 단가를 확인합니다.
             * - https://developers.popbill.com/reference/statement/dotnet/api/point#GetUnitCost
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 명세서 종류 코드 - 121(거래명세서), 122(청구서), 123(견적서), 124(발주서), 125(입금표), 126(영수증)
            int itemCode = 121;

            try
            {
                unitCost = Global.statementService.GetUnitCost(testCorpNum, itemCode);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
