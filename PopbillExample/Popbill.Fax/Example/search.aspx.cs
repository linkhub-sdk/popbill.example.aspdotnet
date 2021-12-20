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

namespace Popbill.Fax.Example
{
    public partial class search : System.Web.UI.Page
    {
        public String code;
        public String message;
        public FAXSearchResult result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 검색조건에 해당하는 팩스 전송내역 목록을 조회합니다. (조회기간 단위 : 최대 2개월)
             * - 팩스 접수일시로부터 2개월 이내 접수건만 조회할 수 있습니다.
             * - https://docs.popbill.com/fax/dotnet/api#Search
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 최대 검색기간 : 2개월 이내 
            // 시작일자, 날짜형식(yyyyMMdd)
            String SDate = "20211201";

            // 종료일자, 날짜형식(yyyyMMdd)
            String EDate = "20211220";

            //전송상태 배열 1-대기, 2-성공, 3-실패, 4-취소
            String[] State = new String[4];
            State[0] = "1";
            State[1] = "2";
            State[2] = "3";
            State[3] = "4";

            // 예약여부, True-예약전송건 검색, False-즉시전송건 검색
            bool ReserveYN = false;

            // 개인조회여부, True-개인조회, False-회사조회
            bool SenderOnly = false;

            // 정렬방향, A-오름차순, D-내림차순
            String Order = "D";

            // 페이지 번호
            int Page = 1;

            // 페이지당 검색개수, 최대 1000개
            int PerPage = 10;

            // 조회 검색어, 팩스 전송시 기재한 발신자명 또는 수신자명 기재
            String QString = "";

            try
            {
                result = Global.faxService.Search(testCorpNum, SDate, EDate, State, ReserveYN, SenderOnly, Order, Page, PerPage, QString);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
