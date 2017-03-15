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

namespace Popbill.Taxinvoice.Example
{
    public partial class getUnitCost : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public float unitCost = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 전자세금계산서 1건당 발행단가를 확인합니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            try
            {
                unitCost = Global.taxinvoiceService.GetUnitCost(testCorpNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
