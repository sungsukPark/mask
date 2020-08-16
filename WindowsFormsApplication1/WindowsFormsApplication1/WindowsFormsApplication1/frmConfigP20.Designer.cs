namespace SmartSerialPort_NewEX
{
    partial class frmConfigP20
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn50PerMin = new System.Windows.Forms.Button();
            this.btn100PerMin = new System.Windows.Forms.Button();
            this.btn90PerMin = new System.Windows.Forms.Button();
            this.btn80PerMin = new System.Windows.Forms.Button();
            this.btn70PerMin = new System.Windows.Forms.Button();
            this.btn60PerMin = new System.Windows.Forms.Button();
            this.btn1Plus = new System.Windows.Forms.Button();
            this.btn1Minus = new System.Windows.Forms.Button();
            this.btn5Minus = new System.Windows.Forms.Button();
            this.btn5Plus = new System.Windows.Forms.Button();
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
            // btn50PerMin
            // 
            this.btn50PerMin.BackColor = System.Drawing.Color.White;
            this.btn50PerMin.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn50PerMin.Location = new System.Drawing.Point(360, 3);
            this.btn50PerMin.Name = "btn50PerMin";
            this.btn50PerMin.Size = new System.Drawing.Size(123, 40);
            this.btn50PerMin.TabIndex = 2;
            this.btn50PerMin.Text = "50 ea/min";
            this.btn50PerMin.Click += new System.EventHandler(this.btn50PerMin_Click);
            // 
            // btn100PerMin
            // 
            this.btn100PerMin.BackColor = System.Drawing.Color.White;
            this.btn100PerMin.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn100PerMin.Location = new System.Drawing.Point(360, 208);
            this.btn100PerMin.Name = "btn100PerMin";
            this.btn100PerMin.Size = new System.Drawing.Size(123, 40);
            this.btn100PerMin.TabIndex = 3;
            this.btn100PerMin.Text = "100 ea/min";
            this.btn100PerMin.Click += new System.EventHandler(this.btn100PerMin_Click);
            // 
            // btn90PerMin
            // 
            this.btn90PerMin.BackColor = System.Drawing.Color.White;
            this.btn90PerMin.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn90PerMin.Location = new System.Drawing.Point(360, 167);
            this.btn90PerMin.Name = "btn90PerMin";
            this.btn90PerMin.Size = new System.Drawing.Size(123, 40);
            this.btn90PerMin.TabIndex = 4;
            this.btn90PerMin.Text = "90 ea/min";
            this.btn90PerMin.Click += new System.EventHandler(this.btn90PerMin_Click);
            // 
            // btn80PerMin
            // 
            this.btn80PerMin.BackColor = System.Drawing.Color.White;
            this.btn80PerMin.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn80PerMin.Location = new System.Drawing.Point(360, 126);
            this.btn80PerMin.Name = "btn80PerMin";
            this.btn80PerMin.Size = new System.Drawing.Size(123, 40);
            this.btn80PerMin.TabIndex = 5;
            this.btn80PerMin.Text = "80 ea/min";
            this.btn80PerMin.Click += new System.EventHandler(this.btn80PerMin_Click);
            // 
            // btn70PerMin
            // 
            this.btn70PerMin.BackColor = System.Drawing.Color.White;
            this.btn70PerMin.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn70PerMin.Location = new System.Drawing.Point(360, 85);
            this.btn70PerMin.Name = "btn70PerMin";
            this.btn70PerMin.Size = new System.Drawing.Size(123, 40);
            this.btn70PerMin.TabIndex = 6;
            this.btn70PerMin.Text = "70 ea/min";
            this.btn70PerMin.Click += new System.EventHandler(this.btn70PerMin_Click);
            // 
            // btn60PerMin
            // 
            this.btn60PerMin.BackColor = System.Drawing.Color.White;
            this.btn60PerMin.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn60PerMin.Location = new System.Drawing.Point(360, 44);
            this.btn60PerMin.Name = "btn60PerMin";
            this.btn60PerMin.Size = new System.Drawing.Size(123, 40);
            this.btn60PerMin.TabIndex = 7;
            this.btn60PerMin.Text = "60 ea/min";
            this.btn60PerMin.Click += new System.EventHandler(this.btn60PerMin_Click);
            // 
            // btn1Plus
            // 
            this.btn1Plus.BackColor = System.Drawing.Color.White;
            this.btn1Plus.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn1Plus.Location = new System.Drawing.Point(248, 85);
            this.btn1Plus.Name = "btn1Plus";
            this.btn1Plus.Size = new System.Drawing.Size(67, 40);
            this.btn1Plus.TabIndex = 11;
            this.btn1Plus.Text = "1 ↑";
            this.btn1Plus.Click += new System.EventHandler(this.btn1Plus_Click);
            // 
            // btn1Minus
            // 
            this.btn1Minus.BackColor = System.Drawing.Color.White;
            this.btn1Minus.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn1Minus.Location = new System.Drawing.Point(248, 131);
            this.btn1Minus.Name = "btn1Minus";
            this.btn1Minus.Size = new System.Drawing.Size(67, 40);
            this.btn1Minus.TabIndex = 10;
            this.btn1Minus.Text = "1 ↓";
            this.btn1Minus.Click += new System.EventHandler(this.btn1Minus_Click);
            // 
            // btn5Minus
            // 
            this.btn5Minus.BackColor = System.Drawing.Color.White;
            this.btn5Minus.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn5Minus.Location = new System.Drawing.Point(248, 177);
            this.btn5Minus.Name = "btn5Minus";
            this.btn5Minus.Size = new System.Drawing.Size(67, 40);
            this.btn5Minus.TabIndex = 9;
            this.btn5Minus.Text = "5 ↓";
            this.btn5Minus.Click += new System.EventHandler(this.btn5Minus_Click);
            // 
            // btn5Plus
            // 
            this.btn5Plus.BackColor = System.Drawing.Color.White;
            this.btn5Plus.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn5Plus.Location = new System.Drawing.Point(248, 39);
            this.btn5Plus.Name = "btn5Plus";
            this.btn5Plus.Size = new System.Drawing.Size(67, 40);
            this.btn5Plus.TabIndex = 8;
            this.btn5Plus.Text = "5 ↑";
            this.btn5Plus.Click += new System.EventHandler(this.btn5Plus_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblCountPerMin);
            this.panel2.Location = new System.Drawing.Point(21, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 171);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(133, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "ea/min";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCountPerMin
            // 
            this.lblCountPerMin.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular);
            this.lblCountPerMin.Location = new System.Drawing.Point(3, 47);
            this.lblCountPerMin.Name = "lblCountPerMin";
            this.lblCountPerMin.Size = new System.Drawing.Size(163, 59);
            this.lblCountPerMin.TabIndex = 1;
            this.lblCountPerMin.Text = "0";
            this.lblCountPerMin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(21, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "[설정 속도]";
            // 
            // frmConfigP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 291);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn1Plus);
            this.Controls.Add(this.btn1Minus);
            this.Controls.Add(this.btn5Minus);
            this.Controls.Add(this.btn5Plus);
            this.Controls.Add(this.btn60PerMin);
            this.Controls.Add(this.btn70PerMin);
            this.Controls.Add(this.btn80PerMin);
            this.Controls.Add(this.btn90PerMin);
            this.Controls.Add(this.btn100PerMin);
            this.Controls.Add(this.btn50PerMin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "frmConfigP20";
            this.Text = "설정변경(P2)";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btn50PerMin;
        private System.Windows.Forms.Button btn100PerMin;
        private System.Windows.Forms.Button btn90PerMin;
        private System.Windows.Forms.Button btn80PerMin;
        private System.Windows.Forms.Button btn70PerMin;
        private System.Windows.Forms.Button btn60PerMin;
        private System.Windows.Forms.Button btn1Plus;
        private System.Windows.Forms.Button btn1Minus;
        private System.Windows.Forms.Button btn5Minus;
        private System.Windows.Forms.Button btn5Plus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountPerMin;
    }
}