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
    public partial class getPopbillURL_CHRG : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public String url = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 연동회원 포인트충전 팝업 URL을 반환합니다.
            * - 반환된 URL은 보안정책에 따라 30초의 유효시간을 갖습니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // [CHRG] : 포인트충전 URL
            String TOGO = "CHRG";

            try
            {
                url = Global.kakaoService.GetPopbillURL(testCorpNum, testUserID, TOGO);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
