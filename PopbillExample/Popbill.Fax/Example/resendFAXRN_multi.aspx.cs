﻿using System;
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
    public partial class resendFAXRN_multi : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String receiptNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 파트너가 할당한 전송요청번호를 통해 다수의 수신자에게 팩스를 재전송합니다. (최대 1,000건)
             * - 발신/수신 정보 미입력시 기존과 동일한 정보로 팩스가 전송되고, 접수일 기준 최대 60일이 경과되지 않는 건만 재전송이 가능합니다.
             * - 팩스 재전송 요청시 포인트가 차감됩니다. (전송실패시 환불처리)
             * - 변환실패 사유로 전송실패한 팩스 접수건은 재전송이 불가합니다.
             * - https://docs.popbill.com/fax/dotnet/api#ResendFAXRN_Same
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 전송요청번호, 파트너가 전송요청에 대한 관리번호를 직접 할당하여 관리하는 경우 기재
            // 최대 36자리, 영문, 숫자, 언더바('_'), 하이픈('-')을 조합하여 사업자별로 중복되지 않도록 구성
            String requestNum = "";

            // 팩스전송시 기재한 요청번호
            String preRequestNum = "resendFaxTest";

            // 발신번호, 공백으로 처리시 기존전송정보로 전송
            String senderNum = "";

            // 발신자명, 공백으로 처리시 기존전송정보로 전송
            String senderName = "";

            // 수신자정보를 변경하지 않고 기존 전송정보로 전송하는 경우
            List<FaxReceiver> receivers = null;


            // 수신자정보를 변경하여 재전송하는 경우, 아래코드 참조
            // 수신자정보 배열 (최대 1000건)
            //List<FaxReceiver> receivers = new List<FaxReceiver>();

            /*
            for (int i = 0; i < 10; i++)
            {
                FaxReceiver receiver = new FaxReceiver();

                // 수신번호
                receiver.receiveNum = "111-2222-3333";

                // 수신자명
                receiver.receiveName = "수신자명칭_" + i;
                receivers.Add(receiver);
            }
            */

            // 예약전송일시(yyyyMMddHHmmss), null인 경우 즉시전송
            String reserveDTStr = "";

            DateTime? reserveDT = null;

            if (reserveDTStr != null && reserveDTStr != "")
            {
                reserveDT = DateTime.ParseExact(reserveDTStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
            }

            // 팩스 제목
            String title = "팩스 재전송 제목 테스트";

            try
            {
                receiptNum = Global.faxService.ResendFAXRN(testCorpNum, preRequestNum, requestNum,
                    senderNum, senderName, receivers, reserveDT, testUserID, title);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
