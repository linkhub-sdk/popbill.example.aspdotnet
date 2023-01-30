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
    public partial class getSenderNumberList : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<SenderNumber> senderNumberList;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌에 등록한 연동회원의 카카오톡 발신번호 목록을 확인합니다.
             * - https://developers.popbill.com/reference/kakaotalk/dotnet/api/sendnum#GetSenderNumberList
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                senderNumberList = Global.kakaoService.GetSenderNumberList(testCorpNum, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
