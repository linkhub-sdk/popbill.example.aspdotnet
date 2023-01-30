using System;
using System.Collections;
using System.Collections.Generic;
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
    public partial class sendMMS_Multi : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String receiptNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 최대 2,000byte의 메시지와 이미지로 구성된 포토문자(MMS) 다수건 전송을 팝빌에 접수합니다. (최대 1,000건)
             * - 모든 수신자에게 동일한 내용을 전송하거나(동보전송), 수신자마다 개별 내용을 전송할 수 있습니다(대량전송).
             * - 이미지 파일 포맷/규격 : 최대 300Kbyte(JPEG), 가로/세로 1,000px 이하 권장
             *  - https://developers.popbill.com/reference/sms/dotnet/api/send#SendMMSSame
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 발신번호
            String senderNum = "";

            // 메시지 제목
            String subject = "동보메시지 제목";

            // 메시지 내용, 포토(MMS) 메시지는 2000byte초과된 내용은 삭제되어 전송됨.
            String contents = "동보 문자 메시지 내용, 최대 2000byte";

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

            // 수신자 정보 배열 (최대 1000건)
            List<Message> messages = new List<Message>();

            for (int i = 0; i < 10; i++)
            {
                Message msg = new Message();

                // 수신번호
                msg.receiveNum = "010111222";

                // 수신자명
                msg.receiveName = "수신자명칭_" + i;

                // 파트너 지정키, 대량전송시, 수신자 구별용 메모
                msg.interOPRefKey = "20220525-" + i;

                messages.Add(msg);
            }

            try
            {
                receiptNum = Global.messageService.SendMMS(testCorpNum, senderNum, subject,
                                        contents, messages, filePath, reserveDT, testUserID, requestNum, adsYN);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
