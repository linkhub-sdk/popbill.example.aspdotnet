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

namespace Popbill.Message.Example
{
    public partial class getCorpInfo : System.Web.UI.Page
    {
        public String code;
        public String message;
        public CorpInfo corpInfo = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 연동회원의 회사정보를 확인합니다.
             * - https://developers.popbill.com/reference/sms/dotnet/common-api/member#GetCorpInfo
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                corpInfo = Global.messageService.GetCorpInfo(testCorpNum, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
