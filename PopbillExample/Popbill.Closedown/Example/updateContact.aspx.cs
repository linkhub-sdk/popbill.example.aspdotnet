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

namespace Popbill.Closedown.Example
{
    public partial class updateContact : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 연동회원 사업자번호에 등록된 담당자(팝빌 로그인 계정) 정보를 수정합니다.
             * - https://developers.popbill.com/reference/closedown/dotnet/api/member#UpdateContact
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            Contact contactInfo = new Contact();

            // 아이디 (6자이상 50자미만)
            contactInfo.id = "testkorea";

            // 담당자 성명 (최대 100자)
            contactInfo.personName = "담당자123";

            // 담당자 연락처 (최대 20자)
            contactInfo.tel = "";

            // 담당자 이메일 (최대 100자)
            contactInfo.email = "";

            // 담당자 권한, 1 : 개인권한, 2 : 읽기권한, 3 : 회사권한
            contactInfo.searchRole = 3;

            try
            {
                Response response = Global.closedownService.UpdateContact(testCorpNum, contactInfo, testUserID);
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
