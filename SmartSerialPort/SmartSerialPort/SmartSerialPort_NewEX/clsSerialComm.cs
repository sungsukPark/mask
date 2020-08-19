using System;

using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SmartSerialPort_NewEX
{

    class clsSerialComm
    {
        private System.IO.Ports.SerialPort _serialP1;

        private int _nMachineType = 0;      //1공정, 2공정
        private int _nDirection = 0;        //0:정(시계)방향, 1:역(반시계)방향 

        //private byte[] byteMainMotorRun;

        private byte[] recvBuff;        //도착 데이터


        //STX, ETX
        private byte byteSTX = 0x3A;                //3A                   
        private byte byteETX = 0x0D;                //0D  

        //Machine Type
        private byte[] byteMType1 = { 0x30, 0x31 };   //1공정 01
        private byte[] byteMType2 = { 0x30, 0x32 };   //2공정 02

        // 
        private byte[] byteDirect1 = { 0x30, 0x30, 0x30, 0x30, 0x33, 0x30, 0x30, 0x30 };   //정(시계)방향    00003000
        private byte[] byteDirect2 = { 0x31, 0x30, 0x30, 0x30, 0x33, 0x30, 0x30, 0x30 };   //역(반시계)방향  10003000

        //---------------------SEND Command-------------------------------------------------------------------------------------------------------------------------  
        private byte[] byteSND_MMR = { 0x30, 0x31 };    //Main Motor Run - 1
        private byte[] byteSND_MMT = { 0x30, 0x30 };    //Main Motor Stop - 2

        private byte[] byteSND_SM1R = { 0x30, 0x33 };    //Sub Motor1 Run - 3
        private byte[] byteSND_SM1T = { 0x30, 0x32 };    //Sub Motor1 Stop - 4

        private byte[] byteSND_SM2R = { 0x30, 0x35 };    //Sub Motor2 Run - 5
        private byte[] byteSND_SM2T = { 0x30, 0x34 };    //Sub Motor2 Stop - 6

        private byte[] byteSND_EMGSTP = { 0x31, 0x30 };    //Emergency Stop - 7

        private byte[] byteSND_MACSTE = { 0x30, 0x46 };    //Get Machine Status - 8

        private byte[] byteSND_ALMRST = { 0x30, 0x35 };    //Alarm Reset - 9 

        private byte[] byteSND_PREACT = { 0x30, 0x37 };    //공압기기동작 - 10

        private byte[] byteSND_SSNACT = { 0x30, 0x38 };    //초음파 동작 - 11

        //---------------------RECV Command------------------------------------------------------------------------------------------------------------------------- 
        private byte[] byteRCV_MMR = { 0x38, 0x31 };    //Main Motor Run - 1
        private byte[] byteRCV_MMT = { 0x38, 0x30 };    //Main Motor Stop - 2

        private byte[] byteRCV_SM1R = { 0x38, 0x33 };    //Sub Motor1 Run - 3
        private byte[] byteRCV_SM1T = { 0x38, 0x32 };    //Sub Motor1 Stop - 4

        private byte[] byteRCV_SM2R = { 0x38, 0x35 };    //Sub Motor2 Run - 5
        private byte[] byteRCV_SM2T = { 0x38, 0x34 };    //Sub Motor2 Stop - 6

        private byte[] byteRCV_EMGSTP = { 0x31, 0x30 };    //Emergency Stop - 7

        private byte[] byteRCV_MACSTE = { 0x30, 0x46 };    //Get Machine Status - 8

        private byte[] byteRCV_ALMRST = { 0x30, 0x35 };    //Alarm Reset - 9 

        private byte[] byteRCV_PREACT = { 0x30, 0x37 };    //공압기기동작 - 10

        private byte[] byteRCV_SSNACT = { 0x30, 0x38 };    //초음파 동작 - 11

        //------------------ 기본 전송 데이터 정의------------------------------------------------------------------------------------------------------------------
        private byte[] cmdMMR = { 0x3A, 0x30, 0x31, 0x30, 0x31, 0x30, 0x38, 0x30, 0x30, 0x30, 0x30, 0x33, 0x30, 0x30, 0x30, 0x30, 0x42, 0x0D };   //Main Motor Run
        private byte[] cmdMMT = { 0x3A, 0x30, 0x31, 0x30, 0x30, 0x30, 0x30, 0x30, 0x33, 0x0D };                                                  //Main Motor Stop

        private byte[] cmdSM1R = { 0x3A, 0x30, 0x31, 0x30, 0x33, 0x30, 0x38, 0x30, 0x30, 0x30, 0x30, 0x33, 0x30, 0x30, 0x30, 0x30, 0x42, 0x0D };  //Sub Motor1 Run
        private byte[] cmdSM1T = { 0x3A, 0x30, 0x31, 0x30, 0x32, 0x30, 0x30, 0x30, 0x33, 0x0D };                                                  //Sub Motor1 Stop

        private byte[] cmdSM2R = { 0x3A, 0x30, 0x31, 0x30, 0x35, 0x30, 0x38, 0x30, 0x30, 0x30, 0x30, 0x33, 0x30, 0x30, 0x30, 0x30, 0x46, 0x0D };  //Sub Motor2 Run
        private byte[] cmdSM2T = { 0x3A, 0x30, 0x31, 0x30, 0x34, 0x30, 0x30, 0x30, 0x35, 0x0D };                                                  //Sub Motor2 Stop

        private byte[] cmdEMT = { 0x3A, 0x30, 0x31, 0x31, 0x30, 0x30, 0x30, 0x30, 0x30, 0x0D };                                                  //Emergency Stop

        private byte[] cmdGMS = { 0x3A, 0x30, 0x31, 0x30, 0x46, 0x30, 0x30, 0x30, 0x30, 0x0D };                                                  //Get Machine Status

        private byte[] cmdARES = { 0x3A, 0x30, 0x31, 0x30, 0x35, 0x30, 0x38, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x43, 0x0D };  //Alarm Alert

        private byte[] cmdCPA = { 0x3A, 0x30, 0x31, 0x30, 0x37, 0x30, 0x34, 0x30, 0x30, 0x30, 0x30, 0x30, 0x32, 0x0D };                          //공압기기 동작

        private byte[] cmdSUP = { 0x3A, 0x30, 0x31, 0x30, 0x38, 0x30, 0x34, 0x30, 0x30, 0x30, 0x30, 0x30, 0x44, 0x0D };                          //초음파 동작

        //---------------------PORT 연결 및 열기 -------------------------------------------------------------------------------------------------------------------
        public clsSerialComm(SerialPort p1, int mType)
        {
            _serialP1 = p1;
            _nMachineType = mType; //공정1, 공정2

            if (!_serialP1.IsOpen)   //포트가 열려있는지 확인후 열려있지 않으면...  
              _serialP1.Open();     //오류발생해서 임의로 주석 처리...COM1 포트가 없습니다.
            _serialP1.DataReceived += new SerialDataReceivedEventHandler(_serialP1_DataReceived);     //포트를 열고나서 바로 비동기 리스너를 열어준다.

            if (_nMachineType == 1)
            {   //1 공정
                cmdMMR[2] = 0x31;
                cmdMMR[2] = 0x31;
                cmdMMT[2] = 0x31;
                cmdSM1R[2] = 0x31;
                cmdSM1T[2] = 0x31;
                cmdSM2R[2] = 0x31;
                cmdSM2T[2] = 0x31;
                cmdEMT[2] = 0x31;
                cmdGMS[2] = 0x31;
                cmdARES[2] = 0x31;
                cmdCPA[2] = 0x31;
                cmdSUP[2] = 0x31;
            }
            else if (_nMachineType == 2)
            {   //2 공정
                cmdMMR[2] = 0x32;
                cmdMMR[2] = 0x32;
                cmdMMT[2] = 0x32;
                cmdSM1R[2] = 0x32;
                cmdSM1T[2] = 0x32;
                cmdSM2R[2] = 0x32;
                cmdSM2T[2] = 0x32;
                cmdEMT[2] = 0x32;
                cmdGMS[2] = 0x32;
                cmdARES[2] = 0x32;
                cmdCPA[2] = 0x32;
                cmdSUP[2] = 0x32;
            }

            MainMotorRun();         //포트열고 TEST로 데이터 명령 전송 TEST
        }
        //-------------------------------------------------------------------------------------------------------------------------------
        //정(시계)방향 = 0, 역(반시계)방향 = 1
        public void SetDirection(int Direct)
        {
            _nDirection = Direct;
            if (_nDirection == 0)
            {     //정방향
                cmdMMR[7] = 0x30;     //Main Motor
                cmdMMR[11] = 0x33;
                cmdSM1R[7] = 0x30;     //Sub Motor1
                cmdSM1R[11] = 0x33;
                cmdSM2R[7] = 0x30;     //Sub Motor2
                cmdSM2R[11] = 0x33;
            }
            else if (_nDirection == 1)  //역방향
            {
                cmdMMR[7] = 0x31;     //Main Motor
                cmdMMR[11] = 0x33;
                cmdSM1R[7] = 0x31;     //Sub Motor1
                cmdSM1R[11] = 0x33;
                cmdSM2R[7] = 0x31;     //Sub Motor2
                cmdSM2R[11] = 0x33;
            }
        }
        //-----------------------명령 전송-----------------------------------------------------------------------------------------------    

        //private byte[] m_bSendData;             //송신할 데이터를 저장할 바이트 배열

        //Main Motor Run
        public void MainMotorRun()
        {

            byte[] bytes = new byte[cmdMMR.Length - 4];

            Buffer.BlockCopy(cmdMMR, 1, bytes, 0, cmdMMR.Length - 4);

            byte[] chkSum2 = CheckSum(bytes, bytes.Length);
            if (cmdMMR[cmdMMR.Length - 2] == chkSum2[0] && cmdMMR[cmdMMR.Length - 1] == chkSum2[1])
            {
                //_serialP1.Write(cmdMMR, 0, cmdMMR.Length);    //명령 전송...수신은 아래부분의 비동기로 받는다...
            }
        }

        //Main Motor Stop
        public void MainMotorStop()
        {

        }

        //Sub motor1 Run    
        public void SubMotor1Run()
        {

        }

        //Sub Motor1 Stop
        public void SubMotor1Stop()
        {

        }

        //Sub Motor2 Run
        public void SubMotor2Run()
        {

        }

        //Sub Motor2 Stop
        public void SubMotor2Stop()
        {

        }

        //Emergency Stop
        public void EmergencyStop()
        {

        }

        //Get Machine State
        public void GetMachineState()
        {

        }

        public void AlarmReset()
        {

        }

        //공압 기기 동작
        public void ActCompressStart()
        {

        }

        //초음파 동작
        public void SuperWaveStart()
        {

        }

        //----------------------------- 데이터 수신(비동기)----------------------------------------------------------------------------
        //비동기 수신...
        private void _serialP1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            SerialPort recvPort = (SerialPort)sender;
            recvPort.ReadBufferSize = 100;

            recvBuff = new byte[100];       //도착 데이터 최대 74 Bytes 일것으로 생각은 되는데, 100 Bytes로 여유롭게 버퍼를 줌...
            byte[] DataReceived;
            try
            {
                int Len = recvPort.Read(recvBuff, 0, 100);

                DataReceived = new byte[Len];

                Buffer.BlockCopy(recvBuff, 0, DataReceived, 0, Len);

                if (Len >= 11)
                {
                    if ((DataReceived[0] == byteSTX) && (DataReceived[DataReceived.Length - 1] == byteETX))
                    {
                        byte[] bytes = new byte[Len - 4];

                        Buffer.BlockCopy(DataReceived, 1, bytes, 0, DataReceived.Length - 4);

                        byte[] chkSum2 = CheckSum(bytes, bytes.Length);
                        if (DataReceived[DataReceived.Length - 2] == chkSum2[0] && DataReceived[DataReceived.Length - 1] == chkSum2[1])
                        {
                            if (DataReceived[3] == byteRCV_MMR[0] && DataReceived[4] == byteRCV_MMR[1])
                            {   //Main Motor Run 응답

                            }
                            else if (DataReceived[3] == byteRCV_MMT[0] && DataReceived[4] == byteRCV_MMT[1])
                            {   //Main Motor Stop 응답

                            }
                            else if (DataReceived[3] == byteRCV_SM1R[0] && DataReceived[4] == byteRCV_SM1R[1])
                            {   //Sub Motor1 Run  응답

                            }
                            else if (DataReceived[3] == byteRCV_SM1T[0] && DataReceived[4] == byteRCV_SM1T[1])
                            {   //Sub Motor1 Stop  응답

                            }
                            else if (DataReceived[3] == byteRCV_SM2R[0] && DataReceived[4] == byteRCV_SM2R[1])
                            {   //Sub Motor2 Run  응답

                            }
                            else if (DataReceived[3] == byteRCV_SM2T[0] && DataReceived[4] == byteRCV_SM2T[1])
                            {   //Sub Motor2 Stop  응답

                            }
                            else if (DataReceived[3] == byteRCV_EMGSTP[0] && DataReceived[4] == byteRCV_EMGSTP[1])
                            {   //Emergency Stop  응답

                            }
                            else if (DataReceived[3] == byteRCV_MACSTE[0] && DataReceived[4] == byteRCV_MACSTE[1])
                            {   //Get Machine Status  응답

                            }
                            else if (DataReceived[3] == byteRCV_ALMRST[0] && DataReceived[4] == byteRCV_ALMRST[1])
                            {   //Alarm Reset  응답

                            }
                            else if (DataReceived[3] == byteRCV_PREACT[0] && DataReceived[4] == byteRCV_PREACT[1])
                            {   //공압기기동작  응답

                            }
                            else if (DataReceived[3] == byteRCV_SSNACT[0] && DataReceived[4] == byteRCV_SSNACT[1])
                            {   //초음파 동작  응답

                            }
                        }
                        else
                        {
                            MessageBox.Show("CheckSum 오류입니다.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("STX, ETX 오류입니다.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------
        //CheckSum을 계산한다.
        private byte[] CheckSum(byte[] _PacketData, int PacketLength)
        {
            byte _CheckSumByte = 0x00;
            for (int i = 0; i < PacketLength; i++)
                _CheckSumByte ^= _PacketData[i];
            int hex = Int32.Parse(_CheckSumByte.ToString());
            string checkSum = hex.ToString("X2");
            return str2bytes(checkSum);
        }

        static public byte[] str2bytes(string byteData)
        {
            System.Text.ASCIIEncoding asencoding = new System.Text.ASCIIEncoding();
            return Encoding.Default.GetBytes(byteData);
        }

        //맨 앞쪽에 newByte 1개를 추가
        public byte[] addByteToFirstLoc(byte[] bArray, byte FirstByte)
        {
            byte[] newArray = new byte[bArray.Length + 1];
            bArray.CopyTo(newArray, 1);
            newArray[0] = FirstByte;
            return newArray;
        }

        //맨 뒤쪽에 newByte 1개를 추가
        public byte[] addByteToLastLoc(byte[] bArray, byte LastByte)
        {
            byte[] newArray = new byte[bArray.Length + 1];
            bArray.CopyTo(newArray, 0);
            newArray[newArray.Length - 1] = LastByte;
            return newArray;
        }

        //두개의 byteArray를 합쳐서 반환
        public static byte[] Combine(byte[] first, byte[] second)
        {
            byte[] bytes = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, bytes, 0, first.Length);
            Buffer.BlockCopy(second, 0, bytes, first.Length, second.Length);
            return bytes;
        }
        //--------------------------------------------------------------------------------------------------------------------------------
        //동기식
        /*
        static byte[] SendMessage(byte[] message, TimeSpan timeout)
        {
            var stopwatch = Stopwatch.StartNew();

            lock (_syncRoot)
            {
                var originalWriteTimeout = _serialPort.WriteTimeout;
                var originalReadTimeout = _serialPort.ReadTimeout;
                try
                {
                    // Start logical request.
                    _serialPort.WriteTimeout = (int)Math.Max((timeout - stopwatch.Elapsed).TotalMilliseconds, 0);
                    _serialPort.Write(message, 0, message.Length);

                    // Expected response length. Look for the constant value from 
                    // the device communication protocol specification or extract 
                    // from the response header (first response bytes) if there is 
                    // any specified in the protocol.
                    int count = ...;
                    byte[] buffer = new byte[count];
                    int offset = 0;
                    // Loop until we recieve a full response.
                    while (count > 0)
                    {
                        _serialPort.ReadTimeout = (int)Math.Max((timeout - stopwatch.Elapsed).TotalMilliseconds, 0);
                        var readCount = _serialPort.Read(buffer, offset, count);
                        offset += readCount;
                        count -= readCount;
                    }
                    return buffer;
                }
                finally
                {
                    // Restore SerialPort state.
                    _serialPort.ReadTimeout = originalReadTimeout;
                    _serialPort.WriteTimeout = originalWriteTimeout;
                }
            }
        }*/
        public void CloseSerialPort()
        {
            try
            {
                if (_serialP1 != null && _serialP1.IsOpen)
                {
                    _serialP1.Close();
                    return;
                }
                else
                {
                    return;
                }
            }
            catch
            {
                return;
            }
        }
    }
}
