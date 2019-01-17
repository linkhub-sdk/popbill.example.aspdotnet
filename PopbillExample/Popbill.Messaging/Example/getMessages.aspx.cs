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
    public partial class getMessages : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<MessageResult> result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 문자전송요청시 발급받은 접수번호(receiptNum)로 전송상태를 확인합니다.
             * - 응답항목에 대한 자세한 사항은 "[문자 API 연동매뉴얼] >  3.3.1. GetMessages (전송내역 확인)을 참조하시기 바랍니다.
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 문자전송 요청시 발급받은 접수번호
            String receiptNum = "018090511000000030";

            try
            {
                result = Global.messageService.GetMessageResult(testCorpNum, receiptNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
