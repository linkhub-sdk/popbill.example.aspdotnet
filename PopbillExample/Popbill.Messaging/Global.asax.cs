﻿/**
* 팝빌 문자 API ASP.NET SDK Example
*
* ASP.NET SDK 연동환경 설정방법 안내 : https://docs.popbill.com/message/tutorial/dotnet#asp
* 업데이트 일자 : 2021-08-06
* 연동기술지원 연락처 : 1600-9854 / 070-4304-2991
* 연동기술지원 이메일 : code@linkhub.co.kr
*
* <테스트 연동개발 준비사항>
* 1) 29, 32번 라인에 선언된 링크아이디(LinkID)와 비밀키(SecretKey)를
*    링크허브 가입시 메일로 발급받은 인증정보를 참조하여 변경합니다.
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

namespace Popbill.Message
{
    public class Global : System.Web.HttpApplication
    {
        // 링크아이디
        private string LinkID = "TESTER";

        // 비밀키
        private string SecretKey = "SwWxqU+0TErBXy/9TVjIPEnI0VTUMMSQZtJf3Ed8q3I=";

        // 문자 서비스 객체 선언
        public static MessageService messageService;

        protected void Application_Start(object sender, EventArgs e)
        {
            // 문자 서비스 객체 초기화
            messageService = new MessageService(LinkID, SecretKey);

            // 연동환경 설정값, 개발용(true), 상업용(false)
            messageService.IsTest = true;

            // 인증토큰 IP 제한기능 사용여부, 권장(true)
            messageService.IPRestrictOnOff = true;

            // 팝빌 API 서비스 고정 IP 사용여부, true-사용, false-미사용, 기본값(false)
            messageService.UseStaticIP = false;

            // 로컬서버 시간 사용 여부 true-사용, false-미사용, 기본값(false)
            messageService.UseLocalTimeYN = true;
        }
    }
}