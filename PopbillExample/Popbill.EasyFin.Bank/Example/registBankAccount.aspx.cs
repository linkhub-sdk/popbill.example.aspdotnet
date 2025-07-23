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
    public partial class registBankAccount : System.Web.UI.Page
    {

        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 계좌조회 서비스를 이용할 계좌를 팝빌에 등록합니다.
             * - https://developers.popbill.com/reference/easyfinbank/dotnet/api/manage#RegistBankAccount
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            EasyFinBankAccountForm info = new EasyFinBankAccountForm();

            // 기관코드
            info.BankCode = "";

            // 계좌번호, 하이픈('-') 제외
            info.AccountNumber = "";

            // 계좌비밀번호
            info.AccountPWD = "";

            // 계좌유형, "법인" 또는 "개인" 입력
            info.AccountType = "";

            // 예금주 식별정보 (‘-‘ 제외)
            // 계좌유형이 “법인”인 경우 : 사업자번호(10자리)
            // 계좌유형이 “개인”인 경우 : 예금주 생년월일 (6자리-YYMMDD)
            info.IdentityNumber = "";

            // 계좌 별칭
            info.AccountName = "";

            // 인터넷뱅킹 아이디 (국민은행 필수)
            info.BankID = "";

            // 조회전용 계정 아이디 (대구은행, 신협, 신한은행 필수)
            info.FastID = "";

            // 조회전용 계정 비밀번호 (대구은행, 신협, 신한은행 필수)
            info.FastPWD = "";

            // 결제기간(개월), 1~12 입력가능, 미기재시 기본값(1) 처리
            // - 파트너 과금방식의 경우 입력값에 관계없이 1개월 처리
            info.UsePeriod = "";

            // 메모
            info.Memo = "";

            try
            {
                Response response = Global.easyFinBankService.RegistBankAccount(testCorpNum, info);

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
