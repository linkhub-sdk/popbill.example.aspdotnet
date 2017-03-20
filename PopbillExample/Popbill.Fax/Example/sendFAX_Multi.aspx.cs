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
            String testCorpNum = "1234567890";

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

            // 팩스전송 파일경로, JPG 파일포맷, 300KByte 이하 전송 가능
            String filePath = "C:/popbill.example.aspdotnet/PopbillExample/test.jpg";

            // 예약전송일시(yyyyMMddHHmmss), null인 경우 즉시전송
            String reserveDTStr = "";

            DateTime? reserveDT = null;

            if (reserveDTStr != null && reserveDTStr != "")
            {
                reserveDT = DateTime.ParseExact(reserveDTStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
            }

            try
            {
                receiptNum = Global.faxService.SendFAX(testCorpNum, senderNum, receivers, filePath, reserveDT, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
