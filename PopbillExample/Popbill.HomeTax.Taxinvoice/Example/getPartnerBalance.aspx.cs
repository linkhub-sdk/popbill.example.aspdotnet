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
    public partial class getPartnerBalance : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public String remainPoint = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 파트너의 잔여포인트를 확인합니다.
             * - 과금방식이 연동과금인 경우 연동회원 잔여포인트 확인(GetBalance API) 함수를 이용하시기 바랍니다.
             * - https://developers.popbill.com/reference/httaxinvoice/dotnet/api/point#GetPartnerBalance
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            try
            {
                double response = Global.htTaxinvoiceService.GetPartnerBalance(testCorpNum);

                remainPoint = response.ToString();
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
