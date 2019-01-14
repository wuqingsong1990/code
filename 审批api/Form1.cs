using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace 审批api
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Faqi_Click(object sender, EventArgs e)
        {

            //DefaultDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/gettoken");
            //OapiGettokenRequest request = new OapiGettokenRequest();
            //request.Appkey = "ding4pmpx3dj9azo1k7s";
            //request.Appsecret = "TYETGgC7XXsFB8hfwIg_hSB537kCJQX71O3wcrrqDYY1Gn6xwc3zBWJmfLlxp1Yc";
            //request.SetHttpMethod("GET");
            //OapiGettokenResponse response = client.Execute(request);

            //var bb = response.AccessToken;
            //MessageBox.Show(bb);

            DefaultDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/processinstance/create");
            OapiProcessinstanceCreateRequest request = new OapiProcessinstanceCreateRequest();
            request.AgentId = 41605932L;
            request.ProcessCode = "PROC-BY6LI83V-4R8T1CHNUX58O0Z6C55M3-DTQJJGEJ-1";
            List<OapiProcessinstanceCreateRequest.FormComponentValueVoDomain> formComponentValues = new List<OapiProcessinstanceCreateRequest.FormComponentValueVoDomain>();
            OapiProcessinstanceCreateRequest.FormComponentValueVoDomain vo = new OapiProcessinstanceCreateRequest.FormComponentValueVoDomain();
            vo.Name = "武汉梓金山科技有限公司";
            vo.Value = "test";
            formComponentValues.Add(vo);
            request.FormComponentValues = "formComponentValues";
            request.Approvers = "userid1,userid2";
            request.OriginatorUserId = "userid1";
            request.DeptId = -1L;
            request.CcList = "userid1,userid2";
            request.CcPosition = "START_FINISH";
            string accessToken = AccessToken();

            OapiProcessinstanceCreateResponse response = client.Execute(request, accessToken);
            MessageBox.Show(response.Body);





            //IDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/processinstance/create");
            //SmartworkBpmsProcessinstanceCreateRequest req = new SmartworkBpmsProcessinstanceCreateRequest();
            //req.AgentId = 41605932L;
            //req.ProcessCode = "PROC-EF6YJL35P2-SCKICSB7P750S0YISYKV3-17IBLGZI-1";
            //req.OriginatorUserId = "manager432";
            //req.DeptId = 100L;
            //req.Approvers = "zhangsan,lisi";
            //req.CcList = "zhangsan,lisi";
            //req.CcPosition = "START";
            //List<SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain> list2 = new List<SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain>();
            //SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain obj3 = new SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain();
            //list2.Add(obj3);
            //obj3.Name = "请假类型";
            //obj3.Value = "事假";
            //obj3.ExtValue = "总天数:1";
            //req.FormComponentValues_ = list2;
            //SmartworkBpmsProcessinstanceCreateResponse rsp = client.Execute(req, accessToken);
            //MessageBox.Show(rsp.Body);







        }



        public static string AccessToken() 
        {
            DefaultDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/gettoken");
            OapiGettokenRequest request = new OapiGettokenRequest();
            request.Appkey="ding4pmpx3dj9azo1k7s";
            request.Appsecret="TYETGgC7XXsFB8hfwIg_hSB537kCJQX71O3wcrrqDYY1Gn6xwc3zBWJmfLlxp1Yc";
            request.SetHttpMethod("GET");
            OapiGettokenResponse response = client.Execute(request);
            return response.AccessToken;
        
        } 




    }
}
