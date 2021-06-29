using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpMap.Layers;
using BruTile.Predefined;
using System.IO;
using GeoPoint = GeoAPI.Geometries.Coordinate;
using SharpMap.Data.Providers;
using GeoAPI.Geometries;
using NetTopologySuite.Geometries;
using System.Collections.ObjectModel;
using System.Collections;
using System.Text.RegularExpressions;

namespace rainControlDevelop
{
    public partial class mainFrom : Form
    {
        TileAsyncLayer osmLayer = null;
        private GeometryProvider geoProvider;

        public mainFrom()
        {
            InitializeComponent();
            this.UpdateStyles();
            this.mapBox1.ShowProgressUpdate = true;
            AddOSMTile();

            CreateVectorLayerFile("point");
        }

        /// <summary>
        /// 使用sharpmap添加osm图层
        /// WTK是代理，因为默认代理被OSM屏蔽
        /// </summary>
        private void AddOSMTile()
        {
             osmLayer = new TileAsyncLayer(KnownTileSources.Create(KnownTileSource.OpenStreetMap,
                null, null, null, "SharpMap-WMSLayer"), "TileLayer - OSM");
            this.mapBox1.Map.BackgroundLayer.Clear();
            this.mapBox1.Map.BackgroundLayer.Add(osmLayer);
            mapBox1.Map.ZoomToExtents();
            this.mapBox1.Refresh();
            mapBox1.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;
        }

        /// <summary>
        /// 重新加载OSM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Refresh_Click(object sender, EventArgs e)
        {
            AddLineFromTXT("line");
            //this.mapBox1.Refresh();
           // mapBox1.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;
        }

        /// <summary>
        /// 将文件中的点数据放入图层并将其显示
        /// </summary>
        /// <param name="pathLine">包含点位置的文件路径</param>
        private void AddPointFromTXT( string pathLine )
        {
            List<string[]> pointList = ReadTxt( pathLine );
            Collection<IGeometry> geometry = new Collection<IGeometry>();
            IGeometryFactory factory = new GeometryFactory();
            foreach (var item in pointList)
            {
                var test_point = new GeoPoint(Convert.ToDouble(item[0]), Convert.ToDouble(item[1]));
                geometry.Add(factory.CreatePoint(test_point));
            }
            var provider = new GeometryProvider(geometry);
            VectorLayer pointLayer = new VectorLayer("point_layer");
            pointLayer.DataSource = provider;
            pointLayer.Style.PointSize = 20;
            pointLayer.Style.PointColor = Brushes.Yellow;
            mapBox1.Map.Layers.Add(pointLayer);
            mapBox1.Map.ZoomToExtents();
            this.mapBox1.Refresh();
        }

        /// <summary>
        /// 读取txt文本中的点数据
        /// </summary>
        /// <returns></returns>
        private List<string[]> ReadTxt( string pathLine )
        {
            List<string[]> pointClub = new List<string[]>();
            StreamReader sr = new StreamReader(pathLine, Encoding.Default);
            String line;
            Regex regex = new Regex(@" (?<value>[\s|\S]*),");
            while ((line = sr.ReadLine()) != null)
            {
                string[] ss = line.Substring(line.IndexOf(' ') + 1).Split(',');
                pointClub.Add(ss);
            }
            return pointClub;
        }

        /// <summary>
        /// 创造图层的方法
        /// </summary>
        private void CreateVectorLayerFile(string layerName)
        {
            VectorLayer vl = new VectorLayer(layerName);
            geoProvider = new GeometryProvider(new List<IGeometry>());
            vl.DataSource = geoProvider;
            this.mapBox1.Map.Layers.Add(vl);

            this.mapBox1.Refresh();
            this.mapBox1.GeometryDefined += new SharpMap.Forms.MapBox.GeometryDefinedHandler(MapBox1GeometryDefined);
            this.mapBox1.ActiveToolChanged += new SharpMap.Forms.MapBox.ActiveToolChangedHandler(MapBox1ActiveToolChange);
            this.mapBox1.MouseMove += new SharpMap.Forms.MapBox.MouseEventHandler(MapBox1MouseMove);
        }

        void MapBox1GeometryDefined(IGeometry geometry)
        {
            geoProvider.Geometries.Add(geometry);
            this.mapBox1.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;
            this.mapBox1.Refresh();
        }

        void MapBox1ActiveToolChange(SharpMap.Forms.MapBox.Tools tools)
        {
            label1.Text = this.mapBox1.ActiveTool.ToString();
        }

        void MapBox1MouseMove(Coordinate worldPos, MouseEventArgs imagePos)
        {
            label2.Text = worldPos.X.ToString("N4") + "/" + worldPos.Y.ToString("N4");
        }

        /// <summary>
        /// 打开txt文件，目前实现打开点文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            //读取点
                            AddPointFromTXT(theDialog.FileName);
                            //读取线
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// 实现存储点的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "文本文件|*.txt";
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                // 创建文件，将textBox1中的内容保存到文件中
                // saveDlg.FileName 是用户指定的文件路径
                FileStream fs = File.Open(saveDlg.FileName,
                    FileMode.Create,
                    FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                int i = 0;
                foreach (var item in geoProvider.Geometries)
                {
                    sw.WriteLine(i.ToString() + " " + (geoProvider.Geometries[geoProvider.Geometries.IndexOf(item)].Coordinate.X).ToString() + "," + (geoProvider.Geometries[geoProvider.Geometries.IndexOf(item)].Coordinate.Y).ToString() + "," + "NaN");
                    i++;
                }
                //关闭文件
                sw.Flush();
                sw.Close();
                fs.Close();
                // 提示用户：文件保存的位置和文件名
                MessageBox.Show("文件已成功保存到" + saveDlg.FileName);
            }
        }

        /// <summary>
        /// 画点的功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewPointsToMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mapBox1.ActiveTool = SharpMap.Forms.MapBox.Tools.DrawPoint;
        }

        /// <summary>
        /// 打开点文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToReadNewPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            //读取点
                            AddPointFromTXT(theDialog.FileName);
                            //读取线
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// 将图上画的点数据放到一个txt文档中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void savePointsToAFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "文本文件|*.txt";
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                // 创建文件，将textBox1中的内容保存到文件中
                // saveDlg.FileName 是用户指定的文件路径
                FileStream fs = File.Open(saveDlg.FileName,
                    FileMode.Create,
                    FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                int i = 0;
                foreach (var item in geoProvider.Geometries)
                {
                    sw.WriteLine(i.ToString() + " " + (geoProvider.Geometries[geoProvider.Geometries.IndexOf(item)].Coordinate.X).ToString() + "," + (geoProvider.Geometries[geoProvider.Geometries.IndexOf(item)].Coordinate.Y).ToString() + "," + "NaN");
                    i++;
                }
                //关闭文件
                sw.Flush();
                sw.Close();
                fs.Close();
                // 提示用户：文件保存的位置和文件名
                MessageBox.Show("文件已成功保存到" + saveDlg.FileName);
            }
        }

        /// <summary>
        /// 画线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawNewLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mapBox1.ActiveTool = SharpMap.Forms.MapBox.Tools.DrawLine;
        }

        /// <summary>
        /// 保存线的点坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveThePolylinesToAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "文本文件|*.txt";
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                // 创建文件，将textBox1中的内容保存到文件中
                // saveDlg.FileName 是用户指定的文件路径
                FileStream fs = File.Open(saveDlg.FileName,
                    FileMode.Create,
                    FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                int i = 0;
                foreach (var item in geoProvider.Geometries[0].Coordinates)
                {
                    sw.WriteLine(i.ToString() + " " + (item.X).ToString() + "," + (item.Y).ToString() + "," + "NaN");
                    i++;
                }
                //关闭文件
                sw.Flush();
                sw.Close();
                fs.Close();
                // 提示用户：文件保存的位置和文件名
                MessageBox.Show("文件已成功保存到" + saveDlg.FileName);
            }
        }

        /// <summary>
        /// 将文件中的点数据放入图层并将其链接成线
        /// </summary>
        /// <param name="pathLine">包含点位置的文件路径</param>
        private void AddLineFromTXT(string pathLine)
        {
            List<string[]> pointList = ReadTxt(pathLine);
            Collection<IGeometry> geometry = new Collection<IGeometry>();
            IGeometryFactory factory = new GeometryFactory();
            var pts = new GeoPoint[pointList.Count];
            for (int i = 0; i < pointList.Count; i++)
            {
                pts[i] = new Coordinate(Convert.ToDouble(pointList[i][0]), Convert.ToDouble(pointList[i][1]));
            }

            geometry.Add(factory.CreateLineString(pts));
            var provider = new GeometryProvider(geometry);
            VectorLayer lineLayer = new VectorLayer("line_layer");
            lineLayer.DataSource = provider;
            lineLayer.Style.Line = new Pen(Color.Black);
            mapBox1.Map.Layers.Add(lineLayer);
            mapBox1.Map.ZoomToExtents();
            this.mapBox1.Refresh();
        }

        private void openAFileAndReadTheLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            //读取线
                            AddLineFromTXT(theDialog.FileName);
                            //读取线
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
}
