﻿/**
* 팝빌 카카오톡 API .NET SDK ASP.NET Example
* ASP.NET 연동 튜토리얼 안내 : https://developers.popbill.com/guide/kakaotalk/dotnet/getting-started/tutorial?fwn=asp
*
* 업데이트 일자 : 2025-07-24
* 연동기술지원 연락처 : 1600-9854
* 연동기술지원 이메일 : code@linkhubcorp.com
*         
* <테스트 연동개발 준비사항>
* 1) API Key 변경 (연동신청 시 메일로 전달된 정보)
*     - LinkID : 링크허브에서 발급한 링크아이디
*     - SecretKey : 링크허브에서 발급한 비밀키
* 2) SDK 환경설정 옵션 설정
*     - IsTest : 연동환경 설정, true-테스트, false-운영(Production), (기본값:true)
*     - IPRestrictOnOff : 인증토큰 IP 검증 설정, true-사용, false-미사용, (기본값:true)
*     - UseStaticIP : 통신 IP 고정, true-사용, false-미사용, (기본값:false)
*     - UseLocalTimeYN : 로컬시스템 시간 사용여부, true-사용, false-미사용, (기본값:true)
* 3) 비즈니스 채널 등록 및 알림톡 템플릿을 신청합니다.
*    - 1. 비즈니스 채널 등록 (등록방법은 사이트/API 두가지 방식이 있습니다.)
*        └ 팝빌 사이트 로그인 > [카카오톡] > [카카오톡 관리] > '카카오톡 채널 관리' 메뉴에서 등록
*        └ GetPlusFriendMgtURL API 를 통해 반환된 URL을 이용하여 등록
*    - 2. 알림톡 템플릿 신청 (등록방법은 사이트/API 두가지 방식이 있습니다.)
*        └ 팝빌 사이트 로그인 > [카카오톡] > [카카오톡 관리] > '알림톡 템플릿 관리' 메뉴에서 등록
*        └ GetATSTemplateMgtURL API 를 통해 URL을 이용하여 등록.
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

namespace Popbill.Kakao
{
    public class Global : System.Web.HttpApplication
    {
        // 링크아이디
        private string LinkID = "TESTER";

        // 비밀키
        private string SecretKey = "SwWxqU+0TErBXy/9TVjIPEnI0VTUMMSQZtJf3Ed8q3I=";

        // 카카오톡 서비스 객체 선언
        public static KakaoService kakaoService;

        protected void Application_Start(object sender, EventArgs e)
        {
            // 카카오톡 서비스 객체 초기화
            kakaoService = new KakaoService(LinkID, SecretKey);

            // 연동환경 설정, true-테스트, false-운영(Production), (기본값:true)
            kakaoService.IsTest = true;

            // 인증토큰 IP 검증 설정, true-사용, false-미사용, (기본값:true)
            kakaoService.IPRestrictOnOff = true;

            // 통신 IP 고정, true-사용, false-미사용, (기본값:false)
            kakaoService.UseStaticIP = false;

            // 로컬시스템 시간 사용여부, true-사용, false-미사용, (기본값:true)
            kakaoService.UseLocalTimeYN = true;
        }

    }
}