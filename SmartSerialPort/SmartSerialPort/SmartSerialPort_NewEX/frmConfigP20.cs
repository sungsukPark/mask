using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartSerialPort_NewEX
{
    public partial class frmConfigP20 : Form
    {
        private int _cntPerMin = 0;
        private int _cntPerMinOrigin = 0;
        public int _cntPerMinSaved = 0;

        public frmConfigP20(int countPerMin)
        {
            InitializeComponent();

            _cntPerMin = countPerMin;
            _cntPerMinOrigin = countPerMin;

            lblCountPerMin.Text = _cntPerMin.ToString();
        }

        private void btn5Plus_Click(object sender, EventArgs e)
        {
            _cntPerMin = _cntPerMin + 5;
            lblCountPerMin.Text = _cntPerMin.ToString();
        }

        private void btn1Plus_Click(object sender, EventArgs e)
        {
            _cntPerMin = _cntPerMin + 1;
            lblCountPerMin.Text = _cntPerMin.ToString();
        }

        private void btn1Minus_Click(object sender, EventArgs e)
        {
            _cntPerMin = _cntPerMin - 1;
            if (_cntPerMin < 0)
                _cntPerMin = 0;
            lblCountPerMin.Text = _cntPerMin.ToString();
        }

        private void btn5Minus_Click(object sender, EventArgs e)
        {
            _cntPerMin = _cntPerMin - 5;
            if (_cntPerMin < 0)
                _cntPerMin = 0;
            lblCountPerMin.Text = _cntPerMin.ToString();
        }

        private void btn50PerMin_Click(object sender, EventArgs e)
        {
            lblCountPerMin.Text = 50.ToString();
            _cntPerMin = 50;
        }

        private void btn60PerMin_Click(object sender, EventArgs e)
        {
            lblCountPerMin.Text = 60.ToString();
            _cntPerMin = 60;
        }

        private void btn70PerMin_Click(object sender, EventArgs e)
        {
            lblCountPerMin.Text = 70.ToString();
            _cntPerMin = 70;
        }

        private void btn80PerMin_Click(object sender, EventArgs e)
        {
            lblCountPerMin.Text = 80.ToString();
            _cntPerMin = 80;
        }

        private void btn90PerMin_Click(object sender, EventArgs e)
        {
            lblCountPerMin.Text = 90.ToString();
            _cntPerMin = 90;
        }

        private void btn100PerMin_Click(object sender, EventArgs e)
        {
            lblCountPerMin.Text = 100.ToString();
            _cntPerMin = 100;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _cntPerMin = _cntPerMinOrigin;
            lblCountPerMin.Text = _cntPerMin.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _cntPerMinSaved = _cntPerMin;
            this.Close(); 
        }
    }
}