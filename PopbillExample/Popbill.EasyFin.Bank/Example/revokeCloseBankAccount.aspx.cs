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
    public partial class revokeCloseBankAccount : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 신청한 정액제 해지요청을 취소합니다.
             * - https://developers.popbill.com/reference/easyfinbank/dotnet/api/manage#RevokeCloseBankAccount
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 은행코드
            String BankCode = "";

            // 계좌번호, 하이픈('-') 제외
            String AccountNumber = "";
            try
            {
                Response response = Global.easyFinBankService.RevokeCloseBankAccount(testCorpNum, BankCode, AccountNumber);

                code = response.code.ToString();
                message = response.message;
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
