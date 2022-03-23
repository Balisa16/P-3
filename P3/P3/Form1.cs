using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace P3
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red100, Primary.Red200, Primary.Red300, Accent.LightBlue200, TextShade.WHITE);
            solidGauge1.To = 320;
            solidGauge1.From = 0;
            solidGauge1.ToColor = System.Windows.Media.Color.FromRgb(255, 0, 0);
            solidGauge1.FromColor = System.Windows.Media.Color.FromRgb(0, 255, 0);
            trackBar1.Value = 0;
            rem_bar.Value = 0;
            timer1.Enabled = false;
            simpan = 0;
            persenelan = 0;
            persenelan_fac = 0;
            tempuh = 0;

            Left_btn.Enabled = false;
            Right_btn.Enabled = false;
            back_btn.Enabled = false;
            trackBar1.Enabled = false;
            rem_bar.Enabled = false;
            persenelan_bar.Enabled = false;

            lampu_timer = 0;
            ganti = false;

            lb_left.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            lb_right.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            back_right.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            back_left.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;

            kep_back = false;
            kep_left = false;
            kep_right = false;
            warning = false;

            /*left_lbl.BackColor = System.Drawing.Color.FromArgb(255, 55, 255, 100);
            right_lbl.BackColor = System.Drawing.Color.FromArgb(255, 55, 255, 100);
            back1_lbl.BackColor = System.Drawing.Color.FromArgb(255, 55, 255, 100);
            back2_lbl.BackColor = System.Drawing.Color.FromArgb(255, 55, 255, 100);*/
        }

        private double impact_plus, impact_minus, tempuh;
        double y, simpan, persenelan, max_limit, persenelan_fac;
        int lampu_timer;
        private bool kep_left, kep_right, kep_back, ganti, warning;
        private void label_input_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            kep_back = !kep_back;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            impact_plus = trackBar1.Value;
        }

        private void solidGauge1_ChildChanged_2(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void volumeMeter1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void machine_Click(object sender, EventArgs e)
        {
        }

        private void lbDigitalMeter1_Load(object sender, EventArgs e)
        {

        }

        private void Left_btn_Click(object sender, EventArgs e)
        {
            kep_left = !kep_left;
        }

        private void turn_on_Click(object sender, EventArgs e)
        {
            Left_btn.Enabled = true;
            Right_btn.Enabled = true;
            back_btn.Enabled = true;
            trackBar1.Enabled = true;
            rem_bar.Enabled = true;
            persenelan_bar.Enabled = true;
            timer1.Enabled = !(timer1.Enabled);
            if (timer1.Enabled == true)
                turn_on.Text = "Turn OFF";
            else
                turn_on.Text = "Turn ON";
            if (warning == true)
                warning = false;
        }

        private void lamp_left_Click(object sender, EventArgs e)
        {

        }

        private void lamp_right_Click(object sender, EventArgs e)
        {

        }

        private void left_lbl_Click(object sender, EventArgs e)
        {

        }

        private void back1_lbl_Click(object sender, EventArgs e)
        {

        }

        private void right_lbl_Click(object sender, EventArgs e)
        {

        }

        private void back2_lbl_Click(object sender, EventArgs e)
        {

        }

        private void lb_left_Load(object sender, EventArgs e)
        {

        }

        private void back_left_Load(object sender, EventArgs e)
        {

        }

        private void lb_right_Load(object sender, EventArgs e)
        {

        }

        private void back_right_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Right_btn_Click(object sender, EventArgs e)
        {
            kep_right = !kep_right;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void back_lamp2_Click(object sender, EventArgs e)
        {

        }

        private void back_lamp1_Click(object sender, EventArgs e)
        {

        }

        private void fuel_bar_Scroll(object sender, EventArgs e)
        {
            fuel.Value = fuel_bar.Value;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rem_bar_Scroll(object sender, EventArgs e)
        {
            impact_minus = rem_bar.Value;
        }

        private void gas_bar_Enter(object sender, EventArgs e)
        {
        }

        private void persenelan_bar_Scroll(object sender, EventArgs e)
        {
            persenelan = persenelan_bar.Value;
            if (persenelan == 0)
            {
                max_limit = 0;
                persenelan_fac = 0;
            }
            else
            {
                max_limit = 320 / 8 * persenelan;
                persenelan_fac = persenelan / 8;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lampu_timer++;
            if (fuel.Value == 0 && warning == false)
            {
                warning = true;
                MessageBox.Show("Your Gasoline is runs out");
            }
            else
            {
                if (impact_plus == 0)
                {
                    if (impact_minus != 0)
                        y -= persenelan_fac * 1 / impact_minus * 10 * y;
                    else if (y > 0)
                        y -= 10;
                    else
                        y = 0;

                    if (y >= 0)
                        solidGauge1.Value = Convert.ToInt32(y);
                }
                else
                {
                    if (y == 0)
                    {
                        y += 1;
                    }
                    else
                    {
                        if (impact_minus != 0)
                        {
                            if (impact_plus >= impact_minus)
                                y += persenelan_fac * impact_plus / impact_minus * 25;
                            else
                                y -= persenelan_fac * impact_plus / impact_minus * 25;
                        }
                        else
                            y += persenelan_fac * impact_plus * 5;

                        if (y > max_limit)
                            y = max_limit;
                        else if (y < 0)
                            y = 0;
                        /*impact_plus -= 0.1;
                        impact_minus -= 0.1;
                        if(impact_plus <= 0 && impact_minus > 0)
                        {
                            trackBar1.Value = Convert.ToInt16(0);
                            rem_bar.Value = Convert.ToInt16(impact_minus);
                        }
                        else if(impact_minus <= 0 && impact_plus > 0)
                        {
                            trackBar1.Value = Convert.ToInt16(impact_plus);
                            rem_bar.Value = Convert.ToInt16(0);
                        }
                        else if(impact_minus <= 0 && impact_plus <= 0)
                        {
                            trackBar1.Value = Convert.ToInt16(0);
                            rem_bar.Value = Convert.ToInt16(0);
                        }
                        else
                        {
                            trackBar1.Value = Convert.ToInt16(impact_plus);
                            rem_bar.Value = Convert.ToInt16(impact_minus);
                        }*/
                    }
                    solidGauge1.Value = Convert.ToInt16(y);
                    machine.Value = trackBar1.Value;
                }
                tempuh += y / 3600;
                lbDigitalMeter1.Value = tempuh;

                if(lampu_timer >= 3)
                {
                    /*if (kep_left == true && ganti == true)
                        left_lbl.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 0);
                    else if(kep_right == true && ganti == true)
                        right_lbl.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 0);
                    else if(kep_back == true && ganti == true)
                    {
                        back1_lbl.BackColor = System.Drawing.Color.FromArgb(255, 255, 0, 0);
                        back2_lbl.BackColor = System.Drawing.Color.FromArgb(255, 255, 0, 0);
                    }

                    if (kep_left == true && ganti == false)
                        left_lbl.BackColor = System.Drawing.Color.FromArgb(255, 55, 55, 0);
                    else if (kep_right == true && ganti == false)
                        right_lbl.BackColor = System.Drawing.Color.FromArgb(255, 55, 55, 0);
                    else if (kep_back == true && ganti == false)
                    {
                        back1_lbl.BackColor = System.Drawing.Color.FromArgb(255, 55, 55, 0);
                        back2_lbl.BackColor = System.Drawing.Color.FromArgb(255, 55, 55, 0);
                    }
                    ganti = !(ganti);*/
                    lb_right.BlinkInterval = 400;
                    lb_left.BlinkInterval = 400;
                    back_right.BlinkInterval = 400;
                    back_left.BlinkInterval = 400;
                    if (kep_left == true)
                        lb_left.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On;
                    else if (kep_right == true )
                        lb_right.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On;
                    else if (kep_back == true)
                    {
                        back_right.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On;
                        back_left.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On;
                    }
                    else
                    {
                        lb_right.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
                        lb_left.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
                        back_right.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
                        back_left.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
                    }
                }
                if(rem_bar.Value > 0)
                {
                    lb_right.BlinkInterval = 800000;
                    lb_left.BlinkInterval = 800000;
                    back_right.BlinkInterval = 800000;
                    back_left.BlinkInterval = 800000;
                    back_right.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On;
                    back_left.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On;
                }
                else
                {
                    back_right.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
                    back_left.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
                }
            }
        }
    }
}
