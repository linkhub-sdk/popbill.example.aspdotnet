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
    public partial class getPopbillURL_LOGIN : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public String url = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 팝빌 로그인 URL을 반환합니다.
            * - 반환된 URL은 보안정책에 따라 30초의 유효시간을 갖습니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // [LOGIN] : 팝빌 로그인 URL
            String TOGO = "LOGIN";

            try
            {
                url = Global.kakaoService.GetPopbillURL(testCorpNum, testUserID, TOGO);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
