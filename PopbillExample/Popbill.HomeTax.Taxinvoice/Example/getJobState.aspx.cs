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

namespace Popbill.HomeTax.Taxinvoice.Example
{
    public partial class getJobState : System.Web.UI.Page
    {
        public String code;
        public String message;
        public HTTaxinvoiceJobState result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 함수 (RequestJob – 수집 요청)를 통해 반환 받은 작업 아이디의 상태를 확인합니다.
             * - https://docs.popbill.com/httaxinvoice/dotnet/api#GetJobState
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 수집 요청(requestJob API)시 반환반은 작업아이디(jobID)
            String jobID = "021032021000000003";

            try
            {
                result = Global.htTaxinvoiceService.GetJobState(testCorpNum, jobID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }            
        }
    }
}
