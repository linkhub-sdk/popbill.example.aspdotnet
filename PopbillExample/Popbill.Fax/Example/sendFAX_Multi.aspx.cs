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
             * - https://docs.popbill.com/fax/dotnet/api#SendFAX_Same
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 발신번호
            String senderNum = "";

            // 수신자정보 배열 (최대 1000건)
            List<FaxReceiver> receivers = new List<FaxReceiver>();

            for (int i = 0; i < 10; i++)
            {
                FaxReceiver receiver = new FaxReceiver();

                // 수신번호
                receiver.receiveNum = "";

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

            // 광고팩스 전송여부 , true / false 중 택 1
            // └ true = 광고 , false = 일반
            // └ 미입력 시 기본값 false 처리
            bool adsYN = false;

            // 팩스제목
            String title = "팩스전송 제목";

            // 전송요청번호
            // 파트너가 전송 건에 대해 관리번호를 구성하여 관리하는 경우 사용.
            // 1~36자리로 구성. 영문, 숫자, 하이픈(-), 언더바(_)를 조합하여 팝빌 회원별로 중복되지 않도록 할당.
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
