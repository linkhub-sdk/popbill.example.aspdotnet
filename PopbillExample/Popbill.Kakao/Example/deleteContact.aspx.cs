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

namespace Popbill.Kakao.Example
{
    public partial class deleteContact : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 연동회원에 추가된 담당자를 삭제합니다.
             * - https://developers.popbill.com/reference/kakaotalk/dotnet/common-api/member#DeleteContact
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 삭제할 팝빌회원 아이디
            String targetUserID = "testkorea20250724_01";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                Response response = Global.kakaoService.DeleteContact(testCorpNum, targetUserID, testUserID);
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
