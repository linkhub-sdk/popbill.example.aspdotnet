using System;
using System.Collections;
using System.Collections.Generic;
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

namespace Popbill.Message.Example
{
    public partial class getAutoDenyList : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<AutoDeny> autoDenyList;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 080 서비스 수신거부 목록을 확인합니다.
             * - https://docs.popbill.com/message/dotnet/api#GetAutoDenyList
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            try
            {
                autoDenyList = Global.messageService.GetAutoDenyList(testCorpNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
