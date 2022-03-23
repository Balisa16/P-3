namespace P3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.persenelan_bar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rem_bar = new System.Windows.Forms.TrackBar();
            this.label_input = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fuel_bar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.back_btn = new MaterialSkin.Controls.MaterialButton();
            this.Left_btn = new MaterialSkin.Controls.MaterialButton();
            this.Right_btn = new MaterialSkin.Controls.MaterialButton();
            this.gas_bar = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.turn_on = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.back_right = new LBSoft.IndustrialCtrls.Leds.LBLed();
            this.lb_right = new LBSoft.IndustrialCtrls.Leds.LBLed();
            this.solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.machine = new System.Windows.Forms.ProgressBar();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.fuel = new System.Windows.Forms.ProgressBar();
            this.lbDigitalMeter1 = new LBSoft.IndustrialCtrls.Meters.LBDigitalMeter();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.back_left = new LBSoft.IndustrialCtrls.Leds.LBLed();
            this.lb_left = new LBSoft.IndustrialCtrls.Leds.LBLed();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.persenelan_bar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rem_bar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuel_bar)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.gas_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 635F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1288, 635);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label_input, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.gas_bar, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.turn_on, 0, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1088, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(197, 629);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.persenelan_bar);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 50);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gear Level";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // persenelan_bar
            // 
            this.persenelan_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.persenelan_bar.LargeChange = 1;
            this.persenelan_bar.Location = new System.Drawing.Point(3, 16);
            this.persenelan_bar.Maximum = 8;
            this.persenelan_bar.Name = "persenelan_bar";
            this.persenelan_bar.Size = new System.Drawing.Size(185, 31);
            this.persenelan_bar.TabIndex = 1;
            this.persenelan_bar.Scroll += new System.EventHandler(this.persenelan_bar_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rem_bar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 54);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brake Pedal";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rem_bar
            // 
            this.rem_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rem_bar.LargeChange = 1;
            this.rem_bar.Location = new System.Drawing.Point(3, 16);
            this.rem_bar.Name = "rem_bar";
            this.rem_bar.Size = new System.Drawing.Size(185, 35);
            this.rem_bar.TabIndex = 1;
            this.rem_bar.Scroll += new System.EventHandler(this.rem_bar_Scroll);
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_input.Location = new System.Drawing.Point(3, 0);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(191, 30);
            this.label_input.TabIndex = 0;
            this.label_input.Text = "Input";
            this.label_input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_input.Click += new System.EventHandler(this.label_input_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fuel_bar);
            this.groupBox1.Location = new System.Drawing.Point(3, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuel Level";
            // 
            // fuel_bar
            // 
            this.fuel_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuel_bar.LargeChange = 1;
            this.fuel_bar.Location = new System.Drawing.Point(3, 16);
            this.fuel_bar.Name = "fuel_bar";
            this.fuel_bar.Size = new System.Drawing.Size(185, 32);
            this.fuel_bar.TabIndex = 0;
            this.fuel_bar.Scroll += new System.EventHandler(this.fuel_bar_Scroll);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.back_btn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.Left_btn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Right_btn, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 90);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(191, 38);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // back_btn
            // 
            this.back_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_btn.BackColor = System.Drawing.Color.Red;
            this.back_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.back_btn.Depth = 0;
            this.back_btn.HighEmphasis = true;
            this.back_btn.Icon = null;
            this.back_btn.Location = new System.Drawing.Point(61, 6);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.back_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.back_btn.Name = "back_btn";
            this.back_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.back_btn.Size = new System.Drawing.Size(64, 26);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "B";
            this.back_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.back_btn.UseAccentColor = false;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Left_btn
            // 
            this.Left_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Left_btn.BackColor = System.Drawing.Color.Lime;
            this.Left_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Left_btn.Depth = 0;
            this.Left_btn.HighEmphasis = true;
            this.Left_btn.Icon = null;
            this.Left_btn.Location = new System.Drawing.Point(4, 6);
            this.Left_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Left_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Left_btn.Name = "Left_btn";
            this.Left_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Left_btn.Size = new System.Drawing.Size(49, 26);
            this.Left_btn.TabIndex = 0;
            this.Left_btn.Text = "L";
            this.Left_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Left_btn.UseAccentColor = false;
            this.Left_btn.UseVisualStyleBackColor = false;
            this.Left_btn.Click += new System.EventHandler(this.Left_btn_Click);
            // 
            // Right_btn
            // 
            this.Right_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Right_btn.BackColor = System.Drawing.Color.Lime;
            this.Right_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Right_btn.Depth = 0;
            this.Right_btn.HighEmphasis = true;
            this.Right_btn.Icon = null;
            this.Right_btn.Location = new System.Drawing.Point(137, 6);
            this.Right_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Right_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Right_btn.Name = "Right_btn";
            this.Right_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Right_btn.Size = new System.Drawing.Size(50, 26);
            this.Right_btn.TabIndex = 1;
            this.Right_btn.Text = "R";
            this.Right_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Right_btn.UseAccentColor = false;
            this.Right_btn.UseVisualStyleBackColor = false;
            this.Right_btn.Click += new System.EventHandler(this.Right_btn_Click);
            // 
            // gas_bar
            // 
            this.gas_bar.Controls.Add(this.trackBar1);
            this.gas_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gas_bar.Location = new System.Drawing.Point(3, 134);
            this.gas_bar.Name = "gas_bar";
            this.gas_bar.Size = new System.Drawing.Size(191, 49);
            this.gas_bar.TabIndex = 3;
            this.gas_bar.TabStop = false;
            this.gas_bar.Text = "Speed Pedal";
            this.gas_bar.Enter += new System.EventHandler(this.gas_bar_Enter);
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(3, 16);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(185, 30);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // turn_on
            // 
            this.turn_on.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.turn_on.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.turn_on.Depth = 0;
            this.turn_on.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turn_on.HighEmphasis = true;
            this.turn_on.Icon = null;
            this.turn_on.Location = new System.Drawing.Point(4, 601);
            this.turn_on.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.turn_on.MouseState = MaterialSkin.MouseState.HOVER;
            this.turn_on.Name = "turn_on";
            this.turn_on.NoAccentTextColor = System.Drawing.Color.Empty;
            this.turn_on.Size = new System.Drawing.Size(189, 22);
            this.turn_on.TabIndex = 6;
            this.turn_on.Text = "Turn On";
            this.turn_on.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.turn_on.UseAccentColor = false;
            this.turn_on.UseVisualStyleBackColor = true;
            this.turn_on.Click += new System.EventHandler(this.turn_on_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel9, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.solidGauge1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbDigitalMeter1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1079, 629);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.back_right, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.lb_right, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(906, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(170, 116);
            this.tableLayoutPanel9.TabIndex = 4;
            // 
            // back_right
            // 
            this.back_right.AutoSize = true;
            this.back_right.BackColor = System.Drawing.Color.Transparent;
            this.back_right.BlinkInterval = 500;
            this.back_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_right.Label = "";
            this.back_right.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top;
            this.back_right.LedColor = System.Drawing.Color.Red;
            this.back_right.LedSize = new System.Drawing.SizeF(10F, 10F);
            this.back_right.Location = new System.Drawing.Point(3, 61);
            this.back_right.Name = "back_right";
            this.back_right.Renderer = null;
            this.back_right.Size = new System.Drawing.Size(164, 52);
            this.back_right.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            this.back_right.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Rectangular;
            this.back_right.TabIndex = 2;
            this.back_right.Load += new System.EventHandler(this.back_right_Load);
            // 
            // lb_right
            // 
            this.lb_right.AutoSize = true;
            this.lb_right.BackColor = System.Drawing.Color.Transparent;
            this.lb_right.BlinkInterval = 500;
            this.lb_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_right.Label = "";
            this.lb_right.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top;
            this.lb_right.LedColor = System.Drawing.Color.Gold;
            this.lb_right.LedSize = new System.Drawing.SizeF(10F, 10F);
            this.lb_right.Location = new System.Drawing.Point(3, 3);
            this.lb_right.Name = "lb_right";
            this.lb_right.Renderer = null;
            this.lb_right.Size = new System.Drawing.Size(164, 52);
            this.lb_right.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            this.lb_right.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Rectangular;
            this.lb_right.TabIndex = 1;
            this.lb_right.Load += new System.EventHandler(this.lb_right_Load);
            // 
            // solidGauge1
            // 
            this.solidGauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solidGauge1.Location = new System.Drawing.Point(153, 125);
            this.solidGauge1.Name = "solidGauge1";
            this.solidGauge1.Size = new System.Drawing.Size(747, 425);
            this.solidGauge1.TabIndex = 0;
            this.solidGauge1.Text = "solidGauge1";
            this.solidGauge1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.solidGauge1_ChildChanged_2);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(153, 556);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(747, 70);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.machine, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.materialLabel2, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(741, 29);
            this.tableLayoutPanel7.TabIndex = 1;
            this.tableLayoutPanel7.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel7_Paint);
            // 
            // machine
            // 
            this.machine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machine.Location = new System.Drawing.Point(155, 3);
            this.machine.Maximum = 10;
            this.machine.Name = "machine";
            this.machine.Size = new System.Drawing.Size(583, 23);
            this.machine.Step = 1;
            this.machine.TabIndex = 2;
            this.machine.Click += new System.EventHandler(this.machine_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(3, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(146, 29);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Machine Rotation";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.fuel, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(741, 29);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(146, 29);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Gas Level";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // fuel
            // 
            this.fuel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuel.Location = new System.Drawing.Point(155, 3);
            this.fuel.Maximum = 10;
            this.fuel.Name = "fuel";
            this.fuel.Size = new System.Drawing.Size(583, 23);
            this.fuel.Step = 1;
            this.fuel.TabIndex = 1;
            // 
            // lbDigitalMeter1
            // 
            this.lbDigitalMeter1.BackColor = System.Drawing.Color.Transparent;
            this.lbDigitalMeter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDigitalMeter1.Format = "000.00";
            this.lbDigitalMeter1.Location = new System.Drawing.Point(153, 3);
            this.lbDigitalMeter1.Name = "lbDigitalMeter1";
            this.lbDigitalMeter1.Renderer = null;
            this.lbDigitalMeter1.Signed = false;
            this.lbDigitalMeter1.Size = new System.Drawing.Size(747, 116);
            this.lbDigitalMeter1.TabIndex = 2;
            this.lbDigitalMeter1.Value = 80D;
            this.lbDigitalMeter1.Load += new System.EventHandler(this.lbDigitalMeter1_Load);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.back_left, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lb_left, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(144, 116);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // back_left
            // 
            this.back_left.AutoSize = true;
            this.back_left.BackColor = System.Drawing.Color.Transparent;
            this.back_left.BlinkInterval = 500;
            this.back_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_left.Label = "";
            this.back_left.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top;
            this.back_left.LedColor = System.Drawing.Color.Red;
            this.back_left.LedSize = new System.Drawing.SizeF(10F, 10F);
            this.back_left.Location = new System.Drawing.Point(3, 61);
            this.back_left.Name = "back_left";
            this.back_left.Renderer = null;
            this.back_left.Size = new System.Drawing.Size(138, 52);
            this.back_left.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            this.back_left.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Rectangular;
            this.back_left.TabIndex = 1;
            this.back_left.Load += new System.EventHandler(this.back_left_Load);
            // 
            // lb_left
            // 
            this.lb_left.AutoSize = true;
            this.lb_left.BackColor = System.Drawing.Color.Transparent;
            this.lb_left.BlinkInterval = 500;
            this.lb_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_left.Label = "";
            this.lb_left.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top;
            this.lb_left.LedColor = System.Drawing.Color.Gold;
            this.lb_left.LedSize = new System.Drawing.SizeF(10F, 10F);
            this.lb_left.Location = new System.Drawing.Point(3, 3);
            this.lb_left.Name = "lb_left";
            this.lb_left.Renderer = null;
            this.lb_left.Size = new System.Drawing.Size(138, 52);
            this.lb_left.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            this.lb_left.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Rectangular;
            this.lb_left.TabIndex = 0;
            this.lb_left.Load += new System.EventHandler(this.lb_left_Load);
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Cars Dock";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.persenelan_bar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rem_bar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuel_bar)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.gas_bar.ResumeLayout(false);
            this.gas_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar fuel_bar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialButton back_btn;
        private MaterialSkin.Controls.MaterialButton Left_btn;
        private MaterialSkin.Controls.MaterialButton Right_btn;
        private System.Windows.Forms.GroupBox gas_bar;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar persenelan_bar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar rem_bar;
        private LiveCharts.WinForms.SolidGauge solidGauge1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ProgressBar machine;
        private System.Windows.Forms.ProgressBar fuel;
        private LBSoft.IndustrialCtrls.Meters.LBDigitalMeter lbDigitalMeter1;
        private MaterialSkin.Controls.MaterialButton turn_on;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private LBSoft.IndustrialCtrls.Leds.LBLed back_right;
        private LBSoft.IndustrialCtrls.Leds.LBLed lb_right;
        private LBSoft.IndustrialCtrls.Leds.LBLed back_left;
        private LBSoft.IndustrialCtrls.Leds.LBLed lb_left;
    }
}

