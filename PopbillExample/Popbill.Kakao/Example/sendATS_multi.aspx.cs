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
    public partial class sendATS_multi : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String receiptNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 승인된 템플릿의 내용을 작성하여 다수건의 알림톡 전송을 팝빌에 접수하며, 수신자 별로 개별 내용을 전송합니다. (최대 1,000건)
             * - 사전에 승인된 템플릿의 내용과 알림톡 전송내용(content)이 다를 경우 전송실패 처리됩니다.
             * - 전송실패시 사전에 지정한 변수 'altSendType' 값으로 대체문자를 전송할 수 있고, 이 경우 문자(SMS/LMS) 요금이 과금됩니다.
             * - https://developers.popbill.com/reference/kakaotalk/dotnet/api/send#SendATSMulti
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
            // ※ 대체문자를 전송하는 경우에는 사전에 등록된 발신번호 입력 필수
            String senderNum = "";

            // 대체문자 유형 (null , "C" , "A" 중 택 1)
            // null = 미전송, C = 알림톡과 동일 내용 전송 , A = 대체문자 내용(altContent)에 입력한 내용 전송
            String altSendType = "";

            // 알림톡 내용, 최대 1000자
            // 사전에 승인받은 템플릿 내용과 다를 경우 전송실패 처리
            String content = "[ 팝빌 ]\n";
            content += "신청하신 #{템플릿코드}에 대한 심사가 완료되어 승인 처리되었습니다.\n";
            content += "해당 템플릿으로 전송 가능합니다.\n\n";
            content += "문의사항 있으시면 파트너센터로 편하게 연락주시기 바랍니다.\n\n";
            content += "팝빌 파트너센터 : 1600-8536\n";
            content += "support@linkhub.co.kr".Replace("\n", Environment.NewLine);

            // 수신자정보 배열, 최대 1000건
            List<KakaoReceiver> receivers = new List<KakaoReceiver>();
            for (int i = 0; i < 5; i++)
            {
                KakaoReceiver receiverInfo = new KakaoReceiver();

                // 수신번호
                receiverInfo.rcv = "" + i;
                // 수신자명
                receiverInfo.rcvnm = "수신자명" + i;
                // 알림톡 템플릿 내용, 최대 1000자
                receiverInfo.msg = content;
                // 대체문자 제목
                receiverInfo.altsjt = "대체문자 제목입니다" + i;
                // 대체문자 내용
                receiverInfo.altmsg = "대체문자 내용입니다"+i;
                // 파트너 지정키, 대량전송시, 수신자 구별용 메모
                receiverInfo.interOPRefKey = "20220525-" + i.ToString();

                // 수신자별 개별 버튼내용 전송하는 경우
                // 개별 버튼의 개수는 템플릿 신청 시 승인받은 버튼의 개수와 동일하게 생성, 다를경우 실패 처리
                // 버튼링크URL에 #{템플릿변수}를 기재하여 승인받은 경우 URL 수정가능
                // 버튼 표시명, 버튼 유형 수정 불가능
                /*
                // 수신자별 개별 버튼정보 리스트 생성
                List<KakaoButton> btns = new List<KakaoButton>();

                // 개별 버튼정보 생성
                KakaoButton btnInfo1 = new KakaoButton();

                // 버튼명
                btnInfo1.n = "템플릿 안내";
                // 버튼유형 DS(-배송조회 / WL - 웹링크 / AL - 앱링크 / MD - 메시지전달 / BK - 봇키워드)
                btnInfo1.t = "WL";
                // 버튼링크1 [앱링크] Android / [웹링크] Mobile
                btnInfo1.u1 = "https://www.popbill.com";
                // 버튼링크2 [앱링크] IOS / [웹링크] PC URL
                btnInfo1.u2 = "http://test.popbill.com" + i.ToString();
                // 개별 버튼정보 리스트에 개별 버튼정보 추가
                btns.Add(btnInfo1);

                // 개별 버튼정보 생성
                KakaoButton btnInfo2 = new KakaoButton();

                // 버튼명
                btnInfo2.n = "템플릿 안내";
                // 버튼유형 DS(-배송조회 / WL - 웹링크 / AL - 앱링크 / MD - 메시지전달 / BK - 봇키워드)
                btnInfo2.t = "WL";
                // 버튼링크1 [앱링크] Android / [웹링크] Mobile
                btnInfo2.u1 = "https://www.test.com";
                // 버튼링크2 [앱링크] IOS / [웹링크] PC URL
                btnInfo2.u2 = "http://test.test.com" + i.ToString();
                // 개별 버튼정보 리스트에 개별 버튼정보 추가
                btns.Add(btnInfo2);
                // 수신자 정보에 개별 버튼정보 리스트 추가
                receiverInfo.btns = btns;
                */
                receivers.Add(receiverInfo);
            }

            // 예약전송일시(yyyyMMddHHmmss), null인 경우 즉시전송
            String reserveDTStr = "";

            // 전송요청번호
            // 팝빌이 접수 단위를 식별할 수 있도록 파트너가 할당한 식별번호.
            // 1~36자리로 구성. 영문, 숫자, 하이픈(-), 언더바(_)를 조합하여 팝빌 회원별로 중복되지 않도록 할당.
            String requestNum = "";

            DateTime? reserveDT = null;
            if (reserveDTStr != null && reserveDTStr != "")
            {
                reserveDT = DateTime.ParseExact(reserveDTStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
            }


            // 버튼정보를 수정하지 않고 템플릿 신청시 기재한 정보로 전송하는 경우 null 처리
            // 개별 버튼정보 전송하는 경우 null 처리
            List<KakaoButton> buttons = null;


            // 동일 버튼정보, 수신자별 동일 버튼내용 전송하는 경우
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
                receiptNum = Global.kakaoService.SendATS(testCorpNum, templateCode,
                    senderNum, altSendType, reserveDT, receivers, testUserID, requestNum, buttons);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
