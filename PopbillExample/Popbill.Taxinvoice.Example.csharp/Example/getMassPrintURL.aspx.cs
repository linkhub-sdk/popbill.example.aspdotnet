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

namespace Popbill.Taxinvoice.Example
{
    public partial class getMassPrintURL : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public String url = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 대량의 세금계산서 인쇄팝업 URL을 반환합니다. (최대 100건)
             * - 보안정책으로 인해 반환된 URL의 유효시간은 30초입니다.
             * - https://docs.popbill.com/taxinvoice/dotnet/api#GetMassPrintURL
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 세금계산서 발행유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            List<string> MgtKeyList = new List<string>();

            // 인쇄할 세금계산서 문서관리번호, (최대 100건)
            MgtKeyList.Add("20190111-001");
            MgtKeyList.Add("20190111-002");
            MgtKeyList.Add("20190111-003");
            MgtKeyList.Add("20190111-004");

            try
            {
                url = Global.taxinvoiceService.GetMassPrintURL(testCorpNum, KeyType, MgtKeyList, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;                
            }
        }
    }
}