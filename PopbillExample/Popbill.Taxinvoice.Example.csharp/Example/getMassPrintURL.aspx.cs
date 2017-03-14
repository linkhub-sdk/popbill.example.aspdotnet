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
    public partial class getMassPrintURL : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public String url = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            String testCorpNum = "1234567890";

            String testUserID = "testkorea";

            // 세금계산서 발행유형 
            MgtKeyType KeyType = MgtKeyType.SELL;

            List<string> MgtKeyList = new List<string>();

            // 인쇄할 세금계산서 문서관리번호, (최대 1000건)
            MgtKeyList.Add("20170314-01");
            MgtKeyList.Add("20170314-02");
            MgtKeyList.Add("20170314-03");
            MgtKeyList.Add("20170314-04");

            try
            {
                url = Global.taxinvoiceService.GetMassPrintURL(testCorpNum, KeyType, MgtKeyList, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;                
            }
        }
    }
}