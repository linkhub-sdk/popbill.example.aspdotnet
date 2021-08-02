using System;
using System.Collections;
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
    public partial class getEmailPublicKeys : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public List<EmailPublicKey> KeyList = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 전자세금계산서 유통사업자의 메일 목록을 확인합니다.
             * - https://docs.popbill.com/taxinvoice/dotnet/api#GetEmailPublicKeys
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            try
            {
                KeyList = Global.taxinvoiceService.GetEmailPublicKeys(testCorpNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
