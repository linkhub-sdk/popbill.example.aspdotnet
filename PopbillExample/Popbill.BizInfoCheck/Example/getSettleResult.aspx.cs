﻿using System;
using System.Web.UI;

namespace Popbill.BizInfoCheck.Example
{
    public partial class getSettleResult : Page
    {
        public PaymentHistory result = null;
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 연동회원 포인트 무통장 입금신청내역 1건을 확인합니다.
             * - https://developers.popbill.com/reference/bizinfocheck/dotnet/api/point#GetSettleResult
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String CorpNum = "1234567890";

            // 정산코드
            String SettleCode = "202301160000000010";

            // 팝빌회원 아이디
            String UserID = "testkorea";

            try
            {
                result = Global.bizInfoCheckService.GetSettleResult(CorpNum, SettleCode, UserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}