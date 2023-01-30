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
    public partial class getCertificateExpireDate : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public DateTime expiration;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌 인증서버에 등록된 인증서의 만료일을 확인합니다.
             * - https://developers.popbill.com/reference/taxinvoice/dotnet/api/cert#GetCertificateExpireDate
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            try
            {
                expiration = Global.taxinvoiceService.GetCertificateExpireDate(testCorpNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
