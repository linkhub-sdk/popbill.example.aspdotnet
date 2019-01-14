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

namespace Popbill.Cashbill.Example
{
    public partial class getUnitCost : System.Web.UI.Page
    {
        public String code;
        public String message;
        public float unitCost;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌 현금영수증 문서함 팝업 URL을 반환합니다.
             * - 보안정책으로 인해 반환된 URL의 유효시간은 30초입니다.
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";
            
            try
            {
                unitCost = Global.cashbillService.GetUnitCost(testCorpNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
