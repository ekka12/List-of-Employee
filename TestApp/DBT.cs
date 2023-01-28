namespace DBT;
using Dep;
using System.Data;
using MySql.Data.MySqlClient;

public static class DBTManage{
    public static List<Department> GetDepartments(){
        List<Department>dlist = new List<Department>();

        string constr=@"server=192.168.10.109;user=dac41;password=welcome;database=dac41";
        MySqlConnection con=new MySqlConnection(constr);
        string query = "select * from Department";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        MySqlDataReader reader=cmd.ExecuteReader();
        while(reader.Read()){
            int Depid=int.Parse(reader["id"].ToString());
            string name=reader["name"].ToString();
            string location=reader["location"].ToString();
             Department dep=new Department{Id=Depid,Name=name,Location=location};
             dlist.Add(dep);
        }
        con.Close();
        return dlist;
    }
    public static Department GetById(int id){
        Department dept=null;
        string constr=@"Server=192.168.10.109;user=dac41;password=welcome;database=dac41";
        MySqlConnection con=new MySqlConnection(constr);
        string query="Select * from Department where id="+id;
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
         MySqlDataReader reader=cmd.ExecuteReader();
        while(reader.Read()){
            int Depid=int.Parse(reader["id"].ToString());
            string name=reader["name"].ToString();
            string location=reader["location"].ToString();
            dept=new Department{Id=Depid,Name=name,Location=location};
             
        }
        con.Close();
        return dept;



    }

    public static bool Insert(Department dept){
        bool status = false;
        string url=@"Server=192.168.10.109;user=dac41;password=welcome;database=dac41";
        MySqlConnection con = new MySqlConnection(url);
        string query="insert into Department(id,name,location) values('"+dept.Id+"','"+dept.Name+"','"+dept.Location+"')";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        cmd.ExecuteNonQuery();
        status=true;
        con.Close();
        return status;


    }
}
