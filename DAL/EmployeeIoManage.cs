namespace DAL;
using System.Collections.Generic;
using BOL;
using System.Data;
using MySql.Data.MySqlClient;

public class EmployeeIoManage{
    public List<Employee>Getall(){
        List<Employee>elist=new List<Employee>();
        string url=@"server=192.168.10.109 ; user=dac41 ; password=welcome ; database=dac41";
        MySqlConnection con = new MySqlConnection(url);
        string query = "select * from Employee";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        MySqlDataReader reader = cmd.ExecuteReader();
        while(reader.Read()){
            string sub = reader["subname"].ToString();
            string hod = reader["hod"].ToString();
            Employee e = new Employee{SubName=sub,HOD=hod};
            elist.Add(e);
        }
        con.Close();
        return elist;
    }

    public bool AddEmp(Employee e){
        bool status = false;
        string url = @"server=192.168.10.109 ; user=dac41 ; password=welcome ; database=dac41";
        MySqlConnection con = new MySqlConnection(url);
        string query = "insert into Employee(subname,hod) values('"+e.SubName+"','"+e.HOD+"')";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        cmd.ExecuteNonQuery();
        status = true;
        con.Close();
    
        return status; 

    }
     public bool Remove(string hod){
        bool status = false;
        string url = @"server=192.168.10.109 ; user=dac41 ; password=welcome ; database=dac41";
        MySqlConnection con = new MySqlConnection(url);
        string query = "Delete from Employee where hod ='"+hod+"'";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        cmd.ExecuteNonQuery();
        status = true;
        con.Close();
    
        return status; 

    }
    public bool Edit(string hod,Employee e){
        bool status =false;
        string url=@"server=192.168.10.109;user=dac41 ;password=welcome; database=dac41";
        MySqlConnection con=new MySqlConnection(url);
        string query="update Employee set subname = '"+e.SubName+"', hod ='"+e.HOD+"' where hod='"+hod+"'";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        cmd.ExecuteNonQuery();
        status=true;
        con.Close();
        return status;
    }
}