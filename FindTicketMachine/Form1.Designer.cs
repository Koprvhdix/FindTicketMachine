using System.Collections.Generic;
using System.Windows.Forms;
namespace FinalSearch
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LeaveStation = new System.Windows.Forms.TextBox();
            this.AimStation = new System.Windows.Forms.TextBox();
            this.LeaveDate = new System.Windows.Forms.TextBox();
            this.SearchTicket = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.GC = new System.Windows.Forms.CheckBox();
            this.D = new System.Windows.Forms.CheckBox();
            this.Z = new System.Windows.Forms.CheckBox();
            this.T = new System.Windows.Forms.CheckBox();
            this.K = new System.Windows.Forms.CheckBox();
            this.OtherTicket = new System.Windows.Forms.CheckBox();
            this.SelectDate = new System.Windows.Forms.MonthCalendar();
            this.Show = new System.Windows.Forms.DataGridView();
            this.PatchFirst = new System.Windows.Forms.CheckBox();
            this.DeepFirst = new System.Windows.Forms.CheckBox();
            this.DeepSecond = new System.Windows.Forms.CheckBox();
            this.AddTrainCode = new System.Windows.Forms.Button();
            this.SeatClass = new System.Windows.Forms.CheckedListBox();
            this.SelectTrainCode = new System.Windows.Forms.CheckedListBox();
            this.UserSelectTrain = new System.Windows.Forms.TextBox();
            this.NormalSearchTicket = new System.Windows.Forms.CheckBox();
            this.NormalSearchLabel = new System.Windows.Forms.Label();
            this.PatchLabel = new System.Windows.Forms.Label();
            this.DeepFirstLabel = new System.Windows.Forms.Label();
            this.TopDeepLabel = new System.Windows.Forms.Label();
            this.labelFinal = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).BeginInit();
            this.SuspendLayout();
            // 
            // LeaveStation
            // 
            this.LeaveStation.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LeaveStation.Location = new System.Drawing.Point(81, 86);
            this.LeaveStation.Name = "LeaveStation";
            this.LeaveStation.Size = new System.Drawing.Size(100, 26);
            this.LeaveStation.TabIndex = 0;
            this.LeaveStation.TextChanged += new System.EventHandler(this.LeaveStation_TextChanged);
            this.LeaveStation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeaveStationDown);
            // 
            // AimStation
            // 
            this.AimStation.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AimStation.Location = new System.Drawing.Point(81, 138);
            this.AimStation.Name = "AimStation";
            this.AimStation.Size = new System.Drawing.Size(100, 26);
            this.AimStation.TabIndex = 1;
            this.AimStation.TextChanged += new System.EventHandler(this.AimStation_TextChanged);
            this.AimStation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AimStationDown);
            // 
            // LeaveDate
            // 
            this.LeaveDate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LeaveDate.Location = new System.Drawing.Point(81, 203);
            this.LeaveDate.Name = "LeaveDate";
            this.LeaveDate.Size = new System.Drawing.Size(100, 26);
            this.LeaveDate.TabIndex = 2;
            this.LeaveDate.TextChanged += new System.EventHandler(this.LeaveDate_TextChanged);
            this.LeaveDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeaveDateMouseClick);
            // 
            // SearchTicket
            // 
            this.SearchTicket.Location = new System.Drawing.Point(81, 275);
            this.SearchTicket.Name = "SearchTicket";
            this.SearchTicket.Size = new System.Drawing.Size(75, 23);
            this.SearchTicket.TabIndex = 3;
            this.SearchTicket.UseVisualStyleBackColor = true;
            this.SearchTicket.Click += new System.EventHandler(this.SearchTicket_Click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(59, 374);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(30, 30);
            this.min.TabIndex = 4;
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(81, 365);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 5;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // GC
            // 
            this.GC.Location = new System.Drawing.Point(68, 330);
            this.GC.Name = "GC";
            this.GC.Size = new System.Drawing.Size(15, 14);
            this.GC.TabIndex = 6;
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(68, 350);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(15, 14);
            this.D.TabIndex = 7;
            this.D.UseVisualStyleBackColor = true;
            // 
            // Z
            // 
            this.Z.AutoSize = true;
            this.Z.Location = new System.Drawing.Point(27, 374);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(15, 14);
            this.Z.TabIndex = 8;
            this.Z.UseVisualStyleBackColor = true;
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Location = new System.Drawing.Point(40, 411);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(15, 14);
            this.T.TabIndex = 9;
            this.T.UseVisualStyleBackColor = true;
            // 
            // K
            // 
            this.K.AutoSize = true;
            this.K.Location = new System.Drawing.Point(59, 437);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(15, 14);
            this.K.TabIndex = 10;
            this.K.UseVisualStyleBackColor = true;
            // 
            // OtherTicket
            // 
            this.OtherTicket.AutoSize = true;
            this.OtherTicket.Location = new System.Drawing.Point(68, 472);
            this.OtherTicket.Name = "OtherTicket";
            this.OtherTicket.Size = new System.Drawing.Size(15, 14);
            this.OtherTicket.TabIndex = 11;
            this.OtherTicket.UseVisualStyleBackColor = true;
            // 
            // SelectDate
            // 
            this.SelectDate.Location = new System.Drawing.Point(277, 350);
            this.SelectDate.MinDate = new System.DateTime(2014, 10, 12, 0, 0, 0, 0);
            this.SelectDate.Name = "SelectDate";
            this.SelectDate.TabIndex = 12;
            this.SelectDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.SelectDate_DateChanged);
            // 
            // Show
            // 
            this.Show.AllowUserToAddRows = false;
            this.Show.AllowUserToDeleteRows = false;
            this.Show.AllowUserToResizeColumns = false;
            this.Show.AllowUserToResizeRows = false;
            this.Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17});
            this.Show.Location = new System.Drawing.Point(277, 107);
            this.Show.Name = "Show";
            this.Show.ReadOnly = true;
            this.Show.RowTemplate.Height = 23;
            this.Show.Size = new System.Drawing.Size(893, 450);
            this.Show.TabIndex = 14;
            // 
            // PatchFirst
            // 
            this.PatchFirst.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PatchFirst.ForeColor = System.Drawing.Color.White;
            this.PatchFirst.Location = new System.Drawing.Point(33, 34);
            this.PatchFirst.Name = "PatchFirst";
            this.PatchFirst.Size = new System.Drawing.Size(104, 24);
            this.PatchFirst.TabIndex = 15;
            this.PatchFirst.UseVisualStyleBackColor = true;
            this.PatchFirst.CheckedChanged += new System.EventHandler(this.PatchFirst_CheckedChanged);
            this.PatchFirst.MouseLeave += new System.EventHandler(this.PatchLeave);
            this.PatchFirst.MouseHover += new System.EventHandler(this.PatchOver);
            // 
            // DeepFirst
            // 
            this.DeepFirst.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeepFirst.ForeColor = System.Drawing.Color.White;
            this.DeepFirst.Location = new System.Drawing.Point(258, 34);
            this.DeepFirst.Name = "DeepFirst";
            this.DeepFirst.Size = new System.Drawing.Size(104, 24);
            this.DeepFirst.TabIndex = 17;
            this.DeepFirst.UseVisualStyleBackColor = true;
            this.DeepFirst.CheckedChanged += new System.EventHandler(this.DeepFirst_CheckedChanged);
            this.DeepFirst.MouseLeave += new System.EventHandler(this.DeepFirstLeave);
            this.DeepFirst.MouseHover += new System.EventHandler(this.DeepFirstOver);
            // 
            // DeepSecond
            // 
            this.DeepSecond.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeepSecond.ForeColor = System.Drawing.Color.White;
            this.DeepSecond.Location = new System.Drawing.Point(393, 34);
            this.DeepSecond.Name = "DeepSecond";
            this.DeepSecond.Size = new System.Drawing.Size(104, 24);
            this.DeepSecond.TabIndex = 18;
            this.DeepSecond.UseVisualStyleBackColor = true;
            this.DeepSecond.CheckedChanged += new System.EventHandler(this.DeepSecond_CheckedChanged);
            this.DeepSecond.MouseLeave += new System.EventHandler(this.TopDeepLeave);
            this.DeepSecond.MouseHover += new System.EventHandler(this.TopDeepOver);
            // 
            // AddTrainCode
            // 
            this.AddTrainCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddTrainCode.Location = new System.Drawing.Point(617, 13);
            this.AddTrainCode.Name = "AddTrainCode";
            this.AddTrainCode.Size = new System.Drawing.Size(27, 64);
            this.AddTrainCode.TabIndex = 19;
            this.AddTrainCode.UseVisualStyleBackColor = true;
            this.AddTrainCode.Click += new System.EventHandler(this.AddTrainCode_Click);
            // 
            // SeatClass
            // 
            this.SeatClass.FormattingEnabled = true;
            this.SeatClass.Items.AddRange(new object[] {
            "二等座",
            "软卧",
            "硬卧",
            "硬座",
            "无座"});
            this.SeatClass.Location = new System.Drawing.Point(17, 86);
            this.SeatClass.Name = "SeatClass";
            this.SeatClass.Size = new System.Drawing.Size(120, 84);
            this.SeatClass.TabIndex = 20;
            // 
            // SelectTrainCode
            // 
            this.SelectTrainCode.FormattingEnabled = true;
            this.SelectTrainCode.Location = new System.Drawing.Point(151, 86);
            this.SelectTrainCode.Name = "SelectTrainCode";
            this.SelectTrainCode.Size = new System.Drawing.Size(120, 84);
            this.SelectTrainCode.TabIndex = 21;
            // 
            // UserSelectTrain
            // 
            this.UserSelectTrain.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserSelectTrain.Location = new System.Drawing.Point(311, 80);
            this.UserSelectTrain.Name = "UserSelectTrain";
            this.UserSelectTrain.Size = new System.Drawing.Size(100, 29);
            this.UserSelectTrain.TabIndex = 22;
            this.UserSelectTrain.TextChanged += new System.EventHandler(this.UserSelectTrain_TextChanged);
            // 
            // NormalSearchTicket
            // 
            this.NormalSearchTicket.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NormalSearchTicket.ForeColor = System.Drawing.Color.White;
            this.NormalSearchTicket.Location = new System.Drawing.Point(134, 34);
            this.NormalSearchTicket.Name = "NormalSearchTicket";
            this.NormalSearchTicket.Size = new System.Drawing.Size(104, 24);
            this.NormalSearchTicket.TabIndex = 23;
            this.NormalSearchTicket.UseVisualStyleBackColor = true;
            this.NormalSearchTicket.CheckedChanged += new System.EventHandler(this.NormalSearchTicket_CheckedChanged);
            this.NormalSearchTicket.MouseLeave += new System.EventHandler(this.NormalSearchLeave);
            this.NormalSearchTicket.MouseHover += new System.EventHandler(this.NormalSearchOver);
            // 
            // NormalSearchLabel
            // 
            this.NormalSearchLabel.BackColor = System.Drawing.Color.White;
            this.NormalSearchLabel.Location = new System.Drawing.Point(316, 195);
            this.NormalSearchLabel.Name = "NormalSearchLabel";
            this.NormalSearchLabel.Size = new System.Drawing.Size(60, 34);
            this.NormalSearchLabel.TabIndex = 24;
            this.NormalSearchLabel.Text = "提供普通查询。";
            this.NormalSearchLabel.Visible = false;
            // 
            // PatchLabel
            // 
            this.PatchLabel.BackColor = System.Drawing.Color.White;
            this.PatchLabel.Location = new System.Drawing.Point(496, 253);
            this.PatchLabel.Name = "PatchLabel";
            this.PatchLabel.Size = new System.Drawing.Size(86, 58);
            this.PatchLabel.TabIndex = 25;
            this.PatchLabel.Text = "自动查询从本站到中途某站的车票，请自行补票。";
            // 
            // DeepFirstLabel
            // 
            this.DeepFirstLabel.BackColor = System.Drawing.Color.White;
            this.DeepFirstLabel.Location = new System.Drawing.Point(366, 247);
            this.DeepFirstLabel.Name = "DeepFirstLabel";
            this.DeepFirstLabel.Size = new System.Drawing.Size(100, 70);
            this.DeepFirstLabel.TabIndex = 26;
            this.DeepFirstLabel.Text = "自动搜索出发站前4站及目的站后4站之内有余票的区间，提供购票选择。";
            // 
            // TopDeepLabel
            // 
            this.TopDeepLabel.BackColor = System.Drawing.Color.White;
            this.TopDeepLabel.Location = new System.Drawing.Point(615, 253);
            this.TopDeepLabel.Name = "TopDeepLabel";
            this.TopDeepLabel.Size = new System.Drawing.Size(100, 58);
            this.TopDeepLabel.TabIndex = 27;
            this.TopDeepLabel.Text = "自动搜索本车次上所有区间的余票信息，提供购票选择。";
            // 
            // labelFinal
            // 
            this.labelFinal.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFinal.Location = new System.Drawing.Point(456, 61);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(79, 23);
            this.labelFinal.TabIndex = 28;
            this.labelFinal.Text = "车次添加";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "车次";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "出发站";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "到达站";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "出发时间";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "到达时间";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "历时";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "商务座";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "特等座";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "一等座";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "二等座";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 50;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "高级软卧";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 50;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "软卧";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 50;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "硬卧";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 50;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "软座";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 50;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "硬座";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 50;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "无座";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 50;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "其它";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.labelFinal);
            this.Controls.Add(this.TopDeepLabel);
            this.Controls.Add(this.DeepFirstLabel);
            this.Controls.Add(this.PatchLabel);
            this.Controls.Add(this.NormalSearchLabel);
            this.Controls.Add(this.NormalSearchTicket);
            this.Controls.Add(this.SelectDate);
            this.Controls.Add(this.UserSelectTrain);
            this.Controls.Add(this.SelectTrainCode);
            this.Controls.Add(this.SeatClass);
            this.Controls.Add(this.AddTrainCode);
            this.Controls.Add(this.DeepSecond);
            this.Controls.Add(this.DeepFirst);
            this.Controls.Add(this.PatchFirst);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.OtherTicket);
            this.Controls.Add(this.K);
            this.Controls.Add(this.T);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.D);
            this.Controls.Add(this.GC);
            this.Controls.Add(this.close);
            this.Controls.Add(this.min);
            this.Controls.Add(this.SearchTicket);
            this.Controls.Add(this.LeaveDate);
            this.Controls.Add(this.AimStation);
            this.Controls.Add(this.LeaveStation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        const int WM_NCHITTEST = 0x0084;
        const int HT_LEFT = 10;
        const int HT_RIGHT = 11;
        const int HT_TOP = 12;
        const int HT_TOPLEFT = 13;
        const int HT_TOPRIGHT = 14;
        const int HT_BOTTOM = 15;
        const int HT_BOTTOMLEFT = 16;
        const int HT_BOTTOMRIGHT = 17;
        const int HT_CAPTION = 2;
        private List<Station> stationList;
        private System.Windows.Forms.TextBox LeaveStation;
        private System.Windows.Forms.TextBox AimStation;
        private System.Windows.Forms.TextBox LeaveDate;
        private List<TextBox> PageText;
        private Button SearchTicket;
        private Button min;
        private Button close;
        private CheckBox GC;
        private CheckBox D;
        private CheckBox Z;
        private CheckBox T;
        private CheckBox K;
        private CheckBox OtherTicket;
        private List<CheckBox> PageTrainClass;
        private MonthCalendar SelectDate;
        private DataGridView Show;
        private CheckBox PatchFirst;
        private CheckBox DeepFirst;
        private CheckBox DeepSecond;

        private List<CheckBox> DeepSearch;
        private Button AddTrainCode;
        private Search FirstSearch;
        private Search DFirstSearch;
        private bool FirstSe;
        
        private CheckedListBox SeatClass;
        private CheckedListBox SelectTrainCode;
        private TextBox UserSelectTrain;
        private List<string> SaveTrainCode;
        private CheckBox NormalSearchTicket;
        private Label NormalSearchLabel;
        private Label PatchLabel;
        private Label DeepFirstLabel;
        private Label TopDeepLabel;
        private Label labelFinal;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
       
    }
}

