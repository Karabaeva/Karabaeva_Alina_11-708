using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuestionsHelper;
using System.Data.SqlClient;

public partial class Testat : System.Web.UI.Page
{
    int step = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        Bot.Text = "Привет! Я Бот Настроения! Хочешь пройти тест?";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        BotRe.Text = "Хорошо ) Давай начнем! Введите свое имя:";
        if (Answer.Visible == false)
            Answer.Visible = true;
    }
    protected void Answer_Click(object sender, EventArgs e)
    {
        Label1.Text = "Еще раз привет! Начинаааааем )))";
        //QuestList questList = new QuestList();    //Считывание с БД
        //questList.GetClients();
        //var r = questList.GetClients();
        //foreach (var l in r)
        //{                                    
        //    quest1.Text = r;
        //}
        if (no.Visible == false && yes1.Visible == false)
        {
            no.Visible = true;
            yes1.Visible = true;
        }
        quest1.Text = "Чувствую беспокойство и не могу усидеть на месте.";  
       
    }

    protected void yes1_Click(object sender, EventArgs e)
    {
        step += 10;
        bot1.Text = "Я живу достаточно полной жизнью.";
        no2.Visible = true;
        yes2.Visible = true;
    }

    protected void yes2_Click(object sender, EventArgs e)
    {
        step += 10;
        bot2.Text = "Чувствую себя исключительно бодро";
        no3.Visible = true;
        yes3.Visible = true;
    }

    protected void yes3_Click(object sender, EventArgs e)
    {
        step += 10;
        bot3.Text = "Не вижу впереди никаких трудностей. Все легко! Все доступно!";
        no4.Visible = true;
        yes4.Visible = true;
    }

    protected void yes4_Click(object sender, EventArgs e)
    {
        step += 10;
        if (step > 30 && step <= 40)
         End.Text = "Ты счастлив на 100% !!";
        else if (step > 0 && step <= 20)
            End.Text = "Ты счастлив только на 10% :С";
        else if (step > 20 && step <= 30)
            End.Text = "Ты счастлив на 50%";
    }

    protected void no_Click(object sender, EventArgs e)
    {
        step += 5;
        bot1.Text = "Я живу достаточно полной жизнью.";
        no2.Visible = true;
        yes2.Visible = true;
    }

    protected void no2_Click(object sender, EventArgs e)
    {
        step += 5;
        bot2.Text = "Чувствую себя исключительно бодро";
        no3.Visible = true;
        yes3.Visible = true;
    }

    protected void no3_Click(object sender, EventArgs e)
    {
        step += 5;
        bot3.Text = "Не вижу впереди никаких трудностей. Все легко! Все доступно!";
        no4.Visible = true;
        yes4.Visible = true;
    }

    protected void no4_Click(object sender, EventArgs e)
    {
        step += 5;
        if (step > 30 && step <= 40)
            End.Text = "Ты счастлив на 100% !!";
        else if (step > 0 && step <= 20)
            End.Text = "Ты счастлив только на 10% :С";
        else if (step > 20 && step <= 30)
            End.Text = "Ты счастлив на 50%";
    }
}