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
    public partial class updateBankAccount : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * 팝빌에 등록된 계좌정보를 수정합니다.
             * - https://developers.popbill.com/reference/easyfinbank/dotnet/api/manage#UpdateBankAccount
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            EasyFinBankAccountForm info = new EasyFinBankAccountForm();

            // 기관코드
            // 산업은행-0002 / 기업은행-0003 / 국민은행-0004 /수협은행-0007 / 농협은행-0011 / 우리은행-0020
            // SC은행-0023 / 대구은행-0031 / 부산은행-0032 / 광주은행-0034 / 제주은행-0035 / 전북은행-0037
            // 경남은행-0039 / 새마을금고-0045 / 신협은행-0048 / 우체국-0071 / KEB하나은행-0081 / 신한은행-0088 /씨티은행-0027
            info.BankCode = "";

            // 계좌번호, 하이픈('-') 제외
            info.AccountNumber = "";

            // 계좌비밀번호
            info.AccountPWD = "";

            // 계좌 별칭
            info.AccountName = "";

            // 인터넷뱅킹 아이디 (국민은행 필수)
            info.BankID = "";

            // 조회전용 계정 아이디 (대구은행, 신협, 신한은행 필수)
            info.FastID = "";

            // 조회전용 계정 비밀번호 (대구은행, 신협, 신한은행 필수)
            info.FastPWD = "";

            // 메모
            info.Memo = "";

            try
            {
                Response response = Global.easyFinBankService.UpdateBankAccount(testCorpNum, info);

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
