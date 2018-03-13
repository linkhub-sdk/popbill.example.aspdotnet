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
            // 팝빌회원 사업자번호
            String testCorpNum = "1234567890";

            // 알림톡 템플릿 코드, ListATSTemplate API의 templateCode 확인
            String templateCode = "018020000001";

            // 팝빌에 사전 등록된 발신번호
            String senderNum = "07043042993";

            // 대체문자 유형, 공백-미전송, C-알림톡 내용, A-대체문자 내용
            String altSendType = "A";

            // 수신자정보 배열, 최대 1000건
            List<KakaoReceiver> receivers = new List<KakaoReceiver>();
            for (int i = 0; i < 5; i++)
            {
                KakaoReceiver receiverInfo = new KakaoReceiver();

                // 수신번호
                receiverInfo.rcv = "01011122" + i;
                // 수신자명
                receiverInfo.rcvnm = "수신자명" + i;
                // 알림톡 템플릿 내용, 최대 1000자
                receiverInfo.msg = "[테스트] 테스트 템플릿입니다."+i;
                // 대체문자 내용
                receiverInfo.altmsg = "대체문자 내용입니다"+i;
                receivers.Add(receiverInfo);
            }


            // 예약전송일시(yyyyMMddHHmmss), null인 경우 즉시전송
            String reserveDTStr = "";

            DateTime? reserveDT = null;
            if (reserveDTStr != null && reserveDTStr != "")
            {
                reserveDT = DateTime.ParseExact(reserveDTStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
            }

            try
            {
                receiptNum = Global.kakaoService.SendATS(testCorpNum, templateCode, senderNum, altSendType, reserveDT, receivers);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
