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

namespace FinalSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            stationList = new List<Station>();
            FileStream file = File.OpenRead("trainStation.txt");
            StreamReader sr = new StreamReader(file, Encoding.GetEncoding("gb2312"));
            string s, final = "";
            while ((s = sr.ReadLine()) != null)
            {
                final += s;
            }

            string name, code;
            int position1 = 0, position2 = 0, position3 = 0, number;
            Station station1;
            number = final.LastIndexOf('；');
            position1 = final.IndexOf('、');
            position2 = final.IndexOf('；');
            name = final.Substring(0, position1);
            code = final.Substring(position1 + 1, position2 - position1 - 1);
            station1 = new Station(name, code);
            stationList.Add(station1);
            for (; ; )
            {
                position3 = position2 + 1;
                position1 = final.IndexOf('、', position3);
                position2 = final.IndexOf('；', position3);
                name = final.Substring(position3, position1 - position3);
                code = final.Substring(position1 + 1, position2 - position1 - 1);
                station1 = new Station(name, code);
                stationList.Add(station1);
                if (position2 == number)
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("First2.jpg");
            int YData1 = 143;
            PageText = new List<TextBox>();
            PageText.Add(LeaveStation);
            PageText.Add(AimStation);
            PageText.Add(LeaveDate);
            for (int i = 0; i < PageText.Count(); i++)
            {
                PageText[i].Location = new Point(110, YData1 += 45);
                PageText[i].Width = 90;
                PageText[i].BorderStyle = BorderStyle.None;
            }

            //最小化按钮、关闭按钮
            min.Location = new Point(1075, 4);
            close.Location = new Point(1113, 4);
            min.FlatStyle = FlatStyle.Flat;
            close.FlatStyle = FlatStyle.Flat;
            min.FlatAppearance.BorderSize = 0;
            close.FlatAppearance.BorderSize = 0;
            min.BackColor = Color.Transparent;
            close.BackColor = Color.Transparent;
            min.ForeColor = Color.Transparent;
            close.ForeColor = Color.Transparent;
            min.FlatAppearance.MouseDownBackColor = Color.Transparent;
            close.FlatAppearance.MouseDownBackColor = Color.Transparent;
            min.FlatAppearance.MouseOverBackColor = Color.Transparent;
            close.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //查询按钮
            SearchTicket.FlatStyle = FlatStyle.Flat;
            SearchTicket.FlatAppearance.BorderSize = 0;
            SearchTicket.BackColor = Color.Transparent;
            SearchTicket.ForeColor = Color.Transparent;
            SearchTicket.FlatAppearance.MouseDownBackColor = Color.Transparent;
            SearchTicket.FlatAppearance.MouseOverBackColor = Color.Transparent;
            SearchTicket.Location = new Point(49, 316);
            SearchTicket.Height = 30;
            SearchTicket.Width = 160;

            //车次选择按钮
            PageTrainClass = new List<CheckBox>();
            PageTrainClass.Add(GC);
            PageTrainClass.Add(D);
            PageTrainClass.Add(Z);
            PageTrainClass.Add(T);
            PageTrainClass.Add(K);
            PageTrainClass.Add(OtherTicket);
            int YData = 316;
            for (int i = 0; i < PageTrainClass.Count(); i++)
            {
                PageTrainClass[i].Location = new Point(65, YData += 45);
                PageTrainClass[i].AutoSize = false;
                PageTrainClass[i].Height = 30;
                PageTrainClass[i].Width = 130;
                PageTrainClass[i].BackColor = Color.Transparent;
            }

            SelectDate.Visible = false;
            SelectDate.Location = new Point(220, 240);
            SelectDate.MinDate = DateTime.Today;
            SelectDate.MaxDate = DateTime.Today.AddDays(19);


            DeepSearch = new List<CheckBox>();
            DeepSearch.Add(NormalSearchTicket);
            DeepSearch.Add(DeepFirst);
            DeepSearch.Add(DeepSecond);
            DeepSearch.Add(PatchFirst);
            for (int i = 0; i < DeepSearch.Count(); i++)
            {
                DeepSearch[i].Location = new Point(240 + i * 50, 85);
                DeepSearch[i].CheckAlign = ContentAlignment.TopCenter;
                DeepSearch[i].Height = 85;
                DeepSearch[i].Width = 25;
                DeepSearch[i].BackColor = Color.Transparent;
            }
            NormalSearchTicket.Checked = true;

            NormalSearchLabel.Visible = false;
            NormalSearchLabel.Location = new Point(NormalSearchTicket.Location.X + 26, NormalSearchTicket.Location.Y);
            NormalSearchLabel.BorderStyle = BorderStyle.FixedSingle;
            DeepFirstLabel.Visible = false;
            DeepFirstLabel.Location = new Point(DeepFirst.Location.X + 26, DeepFirst.Location.Y);
            DeepFirstLabel.BorderStyle = BorderStyle.FixedSingle;
            TopDeepLabel.Visible = false;
            TopDeepLabel.Location = new Point(DeepSecond.Location.X + 26, DeepSecond.Location.Y);
            TopDeepLabel.BorderStyle = BorderStyle.FixedSingle;
            PatchLabel.Visible = false;
            PatchLabel.Location = new Point(PatchFirst.Location.X + 26, PatchFirst.Location.Y);
            PatchLabel.BorderStyle = BorderStyle.FixedSingle;

            labelFinal.Location = new Point(490, 175);
            labelFinal.BackColor = Color.White;
            labelFinal.Visible = false;
            
            AddTrainCode.Location = new Point(600, 200);
            AddTrainCode.Height = 29;
            AddTrainCode.Width = 29;
            AddTrainCode.FlatStyle = FlatStyle.Flat;
            AddTrainCode.FlatAppearance.BorderSize = 0;
            AddTrainCode.BackgroundImage = Image.FromFile("Add.jpg");
            AddTrainCode.Visible = false;

            SeatClass.Location = new Point(220, 175);
            SeatClass.BorderStyle = BorderStyle.None;
            SeatClass.Visible = false;
            SelectTrainCode.Location = new Point(350, 175);
            SelectTrainCode.BorderStyle = BorderStyle.None;
            SelectTrainCode.Visible = false;
            UserSelectTrain.Location = new Point(490, 200);
            UserSelectTrain.Visible = false;

            //DataGirdView
            Show.Location = new Point(230, 270);
            Show.Height = 360;
            Show.Width = 893;
            Show.Visible = true;
            Show.BackgroundColor = Color.White;
            Show.BorderStyle = BorderStyle.None;
            Show.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Show.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            this.MaximumSize = new Size(this.Width, this.Height);
            this.MinimumSize = new Size(this.Width, this.Height);
            FirstSe = true;
            SaveTrainCode = new List<string>();
        }

        protected override void WndProc(ref Message Msg)
        {
            if (Msg.Msg == WM_NCHITTEST)
            {
                //获取鼠标位置
                int nPosX = (Msg.LParam.ToInt32() & 65535);
                int nPosY = (Msg.LParam.ToInt32() >> 16);
                //右下角
                if (nPosX >= this.Right - 6 && nPosY >= this.Bottom - 6)
                {
                    Msg.Result = new IntPtr(HT_BOTTOMRIGHT);
                    return;
                }
                //左上角
                else if (nPosX <= this.Left + 6 && nPosY <= this.Top + 6)
                {
                    Msg.Result = new IntPtr(HT_TOPLEFT);
                    return;
                }
                //左下角
                else if (nPosX <= this.Left + 6 && nPosY >= this.Bottom - 6)
                {
                    Msg.Result = new IntPtr(HT_BOTTOMLEFT);
                    return;
                }
                //右上角
                else if (nPosX >= this.Right - 6 && nPosY <= this.Top + 6)
                {
                    Msg.Result = new IntPtr(HT_TOPRIGHT);
                    return;
                }
                else if (nPosX >= this.Right - 2)
                {
                    Msg.Result = new IntPtr(HT_RIGHT);
                    return;
                }
                else if (nPosY >= this.Bottom - 2)
                {
                    Msg.Result = new IntPtr(HT_BOTTOM);
                    return;
                }
                else if (nPosX <= this.Left + 2)
                {
                    Msg.Result = new IntPtr(HT_LEFT);
                    return;
                }
                else if (nPosY <= this.Top + 2)
                {
                    Msg.Result = new IntPtr(HT_TOP);
                    return;
                }
                else
                {
                    Msg.Result = new IntPtr(HT_CAPTION);
                    return;
                }
            }
            base.WndProc(ref Msg);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            System.GC.Collect();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SearchTicket_Click(object sender, EventArgs e)
        {

            Show.RowCount = 0;
            //make sure that every TextBox have a right data
            if (LeaveStation.Text == string.Empty || AimStation.Text == string.Empty || LeaveDate.Text == string.Empty)
            {
                MessageBox.Show("亲，请输入相应参数");
                return;
            }
            int count1 = 0, count2 = 0;
            string fromStation = "";
            string toStation = "";
            for (int i = 0; i < stationList.Count; i++)
            {
                if (stationList[i].chinese == LeaveStation.Text)
                {
                    fromStation = stationList[i].code;
                    count1++;
                }
                if (stationList[i].chinese == AimStation.Text)
                {
                    toStation = stationList[i].code;
                    count2++;
                }
                if (count1 == 1 && count2 == 1)
                    break;
            }
            if (count1 == 0 && count2 == 0)
            {
                MessageBox.Show("亲，您输入的出发地和出发地均不存在");
                LeaveStation.Text = string.Empty;
                AimStation.Text = string.Empty;
                return;
            }
            else if (count2 == 0)
            {
                MessageBox.Show("亲，您输入的目的地不存在");
                AimStation.Text = string.Empty;
                return;
            }
            else if (count1 == 0)
            {
                MessageBox.Show("亲，您输入的出发地不存在");
                LeaveStation.Text = string.Empty;
                return;
            }


            if (NormalSearchTicket.Checked == true)
            {
                FirstSearch = new Search(fromStation, toStation, LeaveStation.Text, AimStation.Text, LeaveDate.Text, stationList);
                FirstSearch.NormalSearch();
                for (int i = 0; i < FirstSearch.show.Count(); i++)
                {
                    bool bj = true;
                    for (int a = 0; a < PageTrainClass.Count; a++)
                    {
                        if (PageTrainClass[a].Checked == true)
                        {
                            bj = false;
                            break;
                        }
                    }
                    if (bj == false)
                    {
                        switch (FirstSearch.show[i].trainCode[0])
                        {
                            case 'G':
                                if (PageTrainClass[0].Checked == true)
                                    bj = true;
                                break;                               
                            case 'C':
                                if (PageTrainClass[0].Checked == true)
                                    bj = true;
                                break;
                            case 'D':
                                if (PageTrainClass[1].Checked == true)
                                    bj = true;
                                break;
                            case 'Z':
                                if (PageTrainClass[2].Checked == true)
                                    bj = true;
                                break;
                            case 'T':
                                if (PageTrainClass[3].Checked == true)
                                    bj = true;
                                break;
                            case 'K':
                                if (PageTrainClass[4].Checked == true)
                                    bj = true;
                                break;
                            default:
                                if (PageTrainClass[5].Checked == true)
                                    bj = true;
                                break;
                        }
                    }
                    if (bj == true)
                        Show.Rows.Add(FirstSearch.show[i].trainCode,
                            FirstSearch.show[i].fromStationName,
                            FirstSearch.show[i].toStationName,
                            FirstSearch.show[i].startTime,
                            FirstSearch.show[i].arriveTime,
                            FirstSearch.show[i].spendTime,
                            FirstSearch.show[i].BusinessTicket,
                            FirstSearch.show[i].TopGradeTicket,
                            FirstSearch.show[i].FirstClassTicket,
                            FirstSearch.show[i].SecondClassTicket,
                            FirstSearch.show[i].AdvancedSoftSleeperTicket,
                            FirstSearch.show[i].SoftSleeperTicket,
                            FirstSearch.show[i].HardSleeperTicket,
                            FirstSearch.show[i].SoftSeatTicket,
                            FirstSearch.show[i].HardSeatTicket,
                            FirstSearch.show[i].NoneSeatTicket,
                            FirstSearch.show[i].Other);
                }
                for (int i = 0; i < 5; i++)
                {
                    SeatClass.SetItemChecked(i, false);
                }
                for (int i = SaveTrainCode.Count() - 1; i >= 0; i--)
                {
                    SaveTrainCode.RemoveAt(i);
                    SelectTrainCode.Items.RemoveAt(i);
                }

                for (int i = 0; i < FirstSearch.GetAnother.Count(); i++)
                {
                    SelectTrainCode.Items.Add(FirstSearch.GetAnother[i].TrainCode);
                    SaveTrainCode.Add(FirstSearch.GetAnother[i].TrainCode);
                }
            }
            else
            {
                List<string> GetSelectedTrain = new List<string>();
                string pem = "";

                DFirstSearch = new Search(fromStation, toStation, LeaveStation.Text, AimStation.Text, LeaveDate.Text, stationList);
                DFirstSearch.NormalSearch();

                for (int i = 0; i < SaveTrainCode.Count; i++)
                {
                    if (SelectTrainCode.GetItemChecked(i))
                    {
                        pem = SaveTrainCode[i];
                        GetSelectedTrain.Add(pem);
                    }
                }

                if (GetSelectedTrain.Count() == 0)
                {
                    MessageBox.Show("亲，请添加或选择车次");
                    return;
                }

                List<int> SeatClassCheck = new List<int>();
                for (int i = 0; i < 5; i++)
                {
                    if (SeatClass.GetItemChecked(i))
                    {
                        SeatClassCheck.Add(i);
                    }
                }

                if (SeatClassCheck.Count() == 0)
                {
                    MessageBox.Show("亲，请选择查找座位类型");
                    return;
                }
                bool next = true;
                int FinalBJ1 = 0;
                int FinalBJ2 = 0;
                int FinalBJ3 = 0;
                for (int j = 0; j < DFirstSearch.trainCode.Count(); j++)
                {
                    for (int k = 0; k < GetSelectedTrain.Count(); k++)
                    {
                        if (DFirstSearch.trainCode[j].trainCode == GetSelectedTrain[k])
                        {
                            DFirstSearch.trainCode[j].getInformation();
                            DFirstSearch.trainCode[j].SortTime();
                            for (int i = 1; i < DeepSearch.Count(); i++)
                            {
                                switch (i)
                                {
                                    case 1: if (DeepSearch[i].Checked == true)
                                        {
                                            next = DFirstSearch.trainCode[j].FirstDeepSearchTicket(SeatClassCheck);
                                            if (next == true)
                                            {
                                                Show.Rows.Add(DFirstSearch.trainCode[j].show1.trainCode,
                                                        DFirstSearch.trainCode[j].show1.fromStationName,
                                                        DFirstSearch.trainCode[j].show1.toStationName,
                                                        DFirstSearch.trainCode[j].show1.startTime,
                                                        DFirstSearch.trainCode[j].show1.arriveTime,
                                                        DFirstSearch.trainCode[j].show1.spendTime,
                                                        DFirstSearch.trainCode[j].show1.BusinessTicket,
                                                        DFirstSearch.trainCode[j].show1.TopGradeTicket,
                                                        DFirstSearch.trainCode[j].show1.FirstClassTicket,
                                                        DFirstSearch.trainCode[j].show1.SecondClassTicket,
                                                        DFirstSearch.trainCode[j].show1.AdvancedSoftSleeperTicket,
                                                        DFirstSearch.trainCode[j].show1.SoftSleeperTicket,
                                                        DFirstSearch.trainCode[j].show1.HardSleeperTicket,
                                                        DFirstSearch.trainCode[j].show1.SoftSeatTicket,
                                                        DFirstSearch.trainCode[j].show1.HardSeatTicket,
                                                        DFirstSearch.trainCode[j].show1.NoneSeatTicket,
                                                        DFirstSearch.trainCode[j].show1.Other);
                                                FinalBJ1 = 1;
                                            }
                                            else
                                                MessageBox.Show("亲，很抱歉，都没票了");
                                        }
                                        break;
                                    case 2: if (DeepSearch[i].Checked == true)
                                        {
                                            next = DFirstSearch.trainCode[j].TopDeepSearchTicket(SeatClassCheck);
                                            if (next == true)
                                            {
                                                if (FinalBJ1 == 1)
                                                {
                                                    if (DFirstSearch.trainCode[j].show2.trainCode == DFirstSearch.trainCode[j].show1.trainCode
                                                        && DFirstSearch.trainCode[j].show2.fromStationName == DFirstSearch.trainCode[j].show1.fromStationName
                                                        && DFirstSearch.trainCode[j].show2.toStationName == DFirstSearch.trainCode[j].show1.toStationName)
                                                        FinalBJ2 = 3;
                                                }
                                                if (FinalBJ2 == 0)
                                                {
                                                    Show.Rows.Add(DFirstSearch.trainCode[j].show2.trainCode,
                                                           DFirstSearch.trainCode[j].show2.fromStationName,
                                                           DFirstSearch.trainCode[j].show2.toStationName,
                                                           DFirstSearch.trainCode[j].show2.startTime,
                                                           DFirstSearch.trainCode[j].show2.arriveTime,
                                                           DFirstSearch.trainCode[j].show2.spendTime,
                                                           DFirstSearch.trainCode[j].show2.BusinessTicket,
                                                           DFirstSearch.trainCode[j].show2.TopGradeTicket,
                                                           DFirstSearch.trainCode[j].show2.FirstClassTicket,
                                                           DFirstSearch.trainCode[j].show2.SecondClassTicket,
                                                           DFirstSearch.trainCode[j].show2.AdvancedSoftSleeperTicket,
                                                           DFirstSearch.trainCode[j].show2.SoftSleeperTicket,
                                                           DFirstSearch.trainCode[j].show2.HardSleeperTicket,
                                                           DFirstSearch.trainCode[j].show2.SoftSeatTicket,
                                                           DFirstSearch.trainCode[j].show2.HardSeatTicket,
                                                           DFirstSearch.trainCode[j].show2.NoneSeatTicket,
                                                           DFirstSearch.trainCode[j].show2.Other);
                                                    FinalBJ2 = 1;
                                                }
                                                
                                            }
                                            else
                                                MessageBox.Show("亲，很抱歉，都没票了");
                                        }
                                        break;
                                    case 3: if (DeepSearch[i].Checked == true)
                                        {
                                            next = DFirstSearch.trainCode[j].PatchDeepSearchTicket(SeatClassCheck);
                                            if (next == true)
                                            {
                                                if (FinalBJ1 == 1)
                                                {
                                                    if (DFirstSearch.trainCode[j].show3.trainCode == DFirstSearch.trainCode[j].show1.trainCode
                                                        && DFirstSearch.trainCode[j].show3.fromStationName == DFirstSearch.trainCode[j].show1.fromStationName
                                                        && DFirstSearch.trainCode[j].show3.toStationName == DFirstSearch.trainCode[j].show1.toStationName)
                                                        FinalBJ3 = 3;
                                                }
                                                if (FinalBJ2 == 1 && FinalBJ3 == 0)
                                                {
                                                    if (DFirstSearch.trainCode[j].show3.trainCode == DFirstSearch.trainCode[j].show2.trainCode
                                                        && DFirstSearch.trainCode[j].show3.fromStationName == DFirstSearch.trainCode[j].show2.fromStationName
                                                        && DFirstSearch.trainCode[j].show3.toStationName == DFirstSearch.trainCode[j].show2.toStationName)
                                                        FinalBJ2 = 3;
                                                }
                                                if (FinalBJ3 == 0)
                                                {
                                                    Show.Rows.Add(DFirstSearch.trainCode[j].show3.trainCode,
                                                           DFirstSearch.trainCode[j].show3.fromStationName,
                                                           DFirstSearch.trainCode[j].show3.toStationName,
                                                           DFirstSearch.trainCode[j].show3.startTime,
                                                           DFirstSearch.trainCode[j].show3.arriveTime,
                                                           DFirstSearch.trainCode[j].show3.spendTime,
                                                           DFirstSearch.trainCode[j].show3.BusinessTicket,
                                                           DFirstSearch.trainCode[j].show3.TopGradeTicket,
                                                           DFirstSearch.trainCode[j].show3.FirstClassTicket,
                                                           DFirstSearch.trainCode[j].show3.SecondClassTicket,
                                                           DFirstSearch.trainCode[j].show3.AdvancedSoftSleeperTicket,
                                                           DFirstSearch.trainCode[j].show3.SoftSleeperTicket,
                                                           DFirstSearch.trainCode[j].show3.HardSleeperTicket,
                                                           DFirstSearch.trainCode[j].show3.SoftSeatTicket,
                                                           DFirstSearch.trainCode[j].show3.HardSeatTicket,
                                                           DFirstSearch.trainCode[j].show3.NoneSeatTicket,
                                                           DFirstSearch.trainCode[j].show3.Other);
                                                }
                                            }
                                            else
                                                MessageBox.Show("亲，很抱歉，都没票了");
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }

        private void SelectDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            string date1 = e.Start.ToString();
            int position1 = date1.IndexOf(' ');
            string date2 = date1.Substring(0, position1);
            int position2, position3;
            position2 = date1.IndexOf('/');
            position3 = date2.LastIndexOf('/');
            date2 = date2.Replace('/', '-');
            if (date2.Count() - position3 == 2)
                date2 = date2.Insert(position3 + 1, "0");
            if (position3 - position2 == 2)
                date2 = date2.Insert(position2 + 1, "0");
            LeaveDate.Text = date2;
            SelectDate.Visible = false;
        }

        private void LeaveDateMouseClick(object sender, MouseEventArgs e)
        {
            if (SelectDate.Visible == false)
                SelectDate.Visible = true;
            else
                SelectDate.Visible = false;
        }

        private void LeaveDate_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                SeatClass.SetItemChecked(i, false);
            }
            for (int i = SaveTrainCode.Count() - 1; i >= 0; i--)
            {
                SaveTrainCode.RemoveAt(i);
                SelectTrainCode.Items.RemoveAt(i);
            }
            SelectDate.Visible = true;
        }

        private void AimStationDown(object sender, MouseEventArgs e)
        {
            SelectDate.Visible = false;
            string Leave=LeaveStation.Text;
            int BJ = 0;
            for (int i = 0; i < stationList.Count(); i++)
            {
                if (stationList[i].chinese == Leave)
                {
                    BJ = 1;
                    break;
                }
            }
            if (BJ == 0)
                LeaveStation.Text = string.Empty;
        }

        private void LeaveStationDown(object sender, MouseEventArgs e)
        {
            SelectDate.Visible = false;
            string Aim = AimStation.Text;
            int BJ = 0;
            for (int i = 0; i < stationList.Count(); i++)
            {
                if (stationList[i].chinese == Aim)
                {
                    BJ = 1;
                }
            }
            if (BJ == 0)
                AimStation.Text = string.Empty;
        }

        private void AddTrainCode_Click(object sender, EventArgs e)
        {
            if (UserSelectTrain.Text == string.Empty)
                return;
            int BJ = 0;
            for (int i = 0; i < SaveTrainCode.Count(); i++)
            {
                if (UserSelectTrain.Text == SaveTrainCode[i])
                {
                    BJ = 1;
                    SelectTrainCode.SetItemChecked(i, true);
                    break;
                }
            }
            if (BJ == 0)
            {
                SelectTrainCode.Items.Add(UserSelectTrain.Text);
                SaveTrainCode.Add(UserSelectTrain.Text);
                int number = SaveTrainCode.Count() - 1;
                SelectTrainCode.SetItemChecked(number, true);
            }
            UserSelectTrain.Text = string.Empty;
        }

        private void LeaveStation_TextChanged(object sender, EventArgs e)
        {
            LeaveStation.Text = LeaveStation.Text.Replace(" ", "");
            for (int i = 0; i < 5; i++)
            {
                SeatClass.SetItemChecked(i, false);
            }
            for (int i = SaveTrainCode.Count() - 1; i >= 0; i--)
            {
                SaveTrainCode.RemoveAt(i);
                SelectTrainCode.Items.RemoveAt(i);
            }
        }

        private void AimStation_TextChanged(object sender, EventArgs e)
        {
            AimStation.Text = AimStation.Text.Replace(" ", "");
            for (int i = 0; i < 5; i++)
            {
                SeatClass.SetItemChecked(i, false);
            }
            for (int i = SaveTrainCode.Count() - 1; i >= 0; i--)
            {
                SaveTrainCode.RemoveAt(i);
                SelectTrainCode.Items.RemoveAt(i);
            }
        }

        private void UserSelectTrain_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (UserSelectTrain.Text.StartsWith("G") || UserSelectTrain.Text.StartsWith("C")
                || UserSelectTrain.Text.StartsWith("D") || UserSelectTrain.Text.StartsWith("T")
                || UserSelectTrain.Text.StartsWith("Z") || UserSelectTrain.Text.StartsWith("K")
                )
            {
                if (UserSelectTrain.Text.Count() > 1)
                {
                    string test = UserSelectTrain.Text.Substring(1, UserSelectTrain.Text.Count() - 1);
                    if (int.TryParse(test, out result))
                    {

                    }
                    else
                    {
                        UserSelectTrain.Text = string.Empty;
                    }
                }
            }
            else if(int.TryParse(UserSelectTrain.Text, out result))
            {

            }
            else
            {
                UserSelectTrain.Text = string.Empty;
            }
        }

        private void DeepFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (DeepFirst.Checked == true)
            {
                NormalSearchTicket.Checked = false;
                SeatClass.Visible = true;
                SelectTrainCode.Visible = true;
                UserSelectTrain.Visible = true;
                AddTrainCode.Visible = true;
                labelFinal.Visible = true;
                for (int i = 0; i < PageTrainClass.Count(); i++)
                {
                    PageTrainClass[i].Checked = false;
                }
            }
            if (DeepFirst.Checked == false && DeepSecond.Checked == false && PatchFirst.Checked == false)
            {
                NormalSearchTicket.Checked = true;
                SeatClass.Visible = false;
                SelectTrainCode.Visible = false;
                UserSelectTrain.Visible = false;
                AddTrainCode.Visible = false;
                labelFinal.Visible = false;
                for (int i = 0; i < 5; i++)
                {
                    SeatClass.SetItemChecked(i, false);
                }
                for (int i = SaveTrainCode.Count()-1; i >= 0; i--)
                {
                    SaveTrainCode.RemoveAt(i);
                    SelectTrainCode.Items.RemoveAt(i);
                }
            }
        }

        private void DeepSecond_CheckedChanged(object sender, EventArgs e)
        {
            if (DeepSecond.Checked == true)
            {
                NormalSearchTicket.Checked = false;
                SeatClass.Visible = true;
                SelectTrainCode.Visible = true;
                UserSelectTrain.Visible = true;
                AddTrainCode.Visible = true;
                labelFinal.Visible = true;
                for (int i = 0; i < PageTrainClass.Count(); i++)
                {
                    PageTrainClass[i].Checked = false;
                }
            }
            if (DeepFirst.Checked == false && DeepSecond.Checked == false && PatchFirst.Checked == false)
            {
                NormalSearchTicket.Checked = true;
                SeatClass.Visible = false;
                SelectTrainCode.Visible = false;
                UserSelectTrain.Visible = false;
                AddTrainCode.Visible = false;
                labelFinal.Visible = false;
                for (int i = 0; i < 5; i++)
                {
                    SeatClass.SetItemChecked(i, false);
                }
                for (int i = SaveTrainCode.Count() - 1; i >= 0; i--)
                {
                    SaveTrainCode.RemoveAt(i);
                    SelectTrainCode.Items.RemoveAt(i);
                }
            }
        }

        private void PatchFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (PatchFirst.Checked == true)
            {
                NormalSearchTicket.Checked = false;
                SeatClass.Visible = true;
                SelectTrainCode.Visible = true;
                UserSelectTrain.Visible = true;
                AddTrainCode.Visible = true;
                labelFinal.Visible = true;
                for (int i = 0; i < PageTrainClass.Count(); i++)
                {
                    PageTrainClass[i].Checked = false;
                }
            }
            if (DeepFirst.Checked == false && DeepSecond.Checked == false && PatchFirst.Checked == false)
            {
                NormalSearchTicket.Checked = true;
                SeatClass.Visible = false;
                SelectTrainCode.Visible = false;
                UserSelectTrain.Visible = false;
                AddTrainCode.Visible = false;
                labelFinal.Visible = false;
                for (int i = 0; i < 5; i++)
                {
                    SeatClass.SetItemChecked(i, false);
                }
                for (int i = SaveTrainCode.Count() - 1; i >= 0; i--)
                {
                    SaveTrainCode.RemoveAt(i);
                    SelectTrainCode.Items.RemoveAt(i);
                }
            }
        }

        private void NormalSearchTicket_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalSearchTicket.Checked == true)
            {
                DeepFirst.Checked = false;
                DeepSecond.Checked = false;
                PatchFirst.Checked = false;
                SeatClass.Visible = false;
                SelectTrainCode.Visible = false;
                UserSelectTrain.Visible = false;
                AddTrainCode.Visible = false;
                labelFinal.Visible = false;
                for (int i = 0; i < 5; i++)
                {
                    SeatClass.SetItemChecked(i, false);
                }
                UserSelectTrain.Text = string.Empty;
            }
        }

        private void NormalSearchOver(object sender, EventArgs e)
        {
            NormalSearchLabel.Visible = true;
        }

        private void NormalSearchLeave(object sender, EventArgs e)
        {
            NormalSearchLabel.Visible = false;
        }

        private void PatchOver(object sender, EventArgs e)
        {
            PatchLabel.Visible = true;
        }

        private void PatchLeave(object sender, EventArgs e)
        {
            PatchLabel.Visible = false;
        }

        private void DeepFirstOver(object sender, EventArgs e)
        {
            DeepFirstLabel.Visible = true;
        }

        private void DeepFirstLeave(object sender, EventArgs e)
        {
            DeepFirstLabel.Visible = false;
        }

        private void TopDeepOver(object sender, EventArgs e)
        {
            TopDeepLabel.Visible = true;
        }

        private void TopDeepLeave(object sender, EventArgs e)
        {
            TopDeepLabel.Visible = false;
        }

    }
}
