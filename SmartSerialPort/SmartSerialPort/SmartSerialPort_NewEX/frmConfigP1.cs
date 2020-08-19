using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartSerialPort_NewEX
{
    public partial class frmConfigP1 : Form
    {
        private int _cntPerMin = 0;
        private int _cntPerMinOrigin = 0;
        public int _cntPerMinSaved = 0;
        public frmConfigP1(int countPerMin)
        {
            InitializeComponent();

            _cntPerMin = countPerMin;
            _cntPerMinOrigin = countPerMin;

            lblCountPerMin.Text = _cntPerMin.ToString();
        }

        private void btn50Plus_Click(object sender, EventArgs e)
        {
            _cntPerMin = _cntPerMin + 50;
            lblCountPerMin.Text = _cntPerMin.ToString();
        }

        private void btn10Plus_Click(object sender, EventArgs e)
        {
            _cntPerMin = _cntPerMin + 10;
            lblCountPerMin.Text = _cntPerMin.ToString();
        }

        private void btn10Minus_Click(object sender, EventArgs e)
        {
            _cntPerMin = _cntPerMin - 10;
            if (_cntPerMin < 0)
                _cntPerMin = 0;
            lblCountPerMin.Text = _cntPerMin.ToString();
        }

        private void btn50Minus_Click(object sender, EventArgs e)
        {
            _cntPerMin = _cntPerMin - 50;
            if (_cntPerMin < 0)
                _cntPerMin = 0;
            lblCountPerMin.Text = _cntPerMin.ToString();
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

        private void btn100PerMin_Click(object sender, EventArgs e)
        {
            lblCountPerMin.Text = 100.ToString();
            _cntPerMin = 100;
        }

        private void btn150PerMin_Click(object sender, EventArgs e)
        {
            lblCountPerMin.Text = 150.ToString();
            _cntPerMin = 150;
        }

        private void btn200PerMin_Click(object sender, EventArgs e)
        {
            lblCountPerMin.Text = 200.ToString();
            _cntPerMin = 200;
        }

        private void btn250PerMin_Click(object sender, EventArgs e)
        {
            lblCountPerMin.Text = 250.ToString();
            _cntPerMin = 250;
        }

        private void btn300PerMin_Click(object sender, EventArgs e)
        {
            lblCountPerMin.Text = 300.ToString();
            _cntPerMin = 300;
        }

        private void btn350PerMin_Click(object sender, EventArgs e)
        {
            lblCountPerMin.Text = 350.ToString();
            _cntPerMin = 350;
        }

    }
}