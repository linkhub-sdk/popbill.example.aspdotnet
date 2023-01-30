using System;
using System.Collections;
using System.Collections.Generic ;
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
    public partial class listATSTemplate : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<ATSTemplate> templateList;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 승인된 알림톡 템플릿 목록을 확인합니다.
             * - https://developers.popbill.com/reference/kakaotalk/dotnet/api/template#ListATSTemplate
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            try
            {
                templateList = Global.kakaoService.ListATSTemplate(testCorpNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
