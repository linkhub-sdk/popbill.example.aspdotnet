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

namespace Popbill.HomeTax.Taxinvoice.Example
{
    public partial class getTaxinvoice : System.Web.UI.Page
    {
        public String code;
        public String message;
        public HTTaxinvoice taxinvoiceInfo;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 홈택스에서 수집된 전자세금계산서 1건의 상세정보를 제공합니다.
             * - https://developers.popbill.com/reference/httaxinvoice/dotnet/api/search#GetTaxinvoice
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 조회할 전자세금계산서 국세청 승인번호
            String ntsConfirmNum = "20210717410002030000017f";

            try
            {
                taxinvoiceInfo = Global.htTaxinvoiceService.GetTaxinvoice(testCorpNum, ntsConfirmNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
