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
    public partial class getXML : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public TaxinvoiceXML TaxinvoiceXML = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 세금계산서 1건의 상세정보를 XML로 반환합니다.
             * - https://developers.popbill.com/reference/taxinvoice/dotnet/api/info#GetXML
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 세금계산서 발행유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType keyType = MgtKeyType.SELL;

            // 세금계산서 문서번호
            String mgtKey = "20220525-001";

            try
            {
                TaxinvoiceXML = Global.taxinvoiceService.GetXML(testCorpNum, keyType, mgtKey);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
