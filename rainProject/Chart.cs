using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;

struct Date
{
    public int year;
    public int month;
    public int day;
    public int hour;
    public int minutes;
    public int seconds;
}

struct MeasureDate
{
    public Date date;
    public double levels;
}

namespace rainProject
{
    public partial class Chart : Form
    {
        //名称
        string tileName = null;
        List<MeasureDate> measureDateList = new List<MeasureDate>();
        List<Cardata> CCardata = new List<Cardata>();

        public Chart()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
           
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open tek File";
            theDialog.Filter = "tek files|*.tek";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {

                        using (myStream)
                        {
                            //string name = null;
                            //先读取名称Zhapo_utc_2016_min
                            StreamReader sr = new StreamReader(theDialog.FileName, Encoding.Default);
                            string name = sr.ReadToEnd();
                            string[] arrayStr = Regex.Split(name, "\r\n");
                            tileName = arrayStr[3];//标题数据进行读取完成
                                                   //进行时间+水位的读取
                            int size = Convert.ToInt32(arrayStr[4].Split(' ')[0]);


                            MeasureDate measureDate;
                            for (int i = 5; i < size + 5; i++)
                            {
                                Cardata cardate = new Cardata();
                                cardate.date = arrayStr[i].Split(' ')[0] + arrayStr[i].Split(' ')[1];
                                cardate.level = Convert.ToDouble(arrayStr[i].Split(' ')[2]);
                                CCardata.Add(cardate);
                                measureDate.date.year = Convert.ToInt32(arrayStr[i].Split(' ')[0]) / 10000;
                                measureDate.date.month = (Convert.ToInt32(arrayStr[i].Split(' ')[0]) - measureDate.date.year * 10000) / 100;
                                measureDate.date.day = Convert.ToInt32(arrayStr[i].Split(' ')[0]) - measureDate.date.year * 10000 - measureDate.date.month * 100;
                                measureDate.date.hour = Convert.ToInt32(arrayStr[i].Split(' ')[1]) / 10000;
                                measureDate.date.minutes = (Convert.ToInt32(arrayStr[i].Split(' ')[1]) - measureDate.date.hour * 10000) / 100;
                                measureDate.date.seconds = Convert.ToInt32(arrayStr[i].Split(' ')[1]) - measureDate.date.hour * 10000 - measureDate.date.minutes * 100;
                                measureDate.levels = Convert.ToDouble(arrayStr[i].Split(' ')[2]);
                                measureDateList.Add(measureDate);
                            }
                        }

                        this.chart1.Series[0].ChartType = SeriesChartType.Spline;

                        foreach (var item in measureDateList)
                        {
                            this.chart1.Series[0].Points.AddXY((item.date.day).ToString() + "日" + (item.date.hour).ToString() + "时", item.levels);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }

    class Cardata
    {
        private string _date;

        public string date
        {
            get { return _date; }
            set { _date = value; }
        }
        private double _level;

        public double level
        {
            get { return _level; }
            set { _level = value; }
        }
    }
}
