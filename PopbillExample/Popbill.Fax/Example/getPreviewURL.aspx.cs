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

namespace Popbill.Fax.Example
{
    public partial class getPreviewURL : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public String url  = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 접수한 팩스 전송건에 대한 미리보기 팝업 URL을 반환합니다.
             *  - 팩스 미리보기는 팩스 변환 완료후 가능합니다.
             *  - 반환된 URL은 보안정책에 따라 30초의 유효시간을 갖습니다.
             *  - https://docs.popbill.com/fax/dotnet/api#GetPreviewURL
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팩스전송 요청시 발급받은 접수번호
            String receiptNum = "018092922570100001";
            
            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                url = Global.faxService.GetPreviewURL(testCorpNum, receiptNum, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
