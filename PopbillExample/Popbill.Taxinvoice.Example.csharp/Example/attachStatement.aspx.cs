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
    public partial class attachStatement : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            String testCorpNum = "1234567890";

            // 세금계산서 발행유형 
            MgtKeyType KeyType = MgtKeyType.SELL;

            String mgtKey = "20170314-05";

            // 첨부할 명세서 종류 코드
            int DocItemCode = 121;

            // 첨부할 명세서 관리번호
            String DocMgtKey = "20160202-01";

            try
            {
                Response response = Global.taxinvoiceService.AttachStatement(testCorpNum, KeyType, mgtKey, DocItemCode, DocMgtKey);
                code = response.code.ToString();
                message = response.message;
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
