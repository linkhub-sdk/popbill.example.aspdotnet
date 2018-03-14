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
    public partial class getUnitCost : System.Web.UI.Page
    {
        public String code;
        public String message;
        public float unitCost;


        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 카카오톡 전송단가를 확인합니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 카카오톡 전송유형 ATS(알림톡), FTS(친구톡 텍스트), FMS(친구톡 이미지)
            KakaoType kType = KakaoType.ATS;

            try
            {
                unitCost = Global.kakaoService.GetUnitCost(testCorpNum, kType);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
