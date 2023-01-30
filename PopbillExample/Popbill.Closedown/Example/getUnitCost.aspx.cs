using System;
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

namespace Popbill.Closedown.Example
{
    public partial class getUnitCost : System.Web.UI.Page
    {
        public String code;
        public String message;
        public float unitCost;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 휴폐업 조회시 과금되는 포인트 단가를 확인합니다.
             * - https://developers.popbill.com/reference/closedown/dotnet/api/point#GetUnitCost
             */

            String testCorpNum = "1234567890";

            try
            {
                unitCost = Global.closedownService.GetUnitCost(testCorpNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;                
            }
        }
    }
}
