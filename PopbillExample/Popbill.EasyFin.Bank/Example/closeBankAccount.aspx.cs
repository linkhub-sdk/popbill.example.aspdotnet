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
    public partial class closeBankAccount : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌에 등록된 계좌의 정액제 해지를 요청합니다.
             * - https://developers.popbill.com/reference/easyfinbank/dotnet/api/manage#CloseBankAccount
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "";

            // 기관코드
            String BankCode = "";

            // 계좌번호, 하이픈('-') 제외
            String AccountNumber = "";

            // 해지유형
            // 일반(일반해지) – 이용중인 정액제 기간 만료 후 해지
            String CloseType = "일반";

            try
            {
                Response response = Global.easyFinBankService.CloseBankAccount(testCorpNum, BankCode, AccountNumber, CloseType);

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
