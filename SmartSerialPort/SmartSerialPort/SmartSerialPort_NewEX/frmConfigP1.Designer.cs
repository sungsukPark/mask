namespace SmartSerialPort_NewEX
{
    partial class frmConfigP1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn100PerMin = new System.Windows.Forms.Button();
            this.btn350PerMin = new System.Windows.Forms.Button();
            this.btn300PerMin = new System.Windows.Forms.Button();
            this.btn250PerMin = new System.Windows.Forms.Button();
            this.btn200PerMin = new System.Windows.Forms.Button();
            this.btn150PerMin = new System.Windows.Forms.Button();
            this.btn10Plus = new System.Windows.Forms.Button();
            this.btn10Minus = new System.Windows.Forms.Button();
            this.btn50Minus = new System.Windows.Forms.Button();
            this.btn50Plus = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountPerMin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(3, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(244, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "취소";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(248, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(235, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "확인";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn100PerMin
            // 
            this.btn100PerMin.BackColor = System.Drawing.Color.White;
            this.btn100PerMin.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn100PerMin.Location = new System.Drawing.Point(360, 3);
            this.btn100PerMin.Name = "btn100PerMin";
            this.btn100PerMin.Size = new System.Drawing.Size(123, 40);
            this.btn100PerMin.TabIndex = 2;
            this.btn100PerMin.Text = "100 ea/min";
            // 
            // btn350PerMin
            // 
            this.btn350PerMin.BackColor = System.Drawing.Color.White;
            this.btn350PerMin.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn350PerMin.Location = new System.Drawing.Point(360, 208);
            this.btn350PerMin.Name = "btn350PerMin";
            this.btn350PerMin.Size = new System.Drawing.Size(123, 40);
            this.btn350PerMin.TabIndex = 3;
            this.btn350PerMin.Text = "350 ea/min";
            // 
            // btn300PerMin
            // 
            this.btn300PerMin.BackColor = System.Drawing.Color.White;
            this.btn300PerMin.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn300PerMin.Location = new System.Drawing.Point(360, 167);
            this.btn300PerMin.Name = "btn300PerMin";
            this.btn300PerMin.Size = new System.Drawing.Size(123, 40);
            this.btn300PerMin.TabIndex = 4;
            this.btn300PerMin.Text = "300 ea/min";
            // 
            // btn250PerMin
            // 
            this.btn250PerMin.BackColor = System.Drawing.Color.White;
            this.btn250PerMin.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn250PerMin.Location = new System.Drawing.Point(360, 126);
            this.btn250PerMin.Name = "btn250PerMin";
            this.btn250PerMin.Size = new System.Drawing.Size(123, 40);
            this.btn250PerMin.TabIndex = 5;
            this.btn250PerMin.Text = "250 ea/min";
            // 
            // btn200PerMin
            // 
            this.btn200PerMin.BackColor = System.Drawing.Color.White;
            this.btn200PerMin.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn200PerMin.Location = new System.Drawing.Point(360, 85);
            this.btn200PerMin.Name = "btn200PerMin";
            this.btn200PerMin.Size = new System.Drawing.Size(123, 40);
            this.btn200PerMin.TabIndex = 6;
            this.btn200PerMin.Text = "200 ea/min";
            // 
            // btn150PerMin
            // 
            this.btn150PerMin.BackColor = System.Drawing.Color.White;
            this.btn150PerMin.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn150PerMin.Location = new System.Drawing.Point(360, 44);
            this.btn150PerMin.Name = "btn150PerMin";
            this.btn150PerMin.Size = new System.Drawing.Size(123, 40);
            this.btn150PerMin.TabIndex = 7;
            this.btn150PerMin.Text = "150 ea/min";
            // 
            // btn10Plus
            // 
            this.btn10Plus.BackColor = System.Drawing.Color.White;
            this.btn10Plus.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn10Plus.Location = new System.Drawing.Point(248, 85);
            this.btn10Plus.Name = "btn10Plus";
            this.btn10Plus.Size = new System.Drawing.Size(67, 40);
            this.btn10Plus.TabIndex = 11;
            this.btn10Plus.Text = "10 ↑";
            this.btn10Plus.Click += new System.EventHandler(this.btn10Plus_Click);
            // 
            // btn10Minus
            // 
            this.btn10Minus.BackColor = System.Drawing.Color.White;
            this.btn10Minus.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn10Minus.Location = new System.Drawing.Point(248, 131);
            this.btn10Minus.Name = "btn10Minus";
            this.btn10Minus.Size = new System.Drawing.Size(67, 40);
            this.btn10Minus.TabIndex = 10;
            this.btn10Minus.Text = "10 ↓";
            this.btn10Minus.Click += new System.EventHandler(this.btn10Minus_Click);
            // 
            // btn50Minus
            // 
            this.btn50Minus.BackColor = System.Drawing.Color.White;
            this.btn50Minus.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn50Minus.Location = new System.Drawing.Point(248, 177);
            this.btn50Minus.Name = "btn50Minus";
            this.btn50Minus.Size = new System.Drawing.Size(67, 40);
            this.btn50Minus.TabIndex = 9;
            this.btn50Minus.Text = "50 ↓";
            this.btn50Minus.Click += new System.EventHandler(this.btn50Minus_Click);
            // 
            // btn50Plus
            // 
            this.btn50Plus.BackColor = System.Drawing.Color.White;
            this.btn50Plus.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn50Plus.Location = new System.Drawing.Point(248, 39);
            this.btn50Plus.Name = "btn50Plus";
            this.btn50Plus.Size = new System.Drawing.Size(67, 40);
            this.btn50Plus.TabIndex = 8;
            this.btn50Plus.Text = "50 ↑";
            this.btn50Plus.Click += new System.EventHandler(this.btn50Plus_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblCountPerMin);
            this.panel2.Location = new System.Drawing.Point(21, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 171);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(133, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.Text = "ea/min";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCountPerMin
            // 
            this.lblCountPerMin.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular);
            this.lblCountPerMin.Location = new System.Drawing.Point(6, 48);
            this.lblCountPerMin.Name = "lblCountPerMin";
            this.lblCountPerMin.Size = new System.Drawing.Size(160, 53);
            this.lblCountPerMin.Text = "0";
            this.lblCountPerMin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(21, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.Text = "[설정 속도]";
            // 
            // frmConfigP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 291);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn10Plus);
            this.Controls.Add(this.btn10Minus);
            this.Controls.Add(this.btn50Minus);
            this.Controls.Add(this.btn50Plus);
            this.Controls.Add(this.btn150PerMin);
            this.Controls.Add(this.btn200PerMin);
            this.Controls.Add(this.btn250PerMin);
            this.Controls.Add(this.btn300PerMin);
            this.Controls.Add(this.btn350PerMin);
            this.Controls.Add(this.btn100PerMin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "frmConfigP1";
            this.Text = "설정변경(P1)";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btn100PerMin;
        private System.Windows.Forms.Button btn350PerMin;
        private System.Windows.Forms.Button btn300PerMin;
        private System.Windows.Forms.Button btn250PerMin;
        private System.Windows.Forms.Button btn200PerMin;
        private System.Windows.Forms.Button btn150PerMin;
        private System.Windows.Forms.Button btn10Plus;
        private System.Windows.Forms.Button btn10Minus;
        private System.Windows.Forms.Button btn50Minus;
        private System.Windows.Forms.Button btn50Plus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountPerMin;
    }
}