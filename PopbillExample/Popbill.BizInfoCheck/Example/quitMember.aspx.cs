﻿using System;
using System.Web.UI;

namespace Popbill.BizInfoCheck.Example
{
    public partial class quitMember : Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 가입된 연동회원의 탈퇴를 요청합니다.
             * - 회원탈퇴 신청과 동시에 팝빌의 모든 서비스 이용이 불가하며, 관리자를 포함한 모든 담당자 계정도 일괄탈퇴 됩니다.
             * - 회원탈퇴로 삭제된 데이터는 복원이 불가능합니다.
             * - 관리자 계정만 회원탈퇴가 가능합니다.
             * - https://developers.popbill.com/reference/bizinfocheck/dotnet/api/member#QuitMember
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String CorpNum = "1234567890";

            String QuitReason = "탈퇴 사유";

            // 팝빌회원 아이디
            String UserID = "testkorea";

            try
            {
                Response response = Global.bizInfoCheckService.QuitMember(CorpNum, QuitReason, UserID);

                code = response.code.ToString();
                message = response.message;
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}