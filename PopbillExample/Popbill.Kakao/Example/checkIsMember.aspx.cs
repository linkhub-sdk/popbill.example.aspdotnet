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
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 해당 사업자의 파트너 연동회원 가입여부를 확인합니다.
             * - LinkID는 파트너에 할당된 링크아이디를 기재합니다.
             * - https://docs.popbill.com/kakao/dotnet/api#CheckIsMember
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
