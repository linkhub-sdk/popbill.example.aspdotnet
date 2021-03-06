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

namespace Popbill.Taxinvoice.Example
{
    public partial class listEmailConfig : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public List<EmailConfig> emailConfigList = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 전자세금계산서 관련 메일전송 항목에 대한 전송여부를 목록으로 반환한다.
             * - https://docs.popbill.com/taxinvoice/dotnet/api#ListEmailConfig
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                emailConfigList = Global.taxinvoiceService.ListEmailConfig(testCorpNum, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
