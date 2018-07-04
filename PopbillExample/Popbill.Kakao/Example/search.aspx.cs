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
            * 검색조건을 사용하여 카카오톡 전송내역을 조회합니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 최대 검색기한 : 6개월 이내
            // 시작일자, 날자형식(yyyyMMdd)
            String SDate = "20180601";

            // 종료일자, 날자형식(yyyyMMdd)
            String EDate = "20180731";

            // 전송상태값 배열, 0-대기, 1-전송중, -2-성공, 3-대체, 4-실패, 5-취소
            String[] State = new String[6];
            State[0] = "0";
            State[1] = "1";
            State[2] = "2";
            State[3] = "3";
            State[4] = "4";
            State[5] = "5";

            // 검색대상 배열, ATS-알림톡, FTS-친구톡 텍스트, FMS-친구톡 이미지
            String[] Item = new String[3];
            Item[0] = "ATS";
            Item[1] = "FTS";
            Item[2] = "FMS";

            // 예약여부, 공백-전체조회, 1-예약전송건 조회, 0-일반전송건 조회
            String ReserveYN = "";

            // 개인조회여부 true-개인조회, false-회사조회 
            bool SenderYN = false;

            // 정렬방향, A-오름차순, D-내림차순
            String Order = "D";

            // 페이지 번호
            int Page = 1;

            // 페이지당 검색개수, 최대 1000건
            int PerPage = 10;

            // 조회 검색어, 카카오톡 전송시 기재한 수신자명 입력
            String QString = "";

            try
            {
                result = Global.kakaoService.Search(testCorpNum, SDate, EDate, State,
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
