using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartSerialPort_NewEX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int m_iBaudSelect = 6;          //BaudRate 인덱스변수
        private int m_iPortSelect = 2;          //Port 인덱스를 저장
        private int m_iFrameSelect = 0;         //FrameType 인덱스를 저장
        private int m_iDetectSelect = 0;        //DetectType 인덱스를 저장
        private int m_iErrorLoSelect = 0;       //ErrorLo 인덱스를 저장
        private int m_iErrorModeSelect = 0;     //ErrorMode 인덱스를 저장
        private int m_iReadTimeout = 50;        //ReadTimeout 값을 저장
        private uint m_uiBufferSize = 40000;    //FrameBufferSize를 저장
        private bool m_bOPEN = false;           //Port OPEN 후 설정을 변경하지 못하도록 플래그로 체크
        private bool m_bShiftFlag = false;      //Shift키가 눌려있는지 확인
        private byte[] m_bSendData;             //송신할 데이터를 저장할 바이트 배열

        //설정값을 저장할 변수
        private SmartX.SmartSerialPort.ERRORCODELOCATION m_ErrorLoc = SmartX.SmartSerialPort.ERRORCODELOCATION.HEADER;
        private SmartX.SmartSerialPort.FRAMESEPARATIONTYPES m_Separation = SmartX.SmartSerialPort.FRAMESEPARATIONTYPES.STXANDETX;
        private SmartX.SmartSerialPort.ERRORCHECK m_ErrorCheck = SmartX.SmartSerialPort.ERRORCHECK.NONE;
        private SmartX.SmartSerialPort.RECEIVEDETECTTYPE m_ReceiveDetect = SmartX.SmartSerialPort.RECEIVEDETECTTYPE.EVENT_QUEUE;
        private SmartX.SmartSerialPort.COMPORTNO m_PortNo = SmartX.SmartSerialPort.COMPORTNO.COM3;
        private SmartX.SmartSerialPort.BAUDRATE m_BaudRate = SmartX.SmartSerialPort.BAUDRATE._9600bps;

        private void Form1_Load(object sender, EventArgs e)
        {
            //콤보박스에 아이템을 추가하고 버튼의 Color 설정
            comboPortNo.ItemList.AddItem("COM1");
            comboPortNo.ItemList.AddItem("COM2");
            comboPortNo.ItemList.AddItem("COM3");
            SetComboBoxColor(comboPortNo, Color.FromArgb(0, 74, 128));

            comboBaud.ItemList.AddItem("110");
            comboBaud.ItemList.AddItem("300");
            comboBaud.ItemList.AddItem("600");
            comboBaud.ItemList.AddItem("1200");
            comboBaud.ItemList.AddItem("2400");
            comboBaud.ItemList.AddItem("4800");
            comboBaud.ItemList.AddItem("9600");
            comboBaud.ItemList.AddItem("14400");
            comboBaud.ItemList.AddItem("19200");
            comboBaud.ItemList.AddItem("38400");
            comboBaud.ItemList.AddItem("57600");
            comboBaud.ItemList.AddItem("115200");
            SetComboBoxColor(comboBaud, Color.FromArgb(0, 74, 128));

            comboFrameType.ItemList.AddItem("STXANDETX");
            comboFrameType.ItemList.AddItem("STXANDETX_READTIMEOUT");
            comboFrameType.ItemList.AddItem("STXONLY");
            comboFrameType.ItemList.AddItem("STXONLY_READTIMEOUT");
            comboFrameType.ItemList.AddItem("ETXONLY(1Byte)");
            comboFrameType.ItemList.AddItem("ETXONLY_READTIMEOUT(1Byte)");
            comboFrameType.ItemList.AddItem("ETXONLY(2Byte)");
            comboFrameType.ItemList.AddItem("ETXONLY_READTIMEOUT(2Byte)");
            comboFrameType.ItemList.AddItem("NONEFRAME_READTIMEOUT");
            SetComboBoxColor(comboFrameType, Color.FromArgb(0, 74, 128));

            comboDetect.ItemList.AddItem("EVENT");
            comboDetect.ItemList.AddItem("POLLING");
            SetComboBoxColor(comboDetect, Color.FromArgb(0, 74, 128));

            comboErrorLo.ItemList.AddItem("HEAD");
            comboErrorLo.ItemList.AddItem("TAIL");
            SetComboBoxColor(comboErrorLo, Color.FromArgb(0, 74, 128));

            comboErrorMode.ItemList.AddItem("NONE");
            comboErrorMode.ItemList.AddItem("CHECKSUM8");
            comboErrorMode.ItemList.AddItem("CHECKSUM16");
            comboErrorMode.ItemList.AddItem("CRC16");
            comboErrorMode.ItemList.AddItem("CRC32");
            SetComboBoxColor(comboErrorMode, Color.FromArgb(0, 74, 128));

            comboSendDataType.ItemList.AddItem("Binary");
            comboSendDataType.ItemList.AddItem("Text");
            SetComboBoxColor(comboSendDataType, Color.FromArgb(95, 130, 12));

            comboRecvDataType.ItemList.AddItem("Binary");
            comboRecvDataType.ItemList.AddItem("Text");
            SetComboBoxColor(comboRecvDataType, Color.FromArgb(237, 20, 91));

            comboPortNo.Text = "COM3";
            comboBaud.Text = "9600";
            comboFrameType.Text = "STXANDETX";
            comboDetect.Text = "EVENT";
            comboErrorLo.Text = "HEAD";
            comboErrorMode.Text = "NONE";
            comboSendDataType.Text = "Binary";
            comboRecvDataType.Text = "Binary";

            //SmartKeyPad에 키 추가
            smartKeyPad1.KeyTextVisible = true;        //키버튼 텍스트 사용을 위해 true

            //Layer 0 : Hex Data
            smartKeyPad1.SetKeyInfoAdd(0, 7, 7, SmartSerialPort_NewEX.Properties.Resources.key3_1_off, SmartSerialPort_NewEX.Properties.Resources.key3_1_on, SmartX.SmartKeyPad.KeyCode.A);
            smartKeyPad1.SetKeyInfoAdd(0, 69, 7, SmartSerialPort_NewEX.Properties.Resources.key3_1_off, SmartSerialPort_NewEX.Properties.Resources.key3_1_on, SmartX.SmartKeyPad.KeyCode.B);
            smartKeyPad1.SetKeyInfoAdd(0, 131, 7, SmartSerialPort_NewEX.Properties.Resources.key3_2_off, SmartSerialPort_NewEX.Properties.Resources.key3_2_on, SmartX.SmartKeyPad.KeyCode._1);
            smartKeyPad1.SetKeyInfoAdd(0, 193, 7, SmartSerialPort_NewEX.Properties.Resources.key3_2_off, SmartSerialPort_NewEX.Properties.Resources.key3_2_on, SmartX.SmartKeyPad.KeyCode._2);
            smartKeyPad1.SetKeyInfoAdd(0, 255, 7, SmartSerialPort_NewEX.Properties.Resources.key3_2_off, SmartSerialPort_NewEX.Properties.Resources.key3_2_on, SmartX.SmartKeyPad.KeyCode._3);
            smartKeyPad1.SetKeyInfoAdd(0, 317, 7, SmartSerialPort_NewEX.Properties.Resources.key3_2_off, SmartSerialPort_NewEX.Properties.Resources.key3_2_on, SmartX.SmartKeyPad.KeyCode._4);
            smartKeyPad1.SetKeyInfoAdd(0, 379, 7, SmartSerialPort_NewEX.Properties.Resources.key3_2_off, SmartSerialPort_NewEX.Properties.Resources.key3_2_on, SmartX.SmartKeyPad.KeyCode._5);

            smartKeyPad1.SetKeyInfoAdd(0, 7, 69, SmartSerialPort_NewEX.Properties.Resources.key3_1_off, SmartSerialPort_NewEX.Properties.Resources.key3_1_on, SmartX.SmartKeyPad.KeyCode.C);
            smartKeyPad1.SetKeyInfoAdd(0, 69, 69, SmartSerialPort_NewEX.Properties.Resources.key3_1_off, SmartSerialPort_NewEX.Properties.Resources.key3_1_on, SmartX.SmartKeyPad.KeyCode.D);
            smartKeyPad1.SetKeyInfoAdd(0, 131, 69, SmartSerialPort_NewEX.Properties.Resources.key3_2_off, SmartSerialPort_NewEX.Properties.Resources.key3_2_on, SmartX.SmartKeyPad.KeyCode._6);
            smartKeyPad1.SetKeyInfoAdd(0, 193, 69, SmartSerialPort_NewEX.Properties.Resources.key3_2_off, SmartSerialPort_NewEX.Properties.Resources.key3_2_on, SmartX.SmartKeyPad.KeyCode._7);
            smartKeyPad1.SetKeyInfoAdd(0, 255, 69, SmartSerialPort_NewEX.Properties.Resources.key3_2_off, SmartSerialPort_NewEX.Properties.Resources.key3_2_on, SmartX.SmartKeyPad.KeyCode._8);
            smartKeyPad1.SetKeyInfoAdd(0, 317, 69, SmartSerialPort_NewEX.Properties.Resources.key3_2_off, SmartSerialPort_NewEX.Properties.Resources.key3_2_on, SmartX.SmartKeyPad.KeyCode._9);
            smartKeyPad1.SetKeyInfoAdd(0, 379, 69, SmartSerialPort_NewEX.Properties.Resources.key3_3_off, SmartSerialPort_NewEX.Properties.Resources.key3_3_on, SmartX.SmartKeyPad.KeyCode.BackSpace);

            smartKeyPad1.SetKeyInfoAdd(0, 7, 131, SmartSerialPort_NewEX.Properties.Resources.key3_1_off, SmartSerialPort_NewEX.Properties.Resources.key3_1_on, SmartX.SmartKeyPad.KeyCode.E);
            smartKeyPad1.SetKeyInfoAdd(0, 69, 131, SmartSerialPort_NewEX.Properties.Resources.key3_1_off, SmartSerialPort_NewEX.Properties.Resources.key3_1_on, SmartX.SmartKeyPad.KeyCode.F);
            smartKeyPad1.SetKeyInfoAdd(0, 131, 131, SmartSerialPort_NewEX.Properties.Resources.key3_2_off, SmartSerialPort_NewEX.Properties.Resources.key3_2_on, SmartX.SmartKeyPad.KeyCode._0);
            smartKeyPad1.SetKeyInfoAdd(0, 193, 131, SmartSerialPort_NewEX.Properties.Resources.key4_1_off, SmartSerialPort_NewEX.Properties.Resources.key4_1_on, SmartX.SmartKeyPad.KeyCode.SpaceBar);
            smartKeyPad1.SetKeyInfoAdd(0, 379, 131, SmartSerialPort_NewEX.Properties.Resources.key3_4_off, SmartSerialPort_NewEX.Properties.Resources.key3_4_on, "Close", SmartX.SmartKeyPad.KeyCode.Esc);

            //Layer 1 : Number Data
            smartKeyPad1.SetKeyInfoAdd(1, 7, 7, SmartSerialPort_NewEX.Properties.Resources.key2_1_off, SmartSerialPort_NewEX.Properties.Resources.key2_1_on, SmartX.SmartKeyPad.KeyCode._1);
            smartKeyPad1.SetKeyInfoAdd(1, 69, 7, SmartSerialPort_NewEX.Properties.Resources.key2_1_off, SmartSerialPort_NewEX.Properties.Resources.key2_1_on, SmartX.SmartKeyPad.KeyCode._2);
            smartKeyPad1.SetKeyInfoAdd(1, 131, 7, SmartSerialPort_NewEX.Properties.Resources.key2_1_off, SmartSerialPort_NewEX.Properties.Resources.key2_1_on, SmartX.SmartKeyPad.KeyCode._3);
            smartKeyPad1.SetKeyInfoAdd(1, 193, 7, SmartSerialPort_NewEX.Properties.Resources.key2_1_off, SmartSerialPort_NewEX.Properties.Resources.key2_1_on, SmartX.SmartKeyPad.KeyCode._4);

            smartKeyPad1.SetKeyInfoAdd(1, 7, 69, SmartSerialPort_NewEX.Properties.Resources.key2_1_off, SmartSerialPort_NewEX.Properties.Resources.key2_1_on, SmartX.SmartKeyPad.KeyCode._5);
            smartKeyPad1.SetKeyInfoAdd(1, 69, 69, SmartSerialPort_NewEX.Properties.Resources.key2_1_off, SmartSerialPort_NewEX.Properties.Resources.key2_1_on, SmartX.SmartKeyPad.KeyCode._6);
            smartKeyPad1.SetKeyInfoAdd(1, 131, 69, SmartSerialPort_NewEX.Properties.Resources.key2_1_off, SmartSerialPort_NewEX.Properties.Resources.key2_1_on, SmartX.SmartKeyPad.KeyCode._7);
            smartKeyPad1.SetKeyInfoAdd(1, 193, 69, SmartSerialPort_NewEX.Properties.Resources.key2_1_off, SmartSerialPort_NewEX.Properties.Resources.key2_1_on, SmartX.SmartKeyPad.KeyCode._8);

            smartKeyPad1.SetKeyInfoAdd(1, 7, 131, SmartSerialPort_NewEX.Properties.Resources.key2_1_off, SmartSerialPort_NewEX.Properties.Resources.key2_1_on, SmartX.SmartKeyPad.KeyCode._9);
            smartKeyPad1.SetKeyInfoAdd(1, 69, 131, SmartSerialPort_NewEX.Properties.Resources.key2_1_off, SmartSerialPort_NewEX.Properties.Resources.key2_1_on, SmartX.SmartKeyPad.KeyCode._0);
            smartKeyPad1.SetKeyInfoAdd(1, 131, 131, SmartSerialPort_NewEX.Properties.Resources.key2_1_off, SmartSerialPort_NewEX.Properties.Resources.key2_1_on, SmartX.SmartKeyPad.KeyCode._e);
            smartKeyPad1.SetKeyInfoAdd(1, 193, 131, SmartSerialPort_NewEX.Properties.Resources.key2_2_off, SmartSerialPort_NewEX.Properties.Resources.key2_2_on, SmartX.SmartKeyPad.KeyCode.BackSpace);

            smartKeyPad1.SetKeyInfoAdd(1, 7, 193, SmartSerialPort_NewEX.Properties.Resources.key2_1_off, SmartSerialPort_NewEX.Properties.Resources.key2_1_on, SmartX.SmartKeyPad.KeyCode.Period);
            smartKeyPad1.SetKeyInfoAdd(1, 69, 193, SmartSerialPort_NewEX.Properties.Resources.key2_1_off, SmartSerialPort_NewEX.Properties.Resources.key2_1_on, SmartX.SmartKeyPad.KeyCode.Hyphen);
            smartKeyPad1.SetKeyInfoAdd(1, 131, 193, SmartSerialPort_NewEX.Properties.Resources.key1_3_off, SmartSerialPort_NewEX.Properties.Resources.key1_3_on, "Close", SmartX.SmartKeyPad.KeyCode.Esc);

            //Layer 2 : Text Data
            smartKeyPad1.SetKeyInfoAdd(2, 7, 7, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode._1);
            smartKeyPad1.SetKeyInfoAdd(2, 69, 7, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode._2);
            smartKeyPad1.SetKeyInfoAdd(2, 131, 7, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode._3);
            smartKeyPad1.SetKeyInfoAdd(2, 193, 7, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode._4);
            smartKeyPad1.SetKeyInfoAdd(2, 255, 7, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode._5);
            smartKeyPad1.SetKeyInfoAdd(2, 317, 7, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode._6);
            smartKeyPad1.SetKeyInfoAdd(2, 379, 7, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode._7);
            smartKeyPad1.SetKeyInfoAdd(2, 441, 7, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode._8);
            smartKeyPad1.SetKeyInfoAdd(2, 503, 7, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode._9);
            smartKeyPad1.SetKeyInfoAdd(2, 565, 7, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode._0);

            smartKeyPad1.SetKeyInfoAdd(2, 7, 69, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.Q);
            smartKeyPad1.SetKeyInfoAdd(2, 69, 69, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.W);
            smartKeyPad1.SetKeyInfoAdd(2, 131, 69, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.E);
            smartKeyPad1.SetKeyInfoAdd(2, 193, 69, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.R);
            smartKeyPad1.SetKeyInfoAdd(2, 255, 69, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.T);
            smartKeyPad1.SetKeyInfoAdd(2, 317, 69, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.Y);
            smartKeyPad1.SetKeyInfoAdd(2, 379, 69, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.U);
            smartKeyPad1.SetKeyInfoAdd(2, 441, 69, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.I);
            smartKeyPad1.SetKeyInfoAdd(2, 503, 69, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.O);
            smartKeyPad1.SetKeyInfoAdd(2, 565, 69, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.P);

            smartKeyPad1.SetKeyInfoAdd(2, 7, 131, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.A);
            smartKeyPad1.SetKeyInfoAdd(2, 69, 131, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.S);
            smartKeyPad1.SetKeyInfoAdd(2, 131, 131, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.D);
            smartKeyPad1.SetKeyInfoAdd(2, 193, 131, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.F);
            smartKeyPad1.SetKeyInfoAdd(2, 255, 131, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.G);
            smartKeyPad1.SetKeyInfoAdd(2, 317, 131, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.H);
            smartKeyPad1.SetKeyInfoAdd(2, 379, 131, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.J);
            smartKeyPad1.SetKeyInfoAdd(2, 441, 131, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.K);
            smartKeyPad1.SetKeyInfoAdd(2, 503, 131, SmartSerialPort_NewEX.Properties.Resources.key1_2_off, SmartSerialPort_NewEX.Properties.Resources.key1_2_on, SmartX.SmartKeyPad.KeyCode.BackSpace);

            smartKeyPad1.SetKeyInfoAdd(2, 7, 193, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.L);
            smartKeyPad1.SetKeyInfoAdd(2, 69, 193, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.Z);
            smartKeyPad1.SetKeyInfoAdd(2, 131, 193, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.X);
            smartKeyPad1.SetKeyInfoAdd(2, 193, 193, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.C);
            smartKeyPad1.SetKeyInfoAdd(2, 255, 193, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.V);
            smartKeyPad1.SetKeyInfoAdd(2, 317, 193, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.B);
            smartKeyPad1.SetKeyInfoAdd(2, 379, 193, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.N);
            smartKeyPad1.SetKeyInfoAdd(2, 441, 193, SmartSerialPort_NewEX.Properties.Resources.key1_1_off, SmartSerialPort_NewEX.Properties.Resources.key1_1_on, SmartX.SmartKeyPad.KeyCode.M);
            smartKeyPad1.SetKeyInfoAdd(2, 503, 193, SmartSerialPort_NewEX.Properties.Resources.key1_3_off, SmartSerialPort_NewEX.Properties.Resources.key1_3_on, "Close", SmartX.SmartKeyPad.KeyCode.Esc);

            smartKeyPad1.TargetInputObject = labelSendData; //초기 타겟을 지정
            smartKeyPad1.Visible = false;
        }

        //Form이 닫힐 때 발생
        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            //Shift키가 눌려있는 경우 임의로 Shift를 입력하여 해제
            if (m_bShiftFlag == true)
            {
                smartKeyPad1.KeyInput(SmartX.SmartKeyPad.KeyCode.Shift);
            }
            smartTimer1.Stop();         //타이머 중지
            smartTimer2.Stop();         //타이머 중지
            smartSerialPort1.Close();   //포트 Close
        }

        //Port를 선택햇을 때
        private void comboPortNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Port가 오픈되었던 경우 설정을 변경하지 못하도록 설정
            if (comboOpenCheck(comboPortNo, m_iPortSelect)) return;

            //선택한 인덱스를 저장하고 인덱스에 맞는 값을 저장
            m_iPortSelect = comboPortNo.ItemListSelectItemIndex;
            if (m_iPortSelect == 0) m_PortNo = SmartX.SmartSerialPort.COMPORTNO.COM1;
            else if (m_iPortSelect == 1) m_PortNo = SmartX.SmartSerialPort.COMPORTNO.COM2;
            else if (m_iPortSelect == 2) m_PortNo = SmartX.SmartSerialPort.COMPORTNO.COM3;
        }

        //BaudRate를 선택했을 때
        private void comboBaud_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Port가 오픈되었던 경우 설정을 변경하지 못하도록 설정
            if (comboOpenCheck(comboBaud, m_iBaudSelect)) return;

            //선택한 인덱스를 저장하고 인덱스에 맞는 값을 저장
            m_iBaudSelect = comboBaud.ItemListSelectItemIndex;
            if (m_iBaudSelect == 0) m_BaudRate = SmartX.SmartSerialPort.BAUDRATE._110bps;
            else if (m_iBaudSelect == 1) m_BaudRate = SmartX.SmartSerialPort.BAUDRATE._300bps;
            else if (m_iBaudSelect == 2) m_BaudRate = SmartX.SmartSerialPort.BAUDRATE._600bps;
            else if (m_iBaudSelect == 3) m_BaudRate = SmartX.SmartSerialPort.BAUDRATE._1200bps;
            else if (m_iBaudSelect == 4) m_BaudRate = SmartX.SmartSerialPort.BAUDRATE._2400bps;
            else if (m_iBaudSelect == 5) m_BaudRate = SmartX.SmartSerialPort.BAUDRATE._4800bps;
            else if (m_iBaudSelect == 6) m_BaudRate = SmartX.SmartSerialPort.BAUDRATE._9600bps;
            else if (m_iBaudSelect == 7) m_BaudRate = SmartX.SmartSerialPort.BAUDRATE._14400bps;
            else if (m_iBaudSelect == 8) m_BaudRate = SmartX.SmartSerialPort.BAUDRATE._19200bps;
            else if (m_iBaudSelect == 9) m_BaudRate = SmartX.SmartSerialPort.BAUDRATE._38400bps;
            else if (m_iBaudSelect == 10) m_BaudRate = SmartX.SmartSerialPort.BAUDRATE._56000bps;
            else if (m_iBaudSelect == 11) m_BaudRate = SmartX.SmartSerialPort.BAUDRATE._115200bps;
        }

        //FrameType을 선택했을 때
        private void comboFrameType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Port가 오픈되었던 경우 설정을 변경하지 못하도록 설정
            if (comboOpenCheck(comboFrameType, m_iFrameSelect)) return;

            //선택한 인덱스를 저장하고 인덱스에 맞는 값을 저장
            m_iFrameSelect = comboFrameType.ItemListSelectItemIndex;
            labelSTX.Visible = true;    //STX 라벨을 보이도록 설정
            labelETX.Visible = true;    //ETX 라벨을 보이도록 설정

            if (m_iFrameSelect == 0)
            {
                //STXANDETX
                labelSepCode.Text = "STX/ETX";  //라벨표시를 변경
                m_Separation = SmartX.SmartSerialPort.FRAMESEPARATIONTYPES.STXANDETX;
            }
            else if (m_iFrameSelect == 1)
            {
                //STXANDETX_READTIMEOUT
                labelSepCode.Text = "STX/ETX";  //라벨표시를 변경
                m_Separation = SmartX.SmartSerialPort.FRAMESEPARATIONTYPES.STXANDETX_READTIMEOUT;
            }
            else if (m_iFrameSelect == 2)
            {
                //STXONLY
                labelSepCode.Text = "STX1/STX2";  //라벨표시를 변경
                m_Separation = SmartX.SmartSerialPort.FRAMESEPARATIONTYPES.STXONLY;
            }
            else if (m_iFrameSelect == 3)
            {
                //STXONLY_READTIMEOUT
                labelSepCode.Text = "STX1/STX2";  //라벨표시를 변경
                m_Separation = SmartX.SmartSerialPort.FRAMESEPARATIONTYPES.STXONLY_READTIMEOUT;
            }
            else if (m_iFrameSelect == 4)
            {
                //ETXONLY
                labelSTX.Visible = false;   //ETX 1Byte만 필요하므로 STX라벨을 숨김
                labelSepCode.Text = "ETX";  //라벨표시를 변경
                m_Separation = SmartX.SmartSerialPort.FRAMESEPARATIONTYPES.ETXONLY;
            }
            else if (m_iFrameSelect == 5)
            {
                //ETXONLY_READTIMEOUT
                labelSTX.Visible = false;   //ETX 1Byte만 필요하므로 STX라벨을 숨김
                labelSepCode.Text = "ETX";  //라벨표시를 변경
                m_Separation = SmartX.SmartSerialPort.FRAMESEPARATIONTYPES.ETXONLY_READTIMEOUT;
            }
            else if (m_iFrameSelect == 6)
            {
                //ETXONLY
                labelSepCode.Text = "ETX1/ETX2";  //라벨표시를 변경
                m_Separation = SmartX.SmartSerialPort.FRAMESEPARATIONTYPES.ETXONLY;
            }
            else if (m_iFrameSelect == 7)
            {
                //ETXONLY_READTIMEOUT
                labelSepCode.Text = "ETX1/ETX2";  //라벨표시를 변경
                m_Separation = SmartX.SmartSerialPort.FRAMESEPARATIONTYPES.ETXONLY_READTIMEOUT;
            }
            else if (m_iFrameSelect == 8)
            {
                //NONEFRAME_READTIMEOUT
                labelSTX.Visible = false;   //STX라벨을 보이지 않도록 설정
                labelETX.Visible = false;   //ETX라벨을 보이지 않도록 설정
                labelSepCode.Text = "NoneFrame";  //라벨표시를 변경
                m_Separation = SmartX.SmartSerialPort.FRAMESEPARATIONTYPES.NONEFRAME_READTIMEOUT;
            }
        }

        //DetectType을 선택했을 때
        private void comboDetect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Port가 오픈되었던 경우 설정을 변경하지 못하도록 설정
            if (comboOpenCheck(comboDetect, m_iDetectSelect)) return;

            //선택한 인덱스를 저장하고 인덱스에 맞는 값을 저장
            m_iDetectSelect = comboDetect.ItemListSelectItemIndex;
            if (m_iDetectSelect == 0)
            {
                //Event
                smartLabel21.Visible = false;       //Recv Interval을 설정할 수 없도록 Visible 변경
                labelRecvInterval.Visible = false;
                checkRecvRept.Visible = false;
                buttonRECV.Visible = false;
                m_ReceiveDetect = SmartX.SmartSerialPort.RECEIVEDETECTTYPE.EVENT_QUEUE;
            }
            else if (m_iDetectSelect == 1)
            {
                //Polling
                smartLabel21.Visible = true;    //Recv Interval을 설정할 수 있도록 Visible 변경
                labelRecvInterval.Visible = true;
                checkRecvRept.Visible = true;
                buttonRECV.Visible = true;
                m_ReceiveDetect = SmartX.SmartSerialPort.RECEIVEDETECTTYPE.POLLING_NONEQUEUE;
            }
        }

        //ErrorLocation을 선택했을 때
        private void comboErrorLo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Port가 오픈되었던 경우 설정을 변경하지 못하도록 설정
            if (comboOpenCheck(comboErrorLo, m_iErrorLoSelect)) return;

            //선택한 인덱스를 저장하고 인덱스에 맞는 값을 저장
            m_iErrorLoSelect = comboErrorLo.ItemListSelectItemIndex;
            if (m_iErrorLoSelect == 0) m_ErrorLoc = SmartX.SmartSerialPort.ERRORCODELOCATION.HEADER;
            else if (m_iErrorLoSelect == 1) m_ErrorLoc = SmartX.SmartSerialPort.ERRORCODELOCATION.TAIL;
        }

        //ErrorMode를 선택햇을 때
        private void comboErrorMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Port가 오픈되었던 경우 설정을 변경하지 못하도록 설정
            if (comboOpenCheck(comboErrorMode, m_iErrorModeSelect)) return;

            //선택한 인덱스를 저장하고 인덱스에 맞는 값을 저장
            m_iErrorModeSelect = comboErrorMode.ItemListSelectItemIndex;
            if (m_iErrorModeSelect == 0) m_ErrorCheck = SmartX.SmartSerialPort.ERRORCHECK.NONE;
            else if (m_iErrorModeSelect == 1) m_ErrorCheck = SmartX.SmartSerialPort.ERRORCHECK.CHECKSUM8;
            else if (m_iErrorModeSelect == 2) m_ErrorCheck = SmartX.SmartSerialPort.ERRORCHECK.CHECKSUM16;
            else if (m_iErrorModeSelect == 3) m_ErrorCheck = SmartX.SmartSerialPort.ERRORCHECK.CRC16;
            else if (m_iErrorModeSelect == 4) m_ErrorCheck = SmartX.SmartSerialPort.ERRORCHECK.CRC32;
        }

        //수신측 DataType 클릭시
        private void comboSendDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            smartKeyPad1.Visible = false;
            //선택한 Type에 따라 라디오버튼의 텍스트를 변경
            if (comboSendDataType.Text == "Binary")
            {
                radioSend1.Text = "int";
                radioSend2.Text = "float";
                radioSend3.Text = "hex";
            }
            else if (comboSendDataType.Text == "Text")
            {
                radioSend1.Text = "ASCII";
                radioSend2.Text = "Unicode";
                radioSend3.Text = "UTF-7";
            }
        }

        //송신측 DataType 클릭시
        private void comboRecvDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //선택한 Type에 따라 라디오버튼의 텍스트를 변경
            if (comboRecvDataType.Text == "Binary")
            {
                radioRecv1.Text = "int";
                radioRecv2.Text = "float";
                radioRecv3.Text = "hex";
            }
            else if (comboRecvDataType.Text == "Text")
            {
                radioRecv1.Text = "ASCII";
                radioRecv2.Text = "Unicode";
                radioRecv3.Text = "UTF-7";
            }
        }

        //Open 버튼 클릭 시
        private void buttonOPEN_Click(object sender, EventArgs e)
        {
            //smartSerialPort가 Open되지 않은 경우
            if (smartSerialPort1.IsOpen == false)
            {
                byte[] bSTXETX = new byte[2];   //구분 코드를 저장할 바이트 배열

                //구분코드를 변환하여 배열에 저장
                bSTXETX[0] = Convert.ToByte(labelSTX.Text, 16);
                bSTXETX[1] = Convert.ToByte(labelETX.Text, 16);

                //STX와 ETX를 모두 사용하는 경우
                if ((m_iFrameSelect == 0) || (m_iFrameSelect == 1))
                {
                    smartSerialPort1.STXCode = bSTXETX[0];  //STX 설정
                    smartSerialPort1.ETXCode = bSTXETX[1];  //ETX 설정
                }
                //STX만 사용하는 경우
                else if ((m_iFrameSelect == 2) || (m_iFrameSelect == 3))
                {
                    smartSerialPort1.STXCodes = bSTXETX;    //STX 설정(2Byte)
                }
                //ETX 1Byte만 사용하는 경우
                else if ((m_iFrameSelect == 4) || (m_iFrameSelect == 5))
                {
                    smartSerialPort1.ETXCode = bSTXETX[1];  //ETX 설정(1Byte)
                }
                //ETX 2Byte만 사용하는 경우
                else if ((m_iFrameSelect == 6) || (m_iFrameSelect == 7))
                {
                    smartSerialPort1.ETXCodes = bSTXETX;    //ETX 설정(2Byte)
                }

                smartSerialPort1.PortNo = m_PortNo;                                 //포트 설정
                smartSerialPort1.Baud_Rate = m_BaudRate;                            //보드레이트 설정
                smartSerialPort1.FrameBufferSize = m_uiBufferSize;                  //버퍼사이즈 설정
                smartSerialPort1.ReadTimeout = m_iReadTimeout;                      //ReadTimeout 설정
                smartSerialPort1.ErrorCode_Location = m_ErrorLoc;                   //Error 위치 설정
                smartSerialPort1.FrameSeparationType = m_Separation;                //FrameType 설정
                smartSerialPort1.RS485SoftwareDetection = false;                    //485 Software 설정
                smartSerialPort1.ReceiveFrameDebugMode = checkDebugMode.Checked;    //Debug모드 설정
                smartSerialPort1.ErrorCheckMode = m_ErrorCheck;                     //Error 모드 설정
                smartSerialPort1.ErrorCheckCodeType = SmartX.SmartSerialPort.ERRORCHECKCODETYPES.BINARY;    //ErrorCode의 타입을 설정
                smartSerialPort1.ReceiveDetect = m_ReceiveDetect;                   //Event, Polling 선택

                //COM7의 경우 USB Serial 통신을 위해 사용합니다. FTDI VCP드라이버가 없는 경우 COM7을 선택 후 Open()하면 에러가 발생합니다.
                try { smartSerialPort1.Open(); }
                catch (System.IO.IOException)
                {
                    SmartX.SmartMessageBox.Show(m_PortNo.ToString() + " 포트가 존재하지 않습니다.");
                    smartSerialPort1.Close();
                    return;
                }
                labelPortStatus.Text = "Opened";

                //한번 오픈하면 설정을 바꿀수 없도록 플래그 설정
                m_bOPEN = true;
            }
        }

        //Close 버튼 클릭시
        private void buttonCLOSE_Click(object sender, EventArgs e)
        {
            //Port가 Open되어있다면 Close
            if (smartSerialPort1.IsOpen == true)
            {
                smartTimer1.Stop();
                smartTimer2.Stop();
                smartSerialPort1.Close();
                labelPortStatus.Text = "Closed";
            }
        }

        //라벨들을 클릭시
        private void label_Click(object sender, EventArgs e)
        {
            //Target설정을 위한 변수
            SmartX.SmartLabel sL = (SmartX.SmartLabel)sender;
            //KeyPad의 타겟을 라벨로 클릭한 라벨로 설정
            smartKeyPad1.TargetInputObject = sL;

            //타겟이 labelSTX / labelETX 인 경우 Layer0 Show(Hex)
            if (sL == labelSTX || sL == labelETX)
            {
                //Port가 한번도 Open되지 않은 경우에만 실행
                if (m_bOPEN == true)
                {
                    SmartX.SmartMessageBox.Show("OPEN 후 설정을 바꿀 수 없습니다\n" + "프로그램 종료 후 재설정 하십시오");
                    return;
                }
                KeyPadLocationSet(444, 200, 245, 293, 0);   //Layer0 : Hex
            }
            //타겟이 ReadTimeOut / FrameBufferSize 인 경우
            else if (sL == labelRTO || sL == labelBuffer)
            {
                if (m_bOPEN == true)
                {
                    SmartX.SmartMessageBox.Show("OPEN 후 설정을 바꿀 수 없습니다\n" + "프로그램 종료 후 재설정 하십시오");
                    return;
                }
                KeyPadLocationSet(260, 260, 182, 293, 1);   //Layer1 : Num
            }
            //타겟이 SendData이고 DataType이 Binary인 경우
            else if ((sL == labelSendData) && (comboSendDataType.Text == "Binary"))
            {
                //int, float
                if ((radioSend1.Checked == true) || (radioSend2.Checked == true))
                {
                    KeyPadLocationSet(260, 260, 124, 293, 1);   //Layer1 : Num
                }
                //hex
                else
                {
                    KeyPadLocationSet(444, 200, 124, 293, 0);   //Layer0 : Hex
                }
            }
            //타겟이 SendData이고 DataType이 Text인 경우
            else if ((sL == labelSendData) && (comboSendDataType.Text == "Text"))
            {
                KeyPadLocationSet(632, 260, 124, 158, 2);   //Layer0 : FullSize
            }
            //타겟이 Send Interval / Recv Interval 인 경우
            else if (sL == labelSendInterval || sL == labelRecvInterval)
            {
                KeyPadLocationSet(260, 260, 11, 171, 1);   //Layer1 : Num
            }
        }

        //ReceiveFrameDebugMode 설정
        private void checkDebugMode_Click(object sender, EventArgs e)
        {
            smartSerialPort1.ReceiveFrameDebugMode = checkDebugMode.Checked;
        }

        //리스트박스에 관련된 버튼 클릭시
        private void buttonList_Click(object sender, EventArgs e)
        {
            if (sender == buttonUP) { listRecvData.ScrollUp(); }
            else if (sender == buttonDOWN) { listRecvData.ScrollDown(); }
            else if (sender == buttonClear) { listRecvData.ClearAll(); }
        }
        
        //Send쪽 RadioButton 클릭시
        private void radioSend_Click(object sender, EventArgs e)
        {
            //선택된 Type이 Binary인경우 각자 입력되는 형식이 다르기 때문에 키패드를 보이지 않도록 설정후 데이터를 지운다.
            if (comboSendDataType.Text == "Binary")
            {
                smartKeyPad1.Visible = false;
                labelSendData.Text = "";
            }
        }

        //SEND 버튼 클릭시
        private void buttonSEND_Click(object sender, EventArgs e)
        {
            //SendData가 입력되어있고 SerialPort가 Open되어 있는 경우에만 실행
            if ((labelSendData.Text != "") && (smartSerialPort1.IsOpen == true))
            {
                //유효한 값만을 입력받기 위한 예외처리
                try
                {
                    //선택된 Type이 Binary인 경우
                    if (comboSendDataType.Text == "Binary")
                    {
                        //int형인 경우
                        if (radioSend1.Checked == true)
                        {
                            //BitConverter 클래스를 이용하여 데이터를 바이트배열로 인코딩
                            m_bSendData = BitConverter.GetBytes(Convert.ToInt32(labelSendData.Text));
                        }
                        //float형인 경우
                        else if (radioSend2.Checked == true)
                        {
                            //BitConverter 클래스를 이용하여 데이터를 바이트배열로 인코딩
                            m_bSendData = BitConverter.GetBytes(Convert.ToSingle(labelSendData.Text));
                        }
                        //hexString인 경우
                        else if (radioSend3.Checked == true)
                        {
                            //SmartSerialPort의 Static 메서드를 이용하여 데이터를 바이트배열로 인코딩
                            m_bSendData = SmartX.SmartSerialPort.ConvertHexDecStringToBytes(labelSendData.Text, " ");
                        }
                    }
                    //선택된 Type이 Text인 경우
                    else if (comboSendDataType.Text == "Text")
                    {
                        //ASCII인 경우
                        if (radioSend1.Checked == true)
                        {
                            //Encoding 클래스를 이용하여 데이터를 바이트배열로 인코딩
                            m_bSendData = Encoding.ASCII.GetBytes(labelSendData.Text);
                        }
                        //Unicode인 경우
                        else if (radioSend2.Checked == true)
                        {
                            //Encoding 클래스를 이용하여 데이터를 바이트배열로 인코딩
                            m_bSendData = Encoding.Unicode.GetBytes(labelSendData.Text);
                        }
                        //UTF-7인 경우
                        else if (radioSend3.Checked == true)
                        {
                            //Encoding 클래스를 이용하여 데이터를 바이트배열로 인코딩
                            m_bSendData = Encoding.UTF7.GetBytes(labelSendData.Text);
                        }
                    }
                }
                catch (Exception)
                {
                    //예외 발생시 메시지박스를 출력하고 데이터를 지움
                    SmartX.SmartMessageBox.Show("올바른 데이터를 입력하세요!");
                    labelSendData.Text = "";
                    return;
                }

                //메서드를 호출하여 데이터를 송신
                SendData(m_bSendData);

                //Repeat가 체크되어있는 경우
                if (checkSendRept.Checked == true)
                {
                    smartTimer1.Start();
                }
            }
        }

        //데이터 반복 송신을 위한 타이머 Tick 이벤트
        private void smartTimer1_Tick(object sender, EventArgs e)
        {
            //송신 메서드를 반복 호출
            SendData(m_bSendData);

            //Repeat가 체크 해제된 경우 타이머 정지
            if (checkSendRept.Checked == false)
            {
                smartTimer1.Stop();
            }
        }

        //DetectType이 Event일 경우 데이터 수신시 발생하는 이벤트
        private void smartSerialPort1_OnReadQueueEvent()
        {
            //초기값을 Empty로 설정
            SmartX.SmartSerialPort.FRAMEDATAREADSTATUS eStatus = SmartX.SmartSerialPort.FRAMEDATAREADSTATUS.EMPTY;

            byte[] bReadByte;   //수신데이터를 저장할 바이트배열

            //수신데이터를 바이트배열에 저장하고 상태를 체크
            eStatus = smartSerialPort1.ReadQueue(out bReadByte);

            //수신받은 데이터를 메서드에서 처리
            RecvData(eStatus, bReadByte, checkDebugMode.Checked);
        }

        //DetectType이 POLLING일 때 Recv버튼 클릭시 
        private void buttonRECV_Click(object sender, EventArgs e)
        {
            //SerialPort가 Open되어있고 Polling 모드인 경우에만 실행
            if ((comboDetect.Text == "POLLING") && (smartSerialPort1.IsOpen == true))
            {
                byte[] readByte;    //수신 데이터를 저장할 바이트배열

                //초기값을 Empty로 설정
                SmartX.SmartSerialPort.FRAMEDATAREADSTATUS eStatus = SmartX.SmartSerialPort.FRAMEDATAREADSTATUS.EMPTY;

                //NoneFrame일 경우
                if (m_Separation == SmartX.SmartSerialPort.FRAMESEPARATIONTYPES.NONEFRAME_READTIMEOUT)
                {
                    eStatus = smartSerialPort1.ReadNoneFrame(out readByte);
                }
                //Frame일 경우
                else
                {
                    eStatus = smartSerialPort1.ReadFrame(out readByte);
                }

                //데이터 수신 메서드 호출
                RecvData(eStatus, readByte, checkDebugMode.Checked);

                //Repeat 체크시 반복 수신
                if (checkRecvRept.Checked == true)
                {
                    smartTimer2.Start();
                }
            }
        }

        //송신쪽 Repeat 체크박스 클릭시
        private void checkSendRept_Click(object sender, EventArgs e)
        {
            //포트가 Open되어 있고, 체크박스가 체크 될때만 실행
            if (smartSerialPort1.IsOpen == true && checkSendRept.Checked == true)
            {
                //유효한 값을 체크하기 위한 예외 처리
                try
                {
                    //송신 타이머를 라벨값으로 설정
                    smartTimer1.Interval = Convert.ToInt32(labelSendInterval.Text);
                }
                catch (Exception)
                {
                    //예외 발생시 메시지박스 출력 후 체크박스 해제 하고 값을 지움
                    SmartX.SmartMessageBox.Show("올바른 데이터를 입력하세요!");
                    checkSendRept.Checked = false;
                    labelSendInterval.Text = "";
                }
            }
        }

        //수신쪽 Repeat 체크박스 클릭시
        private void checkRecvRept_Click(object sender, EventArgs e)
        {
            //포트가 Open되어 있고, 체크박스가 체크 될때만 실행
            if (smartSerialPort1.IsOpen == true && checkRecvRept.Checked == true)
            {
                //유효한 값을 체크하기 위한 예외 처리
                try
                {
                    //송신 타이머를 라벨값으로 설정
                    smartTimer2.Interval = Convert.ToInt32(labelRecvInterval.Text);
                }
                catch (Exception)
                {
                    //예외 발생시 메시지박스 출력 후 체크박스 해제 하고 값을 지움
                    SmartX.SmartMessageBox.Show("올바른 데이터를 입력하세요!");
                    checkRecvRept.Checked = false;
                    labelRecvInterval.Text = "";
                }
            }
        }

        //DetectType이 POLLING일 때 반복 수신을 위한 타이머 Tick 메서드
        private void smartTimer2_Tick(object sender, EventArgs e)
        {
            //Polling 방식 수신 메서드를 반복 호출
            buttonRECV_Click(sender, e);
            //Repeat 체크 해제시 반복 중지
            if (checkRecvRept.Checked == false)
            {
                smartTimer2.Stop();
            }
        }

        //키패드 키를 누를경우 발생
        private void smartKeyPad1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Clear키가 눌린경우 키패드를 닫는다
            if (e.KeyChar == 27)
            {
                e.Handled = true;
                smartKeyPad1.Visible = false;
            }
            else
            {
                //숫자가 눌린경우나 숫자가 마지막으로 입력되었을 때 백스페이스가 눌린 경우는 Shift 키가 눌리지 않음
                if ((e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8' ||
                    e.KeyChar == '9' || e.KeyChar == '0' || e.KeyChar == 'e' || e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == ' ') || (e.KeyChar == '\b' && m_bShiftFlag == false))
                {
                    m_bShiftFlag = false;
                }
                //문자가 눌린경우나 문자가 마지막으로 입력되었을 때 백스페이스가 눌린 경우 Shift 키가 눌림
                else
                {
                    m_bShiftFlag = true;
                }
                //Target 라벨을 체크하고 값을 변경하기 위한 변수 생성 및 초기화
                SmartX.SmartLabel sL = (SmartX.SmartLabel)smartKeyPad1.TargetInputObject;

                //선택한 라벨이 STX와 ETX라면 글자수를 2개로 제한
                if (sL == labelETX || sL == labelSTX)
                {
                    //Space 입력시 무시
                    if (e.KeyChar == ' ') e.Handled = true;
                    else
                    {
                        //라벨에 입력되는 글자수가 2개 이상이 되는 경우 라벨을 비움
                        if (sL.Text.Length > 1)
                        {
                            smartKeyPad1.LableClear();
                            sL.Text = "";
                        }
                    }
                }
                //선택한 라벨이 SendData고 DataType이 Binary인 경우
                else if ((sL == labelSendData) && (comboSendDataType.Text == "Binary"))
                {
                    //int인 경우
                    if (radioSend1.Checked == true)
                    {
                        //'.', 'e' 가 입력되지 않도록 설정
                        if (e.KeyChar == '.' || e.KeyChar == 'e') e.Handled = true;
                    }
                }
                //ReadTimeout,FrameBufferSize,Interval 클릭시 '-', '.' 'e' 입력 되지 않도록
                else if (sL == labelSendInterval || sL == labelRecvInterval || sL == labelRTO || sL == labelBuffer)
                {
                    if (e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == 'e') e.Handled = true;
                }
            }
        }

        //콤보박스의 버튼 컬러 설정 메서드
        private void SetComboBoxColor(SmartX.SmartComboBox sC, Color cSet)
        {
            sC.DropDownButton.ButtonColor = cSet;
            sC.DropDownButton.TextColor = Color.FromArgb(255, 255, 255);
            sC.ScrollDownButton.ButtonColor = cSet;
            sC.ScrollDownButton.TextColor = Color.FromArgb(255, 255, 255);
            sC.ScrollUpButton.ButtonColor = cSet;
            sC.ScrollUpButton.TextColor = Color.FromArgb(255, 255, 255);
        }

        //Port가 오픈되었던 경우 설정을 변경하지 못하도록 설정하는 메서드
        private bool comboOpenCheck(SmartX.SmartComboBox sC, int iIndex)
        {
            if (m_bOPEN == true)
            {
                SmartX.SmartMessageBox.Show("OPEN 후 설정을 바꿀 수 없습니다\n" + "프로그램 종료 후 재설정 하십시오");
                //텍스트를 설정시의 값으로 변경
                sC.Text = sC.ItemList.Items[iIndex];
                sC.Refresh();
                return true;
            }
            return false;
        }

        //데이터 송신 메서드 인자(송신할 바이트배열)
        private void SendData(byte[] bSendData)
        {
            //NoneFrameType 인 경우
            if (m_Separation == SmartX.SmartSerialPort.FRAMESEPARATIONTYPES.NONEFRAME_READTIMEOUT)
            {
                smartSerialPort1.WriteNoneFrame(bSendData);
            }
            //FrameType 인 경우
            else
            {
                smartSerialPort1.WriteFrame(bSendData);
            }
        }

        //수신데이터 처리 메서드 인자 : (수신데이터 상태, 수신받은 데이터, 디버그모드)
        private void RecvData(SmartX.SmartSerialPort.FRAMEDATAREADSTATUS eStatus, byte[] bReadData, bool bRecvDebug)
        {
            // 수신 결과가 Empty 일 경우
            if (eStatus == SmartX.SmartSerialPort.FRAMEDATAREADSTATUS.EMPTY)
            {
                listRecvData.AddItem("EMPTY");
            }
            // 수신 결과가 FAILDATA 일 경우
            else if (eStatus == SmartX.SmartSerialPort.FRAMEDATAREADSTATUS.FAILDATA)
            {
                listRecvData.AddItem("Fail");
            }
            // 정상인 경우
            else
            {
                string strRead = "";    //ListBox에 항목을 추가하기 위한 String 변수
                try
                {
                    //Debug모드가 켜져있는 경우
                    if (bRecvDebug == true)
                    {
                        for (int i = 0; i < bReadData.Length; i++)
                        {
                            //모든 데이터를 16진수 형식의 String으로 변환하여 저장
                            strRead += bReadData[i].ToString("X2") + " ";
                        }
                    }
                    //Debug모드가 꺼져있는 경우
                    else
                    {
                        //DataType이 Binary인 경우
                        if (comboRecvDataType.Text == "Binary")
                        {
                            //int형인 경우
                            if (radioRecv1.Checked == true)
                            {
                                //BitConverter 클래스를 이용하여 수신받은 바이트 배열을 디코딩
                                strRead = BitConverter.ToInt32(bReadData, 0).ToString();
                            }
                            //float형인 경우
                            else if (radioRecv2.Checked == true)
                            {
                                //BitConverter 클래스를 이용하여 수신받은 바이트 배열을 디코딩
                                strRead = BitConverter.ToSingle(bReadData, 0).ToString();
                            }
                            //hexString인 경우
                            else if (radioRecv3.Checked == true)
                            {
                                //SmartSerialPort의 Static 메서드를 이용하여 수신받은 바이트 배열을 디코딩
                                strRead = SmartX.SmartSerialPort.ConvertBytesToHexDecString(bReadData, " ");
                            }
                        }
                        //DataType이 Text인 경우
                        else if (comboRecvDataType.Text == "Text")
                        {
                            //ASCII인 경우
                            if (radioRecv1.Checked == true)
                            {
                                //Encoding 클래스를 이용하여 수신받은 바이트 배열을 디코딩
                                strRead = Encoding.ASCII.GetString(bReadData, 0, bReadData.Length);
                            }
                            //Unicode인 경우
                            else if (radioRecv2.Checked == true)
                            {
                                //Encoding 클래스를 이용하여 수신받은 바이트 배열을 디코딩
                                strRead = Encoding.Unicode.GetString(bReadData, 0, bReadData.Length);
                            }
                            //UTF-7인 경우
                            else if (radioRecv3.Checked == true)
                            {
                                //Encoding 클래스를 이용하여 수신받은 바이트 배열을 디코딩
                                strRead = Encoding.UTF7.GetString(bReadData, 0, bReadData.Length);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    //수신받은 데이터가 잘못된 경우를 체크
                    SmartX.SmartMessageBox.Show("수신받은 데이터가 올바르지 않습니다!!!");
                    return;
                }
                //ListBox에 항목 추가
                listRecvData.AddItem(strRead);
            }
        }

        //KeyPad의 위치, 크기, 레이어를 설정
        private void KeyPadLocationSet(int iWidth, int iHeight, int iTop, int iLeft, int iLayer)
        {
            smartKeyPad1.Width = iWidth;
            smartKeyPad1.Height = iHeight;
            smartKeyPad1.Top = iTop;
            smartKeyPad1.Left = iLeft;
            smartKeyPad1.LayerChange(iLayer);
            smartKeyPad1.Visible = true;
        }

        

        
    }
}