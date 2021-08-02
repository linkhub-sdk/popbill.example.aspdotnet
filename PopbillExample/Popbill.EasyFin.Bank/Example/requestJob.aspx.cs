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
            /*
             * 계좌 거래내역을 확인하기 위해 팝빌에 수집요청을 합니다. 조회기간은 당일 기준으로 90일 이내로만 지정 가능합니다.
             * - 반환 받은 작업아이디는 함수 호출 시점부터 1시간 동안 유효합니다.
             * - https://docs.popbill.com/easyfinbank/dotnet/api#RequestJob
             */

            // 팝빌회원 사업자번호
            String testCorpNum = "1234567890";

            // 은행코드
            String BankCode = "0048";

            // 은행 계좌번호
            String AccountNumber = "131020538645";

            // 시작일자, 표시형식(yyyyMMdd)
            String SDate = "20210701";

            // 종료일자, 표시형식(yyyyMMdd)
            String EDate = "20210730";

            try
            {
                jobID = Global.easyFinBankService.RequestJob(testCorpNum, BankCode, AccountNumber, SDate, EDate);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
