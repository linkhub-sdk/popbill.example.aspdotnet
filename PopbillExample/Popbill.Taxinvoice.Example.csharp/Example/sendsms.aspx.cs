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

namespace Popbill.Taxinvoice.Example
{
    public partial class sendsms : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 알림문자를 전송합니다. (단문/SMS- 한글 최대 45자)
             * - 알림문자 전송시 포인트가 차감됩니다. (전송실패시 환불처리)
             * - 전송내역 확인은 "팝빌 로그인" > [문자 팩스] > [문자] > [전송내역] 메뉴에서 전송결과를 확인할 수 있습니다.
             * - https://docs.popbill.com/taxinvoice/dotnet/api#SendSMS
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 세금계산서 발행유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 세금계산서 문서관리번호
            String mgtKey = "20190111-001";

            // 발신번호, [참고] 발신번호 세칙안내 - http://blog.linkhub.co.kr/3064
            string senderNum = "070-4304-2991";

            // 수신번호
            string receiverNum = "010-111-222";

            // 문자메시지 내용, 90byte 초과시 길이가 조정되어 전송됨
            string contents = "알림문자 전송내용, 90byte 초과된 내용은 삭제되어 전송됨";

            try
            {
                Response response = Global.taxinvoiceService.SendSMS(testCorpNum, KeyType, mgtKey, senderNum, receiverNum, contents, testUserID);

                code = response.code.ToString();
                message = response.message;
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }    
        }
    }
}
