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
    public partial class getMessagesRN : System.Web.UI.Page
    {
        public String code;
        public String message;
        public KakaoSentResult sentResult;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 전송요청번호(requestNum)를 할당한 알림톡/친구톡 전송내역 및 전송상태를 확인합니다.
             * - https://docs.popbill.com/kakao/dotnet/api#GetMessagesRN
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 카카오톡 전송시 기재한 요청번호
            String requestNum = "20190114-001";

            try
            {
                sentResult = Global.kakaoService.GetMessagesRN(testCorpNum, requestNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
