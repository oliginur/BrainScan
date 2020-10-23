using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using SeriesCollection = LiveCharts.SeriesCollection;

namespace BrainScan
{
    public partial class Form1 : Form
    {
        //Drop down current status 
        private bool isCollapsed_List1;
        private bool isCollapsed_List2;
        private bool isCollapsed_List3;
        
        //Current used button
        private Button mBtn_CurrentUse;

        //Windows move point
        private Point mousePosition;

        //CartesianChart & Random data array
        //LiveCharts.WinForms.CartesianChart[] mCartesianChart;
        int[,] mRandomValues;
        Random mRandomFunc;
        //public ChartValues<MeasureModel>[] mChartValues { get; set; }
        public ChartValues<MeasureModel> mChartValues1 { get; set; }
        public ChartValues<MeasureModel> mChartValues2 { get; set; }
        public ChartValues<MeasureModel> mChartValues3 { get; set; }
        public ChartValues<MeasureModel> mChartValues4 { get; set; }
        public ChartValues<MeasureModel> mChartValues5 { get; set; }
        public ChartValues<MeasureModel> mChartValues6 { get; set; }
        public ChartValues<MeasureModel> mChartValues7 { get; set; }
        public ChartValues<MeasureModel> mChartValues8 { get; set; }


        public System.Windows.Forms.Timer timerRandomTick1 = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Timer timerRandomTick2 = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Timer timerRandomTick3 = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Timer timerRandomTick4 = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Timer timerRandomTick5 = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Timer timerRandomTick6 = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Timer timerRandomTick7 = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Timer timerRandomTick8 = new System.Windows.Forms.Timer();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //When the program is run, the form is brought to the top.
            this.TopMost = true;
            //When the program is run, the Stream Panel is brought to the top.
            this.panel_stream.BringToFront();

            this.panel_edit.Parent = this;
            this.panel_mainmenu.Parent = this;
            this.panel_mainmenu_tab1.Parent = this;
            this.panel_mainmenu_tab2.Parent = this;
            this.panel_mainmenu_tab3.Parent = this;
            panel_mainmenu_tab1.Location = new Point(0, 25);
            panel_mainmenu_tab2.Location = new Point(0, 25);
            panel_mainmenu_tab3.Location = new Point(0, 25);
            panel_mainmenu_tab1.BringToFront();
            panel_mainmenu_tab2.BringToFront();
            panel_mainmenu_tab3.BringToFront();
            panel_mainmenu.BringToFront();

            //init Variable 
            isCollapsed_List1 = true;
            isCollapsed_List2 = true;
            isCollapsed_List3 = true;

            //mBtn_CurrentUse = new Button();
            initializeCartesianChart();
            startTimer();

            
        }


        //close this form
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //for drop down animation.
        private void timer_dropdown_panel1_Tick(object sender, EventArgs e)
        {
            
            if(isCollapsed_List1)
            {
                //btn_main_tab1.Image = Resource1.arrow_left_10px;
                panel_mainmenu_tab1.Width += 20;
                if(panel_mainmenu_tab1.Size == panel_mainmenu_tab1.MaximumSize)
                {
                    timer_dropdown_panel1.Stop();
                    isCollapsed_List1 = false;
                }
            }
            else
            {
                //btn_main_tab1.Image = Resource1.arrow_right_10px;
                panel_mainmenu_tab1.Width -= 20;
                if (panel_mainmenu_tab1.Size == panel_mainmenu_tab1.MinimumSize)
                {
                    timer_dropdown_panel1.Stop();
                    isCollapsed_List1 = true;
                }
            }
            
        }


        //for drop down animation.
        private void timer_dropdown_panel2_Tick(object sender, EventArgs e)
        {
            
            if (isCollapsed_List2)
            {
                //btn_main_tab2.Image = Resource1.arrow_left_10px;
                panel_mainmenu_tab2.Width += 20;
                if (panel_mainmenu_tab2.Size == panel_mainmenu_tab2.MaximumSize)
                {
                    timer_dropdown_panel2.Stop();
                    isCollapsed_List2 = false;
                }
            }
            else
            {
                //btn_main_tab2.Image = Resource1.arrow_right_10px;
                panel_mainmenu_tab2.Width -= 20;
                if (panel_mainmenu_tab2.Size == panel_mainmenu_tab2.MinimumSize)
                {
                    timer_dropdown_panel2.Stop();
                    isCollapsed_List2 = true;
                }
            }
            
        }


        //for drop down animation.
        private void timer_dropdown_panel3_Tick(object sender, EventArgs e)
        {
            
            if (isCollapsed_List3)
            {
                //btn_main_tab3.Image = Resource1.arrow_left_10px;
                panel_mainmenu_tab3.Width += 20;
                if (panel_mainmenu_tab3.Size == panel_mainmenu_tab3.MaximumSize)
                {
                    timer_dropdown_panel3.Stop();
                    isCollapsed_List3 = false;
                }
            }
            else
            {
                //btn_main_tab3.Image = Resource1.arrow_right_10px;
                panel_mainmenu_tab3.Width -= 20;
                if (panel_mainmenu_tab3.Size == panel_mainmenu_tab3.MinimumSize)
                {
                    timer_dropdown_panel3.Stop();
                    isCollapsed_List3 = true;
                }
            }
            
        }


        //drop down start - button list event handler
        private void button_dropdown_list_Click(object sender, EventArgs e)
        {
            //Button _btn = (Button)sender;
            mBtn_CurrentUse = (Button)sender;

            if (mBtn_CurrentUse.Name.Equals("btn_main_tab1"))
            {
                panel_mainmenu_tab2.Size = panel_mainmenu_tab2.MinimumSize;
                panel_mainmenu_tab3.Size = panel_mainmenu_tab3.MinimumSize;
                //btn_main_tab2.Image = Resource1.arrow_right_10px;
                //btn_main_tab3.Image = Resource1.arrow_right_10px;
                isCollapsed_List2 = true;
                isCollapsed_List3 = true;
                panel_mainmenu_tab1.BringToFront();
                panel_mainmenu.BringToFront();
                timer_dropdown_panel1.Start();
            }
            else if (mBtn_CurrentUse.Name.Equals("btn_main_tab2"))
            {
                panel_mainmenu_tab1.Size = panel_mainmenu_tab2.MinimumSize;
                panel_mainmenu_tab3.Size = panel_mainmenu_tab3.MinimumSize;
                //btn_main_tab1.Image = Resource1.arrow_right_10px;
                //btn_main_tab3.Image = Resource1.arrow_right_10px;
                isCollapsed_List1 = true;
                isCollapsed_List3 = true;
                panel_mainmenu_tab2.BringToFront();
                panel_mainmenu.BringToFront();
                timer_dropdown_panel2.Start();
            }
            else
            {
                panel_mainmenu_tab2.Size = panel_mainmenu_tab2.MinimumSize;
                panel_mainmenu_tab1.Size = panel_mainmenu_tab3.MinimumSize;
                //btn_main_tab2.Image = Resource1.arrow_right_10px;
                //btn_main_tab1.Image = Resource1.arrow_right_10px;
                isCollapsed_List2 = true;
                isCollapsed_List1 = true;
                panel_mainmenu_tab3.BringToFront();
                panel_mainmenu.BringToFront();
                timer_dropdown_panel3.Start();
            }
            
        }

        private void currentButtonInitPosion()
        {
            if (mBtn_CurrentUse.Name.Equals("btn_main_tab1"))
            {
                panel_mainmenu_tab1.BringToFront();
                panel_mainmenu.BringToFront();
                timer_dropdown_panel1.Start();
            }
            else if (mBtn_CurrentUse.Name.Equals("btn_main_tab2"))
            {
                panel_mainmenu_tab2.BringToFront();
                panel_mainmenu.BringToFront();
                timer_dropdown_panel2.Start();
            }
            else
            {
                panel_mainmenu_tab3.BringToFront();
                panel_mainmenu.BringToFront();
                timer_dropdown_panel3.Start();
            }
        }


        //for Drop down button 1's sub item event handler
        private void button_button_list1_items(object sender, EventArgs e)
        {
            Button _btn = (Button)sender;
            currentButtonInitPosion();

            if (_btn.TabIndex == 1)//Stream mode
            {
                this.panel_stream.BringToFront();
                //initializeCartesianChart();
                //startTimer();
            }
            else if (_btn.TabIndex == 2)//Edit mode
            {
                this.panel_edit.BringToFront();
            }
            else if (_btn.TabIndex == 3)//Edit mode
            {
                MessageBox.Show("Drop down list1 - item3");
            }
            else if (_btn.TabIndex == 4)//Edit mode
            {
                MessageBox.Show("Drop down list1 - item4");
            }
            else
            {
                MessageBox.Show("Drop down list1 - item5");
            }
        }

        //for Drop down button 2's sub item event handler
        private void button_button_list2_items(object sender, EventArgs e)
        {
            Button _btn = (Button)sender;
            currentButtonInitPosion();
            if (_btn.TabIndex == 1)//Stream mode
            {
                MessageBox.Show("Drop down list2 - item1");
            }
            else if (_btn.TabIndex == 2)//Edit mode
            {
                MessageBox.Show("Drop down list2 - item2");
            }
            else if (_btn.TabIndex == 3)
            {
                MessageBox.Show("Drop down list2 - item3");
            }
            else
            {
                MessageBox.Show("Drop down list2 - item4");
            }
        }

        //for Drop down button 3's sub item event handler
        private void button_button_list3_items(object sender, EventArgs e)
        {
            Button _btn = (Button)sender;
            currentButtonInitPosion();
            if (_btn.TabIndex == 1)//Stream mode
            {
                MessageBox.Show("Drop down list3 - item1");
            }
            else if (_btn.TabIndex == 2)//Edit mode
            {
                MessageBox.Show("Drop down list3 - item2");
            }
            else if (_btn.TabIndex == 3)
            {
                MessageBox.Show("Drop down list3 - item3");
            }
            else
            {
                MessageBox.Show("Drop down list3 - item4");
            }
        }



        //title bar adjust
        private void panel_titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            mousePosition = new Point(e.X, e.Y);
        }

        private void panel_titlebar_MouseMove(object sender, MouseEventArgs e)
        {
            if((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePosition.X - e.X), this.Top - (mousePosition.Y - e.Y));
            }
        }

        private void panel_titlebar_DoubleClick(object sender, EventArgs e)
        {
            Location = new Point(0, 0);
        }



        //Cartesianchart init func
        private void initializeCartesianChart()
        {
            /*
            mCartesianChart = new LiveCharts.WinForms.CartesianChart[10];
            mCartesianChart[0] = cartesianChart_1;
            mCartesianChart[1] = cartesianChart_2;
            mCartesianChart[2] = cartesianChart_3;
            mCartesianChart[3] = cartesianChart_4;
            mCartesianChart[4] = cartesianChart_5;
            mCartesianChart[5] = cartesianChart_6;
            mCartesianChart[6] = cartesianChart_7;
            mCartesianChart[7] = cartesianChart_8;
            */

            mRandomValues = new int[8, 50];
            mRandomFunc = new Random();
            int[] arr = new int[5]{ -50, -25, 0, 25, 50};
            //cartestianChart's X, Y
            var mapper = Mappers.Xy<MeasureModel>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Value);

            Charting.For<MeasureModel>(mapper);


            /*
            //init cartestianChart's option
            for (int i = 0; i < 8; i++)
            {
                mChartValues = new ChartValues<MeasureModel>[i];
                mCartesianChart[i].AnimationsSpeed = System.TimeSpan.FromMilliseconds(200);
            }
            */
            mChartValues1 = new ChartValues<MeasureModel>();
            mChartValues2 = new ChartValues<MeasureModel>();
            mChartValues3 = new ChartValues<MeasureModel>();
            mChartValues4 = new ChartValues<MeasureModel>();
            mChartValues5 = new ChartValues<MeasureModel>();
            mChartValues6 = new ChartValues<MeasureModel>();
            mChartValues7 = new ChartValues<MeasureModel>();
            mChartValues8 = new ChartValues<MeasureModel>();
            cartesianChart_1.AnimationsSpeed = System.TimeSpan.FromMilliseconds(200);
            cartesianChart_2.AnimationsSpeed = System.TimeSpan.FromMilliseconds(200);
            cartesianChart_3.AnimationsSpeed = System.TimeSpan.FromMilliseconds(200);
            cartesianChart_4.AnimationsSpeed = System.TimeSpan.FromMilliseconds(200);
            cartesianChart_5.AnimationsSpeed = System.TimeSpan.FromMilliseconds(200);
            cartesianChart_6.AnimationsSpeed = System.TimeSpan.FromMilliseconds(200);
            cartesianChart_7.AnimationsSpeed = System.TimeSpan.FromMilliseconds(200);
            cartesianChart_8.AnimationsSpeed = System.TimeSpan.FromMilliseconds(200);

            //make random data
            for (int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 50; j++)
                {
                    mRandomValues[i, j] = mRandomFunc.Next(-50, 50);
                }
            }

            //setting CartestuanCharts detail.
            cartesianChart_1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = mChartValues1,
                    PointGeometrySize = 0,
                    StrokeThickness = 2,
                    PointGeometry = null,
                    LineSmoothness = 1,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)),
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0, 0, 0, 0))
                }
            };

            cartesianChart_2.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = mChartValues2,
                    PointGeometrySize = 0,
                    StrokeThickness = 2,
                    PointGeometry = null,
                    LineSmoothness = 1,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 0, 0)),
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0, 0, 0, 0))
                }
            };

            cartesianChart_3.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = mChartValues3,
                    PointGeometrySize = 0,
                    StrokeThickness = 2,
                    PointGeometry = null,
                    LineSmoothness = 1,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 255, 0)),
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0, 0, 0, 0))
                }
            };

            cartesianChart_4.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = mChartValues4,
                    PointGeometrySize = 0,
                    StrokeThickness = 2,
                    PointGeometry = null,
                    LineSmoothness = 1,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 255)),
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0, 0, 0, 0))
                }
            };

            cartesianChart_5.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = mChartValues5,
                    PointGeometrySize = 0,
                    StrokeThickness = 2,
                    PointGeometry = null,
                    LineSmoothness = 1,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 0)),
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0, 0, 0, 0))
                }
            };

            cartesianChart_6.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = mChartValues6,
                    PointGeometrySize = 0,
                    StrokeThickness = 2,
                    PointGeometry = null,
                    LineSmoothness = 1,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 200, 100, 0)),
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0, 0, 0, 0))
                }
            };

            cartesianChart_7.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = mChartValues7,
                    PointGeometrySize = 0,
                    StrokeThickness = 2,
                    PointGeometry = null,
                    LineSmoothness = 1,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 0, 255)),
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0, 0, 0, 0))
                }
            };

            cartesianChart_8.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = mChartValues8,
                    PointGeometrySize = 0,
                    StrokeThickness = 2,
                    PointGeometry = null,
                    LineSmoothness = 1,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 150, 0, 150)),
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0, 0, 0, 0))
                }
            };

            /*
            //Axis X settin label formatter
            for(int i = 0; i < 8;  i++)
            {
                mCartesianChart[i].AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    DisableAnimations = true,

                    LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                    Separator = new Separator
                    {
                        Step = TimeSpan.FromSeconds(1).Ticks
                    }
                });
            }
            */
            //Axis X settin label formatter
            cartesianChart_1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                DisableAnimations = true,

                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });
            cartesianChart_2.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                DisableAnimations = true,

                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });
            cartesianChart_3.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                DisableAnimations = true,

                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });
            cartesianChart_4.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                DisableAnimations = true,

                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });
            cartesianChart_5.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                DisableAnimations = true,

                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });
            cartesianChart_6.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                DisableAnimations = true,

                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });
            cartesianChart_7.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                DisableAnimations = true,

                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });
            cartesianChart_8.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                DisableAnimations = true,

                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });
            

            setAxisLimits(System.DateTime.Now);




            /*
            System.Windows.Forms.Timer timerRandomTick = new System.Windows.Forms.Timer();
            timerRandomTick.Enabled = true;
            timerRandomTick.Interval = 100;
            timerRandomTick.Tick += new EventHandler(lineTimer_tick);
            timerRandomTick.Start();
            */


            



        }

        private void startTimer()
        {



            timerRandomTick1.Enabled = true;
            timerRandomTick1.Interval = 100;
            timerRandomTick1.Tick += new EventHandler(lineTimer_tick1);
            timerRandomTick1.Start();
            /*
            timerRandomTick2.Enabled = true;
            timerRandomTick2.Interval = 100;
            timerRandomTick2.Tick += new EventHandler(lineTimer_tick2);
            timerRandomTick2.Start();

            timerRandomTick3.Enabled = true;
            timerRandomTick3.Interval = 100;
            timerRandomTick3.Tick += new EventHandler(lineTimer_tick3);
            timerRandomTick3.Start();

            timerRandomTick4.Enabled = true;
            timerRandomTick4.Interval = 100;
            timerRandomTick4.Tick += new EventHandler(lineTimer_tick4);
            timerRandomTick4.Start();

            timerRandomTick5.Enabled = true;
            timerRandomTick5.Interval = 100;
            timerRandomTick5.Tick += new EventHandler(lineTimer_tick5);
            timerRandomTick5.Start();

            timerRandomTick6.Enabled = true;
            timerRandomTick6.Interval = 100;
            timerRandomTick6.Tick += new EventHandler(lineTimer_tick6);
            timerRandomTick6.Start();

            timerRandomTick7.Enabled = true;
            timerRandomTick7.Interval = 100;
            timerRandomTick7.Tick += new EventHandler(lineTimer_tick7);
            timerRandomTick7.Start();

            timerRandomTick8.Enabled = true;
            timerRandomTick8.Interval = 100;
            timerRandomTick8.Tick += new EventHandler(lineTimer_tick8);
            timerRandomTick8.Start();
            */
        }

        //Settin Axis X speed
        private void setAxisLimits(System.DateTime now)
        {
            /*
            for(int i = 0; i < 8; i++)
            {
                mCartesianChart[i].AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
                mCartesianChart[i].AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds
            }
            */

            cartesianChart_1.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_1.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds
            cartesianChart_2.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_2.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds
            cartesianChart_3.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_3.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds
            cartesianChart_4.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_4.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds
            cartesianChart_5.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_5.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds
            cartesianChart_6.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_6.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds
            cartesianChart_7.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_7.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds
            cartesianChart_8.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_8.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds

        }




        //Settin Axis X speed
        private void setAxisLimits1(System.DateTime now)
        {

            cartesianChart_1.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_1.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds

        }

        //Settin Axis X speed
        private void setAxisLimits2(System.DateTime now)
        {

            cartesianChart_2.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_2.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds

        }

        //Settin Axis X speed
        private void setAxisLimits3(System.DateTime now)
        {

            cartesianChart_3.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_3.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds

        }

        //Settin Axis X speed
        private void setAxisLimits4(System.DateTime now)
        {

            cartesianChart_4.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_4.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds

        }

        //Settin Axis X speed
        private void setAxisLimits5(System.DateTime now)
        {

            cartesianChart_5.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_5.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds

        }

        //Settin Axis X speed
        private void setAxisLimits6(System.DateTime now)
        {

            cartesianChart_6.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_6.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds

        }

        //Settin Axis X speed
        private void setAxisLimits7(System.DateTime now)
        {

            cartesianChart_7.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_7.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds

        }

        //Settin Axis X speed
        private void setAxisLimits8(System.DateTime now)
        {

            cartesianChart_8.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart_8.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(5).Ticks; //we only care about the last 8 seconds

        }




        public void lineTimer_tick(object sender, EventArgs e)
        {
            try
            {
                /*
                MeasureModel[] mmd = new MeasureModel[8];
                for (int i = 0 ; i < 8; i++)
                {
                    mmd[i].DateTime = System.DateTime.Now;
                    mmd[i].Value = mRandomValues[i, mRandomFunc.Next(0, 49)];
                    mChartValues[i].Add(mmd[i]);

                    if (mChartValues[i].Count > 50) mChartValues[i].RemoveAt(0);
                }
                setAxisLimits(System.DateTime.Now);
                */

                MeasureModel mmd1 = new MeasureModel();
                MeasureModel mmd2 = new MeasureModel();
                MeasureModel mmd3 = new MeasureModel();
                MeasureModel mmd4 = new MeasureModel();
                MeasureModel mmd5 = new MeasureModel();
                MeasureModel mmd6 = new MeasureModel();
                MeasureModel mmd7 = new MeasureModel();
                MeasureModel mmd8 = new MeasureModel();
                mmd1.DateTime = System.DateTime.Now;
                mmd2.DateTime = System.DateTime.Now;
                mmd3.DateTime = System.DateTime.Now;
                mmd4.DateTime = System.DateTime.Now;
                mmd5.DateTime = System.DateTime.Now;
                mmd6.DateTime = System.DateTime.Now;
                mmd7.DateTime = System.DateTime.Now;
                mmd8.DateTime = System.DateTime.Now;
                mmd1.Value = mRandomValues[0, mRandomFunc.Next(0, 49)];
                mmd2.Value = mRandomValues[1, mRandomFunc.Next(0, 49)];
                mmd3.Value = mRandomValues[2, mRandomFunc.Next(0, 49)];
                mmd4.Value = mRandomValues[3, mRandomFunc.Next(0, 49)];
                mmd5.Value = mRandomValues[4, mRandomFunc.Next(0, 49)];
                mmd6.Value = mRandomValues[5, mRandomFunc.Next(0, 49)];
                mmd7.Value = mRandomValues[6, mRandomFunc.Next(0, 49)];
                mmd8.Value = mRandomValues[7, mRandomFunc.Next(0, 49)];
                mChartValues1.Add(mmd1);
                mChartValues2.Add(mmd2);
                mChartValues3.Add(mmd3);
                mChartValues4.Add(mmd4);
                mChartValues5.Add(mmd5);
                mChartValues6.Add(mmd6);
                mChartValues7.Add(mmd7);
                mChartValues8.Add(mmd8);
                if (mChartValues1.Count > 50) mChartValues1.RemoveAt(0);
                if (mChartValues2.Count > 50) mChartValues2.RemoveAt(0);
                if (mChartValues3.Count > 50) mChartValues3.RemoveAt(0);
                if (mChartValues4.Count > 50) mChartValues4.RemoveAt(0);
                if (mChartValues5.Count > 50) mChartValues5.RemoveAt(0);
                if (mChartValues6.Count > 50) mChartValues6.RemoveAt(0);
                if (mChartValues7.Count > 50) mChartValues7.RemoveAt(0);
                if (mChartValues8.Count > 50) mChartValues8.RemoveAt(0);

                setAxisLimits(System.DateTime.Now);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tick1" + ex.ToString());
            }
        }



        public void lineTimer_tick1(object sender, EventArgs e)
        {
            try
            {
                MeasureModel mmd = new MeasureModel();

                

                mmd.DateTime = System.DateTime.Now;
                mmd.Value = mRandomValues[0, mRandomFunc.Next(0, 49)];
                mChartValues1.Add(mmd);
                if (mChartValues1.Count > 50) mChartValues1.RemoveAt(0);

                cartesianChart_1.AxisX[0].Separator.StrokeThickness = 0;
                cartesianChart_1.AxisY[0].Separator.StrokeThickness = 0;

                setAxisLimits1(System.DateTime.Now);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tick1" + ex.ToString());
            }
        }
        public void lineTimer_tick2(object sender, EventArgs e)
        {
            try
            {
                MeasureModel mmd = new MeasureModel();
                mmd.DateTime = System.DateTime.Now;
                mmd.Value = mRandomValues[1, mRandomFunc.Next(0, 49)];
                mChartValues2.Add(mmd);
                if (mChartValues2.Count > 50) mChartValues2.RemoveAt(0);

                setAxisLimits2(System.DateTime.Now);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tick1" + ex.ToString());
            }
        }
        public void lineTimer_tick3(object sender, EventArgs e)
        {
            try
            {
                MeasureModel mmd = new MeasureModel();
                mmd.DateTime = System.DateTime.Now;
                mmd.Value = mRandomValues[2, mRandomFunc.Next(0, 49)];
                mChartValues3.Add(mmd);
                if (mChartValues3.Count > 50) mChartValues3.RemoveAt(0);

                setAxisLimits3(System.DateTime.Now);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tick1" + ex.ToString());
            }
        }
        public void lineTimer_tick4(object sender, EventArgs e)
        {
            try
            {
                MeasureModel mmd = new MeasureModel();
                mmd.DateTime = System.DateTime.Now;
                mmd.Value = mRandomValues[3, mRandomFunc.Next(0, 49)];
                mChartValues4.Add(mmd);
                if (mChartValues4.Count > 50) mChartValues4.RemoveAt(0);

                setAxisLimits4(System.DateTime.Now);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tick1" + ex.ToString());
            }
        }
        public void lineTimer_tick5(object sender, EventArgs e)
        {
            try
            {
                MeasureModel mmd = new MeasureModel();
                mmd.DateTime = System.DateTime.Now;
                mmd.Value = mRandomValues[4, mRandomFunc.Next(0, 49)];
                mChartValues5.Add(mmd);
                if (mChartValues5.Count > 50) mChartValues5.RemoveAt(0);

                setAxisLimits5(System.DateTime.Now);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tick1" + ex.ToString());
            }
        }
        public void lineTimer_tick6(object sender, EventArgs e)
        {
            try
            {
                MeasureModel mmd = new MeasureModel();
                mmd.DateTime = System.DateTime.Now;
                mmd.Value = mRandomValues[5, mRandomFunc.Next(0, 49)];
                mChartValues6.Add(mmd);
                if (mChartValues6.Count > 50) mChartValues6.RemoveAt(0);

                setAxisLimits6(System.DateTime.Now);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tick1" + ex.ToString());
            }
        }
        public void lineTimer_tick7(object sender, EventArgs e)
        {
            try
            {
                MeasureModel mmd = new MeasureModel();
                mmd.DateTime = System.DateTime.Now;
                mmd.Value = mRandomValues[6, mRandomFunc.Next(0, 49)];
                mChartValues7.Add(mmd);
                if (mChartValues7.Count > 50) mChartValues7.RemoveAt(0);

                setAxisLimits7(System.DateTime.Now);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tick1" + ex.ToString());
            }
        }
        public void lineTimer_tick8(object sender, EventArgs e)
        {
            try
            {
                MeasureModel mmd = new MeasureModel();
                mmd.DateTime = System.DateTime.Now;
                mmd.Value = mRandomValues[7, mRandomFunc.Next(0, 49)];
                mChartValues8.Add(mmd);
                if (mChartValues8.Count > 50) mChartValues8.RemoveAt(0);

                setAxisLimits8(System.DateTime.Now);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tick1" + ex.ToString());
            }
        }



        // button image change effect
        private void btn_main_tab1_img_MouseDown(object sender, MouseEventArgs e)
        {
            Button _btn = (Button)sender;

            if (_btn.TabIndex == 1)//Stream mode
            {
                _btn.Image = Resource1.btn1_press;
            }
            else if (_btn.TabIndex == 2)//Edit mode
            {
                _btn.Image = Resource1.btn2_press;
            }
            else if (_btn.TabIndex == 3)//Edit mode
            {
                _btn.Image = Resource1.btn3_press;
            }
            else if (_btn.TabIndex == 4)//Edit mode
            {
                _btn.Image = Resource1.btn4_press;
            }
            else
            {
                _btn.Image = Resource1.btn5_press;
            }            
        }

        // button image change effect
        private void btn_main_tab1_img_MouseUp(object sender, MouseEventArgs e)
        {
            Button _btn = (Button)sender;
            
            if (_btn.TabIndex == 1)//Stream mode
            {
                _btn.Image = Resource1.btn1_normal;
            }
            else if (_btn.TabIndex == 2)//Edit mode
            {
                _btn.Image = Resource1.btn2_normal;
            }
            else if (_btn.TabIndex == 3)//Edit mode
            {
                _btn.Image = Resource1.btn3_normal;
            }
            else if (_btn.TabIndex == 4)//Edit mode
            {
                _btn.Image = Resource1.btn4_normal;
            }
            else
            {
                _btn.Image = Resource1.btn5_normal;
            }
           
        }

        // button image change effect
        private void btn_main_tab2_img_MouseDown(object sender, MouseEventArgs e)
        {
            Button _btn = (Button)sender;

            if (_btn.TabIndex == 1)//Stream mode
            {
                _btn.Image = Resource1.btn6_press;
            }
            else if (_btn.TabIndex == 2)//Edit mode
            {
                _btn.Image = Resource1.btn7_press;
            }
            else if (_btn.TabIndex == 3)//Edit mode
            {
                _btn.Image = Resource1.btn8_press;
            }
            else
            {
                _btn.Image = Resource1.btn9_press;
            }
        }

        // button image change effect
        private void btn_main_tab2_img_MouseUp(object sender, MouseEventArgs e)
        {
            Button _btn = (Button)sender;

            if (_btn.TabIndex == 1)//Stream mode
            {
                _btn.Image = Resource1.btn6_normal;
            }
            else if (_btn.TabIndex == 2)//Edit mode
            {
                _btn.Image = Resource1.btn7_normal;
            }
            else if (_btn.TabIndex == 3)//Edit mode
            {
                _btn.Image = Resource1.btn8_normal;
            }
            else
            {
                _btn.Image = Resource1.btn9_normal;
            }
        }

        // button image change effect
        private void btn_main_tab3_img_MouseDown(object sender, MouseEventArgs e)
        {
            Button _btn = (Button)sender;

            if (_btn.TabIndex == 1)//Stream mode
            {
                _btn.Image = Resource1.btn10_press;
            }
            else if (_btn.TabIndex == 2)//Edit mode
            {
                _btn.Image = Resource1.btn11_press;
            }
            else if (_btn.TabIndex == 3)//Edit mode
            {
                _btn.Image = Resource1.btn12_press;
            }
            else
            {
                _btn.Image = Resource1.btn13_press;
            }
        }

        // button image change effect
        private void btn_main_tab3_img_MouseUp(object sender, MouseEventArgs e)
        {
            Button _btn = (Button)sender;

            if (_btn.TabIndex == 1)//Stream mode
            {
                _btn.Image = Resource1.btn10_normal;
            }
            else if (_btn.TabIndex == 2)//Edit mode
            {
                _btn.Image = Resource1.btn11_normal;
            }
            else if (_btn.TabIndex == 3)//Edit mode
            {
                _btn.Image = Resource1.btn12_normal;
            }
            else
            {
                _btn.Image = Resource1.btn13_normal;
            }
        }

        private void button_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
