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
    public partial class sendFMS_one : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String receiptNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 이미지가 첨부된 1건의 친구톡 전송을 팝빌에 접수합니다.
             * - 친구톡의 경우 야간 전송은 제한됩니다. (20:00 ~ 익일 08:00)
             * - 전송실패시 사전에 지정한 변수 'altSendType' 값으로 대체문자를 전송할 수 있고, 이 경우 문자(SMS/LMS) 요금이 과금됩니다.
             * - 대체문자의 경우, 포토문자(MMS) 형식은 지원하고 있지 않습니다.
             * - https://developers.popbill.com/reference/kakaotalk/dotnet/api/send#SendFMSOne
             */

            // 팝빌회원 사업자번호
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 카카오톡 검색용 아이디, ListPlusFriendID API 의 plusFriendID 참고
            String plusFriendID = "@팝빌";

            // 팝빌에 사전 등록된 발신번호
            // ※ 대체문자를 전송하는 경우에는 사전에 등록된 발신번호 입력 필수
            String senderNum = "07043042991";

            // 친구톡 내용, 최대 400자
            String content = "친구톡 내용";

            // 수신번호
            String receiverNum = "";

            // 수신자명
            String receiverName = "수신자명";

            // 대체문자 제목
            String altSubject = "대체문자 제목";

            // 대체문자 유형(altSendType)이 "A"일 경우, 대체문자로 전송할 내용 (최대 2000byte)
            // └ 팝빌이 메시지 길이에 따라 단문(90byte 이하) 또는 장문(90byte 초과)으로 전송처리
            String altContent = "대체문자 내용";

            // 대체문자 유형 (null , "C" , "A" 중 택 1)
            // null = 미전송, C = 알림톡과 동일 내용 전송 , A = 대체문자 내용(altContent)에 입력한 내용 전송
            String altSendType = "C";

            // 광고성 메시지 여부 ( true , false 중 택 1)
            // └ true = 광고 , false = 일반
            // - 미입력 시 기본값 false 처리
            Boolean adsYN = false;

            // 전송요청번호
            // 팝빌이 접수 단위를 식별할 수 있도록 파트너가 할당한 식별번호.
            // 1~36자리로 구성. 영문, 숫자, 하이픈(-), 언더바(_)를 조합하여 팝빌 회원별로 중복되지 않도록 할당.
            String requestNum = "";

            // 첨부이미지 파일 경로
            // 이미지 파일 규격: 전송 포맷 – JPG 파일 (.jpg, .jpeg), 용량 – 최대 500 Kbyte, 크기 – 가로 500px 이상, 가로 기준으로 세로 0.5~1.3배 비율 가능
            String filePath = "C:/popbill.example.aspdotnet/PopbillExample/test03.jpg";

            // 이미지 링크 URL
            // └ 수신자가 친구톡 상단 이미지 클릭시 호출되는 URL
            // 미입력시 첨부된 이미지를 링크 기능 없이 표시
            String imageURL = "https://www.popbill.com";

            // 예약전송일시(yyyyMMddHHmmss), null인 경우 즉시전송
            String reserveDTStr = "";

            DateTime? reserveDT = null;
            if (reserveDTStr != null && reserveDTStr != "")
            {
                reserveDT = DateTime.ParseExact(reserveDTStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
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
                receiptNum = Global.kakaoService.SendFMS(testCorpNum, plusFriendID, senderNum, content, altSubject, altContent, altSendType, receiverNum,
                    receiverName, adsYN, reserveDT, buttons, filePath, imageURL, testUserID, requestNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
