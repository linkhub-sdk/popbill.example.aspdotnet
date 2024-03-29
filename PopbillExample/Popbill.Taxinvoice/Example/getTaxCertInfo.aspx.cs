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
    public partial class getTaxCertInfo : System.Web.UI.Page
    {
        public String code;
        public String message;
        public TaxinvoiceCertificate TaxinvoiceCertificate = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌 인증서버에 등록된 공동인증서의 정보를 확인합니다.
             * - https://developers.popbill.com/reference/taxinvoice/dotnet/api/cert#GetTaxCertInfo
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            try
            {
                TaxinvoiceCertificate = Global.taxinvoiceService.GetTaxCertInfo(testCorpNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
