namespace SmartSerialPort_NewEX
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.smartForm1 = new SmartX.SmartForm();
            this.smartKeyPad1 = new SmartX.SmartKeyPad();
            this.comboBaud = new SmartX.SmartComboBox();
            this.comboPortNo = new SmartX.SmartComboBox();
            this.listRecvData = new SmartX.SmartListBox();
            this.smartSeparatorLine2 = new SmartX.SmartSeparatorLine();
            this.radioRecv3 = new SmartX.SmartRadioButton();
            this.radioSend3 = new SmartX.SmartRadioButton();
            this.radioRecv2 = new SmartX.SmartRadioButton();
            this.radioRecv1 = new SmartX.SmartRadioButton();
            this.radioSend2 = new SmartX.SmartRadioButton();
            this.radioSend1 = new SmartX.SmartRadioButton();
            this.checkRecvRept = new SmartX.SmartCheckBox();
            this.checkSendRept = new SmartX.SmartCheckBox();
            this.checkDebugMode = new SmartX.SmartCheckBox();
            this.buttonDOWN = new SmartX.SmartButton();
            this.buttonClear = new SmartX.SmartButton();
            this.buttonUP = new SmartX.SmartButton();
            this.buttonRECV = new SmartX.SmartButton();
            this.buttonSEND = new SmartX.SmartButton();
            this.buttonOPEN = new SmartX.SmartButton();
            this.buttonCLOSE = new SmartX.SmartButton();
            this.comboRecvDataType = new SmartX.SmartComboBox();
            this.comboSendDataType = new SmartX.SmartComboBox();
            this.comboFrameType = new SmartX.SmartComboBox();
            this.comboErrorLo = new SmartX.SmartComboBox();
            this.comboErrorMode = new SmartX.SmartComboBox();
            this.comboDetect = new SmartX.SmartComboBox();
            this.labelETX = new SmartX.SmartLabel();
            this.labelSTX = new SmartX.SmartLabel();
            this.labelPortStatus = new SmartX.SmartLabel();
            this.labelSendData = new SmartX.SmartLabel();
            this.labelRecvInterval = new SmartX.SmartLabel();
            this.labelSendInterval = new SmartX.SmartLabel();
            this.smartLabel21 = new SmartX.SmartLabel();
            this.smartLabel15 = new SmartX.SmartLabel();
            this.smartTimer1 = new SmartX.SmartTimer(this.components);
            this.smartTimer2 = new SmartX.SmartTimer(this.components);
            this.labelRTO = new SmartX.SmartLabel();
            this.labelBuffer = new SmartX.SmartLabel();
            this.labelSepCode = new SmartX.SmartLabel();
            this.smartSeparatorLine1 = new SmartX.SmartSeparatorLine();
            this.smartSerialPort1 = new SmartX.SmartSerialPort();
            ((System.ComponentModel.ISupportInitialize)(this.smartForm1)).BeginInit();
            this.SuspendLayout();
            // 
            // smartForm1
            // 
            this.smartForm1.CenterLocation = false;
            this.smartForm1.Image = ((System.Drawing.Image)(resources.GetObject("smartForm1.Image")));
            this.smartForm1.LCDDirection = SmartX.SmartForm.LCDDIRECTIONS.HORIZONTAL;
            this.smartForm1.LCDSize = SmartX.SmartForm.LCDRESOLUTION.LCD800X480;
            this.smartForm1.Location = new System.Drawing.Point(0, 0);
            this.smartForm1.MainForm = null;
            this.smartForm1.Mode = SmartX.SmartForm.RUNMODE.DEVELOPER;
            this.smartForm1.MouseCursor = SmartX.SmartForm.OnOff.ON;
            this.smartForm1.Name = "smartForm1";
            this.smartForm1.Size = new System.Drawing.Size(800, 480);
            this.smartForm1.SpecialFunctionClickPointSize = 100;
            this.smartForm1.SuspendLayoutInterval = 1;
            // 
            // smartKeyPad1
            // 
            this.smartKeyPad1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.smartKeyPad1.BackPictureBox = null;
            this.smartKeyPad1.BackPictureBox1 = null;
            this.smartKeyPad1.BackPictureBox2 = null;
            this.smartKeyPad1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.smartKeyPad1.InitVisible = true;
            this.smartKeyPad1.keyDownImageCommon = null;
            this.smartKeyPad1.KeyPadBackImage = null;
            this.smartKeyPad1.KeyTextColor = System.Drawing.Color.Black;
            this.smartKeyPad1.KeyTextFont = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.smartKeyPad1.KeyTextLeftOffset = 0;
            this.smartKeyPad1.KeyTextTopOffset = 0;
            this.smartKeyPad1.KeyTextVisible = true;
            this.smartKeyPad1.keyUpImageCommon = null;
            this.smartKeyPad1.Location = new System.Drawing.Point(240, 12);
            this.smartKeyPad1.Name = "smartKeyPad1";
            this.smartKeyPad1.Size = new System.Drawing.Size(37, 27);
            this.smartKeyPad1.TabIndex = 62;
            this.smartKeyPad1.TargetInputObject = null;
            this.smartKeyPad1.Text = "smartKeyPad1";
            this.smartKeyPad1.TransparentKeyImage = true;
            this.smartKeyPad1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.smartKeyPad1_KeyPress);
            // 
            // comboBaud
            // 
            this.comboBaud.AutoResize = false;
            this.comboBaud.BackColor = System.Drawing.Color.White;
            this.comboBaud.BackPictureBox = null;
            this.comboBaud.BackPictureBox1 = null;
            this.comboBaud.BackPictureBox2 = null;
            this.comboBaud.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.comboBaud.BorderStyle = SmartX.SmartComboBox.BORDERSTYLES.FixedSingle2;
            this.comboBaud.DropDownButtonDownImage = null;
            this.comboBaud.DropDownButtonLocation = new System.Drawing.Point(103, 2);
            this.comboBaud.DropDownButtonSize = new System.Drawing.Size(32, 25);
            this.comboBaud.DropDownButtonText = "▼";
            this.comboBaud.DropDownButtonUpImage = null;
            this.comboBaud.DropDownHeight = 265;
            this.comboBaud.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.comboBaud.ForeColor = System.Drawing.Color.Black;
            this.comboBaud.InitVisible = true;
            this.comboBaud.ItemListBackImage = null;
            this.comboBaud.ItemListBackPictureBoxApply = false;
            this.comboBaud.ItemListFontColor = System.Drawing.Color.Black;
            this.comboBaud.ItemListItemOffsetGap = 10;
            this.comboBaud.ItemListItemOffsetX = 3;
            this.comboBaud.ItemListItemOffsetY = 0;
            this.comboBaud.ItemListLocation = new System.Drawing.Point(2, 28);
            this.comboBaud.ItemListSelectColor = System.Drawing.Color.DeepSkyBlue;
            this.comboBaud.ItemListSelectFilled = true;
            this.comboBaud.ItemListSelectFontColor = System.Drawing.Color.White;
            this.comboBaud.ItemListSelectItemIndex = -1;
            this.comboBaud.ItemListSeparationlineColor1 = System.Drawing.Color.Gray;
            this.comboBaud.ItemListSeparationlineColor2 = System.Drawing.Color.LightGray;
            this.comboBaud.ItemListSeparationLineStyle = SmartX.SmartListBox.SEPARATIONLINETYPES.FixedSingle;
            this.comboBaud.ItemListSeparationlineVisibleBottom = true;
            this.comboBaud.ItemListSeparationlineVisibleTop = true;
            this.comboBaud.ItemListSize = new System.Drawing.Size(103, 260);
            this.comboBaud.ItemListviewDesigntime = false;
            this.comboBaud.Location = new System.Drawing.Point(152, 159);
            this.comboBaud.Name = "comboBaud";
            this.comboBaud.ScrollDownButtonDownImage = null;
            this.comboBaud.ScrollDownButtonLocation = new System.Drawing.Point(103, 160);
            this.comboBaud.ScrollDownButtonSize = new System.Drawing.Size(32, 130);
            this.comboBaud.ScrollDownButtonText = "▼";
            this.comboBaud.ScrollDownButtonUpImage = null;
            this.comboBaud.ScrollUpButtonDownImage = null;
            this.comboBaud.ScrollUpButtonLocation = new System.Drawing.Point(103, 29);
            this.comboBaud.ScrollUpButtonSize = new System.Drawing.Size(32, 130);
            this.comboBaud.ScrollUpButtonText = "▲";
            this.comboBaud.ScrollUpButtonUpImage = null;
            this.comboBaud.Size = new System.Drawing.Size(137, 29);
            this.comboBaud.TabIndex = 38;
            this.comboBaud.TextLeftOffset = 3;
            this.comboBaud.SelectedIndexChanged += new System.EventHandler(this.comboBaud_SelectedIndexChanged);
            // 
            // comboPortNo
            // 
            this.comboPortNo.AutoResize = false;
            this.comboPortNo.BackColor = System.Drawing.Color.White;
            this.comboPortNo.BackPictureBox = null;
            this.comboPortNo.BackPictureBox1 = null;
            this.comboPortNo.BackPictureBox2 = null;
            this.comboPortNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.comboPortNo.BorderStyle = SmartX.SmartComboBox.BORDERSTYLES.FixedSingle2;
            this.comboPortNo.DropDownButtonDownImage = null;
            this.comboPortNo.DropDownButtonLocation = new System.Drawing.Point(103, 2);
            this.comboPortNo.DropDownButtonSize = new System.Drawing.Size(32, 24);
            this.comboPortNo.DropDownButtonText = "▼";
            this.comboPortNo.DropDownButtonUpImage = null;
            this.comboPortNo.DropDownHeight = 115;
            this.comboPortNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.comboPortNo.ForeColor = System.Drawing.Color.Black;
            this.comboPortNo.InitVisible = true;
            this.comboPortNo.ItemListBackImage = null;
            this.comboPortNo.ItemListBackPictureBoxApply = false;
            this.comboPortNo.ItemListFontColor = System.Drawing.Color.Black;
            this.comboPortNo.ItemListItemOffsetGap = 10;
            this.comboPortNo.ItemListItemOffsetX = 3;
            this.comboPortNo.ItemListItemOffsetY = 0;
            this.comboPortNo.ItemListLocation = new System.Drawing.Point(2, 27);
            this.comboPortNo.ItemListSelectColor = System.Drawing.Color.DeepSkyBlue;
            this.comboPortNo.ItemListSelectFilled = true;
            this.comboPortNo.ItemListSelectFontColor = System.Drawing.Color.White;
            this.comboPortNo.ItemListSelectItemIndex = -1;
            this.comboPortNo.ItemListSeparationlineColor1 = System.Drawing.Color.Gray;
            this.comboPortNo.ItemListSeparationlineColor2 = System.Drawing.Color.LightGray;
            this.comboPortNo.ItemListSeparationLineStyle = SmartX.SmartListBox.SEPARATIONLINETYPES.FixedSingle;
            this.comboPortNo.ItemListSeparationlineVisibleBottom = true;
            this.comboPortNo.ItemListSeparationlineVisibleTop = true;
            this.comboPortNo.ItemListSize = new System.Drawing.Size(103, 110);
            this.comboPortNo.ItemListviewDesigntime = false;
            this.comboPortNo.Location = new System.Drawing.Point(9, 159);
            this.comboPortNo.Name = "comboPortNo";
            this.comboPortNo.ScrollDownButtonDownImage = null;
            this.comboPortNo.ScrollDownButtonLocation = new System.Drawing.Point(103, 85);
            this.comboPortNo.ScrollDownButtonSize = new System.Drawing.Size(32, 55);
            this.comboPortNo.ScrollDownButtonText = "▼";
            this.comboPortNo.ScrollDownButtonUpImage = null;
            this.comboPortNo.ScrollUpButtonDownImage = null;
            this.comboPortNo.ScrollUpButtonLocation = new System.Drawing.Point(103, 28);
            this.comboPortNo.ScrollUpButtonSize = new System.Drawing.Size(32, 55);
            this.comboPortNo.ScrollUpButtonText = "▲";
            this.comboPortNo.ScrollUpButtonUpImage = null;
            this.comboPortNo.Size = new System.Drawing.Size(137, 29);
            this.comboPortNo.TabIndex = 37;
            this.comboPortNo.TextLeftOffset = 3;
            this.comboPortNo.SelectedIndexChanged += new System.EventHandler(this.comboPortNo_SelectedIndexChanged);
            // 
            // listRecvData
            // 
            this.listRecvData.BackPictureBox = this.smartForm1;
            this.listRecvData.BackPictureBox1 = null;
            this.listRecvData.BackPictureBox2 = null;
            this.listRecvData.ColumnAlign = SmartX.SmartListBox.COLUMNALIGNS.CENTER;
            this.listRecvData.ColumnDelimiter = '\0';
            this.listRecvData.ColumnOffsets = null;
            this.listRecvData.FontColor = System.Drawing.Color.Black;
            this.listRecvData.InitVisible = true;
            this.listRecvData.ItemAddOrder = SmartX.SmartListBox.ITEMADDORDERS.TOPADD;
            this.listRecvData.ItemOffsetGap = 0;
            this.listRecvData.ItemOffsetX = 0;
            this.listRecvData.ItemOffsetY = 0;
            this.listRecvData.Location = new System.Drawing.Point(301, 207);
            this.listRecvData.MouseMoveEventSpace = 3;
            this.listRecvData.MouseMoveSpace = 10;
            this.listRecvData.Name = "listRecvData";
            this.listRecvData.OutLineColor = System.Drawing.SystemColors.ControlText;
            this.listRecvData.SelectColor = System.Drawing.Color.Blue;
            this.listRecvData.SelectFilled = true;
            this.listRecvData.SelectFontColor = System.Drawing.Color.DarkBlue;
            this.listRecvData.SelectItemIndex = -1;
            this.listRecvData.SeparationlineColor1 = System.Drawing.Color.Gray;
            this.listRecvData.SeparationlineColor2 = System.Drawing.Color.LightGray;
            this.listRecvData.SeparationLineStyle = SmartX.SmartListBox.SEPARATIONLINETYPES.FixedSingle;
            this.listRecvData.SeparationlineVisibleBottom = false;
            this.listRecvData.SeparationlineVisibleTop = false;
            this.listRecvData.Size = new System.Drawing.Size(445, 262);
            this.listRecvData.TabIndex = 61;
            this.listRecvData.Text = "smartListBox1";
            // 
            // smartSeparatorLine2
            // 
            this.smartSeparatorLine2.InitVisible = true;
            this.smartSeparatorLine2.Line1Color = System.Drawing.Color.DimGray;
            this.smartSeparatorLine2.Line1Width = 1F;
            this.smartSeparatorLine2.Line2Color = System.Drawing.Color.LightGray;
            this.smartSeparatorLine2.Line2Visible = true;
            this.smartSeparatorLine2.Line2Width = 1F;
            this.smartSeparatorLine2.LineDirection = SmartX.SmartSeparatorLine.DIR.Horizontal;
            this.smartSeparatorLine2.Location = new System.Drawing.Point(301, 124);
            this.smartSeparatorLine2.Name = "smartSeparatorLine2";
            this.smartSeparatorLine2.Size = new System.Drawing.Size(495, 2);
            this.smartSeparatorLine2.TabIndex = 60;
            this.smartSeparatorLine2.Text = "smartSeparatorLine2";
            // 
            // radioRecv3
            // 
            this.radioRecv3.BackPictureBox = this.smartForm1;
            this.radioRecv3.BackPictureBox1 = null;
            this.radioRecv3.BackPictureBox2 = null;
            this.radioRecv3.Checked = false;
            this.radioRecv3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.radioRecv3.GroupID = 1;
            this.radioRecv3.ImageCheckRadioButton = ((System.Drawing.Image)(resources.GetObject("radioRecv3.ImageCheckRadioButton")));
            this.radioRecv3.ImageUnCheckRadioButton = ((System.Drawing.Image)(resources.GetObject("radioRecv3.ImageUnCheckRadioButton")));
            this.radioRecv3.InitVisible = true;
            this.radioRecv3.Location = new System.Drawing.Point(549, 168);
            this.radioRecv3.Name = "radioRecv3";
            this.radioRecv3.OutputOnly = false;
            this.radioRecv3.RadioBackColor = System.Drawing.Color.White;
            this.radioRecv3.RadioCheckColor = System.Drawing.Color.Green;
            this.radioRecv3.RadioForeColor = System.Drawing.Color.Black;
            this.radioRecv3.RadioSymbolSize = 14;
            this.radioRecv3.Shadow = false;
            this.radioRecv3.Size = new System.Drawing.Size(69, 27);
            this.radioRecv3.TabIndex = 55;
            this.radioRecv3.Text = "hex";
            this.radioRecv3.TextVAlign = SmartX.SmartRadioButton.TextVerAlign.Middle;
            // 
            // radioSend3
            // 
            this.radioSend3.BackPictureBox = this.smartForm1;
            this.radioSend3.BackPictureBox1 = null;
            this.radioSend3.BackPictureBox2 = null;
            this.radioSend3.Checked = false;
            this.radioSend3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.radioSend3.GroupID = 0;
            this.radioSend3.ImageCheckRadioButton = ((System.Drawing.Image)(resources.GetObject("radioSend3.ImageCheckRadioButton")));
            this.radioSend3.ImageUnCheckRadioButton = ((System.Drawing.Image)(resources.GetObject("radioSend3.ImageUnCheckRadioButton")));
            this.radioSend3.InitVisible = true;
            this.radioSend3.Location = new System.Drawing.Point(549, 55);
            this.radioSend3.Name = "radioSend3";
            this.radioSend3.OutputOnly = false;
            this.radioSend3.RadioBackColor = System.Drawing.Color.White;
            this.radioSend3.RadioCheckColor = System.Drawing.Color.Green;
            this.radioSend3.RadioForeColor = System.Drawing.Color.Black;
            this.radioSend3.RadioSymbolSize = 14;
            this.radioSend3.Shadow = false;
            this.radioSend3.Size = new System.Drawing.Size(70, 27);
            this.radioSend3.TabIndex = 54;
            this.radioSend3.Text = "hex";
            this.radioSend3.TextVAlign = SmartX.SmartRadioButton.TextVerAlign.Middle;
            this.radioSend3.Click += new System.EventHandler(this.radioSend_Click);
            // 
            // radioRecv2
            // 
            this.radioRecv2.BackPictureBox = this.smartForm1;
            this.radioRecv2.BackPictureBox1 = null;
            this.radioRecv2.BackPictureBox2 = null;
            this.radioRecv2.Checked = false;
            this.radioRecv2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.radioRecv2.GroupID = 1;
            this.radioRecv2.ImageCheckRadioButton = ((System.Drawing.Image)(resources.GetObject("radioRecv2.ImageCheckRadioButton")));
            this.radioRecv2.ImageUnCheckRadioButton = ((System.Drawing.Image)(resources.GetObject("radioRecv2.ImageUnCheckRadioButton")));
            this.radioRecv2.InitVisible = true;
            this.radioRecv2.Location = new System.Drawing.Point(456, 168);
            this.radioRecv2.Name = "radioRecv2";
            this.radioRecv2.OutputOnly = false;
            this.radioRecv2.RadioBackColor = System.Drawing.Color.White;
            this.radioRecv2.RadioCheckColor = System.Drawing.Color.Green;
            this.radioRecv2.RadioForeColor = System.Drawing.Color.Black;
            this.radioRecv2.RadioSymbolSize = 14;
            this.radioRecv2.Shadow = false;
            this.radioRecv2.Size = new System.Drawing.Size(81, 27);
            this.radioRecv2.TabIndex = 58;
            this.radioRecv2.Text = "float";
            this.radioRecv2.TextVAlign = SmartX.SmartRadioButton.TextVerAlign.Middle;
            // 
            // radioRecv1
            // 
            this.radioRecv1.BackPictureBox = this.smartForm1;
            this.radioRecv1.BackPictureBox1 = null;
            this.radioRecv1.BackPictureBox2 = null;
            this.radioRecv1.Checked = true;
            this.radioRecv1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.radioRecv1.GroupID = 1;
            this.radioRecv1.ImageCheckRadioButton = ((System.Drawing.Image)(resources.GetObject("radioRecv1.ImageCheckRadioButton")));
            this.radioRecv1.ImageUnCheckRadioButton = ((System.Drawing.Image)(resources.GetObject("radioRecv1.ImageUnCheckRadioButton")));
            this.radioRecv1.InitVisible = true;
            this.radioRecv1.Location = new System.Drawing.Point(382, 168);
            this.radioRecv1.Name = "radioRecv1";
            this.radioRecv1.OutputOnly = false;
            this.radioRecv1.RadioBackColor = System.Drawing.Color.White;
            this.radioRecv1.RadioCheckColor = System.Drawing.Color.Green;
            this.radioRecv1.RadioForeColor = System.Drawing.Color.Black;
            this.radioRecv1.RadioSymbolSize = 14;
            this.radioRecv1.Shadow = false;
            this.radioRecv1.Size = new System.Drawing.Size(70, 27);
            this.radioRecv1.TabIndex = 59;
            this.radioRecv1.Text = "int";
            this.radioRecv1.TextVAlign = SmartX.SmartRadioButton.TextVerAlign.Middle;
            // 
            // radioSend2
            // 
            this.radioSend2.BackPictureBox = this.smartForm1;
            this.radioSend2.BackPictureBox1 = null;
            this.radioSend2.BackPictureBox2 = null;
            this.radioSend2.Checked = false;
            this.radioSend2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.radioSend2.GroupID = 0;
            this.radioSend2.ImageCheckRadioButton = ((System.Drawing.Image)(resources.GetObject("radioSend2.ImageCheckRadioButton")));
            this.radioSend2.ImageUnCheckRadioButton = ((System.Drawing.Image)(resources.GetObject("radioSend2.ImageUnCheckRadioButton")));
            this.radioSend2.InitVisible = true;
            this.radioSend2.Location = new System.Drawing.Point(456, 55);
            this.radioSend2.Name = "radioSend2";
            this.radioSend2.OutputOnly = false;
            this.radioSend2.RadioBackColor = System.Drawing.Color.White;
            this.radioSend2.RadioCheckColor = System.Drawing.Color.Green;
            this.radioSend2.RadioForeColor = System.Drawing.Color.Black;
            this.radioSend2.RadioSymbolSize = 14;
            this.radioSend2.Shadow = false;
            this.radioSend2.Size = new System.Drawing.Size(81, 27);
            this.radioSend2.TabIndex = 56;
            this.radioSend2.Text = "float";
            this.radioSend2.TextVAlign = SmartX.SmartRadioButton.TextVerAlign.Middle;
            this.radioSend2.Click += new System.EventHandler(this.radioSend_Click);
            // 
            // radioSend1
            // 
            this.radioSend1.BackPictureBox = this.smartForm1;
            this.radioSend1.BackPictureBox1 = null;
            this.radioSend1.BackPictureBox2 = null;
            this.radioSend1.Checked = true;
            this.radioSend1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.radioSend1.GroupID = 0;
            this.radioSend1.ImageCheckRadioButton = ((System.Drawing.Image)(resources.GetObject("radioSend1.ImageCheckRadioButton")));
            this.radioSend1.ImageUnCheckRadioButton = ((System.Drawing.Image)(resources.GetObject("radioSend1.ImageUnCheckRadioButton")));
            this.radioSend1.InitVisible = true;
            this.radioSend1.Location = new System.Drawing.Point(382, 55);
            this.radioSend1.Name = "radioSend1";
            this.radioSend1.OutputOnly = false;
            this.radioSend1.RadioBackColor = System.Drawing.Color.White;
            this.radioSend1.RadioCheckColor = System.Drawing.Color.Green;
            this.radioSend1.RadioForeColor = System.Drawing.Color.Black;
            this.radioSend1.RadioSymbolSize = 14;
            this.radioSend1.Shadow = false;
            this.radioSend1.Size = new System.Drawing.Size(70, 27);
            this.radioSend1.TabIndex = 57;
            this.radioSend1.Text = "int";
            this.radioSend1.TextVAlign = SmartX.SmartRadioButton.TextVerAlign.Middle;
            this.radioSend1.Click += new System.EventHandler(this.radioSend_Click);
            // 
            // checkRecvRept
            // 
            this.checkRecvRept.BackPictureBox = this.smartForm1;
            this.checkRecvRept.BackPictureBox1 = null;
            this.checkRecvRept.BackPictureBox2 = null;
            this.checkRecvRept.CheckBoxBackColor = System.Drawing.Color.White;
            this.checkRecvRept.CheckBoxCheckColor = System.Drawing.Color.Green;
            this.checkRecvRept.CheckBoxForeColor = System.Drawing.Color.Black;
            this.checkRecvRept.CheckBoxSymbolSize = 14;
            this.checkRecvRept.Checked = false;
            this.checkRecvRept.CheckLineWidth = 3;
            this.checkRecvRept.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.checkRecvRept.ImageCheckBox = ((System.Drawing.Image)(resources.GetObject("checkRecvRept.ImageCheckBox")));
            this.checkRecvRept.ImageUnCheckBox = ((System.Drawing.Image)(resources.GetObject("checkRecvRept.ImageUnCheckBox")));
            this.checkRecvRept.InitVisible = true;
            this.checkRecvRept.Location = new System.Drawing.Point(625, 168);
            this.checkRecvRept.Name = "checkRecvRept";
            this.checkRecvRept.Size = new System.Drawing.Size(71, 26);
            this.checkRecvRept.TabIndex = 50;
            this.checkRecvRept.Text = "Repeat";
            this.checkRecvRept.TextVAlign = SmartX.SmartCheckBox.TextVerAlign.Middle;
            this.checkRecvRept.Visible = false;
            this.checkRecvRept.Click += new System.EventHandler(this.checkRecvRept_Click);
            // 
            // checkSendRept
            // 
            this.checkSendRept.BackPictureBox = this.smartForm1;
            this.checkSendRept.BackPictureBox1 = null;
            this.checkSendRept.BackPictureBox2 = null;
            this.checkSendRept.CheckBoxBackColor = System.Drawing.Color.White;
            this.checkSendRept.CheckBoxCheckColor = System.Drawing.Color.Green;
            this.checkSendRept.CheckBoxForeColor = System.Drawing.Color.Black;
            this.checkSendRept.CheckBoxSymbolSize = 14;
            this.checkSendRept.Checked = false;
            this.checkSendRept.CheckLineWidth = 3;
            this.checkSendRept.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.checkSendRept.ImageCheckBox = ((System.Drawing.Image)(resources.GetObject("checkSendRept.ImageCheckBox")));
            this.checkSendRept.ImageUnCheckBox = ((System.Drawing.Image)(resources.GetObject("checkSendRept.ImageUnCheckBox")));
            this.checkSendRept.InitVisible = true;
            this.checkSendRept.Location = new System.Drawing.Point(702, 11);
            this.checkSendRept.Name = "checkSendRept";
            this.checkSendRept.Size = new System.Drawing.Size(69, 27);
            this.checkSendRept.TabIndex = 52;
            this.checkSendRept.Text = "Repeat";
            this.checkSendRept.TextVAlign = SmartX.SmartCheckBox.TextVerAlign.Middle;
            this.checkSendRept.Click += new System.EventHandler(this.checkSendRept_Click);
            // 
            // checkDebugMode
            // 
            this.checkDebugMode.BackPictureBox = this.smartForm1;
            this.checkDebugMode.BackPictureBox1 = null;
            this.checkDebugMode.BackPictureBox2 = null;
            this.checkDebugMode.CheckBoxBackColor = System.Drawing.Color.White;
            this.checkDebugMode.CheckBoxCheckColor = System.Drawing.Color.Green;
            this.checkDebugMode.CheckBoxForeColor = System.Drawing.Color.Black;
            this.checkDebugMode.CheckBoxSymbolSize = 14;
            this.checkDebugMode.Checked = false;
            this.checkDebugMode.CheckLineWidth = 3;
            this.checkDebugMode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.checkDebugMode.ImageCheckBox = ((System.Drawing.Image)(resources.GetObject("checkDebugMode.ImageCheckBox")));
            this.checkDebugMode.ImageUnCheckBox = ((System.Drawing.Image)(resources.GetObject("checkDebugMode.ImageUnCheckBox")));
            this.checkDebugMode.InitVisible = true;
            this.checkDebugMode.Location = new System.Drawing.Point(9, 435);
            this.checkDebugMode.Name = "checkDebugMode";
            this.checkDebugMode.Size = new System.Drawing.Size(278, 28);
            this.checkDebugMode.TabIndex = 51;
            this.checkDebugMode.Text = "ReceiveFrameDebugMode";
            this.checkDebugMode.TextVAlign = SmartX.SmartCheckBox.TextVerAlign.Middle;
            this.checkDebugMode.Click += new System.EventHandler(this.checkDebugMode_Click);
            // 
            // buttonDOWN
            // 
            this.buttonDOWN.BackPictureBox = null;
            this.buttonDOWN.BackPictureBox1 = null;
            this.buttonDOWN.BackPictureBox2 = null;
            this.buttonDOWN.ButtonColor = System.Drawing.Color.Gray;
            this.buttonDOWN.ButtonImageAutoSize = true;
            this.buttonDOWN.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.buttonDOWN.DisableImage = null;
            this.buttonDOWN.DownImage = ((System.Drawing.Image)(resources.GetObject("buttonDOWN.DownImage")));
            this.buttonDOWN.GroupID = 0;
            this.buttonDOWN.InitVisible = true;
            this.buttonDOWN.Location = new System.Drawing.Point(747, 339);
            this.buttonDOWN.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.buttonDOWN.Name = "buttonDOWN";
            this.buttonDOWN.NestedClickEventPrevent = false;
            this.buttonDOWN.OutlinePixel = 1;
            this.buttonDOWN.RepeatInterval = 200;
            this.buttonDOWN.RepeatIntervalAccelerate = null;
            this.buttonDOWN.SafeInterval = 200;
            this.buttonDOWN.Size = new System.Drawing.Size(41, 132);
            this.buttonDOWN.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.buttonDOWN.TabIndex = 44;
            this.buttonDOWN.TextColor = System.Drawing.Color.Black;
            this.buttonDOWN.TextDownColor = System.Drawing.Color.White;
            this.buttonDOWN.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.buttonDOWN.TextLocation = new System.Drawing.Point(0, 0);
            this.buttonDOWN.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.buttonDOWN.UpImage = ((System.Drawing.Image)(resources.GetObject("buttonDOWN.UpImage")));
            this.buttonDOWN.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackPictureBox = null;
            this.buttonClear.BackPictureBox1 = null;
            this.buttonClear.BackPictureBox2 = null;
            this.buttonClear.ButtonColor = System.Drawing.Color.Gray;
            this.buttonClear.ButtonImageAutoSize = true;
            this.buttonClear.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.buttonClear.DisableImage = null;
            this.buttonClear.DownImage = ((System.Drawing.Image)(resources.GetObject("buttonClear.DownImage")));
            this.buttonClear.GroupID = 0;
            this.buttonClear.InitVisible = true;
            this.buttonClear.Location = new System.Drawing.Point(703, 168);
            this.buttonClear.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.NestedClickEventPrevent = false;
            this.buttonClear.OutlinePixel = 1;
            this.buttonClear.RepeatInterval = 200;
            this.buttonClear.RepeatIntervalAccelerate = null;
            this.buttonClear.SafeInterval = 200;
            this.buttonClear.Size = new System.Drawing.Size(85, 29);
            this.buttonClear.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.buttonClear.TabIndex = 43;
            this.buttonClear.TextColor = System.Drawing.Color.Black;
            this.buttonClear.TextDownColor = System.Drawing.Color.White;
            this.buttonClear.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.buttonClear.TextLocation = new System.Drawing.Point(0, 0);
            this.buttonClear.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.buttonClear.UpImage = ((System.Drawing.Image)(resources.GetObject("buttonClear.UpImage")));
            this.buttonClear.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonUP
            // 
            this.buttonUP.BackPictureBox = null;
            this.buttonUP.BackPictureBox1 = null;
            this.buttonUP.BackPictureBox2 = null;
            this.buttonUP.ButtonColor = System.Drawing.Color.Gray;
            this.buttonUP.ButtonImageAutoSize = true;
            this.buttonUP.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.buttonUP.DisableImage = null;
            this.buttonUP.DownImage = ((System.Drawing.Image)(resources.GetObject("buttonUP.DownImage")));
            this.buttonUP.GroupID = 0;
            this.buttonUP.InitVisible = true;
            this.buttonUP.Location = new System.Drawing.Point(747, 205);
            this.buttonUP.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.NestedClickEventPrevent = false;
            this.buttonUP.OutlinePixel = 1;
            this.buttonUP.RepeatInterval = 200;
            this.buttonUP.RepeatIntervalAccelerate = null;
            this.buttonUP.SafeInterval = 200;
            this.buttonUP.Size = new System.Drawing.Size(41, 134);
            this.buttonUP.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.buttonUP.TabIndex = 48;
            this.buttonUP.TextColor = System.Drawing.Color.Black;
            this.buttonUP.TextDownColor = System.Drawing.Color.White;
            this.buttonUP.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.buttonUP.TextLocation = new System.Drawing.Point(0, 0);
            this.buttonUP.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.buttonUP.UpImage = ((System.Drawing.Image)(resources.GetObject("buttonUP.UpImage")));
            this.buttonUP.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonRECV
            // 
            this.buttonRECV.BackPictureBox = null;
            this.buttonRECV.BackPictureBox1 = null;
            this.buttonRECV.BackPictureBox2 = null;
            this.buttonRECV.ButtonColor = System.Drawing.Color.Gray;
            this.buttonRECV.ButtonImageAutoSize = true;
            this.buttonRECV.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.buttonRECV.DisableImage = null;
            this.buttonRECV.DownImage = ((System.Drawing.Image)(resources.GetObject("buttonRECV.DownImage")));
            this.buttonRECV.GroupID = 0;
            this.buttonRECV.InitVisible = true;
            this.buttonRECV.Location = new System.Drawing.Point(702, 129);
            this.buttonRECV.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.buttonRECV.Name = "buttonRECV";
            this.buttonRECV.NestedClickEventPrevent = false;
            this.buttonRECV.OutlinePixel = 1;
            this.buttonRECV.RepeatInterval = 200;
            this.buttonRECV.RepeatIntervalAccelerate = null;
            this.buttonRECV.SafeInterval = 200;
            this.buttonRECV.Size = new System.Drawing.Size(85, 34);
            this.buttonRECV.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.buttonRECV.TabIndex = 49;
            this.buttonRECV.TextColor = System.Drawing.Color.Black;
            this.buttonRECV.TextDownColor = System.Drawing.Color.White;
            this.buttonRECV.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.buttonRECV.TextLocation = new System.Drawing.Point(0, 0);
            this.buttonRECV.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.buttonRECV.UpImage = ((System.Drawing.Image)(resources.GetObject("buttonRECV.UpImage")));
            this.buttonRECV.Visible = false;
            this.buttonRECV.Click += new System.EventHandler(this.buttonRECV_Click);
            // 
            // buttonSEND
            // 
            this.buttonSEND.BackPictureBox = null;
            this.buttonSEND.BackPictureBox1 = null;
            this.buttonSEND.BackPictureBox2 = null;
            this.buttonSEND.ButtonColor = System.Drawing.Color.Gray;
            this.buttonSEND.ButtonImageAutoSize = true;
            this.buttonSEND.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.buttonSEND.DisableImage = null;
            this.buttonSEND.DownImage = ((System.Drawing.Image)(resources.GetObject("buttonSEND.DownImage")));
            this.buttonSEND.GroupID = 0;
            this.buttonSEND.InitVisible = true;
            this.buttonSEND.Location = new System.Drawing.Point(702, 54);
            this.buttonSEND.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.buttonSEND.Name = "buttonSEND";
            this.buttonSEND.NestedClickEventPrevent = false;
            this.buttonSEND.OutlinePixel = 1;
            this.buttonSEND.RepeatInterval = 200;
            this.buttonSEND.RepeatIntervalAccelerate = null;
            this.buttonSEND.SafeInterval = 200;
            this.buttonSEND.Size = new System.Drawing.Size(85, 63);
            this.buttonSEND.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.buttonSEND.TabIndex = 45;
            this.buttonSEND.TextColor = System.Drawing.Color.Black;
            this.buttonSEND.TextDownColor = System.Drawing.Color.White;
            this.buttonSEND.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.buttonSEND.TextLocation = new System.Drawing.Point(0, 0);
            this.buttonSEND.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.buttonSEND.UpImage = ((System.Drawing.Image)(resources.GetObject("buttonSEND.UpImage")));
            this.buttonSEND.Click += new System.EventHandler(this.buttonSEND_Click);
            // 
            // buttonOPEN
            // 
            this.buttonOPEN.BackPictureBox = null;
            this.buttonOPEN.BackPictureBox1 = null;
            this.buttonOPEN.BackPictureBox2 = null;
            this.buttonOPEN.ButtonColor = System.Drawing.Color.Gray;
            this.buttonOPEN.ButtonImageAutoSize = true;
            this.buttonOPEN.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.buttonOPEN.DisableImage = null;
            this.buttonOPEN.DownImage = ((System.Drawing.Image)(resources.GetObject("buttonOPEN.DownImage")));
            this.buttonOPEN.GroupID = 0;
            this.buttonOPEN.InitVisible = true;
            this.buttonOPEN.Location = new System.Drawing.Point(128, 54);
            this.buttonOPEN.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.buttonOPEN.Name = "buttonOPEN";
            this.buttonOPEN.NestedClickEventPrevent = false;
            this.buttonOPEN.OutlinePixel = 1;
            this.buttonOPEN.RepeatInterval = 200;
            this.buttonOPEN.RepeatIntervalAccelerate = null;
            this.buttonOPEN.SafeInterval = 200;
            this.buttonOPEN.Size = new System.Drawing.Size(81, 63);
            this.buttonOPEN.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.buttonOPEN.TabIndex = 46;
            this.buttonOPEN.TextColor = System.Drawing.Color.Black;
            this.buttonOPEN.TextDownColor = System.Drawing.Color.White;
            this.buttonOPEN.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.buttonOPEN.TextLocation = new System.Drawing.Point(0, 0);
            this.buttonOPEN.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.buttonOPEN.UpImage = ((System.Drawing.Image)(resources.GetObject("buttonOPEN.UpImage")));
            this.buttonOPEN.Click += new System.EventHandler(this.buttonOPEN_Click);
            // 
            // buttonCLOSE
            // 
            this.buttonCLOSE.BackPictureBox = null;
            this.buttonCLOSE.BackPictureBox1 = null;
            this.buttonCLOSE.BackPictureBox2 = null;
            this.buttonCLOSE.ButtonColor = System.Drawing.Color.Gray;
            this.buttonCLOSE.ButtonImageAutoSize = true;
            this.buttonCLOSE.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.buttonCLOSE.DisableImage = null;
            this.buttonCLOSE.DownImage = ((System.Drawing.Image)(resources.GetObject("buttonCLOSE.DownImage")));
            this.buttonCLOSE.GroupID = 0;
            this.buttonCLOSE.InitVisible = true;
            this.buttonCLOSE.Location = new System.Drawing.Point(209, 54);
            this.buttonCLOSE.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.buttonCLOSE.Name = "buttonCLOSE";
            this.buttonCLOSE.NestedClickEventPrevent = false;
            this.buttonCLOSE.OutlinePixel = 1;
            this.buttonCLOSE.RepeatInterval = 200;
            this.buttonCLOSE.RepeatIntervalAccelerate = null;
            this.buttonCLOSE.SafeInterval = 200;
            this.buttonCLOSE.Size = new System.Drawing.Size(80, 63);
            this.buttonCLOSE.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.buttonCLOSE.TabIndex = 47;
            this.buttonCLOSE.TextColor = System.Drawing.Color.Black;
            this.buttonCLOSE.TextDownColor = System.Drawing.Color.White;
            this.buttonCLOSE.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.buttonCLOSE.TextLocation = new System.Drawing.Point(0, 0);
            this.buttonCLOSE.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.buttonCLOSE.UpImage = ((System.Drawing.Image)(resources.GetObject("buttonCLOSE.UpImage")));
            this.buttonCLOSE.Click += new System.EventHandler(this.buttonCLOSE_Click);
            // 
            // comboRecvDataType
            // 
            this.comboRecvDataType.AutoResize = false;
            this.comboRecvDataType.BackColor = System.Drawing.Color.White;
            this.comboRecvDataType.BackPictureBox = null;
            this.comboRecvDataType.BackPictureBox1 = null;
            this.comboRecvDataType.BackPictureBox2 = null;
            this.comboRecvDataType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(20)))), ((int)(((byte)(91)))));
            this.comboRecvDataType.BorderStyle = SmartX.SmartComboBox.BORDERSTYLES.FixedSingle1;
            this.comboRecvDataType.DropDownButtonDownImage = null;
            this.comboRecvDataType.DropDownButtonLocation = new System.Drawing.Point(74, 1);
            this.comboRecvDataType.DropDownButtonSize = new System.Drawing.Size(32, 25);
            this.comboRecvDataType.DropDownButtonText = "▼";
            this.comboRecvDataType.DropDownButtonUpImage = null;
            this.comboRecvDataType.DropDownHeight = 70;
            this.comboRecvDataType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.comboRecvDataType.ForeColor = System.Drawing.Color.Black;
            this.comboRecvDataType.InitVisible = true;
            this.comboRecvDataType.ItemListBackImage = null;
            this.comboRecvDataType.ItemListBackPictureBoxApply = true;
            this.comboRecvDataType.ItemListFontColor = System.Drawing.Color.Black;
            this.comboRecvDataType.ItemListItemOffsetGap = 20;
            this.comboRecvDataType.ItemListItemOffsetX = 3;
            this.comboRecvDataType.ItemListItemOffsetY = 0;
            this.comboRecvDataType.ItemListLocation = new System.Drawing.Point(2, 27);
            this.comboRecvDataType.ItemListSelectColor = System.Drawing.Color.PaleVioletRed;
            this.comboRecvDataType.ItemListSelectFilled = true;
            this.comboRecvDataType.ItemListSelectFontColor = System.Drawing.Color.White;
            this.comboRecvDataType.ItemListSelectItemIndex = -1;
            this.comboRecvDataType.ItemListSeparationlineColor1 = System.Drawing.Color.Gray;
            this.comboRecvDataType.ItemListSeparationlineColor2 = System.Drawing.Color.LightGray;
            this.comboRecvDataType.ItemListSeparationLineStyle = SmartX.SmartListBox.SEPARATIONLINETYPES.FixedSingle;
            this.comboRecvDataType.ItemListSeparationlineVisibleBottom = true;
            this.comboRecvDataType.ItemListSeparationlineVisibleTop = true;
            this.comboRecvDataType.ItemListSize = new System.Drawing.Size(74, 68);
            this.comboRecvDataType.ItemListviewDesigntime = false;
            this.comboRecvDataType.Location = new System.Drawing.Point(378, 135);
            this.comboRecvDataType.Name = "comboRecvDataType";
            this.comboRecvDataType.ScrollDownButtonDownImage = null;
            this.comboRecvDataType.ScrollDownButtonLocation = new System.Drawing.Point(74, 62);
            this.comboRecvDataType.ScrollDownButtonSize = new System.Drawing.Size(32, 34);
            this.comboRecvDataType.ScrollDownButtonText = "▼";
            this.comboRecvDataType.ScrollDownButtonUpImage = null;
            this.comboRecvDataType.ScrollUpButtonDownImage = null;
            this.comboRecvDataType.ScrollUpButtonLocation = new System.Drawing.Point(74, 29);
            this.comboRecvDataType.ScrollUpButtonSize = new System.Drawing.Size(32, 33);
            this.comboRecvDataType.ScrollUpButtonText = "▲";
            this.comboRecvDataType.ScrollUpButtonUpImage = null;
            this.comboRecvDataType.Size = new System.Drawing.Size(108, 28);
            this.comboRecvDataType.TabIndex = 39;
            this.comboRecvDataType.TextLeftOffset = 3;
            this.comboRecvDataType.SelectedIndexChanged += new System.EventHandler(this.comboRecvDataType_SelectedIndexChanged);
            // 
            // comboSendDataType
            // 
            this.comboSendDataType.AutoResize = false;
            this.comboSendDataType.BackColor = System.Drawing.Color.White;
            this.comboSendDataType.BackPictureBox = null;
            this.comboSendDataType.BackPictureBox1 = null;
            this.comboSendDataType.BackPictureBox2 = null;
            this.comboSendDataType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(130)))), ((int)(((byte)(12)))));
            this.comboSendDataType.BorderStyle = SmartX.SmartComboBox.BORDERSTYLES.FixedSingle1;
            this.comboSendDataType.DropDownButtonDownImage = null;
            this.comboSendDataType.DropDownButtonLocation = new System.Drawing.Point(74, 1);
            this.comboSendDataType.DropDownButtonSize = new System.Drawing.Size(32, 25);
            this.comboSendDataType.DropDownButtonText = "▼";
            this.comboSendDataType.DropDownButtonUpImage = null;
            this.comboSendDataType.DropDownHeight = 70;
            this.comboSendDataType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.comboSendDataType.ForeColor = System.Drawing.Color.Black;
            this.comboSendDataType.InitVisible = true;
            this.comboSendDataType.ItemListBackImage = null;
            this.comboSendDataType.ItemListBackPictureBoxApply = true;
            this.comboSendDataType.ItemListFontColor = System.Drawing.Color.Black;
            this.comboSendDataType.ItemListItemOffsetGap = 20;
            this.comboSendDataType.ItemListItemOffsetX = 3;
            this.comboSendDataType.ItemListItemOffsetY = 0;
            this.comboSendDataType.ItemListLocation = new System.Drawing.Point(2, 27);
            this.comboSendDataType.ItemListSelectColor = System.Drawing.Color.Olive;
            this.comboSendDataType.ItemListSelectFilled = true;
            this.comboSendDataType.ItemListSelectFontColor = System.Drawing.Color.White;
            this.comboSendDataType.ItemListSelectItemIndex = -1;
            this.comboSendDataType.ItemListSeparationlineColor1 = System.Drawing.Color.Gray;
            this.comboSendDataType.ItemListSeparationlineColor2 = System.Drawing.Color.LightGray;
            this.comboSendDataType.ItemListSeparationLineStyle = SmartX.SmartListBox.SEPARATIONLINETYPES.FixedSingle;
            this.comboSendDataType.ItemListSeparationlineVisibleBottom = true;
            this.comboSendDataType.ItemListSeparationlineVisibleTop = true;
            this.comboSendDataType.ItemListSize = new System.Drawing.Size(74, 68);
            this.comboSendDataType.ItemListviewDesigntime = false;
            this.comboSendDataType.Location = new System.Drawing.Point(378, 11);
            this.comboSendDataType.Name = "comboSendDataType";
            this.comboSendDataType.ScrollDownButtonDownImage = null;
            this.comboSendDataType.ScrollDownButtonLocation = new System.Drawing.Point(74, 62);
            this.comboSendDataType.ScrollDownButtonSize = new System.Drawing.Size(32, 34);
            this.comboSendDataType.ScrollDownButtonText = "▼";
            this.comboSendDataType.ScrollDownButtonUpImage = null;
            this.comboSendDataType.ScrollUpButtonDownImage = null;
            this.comboSendDataType.ScrollUpButtonLocation = new System.Drawing.Point(74, 29);
            this.comboSendDataType.ScrollUpButtonSize = new System.Drawing.Size(32, 33);
            this.comboSendDataType.ScrollUpButtonText = "▲";
            this.comboSendDataType.ScrollUpButtonUpImage = null;
            this.comboSendDataType.Size = new System.Drawing.Size(108, 28);
            this.comboSendDataType.TabIndex = 40;
            this.comboSendDataType.TextLeftOffset = 3;
            this.comboSendDataType.SelectedIndexChanged += new System.EventHandler(this.comboSendDataType_SelectedIndexChanged);
            // 
            // comboFrameType
            // 
            this.comboFrameType.AutoResize = false;
            this.comboFrameType.BackColor = System.Drawing.Color.White;
            this.comboFrameType.BackPictureBox = null;
            this.comboFrameType.BackPictureBox1 = null;
            this.comboFrameType.BackPictureBox2 = null;
            this.comboFrameType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.comboFrameType.BorderStyle = SmartX.SmartComboBox.BORDERSTYLES.FixedSingle1;
            this.comboFrameType.DropDownButtonDownImage = null;
            this.comboFrameType.DropDownButtonLocation = new System.Drawing.Point(246, 1);
            this.comboFrameType.DropDownButtonSize = new System.Drawing.Size(32, 29);
            this.comboFrameType.DropDownButtonText = "▼";
            this.comboFrameType.DropDownButtonUpImage = null;
            this.comboFrameType.DropDownHeight = 125;
            this.comboFrameType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.comboFrameType.ForeColor = System.Drawing.Color.Black;
            this.comboFrameType.InitVisible = true;
            this.comboFrameType.ItemListBackImage = null;
            this.comboFrameType.ItemListBackPictureBoxApply = false;
            this.comboFrameType.ItemListFontColor = System.Drawing.Color.Black;
            this.comboFrameType.ItemListItemOffsetGap = 12;
            this.comboFrameType.ItemListItemOffsetX = 3;
            this.comboFrameType.ItemListItemOffsetY = 0;
            this.comboFrameType.ItemListLocation = new System.Drawing.Point(2, 31);
            this.comboFrameType.ItemListSelectColor = System.Drawing.Color.DeepSkyBlue;
            this.comboFrameType.ItemListSelectFilled = true;
            this.comboFrameType.ItemListSelectFontColor = System.Drawing.Color.White;
            this.comboFrameType.ItemListSelectItemIndex = -1;
            this.comboFrameType.ItemListSeparationlineColor1 = System.Drawing.Color.Gray;
            this.comboFrameType.ItemListSeparationlineColor2 = System.Drawing.Color.LightGray;
            this.comboFrameType.ItemListSeparationLineStyle = SmartX.SmartListBox.SEPARATIONLINETYPES.FixedSingle;
            this.comboFrameType.ItemListSeparationlineVisibleBottom = true;
            this.comboFrameType.ItemListSeparationlineVisibleTop = true;
            this.comboFrameType.ItemListSize = new System.Drawing.Size(246, 120);
            this.comboFrameType.ItemListviewDesigntime = false;
            this.comboFrameType.Location = new System.Drawing.Point(9, 285);
            this.comboFrameType.Name = "comboFrameType";
            this.comboFrameType.ScrollDownButtonDownImage = null;
            this.comboFrameType.ScrollDownButtonLocation = new System.Drawing.Point(246, 94);
            this.comboFrameType.ScrollDownButtonSize = new System.Drawing.Size(32, 60);
            this.comboFrameType.ScrollDownButtonText = "▼";
            this.comboFrameType.ScrollDownButtonUpImage = null;
            this.comboFrameType.ScrollUpButtonDownImage = null;
            this.comboFrameType.ScrollUpButtonLocation = new System.Drawing.Point(246, 33);
            this.comboFrameType.ScrollUpButtonSize = new System.Drawing.Size(32, 60);
            this.comboFrameType.ScrollUpButtonText = "▲";
            this.comboFrameType.ScrollUpButtonUpImage = null;
            this.comboFrameType.Size = new System.Drawing.Size(280, 32);
            this.comboFrameType.TabIndex = 34;
            this.comboFrameType.TextLeftOffset = 3;
            this.comboFrameType.SelectedIndexChanged += new System.EventHandler(this.comboFrameType_SelectedIndexChanged);
            // 
            // comboErrorLo
            // 
            this.comboErrorLo.AutoResize = false;
            this.comboErrorLo.BackColor = System.Drawing.Color.White;
            this.comboErrorLo.BackPictureBox = null;
            this.comboErrorLo.BackPictureBox1 = null;
            this.comboErrorLo.BackPictureBox2 = null;
            this.comboErrorLo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.comboErrorLo.BorderStyle = SmartX.SmartComboBox.BORDERSTYLES.FixedSingle1;
            this.comboErrorLo.DropDownButtonDownImage = null;
            this.comboErrorLo.DropDownButtonLocation = new System.Drawing.Point(109, 1);
            this.comboErrorLo.DropDownButtonSize = new System.Drawing.Size(32, 26);
            this.comboErrorLo.DropDownButtonText = "▼";
            this.comboErrorLo.DropDownButtonUpImage = null;
            this.comboErrorLo.DropDownHeight = 60;
            this.comboErrorLo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.comboErrorLo.ForeColor = System.Drawing.Color.Black;
            this.comboErrorLo.InitVisible = true;
            this.comboErrorLo.ItemListBackImage = null;
            this.comboErrorLo.ItemListBackPictureBoxApply = true;
            this.comboErrorLo.ItemListFontColor = System.Drawing.Color.Black;
            this.comboErrorLo.ItemListItemOffsetGap = 15;
            this.comboErrorLo.ItemListItemOffsetX = 3;
            this.comboErrorLo.ItemListItemOffsetY = 0;
            this.comboErrorLo.ItemListLocation = new System.Drawing.Point(2, 28);
            this.comboErrorLo.ItemListSelectColor = System.Drawing.Color.DeepSkyBlue;
            this.comboErrorLo.ItemListSelectFilled = true;
            this.comboErrorLo.ItemListSelectFontColor = System.Drawing.Color.White;
            this.comboErrorLo.ItemListSelectItemIndex = -1;
            this.comboErrorLo.ItemListSeparationlineColor1 = System.Drawing.Color.Gray;
            this.comboErrorLo.ItemListSeparationlineColor2 = System.Drawing.Color.LightGray;
            this.comboErrorLo.ItemListSeparationLineStyle = SmartX.SmartListBox.SEPARATIONLINETYPES.FixedSingle;
            this.comboErrorLo.ItemListSeparationlineVisibleBottom = true;
            this.comboErrorLo.ItemListSeparationlineVisibleTop = true;
            this.comboErrorLo.ItemListSize = new System.Drawing.Size(108, 56);
            this.comboErrorLo.ItemListviewDesigntime = false;
            this.comboErrorLo.Location = new System.Drawing.Point(146, 358);
            this.comboErrorLo.Name = "comboErrorLo";
            this.comboErrorLo.ScrollDownButtonDownImage = null;
            this.comboErrorLo.ScrollDownButtonLocation = new System.Drawing.Point(109, 59);
            this.comboErrorLo.ScrollDownButtonSize = new System.Drawing.Size(32, 27);
            this.comboErrorLo.ScrollDownButtonText = "▼";
            this.comboErrorLo.ScrollDownButtonUpImage = null;
            this.comboErrorLo.ScrollUpButtonDownImage = null;
            this.comboErrorLo.ScrollUpButtonLocation = new System.Drawing.Point(109, 30);
            this.comboErrorLo.ScrollUpButtonSize = new System.Drawing.Size(32, 27);
            this.comboErrorLo.ScrollUpButtonText = "▲";
            this.comboErrorLo.ScrollUpButtonUpImage = null;
            this.comboErrorLo.Size = new System.Drawing.Size(143, 29);
            this.comboErrorLo.TabIndex = 33;
            this.comboErrorLo.TextLeftOffset = 3;
            this.comboErrorLo.SelectedIndexChanged += new System.EventHandler(this.comboErrorLo_SelectedIndexChanged);
            // 
            // comboErrorMode
            // 
            this.comboErrorMode.AutoResize = false;
            this.comboErrorMode.BackColor = System.Drawing.Color.White;
            this.comboErrorMode.BackPictureBox = null;
            this.comboErrorMode.BackPictureBox1 = null;
            this.comboErrorMode.BackPictureBox2 = null;
            this.comboErrorMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.comboErrorMode.BorderStyle = SmartX.SmartComboBox.BORDERSTYLES.FixedSingle1;
            this.comboErrorMode.DropDownButtonDownImage = null;
            this.comboErrorMode.DropDownButtonLocation = new System.Drawing.Point(109, 1);
            this.comboErrorMode.DropDownButtonSize = new System.Drawing.Size(32, 26);
            this.comboErrorMode.DropDownButtonText = "▼";
            this.comboErrorMode.DropDownButtonUpImage = null;
            this.comboErrorMode.DropDownHeight = 118;
            this.comboErrorMode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.comboErrorMode.ForeColor = System.Drawing.Color.Black;
            this.comboErrorMode.InitVisible = true;
            this.comboErrorMode.ItemListBackImage = null;
            this.comboErrorMode.ItemListBackPictureBoxApply = false;
            this.comboErrorMode.ItemListFontColor = System.Drawing.Color.Black;
            this.comboErrorMode.ItemListItemOffsetGap = 10;
            this.comboErrorMode.ItemListItemOffsetX = 3;
            this.comboErrorMode.ItemListItemOffsetY = 0;
            this.comboErrorMode.ItemListLocation = new System.Drawing.Point(2, 28);
            this.comboErrorMode.ItemListSelectColor = System.Drawing.Color.DeepSkyBlue;
            this.comboErrorMode.ItemListSelectFilled = true;
            this.comboErrorMode.ItemListSelectFontColor = System.Drawing.Color.White;
            this.comboErrorMode.ItemListSelectItemIndex = -1;
            this.comboErrorMode.ItemListSeparationlineColor1 = System.Drawing.Color.Gray;
            this.comboErrorMode.ItemListSeparationlineColor2 = System.Drawing.Color.LightGray;
            this.comboErrorMode.ItemListSeparationLineStyle = SmartX.SmartListBox.SEPARATIONLINETYPES.FixedSingle;
            this.comboErrorMode.ItemListSeparationlineVisibleBottom = true;
            this.comboErrorMode.ItemListSeparationlineVisibleTop = true;
            this.comboErrorMode.ItemListSize = new System.Drawing.Size(109, 110);
            this.comboErrorMode.ItemListviewDesigntime = false;
            this.comboErrorMode.Location = new System.Drawing.Point(146, 324);
            this.comboErrorMode.Name = "comboErrorMode";
            this.comboErrorMode.ScrollDownButtonDownImage = null;
            this.comboErrorMode.ScrollDownButtonLocation = new System.Drawing.Point(109, 88);
            this.comboErrorMode.ScrollDownButtonSize = new System.Drawing.Size(32, 56);
            this.comboErrorMode.ScrollDownButtonText = "▼";
            this.comboErrorMode.ScrollDownButtonUpImage = null;
            this.comboErrorMode.ScrollUpButtonDownImage = null;
            this.comboErrorMode.ScrollUpButtonLocation = new System.Drawing.Point(109, 30);
            this.comboErrorMode.ScrollUpButtonSize = new System.Drawing.Size(32, 56);
            this.comboErrorMode.ScrollUpButtonText = "▲";
            this.comboErrorMode.ScrollUpButtonUpImage = null;
            this.comboErrorMode.Size = new System.Drawing.Size(143, 29);
            this.comboErrorMode.TabIndex = 36;
            this.comboErrorMode.TextLeftOffset = 3;
            this.comboErrorMode.SelectedIndexChanged += new System.EventHandler(this.comboErrorMode_SelectedIndexChanged);
            // 
            // comboDetect
            // 
            this.comboDetect.AutoResize = false;
            this.comboDetect.BackColor = System.Drawing.Color.White;
            this.comboDetect.BackPictureBox = null;
            this.comboDetect.BackPictureBox1 = null;
            this.comboDetect.BackPictureBox2 = null;
            this.comboDetect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.comboDetect.BorderStyle = SmartX.SmartComboBox.BORDERSTYLES.FixedSingle1;
            this.comboDetect.DropDownButtonDownImage = null;
            this.comboDetect.DropDownButtonLocation = new System.Drawing.Point(109, 1);
            this.comboDetect.DropDownButtonSize = new System.Drawing.Size(32, 26);
            this.comboDetect.DropDownButtonText = "▼";
            this.comboDetect.DropDownButtonUpImage = null;
            this.comboDetect.DropDownHeight = 48;
            this.comboDetect.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.comboDetect.ForeColor = System.Drawing.Color.Black;
            this.comboDetect.InitVisible = true;
            this.comboDetect.ItemListBackImage = null;
            this.comboDetect.ItemListBackPictureBoxApply = true;
            this.comboDetect.ItemListFontColor = System.Drawing.Color.Black;
            this.comboDetect.ItemListItemOffsetGap = 10;
            this.comboDetect.ItemListItemOffsetX = 3;
            this.comboDetect.ItemListItemOffsetY = 0;
            this.comboDetect.ItemListLocation = new System.Drawing.Point(2, 28);
            this.comboDetect.ItemListSelectColor = System.Drawing.Color.DeepSkyBlue;
            this.comboDetect.ItemListSelectFilled = true;
            this.comboDetect.ItemListSelectFontColor = System.Drawing.Color.White;
            this.comboDetect.ItemListSelectItemIndex = -1;
            this.comboDetect.ItemListSeparationlineColor1 = System.Drawing.Color.Gray;
            this.comboDetect.ItemListSeparationlineColor2 = System.Drawing.Color.LightGray;
            this.comboDetect.ItemListSeparationLineStyle = SmartX.SmartListBox.SEPARATIONLINETYPES.FixedSingle;
            this.comboDetect.ItemListSeparationlineVisibleBottom = true;
            this.comboDetect.ItemListSeparationlineVisibleTop = true;
            this.comboDetect.ItemListSize = new System.Drawing.Size(108, 45);
            this.comboDetect.ItemListviewDesigntime = false;
            this.comboDetect.Location = new System.Drawing.Point(146, 391);
            this.comboDetect.Name = "comboDetect";
            this.comboDetect.ScrollDownButtonDownImage = null;
            this.comboDetect.ScrollDownButtonLocation = new System.Drawing.Point(109, 53);
            this.comboDetect.ScrollDownButtonSize = new System.Drawing.Size(32, 21);
            this.comboDetect.ScrollDownButtonText = "▼";
            this.comboDetect.ScrollDownButtonUpImage = null;
            this.comboDetect.ScrollUpButtonDownImage = null;
            this.comboDetect.ScrollUpButtonLocation = new System.Drawing.Point(109, 30);
            this.comboDetect.ScrollUpButtonSize = new System.Drawing.Size(32, 21);
            this.comboDetect.ScrollUpButtonText = "▲";
            this.comboDetect.ScrollUpButtonUpImage = null;
            this.comboDetect.Size = new System.Drawing.Size(143, 29);
            this.comboDetect.TabIndex = 35;
            this.comboDetect.TextLeftOffset = 3;
            this.comboDetect.SelectedIndexChanged += new System.EventHandler(this.comboDetect_SelectedIndexChanged);
            // 
            // labelETX
            // 
            this.labelETX.BackColor = System.Drawing.Color.White;
            this.labelETX.BackPictureBox = null;
            this.labelETX.BackPictureBox1 = null;
            this.labelETX.BackPictureBox2 = null;
            this.labelETX.BorderColor = System.Drawing.Color.Black;
            this.labelETX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelETX.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelETX.ForeColor = System.Drawing.Color.Black;
            this.labelETX.InitVisible = true;
            this.labelETX.LineSpacing = 0F;
            this.labelETX.Location = new System.Drawing.Point(247, 255);
            this.labelETX.Name = "labelETX";
            this.labelETX.Size = new System.Drawing.Size(35, 25);
            this.labelETX.TabIndex = 18;
            this.labelETX.Text = "03";
            this.labelETX.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.labelETX.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.labelETX.Wordwrap = false;
            this.labelETX.Click += new System.EventHandler(this.label_Click);
            // 
            // labelSTX
            // 
            this.labelSTX.BackColor = System.Drawing.Color.White;
            this.labelSTX.BackPictureBox = null;
            this.labelSTX.BackPictureBox1 = null;
            this.labelSTX.BackPictureBox2 = null;
            this.labelSTX.BorderColor = System.Drawing.Color.Black;
            this.labelSTX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelSTX.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelSTX.ForeColor = System.Drawing.Color.Black;
            this.labelSTX.InitVisible = true;
            this.labelSTX.LineSpacing = 0F;
            this.labelSTX.Location = new System.Drawing.Point(206, 255);
            this.labelSTX.Name = "labelSTX";
            this.labelSTX.Size = new System.Drawing.Size(35, 25);
            this.labelSTX.TabIndex = 17;
            this.labelSTX.Text = "02";
            this.labelSTX.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.labelSTX.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.labelSTX.Wordwrap = false;
            this.labelSTX.Click += new System.EventHandler(this.label_Click);
            // 
            // labelPortStatus
            // 
            this.labelPortStatus.BackColor = System.Drawing.Color.White;
            this.labelPortStatus.BackPictureBox = this.smartForm1;
            this.labelPortStatus.BackPictureBox1 = null;
            this.labelPortStatus.BackPictureBox2 = null;
            this.labelPortStatus.BorderColor = System.Drawing.Color.Black;
            this.labelPortStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelPortStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelPortStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPortStatus.InitVisible = true;
            this.labelPortStatus.LineSpacing = 0F;
            this.labelPortStatus.Location = new System.Drawing.Point(10, 56);
            this.labelPortStatus.Name = "labelPortStatus";
            this.labelPortStatus.Size = new System.Drawing.Size(117, 59);
            this.labelPortStatus.TabIndex = 19;
            this.labelPortStatus.Text = "PortStatus";
            this.labelPortStatus.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.labelPortStatus.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.labelPortStatus.Wordwrap = false;
            // 
            // labelSendData
            // 
            this.labelSendData.BackColor = System.Drawing.Color.White;
            this.labelSendData.BackPictureBox = this.smartForm1;
            this.labelSendData.BackPictureBox1 = null;
            this.labelSendData.BackPictureBox2 = null;
            this.labelSendData.BorderColor = System.Drawing.Color.Black;
            this.labelSendData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelSendData.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.labelSendData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSendData.InitVisible = true;
            this.labelSendData.LineSpacing = 0F;
            this.labelSendData.Location = new System.Drawing.Point(301, 90);
            this.labelSendData.Name = "labelSendData";
            this.labelSendData.Size = new System.Drawing.Size(395, 25);
            this.labelSendData.TabIndex = 15;
            this.labelSendData.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.labelSendData.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.labelSendData.Wordwrap = false;
            this.labelSendData.Click += new System.EventHandler(this.label_Click);
            // 
            // labelRecvInterval
            // 
            this.labelRecvInterval.BackColor = System.Drawing.Color.White;
            this.labelRecvInterval.BackPictureBox = null;
            this.labelRecvInterval.BackPictureBox1 = null;
            this.labelRecvInterval.BackPictureBox2 = null;
            this.labelRecvInterval.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.labelRecvInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRecvInterval.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelRecvInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRecvInterval.InitVisible = true;
            this.labelRecvInterval.LineSpacing = 0F;
            this.labelRecvInterval.Location = new System.Drawing.Point(616, 135);
            this.labelRecvInterval.Name = "labelRecvInterval";
            this.labelRecvInterval.Size = new System.Drawing.Size(80, 27);
            this.labelRecvInterval.TabIndex = 14;
            this.labelRecvInterval.Text = "500";
            this.labelRecvInterval.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.labelRecvInterval.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.labelRecvInterval.Visible = false;
            this.labelRecvInterval.Wordwrap = false;
            this.labelRecvInterval.Click += new System.EventHandler(this.label_Click);
            // 
            // labelSendInterval
            // 
            this.labelSendInterval.BackColor = System.Drawing.Color.White;
            this.labelSendInterval.BackPictureBox = null;
            this.labelSendInterval.BackPictureBox1 = null;
            this.labelSendInterval.BackPictureBox2 = null;
            this.labelSendInterval.BorderColor = System.Drawing.Color.Black;
            this.labelSendInterval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelSendInterval.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelSendInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSendInterval.InitVisible = true;
            this.labelSendInterval.LineSpacing = 0F;
            this.labelSendInterval.Location = new System.Drawing.Point(616, 12);
            this.labelSendInterval.Name = "labelSendInterval";
            this.labelSendInterval.Size = new System.Drawing.Size(80, 25);
            this.labelSendInterval.TabIndex = 29;
            this.labelSendInterval.Text = "500";
            this.labelSendInterval.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.labelSendInterval.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.labelSendInterval.Wordwrap = false;
            this.labelSendInterval.Click += new System.EventHandler(this.label_Click);
            // 
            // smartLabel21
            // 
            this.smartLabel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(20)))), ((int)(((byte)(91)))));
            this.smartLabel21.BackPictureBox = null;
            this.smartLabel21.BackPictureBox1 = null;
            this.smartLabel21.BackPictureBox2 = null;
            this.smartLabel21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(20)))), ((int)(((byte)(91)))));
            this.smartLabel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartLabel21.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.ForeColor = System.Drawing.Color.White;
            this.smartLabel21.InitVisible = true;
            this.smartLabel21.LineSpacing = 0F;
            this.smartLabel21.Location = new System.Drawing.Point(495, 135);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(116, 27);
            this.smartLabel21.TabIndex = 30;
            this.smartLabel21.Text = "Recv Interval";
            this.smartLabel21.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.smartLabel21.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.smartLabel21.Visible = false;
            this.smartLabel21.Wordwrap = false;
            // 
            // smartLabel15
            // 
            this.smartLabel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(130)))), ((int)(((byte)(12)))));
            this.smartLabel15.BackPictureBox = null;
            this.smartLabel15.BackPictureBox1 = null;
            this.smartLabel15.BackPictureBox2 = null;
            this.smartLabel15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(130)))), ((int)(((byte)(12)))));
            this.smartLabel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartLabel15.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.smartLabel15.ForeColor = System.Drawing.Color.White;
            this.smartLabel15.InitVisible = true;
            this.smartLabel15.LineSpacing = 0F;
            this.smartLabel15.Location = new System.Drawing.Point(495, 11);
            this.smartLabel15.Name = "smartLabel15";
            this.smartLabel15.Size = new System.Drawing.Size(116, 27);
            this.smartLabel15.TabIndex = 32;
            this.smartLabel15.Text = "Send Interval";
            this.smartLabel15.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.smartLabel15.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.smartLabel15.Wordwrap = false;
            // 
            // smartTimer1
            // 
            this.smartTimer1.EndTime = ((long)(100000000000));
            this.smartTimer1.Interval = 150;
            this.smartTimer1.IntervalSeries = null;
            this.smartTimer1.NowMillisecond = ((long)(0));
            this.smartTimer1.StartTime = ((long)(0));
            this.smartTimer1.Tick += new System.EventHandler(this.smartTimer1_Tick);
            // 
            // smartTimer2
            // 
            this.smartTimer2.EndTime = ((long)(100000000000));
            this.smartTimer2.Interval = 150;
            this.smartTimer2.IntervalSeries = null;
            this.smartTimer2.NowMillisecond = ((long)(0));
            this.smartTimer2.StartTime = ((long)(0));
            this.smartTimer2.Tick += new System.EventHandler(this.smartTimer2_Tick);
            // 
            // labelRTO
            // 
            this.labelRTO.BackColor = System.Drawing.Color.White;
            this.labelRTO.BackPictureBox = this.smartForm1;
            this.labelRTO.BackPictureBox1 = null;
            this.labelRTO.BackPictureBox2 = null;
            this.labelRTO.BorderColor = System.Drawing.Color.Black;
            this.labelRTO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelRTO.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelRTO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRTO.InitVisible = true;
            this.labelRTO.LineSpacing = 0F;
            this.labelRTO.Location = new System.Drawing.Point(11, 221);
            this.labelRTO.Name = "labelRTO";
            this.labelRTO.Size = new System.Drawing.Size(133, 25);
            this.labelRTO.TabIndex = 15;
            this.labelRTO.Text = "50";
            this.labelRTO.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.labelRTO.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.labelRTO.Wordwrap = false;
            this.labelRTO.Click += new System.EventHandler(this.label_Click);
            // 
            // labelBuffer
            // 
            this.labelBuffer.BackColor = System.Drawing.Color.White;
            this.labelBuffer.BackPictureBox = this.smartForm1;
            this.labelBuffer.BackPictureBox1 = null;
            this.labelBuffer.BackPictureBox2 = null;
            this.labelBuffer.BorderColor = System.Drawing.Color.Black;
            this.labelBuffer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelBuffer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelBuffer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBuffer.InitVisible = true;
            this.labelBuffer.LineSpacing = 0F;
            this.labelBuffer.Location = new System.Drawing.Point(154, 221);
            this.labelBuffer.Name = "labelBuffer";
            this.labelBuffer.Size = new System.Drawing.Size(133, 25);
            this.labelBuffer.TabIndex = 15;
            this.labelBuffer.Text = "40000";
            this.labelBuffer.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.labelBuffer.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.labelBuffer.Wordwrap = false;
            this.labelBuffer.Click += new System.EventHandler(this.label_Click);
            // 
            // labelSepCode
            // 
            this.labelSepCode.BackColor = System.Drawing.Color.White;
            this.labelSepCode.BackPictureBox = this.smartForm1;
            this.labelSepCode.BackPictureBox1 = null;
            this.labelSepCode.BackPictureBox2 = null;
            this.labelSepCode.BorderColor = System.Drawing.Color.Black;
            this.labelSepCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelSepCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelSepCode.ForeColor = System.Drawing.Color.White;
            this.labelSepCode.InitVisible = true;
            this.labelSepCode.LineSpacing = 0F;
            this.labelSepCode.Location = new System.Drawing.Point(114, 255);
            this.labelSepCode.Name = "labelSepCode";
            this.labelSepCode.Size = new System.Drawing.Size(84, 25);
            this.labelSepCode.TabIndex = 31;
            this.labelSepCode.Text = "STX/ETX";
            this.labelSepCode.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.labelSepCode.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.labelSepCode.Wordwrap = false;
            // 
            // smartSeparatorLine1
            // 
            this.smartSeparatorLine1.InitVisible = true;
            this.smartSeparatorLine1.Line1Color = System.Drawing.Color.LightSteelBlue;
            this.smartSeparatorLine1.Line1Width = 1F;
            this.smartSeparatorLine1.Line2Color = System.Drawing.Color.LightGray;
            this.smartSeparatorLine1.Line2Visible = true;
            this.smartSeparatorLine1.Line2Width = 1F;
            this.smartSeparatorLine1.LineDirection = SmartX.SmartSeparatorLine.DIR.Vertical;
            this.smartSeparatorLine1.Location = new System.Drawing.Point(105, 258);
            this.smartSeparatorLine1.Name = "smartSeparatorLine1";
            this.smartSeparatorLine1.Size = new System.Drawing.Size(2, 19);
            this.smartSeparatorLine1.TabIndex = 64;
            this.smartSeparatorLine1.Text = "smartSeparatorLine1";
            // 
            // smartSerialPort1
            // 
            this.smartSerialPort1.Baud_Rate = SmartX.SmartSerialPort.BAUDRATE._9600bps;
            this.smartSerialPort1.ErrorCheckCodeType = SmartX.SmartSerialPort.ERRORCHECKCODETYPES.ASCIICODE;
            this.smartSerialPort1.ErrorCheckMode = SmartX.SmartSerialPort.ERRORCHECK.NONE;
            this.smartSerialPort1.ErrorCode_Location = SmartX.SmartSerialPort.ERRORCODELOCATION.HEADER;
            this.smartSerialPort1.ETXCode = ((byte)(3));
            this.smartSerialPort1.ETXCodes = null;
            this.smartSerialPort1.FrameBufferSize = ((uint)(1024u));
            this.smartSerialPort1.FrameSeparationType = SmartX.SmartSerialPort.FRAMESEPARATIONTYPES.STXANDETX;
            this.smartSerialPort1.HeadErrorCodeOffset = 0;
            this.smartSerialPort1.PortNo = SmartX.SmartSerialPort.COMPORTNO.COM1;
            this.smartSerialPort1.ReadTimeout = -1;
            this.smartSerialPort1.ReceiveDetect = SmartX.SmartSerialPort.RECEIVEDETECTTYPE.EVENT_QUEUE;
            this.smartSerialPort1.ReceiveFrameDebugMode = false;
            this.smartSerialPort1.RS485SoftwareDetection = false;
            this.smartSerialPort1.STXCode = ((byte)(2));
            this.smartSerialPort1.STXCodes = null;
            this.smartSerialPort1.TailErrorCodeOffset = 0;
            this.smartSerialPort1.OnReadQueueEvent += new SmartX.SmartSerialPort.ReceiveDataHandler(this.smartSerialPort1_OnReadQueueEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.comboPortNo);
            this.Controls.Add(this.comboBaud);
            this.Controls.Add(this.comboErrorMode);
            this.Controls.Add(this.comboErrorLo);
            this.Controls.Add(this.comboDetect);
            this.Controls.Add(this.comboRecvDataType);
            this.Controls.Add(this.comboSendDataType);
            this.Controls.Add(this.comboFrameType);
            this.Controls.Add(this.smartSeparatorLine1);
            this.Controls.Add(this.smartKeyPad1);
            this.Controls.Add(this.listRecvData);
            this.Controls.Add(this.smartSeparatorLine2);
            this.Controls.Add(this.radioRecv3);
            this.Controls.Add(this.radioSend3);
            this.Controls.Add(this.radioRecv2);
            this.Controls.Add(this.radioRecv1);
            this.Controls.Add(this.radioSend2);
            this.Controls.Add(this.radioSend1);
            this.Controls.Add(this.checkRecvRept);
            this.Controls.Add(this.checkSendRept);
            this.Controls.Add(this.checkDebugMode);
            this.Controls.Add(this.buttonDOWN);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonUP);
            this.Controls.Add(this.buttonRECV);
            this.Controls.Add(this.buttonSEND);
            this.Controls.Add(this.buttonOPEN);
            this.Controls.Add(this.buttonCLOSE);
            this.Controls.Add(this.labelETX);
            this.Controls.Add(this.labelSTX);
            this.Controls.Add(this.labelPortStatus);
            this.Controls.Add(this.labelBuffer);
            this.Controls.Add(this.labelRTO);
            this.Controls.Add(this.labelSendData);
            this.Controls.Add(this.labelRecvInterval);
            this.Controls.Add(this.labelSendInterval);
            this.Controls.Add(this.smartLabel21);
            this.Controls.Add(this.smartLabel15);
            this.Controls.Add(this.labelSepCode);
            this.Controls.Add(this.smartForm1);
            this.Name = "Form1";
            this.Text = "IEC-266";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.smartForm1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartX.SmartForm smartForm1;
        private SmartX.SmartKeyPad smartKeyPad1;
        private SmartX.SmartComboBox comboBaud;
        private SmartX.SmartComboBox comboPortNo;
        private SmartX.SmartListBox listRecvData;
        private SmartX.SmartSeparatorLine smartSeparatorLine2;
        private SmartX.SmartRadioButton radioRecv3;
        private SmartX.SmartRadioButton radioSend3;
        private SmartX.SmartRadioButton radioRecv2;
        private SmartX.SmartRadioButton radioRecv1;
        private SmartX.SmartRadioButton radioSend2;
        private SmartX.SmartRadioButton radioSend1;
        private SmartX.SmartCheckBox checkRecvRept;
        private SmartX.SmartCheckBox checkSendRept;
        private SmartX.SmartCheckBox checkDebugMode;
        private SmartX.SmartButton buttonDOWN;
        private SmartX.SmartButton buttonClear;
        private SmartX.SmartButton buttonUP;
        private SmartX.SmartButton buttonRECV;
        private SmartX.SmartButton buttonSEND;
        private SmartX.SmartButton buttonOPEN;
        private SmartX.SmartButton buttonCLOSE;
        private SmartX.SmartComboBox comboRecvDataType;
        private SmartX.SmartComboBox comboSendDataType;
        private SmartX.SmartComboBox comboFrameType;
        private SmartX.SmartComboBox comboErrorLo;
        private SmartX.SmartComboBox comboErrorMode;
        private SmartX.SmartComboBox comboDetect;
        private SmartX.SmartLabel labelETX;
        private SmartX.SmartLabel labelSTX;
        private SmartX.SmartLabel labelPortStatus;
        private SmartX.SmartLabel labelSendData;
        private SmartX.SmartLabel labelRecvInterval;
        private SmartX.SmartLabel labelSendInterval;
        private SmartX.SmartLabel smartLabel21;
        private SmartX.SmartLabel smartLabel15;
        private SmartX.SmartTimer smartTimer1;
        private SmartX.SmartTimer smartTimer2;
        private SmartX.SmartLabel labelRTO;
        private SmartX.SmartLabel labelBuffer;
        private SmartX.SmartLabel labelSepCode;
        private SmartX.SmartSeparatorLine smartSeparatorLine1;
        private SmartX.SmartSerialPort smartSerialPort1;
    }
}

