using System;
using System.Drawing;
using System.Windows.Forms;

namespace IndustrialHMI
{
    public partial class MainForm : Form
    {
        // 全局控件
        private Panel panelLeftMenu;     //左侧菜单栏
        private Panel panelMainContent;  //右侧主内容区
        private Label lblTitleTop;       //顶部标题

        // 5个页面面板
        private Panel pPageOverview;     //总览（原图界面）
        private Panel pPageControl;      //设备控制
        private Panel pPageTrend;        //数据趋势
        private Panel pPageAlarm;        //报警记录
        private Panel pPageSetting;      //系统设置

        //菜单按钮
        private Button btnMenuOverview, btnMenuDevice, btnMenuAlarm, btnMenuReport, btnMenuSetting;

        public MainForm()
        {
            BuildMainUI();
            BuildPage_Overview();
            BuildPage_Control();
            BuildPage_Trend();
            BuildPage_Alarm();
            BuildPage_Setting();
            SwitchPage(pPageOverview); //默认打开总览页
        }

        #region 主框架布局
        void BuildMainUI()
        {
            this.Text = "设备监控系统";
            this.Size = new Size(1720, 980);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(18, 26, 38);
            this.ForeColor = Color.FromArgb(80, 200, 255);
            this.FormBorderStyle = FormBorderStyle.Sizable;

            //顶部标题栏
            lblTitleTop = new Label
            {
                Text = "设备监控系统",
                Font = new Font("微软雅黑", 22, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(22,32,46),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(0,0),
                Size = new Size(this.ClientSize.Width,70)
            };

            //左侧菜单面板
            panelLeftMenu = new Panel
            {
                BackColor = Color.FromArgb(24,36,52),
                Location = new Point(0,70),
                Size = new Size(140, this.ClientSize.Height -70)
            };

            //右侧内容面板
            panelMainContent = new Panel
            {
                BackColor = Color.FromArgb(18,26,38),
                Location = new Point(140,70),
                Size = new Size(this.ClientSize.Width - 140, this.ClientSize.Height -70)
            };

            //菜单按钮
            int btnY = 20;
            Size menuBtnSize = new Size(130, 55);
            btnMenuOverview = CreateMenuBtn("🏠 总览", new Point(5, btnY), menuBtnSize);
            btnMenuOverview.Click += (s, e) => SwitchPage(pPageOverview);
            btnY += 60;

            btnMenuDevice = CreateMenuBtn("⚙ 设备", new Point(5, btnY), menuBtnSize);
            btnMenuDevice.Click += (s, e) => SwitchPage(pPageControl);
            btnY += 60;

            btnMenuAlarm = CreateMenuBtn("🔔 报警", new Point(5, btnY), menuBtnSize);
            btnMenuAlarm.Click += (s, e) => SwitchPage(pPageAlarm);
            btnY += 60;

            btnMenuReport = CreateMenuBtn("📊 报表", new Point(5, btnY), menuBtnSize);
            btnMenuReport.Click += (s, e) => SwitchPage(pPageTrend);
            btnY += 60;

            btnMenuSetting = CreateMenuBtn("🔧 设置", new Point(5, btnY), menuBtnSize);
            btnMenuSetting.Click += (s, e) => SwitchPage(pPageSetting);

            panelLeftMenu.Controls.AddRange(new Control[]
            {
                btnMenuOverview,btnMenuDevice,btnMenuAlarm,btnMenuReport,btnMenuSetting
            });

            this.Controls.Add(lblTitleTop);
            this.Controls.Add(panelLeftMenu);
            this.Controls.Add(panelMainContent);
        }

        //生成菜单按钮样式
        Button CreateMenuBtn(string text, Point loc, Size sz)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Location = loc;
            btn.Size = sz;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(28,42,60);
            btn.ForeColor = Color.FromArgb(120,210,255);
            btn.Font = new Font("微软雅黑",11);
            return btn;
        }

        //页面切换核心函数：隐藏所有页面，显示指定页面
        void SwitchPage(Panel targetPage)
        {
            Control[] pages = { pPageOverview, pPageControl, pPageTrend, pPageAlarm, pPageSetting };
            foreach(var p in pages)
            {
                if(p!=null) p.Visible = false;
            }
            targetPage.Visible = true;
        }
        #endregion

        #region 页面1：总览（对应截图界面框架）
        void BuildPage_Overview()
        {
            pPageOverview = new Panel();
            pPageOverview.Dock = DockStyle.Fill;
            pPageOverview.BackColor = Color.FromArgb(18,26,38);

            Label tip = new Label
            {
                Text = "【总览页面】\n可放置你截图中的6个设备状态卡片、右侧数据表、底部报警日志表格\n如需加载背景示意图：使用PictureBox放入本Panel内",
                ForeColor = Color.Cyan,
                Font = new Font("微软雅黑",11),
                Location = new Point(30,30),
                AutoSize = true
            };
            pPageOverview.Controls.Add(tip);
            panelMainContent.Controls.Add(pPageOverview);
        }
        #endregion

        #region 页面2：设备控制页
        void BuildPage_Control()
        {
            pPageControl = new Panel();
            pPageControl.Dock = DockStyle.Fill;
            pPageControl.BackColor = Color.FromArgb(18,26,38);

            Label pageTitle = new Label
            {
                Text = "▶ 设备手动控制",
                ForeColor = Color.FromArgb(80,200,255),
                Font = new Font("微软雅黑",16,FontStyle.Bold),
                Location = new Point(30,20),
                AutoSize = true
            };

            //模拟设备控制卡片
            GroupBox g1 = new GroupBox();
            g1.Text = "一号电机控制";
            g1.ForeColor = Color.LightSkyBlue;
            g1.BackColor = Color.FromArgb(25,38,55);
            g1.Location = new Point(30,70);
            g1.Size = new Size(320,180);

            Button btnRun1 = new Button{Text="启动",Location=new Point(40,60),Size=new Size(100,40),BackColor=Color.FromArgb(15,110,60),ForeColor=Color.White,FlatStyle=FlatStyle.Flat};
            Button btnStop1 = new Button{Text="停止",Location=new Point(170,60),Size=new Size(100,40),BackColor=Color.FromArgb(130,25,25),ForeColor=Color.White,FlatStyle=FlatStyle.Flat};
            Label status1 = new Label{Text="当前状态：待机",ForeColor=Color.White,Location=new Point(40,115),Size=new Size(200,25)};
            g1.Controls.AddRange(new Control[]{btnRun1,btnStop1,status1});

            GroupBox g2 = new GroupBox();
            g2.Text = "二号电机控制";
            g2.ForeColor = Color.LightSkyBlue;
            g2.BackColor = Color.FromArgb(25,38,55);
            g2.Location = new Point(380,70);
            g2.Size = new Size(320,180);

            Button btnRun2 = new Button{Text="启动",Location=new Point(40,60),Size=new Size(100,40),BackColor=Color.FromArgb(15,110,60),ForeColor=Color.White,FlatStyle=FlatStyle.Flat};
            Button btnStop2 = new Button{Text="停止",Location=new Point(170,60),Size=new Size(100,40),BackColor=Color.FromArgb(130,25,25),ForeColor=Color.White,FlatStyle=FlatStyle.Flat};
            Label status2 = new Label{Text="当前状态：待机",ForeColor=Color.White,Location=new Point(40,115),Size=new Size(200,25)};
            g2.Controls.AddRange(new Control[]{btnRun2,btnStop2,status2});

            GroupBox g3 = new GroupBox();
            g3.Text = "电磁阀控制";
            g3.ForeColor = Color.LightSkyBlue;
            g3.BackColor = Color.FromArgb(25,38,55);
            g3.Location = new Point(730,70);
            g3.Size = new Size(320,180);

            Button btnOpen = new Button{Text="开阀",Location=new Point(40,60),Size=new Size(100,40),BackColor=Color.FromArgb(15,80,120),ForeColor=Color.White,FlatStyle=FlatStyle.Flat};
            Button btnClose = new Button{Text="关阀",Location=new Point(170,60),Size=new Size(100,40),BackColor=Color.FromArgb(100,40,20),ForeColor=Color.White,FlatStyle=FlatStyle.Flat};
            Label status3 = new Label{Text="当前状态：关闭",ForeColor=Color.White,Location=new Point(40,115),Size=new Size(200,25)};
            g3.Controls.AddRange(new Control[]{btnOpen,btnClose,status3});

            Label tipChart = new Label
            {
                Text = "下方区域可添加实时参数仪表盘、转速/压力仪表图片",
                ForeColor = Color.Gray,
                Location = new Point(30,280),
                AutoSize = true
            };

            pPageControl.Controls.AddRange(new Control[]{pageTitle,g1,g2,g3,tipChart});
            panelMainContent.Controls.Add(pPageControl);
        }
        #endregion

        #region 页面3：数据趋势（报表曲线页）
        void BuildPage_Trend()
        {
            pPageTrend = new Panel();
            pPageTrend.Dock = DockStyle.Fill;
            pPageTrend.BackColor = Color.FromArgb(18,26,38);

            Label pageTitle = new Label
            {
                Text = "📈 历史数据&趋势曲线",
                ForeColor = Color.FromArgb(80,200,255),
                Font = new Font("微软雅黑",16,FontStyle.Bold),
                Location = new Point(30,20),
                AutoSize = true
            };

            GroupBox chartBox = new GroupBox();
            chartBox.Text = "温度&压力实时曲线";
            chartBox.ForeColor = Color.LightSkyBlue;
            chartBox.BackColor = Color.FromArgb(24,36,50);
            chartBox.Location = new Point(30,70);
            chartBox.Size = new Size(1100,420);

            Label chartTip = new Label
            {
                Text = "此处放置图表控件（可使用ZedGraph、NPlot或DevExpress图表）\nX轴：时间；Y轴：温度、压力、转速",
                ForeColor = Color.Aqua,
                Location = new Point(50,80),
                AutoSize = true
            };
            chartBox.Controls.Add(chartTip);

            GroupBox tableBox = new GroupBox();
            tableBox.Text = "历史数据表";
            tableBox.ForeColor = Color.LightSkyBlue;
            tableBox.BackColor = Color.FromArgb(24,36,50);
            tableBox.Location = new Point(30,510);
            tableBox.Size = new Size(1100,260);

            Label tableTip = new Label
            {
                Text = "放置DataGridView，列：时间、电机1转速、电机2转速、压力、温度",
                ForeColor = Color.Aqua,
                Location = new Point(50,60),
                AutoSize = true
            };
            tableBox.Controls.Add(tableTip);

            pPageTrend.Controls.AddRange(new Control[]{pageTitle,chartBox,tableBox});
            panelMainContent.Controls.Add(pPageTrend);
        }
        #endregion

        #region 页面4：报警记录页
        void BuildPage_Alarm()
        {
            pPageAlarm = new Panel();
            pPageAlarm.Dock = DockStyle.Fill;
            pPageAlarm.BackColor = Color.FromArgb(18,26,38);

            Label pageTitle = new Label
            {
                Text = "🔔 报警事件记录",
                ForeColor = Color.FromArgb(80,200,255),
                Font = new Font("微软雅黑",16,FontStyle.Bold),
                Location = new Point(30,20),
                AutoSize = true
            };

            //筛选面板
            Panel filterPanel = new Panel{BackColor=Color.FromArgb(26,38,52),Location=new Point(30,70),Size=new Size(1100,65)};
            Label lblSTime = new Label{Text="起始时间：",ForeColor=Color.White,Location=new Point(20,20),AutoSize=true};
            DateTimePicker dtStart = new DateTimePicker{Location=new Point(100,18),Size=new Size(180,25),BackColor=Color.FromArgb(30,44,62),ForeColor=Color.White};
            Label lblETime = new Label{Text="结束时间：",ForeColor=Color.White,Location=new Point(310,20),AutoSize=true};
            DateTimePicker dtEnd = new DateTimePicker{Location=new Point(390,18),Size=new Size(180,25),BackColor=Color.FromArgb(30,44,62),ForeColor=Color.White};
            Button btnQuery = new Button{Text="查询",Location=new Point(620,15),Size=new Size(100,32),BackColor=Color.FromArgb(20,90,140),ForeColor=Color.White,FlatStyle=FlatStyle.Flat};
            Button btnExport = new Button{Text="导出报表",Location=new Point(740,15),Size=new Size(100,32),BackColor=Color.FromArgb(25,100,75),ForeColor=Color.White,FlatStyle=FlatStyle.Flat};
            filterPanel.Controls.AddRange(new Control[]{lblSTime,dtStart,lblETime,dtEnd,btnQuery,btnExport});

            //报警表格
            GroupBox gridBox = new GroupBox();
            gridBox.Text = "报警列表";
            gridBox.ForeColor = Color.LightSkyBlue;
            gridBox.BackColor = Color.FromArgb(24,36,50);
            gridBox.Location = new Point(30,150);
            gridBox.Size = new Size(1100,580);

            Label gridTip = new Label
            {
                Text = "添加DataGridView，列：序号、报警时间、设备编号、报警类型、报警内容、状态、复位操作",
                ForeColor = Color.Aqua,
                Location = new Point(40,70),
                AutoSize = true
            };
            gridBox.Controls.Add(gridTip);

            pPageAlarm.Controls.AddRange(new Control[]{pageTitle,filterPanel,gridBox});
            panelMainContent.Controls.Add(pPageAlarm);
        }
        #endregion

        #region 页面5：系统设置页
        void BuildPage_Setting()
        {
            pPageSetting = new Panel();
            pPageSetting.Dock = DockStyle.Fill;
            pPageSetting.BackColor = Color.FromArgb(18,26,38);

            Label pageTitle = new Label
            {
                Text = "🔧 系统参数设置",
                ForeColor = Color.FromArgb(80,200,255),
                Font = new Font("微软雅黑",16,FontStyle.Bold),
                Location = new Point(30,20),
                AutoSize = true
            };

            GroupBox gParam = new GroupBox();
            gParam.Text = "设备阈值参数";
            gParam.ForeColor = Color.LightSkyBlue;
            gParam.BackColor = Color.FromArgb(25,38,55);
            gParam.Location = new Point(30,70);
            gParam.Size = new Size(480,320);

            Label lblTempMax = new Label{Text="温度上限：",ForeColor=Color.White,Location=new Point(35,40),Size=new Size(90,25)};
            TextBox txtTempMax = new TextBox{Text="85",Location=new Point(135,38),Size=new Size(120,25),BackColor=Color.FromArgb(32,48,68),ForeColor=Color.White};
            Label lblPressMax = new Label{Text="压力上限：",ForeColor=Color.White,Location=new Point(35,90),Size=new Size(90,25)};
            TextBox txtPressMax = new TextBox{Text="1.6",Location=new Point(135,88),Size=new Size(120,25),BackColor=Color.FromArgb(32,48,68),ForeColor=Color.White};
            Label lblSpeedMax = new Label{Text="转速上限：",ForeColor=Color.White,Location=new Point(35,140),Size=new Size(90,25)};
            TextBox txtSpeedMax = new TextBox{Text="2800",Location=new Point(135,138),Size=new Size(120,25),BackColor=Color.FromArgb(32,48,68),ForeColor=Color.White};
            Button btnSaveParam = new Button{Text="保存参数",Location=new Point(135,200),Size=new Size(120,35),BackColor=Color.FromArgb(18,105,70),ForeColor=Color.White,FlatStyle=FlatStyle.Flat};
            gParam.Controls.AddRange(new Control[]{lblTempMax,txtTempMax,lblPressMax,txtPressMax,lblSpeedMax,txtSpeedMax,btnSaveParam});

            GroupBox gComm = new GroupBox();
            gComm.Text = "通讯设置";
            gComm.ForeColor = Color.LightSkyBlue;
            gComm.BackColor = Color.FromArgb(25,38,55);
            gComm.Location = new Point(540,70);
            gComm.Size = new Size(480,320);

            Label lblIp = new Label{Text="PLC IP地址：",ForeColor=Color.White,Location=new Point(35,40),Size=new Size(100,25)};
            TextBox txtIp = new TextBox{Text="192.168.1.10",Location=new Point(145,38),Size=new Size(180,25),BackColor=Color.FromArgb(32,48,68),ForeColor=Color.White};
            Label lblPort = new Label{Text="端口号：",ForeColor=Color.White,Location=new Point(35,90),Size=new Size(100,25)};
            TextBox txtPort = new TextBox{Text="502",Location=new Point(145,88),Size=new Size(180,25),BackColor=Color.FromArgb(32,48,68),ForeColor=Color.White};
            Button btnConnTest = new Button{Text="测试连接",Location=new Point(145,200),Size=new Size(120,35),BackColor=Color.FromArgb(20,80,125),ForeColor=Color.White,FlatStyle=FlatStyle.Flat};
            gComm.Controls.AddRange(new Control[]{lblIp,txtIp,lblPort,txtPort,btnConnTest});

            pPageSetting.Controls.AddRange(new Control[]{pageTitle,gParam,gComm});
            panelMainContent.Controls.Add(pPageSetting);
        }
        #endregion
    }
}
