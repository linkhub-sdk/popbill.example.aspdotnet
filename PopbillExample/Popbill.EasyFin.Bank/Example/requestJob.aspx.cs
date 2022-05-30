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
    public partial class requestJob : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String jobID;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 계좌 거래내역을 확인하기 위해 팝빌에 수집요청을 합니다. (조회기간 단위 : 최대 1개월)
             * - 조회일로부터 최대 3개월 이전 내역까지 조회할 수 있습니다.
             * - 반환 받은 작업아이디는 함수 호출 시점부터 1시간 동안 유효합니다.
             * - https://docs.popbill.com/easyfinbank/dotnet/api#RequestJob
             */

            // 팝빌회원 사업자번호
            String testCorpNum = "1234567890";

            // 기관코드
            String BankCode = "";

            // 은행 계좌번호
            String AccountNumber = "";

            // 시작일자, 표시형식(yyyyMMdd)
            String SDate = "20220501";

            // 종료일자, 표시형식(yyyyMMdd)
            String EDate = "20220525";

            // 팝빌회원 아이디
            String userID = "testkorea";

            try
            {
                jobID = Global.easyFinBankService.RequestJob(testCorpNum, BankCode, AccountNumber, SDate, EDate, userID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
