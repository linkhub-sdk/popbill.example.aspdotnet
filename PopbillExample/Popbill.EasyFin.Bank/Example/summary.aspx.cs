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
    public partial class summary : System.Web.UI.Page
    {
        public String code;
        public String message;
        public EasyFinBankSummary summaryInfo;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * GetJobState(수집 상태 확인)를 통해 상태 정보가 확인된 작업아이디를 활용하여 계좌 거래내역의 요약 정보를 조회합니다.
             * - https://docs.popbill.com/easyfinbank/dotnet/api#Summary
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 수집 요청(requestJob API)시 반환반은 작업아이디(jobID)
            String jobID = "019123013000000002";

            // 거래유형 배열, I-입금, O-출금
            String[] TradeType = { "I", "O" };

            // 조회 검색어, 거래처 사업자번호 또는 거래처명 like 검색
            String SearchString = "";

            try
            {
                summaryInfo = Global.easyFinBankService.Summary(testCorpNum, jobID,
                    TradeType, SearchString, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
