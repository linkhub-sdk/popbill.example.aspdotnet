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

namespace Popbill.Fax.Example
{
    public partial class sendFAX_Multi : System.Web.UI.Page
    {
        public String code;
        public String message;
        public string receiptNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 동일한 팩스파일을 다수의 수신자에게 전송하기 위해 팝빌에 접수합니다. (최대 전송파일 개수 : 20개) (최대 1,000건)
             * - 팩스전송 문서 파일포맷 안내 : https://docs.popbill.com/fax/format?lang=java
             * - https://docs.popbill.com/fax/dotnet/api#SendFAX_Same
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 발신번호
            String senderNum = "07043042991";

            // 수신자정보 배열 (최대 1000건)
            List<FaxReceiver> receivers = new List<FaxReceiver>();

            for (int i = 0; i < 10; i++)
            {
                FaxReceiver receiver = new FaxReceiver();

                // 수신번호
                receiver.receiveNum = "111-2222-3333";

                // 수신자명
                receiver.receiveName = "수신자명칭_" + i;
                receivers.Add(receiver);
            }

            // 팩스전송 파일경로, 전송파일 최대 20개 
            List<String> filePath = new List<String>();
            filePath.Add("C:/popbill.example.aspdotnet/PopbillExample/test.jpg");
            filePath.Add("C:/popbill.example.aspdotnet/PopbillExample/test03.jpg");

            // 예약전송일시(yyyyMMddHHmmss), null인 경우 즉시전송
            String reserveDTStr = "";

            DateTime? reserveDT = null;

            if (reserveDTStr != null && reserveDTStr != "")
            {
                reserveDT = DateTime.ParseExact(reserveDTStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
            }

            // 광고팩스 전송여부
            bool adsYN = false;

            // 팩스제목
            String title = "팩스전송 제목";


            // 전송요청번호, 파트너가 전송요청에 대한 관리번호를 직접 할당하여 관리하는 경우 기재
            // 최대 36자리, 영문, 숫자, 언더바('_'), 하이픈('-')을 조합하여 사업자별로 중복되지 않도록 구성
            String requestNum = "";

            try
            {
                receiptNum = Global.faxService.SendFAX(testCorpNum, senderNum, receivers, filePath, reserveDT, testUserID, adsYN, title, requestNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
