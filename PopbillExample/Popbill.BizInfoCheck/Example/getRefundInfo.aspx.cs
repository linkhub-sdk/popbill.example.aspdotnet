﻿using System;
using System.Web.UI;

namespace Popbill.BizInfoCheck.Example
{
    public partial class getRefundInfo : Page
    {
        public RefundHistory result = null;
        public String code;
        public String message;
        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 포인트 환불에 대한 상세정보 1건을 확인합니다.
             * - https://developers.popbill.com/reference/bizinfocheck/dotnet/api/point#GetRefundInfo
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String CorpNum = "1234567890";

            // 환불코드
            String RefundCode = "023040000017";

            // 팝빌회원 아이디
            String UserID = "testkorea";

            try
            {
                result = Global.bizInfoCheckService.GetRefundInfo(CorpNum, RefundCode, UserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}