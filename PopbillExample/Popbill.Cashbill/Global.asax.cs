/**
* �˺� ���ݿ����� API ASP.NET SDK Example
*
* ASP.NET SDK ����ȯ�� ������� �ȳ� : https://docs.popbill.com/cashbill/tutorial/dotnet#asp
* ������Ʈ ���� : 2021-12-23
* ����������� ����ó : 1600-9854 / 070-4304-2991
* ����������� �̸��� : code@linkhub.co.kr
*
* <�׽�Ʈ �������� �غ����>
* 1) 30, 33�� ���ο� ����� ��ũ���̵�(LinkID)�� ���Ű(SecretKey)��
*    ��ũ��� ���Խ� ���Ϸ� �߱޹��� ���������� �����Ͽ� �����մϴ�.
* 2) �˺� ���߿� ����Ʈ(test.popbill.com)�� ����ȸ������ �����մϴ�.
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
        // ��ũ���̵�
        private string LinkID = "TESTER";

        // ���Ű
        private string SecretKey = "SwWxqU+0TErBXy/9TVjIPEnI0VTUMMSQZtJf3Ed8q3I=";

        // ���ݿ����� ���� ��ü ����
        public static CashbillService cashbillService;

        protected void Application_Start(object sender, EventArgs e)
        {
            // ���ݿ����� ���� ��ü �ʱ�ȭ
            cashbillService = new CashbillService(LinkID, SecretKey);

            // ����ȯ�� ������, ���߿�(true), �����(false)
            cashbillService.IsTest = true;

            // ������ū IP ���ѱ�� ��뿩��, ����(true)
            cashbillService.IPRestrictOnOff = true;

            // �˺� API ���� ���� IP ��뿩��, true-���, false-�̻��, �⺻��(false)
            cashbillService.UseStaticIP = false;

            // ���ü��� �ð� ��� ���� true-���, false-�̻��, �⺻��(false)
            cashbillService.UseLocalTimeYN = true;
        }
    }
}