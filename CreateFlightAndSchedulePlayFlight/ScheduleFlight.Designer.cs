namespace CreateFlightAndSchedulePlayFlight
{
    partial class ScheduleFlight
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTestAllFlight = new System.Windows.Forms.Button();
            this.btnTestSelect = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSendSchedulePlan = new System.Windows.Forms.Button();
            this.dgFlightPlan = new System.Windows.Forms.DataGridView();
            this.Cadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cairline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_suffix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_flightrepeatecount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonegroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_announcementtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeatcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_gate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_languages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_terminalcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEnable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSendToServer = new System.Windows.Forms.Button();
            this.btnReInstallTodayFlight = new System.Windows.Forms.Button();
            this.btnSaveFlights = new System.Windows.Forms.Button();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.cboxFlightSector = new System.Windows.Forms.ComboBox();
            this.dpSchedule = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRepeateCount = new System.Windows.Forms.TextBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtServerQueue = new System.Windows.Forms.TextBox();
            this.txtAirline = new System.Windows.Forms.TextBox();
            this.dgFlight = new System.Windows.Forms.DataGridView();
            this.CLine_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSuffix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRepeateCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmSendPlan = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlightPlan)).BeginInit();
            this.btnAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.btnAdd);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1392, 732);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTestAllFlight);
            this.tabPage1.Controls.Add(this.btnTestSelect);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnSendSchedulePlan);
            this.tabPage1.Controls.Add(this.dgFlightPlan);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1384, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SendPlan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTestAllFlight
            // 
            this.btnTestAllFlight.Location = new System.Drawing.Point(566, 10);
            this.btnTestAllFlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTestAllFlight.Name = "btnTestAllFlight";
            this.btnTestAllFlight.Size = new System.Drawing.Size(141, 38);
            this.btnTestAllFlight.TabIndex = 4;
            this.btnTestAllFlight.Text = "test all airlines";
            this.btnTestAllFlight.UseVisualStyleBackColor = true;
            this.btnTestAllFlight.Click += new System.EventHandler(this.btnTestAllFlight_Click);
            // 
            // btnTestSelect
            // 
            this.btnTestSelect.Location = new System.Drawing.Point(346, 12);
            this.btnTestSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTestSelect.Name = "btnTestSelect";
            this.btnTestSelect.Size = new System.Drawing.Size(135, 38);
            this.btnTestSelect.TabIndex = 3;
            this.btnTestSelect.Text = "test selected airline";
            this.btnTestSelect.UseVisualStyleBackColor = true;
            this.btnTestSelect.Click += new System.EventHandler(this.btnTestSelect_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(153, 10);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 38);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "stop sending ";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSendSchedulePlan
            // 
            this.btnSendSchedulePlan.Location = new System.Drawing.Point(12, 10);
            this.btnSendSchedulePlan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendSchedulePlan.Name = "btnSendSchedulePlan";
            this.btnSendSchedulePlan.Size = new System.Drawing.Size(112, 38);
            this.btnSendSchedulePlan.TabIndex = 1;
            this.btnSendSchedulePlan.Text = "add plan";
            this.btnSendSchedulePlan.UseVisualStyleBackColor = true;
            this.btnSendSchedulePlan.Click += new System.EventHandler(this.btnSendSchedulePlan_Click);
            // 
            // dgFlightPlan
            // 
            this.dgFlightPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFlightPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFlightPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cadi,
            this.Cairline,
            this.C_number,
            this.C_suffix,
            this.C_flightrepeatecount,
            this.zonegroup,
            this.C_announcementtype,
            this.repeatcount,
            this.C_gate,
            this.C_languages,
            this.C_terminalcode,
            this.C_time,
            this.CEnable});
            this.dgFlightPlan.Location = new System.Drawing.Point(4, 77);
            this.dgFlightPlan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgFlightPlan.Name = "dgFlightPlan";
            this.dgFlightPlan.RowTemplate.Height = 23;
            this.dgFlightPlan.Size = new System.Drawing.Size(1362, 600);
            this.dgFlightPlan.TabIndex = 0;
            // 
            // Cadi
            // 
            this.Cadi.HeaderText = "adi";
            this.Cadi.Name = "Cadi";
            // 
            // Cairline
            // 
            this.Cairline.HeaderText = "airline";
            this.Cairline.Name = "Cairline";
            // 
            // C_number
            // 
            this.C_number.HeaderText = "number";
            this.C_number.Name = "C_number";
            // 
            // C_suffix
            // 
            this.C_suffix.HeaderText = "suffix";
            this.C_suffix.Name = "C_suffix";
            // 
            // C_flightrepeatecount
            // 
            this.C_flightrepeatecount.HeaderText = "flightrepeatecount";
            this.C_flightrepeatecount.Name = "C_flightrepeatecount";
            // 
            // zonegroup
            // 
            this.zonegroup.HeaderText = "zonegroup";
            this.zonegroup.Name = "zonegroup";
            // 
            // C_announcementtype
            // 
            this.C_announcementtype.HeaderText = "announcementtype";
            this.C_announcementtype.Name = "C_announcementtype";
            // 
            // repeatcount
            // 
            this.repeatcount.HeaderText = "repeatcount";
            this.repeatcount.Name = "repeatcount";
            // 
            // C_gate
            // 
            this.C_gate.HeaderText = "gate";
            this.C_gate.Name = "C_gate";
            // 
            // C_languages
            // 
            this.C_languages.HeaderText = "languages";
            this.C_languages.Name = "C_languages";
            // 
            // C_terminalcode
            // 
            this.C_terminalcode.HeaderText = "terminalcode";
            this.C_terminalcode.Name = "C_terminalcode";
            // 
            // C_time
            // 
            this.C_time.HeaderText = "time";
            this.C_time.Name = "C_time";
            // 
            // CEnable
            // 
            this.CEnable.HeaderText = "Enable";
            this.CEnable.Name = "CEnable";
            // 
            // btnAdd
            // 
            this.btnAdd.Controls.Add(this.label7);
            this.btnAdd.Controls.Add(this.btnSendToServer);
            this.btnAdd.Controls.Add(this.btnReInstallTodayFlight);
            this.btnAdd.Controls.Add(this.btnSaveFlights);
            this.btnAdd.Controls.Add(this.btnAddFlight);
            this.btnAdd.Controls.Add(this.cboxFlightSector);
            this.btnAdd.Controls.Add(this.dpSchedule);
            this.btnAdd.Controls.Add(this.label5);
            this.btnAdd.Controls.Add(this.label4);
            this.btnAdd.Controls.Add(this.label6);
            this.btnAdd.Controls.Add(this.label3);
            this.btnAdd.Controls.Add(this.label2);
            this.btnAdd.Controls.Add(this.label1);
            this.btnAdd.Controls.Add(this.txtRepeateCount);
            this.btnAdd.Controls.Add(this.txtSuffix);
            this.btnAdd.Controls.Add(this.txtNumber);
            this.btnAdd.Controls.Add(this.txtServerQueue);
            this.btnAdd.Controls.Add(this.txtAirline);
            this.btnAdd.Controls.Add(this.dgFlight);
            this.btnAdd.Location = new System.Drawing.Point(4, 29);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Size = new System.Drawing.Size(1384, 699);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "add airline";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "服务器消息队列：";
            // 
            // btnSendToServer
            // 
            this.btnSendToServer.Location = new System.Drawing.Point(309, 640);
            this.btnSendToServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendToServer.Name = "btnSendToServer";
            this.btnSendToServer.Size = new System.Drawing.Size(147, 38);
            this.btnSendToServer.TabIndex = 8;
            this.btnSendToServer.Text = "发送到服务器";
            this.btnSendToServer.UseVisualStyleBackColor = true;
            // 
            // btnReInstallTodayFlight
            // 
            this.btnReInstallTodayFlight.Location = new System.Drawing.Point(132, 640);
            this.btnReInstallTodayFlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReInstallTodayFlight.Name = "btnReInstallTodayFlight";
            this.btnReInstallTodayFlight.Size = new System.Drawing.Size(168, 38);
            this.btnReInstallTodayFlight.TabIndex = 7;
            this.btnReInstallTodayFlight.Text = "重新生成当日航班";
            this.btnReInstallTodayFlight.UseVisualStyleBackColor = true;
            // 
            // btnSaveFlights
            // 
            this.btnSaveFlights.Location = new System.Drawing.Point(9, 640);
            this.btnSaveFlights.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveFlights.Name = "btnSaveFlights";
            this.btnSaveFlights.Size = new System.Drawing.Size(112, 38);
            this.btnSaveFlights.TabIndex = 6;
            this.btnSaveFlights.Text = "保存配置";
            this.btnSaveFlights.UseVisualStyleBackColor = true;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Location = new System.Drawing.Point(606, 52);
            this.btnAddFlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(112, 38);
            this.btnAddFlight.TabIndex = 5;
            this.btnAddFlight.Text = "添加航班";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            // 
            // cboxFlightSector
            // 
            this.cboxFlightSector.FormattingEnabled = true;
            this.cboxFlightSector.Items.AddRange(new object[] {
            "D",
            "I",
            "M",
            "R"});
            this.cboxFlightSector.Location = new System.Drawing.Point(114, 50);
            this.cboxFlightSector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxFlightSector.Name = "cboxFlightSector";
            this.cboxFlightSector.Size = new System.Drawing.Size(142, 28);
            this.cboxFlightSector.TabIndex = 4;
            this.cboxFlightSector.Text = "D";
            // 
            // dpSchedule
            // 
            this.dpSchedule.CustomFormat = "yyyy-MM-dd hh:mm";
            this.dpSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpSchedule.Location = new System.Drawing.Point(916, 0);
            this.dpSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpSchedule.Name = "dpSchedule";
            this.dpSchedule.Size = new System.Drawing.Size(260, 26);
            this.dpSchedule.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "RepeateCount：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "航班性质：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(810, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "计划日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "suffix：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "航班号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "航空公司代码：";
            // 
            // txtRepeateCount
            // 
            this.txtRepeateCount.Location = new System.Drawing.Point(429, 48);
            this.txtRepeateCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRepeateCount.Name = "txtRepeateCount";
            this.txtRepeateCount.Size = new System.Drawing.Size(148, 26);
            this.txtRepeateCount.TabIndex = 1;
            this.txtRepeateCount.Text = "0";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(651, 5);
            this.txtSuffix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(148, 26);
            this.txtSuffix.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(404, 0);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(148, 26);
            this.txtNumber.TabIndex = 1;
            // 
            // txtServerQueue
            // 
            this.txtServerQueue.Location = new System.Drawing.Point(150, 107);
            this.txtServerQueue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServerQueue.Name = "txtServerQueue";
            this.txtServerQueue.Size = new System.Drawing.Size(494, 26);
            this.txtServerQueue.TabIndex = 1;
            // 
            // txtAirline
            // 
            this.txtAirline.Location = new System.Drawing.Point(150, 5);
            this.txtAirline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAirline.Name = "txtAirline";
            this.txtAirline.Size = new System.Drawing.Size(148, 26);
            this.txtAirline.TabIndex = 1;
            // 
            // dgFlight
            // 
            this.dgFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFlight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLine_code,
            this.CNumber,
            this.CSuffix,
            this.CSchedule,
            this.FlightSector,
            this.CRepeateCount});
            this.dgFlight.Location = new System.Drawing.Point(10, 152);
            this.dgFlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgFlight.Name = "dgFlight";
            this.dgFlight.RowTemplate.Height = 23;
            this.dgFlight.Size = new System.Drawing.Size(1174, 478);
            this.dgFlight.TabIndex = 0;
            // 
            // CLine_code
            // 
            this.CLine_code.HeaderText = "航空公司";
            this.CLine_code.Name = "CLine_code";
            // 
            // CNumber
            // 
            this.CNumber.HeaderText = "航班号";
            this.CNumber.Name = "CNumber";
            // 
            // CSuffix
            // 
            this.CSuffix.HeaderText = "Suffix";
            this.CSuffix.Name = "CSuffix";
            // 
            // CSchedule
            // 
            this.CSchedule.HeaderText = "计划日期";
            this.CSchedule.Name = "CSchedule";
            // 
            // FlightSector
            // 
            this.FlightSector.HeaderText = "航班性质";
            this.FlightSector.Name = "FlightSector";
            this.FlightSector.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FlightSector.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CRepeateCount
            // 
            this.CRepeateCount.HeaderText = "RepeateCount";
            this.CRepeateCount.Name = "CRepeateCount";
            // 
            // tmSendPlan
            // 
            this.tmSendPlan.Tick += new System.EventHandler(this.tmSendPlan_Tick);
            // 
            // ScheduleFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 718);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScheduleFlight";
            this.Load += new System.EventHandler(this.ScheduleFlight_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFlightPlan)).EndInit();
            this.btnAdd.ResumeLayout(false);
            this.btnAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage btnAdd;
        private System.Windows.Forms.DataGridView dgFlight;
        private System.Windows.Forms.DateTimePicker dpSchedule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRepeateCount;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtAirline;
        private System.Windows.Forms.ComboBox cboxFlightSector;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button btnSendToServer;
        private System.Windows.Forms.Button btnReInstallTodayFlight;
        private System.Windows.Forms.Button btnSaveFlights;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLine_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSuffix;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRepeateCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtServerQueue;
        private System.Windows.Forms.DataGridView dgFlightPlan;
        private System.Windows.Forms.Button btnSendSchedulePlan;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer tmSendPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cairline;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_suffix;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_flightrepeatecount;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonegroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_announcementtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeatcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_gate;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_languages;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_terminalcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEnable;
        private System.Windows.Forms.Button btnTestAllFlight;
        private System.Windows.Forms.Button btnTestSelect;
    }
}

