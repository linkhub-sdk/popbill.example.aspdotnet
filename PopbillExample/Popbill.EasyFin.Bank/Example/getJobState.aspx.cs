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

namespace Popbill.EasyFin.Bank.Example
{
    public partial class getJobState : System.Web.UI.Page
    {
        public String code;
        public String message;
        public EasyFinBankJobState result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 수집 요청 상태를 확인합니다.
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 수집 요청(requestJob API)시 반환반은 작업아이디(jobID)
            String jobID = "019123013000000002";

            try
            {
                result = Global.easyFinBankService.GetJobState(testCorpNum, jobID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
