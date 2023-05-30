package hello.hellospring.service;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.node.ObjectNode;
import hello.hellospring.DTO.HelloDTO;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.datasource.DriverManagerDataSource;
import org.springframework.stereotype.Service;

import javax.sql.DataSource;
import java.io.UnsupportedEncodingException;
import java.nio.charset.StandardCharsets;
import java.util.*;

@Service
public class HelloService {
    DataSource dataSource = new DriverManagerDataSource("jdbc:mysql://database.cv7tztt1jtpd.ap-northeast-2.rds.amazonaws.com:3306/person", "admin", "1q2w3e4r");
    @Autowired
    private final JdbcTemplate jdbcTemplate= new JdbcTemplate(dataSource);

    public String[] SplitData(String data)
    {
        String[] split_Data = data.split("//");
        return split_Data;
    }

    public void UserInfo_add(HelloDTO.UserInfoDTO DTO)
    {
        String sql = String.format("Call InsertUser(%d, \"%s\", %d, %d, %d, %d,%d,\"%s\",\"%s\",\"%s\",%d)",DTO.getEmployeeNumber(),DTO.getName(),DTO.getPW(),DTO.getAuthority(),
                DTO.getTeam(), DTO.getJG(),DTO.getBirth(),DTO.getAddr(), DTO.getTel(), DTO.getMail(), DTO.getDoE());
        jdbcTemplate.update(sql);
    }



    public void createData(String table, String data) {
        String[] userInfoSplit = SplitData(data);
        String sql = "";
        if(Objects.equals(table, "UserInfo"))
        {
            sql = String.format("Call InsertUser(%s, \"%s\", %s, %s, %s, %s,%s,%s,%s,%s,%s)",
                    userInfoSplit[0],userInfoSplit[1],userInfoSplit[2],userInfoSplit[3],userInfoSplit[4],userInfoSplit[5],userInfoSplit[6],userInfoSplit[7]
                    ,userInfoSplit[8],userInfoSplit[9],userInfoSplit[10]);
        }
//        else if(Objects.equals(table, ))
        jdbcTemplate.update(sql);
    }

    // Read
    public String getAllData(String table) throws JsonProcessingException {
        String sql = String.format("SELECT * FROM %s",table);
        return sqlToDataAll(sql);
    }

//    public String getEmployeeNumber(String name) throws JsonProcessingException{
//        String sql = String.format("SELECT employeeNumber FROM UserInfo WHERE name = \"%s\"",name);
//        return sqlToData(sql);
//    }

    public String getAllDataElectric(String table, int state, int page) throws JsonProcessingException {
        String sql;
        if(state == 1)
        {
            sql = String.format("SELECT id, writer, title, date, type \n" +
                    "FROM (\n" +
                    "    SELECT id, writer, title, date, type FROM ApplicationForLeave WHERE state = %d or state = %d\n" +
                    "    UNION\n" +
                    "    SELECT id, writer, title, date, type FROM Draft WHERE state = %d or state = %d\n" +
                    "    UNION\n" +
                    "    SELECT id, writer, title, date, type FROM journal WHERE state = %d or state = %d\n" +
                    ") AS t\n" +
                    "ORDER BY date DESC LIMIT %d,20;",state,state+1,state,state+1,state,state+1, (page-1)*20);
        }
        else {
            sql = String.format("SELECT id, writer, title, date, type \n" +
                    "FROM (\n" +
                    "    SELECT id, writer, title, date, type FROM ApplicationForLeave WHERE state = %d\n" +
                    "    UNION\n" +
                    "    SELECT id, writer, title, date, type FROM Draft WHERE state = %d\n" +
                    "    UNION\n" +
                    "    SELECT id, writer, title, date, type FROM journal WHERE state = %d\n" +
                    ") AS t\n" +
                    "ORDER BY date DESC LIMIT %d,20;",state, state, state, (page-1)*20);
        }
        return sqlToDataAll(sql);
    }

    public String getAllDataElectricSelf(String table, String writer, int state, int page) throws JsonProcessingException {
        String sql;
        if(state == 1)
        {
            sql = String.format("SELECT id, writer, title, date, type \n" +
                    "FROM (\n" +
                    "    SELECT id, writer, title, date, type FROM ApplicationForLeave WHERE writer = \"%s\" and (state = %d or state = %d)\n" +
                    "    UNION\n" +
                    "    SELECT id, writer, title, date, type FROM Draft WHERE writer = \"%s\" and (state = %d or state = %d)\n" +
                    "    UNION\n" +
                    "    SELECT id, writer, title, date, type FROM journal WHERE writer = \"%s\" and (state = %d or state = %d)\n" +
                    ") AS t\n" +
                    "ORDER BY date DESC LIMIT %d,20;",writer, state,state+1,writer,  state,state+1,writer,  state,state+1,(page-1)*20);
        }
        else {
            sql = String.format("SELECT id, writer, title, date, type \n" +
                    "FROM (\n" +
                    "    SELECT id, writer, title, date, type FROM ApplicationForLeave WHERE writer = \"%s\" and state = %d\n" +
                    "    UNION\n" +
                    "    SELECT id, writer, title, date, type FROM Draft WHERE writer = \"%s\" and state = %d\n" +
                    "    UNION\n" +
                    "    SELECT id, writer, title, date, type FROM journal WHERE writer = \"%s\" and state = %d\n" +
                    ") AS t\n" +
                    "ORDER BY date DESC LIMIT %d,20;",writer, state,writer, state,writer, state, (page-1)*20);
        }
        return sqlToDataAll(sql);
    }

    public String getElectric(String table, String id) throws JsonProcessingException {
        String sql = String.format("SELECT * FROM person.%s where id = \"%s\"",table, id);
        return sqlToData(sql);
    }

    public String getQRdate(String table, int id, int date) throws JsonProcessingException {
        String sql = String.format("SELECT * FROM person.%s where employeeNumber= %d and date= %d",table, id, date);
        return sqlToData(sql);
    }

    public String getQRdateAll(String table, int id) throws JsonProcessingException {
        String sql = String.format("SELECT * FROM person.%s where employeeNumber= %d",table, id);
        return sqlToDataAll(sql);
    }

    public String getAllQR(String table, int id) throws JsonProcessingException {
        String sql = String.format("SELECT * FROM person.%s where date= %d;",table, id);
        return sqlToDataAll(sql);
    }
////////////////////TODO
    public String getALLElectricTeam(String table, String team, int state, int page) throws JsonProcessingException
    {
        String sql;
        if(state == 1)
        {
            sql = String.format("SELECT id, writer, title, date, type \n" +
                    "FROM (\n" +
                    "    SELECT id, writer, title, date, type FROM ApplicationForLeave WHERE team = \"%s\" and (state = %d or state = %d)\n" +
                    "    UNION\n" +
                    "    SELECT id, writer, title, date, type FROM Draft WHERE team = \"%s\" and  (state = %d or state = %d)\n" +
                    "    UNION\n" +
                    "    SELECT id, writer, title, date, type FROM journal WHERE team = \"%s\" and (state = %d or state = %d)\n" +
                    ") AS t\n" +
                    "ORDER BY date DESC LIMIT %d,20;",team, state,state +1,team, state,state +1,team,state,state+1,(page-1)*20);
        }
        else
        {
            sql = String.format("SELECT id, writer, title, date, type \n" +
                    "FROM (\n" +
                    "    SELECT id, writer, title, date, type FROM ApplicationForLeave WHERE team = \"%s\" and state = %d\n" +
                    "    UNION\n" +
                    "    SELECT id, writer, title, date, type FROM Draft WHERE team = \"%s\" and state = %d\n" +
                    "    UNION\n" +
                    "    SELECT id, writer, title, date, type FROM journal WHERE team = \"%s\" and state = %d\n" +
                    ") AS t\n" +
                    "ORDER BY date DESC LIMIT %d,20;",team, state,team, state,team, state, (page-1)*20);
        }
        return sqlToDataAll(sql);
    }

    public String getData(String table, int num) throws JsonProcessingException {
        String sql = String.format("SELECT * FROM %s WHERE employeeNumber = %d",table, num);
        return sqlToData(sql);
    }

    public String getMemo(String table, int num, int date) throws JsonProcessingException {
        String sql = String.format("SELECT Memo FROM person.%s WHERE employeeNumber = %d and Mdate = %d", table, num, date);
        return sqlToData(sql);
    }
    public void addMemo_delete(int num, int date)
    {
        String sql = String.format("DELETE person.MyPage FROM person.MyPage JOIN (SELECT id FROM person.MyPage WHERE employeeNumber =" +
                " %d AND Mdate = %d) AS subquery ON person.MyPage.id = subquery.id;",num, date);
        jdbcTemplate.update(sql);
    }

    public void addMemo_insert(int num, int date, String memo)
    {
        String sql = String.format("call InsertMemo(%d, %d, \"%s\")", num, date, memo);
        jdbcTemplate.update(sql);
    }



    public void AddNotice(int num, String name, String title, String content, int wdate, String division, String id)
    {
        String sql = String.format("Call InsertNoticeBoard(%d, \"%s\", \"%s\", \"%s\", %d, \"%s\", \"%s\")", num,name, title,content,wdate,division,id);
        jdbcTemplate.update(sql);
    }

    public void AddApplicationForLeave(String Writer, String team, String title, int startdate, int endDate, String emergencyTel, String reason, String id, int state, int type, int date)
    {
        String sql = String.format("call InsertApplicationForLeave(\"%s\",\"%s\",\"%s\",%d,%d,\"%s\",\"%s\",\"%s\",%d,%d,%d)",Writer, team, title,startdate,endDate,
                emergencyTel,reason,id, state,type,date);
        jdbcTemplate.update(sql);
    }

    public void Addjournal(String title, String writer, String team, String  JG, int date, String morning, String afternoon, String significant, String untreated, String id,
                           int state, int type)
    {
        String sql = String.format("call InsertJournal(\"%s\",\"%s\",\"%s\",\"%s\",%d,\"%s\",\"%s\",\"%s\",\"%s\",\"%s\",%d,%d)",title,
                writer, team, JG, date, morning, afternoon,significant,untreated,id,state,type);
        jdbcTemplate.update(sql);
    }

    public void AddDraft(int number, String team, String JG, String writer, int date, String title, String remarks, String detail, String id, int state, int type)
    {
        String sql = String.format("call InsertDraft(%d,\"%s\",\"%s\",\"%s\",%d,\"%s\",\"%s\",\"%s\",\"%s\",%d,%d)",number,team,JG,
                writer, date,title,remarks, detail,id,state,type);
        jdbcTemplate.update(sql);
    }

    public void AddPost(int num, String name, String title, String content, int wdate, String division, String id) {
        String sql = String.format("Call InsertFreeBoard(%d, \"%s\", \"%s\", \"%s\", %d, \"%s\", \"%s\")", num, name, title, content, wdate, division, id);
        this.jdbcTemplate.update(sql);
    }

    public void AddAnnualLeave(int num, int start, int end)
    {
        String sql = String.format("Call InsertAnnualLeave(%d, %d, %d)", num, start, end);
        jdbcTemplate.update(sql);
    }
    public void AddQrcode(int num, int date,int start, int end)
    {
        String sql = String.format("Call InsertQrcode(%d, %d, %d, %d)", num, date ,start, end);
        jdbcTemplate.update(sql);
    }

    public void AddTeam(int teamID,String team, String teamDOC)
    {
        String sql = String.format("Call InsertTeam(%d, \"%s\", \"%s\")", teamID, team, teamDOC);
        jdbcTemplate.update(sql);
    }

    public void AddLeaveCount(int num, int count)
    {
        String sql = String.format("Call InsertLeaveCount(%d, %d)", num, count);
        jdbcTemplate.update(sql);
    }

    public String getBoard(String table, int page) throws JsonProcessingException {
        String sql = String.format("SELECT * FROM %s order by wdate desc limit %d,20", table, (page-1)*20);
        return sqlToDataAll(sql);
    }


    public String getBoardContent(String table, String id) throws JsonProcessingException {
        String sql = String.format("SELECT * FROM %s WHERE id = \"%s\"", table, id);
        return sqlToData(sql);
    }

    public String getElectronicPayment(String table) throws JsonProcessingException {
        String sql = String.format("SELECT * FROM %s", table);
        return sqlToDataAll(sql);
    }

    public String sqlToData(String sql) throws JsonProcessingException {
        List<Map<String, Object>> rows = jdbcTemplate.queryForList(sql);
        ObjectMapper objectMapper = new ObjectMapper();
        return objectMapper.writeValueAsString(rows.get(0));
    }

    public String sqlToDataAll(String sql) throws JsonProcessingException {
        List<Map<String, Object>> rows = jdbcTemplate.queryForList(sql);
        ObjectMapper objectMapper = new ObjectMapper();
        return objectMapper.writeValueAsString(rows);
    }


    // Update
    public void updateData(String table, String column, String data, int num) {
        String sql;
        try{
            int dataToInt = Integer.parseInt(data);
            sql = String.format("UPDATE %s SET %s = %d WHERE employeeNumber= %d", table, column, dataToInt, num);
        }
        catch (NumberFormatException ex){
            sql = String.format("UPDATE %s SET %s = \"%s\" WHERE employeeNumber= %d", table, column, data, num);
        }
        jdbcTemplate.update(sql);
    }

    public void updateState(String table, int state, String id)
    {
        String sql = String.format("UPDATE %s SET state = %d WHERE id = \"%s\"", table, state, id);
        jdbcTemplate.update(sql);
    }

    public void updateTeam(int teamID, String change)
    {
        String sql = String.format("UPDATE Team SET team = \"%s\" WHERE teamID = %d", change,teamID);
        jdbcTemplate.update(sql);
    }
    // Delete
    public void deleteDataInt(String table_name, int number) {
        String sql = String.format("DELETE FROM person." +table_name+ " WHERE employeeNumber = %d",number);
        jdbcTemplate.update(sql);
    }
    public void deleteLeave(String table, int num, int start, int end)
    {
        String sql = String.format("DELETE person.%s \n" +
                "FROM person.AnnualLeave \n" +
                "JOIN (SELECT num FROM person.AnnualLeave WHERE employeeNumber = %d AND start = %d and end = %d) AS subquery \n" +
                "ON person.AnnualLeave.num = subquery.num;",table,num,start,end);
        jdbcTemplate.update(sql);
    }

    public void deleteTeam(int teamID)
    {
        String sql = String.format("DELETE FROM person.Team WHERE teamID = %d",teamID);
        jdbcTemplate.update(sql);
    }
    public void deleteQrcode(String table, int num,int date)
    {
        String sql = String.format("DELETE person.%s \n" +
                "FROM person.Qrcode \n" +
                "JOIN (SELECT num FROM person.Qrcode WHERE employeeNumber = %d AND date = %d) AS subquery \n" +
                "ON person.Qrcode.num = subquery.num;",table,num,date);
        jdbcTemplate.update(sql);
    }
    public void deleteDataString(String table_name, String number) {
        String sql = String.format("DELETE FROM person." +table_name+ " WHERE id = \"%s\"",number);
        jdbcTemplate.update(sql);
    }

    public void UpdateImage(String name, String menu,int number ,byte[] imageBytes) {
        //String byteHex = bytesToHex(imageBytes);
        String sql = String.format("UPDATE %s SET %s = ? WHERE employeeNumber = ?",name,menu);
        jdbcTemplate.update(sql, imageBytes, number);
    }

    public ObjectNode ReadImage(String table_name, int number) throws JsonProcessingException {
        String sql = String.format("SELECT img From person.%s WHERE employeeNumber = %d", table_name, number);
        byte[] imageData = jdbcTemplate.queryForObject(sql, byte[].class);
        String encoded = Base64.getEncoder().encodeToString(imageData);
        ObjectMapper objectMapper = new ObjectMapper();
        ObjectNode jsonNode = objectMapper.createObjectNode();
        jsonNode.put("img", encoded);
        return jsonNode;
    }
    public String getInfoData(int employeeNumber, int PW) throws JsonProcessingException {
        String sql = String.format("SELECT employeeNumber, PW FROM person.UserInfo WHERE employeeNumber = %d AND PW = %d", employeeNumber, PW);
        return sqlToData(sql);
    }

    public void Updateqr(int employeeNumber, byte[] imageBytes) {
        String sql = String.format("UPDATE person.UserInfo SET qrcode = ? WHERE employeeNumber = %d", employeeNumber);
        jdbcTemplate.update(sql, imageBytes);
    }

    public String getId(int employeeNumber, int date) throws JsonProcessingException {
        String sql = String.format("SELECT * FROM person.Qrcode WHERE employeeNumber = %d AND date = %d", employeeNumber, date);
        return sqlToData(sql);
    }

    public String getLeave(int end_time, int num) throws JsonProcessingException {
        String sql = String.format("UPDATE person.Qrcode SET end_time = %d WHERE num = %d", end_time, num);
        try {
            jdbcTemplate.update(sql);
            return "Success";
        } catch (Exception e) {
            return "Failed";
        }
    }
    public void InsertInfo(int employeeNumber, int date, int start_time) {
        String sql = String.format("insert into person.Qrcode(employeeNumber, date, start_time) values(%d,%d,%d);", employeeNumber, date, start_time);
        jdbcTemplate.update(sql);
    }
    // 박쥐
    public String ReadUserInfoTeam(int team, int page) throws JsonProcessingException {
        String sql = String.format("SELECT * FROM person.UserInfo WHERE team = %d ORDER BY employeeNumber LIMIT %d, 20" , team, (page-1)*20);
        return sqlToDataAll(sql);
    }
    public String getUserInfo(int page) throws JsonProcessingException {
        String sql = String.format("SELECT * FROM person.UserInfo order by employeeNumber LIMIT %d,20", (page-1)*20);
        return sqlToDataAll(sql);
    }

    public String getSearchBoard(String table, String division,String str, int page) throws JsonProcessingException {
        String sql = String.format("SELECT * FROM %s where %s like \"%%%s%%\" order by wdate desc limit %d,20", table,division,str ,(page-1)*20);
        return sqlToDataAll(sql);
    }
    public String getFreeBoard(String table, String team, int page) throws JsonProcessingException {
        String sql = String.format("SELECT * FROM %s where division= \"자유\" or division=\"%s\" order by wdate desc limit %d,20", table, team, (page-1)*20);
        return sqlToDataAll(sql);
    }

    public String getSearchFreeBoard(String table, String division,String str, int page, String team) throws JsonProcessingException {
        String sql = String.format("SELECT * FROM %s where %s like \"%%%s%%\" and (division=\"자유\" or division=\"%s\") order by wdate desc limit %d,20", table,division,str, team ,(page-1)*20);
        return sqlToDataAll(sql);
    }
}
