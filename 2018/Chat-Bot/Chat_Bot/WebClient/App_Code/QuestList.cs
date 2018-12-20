using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
/// <summary>
/// Сводное описание для QuestList
/// </summary>
public class QuestList 
{
    //static readonly string SqlConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\App_Data\Question.mdf;Integrated Security=True";
    
    //public List<Questions> GetClients()
    //{
    //    List<Questions> listQues = new List<Questions>();
    //    SqlConnection conn = new SqlConnection(SqlConnection);
    //    conn.Open();
    //    SqlCommand command = new SqlCommand("Select * from Questions", conn);
    //    SqlDataReader reader = command.ExecuteReader();
    //    if (reader.HasRows)
    //    {
    //        while (reader.Read())
    //        {
    //            Questions questions = new Questions();
    //            questions.Quest = reader.GetValue(0).ToString();
    //            listQues.Add(questions);
    //        }
    //    }
    //    reader.Close();
    //    conn.Close();
    //    return listQues;
        
    //}
    
}