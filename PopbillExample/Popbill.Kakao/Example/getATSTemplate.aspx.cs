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

namespace Popbill.Kakao.Example
{
    public partial class getATSTemplate : System.Web.UI.Page
    {
        public String code;
        public String message;
        public ATSTemplate templateInfo;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 승인된 알림톡 템플릿 정보를 확인합니다.
             * - https://developers.popbill.com/reference/kakaotalk/dotnet/api/template#GetATSTemplate
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 확인할 템플릿 코드
            String templateCode = "021010000076";

            try
            {
                templateInfo = Global.kakaoService.GetATSTemplate(testCorpNum, templateCode);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
