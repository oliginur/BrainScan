namespace BrainScan
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_stream = new System.Windows.Forms.Panel();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.panel_mainmenu_tab1 = new System.Windows.Forms.Panel();
            this.btn_main_tab1_5 = new System.Windows.Forms.Button();
            this.btn_main_tab1_4 = new System.Windows.Forms.Button();
            this.btn_main_tab1_3 = new System.Windows.Forms.Button();
            this.btn_main_tab1_2 = new System.Windows.Forms.Button();
            this.btn_main_tab1_1 = new System.Windows.Forms.Button();
            this.panel_mainmenu_tab2 = new System.Windows.Forms.Panel();
            this.btn_main_tab2_4 = new System.Windows.Forms.Button();
            this.btn_main_tab2_3 = new System.Windows.Forms.Button();
            this.btn_main_tab2_2 = new System.Windows.Forms.Button();
            this.btn_main_tab2_1 = new System.Windows.Forms.Button();
            this.panel_mainmenu_tab3 = new System.Windows.Forms.Panel();
            this.btn_main_tab3_4 = new System.Windows.Forms.Button();
            this.btn_main_tab3_3 = new System.Windows.Forms.Button();
            this.btn_main_tab3_2 = new System.Windows.Forms.Button();
            this.btn_main_tab3_1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cartesianChart_8 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart_7 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart_6 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart_5 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart_4 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart_3 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart_2 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart_1 = new LiveCharts.WinForms.CartesianChart();
            this.timer_dropdown_panel1 = new System.Windows.Forms.Timer(this.components);
            this.timer_dropdown_panel2 = new System.Windows.Forms.Timer(this.components);
            this.timer_dropdown_panel3 = new System.Windows.Forms.Timer(this.components);
            this.panel_mainmenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_main_tab3 = new System.Windows.Forms.Button();
            this.btn_main_tab2 = new System.Windows.Forms.Button();
            this.btn_main_tab1 = new System.Windows.Forms.Button();
            this.panel_titlebar = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_btstatus = new System.Windows.Forms.Label();
            this.panel_stream.SuspendLayout();
            this.panel_edit.SuspendLayout();
            this.panel_mainmenu_tab1.SuspendLayout();
            this.panel_mainmenu_tab2.SuspendLayout();
            this.panel_mainmenu_tab3.SuspendLayout();
            this.panel_mainmenu.SuspendLayout();
            this.panel_titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_stream
            // 
            this.panel_stream.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel_stream.Controls.Add(this.panel_edit);
            this.panel_stream.Controls.Add(this.groupBox2);
            this.panel_stream.Controls.Add(this.groupBox1);
            this.panel_stream.Controls.Add(this.cartesianChart_8);
            this.panel_stream.Controls.Add(this.cartesianChart_7);
            this.panel_stream.Controls.Add(this.cartesianChart_6);
            this.panel_stream.Controls.Add(this.cartesianChart_5);
            this.panel_stream.Controls.Add(this.cartesianChart_4);
            this.panel_stream.Controls.Add(this.cartesianChart_3);
            this.panel_stream.Controls.Add(this.cartesianChart_2);
            this.panel_stream.Controls.Add(this.cartesianChart_1);
            this.panel_stream.Location = new System.Drawing.Point(206, 25);
            this.panel_stream.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel_stream.Name = "panel_stream";
            this.panel_stream.Size = new System.Drawing.Size(1767, 1055);
            this.panel_stream.TabIndex = 1;
            // 
            // panel_edit
            // 
            this.panel_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel_edit.Controls.Add(this.panel_mainmenu_tab1);
            this.panel_edit.Controls.Add(this.panel_mainmenu_tab2);
            this.panel_edit.Controls.Add(this.panel_mainmenu_tab3);
            this.panel_edit.Controls.Add(this.label2);
            this.panel_edit.Location = new System.Drawing.Point(206, 25);
            this.panel_edit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(1767, 1055);
            this.panel_edit.TabIndex = 3;
            // 
            // panel_mainmenu_tab1
            // 
            this.panel_mainmenu_tab1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_mainmenu_tab1.Controls.Add(this.btn_main_tab1_5);
            this.panel_mainmenu_tab1.Controls.Add(this.btn_main_tab1_4);
            this.panel_mainmenu_tab1.Controls.Add(this.btn_main_tab1_3);
            this.panel_mainmenu_tab1.Controls.Add(this.btn_main_tab1_2);
            this.panel_mainmenu_tab1.Controls.Add(this.btn_main_tab1_1);
            this.panel_mainmenu_tab1.Location = new System.Drawing.Point(20, 86);
            this.panel_mainmenu_tab1.MaximumSize = new System.Drawing.Size(363, 1055);
            this.panel_mainmenu_tab1.MinimumSize = new System.Drawing.Size(206, 1055);
            this.panel_mainmenu_tab1.Name = "panel_mainmenu_tab1";
            this.panel_mainmenu_tab1.Size = new System.Drawing.Size(363, 1055);
            this.panel_mainmenu_tab1.TabIndex = 10;
            // 
            // btn_main_tab1_5
            // 
            this.btn_main_tab1_5.BackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab1_5.BackgroundImage = global::BrainScan.Resource1.btn5_normal;
            this.btn_main_tab1_5.FlatAppearance.BorderSize = 0;
            this.btn_main_tab1_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab1_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab1_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab1_5.Location = new System.Drawing.Point(259, 58);
            this.btn_main_tab1_5.Name = "btn_main_tab1_5";
            this.btn_main_tab1_5.Size = new System.Drawing.Size(52, 52);
            this.btn_main_tab1_5.TabIndex = 5;
            this.btn_main_tab1_5.UseVisualStyleBackColor = false;
            this.btn_main_tab1_5.Click += new System.EventHandler(this.button_button_list1_items);
            this.btn_main_tab1_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab1_img_MouseDown);
            this.btn_main_tab1_5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab1_img_MouseUp);
            // 
            // btn_main_tab1_4
            // 
            this.btn_main_tab1_4.BackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab1_4.BackgroundImage = global::BrainScan.Resource1.btn4_normal;
            this.btn_main_tab1_4.FlatAppearance.BorderSize = 0;
            this.btn_main_tab1_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab1_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab1_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab1_4.Location = new System.Drawing.Point(206, 58);
            this.btn_main_tab1_4.Name = "btn_main_tab1_4";
            this.btn_main_tab1_4.Size = new System.Drawing.Size(52, 52);
            this.btn_main_tab1_4.TabIndex = 4;
            this.btn_main_tab1_4.UseVisualStyleBackColor = false;
            this.btn_main_tab1_4.Click += new System.EventHandler(this.button_button_list1_items);
            this.btn_main_tab1_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab1_img_MouseDown);
            this.btn_main_tab1_4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab1_img_MouseUp);
            // 
            // btn_main_tab1_3
            // 
            this.btn_main_tab1_3.BackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab1_3.BackgroundImage = global::BrainScan.Resource1.btn3_normal;
            this.btn_main_tab1_3.FlatAppearance.BorderSize = 0;
            this.btn_main_tab1_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab1_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab1_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab1_3.Location = new System.Drawing.Point(311, 0);
            this.btn_main_tab1_3.Name = "btn_main_tab1_3";
            this.btn_main_tab1_3.Size = new System.Drawing.Size(52, 52);
            this.btn_main_tab1_3.TabIndex = 4;
            this.btn_main_tab1_3.UseVisualStyleBackColor = false;
            this.btn_main_tab1_3.Click += new System.EventHandler(this.button_button_list1_items);
            this.btn_main_tab1_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab1_img_MouseDown);
            this.btn_main_tab1_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab1_img_MouseUp);
            // 
            // btn_main_tab1_2
            // 
            this.btn_main_tab1_2.BackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab1_2.BackgroundImage = global::BrainScan.Resource1.btn2_normal;
            this.btn_main_tab1_2.FlatAppearance.BorderSize = 0;
            this.btn_main_tab1_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab1_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab1_2.Location = new System.Drawing.Point(259, 0);
            this.btn_main_tab1_2.Name = "btn_main_tab1_2";
            this.btn_main_tab1_2.Size = new System.Drawing.Size(52, 52);
            this.btn_main_tab1_2.TabIndex = 2;
            this.btn_main_tab1_2.UseVisualStyleBackColor = false;
            this.btn_main_tab1_2.Click += new System.EventHandler(this.button_button_list1_items);
            this.btn_main_tab1_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab1_img_MouseDown);
            this.btn_main_tab1_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab1_img_MouseUp);
            // 
            // btn_main_tab1_1
            // 
            this.btn_main_tab1_1.BackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab1_1.BackgroundImage = global::BrainScan.Resource1.btn1_normal;
            this.btn_main_tab1_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_main_tab1_1.FlatAppearance.BorderSize = 0;
            this.btn_main_tab1_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab1_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab1_1.Location = new System.Drawing.Point(206, 0);
            this.btn_main_tab1_1.Name = "btn_main_tab1_1";
            this.btn_main_tab1_1.Size = new System.Drawing.Size(52, 52);
            this.btn_main_tab1_1.TabIndex = 1;
            this.btn_main_tab1_1.UseVisualStyleBackColor = false;
            this.btn_main_tab1_1.Click += new System.EventHandler(this.button_button_list1_items);
            this.btn_main_tab1_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab1_img_MouseDown);
            this.btn_main_tab1_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab1_img_MouseUp);
            // 
            // panel_mainmenu_tab2
            // 
            this.panel_mainmenu_tab2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_mainmenu_tab2.Controls.Add(this.btn_main_tab2_4);
            this.panel_mainmenu_tab2.Controls.Add(this.btn_main_tab2_3);
            this.panel_mainmenu_tab2.Controls.Add(this.btn_main_tab2_2);
            this.panel_mainmenu_tab2.Controls.Add(this.btn_main_tab2_1);
            this.panel_mainmenu_tab2.Location = new System.Drawing.Point(430, 88);
            this.panel_mainmenu_tab2.MaximumSize = new System.Drawing.Size(363, 1055);
            this.panel_mainmenu_tab2.MinimumSize = new System.Drawing.Size(206, 1055);
            this.panel_mainmenu_tab2.Name = "panel_mainmenu_tab2";
            this.panel_mainmenu_tab2.Size = new System.Drawing.Size(206, 1055);
            this.panel_mainmenu_tab2.TabIndex = 11;
            // 
            // btn_main_tab2_4
            // 
            this.btn_main_tab2_4.BackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab2_4.BackgroundImage = global::BrainScan.Resource1.btn9_normal;
            this.btn_main_tab2_4.FlatAppearance.BorderSize = 0;
            this.btn_main_tab2_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab2_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab2_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab2_4.Location = new System.Drawing.Point(206, 58);
            this.btn_main_tab2_4.Name = "btn_main_tab2_4";
            this.btn_main_tab2_4.Size = new System.Drawing.Size(52, 52);
            this.btn_main_tab2_4.TabIndex = 4;
            this.btn_main_tab2_4.UseVisualStyleBackColor = false;
            this.btn_main_tab2_4.Click += new System.EventHandler(this.button_button_list2_items);
            this.btn_main_tab2_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab2_img_MouseDown);
            this.btn_main_tab2_4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab2_img_MouseUp);
            // 
            // btn_main_tab2_3
            // 
            this.btn_main_tab2_3.BackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab2_3.BackgroundImage = global::BrainScan.Resource1.btn8_normal;
            this.btn_main_tab2_3.FlatAppearance.BorderSize = 0;
            this.btn_main_tab2_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab2_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab2_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab2_3.Location = new System.Drawing.Point(311, 0);
            this.btn_main_tab2_3.Name = "btn_main_tab2_3";
            this.btn_main_tab2_3.Size = new System.Drawing.Size(52, 52);
            this.btn_main_tab2_3.TabIndex = 3;
            this.btn_main_tab2_3.UseVisualStyleBackColor = false;
            this.btn_main_tab2_3.Click += new System.EventHandler(this.button_button_list2_items);
            this.btn_main_tab2_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab2_img_MouseDown);
            this.btn_main_tab2_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab2_img_MouseUp);
            // 
            // btn_main_tab2_2
            // 
            this.btn_main_tab2_2.BackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab2_2.BackgroundImage = global::BrainScan.Resource1.btn7_normal;
            this.btn_main_tab2_2.FlatAppearance.BorderSize = 0;
            this.btn_main_tab2_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab2_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab2_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab2_2.Location = new System.Drawing.Point(259, 0);
            this.btn_main_tab2_2.Name = "btn_main_tab2_2";
            this.btn_main_tab2_2.Size = new System.Drawing.Size(52, 52);
            this.btn_main_tab2_2.TabIndex = 2;
            this.btn_main_tab2_2.UseVisualStyleBackColor = false;
            this.btn_main_tab2_2.Click += new System.EventHandler(this.button_button_list2_items);
            this.btn_main_tab2_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab2_img_MouseDown);
            this.btn_main_tab2_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab2_img_MouseUp);
            // 
            // btn_main_tab2_1
            // 
            this.btn_main_tab2_1.BackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab2_1.BackgroundImage = global::BrainScan.Resource1.btn6_normal;
            this.btn_main_tab2_1.FlatAppearance.BorderSize = 0;
            this.btn_main_tab2_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab2_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab2_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab2_1.Location = new System.Drawing.Point(206, 0);
            this.btn_main_tab2_1.Name = "btn_main_tab2_1";
            this.btn_main_tab2_1.Size = new System.Drawing.Size(52, 52);
            this.btn_main_tab2_1.TabIndex = 1;
            this.btn_main_tab2_1.UseVisualStyleBackColor = false;
            this.btn_main_tab2_1.Click += new System.EventHandler(this.button_button_list2_items);
            this.btn_main_tab2_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab2_img_MouseDown);
            this.btn_main_tab2_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab2_img_MouseUp);
            // 
            // panel_mainmenu_tab3
            // 
            this.panel_mainmenu_tab3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_mainmenu_tab3.Controls.Add(this.btn_main_tab3_4);
            this.panel_mainmenu_tab3.Controls.Add(this.btn_main_tab3_3);
            this.panel_mainmenu_tab3.Controls.Add(this.btn_main_tab3_2);
            this.panel_mainmenu_tab3.Controls.Add(this.btn_main_tab3_1);
            this.panel_mainmenu_tab3.Location = new System.Drawing.Point(819, 88);
            this.panel_mainmenu_tab3.MaximumSize = new System.Drawing.Size(363, 1055);
            this.panel_mainmenu_tab3.MinimumSize = new System.Drawing.Size(206, 1055);
            this.panel_mainmenu_tab3.Name = "panel_mainmenu_tab3";
            this.panel_mainmenu_tab3.Size = new System.Drawing.Size(206, 1055);
            this.panel_mainmenu_tab3.TabIndex = 12;
            // 
            // btn_main_tab3_4
            // 
            this.btn_main_tab3_4.BackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab3_4.BackgroundImage = global::BrainScan.Resource1.btn13_normal;
            this.btn_main_tab3_4.FlatAppearance.BorderSize = 0;
            this.btn_main_tab3_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab3_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab3_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab3_4.Location = new System.Drawing.Point(206, 58);
            this.btn_main_tab3_4.Name = "btn_main_tab3_4";
            this.btn_main_tab3_4.Size = new System.Drawing.Size(52, 52);
            this.btn_main_tab3_4.TabIndex = 4;
            this.btn_main_tab3_4.UseVisualStyleBackColor = false;
            this.btn_main_tab3_4.Click += new System.EventHandler(this.button_button_list3_items);
            this.btn_main_tab3_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab3_img_MouseDown);
            this.btn_main_tab3_4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab3_img_MouseUp);
            // 
            // btn_main_tab3_3
            // 
            this.btn_main_tab3_3.BackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab3_3.BackgroundImage = global::BrainScan.Resource1.btn12_normal;
            this.btn_main_tab3_3.FlatAppearance.BorderSize = 0;
            this.btn_main_tab3_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab3_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab3_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab3_3.Location = new System.Drawing.Point(311, 0);
            this.btn_main_tab3_3.Name = "btn_main_tab3_3";
            this.btn_main_tab3_3.Size = new System.Drawing.Size(52, 52);
            this.btn_main_tab3_3.TabIndex = 3;
            this.btn_main_tab3_3.UseVisualStyleBackColor = false;
            this.btn_main_tab3_3.Click += new System.EventHandler(this.button_button_list3_items);
            this.btn_main_tab3_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab3_img_MouseDown);
            this.btn_main_tab3_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab3_img_MouseUp);
            // 
            // btn_main_tab3_2
            // 
            this.btn_main_tab3_2.BackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab3_2.BackgroundImage = global::BrainScan.Resource1.btn11_normal;
            this.btn_main_tab3_2.FlatAppearance.BorderSize = 0;
            this.btn_main_tab3_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab3_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab3_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab3_2.Location = new System.Drawing.Point(259, 0);
            this.btn_main_tab3_2.Name = "btn_main_tab3_2";
            this.btn_main_tab3_2.Size = new System.Drawing.Size(52, 52);
            this.btn_main_tab3_2.TabIndex = 2;
            this.btn_main_tab3_2.UseVisualStyleBackColor = false;
            this.btn_main_tab3_2.Click += new System.EventHandler(this.button_button_list3_items);
            this.btn_main_tab3_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab3_img_MouseDown);
            this.btn_main_tab3_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab3_img_MouseUp);
            // 
            // btn_main_tab3_1
            // 
            this.btn_main_tab3_1.BackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab3_1.BackgroundImage = global::BrainScan.Resource1.btn10_normal;
            this.btn_main_tab3_1.FlatAppearance.BorderSize = 0;
            this.btn_main_tab3_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab3_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_main_tab3_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab3_1.Location = new System.Drawing.Point(206, 0);
            this.btn_main_tab3_1.Name = "btn_main_tab3_1";
            this.btn_main_tab3_1.Size = new System.Drawing.Size(52, 52);
            this.btn_main_tab3_1.TabIndex = 1;
            this.btn_main_tab3_1.UseVisualStyleBackColor = false;
            this.btn_main_tab3_1.Click += new System.EventHandler(this.button_button_list3_items);
            this.btn_main_tab3_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab3_img_MouseDown);
            this.btn_main_tab3_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_main_tab3_img_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(57, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 64);
            this.label2.TabIndex = 0;
            this.label2.Text = "Edit Mode";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(902, 551);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 492);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "|     Item2     |";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(902, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 532);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "|     Item1     |";
            // 
            // cartesianChart_8
            // 
            this.cartesianChart_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cartesianChart_8.Location = new System.Drawing.Point(1, 926);
            this.cartesianChart_8.Name = "cartesianChart_8";
            this.cartesianChart_8.Size = new System.Drawing.Size(883, 125);
            this.cartesianChart_8.TabIndex = 8;
            this.cartesianChart_8.Text = "cartesianChart8";
            // 
            // cartesianChart_7
            // 
            this.cartesianChart_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cartesianChart_7.Location = new System.Drawing.Point(1, 801);
            this.cartesianChart_7.Name = "cartesianChart_7";
            this.cartesianChart_7.Size = new System.Drawing.Size(883, 125);
            this.cartesianChart_7.TabIndex = 7;
            this.cartesianChart_7.Text = "cartesianChart7";
            // 
            // cartesianChart_6
            // 
            this.cartesianChart_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cartesianChart_6.Location = new System.Drawing.Point(1, 676);
            this.cartesianChart_6.Name = "cartesianChart_6";
            this.cartesianChart_6.Size = new System.Drawing.Size(883, 125);
            this.cartesianChart_6.TabIndex = 6;
            this.cartesianChart_6.Text = "cartesianChart6";
            // 
            // cartesianChart_5
            // 
            this.cartesianChart_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cartesianChart_5.Location = new System.Drawing.Point(1, 551);
            this.cartesianChart_5.Name = "cartesianChart_5";
            this.cartesianChart_5.Size = new System.Drawing.Size(883, 125);
            this.cartesianChart_5.TabIndex = 5;
            this.cartesianChart_5.Text = "cartesianChart5";
            // 
            // cartesianChart_4
            // 
            this.cartesianChart_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cartesianChart_4.Location = new System.Drawing.Point(1, 426);
            this.cartesianChart_4.Name = "cartesianChart_4";
            this.cartesianChart_4.Size = new System.Drawing.Size(883, 125);
            this.cartesianChart_4.TabIndex = 4;
            this.cartesianChart_4.Text = "cartesianChart4";
            // 
            // cartesianChart_3
            // 
            this.cartesianChart_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cartesianChart_3.Location = new System.Drawing.Point(1, 301);
            this.cartesianChart_3.Name = "cartesianChart_3";
            this.cartesianChart_3.Size = new System.Drawing.Size(883, 125);
            this.cartesianChart_3.TabIndex = 3;
            this.cartesianChart_3.Text = "cartesianChart3";
            // 
            // cartesianChart_2
            // 
            this.cartesianChart_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cartesianChart_2.Location = new System.Drawing.Point(1, 176);
            this.cartesianChart_2.Name = "cartesianChart_2";
            this.cartesianChart_2.Size = new System.Drawing.Size(883, 125);
            this.cartesianChart_2.TabIndex = 2;
            this.cartesianChart_2.Text = "cartesianChart2";
            // 
            // cartesianChart_1
            // 
            this.cartesianChart_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cartesianChart_1.Location = new System.Drawing.Point(1, 51);
            this.cartesianChart_1.Name = "cartesianChart_1";
            this.cartesianChart_1.Size = new System.Drawing.Size(883, 125);
            this.cartesianChart_1.TabIndex = 1;
            this.cartesianChart_1.Text = "cartesianChart1";
            // 
            // timer_dropdown_panel1
            // 
            this.timer_dropdown_panel1.Interval = 5;
            this.timer_dropdown_panel1.Tick += new System.EventHandler(this.timer_dropdown_panel1_Tick);
            // 
            // timer_dropdown_panel2
            // 
            this.timer_dropdown_panel2.Interval = 5;
            this.timer_dropdown_panel2.Tick += new System.EventHandler(this.timer_dropdown_panel2_Tick);
            // 
            // timer_dropdown_panel3
            // 
            this.timer_dropdown_panel3.Interval = 5;
            this.timer_dropdown_panel3.Tick += new System.EventHandler(this.timer_dropdown_panel3_Tick);
            // 
            // panel_mainmenu
            // 
            this.panel_mainmenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_mainmenu.Controls.Add(this.button1);
            this.panel_mainmenu.Controls.Add(this.btn_main_tab3);
            this.panel_mainmenu.Controls.Add(this.btn_main_tab2);
            this.panel_mainmenu.Controls.Add(this.btn_main_tab1);
            this.panel_mainmenu.Location = new System.Drawing.Point(0, 25);
            this.panel_mainmenu.Name = "panel_mainmenu";
            this.panel_mainmenu.Size = new System.Drawing.Size(206, 1055);
            this.panel_mainmenu.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(0, 1015);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_close_Click);
            // 
            // btn_main_tab3
            // 
            this.btn_main_tab3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_main_tab3.FlatAppearance.BorderSize = 0;
            this.btn_main_tab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_main_tab3.Image = ((System.Drawing.Image)(resources.GetObject("btn_main_tab3.Image")));
            this.btn_main_tab3.Location = new System.Drawing.Point(0, 163);
            this.btn_main_tab3.Name = "btn_main_tab3";
            this.btn_main_tab3.Size = new System.Drawing.Size(206, 50);
            this.btn_main_tab3.TabIndex = 3;
            this.btn_main_tab3.Text = "MainMenu3";
            this.btn_main_tab3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_main_tab3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_main_tab3.UseVisualStyleBackColor = true;
            this.btn_main_tab3.Click += new System.EventHandler(this.button_dropdown_list_Click);
            // 
            // btn_main_tab2
            // 
            this.btn_main_tab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_main_tab2.FlatAppearance.BorderSize = 0;
            this.btn_main_tab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_main_tab2.Image = ((System.Drawing.Image)(resources.GetObject("btn_main_tab2.Image")));
            this.btn_main_tab2.Location = new System.Drawing.Point(0, 107);
            this.btn_main_tab2.Name = "btn_main_tab2";
            this.btn_main_tab2.Size = new System.Drawing.Size(206, 50);
            this.btn_main_tab2.TabIndex = 2;
            this.btn_main_tab2.Text = "MainMenu2";
            this.btn_main_tab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_main_tab2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_main_tab2.UseVisualStyleBackColor = true;
            this.btn_main_tab2.Click += new System.EventHandler(this.button_dropdown_list_Click);
            // 
            // btn_main_tab1
            // 
            this.btn_main_tab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_main_tab1.FlatAppearance.BorderSize = 0;
            this.btn_main_tab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_tab1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_main_tab1.Image = ((System.Drawing.Image)(resources.GetObject("btn_main_tab1.Image")));
            this.btn_main_tab1.Location = new System.Drawing.Point(0, 51);
            this.btn_main_tab1.Name = "btn_main_tab1";
            this.btn_main_tab1.Size = new System.Drawing.Size(206, 50);
            this.btn_main_tab1.TabIndex = 1;
            this.btn_main_tab1.Text = "Bluetooth";
            this.btn_main_tab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_main_tab1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_main_tab1.UseVisualStyleBackColor = true;
            this.btn_main_tab1.Click += new System.EventHandler(this.button_dropdown_list_Click);
            // 
            // panel_titlebar
            // 
            this.panel_titlebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_titlebar.BackColor = System.Drawing.Color.Transparent;
            this.panel_titlebar.BackgroundImage = global::BrainScan.Resource1.TitleBar2;
            this.panel_titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_titlebar.Controls.Add(this.button_close);
            this.panel_titlebar.Controls.Add(this.pictureBox1);
            this.panel_titlebar.Controls.Add(this.label_btstatus);
            this.panel_titlebar.Location = new System.Drawing.Point(0, 0);
            this.panel_titlebar.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel_titlebar.Name = "panel_titlebar";
            this.panel_titlebar.Size = new System.Drawing.Size(1919, 25);
            this.panel_titlebar.TabIndex = 2;
            this.panel_titlebar.DoubleClick += new System.EventHandler(this.panel_titlebar_DoubleClick);
            this.panel_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titlebar_MouseDown);
            this.panel_titlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_titlebar_MouseMove);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(1886, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(33, 25);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BrainScan.Resource1.bt_discon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(206, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_btstatus
            // 
            this.label_btstatus.AutoSize = true;
            this.label_btstatus.BackColor = System.Drawing.Color.Transparent;
            this.label_btstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_btstatus.Location = new System.Drawing.Point(223, 4);
            this.label_btstatus.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label_btstatus.Name = "label_btstatus";
            this.label_btstatus.Size = new System.Drawing.Size(123, 17);
            this.label_btstatus.TabIndex = 0;
            this.label_btstatus.Text = "Connection Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1919, 1080);
            this.Controls.Add(this.panel_mainmenu);
            this.Controls.Add(this.panel_titlebar);
            this.Controls.Add(this.panel_stream);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "BrainScan";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_stream.ResumeLayout(false);
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            this.panel_mainmenu_tab1.ResumeLayout(false);
            this.panel_mainmenu_tab2.ResumeLayout(false);
            this.panel_mainmenu_tab3.ResumeLayout(false);
            this.panel_mainmenu.ResumeLayout(false);
            this.panel_titlebar.ResumeLayout(false);
            this.panel_titlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_titlebar;
        private System.Windows.Forms.Panel panel_stream;
        private System.Windows.Forms.Label label_btstatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_dropdown_panel1;
        private System.Windows.Forms.Timer timer_dropdown_panel2;
        private System.Windows.Forms.Timer timer_dropdown_panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private LiveCharts.WinForms.CartesianChart cartesianChart_8;
        private LiveCharts.WinForms.CartesianChart cartesianChart_7;
        private LiveCharts.WinForms.CartesianChart cartesianChart_6;
        private LiveCharts.WinForms.CartesianChart cartesianChart_5;
        private LiveCharts.WinForms.CartesianChart cartesianChart_4;
        private LiveCharts.WinForms.CartesianChart cartesianChart_3;
        private LiveCharts.WinForms.CartesianChart cartesianChart_2;
        private LiveCharts.WinForms.CartesianChart cartesianChart_1;
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.Panel panel_mainmenu;
        private System.Windows.Forms.Panel panel_mainmenu_tab1;
        private System.Windows.Forms.Panel panel_mainmenu_tab2;
        private System.Windows.Forms.Panel panel_mainmenu_tab3;
        private System.Windows.Forms.Button btn_main_tab1_5;
        private System.Windows.Forms.Button btn_main_tab1_4;
        private System.Windows.Forms.Button btn_main_tab1_3;
        private System.Windows.Forms.Button btn_main_tab1_2;
        private System.Windows.Forms.Button btn_main_tab1_1;
        private System.Windows.Forms.Button btn_main_tab2_4;
        private System.Windows.Forms.Button btn_main_tab2_3;
        private System.Windows.Forms.Button btn_main_tab2_2;
        private System.Windows.Forms.Button btn_main_tab2_1;
        private System.Windows.Forms.Button btn_main_tab3_4;
        private System.Windows.Forms.Button btn_main_tab3_3;
        private System.Windows.Forms.Button btn_main_tab3_2;
        private System.Windows.Forms.Button btn_main_tab3_1;
        private System.Windows.Forms.Button btn_main_tab3;
        private System.Windows.Forms.Button btn_main_tab2;
        private System.Windows.Forms.Button btn_main_tab1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_close;
    }
}

