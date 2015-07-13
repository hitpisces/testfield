using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)//this.Controls是得到当前窗体里的所有控件的集合，Control是一个控件对象（textbox也是控件继承了Control）
            {
                if (c is TextBox)//判断c是不是TextBox类型的
                {
                    TextBox temp = c as TextBox;//如果是则转换为TextBox类型的 （as是转换用的关键字）
                    temp.ReadOnly = true;//这个不用解释了吧
                    textBox1.Text = "haha";
                    textBox2.Text = "hehe";

                }
            } 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;

            string strConnection = "Data Source=ALICE;Initial Catalog=yn;Integrated Security=True";
            SqlConnection lo_con=new SqlConnection (strConnection );
            lo_con .Open ();
            SqlCommand lo_cmd = new SqlCommand(); //创建命令对象
            lo_cmd.CommandText = "select * from site_general where source_type = N'车间'"; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
            DataSet ds = new DataSet(); //创建数据集对象
            dbAdapter.Fill(ds,"searchResult"); //用返回的结果集填充数据集

            lo_con.Close();

            textBox1.Text = ds.Tables["searchResult"].Rows[0][2].ToString();
            textBox2.Text = ds.Tables["searchResult"].Rows[1][3].ToString();

            /*bool CanConnectDB = false;
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    CanConnectDB = true;
                    objConnection.Close();
                }
                catch { }
                if (CanConnectDB) 
                {
                    SqlCommand lo_cmd = new SqlCommand();
                    lo_cmd.CommandText = "select * from site_general where source_type = N'车间'";
                    SqlDataAdapter dbAdapter = new SqlDataAdapter(lo_cmd);
                    DataSet ds = new DataSet();
                    //DataTable dt = new DataTable();
                    dbAdapter.Fill(ds,"searchResult");
                    

                    textBox1.Text = ds.Tables["searchResult"].Rows[0][1].ToString();
                 }
                else MessageBox.Show("数据库连接失败！", "警告:");
            }*/


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox1 .Text == "a")
            {
                MessageBox .Show ("ok");

            }
            else
                MessageBox .Show ("error");
        }

        private void button4_Click(object sender, EventArgs e)
        {
           foreach (Control c in this .Controls )
           {
               if (c is GroupBox)
               {
                   foreach (Control b in c.Controls )
                   {
                       if (b is TextBox)
                       {
                           (b as TextBox).Text = "hahaha";
                           (b as TextBox).ReadOnly = true ;
                       }
                   }
               }
           }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            List<MyData> dds = new List<MyData>();
            dds.Add(new MyData("春", 30));
            dds.Add(new MyData("夏", 60));
            dds.Add(new MyData("秋", 90));
            dds.Add(new MyData("冬", 10));
            chart1.Series[0].Points.DataBind(dds, "JJ", "DD", "");
        }
        class MyData
        {
            public string JJ { get; set; }
            public int DD { get; set; }
            public MyData(string j, int d)
            {
                JJ = j;
                DD = d;
            }
        }
    }
}
