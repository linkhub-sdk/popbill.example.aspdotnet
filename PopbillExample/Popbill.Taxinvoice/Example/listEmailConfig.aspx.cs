using System;
using System.Collections.Generic;
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
    public partial class listEmailConfig : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<EmailConfig> emailConfigList = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 세금계산서 관련 메일 항목에 대한 발송설정을 확인합니다.
             * - https://developers.popbill.com/reference/taxinvoice/dotnet/api/etc#ListEmailConfig
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                emailConfigList = Global.taxinvoiceService.ListEmailConfig(testCorpNum, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
