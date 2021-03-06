﻿using System;
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

namespace Popbill.Closedown.Example
{
    public partial class listContact : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public List<Contact> contactList = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 연동회원의 담당자 목록을 확인합니다.
            * - https://docs.popbill.com/closedown/dotnet/api#ListContact
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                contactList = Global.closedownService.ListContact(testCorpNum, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
