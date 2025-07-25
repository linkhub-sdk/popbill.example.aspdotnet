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

namespace Popbill.Statement.Example
{
    public partial class issue : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * "임시저장" 상태의 전자명세서를 발행하여, "발행완료" 상태로 처리합니다.
             * - https://developers.popbill.com/reference/statement/dotnet/api/issue#Issue
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String CorpNum = "1234567890";

            // 팝빌회원 아이디
            String UserID = "testkorea";

            // 명세서 종류 코드 - 121(거래명세서), 122(청구서), 123(견적서), 124(발주서), 125(입금표), 126(영수증)
            int itemCode = 121;

            // 전자명세서 문서번호
            String mgtKey = "20220525-001";

            //메모
            String memo = "발행 메모";

            // 전자명세서 발행 안내메일 제목
            String EmailSubject = "발행 안내메일";

            try
            {
                Response response =
                    Global.statementService.Issue(CorpNum, itemCode, mgtKey, memo, EmailSubject, UserID);

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