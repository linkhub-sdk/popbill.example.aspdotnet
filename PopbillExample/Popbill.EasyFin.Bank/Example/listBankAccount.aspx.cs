using System;
using System.Collections;
using System.Collections.Generic;
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
    public partial class listBankAccount : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<EasyFinBankAccount> bankAccountList;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌에 등록된 은행계좌 목록을 반환한다.
             * - https://docs.popbill.com/easyfinbank/dotnet/api#ListBankAccount
             */


            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                bankAccountList = Global.easyFinBankService.ListBankAccount(testCorpNum, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
