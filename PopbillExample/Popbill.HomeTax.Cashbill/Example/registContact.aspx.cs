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

namespace Popbill.HomeTax.Cashbill.Example
{
    public partial class registContact : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 연동회원 사업자번호에 담당자(팝빌 로그인 계정)를 추가합니다.
             * - https://docs.popbill.com/htcashbill/dotnet/api#RegistContact
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            Contact contactInfo = new Contact();

            // 담당자 아이디, 6자 이상 50자 미만
            contactInfo.id = "testkorea";
            
            // 담당자 비밀번호, 8자 이상 20자 이하(영문, 숫자, 특수문자 조합)
            contactInfo.Password = "asdf8536!@#";
            
            // 담당자 성명 (최대 100자)
            contactInfo.personName = "담당자명";
            
            // 담당자 연락처 (최대 20자)
            contactInfo.tel = "070-4304-2992";
            
            // 담당자 휴대폰번호 (최대 20자)
            contactInfo.hp = "010-222-111";
            
            // 담당자 팩스 (최대 20자)
            contactInfo.fax = "02-222-1110";
            
            // 담당자 이메일 (최대 100자)
            contactInfo.email = "aspnetcore@popbill.co.kr";
            
            // 담당자 권한, 1 : 개인권한, 2 : 읽기권한, 3 : 회사권한
            contactInfo.searchRole = 3;

            try
            {
                Response response = Global.htCashbillService.RegistContact(testCorpNum, contactInfo, testUserID);
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
