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
    public partial class sendFTS_multi : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String receiptNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 텍스트로 구성된 다수건의 친구톡 전송을 팝빌에 접수하며, 수신자 별로 개별 내용을 전송합니다. (최대 1,000건)
             * - 친구톡의 경우 야간 전송은 제한됩니다. (20:00 ~ 익일 08:00)
             * - 전송실패시 사전에 지정한 변수 'altSendType' 값으로 대체문자를 전송할 수 있고, 이 경우 문자(SMS/LMS) 요금이 과금됩니다.
             * - https://developers.popbill.com/reference/kakaotalk/dotnet/api/send#SendFTSMulti
             */

            // 팝빌회원 사업자번호
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 카카오톡 검색용 아이디, ListPlusFriendID API 의 plusFriendID 참고
            String plusFriendID = "@팝빌";

            // 팝빌에 사전 등록된 발신번호
            String senderNum = "";

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
                receiverInfo.rcv = "" + i;                        // 수신번호
                receiverInfo.rcvnm = "수신자명" + i.ToString();           // 수신자명
                receiverInfo.msg = "개별 친구톡 내용" + i.ToString();     // 친구톡 내용 (최대 400자)
                receiverInfo.altsjt = "대체문자 제목" + i.ToString();     // 대체문자 제목
                receiverInfo.altmsg = "대체문자 전송내용" + i.ToString(); // 대체문자 내용 (최대 2000byte)
                receiverInfo.interOPRefKey = "20220525-" + i.ToString();  // 파트너 지정키, 대량전송시, 수신자 구별용 메모

                // 수신자별 개별 버튼내용 전송하는 경우
                // 생성 가능 개수 최대 5개
                /*
                // 수신자별 개별 버튼정보 리스트 생성
                List<KakaoButton> btns = new List<KakaoButton>();

                // 개별 버튼정보 생성
                KakaoButton btnInfo1 = new KakaoButton();
                btnInfo1.n = "템플릿 안내";                              // 버튼명
                btnInfo1.t = "WL";                                       // 버튼유형 DS(-배송조회 / WL - 웹링크 / AL - 앱링크 / MD - 메시지전달 / BK - 봇키워드)
                btnInfo1.u1 = "https://www.popbill.com";                 // 버튼링크1 [앱링크] Android / [웹링크] Mobile
                btnInfo1.u2 = "http://test.popbill.com" + i.ToString();  // 버튼링크2 [앱링크] IOS / [웹링크] PC URL
                btns.Add(btnInfo1);                                      // 개별 버튼정보 리스트에 개별 버튼정보 추가

                // 개별 버튼정보 생성
                KakaoButton btnInfo2 = new KakaoButton();
                btnInfo2.n = "템플릿 안내";                              // 버튼명
                btnInfo2.t = "WL";                                       // 버튼유형 DS(-배송조회 / WL - 웹링크 / AL - 앱링크 / MD - 메시지전달 / BK - 봇키워드)
                btnInfo2.u1 = "https://www.test.com";                    // 버튼링크1 [앱링크] Android / [웹링크] Mobile
                btnInfo2.u2 = "http://test.test.com" + i.ToString();     // 버튼링크2 [앱링크] IOS / [웹링크] PC URL
                btns.Add(btnInfo2);                                      // 개별 버튼정보 리스트에 개별 버튼정보 추가

                // 수신자 정보에 개별 버튼정보 리스트 추가
                receiverInfo.btns = btns;
                */
                receivers.Add(receiverInfo);
            }

            // 버튼정보를 전송하지 않는 경우, null처리
            // 개별 버튼정보 전송하는 경우, null처리
            // List<KakaoButton> buttons = null;

            // 동일 버튼정보, 수신자별 동일 버튼정보 전송하는 경우
            List<KakaoButton> buttons = new List<KakaoButton>();
            // 생성 가능 개수 최대 5개
            KakaoButton btnInfo = new KakaoButton();
            btnInfo.n = "버튼이름";                     // 버튼명
            btnInfo.t = "WL";                           // 버튼유형 DS(-배송조회 / WL - 웹링크 / AL - 앱링크 / MD - 메시지전달 / BK - 봇키워드)
            btnInfo.u1 = "http://www.popbill.com";      // 버튼링크1 [앱링크] Android / [웹링크] Mobile
            btnInfo.u2 = "http://test.popbill.com";     // 버튼링크2 [앱링크] IOS / [웹링크] PC URL
            buttons.Add(btnInfo);

            try
            {
                receiptNum = Global.kakaoService.SendFTS(testCorpNum, plusFriendID, senderNum, altSendType, adsYN, reserveDT, receivers, buttons, testUserID, requestNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
