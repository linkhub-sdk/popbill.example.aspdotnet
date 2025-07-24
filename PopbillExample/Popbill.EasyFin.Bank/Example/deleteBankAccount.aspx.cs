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
    public partial class deleteBankAccount : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 등록된 계좌를 삭제합니다.
             * - https://developers.popbill.com/reference/easyfinbank/dotnet/api/manage#DeleteBankAccount
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 기관코드
            String BankCode = "";

            // 계좌번호, 하이픈('-') 제외
            String AccountNumber = "";

            try
            {
                Response response = Global.easyFinBankService.DeleteBankAccount(testCorpNum, BankCode, AccountNumber);

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
