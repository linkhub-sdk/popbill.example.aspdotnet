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
    public partial class getURL : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String url;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 팝빌 전자명세서 문서함 관련 팝업 URL을 반환합니다.
            * TOGO - TBOX(임시문서함), SBOX(발행문서함)
            * 반환된 URL은 보안정책에 따라 30초의 유효시간을 갖습니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 임시문서함(TBOX), 발행문서함(SBOX)
            String TOGO = "TBOX";

            try
            {
                url = Global.statementService.GetURL(testCorpNum, testUserID, TOGO);

            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
