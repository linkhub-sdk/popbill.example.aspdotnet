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
    public partial class getPrintURL : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String url = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 홈택스에서 수집된 전자세금계산서 1건의 인쇄 팝업 URL을 반환합니다.
             * - https://developers.popbill.com/reference/httaxinvoice/dotnet/api/search#GetPrintURL
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 조회할 전자세금계산서 국세청승인번호
            String NTSConfirmNum = "202110314100020300002777";

            // 팝빌회원 아이디
            String userID = "testkorea";

            try
            {
                url = Global.htTaxinvoiceService.GetPrintURL(testCorpNum, NTSConfirmNum, userID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
