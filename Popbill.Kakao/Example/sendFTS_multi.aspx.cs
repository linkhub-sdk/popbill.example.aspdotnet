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

namespace Popbill.Kakao.Example
{
    public partial class sendFTS_multi : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String receiptNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            // 팝빌회원 사업자번호
            String testCorpNum = "1234567890";

            // 플러스친구 아이디, ListPlusFriendID API 의 plusFriendID 참고
            String plusFriendID = "@팝빌";

            // 팝빌에 사전 등록된 발신번호
            String senderNum = "07043042993";

            // 대체문자 유형, 공백-미전송, C-알림톡 내용, A-대체문자 내용
            String altSendType = "C";

            // 광고전송여부
            Boolean adsYN = false;


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
                receiverInfo.rcv = "01011122" + i;
                receiverInfo.rcvnm = "수신자명" + i.ToString();
                receiverInfo.msg = "개별 친구톡 내용" + i.ToString();
                receiverInfo.altmsg = "대체문자 전송내용" + i.ToString();
                receivers.Add(receiverInfo);
            }

            // 버튼배열, 최대 5개
            List<KakaoButton> buttons = new List<KakaoButton>();
            KakaoButton btnInfo = new KakaoButton();
            btnInfo.n = "버튼이름"; // 버튼명
            btnInfo.t = "WL"; // 버튼유형
            btnInfo.u1 = "http://www.popbill.com"; // 버튼링크1
            btnInfo.u2 = "http://test.popbill.com";// 버튼링크2
            buttons.Add(btnInfo);

            try
            {
                receiptNum = Global.kakaoService.SendFTS(testCorpNum, plusFriendID, senderNum, altSendType, adsYN, reserveDT, receivers, buttons);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
