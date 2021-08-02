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

namespace Popbill.Kakao.Example
{
    public partial class sendFMS_same : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String receiptNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 이미지가 첨부된 다수건의 친구톡 전송을 팝빌에 접수하며, 모든 수신자에게 동일 내용을 전송합니다. (최대 1,000건)
             * - 친구톡은 심야 전송(20:00~08:00)이 제한됩니다.
             * - 이미지 전송규격 / jpg 포맷, 용량 최대 500KByte, 이미지 높이/너비 비율 1.333 이하, 1/2 이상
             * - 전송실패시 사전에 지정한 변수 'altSendType' 값으로 대체문자를 전송할 수 있고, 이 경우 문자(SMS/LMS) 요금이 과금됩니다.
             * - https://docs.popbill.com/kakao/dotnet/api#SendFMS_Same
             */

            // 팝빌회원 사업자번호
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 카카오톡 채널 아이디, ListPlusFriendID API 의 plusFriendID 참고
            String plusFriendID = "@팝빌";

            // 팝빌에 사전 등록된 발신번호
            String senderNum = "07043042991";

            // 친구톡 내용, 최대 400자
            String content = "친구톡 내용";

            // 대체문자 내용 (최대 2000byte)
            String altContent = "대체문자 내용";

            // 대체문자 유형, 공백-미전송, C-친구톡 내용, A-대체문자 내용
            String altSendType = "C";

            // 광고전송여부
            Boolean adsYN = false;

            // 이미지 파일경로
            String filePath = "C:/popbill.example.aspdotnet/PopbillExample/test03.jpg";

            // 이미지 링크 URL
            String imageURL = "https://www.popbill.com";

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

            // 수신자정보 배열, 최대 1000건
            List<KakaoReceiver> receivers = new List<KakaoReceiver>();
            for (int i = 0; i < 5; i++)
            {
                KakaoReceiver receiverInfo = new KakaoReceiver();
                receiverInfo.rcv = "01011122"+i;
                receiverInfo.rcvnm = "수신자명" + i.ToString();
                receivers.Add(receiverInfo);
            }

            // 버튼배열, 최대 5개
            List<KakaoButton> buttons = new List<KakaoButton>();
            KakaoButton btnInfo = new KakaoButton();
            btnInfo.n = "버튼이름"; // 버튼명
            btnInfo.t = "WL"; // 버튼유형
            btnInfo.u1 = "http://www.popbill.com"; // 버튼링크1
            btnInfo.u2 = "http://test.popbill.com";// 버튼링크2
            buttons.Add(btnInfo);

            try
            {
                receiptNum = Global.kakaoService.SendFMS(testCorpNum, plusFriendID, senderNum, content,
                    altContent, altSendType, adsYN, reserveDT, receivers, buttons, filePath, imageURL, testUserID, requestNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
