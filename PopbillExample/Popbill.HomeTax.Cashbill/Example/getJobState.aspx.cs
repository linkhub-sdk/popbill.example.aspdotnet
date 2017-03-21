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
    public partial class getJobState : System.Web.UI.Page
    {
        public String code;
        public String message;
        public HTCashbillJobState jobState;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 수집 요청 상태를 확인합니다.
            * - 응답항목 관한 정보는 "[홈택스 현금영수증 연계 API 연동매뉴얼
            *   > 3.2.2. GetJobState (수집 상태 확인)" 을 참고하시기 바랍니다 .
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 수집 요청(requestJob API)시 반환반은 작업아이디(jobID)
            String jobID = "017032114000000005";

            try
            {
                jobState = Global.htCashbillService.GetJobState(testCorpNum, jobID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;                
            }
        }
    }
}
