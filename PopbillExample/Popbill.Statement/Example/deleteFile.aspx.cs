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

namespace Popbill.Statement.Example
{
    public partial class deleteFile : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 전자명세서에 첨부된 파일을 삭제합니다.
             * - 파일을 식별하는 파일아이디는 첨부파일 목록(GetFileList API) 의 응답항목
             *   중 파일아이디(AttachedFile) 값을 통해 확인할 수 있습니다.
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 명세서 종류 코드 - 121(거래명세서), 122(청구서), 123(견적서) 124(발주서), 125(입금표), 126(영수증)
            int itemCode = 121;

            // 전자명세서 문서관리번호
            String mgtKey = "20190111-001";

            // 파일아이디
            String fileID = "2AD5E4B8-3639-4F93-A9B1-A93B097A6D96.PBF";

            try
            {
                Response response = Global.statementService.DeleteFile(testCorpNum, itemCode, mgtKey, fileID, testUserID);

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
