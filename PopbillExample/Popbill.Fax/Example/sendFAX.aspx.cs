using System;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Popbill.Fax.Example
{
    public partial class sendFAX : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String receiptNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팩스 1건을 전송합니다. (최대 전송파일 개수: 20개)
             * - https://docs.popbill.com/fax/dotnet/api#SendFAX
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 발신번호
            String senderNum = "07043042991";

            // 수신번호
            String receiverNum = "070111222";

            // 수신자명 
            String receiverName = "수신자명";

            // 광고팩스 전송여부
            bool adsYN = true;

            // 팩스전송 파일경로, 전송파일 최대 20개 
            List<String> filePath = new List<String>();
            filePath.Add("C:/popbill.example.aspdotnet/PopbillExample/test.jpg");
            filePath.Add("C:/popbill.example.aspdotnet/PopbillExample/test03.jpg");

            // 전송요청번호, 파트너가 전송요청에 대한 관리번호를 직접 할당하여 관리하는 경우 기재
            // 최대 36자리, 영문, 숫자, 언더바('_'), 하이픈('-')을 조합하여 사업자별로 중복되지 않도록 구성
            String requestNum = "";

            // 예약전송일시(yyyyMMddHHmmss), null인 경우 즉시전송
            String reserveDTStr = "";

            DateTime? reserveDT = null;

            if (reserveDTStr != null && reserveDTStr != "")
            {
                reserveDT = DateTime.ParseExact(reserveDTStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
            }

            // 팩스제목
            String title = "팩스전송 제목";

            try
            {
                receiptNum = Global.faxService.SendFAX(testCorpNum, senderNum, receiverNum, receiverName, filePath, reserveDT, testUserID, adsYN, title, requestNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
