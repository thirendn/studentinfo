using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginApp
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }
    public class MMysql
    {
      MySqlConnection MyConn2 = null;
      public void mysqlConnection(string ConnStr)
      {
        MyConn2 = new MySqlConnection(ConnStr);
      }
      public bool mysqlInsert(string qry)
      {
        try
        {
          string Query = qry;
          MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
          MySqlDataReader MyReader2;
          MyConn2.Open();
          MyReader2 = MyCommand2.ExecuteReader();
          MyConn2.Close();
          return true;
        }
        catch (Exception ex)
        {
          return false;
        }

        return true;
      }

    }
    MMysql mMysql = null;

    MySqlConnection MyConn2 = null;

    public void mysqlConnection(string ConnStr)
    {
      MyConn2 = new MySqlConnection(ConnStr);
    }
    public bool mysqlQuery(string qry)
    {
      try
      {
        string Query = qry;
        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
        MySqlDataReader MyReader2;
        MyConn2.Open();
        MyReader2 = MyCommand2.ExecuteReader();
        MyConn2.Close();
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }

      return true;
    }


    private void button1_Click(object sender, EventArgs e)
    {
      bool ok = mysqlQuery("insert into dawoon.studentinfo(idStudentInfo,Name,Father_Name,Age,Semester) values('" + this.IdTextBox.Text + "','" + this.NameTextBox.Text + "','" + this.FnameTextBox.Text + "','" + this.AgeTextBox.Text + "','" + this.SemesterTextBox.Text + "');");
      showMessage(ok, "저장");

    }

    private void button2_Click(object sender, EventArgs e)
    {
      string Query = "update dawoon.studentinfo set idStudentInfo='" + this.IdTextBox.Text + "',Name='" + this.NameTextBox.Text + "',Father_Name='" + this.FnameTextBox.Text + "',Age='" + this.AgeTextBox.Text + "',Semester='" + this.SemesterTextBox.Text + "' where idStudentInfo='" + this.IdTextBox.Text + "';";
      bool ok=mysqlQuery(Query);
      showMessage(ok, "변경");

    }

    public void showMessage(bool ok, string txt)
    {
      if (ok) MessageBox.Show("테이블 "+ txt+"성공");
      else MessageBox.Show("테이블 " + txt + " 실패");
    }

    private void button3_Click(object sender, EventArgs e)
    {
        string Query = "delete from dawoon.studentinfo where idStudentInfo='" + this.IdTextBox.Text + "';";
      bool ok = mysqlQuery(Query);
      showMessage(ok, "삭제");
    }

    private void button4_Click(object sender, EventArgs e)
    {
      try
      {
        string Query = "select * from dawoon.studentinfo;";
        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
        MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        MyAdapter.SelectCommand = MyCommand2;
        DataTable dTable = new DataTable();
        MyAdapter.Fill(dTable);
        dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                           // MyConn2.Close();  
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      //mysqlConnection("datasource=localhost;port=3306;username=root;password=ekdnsel");

      mMysql.mysqlConnection("datasource=localhost;port=3306;username=root;password=ekdnsel");

    }
  }
}
