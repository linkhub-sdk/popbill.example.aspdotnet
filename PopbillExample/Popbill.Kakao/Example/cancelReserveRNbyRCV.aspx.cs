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
    public partial class cancelReserveRNbyRCV : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 파트너가 할당한 전송 요청번호로 접수 건을 식별하여 수신번호에 예약된 카카오톡을 전송 취소합니다. (예약시간 10분 전까지 가능)
             * - https://developers.popbill.com/reference/kakaotalk/dotnet/api/send#CancelReserveRNbyRCV
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 카카오톡 예약전송 접수시 파트너가 할당한 전송 요청번호
            String requestNum = "test_request_Num";

            // 카카오톡 예약전송 접수시 팝빌로 요청한 수신번호
            String receiveNum = "01012341234";

            // 팝빌회원 아이디
            String UserID = "testkorea";

            try
            {
                Response response = Global.kakaoService.CancelReserveRNbyRCV(testCorpNum, requestNum, receiveNum, UserID);

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
