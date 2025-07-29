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

namespace Popbill.Kakao.Example
{
    public partial class search : System.Web.UI.Page
    {
        public String code;
        public String message;
        public KakaoSearchResult result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 검색조건에 해당하는 카카오톡 전송내역을 조회합니다. (조회기간 단위 : 최대 2개월)
             * - 카카오톡 접수일시로부터 6개월 이내 접수건만 조회할 수 있습니다.
             * - https://developers.popbill.com/reference/kakaotalk/dotnet/api/info#Search
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 최대 검색기한 : 6개월 이내
            // 시작일자, 날자형식(yyyyMMdd)
            String SDate = "20250701";

            // 종료일자, 날자형식(yyyyMMdd)
            String EDate = "20250731";

            // 전송상태 배열 ("0" , "1" , "2" , "3" , "4" , "5" 중 선택, 다중 선택 가능)
            // └ 0 = 전송대기 , 1 = 전송중 , 2 = 전송성공 , 3 = 대체문자 전송 , 4 = 전송실패 , 5 = 전송취소
            // - 미입력 시 전체조회
            String[] State = new String[6];
            State[0] = "0";
            State[1] = "1";
            State[2] = "2";
            State[3] = "3";
            State[4] = "4";
            State[5] = "5";

            // 검색대상 배열 ("ATS", "FTS", "FMS" 중 선택, 다중 선택 가능)
            // └ ATS = 알림톡 , FTS = 친구톡(텍스트) , FMS = 친구톡(이미지)
            // - 미입력 시 전체조회
            String[] Item = new String[3];
            Item[0] = "ATS";
            Item[1] = "FTS";
            Item[2] = "FMS";

            // 전송유형별 조회 (null , "0" , "1" 중 택 1)
            // └ null = 전체 , 0 = 즉시전송건 , 1 = 예약전송건
            // - 미입력 시 전체조회
            String ReserveYN = "";

            // 사용자권한별 조회 (true / false 중 택 1)
            // └ false = 접수한 카카오톡 전체 조회 (관리자권한)
            // └ true = 해당 담당자 계정으로 접수한 카카오톡만 조회 (개인권한)
            // 미입력시 기본값 false 처리
            bool SenderYN = false;

            // 정렬방향, A-오름차순, D-내림차순
            String Order = "D";

            // 페이지 번호
            int Page = 1;

            // 페이지당 검색개수, 최대 1000건
            int PerPage = 10;

            // 팝빌회원 아이디
            String userID = "testkorea";

            // 조회하고자 하는 수신자명
            // - 미입력시 전체조회
            String QString = "";

            try
            {
                result = Global.kakaoService.Search(testCorpNum, SDate, EDate, State,
                    Item, ReserveYN, SenderYN, Order, Page, PerPage, userID, QString);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
