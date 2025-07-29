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
             * 계좌 거래내역 수집을 팝빌에 요청합니다.
             * - https://developers.popbill.com/reference/easyfinbank/dotnet/api/job#RequestJob
             */

            // 팝빌회원 사업자번호
            String testCorpNum = "1234567890";

            // 기관코드
            String BankCode = "";

            // 은행 계좌번호
            String AccountNumber = "";

            // 시작일자, 표시형식(yyyyMMdd)
            String SDate = "20250701";

            // 종료일자, 표시형식(yyyyMMdd)
            String EDate = "20250731";

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
