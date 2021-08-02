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

namespace Popbill.HomeTax.Taxinvoice.Example
{
    public partial class joinMember : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 사용자를 연동회원으로 가입처리합니다.
             * - https://docs.popbill.com/httaxinvoice/dotnet/api#JoinMember
             */

            JoinForm joinInfo = new JoinForm();

            //아이디, 6자이상 50자 미만
            joinInfo.ID = "userid";

            //비밀번호, 6자이상 20자 미만
            joinInfo.PWD = "pwd_must_be_long_enough";

            //링크아이디
            joinInfo.LinkID = "TESTER";

            //사업자번호 "-" 제외
            joinInfo.CorpNum = "1231212312";

            //대표자명 (최대 100자)
            joinInfo.CEOName = "대표자성명";

            //상호 (최대 200자)
            joinInfo.CorpName = "상호";

            //사업장 주소 (최대 300자)
            joinInfo.Addr = "주소";

            //업태 (최대 100자)
            joinInfo.BizType = "업태";

            //종목 (최대 100자)
            joinInfo.BizClass = "종목";

            //담당자 성명 (최대 100자)
            joinInfo.ContactName = "담당자명";

            //담당자 이메일 (최대 20자)
            joinInfo.ContactEmail = "test@test.com";

            //담당자 연락처 (최대 20자)
            joinInfo.ContactTEL = "070-4304-2991";

            //담당자 휴대폰번호 (최대 20자)
            joinInfo.ContactHP = "010-111-222";

            //담당자 팩스번호 (최대 20자)
            joinInfo.ContactFAX = "02-6442-9700";

            try
            {
                Response response = Global.htTaxinvoiceService.JoinMember(joinInfo);

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
