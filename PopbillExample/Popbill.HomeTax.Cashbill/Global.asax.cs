/**
* 팝빌 홈택스 현금영수증 매입/매출 조회 API ASP.NET SDK Example
*
* ASP.NET SDK 연동환경 설정방법 안내 : https://developers.popbill.com/guide/htcashbill/dotnet/getting-started/tutorial?fwn=asp
* 업데이트 일자 : 2023-07-07
* 연동기술지원 연락처 : 1600-9854
* 연동기술지원 이메일 : code@linkhubcorp.com
*
*
* <테스트 연동개발 준비사항>
* 1) 35, 38번 라인에 선언된 링크아이디(LinkID)와 비밀키(SecretKey)를
*    링크허브 가입시 메일로 발급받은 인증정보를 참조하여 변경합니다.
* 2) 팝빌 개발용 사이트(test.popbill.com)에 연동회원으로 가입합니다.
* 3) 홈택스에서 이용가능한 공인인증서를 등록합니다.
*    - 팝빌로그인 > [홈택스연계] > [환경설정] > [공인인증서 관리] 메뉴
*    - 공인인증서 등록(GetCertificatePopUpURL API) 반환된 URL을 이용하여
*      팝업 페이지에서 공인인증서 등록
*/

using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;

namespace Popbill.HomeTax.Cashbill
{
    public class Global : System.Web.HttpApplication
    {
        // 링크아이디
        private string LinkID = "TESTER";

        // 비밀키
        private string SecretKey = "SwWxqU+0TErBXy/9TVjIPEnI0VTUMMSQZtJf3Ed8q3I=";

        // 홈택스 현금영수증 매입/매출 조회 서비스 객체 선언
        public static HTCashbillService htCashbillService;

        protected void Application_Start(object sender, EventArgs e)
        {
            // 현금영수증 매입/매출 조회 서비스 객체 초기화
            htCashbillService = new HTCashbillService(LinkID, SecretKey);

            // 연동환경 설정값, 개발용(true), 상업용(false)
            htCashbillService.IsTest = true;

            // 인증토큰 IP 제한기능 사용여부, 권장(true)
            htCashbillService.IPRestrictOnOff = true;

            // 팝빌 API 서비스 고정 IP 사용여부, true-사용, false-미사용, 기본값(false)
            htCashbillService.UseStaticIP = false;

            // 로컬서버 시간 사용 여부 true-사용, false-미사용, 기본값(false)
            htCashbillService.UseLocalTimeYN = true;
        }
    }
}