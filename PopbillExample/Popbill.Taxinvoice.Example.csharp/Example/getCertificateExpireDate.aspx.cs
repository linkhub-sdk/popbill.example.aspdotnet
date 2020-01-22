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
    public partial class getCertificateExpireDate : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public DateTime expiration;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌에 등록되어 있는 공인인증서의 만료일자를 확인합니다.
             * - 공인인증서가 갱신/재발급/비밀번호 변경이 되는 경우 해당 인증서를
             *   재등록 하셔야 정상적으로 세금계산서를 발행할 수 있습니다.
             * - https://docs.popbill.com/taxinvoice/dotnet/api#GetCertificateExpireDate
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            try
            {
                expiration = Global.taxinvoiceService.GetCertificateExpireDate(testCorpNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
