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
    public partial class getMessages : System.Web.UI.Page
    {
        public String code;
        public String message;
        public KakaoSentResult sentResult;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌에서 반환받은 접수번호를 통해 알림톡/친구톡 전송상태 및 결과를 확인합니다.
             * - https://docs.popbill.com/kakao/dotnet/api#GetMessages
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 카카오톡 전송 요청시 발급받은 접수번호
            String receiptNum = "021080618024000001";

            try
            {
                sentResult = Global.kakaoService.GetMessages(testCorpNum, receiptNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
