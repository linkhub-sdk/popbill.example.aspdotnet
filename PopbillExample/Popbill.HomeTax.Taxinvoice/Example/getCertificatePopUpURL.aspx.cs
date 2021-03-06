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

namespace Popbill.HomeTax.Taxinvoice.Example
{
    public partial class getCertificatePopUpURL : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String url;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 홈택스연동 인증관리를 위한 URL을 반환합니다.
             * 인증방식에는 부서사용자/공인인증서 인증 방식이 있습니다.
             * - 반환된 URL은 보안정책에 따라 30초의 유효시간을 갖습니다.
             * - https://docs.popbill.com/httaxinvoice/dotnet/api#GetCertificatePopUpURL
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                url = Global.htTaxinvoiceService.GetCertificatePopUpURL(testCorpNum, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
