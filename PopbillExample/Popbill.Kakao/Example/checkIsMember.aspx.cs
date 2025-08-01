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
    public partial class checkIsMember : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 사업자번호를 조회하여 연동회원 가입여부를 확인합니다.
             * - https://developers.popbill.com/reference/kakaotalk/dotnet/common-api/member#CheckIsMember
             */

            // 조회할 사업자번호
            String testCorpNum = "1234567890";

            // 링크아이디
            String LinkID = "TESTER";

            try
            {
                Response response = Global.kakaoService.CheckIsMember(testCorpNum, LinkID);

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
