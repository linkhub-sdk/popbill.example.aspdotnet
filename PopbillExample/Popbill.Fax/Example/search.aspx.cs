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
             * - https://developers.popbill.com/reference/fax/dotnet/api/info#Search
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 최대 검색기간 : 2개월 이내
            // 시작일자, 날짜형식(yyyyMMdd)
            String SDate = "20241201";

            // 종료일자, 날짜형식(yyyyMMdd)
            String EDate = "20241231";

            // 전송상태 배열 ("1" , "2" , "3" , "4" 중 선택, 다중 선택 가능)
            // └ 1 = 대기 , 2 = 성공 , 3 = 실패 , 4 = 취소
            // - 미입력 시 전체조회
            String[] State = new String[4];
            State[0] = "1";
            State[1] = "2";
            State[2] = "3";
            State[3] = "4";

            // 예약여부 (null, false , true 중 택 1)
            // └ null = 전체조회, false = 즉시전송건 조회, true = 예약전송건 조회
            // - 미입력 시 전체조회
            bool ReserveYN = false;

            // 개인조회 여부 (false , true 중 택 1)
            // false = 접수한 팩스 전체 조회 (관리자권한)
            // true = 해당 담당자 계정으로 접수한 팩스만 조회 (개인권한)
            // 미입력시 기본값 false 처리
            bool SenderOnly = false;

            // 정렬방향, A-오름차순, D-내림차순
            String Order = "D";

            // 페이지 번호
            int Page = 1;

            // 페이지당 검색개수, 최대 1000개
            int PerPage = 10;

            // 조회하고자 하는 발신자명 또는 수신자명
            // - 미입력시 전체조회
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
