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
    public partial class revokeRegistIssue : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String confirmNum;
        public String tradeDate;
        public String tradeDT;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 당초 승인 현금영수증의 취소거래 발행 API 입니다.
             * - https://developers.popbill.com/reference/cashbill/dotnet/api/issue#RevokeRegistIssue
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 문서번호, 최대 24자리, 영문, 숫자 '-', '_'를 조합하여 사업자별로 중복되지 않도록 구성
            String mgtKey = "20221108_ASP_BULK_001";

            // 원본현금영수증 승인번호, 문서정보 확인(GetInfo API)로 확인가능
            String orgConfirmNum = "TB0000130";

            // 원본현금영수증 거래일자, 문서정보 확인(GetInfo API)로 확인가능
            String orgTradeDate = "20221103";

            try
            {
                CBIssueResponse response = Global.cashbillService.RevokeRegistIssue(testCorpNum, mgtKey, orgConfirmNum, orgTradeDate);

                code = response.code.ToString();
                message = response.message;
                confirmNum = response.confirmNum;
                tradeDate = response.tradeDate;
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
