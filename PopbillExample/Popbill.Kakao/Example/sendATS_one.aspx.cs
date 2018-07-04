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

namespace Popbill.Kakao.Example
{
    public partial class sendATS_one : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String receiptNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            // 팝빌회원 사업자번호
            String testCorpNum = "1234567890";

            // 알림톡 템플릿 코드, ListATSTemplate API의 templateCode 확인
            String templateCode = "018030000066";

            // 팝빌에 사전 등록된 발신번호
            String senderNum = "07043042991";

            // 알림톡 템플릿 내용, 최대 1000자
            String content = "[테스트] 테스트 템플릿입니다.";

            // 대체문자 메시지 내용 
            String altContent = "대체문자 메시지 내용";
            
            // 대체문자 유형, 공백-미전송, C-알림톡 내용, A-대체문자 내용
            String altSendType = "A";

            // 수신번호
            String receiverNum = "010111222";

            // 수신자명
            String receiverName = "수신자명";

            // 예약전송일시(yyyyMMddHHmmss), null인 경우 즉시전송
            String reserveDTStr = "";

            // 전송요청번호, 파트너가 전송요청에 대한 관리번호를 직접 할당하여 관리하는 경우 기재
            // 최대 36자리, 영문, 숫자, 언더바('_'), 하이픈('-')을 조합하여 사업자별로 중복되지 않도록 구성
            String requestNum = "";

            DateTime? reserveDT = null;
            if (reserveDTStr != null && reserveDTStr != "")
            {
                reserveDT = DateTime.ParseExact(reserveDTStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
            }

            try
            {
                receiptNum = Global.kakaoService.SendATS(testCorpNum, templateCode, senderNum, altSendType, reserveDT,
                    receiverNum, receiverName, content, altContent, requestNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
