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
             * 최대 2,000byte의 메시지와 이미지로 구성된 포토문자(MMS) 1건 전송을 팝빌에 접수합니다.
             * - 이미지 파일의 크기는 최대 300Kbtye (JPEG), 가로/세로 1000px 이하 권장
             * - https://developers.popbill.com/reference/sms/dotnet/api/send#SendMMSOne
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 발신번호
            String senderNum = "";

            // 발신자명
            String senderName = "";

            // 수신번호
            String receiver = "";

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

            // 전송요청번호
            // 팝빌이 접수 단위를 식별할 수 있도록 파트너가 할당한 식별번호.
            // 1~36자리로 구성. 영문, 숫자, 하이픈(-), 언더바(_)를 조합하여 팝빌 회원별로 중복되지 않도록 할당.
            String requestNum = "";

            // 광고성 메시지 여부 ( true , false 중 택 1)
            // └ true = 광고 , false = 일반
            Boolean adsYN = false;

            DateTime? reserveDT = null;

            if (reserveDTStr != null && reserveDTStr != "")
            {
                reserveDT = DateTime.ParseExact(reserveDTStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
            }

            try
            {
                receiptNum = Global.messageService.SendMMS(testCorpNum, senderNum, senderName, receiver, receiverName,
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
