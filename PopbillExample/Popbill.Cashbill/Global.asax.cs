/**
* 팝빌 현금영수증 API ASP.NET SDK Example
*
* ASP.NET SDK 연동환경 설정방법 안내 : https://developers.popbill.com/guide/cashbill/dotnet/getting-started/tutorial?fwn=asp
* 업데이트 일자 : 2023-05-30
* 연동기술지원 연락처 : 1600-9854
* 연동기술지원 이메일 : code@linkhubcorp.com
*
* <테스트 연동개발 준비사항>
* 1) 30, 33번 라인에 선언된 링크아이디(LinkID)와 비밀키(SecretKey)를
*    링크허브 가입시 메일로 발급받은 인증정보를 참조하여 변경합니다.
* 2) 팝빌 개발용 사이트(test.popbill.com)에 연동회원으로 가입합니다.
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

namespace Popbill.Cashbill
{
    public class Global : System.Web.HttpApplication
    {
        // 링크아이디
        private string LinkID = "TESTER";

        // 비밀키
        private string SecretKey = "SwWxqU+0TErBXy/9TVjIPEnI0VTUMMSQZtJf3Ed8q3I=";

        // 현금영수증 서비스 객체 선언
        public static CashbillService cashbillService;

        protected void Application_Start(object sender, EventArgs e)
        {
            // 현금영수증 서비스 객체 초기화
            cashbillService = new CashbillService(LinkID, SecretKey);

            // 연동환경 설정값, 개발용(true), 상업용(false)
            cashbillService.IsTest = true;

            // 인증토큰 IP 제한기능 사용여부, 권장(true)
            cashbillService.IPRestrictOnOff = true;

            // 팝빌 API 서비스 고정 IP 사용여부, true-사용, false-미사용, 기본값(false)
            cashbillService.UseStaticIP = false;

            // 로컬서버 시간 사용 여부 true-사용, false-미사용, 기본값(false)
            cashbillService.UseLocalTimeYN = true;
        }
    }
}