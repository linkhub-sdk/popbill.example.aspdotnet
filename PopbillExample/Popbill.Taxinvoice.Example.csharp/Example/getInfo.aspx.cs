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
    public partial class getInfo : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public TaxinvoiceInfo taxinvoiceInfo = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            String testCorpNum = "1234567890";

            String mgtKey = "20170314-01";

            // 세금계산서 발행유형 
            MgtKeyType KeyType = MgtKeyType.SELL;

            try
            {
                taxinvoiceInfo = Global.taxinvoiceService.GetInfo(testCorpNum, KeyType, mgtKey);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
