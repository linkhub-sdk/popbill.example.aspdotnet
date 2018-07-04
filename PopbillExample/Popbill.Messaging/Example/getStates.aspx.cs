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
    public partial class getStates : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public List<MessageState> statesList;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 문자 전송내역 요약정보를 확인 합니다.
             */
            //팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            //팝빌회원 아이디
            String userID = "testkorea";

            //문자전송 접수번호
            List<string> reciptNumList = new List<String>();

            reciptNumList.Add("018041717000000018");
            reciptNumList.Add("018041717000000019");

            try
            {
                statesList = Global.messageService.GetStates(testCorpNum, reciptNumList, userID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }

        }
    }
}