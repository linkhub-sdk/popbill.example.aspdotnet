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
    public partial class getFlatRateState : System.Web.UI.Page
    {
        public String code;
        public String message;
        public EasyFinBankFlatRate flatRateInfo;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 계좌조회 정액제 서비스 상태를 확인합니다.
             * - https://docs.popbill.com/easyfinbank/dotnet/api#GetFlatRateState
             */


            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 은행코드
            String BankCode = "";

            // 은행 계좌번호
            String AccountNumber = "";

            try
            {
                flatRateInfo = Global.easyFinBankService.GetFlatRateState(testCorpNum, BankCode, AccountNumber, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
