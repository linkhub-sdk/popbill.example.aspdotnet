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
    public partial class cancelReserve : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 카카오톡 전송요청시 발급받은 접수번호(receiptNum)로 예약전송건을 취소합니다.
             * - 예약취소는 예약전송시간 10분전까지만 가능합니다.
             * - https://docs.popbill.com/kakao/dotnet/api#CancelReserve
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 카카오톡 전송 요청시 발급받은 접수번호
            String receiptNum = "018031311564800001";

            try
            {
                Response response = Global.kakaoService.CancelReserve(testCorpNum, receiptNum, testUserID);

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