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
    public partial class sendATS_same : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String receiptNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 승인된 템플릿 내용을 작성하여 다수건의 알림톡 전송을 팝빌에 접수하며, 모든 수신자에게 동일 내용을 전송합니다. (최대 1,000건)
            * - 사전에 승인된 템플릿의 내용과 알림톡 전송내용(content)이 다를 경우 전송실패 처리됩니다.
            * - 전송실패시 사전에 지정한 변수 'altSendType' 값으로 대체문자를 전송할 수 있고, 이 경우 문자(SMS/LMS) 요금이 과금됩니다.
             * - https://developers.popbill.com/reference/kakaotalk/dotnet/api/send#SendATSSame
             */

            // 팝빌회원 사업자번호
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 승인된 알림톡 템플릿코드
            // └ 알림톡 템플릿 관리 팝업 URL(GetATSTemplateMgtURL API) 함수, 알림톡 템플릿 목록 확인(ListATStemplate API) 함수를 호출하거나
            //   팝빌사이트에서 승인된 알림톡 템플릿 코드를  확인 가능.
            String templateCode = "019020000163";

            // 팝빌에 사전 등록된 발신번호
            String senderNum = "";

            // 알림톡 템플릿 내용, 최대 1000자
            String content = "[ 팝빌 ]\n";
            content += "신청하신 #{템플릿코드}에 대한 심사가 완료되어 승인 처리되었습니다.\n";
            content += "해당 템플릿으로 전송 가능합니다.\n\n";
            content += "문의사항 있으시면 파트너센터로 편하게 연락주시기 바랍니다.\n\n";
            content += "팝빌 파트너센터 : 1600-8536\n";
            content += "support@linkhub.co.kr".Replace("\n", Environment.NewLine);

            // 대체문자 제목
            String altSubject = "대체문자 제목";

            // 대체문자 유형(altSendType)이 "A"일 경우, 대체문자로 전송할 내용 (최대 2000byte)
            // └ 팝빌이 메시지 길이에 따라 단문(90byte 이하) 또는 장문(90byte 초과)으로 전송처리
            String altContent = "대체문자 메시지 내용";

            // 대체문자 유형 (null , "C" , "A" 중 택 1)
            // null = 미전송, C = 알림톡과 동일 내용 전송 , A = 대체문자 내용(altContent)에 입력한 내용 전송
            String altSendType = "A";

            // 수신자정보 배열, 최대 1000건
            List<KakaoReceiver> receivers = new List<KakaoReceiver>();
            for (int i = 0; i < 5; i++)
            {
                KakaoReceiver receiverInfo = new KakaoReceiver();

                // 수신번호
                receiverInfo.rcv = ""+i;

                // 수신자명
                receiverInfo.rcvnm = "수신자명"+i;

                // 파트너 지정키, 수신자 구별용 메모
                receiverInfo.interOPRefKey = "20220525-" + i;

                receivers.Add(receiverInfo);
            }

            // 전송요청번호
            // 팝빌이 접수 단위를 식별할 수 있도록 파트너가 할당한 식별번호.
            // 1~36자리로 구성. 영문, 숫자, 하이픈(-), 언더바(_)를 조합하여 팝빌 회원별로 중복되지 않도록 할당.
            String requestNum = "";

            // 예약전송일시(yyyyMMddHHmmss), null인 경우 즉시전송
            String reserveDTStr = "";

            DateTime? reserveDT = null;
            if (reserveDTStr != null && reserveDTStr != "")
            {
                reserveDT = DateTime.ParseExact(reserveDTStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
            }

            // 버튼정보를 수정하지 않고 템플릿 신청시 기재한 정보로 전송하는 경우 null 처리
            List<KakaoButton> buttons = null;


            // 버튼링크 URL 에 #{템플릿변수}를 기재하여 승인받은경우 URL 수정하여 전송
            /*
            List<KakaoButton> buttons = new List<KakaoButton>();

            KakaoButton btnInfo = new KakaoButton();
            // 버튼명
            btnInfo.n = "템플릿 안내";
            // 버튼유형 DS(-배송조회 / WL - 웹링크 / AL - 앱링크 / MD - 메시지전달 / BK - 봇키워드)
            btnInfo.t = "WL";
            // 버튼링크1 [앱링크] iOS / [웹링크] Mobile
            btnInfo.u1 = "https://www.popbill.com";
            // 버튼링크2 [앱링크] Android / [웹링크] PC URL
            btnInfo.u2 = "http://test.popbill.com";
            buttons.Add(btnInfo);
            */

            try
            {
                receiptNum = Global.kakaoService.SendATS(testCorpNum, templateCode, senderNum, content,
                    altSubject, altContent, altSendType, reserveDT, receivers, testUserID, requestNum, buttons);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
