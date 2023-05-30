using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using System.Security.Policy;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.AxHost;
using Google.Protobuf.WellKnownTypes;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace F_Final_Project
{
    public class RDSserver
    {
        string ip = "http://13.209.6.6:8080"; // ec2 java

        public RDSserver()
        {
            List<JObject> list = Readdic_database("Team");
            foreach (JObject i in list)
            {
                try
                {
                    team_dic.Add(Convert.ToInt32(i["teamID"]), i["team"].ToString());
                    teamDoc_dic.Add(i["team"].ToString(), i["DocChar"].ToString());
                }
                catch { }
            }
        }

        public Dictionary<int, string> JG_dic = new Dictionary<int, string>()
        {
            {0, "사장" },
            {1, "상무" },
            {2, "이사" },
            {3, "부장" },
            {4, "차장" },
            {5, "과장" },
            {6, "대리" },
            {7, "사원" },
        };
        public Dictionary<int, string> team_dic = new Dictionary<int, string>();
        public Dictionary<string, string> teamDoc_dic = new Dictionary<string, string>();
        public Dictionary<int, string> authority_dic = new Dictionary<int ,string>()
        {
            {2,"사원" },
            {1,"팀장급" },
            {0 , "관리자" }
        };

        // database C.R.U.D
        public void Create_database(List<object> list, string tableType) // tableType =  "UserInfo"
        {
            if (tableType == "UserInfo")
            {
                string url = string.Format("{0}/AddUserInfo", ip);
                using (var client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";

                    var data = new
                    {
                        employeeNumber = Convert.ToInt32(list[0]),
                        name = Convert.ToString(list[1]),
                        PW = Convert.ToInt32(list[2]),
                        authority = Convert.ToInt32(list[3]),
                        team = Convert.ToInt32(list[4]),
                        JG = Convert.ToInt32(list[5]),
                        birth = Convert.ToInt32(list[6]),
                        addr = Convert.ToString(list[7]),
                        tel = Convert.ToString(list[8]),
                        mail = Convert.ToString(list[9]),
                        DoE = Convert.ToInt32(list[10])
                    };

                    string json = JsonConvert.SerializeObject(data);
                    string result = client.UploadString(url, json);
                }
            }
            else if (tableType == "NoticeBoard")
            {
                string url = string.Format("{0}/Addnotice", ip);
                using (var client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    var data = new { num = list[0], name = list[1], title = list[2], content = list[3], wdate = list[4], division = list[5], id = list[6] };

                    string json = JsonConvert.SerializeObject(data);
                    string result = client.UploadString(url, json);
                }
            }
            else if (tableType == "FreeBoard")
            {
                string url = string.Format("{0}/Addpost", ip);
                using (var client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    var data = new { num = list[0], name = list[1], title = list[2], content = list[3], wdate = list[4], division = list[5], id = list[6] };

                    string json = JsonConvert.SerializeObject(data);
                    string result = client.UploadString(url, json);
                }
            }
            else if (tableType == "AnnualLeave")
            {
                string url = string.Format("{0}/AddAnnualLeave", ip);
                using (var client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    var data = new { num = list[0], start = list[1], end = list[2]}; // int int int 

                    string json = JsonConvert.SerializeObject(data);
                    string result = client.UploadString(url, json);
                }
            }
            else if(tableType == "LeaveCount")
            {
                string url = string.Format("{0}/AddLeaveCount", ip);
                using (var client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    var data = new { num = list[0], count = list[1]}; // int int 

                    string json = JsonConvert.SerializeObject(data);
                    string result = client.UploadString(url, json);
                }
            }
            else if(tableType == "Qrcode")
            {
                string url = string.Format("{0}/AddQrcode", ip);
                using (var client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    var data = new { num = list[0], date = list[1], start = list[2], end = list[3] }; // int int int int

                    string json = JsonConvert.SerializeObject(data);
                    string result = client.UploadString(url, json);
                }
            }
            else if(tableType == "Team")
            {
                string url = string.Format("{0}/AddTeam", ip);
                using (var client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    var data = new { teamID = list[0], team = list[1].ToString(), teamDOC = list[2].ToString() }; // int string string

                    string json = JsonConvert.SerializeObject(data);
                    string result = client.UploadString(url, json);
                }
            }
        }

        public void Create_database(int employeeNumber, string Mdate, string Memo) // MyPage memo Create
        {
            string url = string.Format("{0}/AddMemo", ip);

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";

                var data = new { num = employeeNumber, date = Convert.ToInt32(Mdate), memo = Memo };

                string json = JsonConvert.SerializeObject(data);
                string result = client.UploadString(url, json);
            }
        }

        public List<JObject> Search_database(string table, string division, string str, int page,string team="") // Board SearchRead
        {
            List<JObject> obj= new List<JObject>();
            string url="";
            if (table == "NoticeBoard")
            {
                url = string.Format("{0}/SearchBoard?table={1}&division={2}&str={3}&page={4}", ip, table,division,str,page);
            }
            else if(table == "FreeBoard")
            {
                if(team=="")
                {
                    url = string.Format("{0}/SearchBoard?table={1}&division={2}&str={3}&page={4}", ip, table, division, str, page);
                }
                else
                {
                    url = string.Format("{0}/SearchFreeBoard?table={1}&division={2}&str={3}&page={4}&team={5}", ip, table, division, str, page,team);
                }
            }
            obj = CallApis(url);
            return obj;
        }

        public List<JObject> Readdic_database(string table_name, int state=0, int num=0, int page=0)  // Board Read
        {
            string url;
            List<JObject> list = new List<JObject>();

            if (table_name == "NoticeBoard")
            {
                url = string.Format("{0}/ReadBoard?table={1}&page={2}", ip, table_name,state);
            }
            else if(table_name == "FreeBoard")
            {
                if(num==0)
                {
                    url = string.Format("{0}/ReadBoard?table={1}&page={2}", ip, table_name, state);
                }
                else
                {
                    url = string.Format("{0}/ReadFreeBoard?table={1}&team={2}&page={3}", ip, table_name, team_dic[state] ,num);
                }
            }
            else if(table_name == "ApplicationForLeave" || table_name == "Draft" || table_name == "journal" && state != -1)
            {
                url = string.Format("{0}/ReadAllElectric?table={1}&state={2}&page={3}", ip, table_name,state.ToString(),page);
            }
            else if(table_name == "Qrcode") // one people all attendance
            {
                if(state==0) 
                    url = string.Format("{0}/ReadQRdateAll?table={1}&id={2}", ip, table_name, num.ToString());
                else
                    url = string.Format("{0}/ReadAllQR?table={1}&date={2}", ip, table_name, num.ToString());
            }
            else if(table_name=="UserInfo")
            {
                if(state==0)
                    url = string.Format("{0}/ReadAll?table={1}", ip, table_name);
                else
                    url = string.Format("{0}/ReadUserInfo?table={1}&page={2}", ip, table_name, state);
            }
            else
            {
                url = string.Format("{0}/ReadAll?table={1}", ip,table_name);
            }

            list = CallApis(url);

            return list;
        }

        public List<JObject> Readdic_database(string table, string name, int state , string division="", int page=0) // Electric, UserInfo team Read
        {
            string url;
            List<JObject> list = new List<JObject>();

            if (division == "writer")
            {
                url = string.Format("{0}/ReadDataElectricSelf?table={1}&writer={2}&state={3}&page={4}", ip, table, name,state,page);
                list = CallApis(url);
            }
            else if(division == "team")
            {
                url = string.Format("{0}/ReadElectricTeam?table={1}&team={2}&state={3}&page={4}", ip, table, name,state,page);
                list = CallApis(url);
            }

            else if(table == "UserInfo")
            {
                url = string.Format("{0}/ReadUserInfoTeam?team={1}&page={2}", ip,team_dic.FirstOrDefault(x=>x.Value==name).Key, state);
                list = CallApis(url);
            }

            return list;
        }

        public JObject Read_database2(string table, string id,int date=0) // Electric search Read, UserInfo one Read
        {
            JObject obj = null;
            string url="";

            if (table == "ApplicationForLeave" || table == "Draft" || table == "journal")
            {
                url = string.Format("{0}/ReadElectric?table={1}&id={2}", ip, table,id);
                obj = CallApiJ(url);
            }
            else if(table == "Qrcode")
            {
                url = string.Format("{0}/ReadQRdate?table={1}&id={2}&date={3}", ip, table, id, date);
                obj = CallApiJ(url);
            }
            else
            {
                url = string.Format("{0}/Read?table={1}&num={2}", ip, table, id);
                obj = CallApiJ(url);
            }

            return obj;
        }

        public JObject ReademployeeNumber(string name)
        {
            JObject result=null;
            List<JObject> list = Readdic_database("UserInfo");

            foreach(JObject item in list)
            {
                if (item["name"].ToString() == name)
                {
                    result = item;
                    break;
                }
            }
            return result;
        }

        public List<object> Read_database(string table_name, int num, string Mdate = null) // use form: ShowWorker, Login, MyPage
        {
            List<object> list = new List<object>();
            Dictionary<string, object> result = new Dictionary<string, object>();

            string url;

            if (table_name == "MyPage")
            {
                url = string.Format("{0}/ReadMemo?table=MyPage&num={1}&date={2}", ip, num.ToString(), Mdate);
            }
            else
            {
                url = string.Format("{0}/Read?table={1}&num={2}", ip, table_name, num.ToString());
            }
            result = CallApi(url);


            try
            {
                if (table_name == "UserInfo")
                {
                    list.Add(result["employeeNumber"]);
                    list.Add(result["name"]);
                    list.Add(result["PW"]);
                    list.Add(result["authority"]);
                    list.Add(team_dic[Convert.ToInt32(result["team"])]);
                    list.Add(JG_dic[Convert.ToInt32(result["JG"])]);
                    list.Add(result["birth"]);
                    list.Add(result["addr"]);
                    list.Add(result["tel"]);
                    list.Add(result["mail"]);
                    list.Add(result["DoE"]);

                }
                else if (table_name == "MyPage")
                {
                    list.Add(result["Memo"]);
                }
                else if (table_name == "ElectronicPayment")
                {
                    list.Add(result["employeeNumber"]);
                    list.Add(result["docTitle"]);
                    list.Add(result["docContent"]);
                    list.Add(result["docState"]);
                }
                else if (table_name == "NoticeBoard")
                {
                    list.Add(result["employeeNumber"]);
                    list.Add(result["name"]);
                    list.Add(result["title"]);
                    list.Add(result["content"]);
                    list.Add(result["date"]);
                    list.Add(result["division"]);
                    list.Add(result["id"]);
                }
                else if (table_name == "FreeBoard")
                {
                    list.Add(result["employeeNumber"]);
                    list.Add(result["name"]);
                    list.Add(result["title"]);
                    list.Add(result["content"]);
                    list.Add(result["date"]);
                    list.Add(result["division"]);
                    list.Add(result["id"]);
                }
                else if (table_name == "FingerPrint")
                {
                    list.Add(result["emplyeeNumber"]);
                    list.Add(result["start_time"]);
                    list.Add(result["end_time"]);
                    list.Add(result["date"]);
                }

            }
            catch (Exception exc)
            {
                //MessageBox.Show(exc.Message);
            }
            return list;
        }

        public List<object> Read_database(string table_name, string num) // use form: PostBrowse, NoticeBrowse
        {
            List<object> list = new List<object>();
            Dictionary<string, object> result = new Dictionary<string, object>();

            string url = string.Format("{0}/Read?table={1}&num={2}", ip, table_name, num.ToString());
            if (table_name == "NoticeBoard" || table_name == "FreeBoard")
            {
                url = string.Format("{0}/ReadBoardContent?table={1}&id={2}", ip, table_name, num.ToString());
            }
            result = CallApi(url);


            try
            {
                if (table_name == "ElectronicPayment")
                {
                    list.Add(result["employeeNumber"]);
                    list.Add(result["docTitle"]);
                    list.Add(result["docContent"]);
                    list.Add(result["docState"]);
                }
                else if (table_name == "NoticeBoard")
                {
                    list.Add(result["employeeNumber"]);
                    list.Add(result["name"]);
                    list.Add(result["title"]);
                    list.Add(result["content"]);
                    list.Add(result["wdate"]);
                    list.Add(result["division"]);
                    list.Add(result["id"]);
                }
                else if (table_name == "FreeBoard")
                {
                    list.Add(result["employeeNumber"]);
                    list.Add(result["name"]);
                    list.Add(result["title"]);
                    list.Add(result["content"]);
                    list.Add(result["wdate"]);
                    list.Add(result["division"]);
                    list.Add(result["id"]);
                }
                else if (table_name == "FingerPrint")
                {
                    list.Add(result["emplyeeNumber"]);
                    list.Add(result["start_time"]);
                    list.Add(result["end_time"]);
                    list.Add(result["date"]);
                }

            }
            catch (Exception exc)
            {
                //MessageBox.Show(exc.Message);
            }
            return list;
        }
        
        public byte[] ReadImage_database(string table_name, int num)
        {
            byte[] bimage = null;
            try
            {
                string url = string.Format("{0}/ReadImage?table={1}&num={2}", ip, table_name, num.ToString());
                Dictionary<string, object> result = CallApi(url);

                bimage = (byte[])Convert.FromBase64String(result["img"].ToString());

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return bimage;
        }

        public void Update_database(int number, string table_name, string menu, string update)  // ex) menu = select menu / update="update data"
        {
            string url = string.Format("{0}/Update?table={1}&column={2}&data={3}&num={4}", ip, table_name, menu, update, number.ToString());
            Dictionary<string, object> result = CallApi(url);
        }
        public void UpdateTeam_database(string teamname, string change)
        {
            int id = team_dic.FirstOrDefault(x => x.Value == teamname).Key;
            string url = string.Format("{0}/UpdateTeam?teamID={1}&change={2}", ip, id, change);
            Dictionary<string, object> result = CallApi(url);
        }

        public void Updatestate( string table, int state, string id)
        {
            string url = string.Format("{0}/UpdateState?table={1}&state={2}&id={3}", ip, table, state, id );
            Dictionary<string, object> result = CallApi(url);
        }

        public void UpdateImage_database(int number, string table_name, string menu, byte[] update)  // ex) menu = select menu / update="update data"
        {
            string url = string.Format("{0}/UpdateImage", ip);
            string imgjson = Convert.ToBase64String(update);

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";

                var data = new { table = table_name, column = menu, num = number, img = imgjson };

                string json = JsonConvert.SerializeObject(data);
                string result = client.UploadString(url, json);
            }
        }

        public void Delete_database(int number, string table_name) // ex) number = employeenumber / tablename =  "UserInfo"
        {
            if(table_name == "Team")
            {
                string url = string.Format("{0}/DeleteTeam?teamID={1}", ip, number.ToString());
                Dictionary<string, object> result = CallApi(url);
            }
            else
            {
                string url = string.Format("{0}/Delete?table={1}&num={2}", ip, table_name, number.ToString());
                Dictionary<string, object> result = CallApi(url);
            }
        }

        public void Delete_database(string number, string table_name) // ex) number = board id / tablename =  "NoticeBoard" or "FreeBoard"
        {

            string url = string.Format("{0}/Delete?table={1}&num={2}", ip, table_name, number);
            Dictionary<string, object> result = CallApi(url);
        }

        public void Delete_database(List<object> list, string table_name) 
        {
            if(table_name== "AnnualLeave")
            {
                string url = string.Format("{0}/DeleteLeave?table={1}&num={2}&start={3}&end={4}", ip, table_name, list[0].ToString(), list[1].ToString(), list[2].ToString());
                Dictionary<string, object> result = CallApi(url);
            }
            else if(table_name=="Qrcode")
            {
                string url = string.Format("{0}/DeleteQrcode?table={1}&num={2}&date={3}", ip, table_name, list[0].ToString(), list[1].ToString());
                Dictionary<string, object> result = CallApi(url);
            }
        }

        public Dictionary<string, object> CallApi(string url)
        {
            // HTTP 요청 생성
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            try
            {
                // API 호출 및 응답 처리
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // 응답 데이터를 JSON 형식으로 Deserialize
                        Stream responseStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                        string jsonContent = reader.ReadToEnd();
                        Dictionary<string, object> result = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonContent);

                        return result;
                    }
                    else
                    {
                        // 에러 처리
                        throw new Exception($"API 호출에 실패하였습니다. 상태 코드: {response.StatusCode}");
                    }
                }

            }
            catch (Exception ex)
            {
                Dictionary<string, object> a = new Dictionary<string, object>();
                return a;
            }

        }

        public List<JObject> CallApis(string url) // 오류
        {
            // HTTP 요청 생성
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            List<JObject> dic_list = new List<JObject>();
            try
            {
                // API 호출 및 응답 처리
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {                       // 응답 데이터를 JSON 형식으로 Deserialize
                        Stream responseStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                        string jsonContent = reader.ReadToEnd();
                        dic_list = JsonConvert.DeserializeObject<List<JObject>>(jsonContent);
                    }
                    else
                    {
                        // 에러 처리
                        throw new Exception($"API 호출에 실패하였습니다. 상태 코드: {response.StatusCode}");
                    }
                }

            }
            catch (Exception ex)
            {
                List<JObject> a = new List<JObject>();
                return a;
            }


            return dic_list;
        }

        public JObject CallApiJ(string url)
        {
            // HTTP 요청 생성
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            JObject obj  = new JObject();
            try
            {
                // API 호출 및 응답 처리
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // 응답 데이터를 JSON 형식으로 Deserialize

                        Stream responseStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                        string jsonContent = reader.ReadToEnd();
                        obj = JsonConvert.DeserializeObject<JObject>(jsonContent);

                    }
                    else
                    {
                        // 에러 처리
                        throw new Exception($"API 호출에 실패하였습니다. 상태 코드: {response.StatusCode}");
                    }
                }

            }
            catch (Exception ex)
            {
                JObject a = new JObject();
                return a;
            }


            return obj;
        }
    }
}
