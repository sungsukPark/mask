using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartSerialPort_NewEX
{
   

    public partial class Form2 : Form
    {
        private string loginNm = "";
        private string PrevloginNm = "";
        private int ProdSpeedPerMin = 0;

        private clsSerialComm comm = null;

        private int machineType = 0;   //Machine Type 1공정, 2공정
        public Form2()
        {
            InitializeComponent();

            ////System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ////ps.StartInfo.FileName = "osk.exe";
            ////ps.Start();

            tmrCurrTime.Enabled = true;
            txtUserName.Focus();

            ////PictureBox pic = GetState(1);
            ////Controls.Add(pic);

            //ini정보 가져오기(LOGO IMAGE)
            clsIni iniInfo = new clsIni();
/*
            try
            {

                string logoFileName = iniInfo.ReadIniFile("LOG_INFO", "FILENAME");
                Bitmap bmp = new Bitmap(System.IO.Directory.GetCurrentDirectory() + @"\Resources\" + logoFileName);

                picLogo.Image = bmp;        //로고 이미지 로딩..
                picLogo1.Image = bmp;
            }
            catch (Exception ex) {
                MessageBox.Show("설정파일에 로고파일을 확인해 주세요.!!!");
            } */
            //생산속도
            ProdSpeedPerMin = Int32.Parse(iniInfo.ReadIniFile("PRODUCE_SPEED", "COUNT_PER_MIN"));

            lblCntPerMin.Text = ProdSpeedPerMin.ToString();
            txtCntPerMin.Text = ProdSpeedPerMin.ToString();

            //1공정, 2공정여부
            machineType = Int32.Parse(iniInfo.ReadIniFile("MACHINE_TYPE", "TYPE"));
            if (machineType == 1)
            {
                //1공정 기기 상태 이미지 로딩..
                // 임시주석 sspark
                //Bitmap bmp = new Bitmap(System.IO.Directory.GetCurrentDirectory() + @"\Resources\1공정_.png");
                //picMachineType.Image = bmp;

             /*   ChkState1_1.Visible = true;
                ChkState1_2.Visible = true;
                ChkState1_3.Visible = true;
                ChkState1_4.Visible = true;
                ChkState1_5.Visible = true;
                ChkState1_6.Visible = true;
                ChkState1_7.Visible = true;
                ChkState1_8.Visible = true;

                ChkState1_1.ForeColor = Color.Black;  //미동작상태
                ChkState1_2.ForeColor = Color.Black;
                ChkState1_3.ForeColor = Color.Black;
                ChkState1_4.ForeColor = Color.Black;
                ChkState1_5.ForeColor = Color.Black;
                ChkState1_6.ForeColor = Color.Black;
                ChkState1_7.ForeColor = Color.Black;
                ChkState1_8.ForeColor = Color.Black;

                this.ChkState1_1.Parent = this.picMachineType;
                this.ChkState1_2.Parent = this.picMachineType;
                this.ChkState1_3.Parent = this.picMachineType;
                this.ChkState1_4.Parent = this.picMachineType;
                this.ChkState1_5.Parent = this.picMachineType;
                this.ChkState1_6.Parent = this.picMachineType;
                this.ChkState1_7.Parent = this.picMachineType;
                this.ChkState1_8.Parent = this.picMachineType;

                ChkState1_1.Top = ChkState1_1.Top - 190;
                ChkState1_2.Top = ChkState1_2.Top - 190;
                ChkState1_3.Top = ChkState1_3.Top - 190;
                ChkState1_4.Top = ChkState1_4.Top - 190;
                ChkState1_5.Top = ChkState1_5.Top - 190;
                ChkState1_6.Top = ChkState1_6.Top - 190;
                ChkState1_7.Top = ChkState1_7.Top - 190;
                ChkState1_8.Top = ChkState1_8.Top - 190;*/
            }
            else if (machineType == 2) {
                //2공정 기기 상태 이미지 로딩..
                //Bitmap bmp = new Bitmap(System.IO.Directory.GetCurrentDirectory() + @"\Resources\2공정_.png");
                //picMachineType.Image = bmp;

            /*    ChkState2_1.Visible = true;
                ChkState2_2.Visible = true;
                ChkState2_3.Visible = true;
                ChkState2_4.Visible = true;
                ChkState2_5.Visible = true;
                ChkState2_6.Visible = true;
                ChkState2_7.Visible = true;

                ChkState2_1.ForeColor = Color.Black;  //미동작상태
                ChkState2_2.ForeColor = Color.Black;
                ChkState2_3.ForeColor = Color.Black;
                ChkState2_4.ForeColor = Color.Black;
                ChkState2_5.ForeColor = Color.Black;
                ChkState2_6.ForeColor = Color.Black;
                ChkState2_7.ForeColor = Color.Black;

                this.ChkState2_1.Parent = this.picMachineType;
                this.ChkState2_2.Parent = this.picMachineType;
                this.ChkState2_3.Parent = this.picMachineType;
                this.ChkState2_4.Parent = this.picMachineType;
                this.ChkState2_5.Parent = this.picMachineType;
                this.ChkState2_6.Parent = this.picMachineType;
                this.ChkState2_7.Parent = this.picMachineType;

                ChkState2_1.Top = ChkState2_1.Top - 190;
                ChkState2_2.Top = ChkState2_2.Top - 190;
                ChkState2_3.Top = ChkState2_3.Top - 190;
                ChkState2_4.Top = ChkState2_4.Top - 190;
                ChkState2_5.Top = ChkState2_5.Top - 190;
                ChkState2_6.Top = ChkState2_6.Top - 190;
                ChkState2_7.Top = ChkState2_7.Top - 190;*/
            }

    /*        serialP1.BaudRate = Int32.Parse(iniInfo.ReadIniFile("COMM_SETTINGS", "BAUD_RATE"));
            serialP1.DataBits = Int32.Parse(iniInfo.ReadIniFile("COMM_SETTINGS", "DATA_BIT"));
            if (iniInfo.ReadIniFile("COMM_SETTINGS", "PARITY_BIT") == "ODD")
                serialP1.Parity = Parity.Odd; 
            else if (iniInfo.ReadIniFile("COMM_SETTINGS", "PARITY_BIT") == "EVEN")
                serialP1.Parity = Parity.Even ;
            else if (iniInfo.ReadIniFile("COMM_SETTINGS", "PARITY_BIT") == "MARK")
                serialP1.Parity = Parity.Mark ;
            else if (iniInfo.ReadIniFile("COMM_SETTINGS", "PARITY_BIT") == "NONE")
                serialP1.Parity = Parity.None;
            else if (iniInfo.ReadIniFile("COMM_SETTINGS", "PARITY_BIT") == "SPACE")
                serialP1.Parity = Parity.Space;

            if (iniInfo.ReadIniFile("COMM_SETTINGS", "STOP_BIT") == "1")
                serialP1.StopBits = StopBits.One;
            if (iniInfo.ReadIniFile("COMM_SETTINGS", "STOP_BIT") == "NONE")
                serialP1.StopBits = StopBits.None;
            if (iniInfo.ReadIniFile("COMM_SETTINGS", "STOP_BIT") == "1.5")
                serialP1.StopBits = StopBits.OnePointFive;
            if (iniInfo.ReadIniFile("COMM_SETTINGS", "STOP_BIT") == "2")
                serialP1.StopBits = StopBits.Two;

            serialP1.PortName = iniInfo.ReadIniFile("COMM_SETTINGS", "PORT");

            comm = new clsSerialComm(serialP1, machineType);*/

            rdoFlow1.Checked = true;    //기본 정방향 설정..

            //comm.MainMotorRun();

        }

        private void tmrCurrTime_Tick(object sender, EventArgs e)
        {
            lblCurrTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        }

        //로그인 버튼 클릭시...로그인 패널 숨기고.. 프로세스 패널을 보인다.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginNm = txtUserName.Text;
            pnlLogin.Visible = false;
            pnlProcess.Visible = true;
            if (PrevloginNm.Length == 0)
                lblCongrat.Text = lblCongrat.Text.Replace("?????", loginNm);
            else
                lblCongrat.Text = lblCongrat.Text.Replace(PrevloginNm, loginNm);

            PrevloginNm = txtUserName.Text;
            txtUserName.Text = "";
        }

        private void rdoFlow1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFlow1.Checked == true)
            {
                //comm.SetDirection(0);
                rdoFlow2.Checked = false;
            }
            else
            {
                comm.SetDirection(1);
                rdoFlow2.Checked = true;
            }
        }

        private void rdoFlow2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFlow2.Checked == true)
            {
                comm.SetDirection(1);
                rdoFlow1.Checked = false;
            }
            else
            {
                comm.SetDirection(0);
                rdoFlow1.Checked = true;
            }
        }

        //사용자 변경
        private void btnUserChg_Click(object sender, EventArgs e)
        {
            //모든 프로세스를 정지했는지 확인후 아래의 과정을 수행...
            pnlLogin.Visible = true;
            pnlProcess.Visible = false; 
        }

        private void btnCntChg_Click(object sender, EventArgs e)
        {
            if (machineType == 1)
            {
                //1공정 설정변경 팝업
                frmConfigP1 frmP1 = new frmConfigP1(Int32.Parse(txtCntPerMin.Text));
                frmP1.ShowDialog();
                string str = frmP1._cntPerMinSaved.ToString();

                lblCntPerMin.Text = str;
                txtCntPerMin.Text = str;
            }
            else if (machineType == 2) {
                //2공정 설정변경 팝업
                frmConfigP2 frmP2 = new frmConfigP2(Int32.Parse(txtCntPerMin.Text));
                frmP2.ShowDialog();
                string str = frmP2._cntPerMinSaved.ToString();

                lblCntPerMin.Text = str;
                txtCntPerMin.Text = str;
            }
        }

        private void ShowDeviceState(int MachineType, int Order, int State) {
            /*
            if (MachineType == 1)
            {
                switch (Order)
                {
                    case 1:
                        switch (State)
                        {
                            case 1:
                                ChkState1_1.ForeColor = Color.LimeGreen;      //정상상태    
                                break;
                            case 2:
                                ChkState1_1.ForeColor = Color.Red;            //장애상태    
                                break;
                            case 3:
                                ChkState1_1.ForeColor = Color.Gold;           //원단 30 미만 주의 표시
                                break;
                            case 4:
                                ChkState1_1.ForeColor = Color.DodgerBlue;     //작동중
                                break;
                            default:
                                ChkState1_1.ForeColor = Color.Black;          //기타
                                break;
                        }
                        break;
                    case 2:
                        switch (State)
                        {
                            case 1:
                                ChkState1_2.ForeColor = Color.LimeGreen;      //정상상태    
                                break;
                            case 2:
                                ChkState1_2.ForeColor = Color.Red;            //장애상태    
                                break;
                            case 3:
                                ChkState1_2.ForeColor = Color.Gold;           //원단 30 미만 주의 표시
                                break;
                            case 4:
                                ChkState1_2.ForeColor = Color.DodgerBlue;     //작동중
                                break;
                            default:
                                ChkState1_2.ForeColor = Color.Black;          //기타
                                break;
                        }
                        break;
                    case 3:
                        switch (State)
                        {
                            case 1:
                                ChkState1_3.ForeColor = Color.LimeGreen;      //정상상태    
                                break;
                            case 2:
                                ChkState1_3.ForeColor = Color.Red;            //장애상태    
                                break;
                            case 3:
                                ChkState1_3.ForeColor = Color.Gold;           //원단 30 미만 주의 표시
                                break;
                            case 4:
                                ChkState1_3.ForeColor = Color.DodgerBlue;     //작동중
                                break;
                            default:
                                ChkState1_3.ForeColor = Color.Black;          //기타
                                break;

                        }
                        break;
                    case 4:
                        switch (State)
                        {
                            case 1:
                                ChkState1_4.ForeColor = Color.LimeGreen;      //정상상태    
                                break;
                            case 2:
                                ChkState1_4.ForeColor = Color.Red;            //장애상태    
                                break;
                            case 3:
                                ChkState1_4.ForeColor = Color.Gold;           //원단 30 미만 주의 표시
                                break;
                            case 4:
                                ChkState1_4.ForeColor = Color.DodgerBlue;     //작동중
                                break;
                            default:
                                ChkState1_4.ForeColor = Color.Black;          //기타
                                break;

                        }
                        break;
                    case 5:
                        switch (State)
                        {
                            case 1:
                                ChkState1_5.ForeColor = Color.LimeGreen;      //정상상태    
                                break;
                            case 2:
                                ChkState1_5.ForeColor = Color.Red;            //장애상태    
                                break;
                            case 3:
                                ChkState1_5.ForeColor = Color.Gold;           //원단 30 미만 주의 표시
                                break;
                            case 4:
                                ChkState1_5.ForeColor = Color.DodgerBlue;     //작동중
                                break;
                            default:
                                ChkState1_5.ForeColor = Color.Black;          //기타
                                break;

                        }
                        break;
                    case 6:
                        switch (State)
                        {
                            case 1:
                                ChkState1_6.ForeColor = Color.LimeGreen;      //정상상태    
                                break;
                            case 2:
                                ChkState1_6.ForeColor = Color.Red;            //장애상태    
                                break;
                            case 3:
                                ChkState1_6.ForeColor = Color.Gold;           //원단 30 미만 주의 표시
                                break;
                            case 4:
                                ChkState1_6.ForeColor = Color.DodgerBlue;     //작동중
                                break;
                            default:
                                ChkState1_6.ForeColor = Color.Black;          //기타
                                break;
                        }
                        break;
                    case 7:
                        switch (State)
                        {
                            case 1:
                                ChkState1_7.ForeColor = Color.LimeGreen;      //정상상태    
                                break;
                            case 2:
                                ChkState1_7.ForeColor = Color.Red;            //장애상태    
                                break;
                            case 3:
                                ChkState1_7.ForeColor = Color.Gold;           //원단 30 미만 주의 표시
                                break;
                            case 4:
                                ChkState1_7.ForeColor = Color.DodgerBlue;     //작동중
                                break;
                            default:
                                ChkState1_7.ForeColor = Color.Black;          //기타
                                break;

                        }
                        break;
                    case 8:
                        switch (State)
                        {
                            case 1:
                                ChkState1_8.ForeColor = Color.LimeGreen;      //정상상태    
                                break;
                            case 2:
                                ChkState1_8.ForeColor = Color.Red;            //장애상태    
                                break;
                            case 3:
                                ChkState1_8.ForeColor = Color.Gold;           //원단 30 미만 주의 표시
                                break;
                            case 4:
                                ChkState1_8.ForeColor = Color.DodgerBlue;     //작동중
                                break;
                            default:
                                ChkState1_8.ForeColor = Color.Black;          //기타
                                break;
                        }
                        break;
                }
            }
            else if (MachineType == 2)
            {
                switch (Order)
                {
                    case 1:
                        switch (State)
                        {
                            case 1:
                                ChkState2_1.ForeColor = Color.LimeGreen;      //정상상태    
                                break;
                            case 2:
                                ChkState2_1.ForeColor = Color.Red;            //장애상태    
                                break;
                            case 3:
                                ChkState2_1.ForeColor = Color.Gold;           //원단 30 미만 주의 표시
                                break;
                            case 4:
                                ChkState2_1.ForeColor = Color.DodgerBlue;     //작동중
                                break;
                            default:
                                ChkState2_1.ForeColor = Color.Black;          //기타
                                break;
                        }
                        break;
                    case 2:
                        switch (State)
                        {
                            case 1:
                                ChkState2_2.ForeColor = Color.LimeGreen;      //정상상태    
                                break;
                            case 2:
                                ChkState2_2.ForeColor = Color.Red;            //장애상태    
                                break;
                            case 3:
                                ChkState2_2.ForeColor = Color.Gold;           //원단 30 미만 주의 표시
                                break;
                            case 4:
                                ChkState2_2.ForeColor = Color.DodgerBlue;     //작동중
                                break;
                            default:
                                ChkState2_2.ForeColor = Color.Black;          //기타
                                break;
                        }
                        break;
                    case 3:
                        switch (State)
                        {
                            case 1:
                                ChkState2_3.ForeColor = Color.LimeGreen;      //정상상태    
                                break;
                            case 2:
                                ChkState2_3.ForeColor = Color.Red;            //장애상태    
                                break;
                            case 3:
                                ChkState2_3.ForeColor = Color.Gold;           //원단 30 미만 주의 표시
                                break;
                            case 4:
                                ChkState2_3.ForeColor = Color.DodgerBlue;     //작동중
                                break;
                            default:
                                ChkState2_3.ForeColor = Color.Black;          //기타
                                break;

                        }
                        break;
                    case 4:
                        switch (State)
                        {
                            case 1:
                                ChkState2_4.ForeColor = Color.LimeGreen;      //정상상태    
                                break;
                            case 2:
                                ChkState2_4.ForeColor = Color.Red;            //장애상태    
                                break;
                            case 3:
                                ChkState2_4.ForeColor = Color.Gold;           //원단 30 미만 주의 표시
                                break;
                            case 4:
                                ChkState2_4.ForeColor = Color.DodgerBlue;     //작동중
                                break;
                            default:
                                ChkState2_4.ForeColor = Color.Black;          //기타
                                break;

                        }
                        break;
                    case 5:
                        switch (State)
                        {
                            case 1:
                                ChkState2_5.ForeColor = Color.LimeGreen;      //정상상태    
                                break;
                            case 2:
                                ChkState2_5.ForeColor = Color.Red;            //장애상태    
                                break;
                            case 3:
                                ChkState2_5.ForeColor = Color.Gold;           //원단 30 미만 주의 표시
                                break;
                            case 4:
                                ChkState2_5.ForeColor = Color.DodgerBlue;     //작동중
                                break;
                            default:
                                ChkState2_5.ForeColor = Color.Black;          //기타
                                break;

                        }
                        break;
                    case 6:
                        switch (State)
                        {
                            case 1:
                                ChkState2_6.ForeColor = Color.LimeGreen;      //정상상태    
                                break;
                            case 2:
                                ChkState2_6.ForeColor = Color.Red;            //장애상태    
                                break;
                            case 3:
                                ChkState2_6.ForeColor = Color.Gold;           //원단 30 미만 주의 표시
                                break;
                            case 4:
                                ChkState2_6.ForeColor = Color.DodgerBlue;     //작동중
                                break;
                            default:
                                ChkState2_6.ForeColor = Color.Black;          //기타
                                break;
                        }
                        break;
                    case 7:
                        switch (State)
                        {
                            case 1:
                                ChkState2_7.ForeColor = Color.LimeGreen;      //정상상태    
                                break;
                            case 2:
                                ChkState2_7.ForeColor = Color.Red;            //장애상태    
                                break;
                            case 3:
                                ChkState2_7.ForeColor = Color.Gold;           //원단 30 미만 주의 표시
                                break;
                            case 4:
                                ChkState2_7.ForeColor = Color.DodgerBlue;     //작동중
                                break;
                            default:
                                ChkState2_7.ForeColor = Color.Black;          //기타
                                break;

                        }
                        break;
                }
            }*/

        }

        //private 

    }
}