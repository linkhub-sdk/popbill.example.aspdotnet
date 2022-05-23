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

namespace Popbill.Taxinvoice.Example
{
    public partial class getSendToNTSConfig : System.Web.UI.Page
    {
        public String code = null;
        public String message =null;
        public bool? sendToNTSConfig = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * 연동회원의 국세청 전송 옵션 설정 상태를 확인합니다.
             * - 팝빌 국세청 전송 정책 [https://docs.popbill.com/taxinvoice/ntsSendPolicy?lang=dotnet]
             * - 국세청 전송 옵션 설정은 팝빌 사이트 [전자세금계산서] > [환경설정] > [세금계산서 관리] 메뉴에서 설정할 수 있으며, API로 설정은 불가능 합니다.
             * - https://docs.popbill.com/taxinvoice/dotnet/api#GetSendToNTSConfig
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                sendToNTSConfig = Global.taxinvoiceService.GetSendToNTSConfig(testCorpNum, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
