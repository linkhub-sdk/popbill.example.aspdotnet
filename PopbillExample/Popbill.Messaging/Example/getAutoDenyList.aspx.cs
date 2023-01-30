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
             * 전용 080 번호에 등록된 수신거부 목록을 반환합니다.
             * - https://developers.popbill.com/reference/sms/dotnet/api/info#GetAutoDenyList
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
