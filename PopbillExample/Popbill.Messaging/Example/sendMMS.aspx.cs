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

namespace Popbill.Message.Example
{
    public partial class sendMMS : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String receiptNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * MMS(포토)를 전송합니다.
             *  - 메시지 내용이 2,000Byte 초과시 메시지 내용은 자동으로 제거됩니다.
             *  - 이미지 파일의 크기는 최대 300Kbtye (JPEG), 가로/세로 1500px 이하 권장
             *  - https://docs.popbill.com/message/dotnet/api#SendMMS
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 발신번호
            String senderNum = "070-4304-2991";

            // 수신번호 
            String receiver = "010111222";

            // 수신자명
            String receiverName = "수신자명";

            // 메시지 제목
            String subject = "포토 메시지 제목";

            // 메시지 내용, 포토(MMS) 메시지는 2000byte초과된 내용은 삭제되어 전송됨. 
            String contents = "포토 문자 메시지 내용. 최대길이 2000byte";

            // 포토 메시지 파일경로, JPG 파일포맷, 300KByte 이하 전송 가능
            String filePath = "C:/popbill.example.aspdotnet/PopbillExample/test.jpg";

            // 예약전송일시(yyyyMMddHHmmss), null인 경우 즉시전송
            String reserveDTStr = "";

            // 전송요청번호, 파트너가 전송요청에 대한 관리번호를 직접 할당하여 관리하는 경우 기재
            // 최대 36자리, 영문, 숫자, 언더바('_'), 하이픈('-')을 조합하여 사업자별로 중복되지 않도록 구성
            String requestNum = "";

            // 광고문자 여부 (기본값 false)
            Boolean adsYN = false;

            DateTime? reserveDT = null;

            if (reserveDTStr != null && reserveDTStr != "")
            {
                reserveDT = DateTime.ParseExact(reserveDTStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
            }

            try
            {
               receiptNum = Global.messageService.SendMMS(testCorpNum, senderNum, receiver, receiverName,
                                                    subject, contents, filePath, reserveDT, testUserID, requestNum, adsYN);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
