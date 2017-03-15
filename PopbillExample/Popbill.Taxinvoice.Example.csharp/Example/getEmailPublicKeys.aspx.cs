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
            * 대용량 연계사업자 유통메일주소 목록을 반환합니다.
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
