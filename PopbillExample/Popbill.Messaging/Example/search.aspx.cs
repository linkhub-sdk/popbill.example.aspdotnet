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

namespace Popbill.Message.Example
{
    public partial class search : System.Web.UI.Page
    {
        public String code;
        public String message;
        public MSGSearchResult result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 검색조건을 사용하여 메시지 전송내역을 조회합니다.
             * - 최대 검색기한 : 6개월 이내
             * - https://docs.popbill.com/message/dotnet/api#Search
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 최대 검색기간 : 6개월 이내
            // 시작일자, 날짜형식(yyyyMMdd)
            String SDate = "20190918";

            // 종료일자, 날짜형식(yyyyMMdd)
            String EDate = "20191231";

            // 전송상태값 배열, 1-대기, 2-성공, 3-실패, 4-취소
            String[] State = new String[4];
            State[0] = "1";
            State[1] = "2";
            State[2] = "3";
            State[3] = "4";

            // 검색대상 배열, SMS, LMS, MMS
            String[] Item = new String[3];
            Item[0] = "SMS";
            Item[1] = "LMS";
            Item[2] = "MMS";

            // 예약여부, true-예약전송건 조회, false-즉시전송건 조회
            bool ReserveYN = false;

            // 개인조회여부 true-개인조회, false-회사조회 
            bool SenderYN = false;

            // 정렬방향, A-오름차순, D-내림차순
            String Order = "D";

            // 페이지 번호
            int Page = 1;

            // 페이지당 검색개수, 최대 1000건
            int PerPage = 10;

            // 조회 검색어, 문자 전송시 기재한 수신자명 또는 발신자명 기재
            String QString = "";

            try
            {
                result = Global.messageService.Search(testCorpNum, SDate, EDate, State, 
                    Item, ReserveYN, SenderYN, Order, Page, PerPage, QString);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
