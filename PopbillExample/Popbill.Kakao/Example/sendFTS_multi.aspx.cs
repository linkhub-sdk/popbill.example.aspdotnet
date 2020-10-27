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
             * [대량전송] 친구톡(텍스트) 전송을 요청합니다.
             * - 친구톡은 심야 전송(20:00~08:00)이 제한됩니다.
             * - https://docs.popbill.com/kakao/dotnet/api#SendFTS_Multi
             */

            // 팝빌회원 사업자번호
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";
            
            // 플러스친구 아이디, ListPlusFriendID API 의 plusFriendID 참고
            String plusFriendID = "@팝빌";

            // 팝빌에 사전 등록된 발신번호
            String senderNum = "07043042991";

            // 대체문자 유형, 공백-미전송, C-친구톡 내용, A-대체문자 내용
            String altSendType = "C";

            // 광고전송여부
            Boolean adsYN = false;

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
                receiverInfo.rcv = "01011122" + i;                        // 수신번호
                receiverInfo.rcvnm = "수신자명" + i.ToString();           // 수신자명
                receiverInfo.msg = "개별 친구톡 내용" + i.ToString();     // 친구톡 내용 (최대 400자)
                receiverInfo.altmsg = "대체문자 전송내용" + i.ToString(); // 대체문자 내용 (최대 2000byte)
                receiverInfo.interOPRefKey = "20201027-" + i.ToString();  // 파트너 지정키, 대량전송시, 수신자 구별용 메모
                
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
