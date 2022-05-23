/**
* 팝빌 예금주조회 API ASP.NET SDK Example
*
* ASP.NET SDK 연동환경 설정방법 안내 : https://docs.popbill.com/accountcheck/tutorial/dotnet
* 업데이트 일자 : 2022-05-25
* 연동기술지원 연락처 : 1600-9854
* 연동기술지원 이메일 : code@linkhubcorp.com
*
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

namespace Popbill.AccountCheck
{
    public class Global : System.Web.HttpApplication
    {

        // 링크아이디
        private string LinkID = "TESTER";

        // 비밀키
        private string SecretKey = "SwWxqU+0TErBXy/9TVjIPEnI0VTUMMSQZtJf3Ed8q3I=";

        // 예금주조회 서비스 객체 선언
        public static AccountCheckService accountCheckService;

        protected void Application_Start(object sender, EventArgs e)
        {
            // 예금주조회 서비스 객체 초기화
            accountCheckService = new AccountCheckService(LinkID, SecretKey);

            // 연동환경 설정값, 개발용(true), 상업용(false)
            accountCheckService.IsTest = true;

            // 인증토큰 IP 제한기능 사용여부, 권장(true)
            accountCheckService.IPRestrictOnOff = true;

            // 팝빌 API 서비스 고정 IP 사용여부, true-사용, false-미사용, 기본값(false)
            accountCheckService.UseStaticIP = false;

            // 로컬서버 시간 사용 여부 true-사용, false-미사용, 기본값(false)
            accountCheckService.UseLocalTimeYN = true;
        }
    }
}