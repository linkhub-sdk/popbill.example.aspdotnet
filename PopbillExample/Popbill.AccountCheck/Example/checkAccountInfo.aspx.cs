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

namespace Popbill.AccountCheck.Example
{
    public partial class checkAccountInfo : System.Web.UI.Page
    {
        public String code;
        public String message;
        public AccountCheckInfo result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 1건의 예금주성명을 조회합니다.
             * - https://developers.popbill.com/reference/accountcheck/dotnet/api/check#CheckAccountInfo
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 기관코드
            String bankCode = "";

            // 계좌번호
            String accountNumber = "";

            try
            {
                result = Global.accountCheckService.CheckAccountInfo(testCorpNum, bankCode, accountNumber);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
