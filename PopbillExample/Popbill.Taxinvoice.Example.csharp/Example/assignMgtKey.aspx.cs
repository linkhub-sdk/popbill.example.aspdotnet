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
    public partial class assignMgtKey : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌사이트에서 작성된 세금계산서에 파트너 문서관리번호를 할당합니다.
             * - https://docs.popbill.com/taxinvoice/dotnet/api#AssignMgtKey
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 세금계산서 유형 SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 세금계산서 아이템키, 목록조회(Search) API의 반환항목중 ItemKey 참조
            String itemKey = "018041823580800001";

            // 할당할 문서관리번호, 숫자, 영문, '-', '_' 조합으로 
            // 1~24자리까지 사업자번호별 중복없는 고유번호 할당
            String mgtKey = "20190111-001";

            try
            {
                Response response = Global.taxinvoiceService.AssignMgtKey(testCorpNum, KeyType, itemKey, mgtKey, testUserID);

                code = response.code.ToString();
                message = response.message;
            }
            catch(PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }

        }
    }
}
