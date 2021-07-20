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

namespace Popbill.Cashbill.Example
{
    public partial class revokeRegistIssue : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 1건의 취소현금영수증을 [즉시발행]합니다.
             * - 현금영수증 국세청 전송 정책 : https://docs.popbill.com/cashbill/ntsSendPolicy?lang=dotnet
             * - https://docs.popbill.com/cashbill/dotnet/api#RevokeRegistIssue
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // [필수] 문서번호, 사업자별로 중복되지 않도록 문서번호 할당
            // 1~24자리 영문,숫자,'-','_' 조합 구성
            String mgtKey = "20201027-101";

            // 원본현금영수증 승인번호, 문서정보 확인(GetInfo API)로 확인가능
            String orgConfirmNum = "548757045";

            // 원본현금영수증 거래일자, 문서정보 확인(GetInfo API)로 확인가능
            String orgTradeDate = "20201027";

            try
            {
                Response response = Global.cashbillService.RevokeRegistIssue(testCorpNum, mgtKey, orgConfirmNum, orgTradeDate);

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
