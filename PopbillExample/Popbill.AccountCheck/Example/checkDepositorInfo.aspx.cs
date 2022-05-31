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
    public partial class checkDepositorInfo : System.Web.UI.Page
    {
        public String code;
        public String message;
        public DepositorCheckInfo result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 1건의 예금주성명을 조회합니다.
             * - https://docs.popbill.com/accountcheck/dotnet/api#CheckDepositorInfo
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 기관코드
            String bankCode = "";

            // 계좌번호
            String accountNumber = "";

            // 등록번호 유형, P-개인, B-사업자
            String identityNumType = "P";

            // 등록번호
            // └ 등록번호 유형 값이 "B"인 경우 사업자번호(10 자리)입력 ('-' 제외)
            // └ 등록번호 유형 값이 "P"인 경우 생년월일(6 자리)입력 (형식 : YYMMDD)
            String identityNum = "";

            try
            {
                result = Global.accountCheckService.CheckDepositorInfo(testCorpNum, bankCode, accountNumber, identityNumType, identityNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
