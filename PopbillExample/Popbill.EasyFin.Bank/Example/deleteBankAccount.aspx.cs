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
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * 등록된 계좌를 삭제합니다.
             * - 정액제가 아닌 종량제 이용 시에만 등록된 계좌를 삭제할 수 있습니다.
             * - https://docs.popbill.com/easyfinbank/dotnet/api#DeleteBankAccount
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // [필수] 은행코드
            // 산업은행-0002 / 기업은행-0003 / 국민은행-0004 /수협은행-0007 / 농협은행-0011 / 우리은행-0020
            // SC은행-0023 / 대구은행-0031 / 부산은행-0032 / 광주은행-0034 / 제주은행-0035 / 전북은행-0037
            // 경남은행-0039 / 새마을금고-0045 / 신협은행-0048 / 우체국-0071 / KEB하나은행-0081 / 신한은행-0088 /씨티은행-0027
            String BankCode = "";

            // [필수] 계좌번호, 하이픈('-') 제외
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
