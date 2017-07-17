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

namespace Popbill.Fax.Example
{
    public partial class getFaxResult : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<FaxResult> result;

        protected void Page_Load(object sender, EventArgs e)
        {
            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팩스전송 요청시 발급받은 접수번호
            String receiptNum = "017071713443600001";
            
            try
            {
                result = Global.faxService.GetFaxResult(testCorpNum, receiptNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}