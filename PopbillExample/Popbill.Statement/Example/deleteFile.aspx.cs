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

namespace Popbill.Statement.Example
{
    public partial class deleteFile : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * "임시저장" 상태의 전자명세서에 첨부된 1개의 파일을 삭제합니다.
             * - https://developers.popbill.com/reference/statement/dotnet/api/etc#DeleteFile
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 전자명세서 문서 유형 - 121(거래명세서), 122(청구서), 123(견적서), 124(발주서), 125(입금표), 126(영수증)
            int itemCode = 121;

            // 전자명세서 문서번호
            String mgtKey = "20220525-001";

            // 팝빌 식별번호, 첨부파일 목록 확인(getFiles API) 함수의 리턴 값 중 attachedFile 필드값 기재.
            String fileID = "";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

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
