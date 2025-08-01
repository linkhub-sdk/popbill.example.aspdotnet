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

namespace Popbill.Cashbill.Example
{
    public partial class sendEmail : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 현금영수증과 관련된 안내 메일을 재전송 합니다.
             * - https://developers.popbill.com/reference/cashbill/dotnet/api/etc#SendEmail
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 현금영수증 문서번호
            String mgtKey = "20220525-001";

            // 수신메일주소
            String receiveEmail = "";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                Response response = Global.cashbillService.SendEmail(testCorpNum, mgtKey, receiveEmail, testUserID);

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
