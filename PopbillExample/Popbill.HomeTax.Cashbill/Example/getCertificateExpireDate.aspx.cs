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

namespace Popbill.HomeTax.Cashbill.Example
{
    public partial class getCertificateExpireDate : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String expireDate;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 등록된 홈택스 공인인증서의 만료일자를 확인합니다.
            * - https://docs.popbill.com/htcashbill/dotnet/api#GetCertificateExpireDate
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            try
            {
                DateTime expiration = Global.htCashbillService.GetCertificateExpireDate(testCorpNum);

                expireDate = expiration.ToString();
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
