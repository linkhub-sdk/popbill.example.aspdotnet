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
    public partial class getXML : System.Web.UI.Page
    {

        public String code;
        public String message;
        public HTTaxinvoiceXML taxinvoiceXML;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 국세청 승인번호를 통해 수집한 전자세금계산서 1건의 상세정보를 XML 형태의 문자열로 반환합니다.
             * - https://docs.popbill.com/httaxinvoice/dotnet/api#GetXML
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 조회할 전자세금계산서 국세청 승인번호
            String ntsConfirmNum = "20210317410002030000017f";
            
            try
            {
                taxinvoiceXML = Global.htTaxinvoiceService.GetXML(testCorpNum, ntsConfirmNum);
                
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
