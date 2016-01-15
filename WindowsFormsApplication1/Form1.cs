using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Permissions;
using System.IO;
using System.ComponentModel;
using System.Linq;
using System.Text;
//using map;


namespace WindowsFormsApplication1
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //webBrowser1.ScriptErrorsSuppressed = false;

        }

        public List<BlogNew> blogNews { get; set; }
        public BindingList<BlogNew> blogNewsRegardUI { get; set; }

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

            string strConnection = "Data Source=DESKTOP-SK2RD82;Initial Catalog=cdsj;Integrated Security=True";
            SqlConnection lo_con = new SqlConnection(strConnection);
            lo_con.Open();
            SqlCommand lo_cmd = new SqlCommand(); //创建命令对象
            lo_cmd.CommandText = "select * from site_info where site_property = N'退役工业用地'"; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
            DataSet ds = new DataSet(); //创建数据集对象
            dbAdapter.Fill(ds, "searchResult"); //用返回的结果集填充数据集

            lo_con.Close();

            textBox1.Text = ds.Tables["searchResult"].Rows[0][3].ToString();
            textBox2.Text = ds.Tables["searchResult"].Rows[1][3].ToString();

            foreach (DataRow row in ds.Tables["searchResult"].Rows)
            {
                TreeNode node = treeView1.Nodes.Add(row[13].ToString());
            }

            //TreeNode node1 = treeView1.Nodes.Add(ds.Tables["searchResult"].Rows[0][3].ToString());
            //TreeNode node2 = treeView1.Nodes.Add(ds.Tables["searchResult"].Rows[1][3].ToString());

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
            this.Hide();
            Form3 frm = new Form3();
            frm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is GroupBox)
                {
                    foreach (Control b in c.Controls)
                    {
                        if (b is TextBox)
                        {
                            (b as TextBox).Text = "hahaha";
                            (b as TextBox).ReadOnly = true;
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // map.Form1 frm = new map.Form1();
            // frm.Show();
            object[] objects = new object[2];
            objects[0] = textBox1.Text.ToString();
            objects[1] = textBox2.Text.ToString();
            double input;
            decimal output;
            double.TryParse(textBox7.Text,out input);//转换字符串为double
            output = MonteCarloPI(input);
            MessageBox.Show(output.ToString());
        }
            
           private decimal MonteCarloPI(double x)
            {
                int test_times = 10000000;
                int hit_sum = 0; 
                double a, b;
                Random ran = new Random();
            for(int i = 0; i < test_times; i++){
                a = 2*x*ran.NextDouble();
                b = 2*x*ran.NextDouble();
                if (Math.Pow((a- x),2)+ Math.Pow((b -x),2)<= Math.Pow(x,2) ){
                    hit_sum++;
                    }
                }
            decimal PI = decimal.Divide(4*hit_sum,test_times);//类型转换
            return PI;
            }
 



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“testDataSet.Table_1”中。您可以根据需要移动或删除它。
            //this.table_1TableAdapter.Fill(this.testDataSet.Table_1);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32.exe", " PrScrn.dll PrScrn");
        }


        private void button8_Click(object sender, EventArgs e)
        {
            byte[] imagebytes = null;
            try
            {
                string strConnection = "Data Source=DESKTOP-SK2RD82;Initial Catalog=TestDB;Integrated Security=True";//Initial catalog后面跟数据库的名字
                SqlConnection conn = new SqlConnection(strConnection);
                conn.Open();//数据库链接打开
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select pic from sampling_record where sample_point ='1'";
                cmd.Connection = conn;
                SqlDataReader bdr = cmd.ExecuteReader();
                //SqlDataAdapter dbAdapter = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                while (bdr.Read())
                {
                    imagebytes = (byte[])(bdr.GetValue(0));
                }
                bdr.Close();
                cmd.Clone();
                conn.Close();//关闭数据库连接
                MemoryStream ms = new MemoryStream(imagebytes);
                Bitmap bmpt = new Bitmap(ms);
                pictureBox1.Image = bmpt;
            }
            catch (Exception)
            {
                MessageBox.Show("我操粗错了！＼(≧▽≦)／");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double input1,input2;
            decimal output;
            double.TryParse(textBox5.Text, out input1);//转换字符串为double
            double.TryParse(textBox6.Text, out input2);
            output = CalArea(input1,input2);
            MessageBox.Show(output.ToString());
        }

        private decimal MonteCarloArea(double x)//蒙特卡洛法求任意函数曲线[0,x]区间积分面积
        {
            int test_times = 1000000;
            int hit_sum = 0;
            double a, b;
            Random ran = new Random();
            for (int i = 0; i < test_times; i++)
            {
                a = x * ran.NextDouble();//确定随机点横坐标
                b = f(x) * ran.NextDouble();//确定随机点纵坐标
                if (f(a)>= b)
                {
                    hit_sum++;
                }
            }
            double fra = Convert.ToDouble(decimal.Divide(hit_sum, test_times));//类型转换
            decimal area = Convert.ToDecimal(fra * x * f(x));//面积比计算
            area = decimal.Round(area,3);//限定decimal输出为小数点后两位
            return area;
        }

        private double f(double x)
        {
            return Math.Pow(x, 2)+Math.Log(x);//此处写待积分方程
        }

        private decimal CalArea(double x,double y)
        {
            decimal z;
            z = MonteCarloArea(y) - MonteCarloArea(x);//积分上下限面积差
            return z;
        }
    }
}
