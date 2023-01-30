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
             * 수집 요청(RequestJob API) 함수를 통해 반환 받은 작업 아이디의 상태를 확인합니다.
             * - 거래 내역 조회(Search API) 함수 또는 거래 요약 정보 조회(Summary API) 함수를 사용하기 전에
             *   수집 작업의 진행 상태, 수집 작업의 성공 여부를 확인해야 합니다.
             * - 작업 상태(jobState) = 3(완료)이고 수집 결과 코드(errorCode) = 1(수집성공)이면
             *   거래 내역 조회(Search) 또는 거래 요약 정보 조회(Summary) 를 해야합니다.
             * - 작업 상태(jobState)가 3(완료)이지만 수집 결과 코드(errorCode)가 1(수집성공)이 아닌 경우에는
             *   오류메시지(errorReason)로 수집 실패에 대한 원인을 파악할 수 있습니다.
             * - https://developers.popbill.com/reference/easyfinbank/dotnet/api/job#GetJobState
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
