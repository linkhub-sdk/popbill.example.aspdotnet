﻿using System;
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

namespace Popbill.Fax.Example
{
    public partial class resendFAXRN : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String receiptNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 파트너가 할당한 요청번호를 통해 팩스 1건을 재전송합니다.
             * - https://developers.popbill.com/reference/fax/dotnet/api/send#ResendFAXRN
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

            // 수신번호/수신자명을 공백으로 처리시 기존전송정보로 전송
            // 수신번호
            String receiverNum = "";

            // 수신자명
            String receiverName = "";

            // 예약전송일시(yyyyMMddHHmmss), null인 경우 즉시전송
            String reserveDTStr = "";

            DateTime? reserveDT = null;

            if (reserveDTStr != null && reserveDTStr != "")
            {
                reserveDT = DateTime.ParseExact(reserveDTStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
            }

            // 팩스제목
            String title = "팩스 재전송 제목";

            try
            {
                receiptNum = Global.faxService.ResendFAXRN(testCorpNum, preRequestNum, requestNum,
                    senderNum, senderName, receiverNum, receiverName, reserveDT, testUserID, title);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
