using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnetCHARTING.WinForms;
using System.Data.SqlClient;//连接数据库
using System.Data.Sql;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public DataSet ds_pollution = new DataSet();

        class Mydata
        {
            private string _name;
            private int _age;
            public Mydata(string Name, int Age)
            {
                this._name = Name;
                this._age = Age;
            }
            public string Name
            {

                get { return _name; }

            }
            public int Age
            {

                get { return _age; }

            }

        }

        private SeriesCollection getChartData(DataTable dt)
        {
            SeriesCollection SC = new SeriesCollection();

            Series s = new Series();

            Random ro = new Random();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Element e = new Element();

                e.Name = dt.Rows[i][0].ToString();
                e.YValue = Convert.ToDouble(dt.Rows[i][1].ToString());
                e.ShowValue = true;
                s.Elements.Add(e);

            }

            SC.Add(s);

            return SC;
        }


            private void button31_Click(object sender, EventArgs e)
            {
                SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=cdsj;Integrated Security=True");
                conn.Open();
                SqlDataAdapter dbAdapter4 = new SqlDataAdapter();
                dbAdapter4.SelectCommand = new SqlCommand("procGetData", conn);  //存储过程名称procGetData
                dbAdapter4.SelectCommand.CommandType = CommandType.StoredProcedure;
                dbAdapter4.SelectCommand.Parameters.Add("@sc", System.Data.SqlDbType.NVarChar, 50);   //传入参数
                dbAdapter4.SelectCommand.Parameters["@sc"].Value = "JA01010008201";

                dbAdapter4.Fill(ds_pollution, "pt");
                conn.Close();

                DataTable _dt = new DataTable();
                _dt = ds_pollution.Tables[0].Clone();
                
                DataEngine de = new DataEngine();
                de.Data = _dt;
                de.DataFields = "YAxis=concentration,XAxis=test_time";

                chart31.Title = "统计图标题"; 
                //chart31.Use3D =  true ; // 3D效果
         
                //chart31.DefaultSeries.DefaultElement.Transparency = 10;
                //chart31.ShadingEffectMode =  ShadingEffectMode.Five;  // 3d效果的色彩数

                chart31.DefaultSeries.Type = SeriesType.Line; //折线

                //chart31.DefaultSeries.Type = SeriesType.Column; //柱状
                // chart31.DefaultSeries.Type = SeriesType.Spline; //曲线

                //chart31.YAxis.Scale =;
                chart31.XAxis.Label.Text = "x轴标题";
                chart31.YAxis.Label.Text = "y轴标题";

                //chart31.TempDirectory = Application.StartupPath;
                //chart31.FileName = "Dailysell";
                chart31.SeriesCollection.Clear();
                //chart31.Series.Data= ds_pollution.Tables[0];
                chart31.SeriesCollection.Add(de.GetSeries());
                
            }
    }
}
