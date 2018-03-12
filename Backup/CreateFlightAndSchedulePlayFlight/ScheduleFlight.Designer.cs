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
            this.btnTestSelect = new System.Windows.Forms.Button();
            this.btnTestAllFlight = new System.Windows.Forms.Button();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTestAllFlight);
            this.tabPage1.Controls.Add(this.btnTestSelect);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnSendSchedulePlan);
            this.tabPage1.Controls.Add(this.dgFlightPlan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(920, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "发送广播计划";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(102, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止发送";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSendSchedulePlan
            // 
            this.btnSendSchedulePlan.Location = new System.Drawing.Point(8, 6);
            this.btnSendSchedulePlan.Name = "btnSendSchedulePlan";
            this.btnSendSchedulePlan.Size = new System.Drawing.Size(75, 23);
            this.btnSendSchedulePlan.TabIndex = 1;
            this.btnSendSchedulePlan.Text = "发送计划";
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
            this.dgFlightPlan.Location = new System.Drawing.Point(3, 46);
            this.dgFlightPlan.Name = "dgFlightPlan";
            this.dgFlightPlan.RowTemplate.Height = 23;
            this.dgFlightPlan.Size = new System.Drawing.Size(908, 360);
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
            this.btnAdd.Location = new System.Drawing.Point(4, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(3);
            this.btnAdd.Size = new System.Drawing.Size(920, 413);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "创建航班";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "服务器消息队列：";
            // 
            // btnSendToServer
            // 
            this.btnSendToServer.Location = new System.Drawing.Point(206, 384);
            this.btnSendToServer.Name = "btnSendToServer";
            this.btnSendToServer.Size = new System.Drawing.Size(98, 23);
            this.btnSendToServer.TabIndex = 8;
            this.btnSendToServer.Text = "发送到服务器";
            this.btnSendToServer.UseVisualStyleBackColor = true;
            // 
            // btnReInstallTodayFlight
            // 
            this.btnReInstallTodayFlight.Location = new System.Drawing.Point(88, 384);
            this.btnReInstallTodayFlight.Name = "btnReInstallTodayFlight";
            this.btnReInstallTodayFlight.Size = new System.Drawing.Size(112, 23);
            this.btnReInstallTodayFlight.TabIndex = 7;
            this.btnReInstallTodayFlight.Text = "重新生成当日航班";
            this.btnReInstallTodayFlight.UseVisualStyleBackColor = true;
            // 
            // btnSaveFlights
            // 
            this.btnSaveFlights.Location = new System.Drawing.Point(6, 384);
            this.btnSaveFlights.Name = "btnSaveFlights";
            this.btnSaveFlights.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFlights.TabIndex = 6;
            this.btnSaveFlights.Text = "保存配置";
            this.btnSaveFlights.UseVisualStyleBackColor = true;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Location = new System.Drawing.Point(404, 31);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(75, 23);
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
            this.cboxFlightSector.Location = new System.Drawing.Point(76, 30);
            this.cboxFlightSector.Name = "cboxFlightSector";
            this.cboxFlightSector.Size = new System.Drawing.Size(96, 20);
            this.cboxFlightSector.TabIndex = 4;
            this.cboxFlightSector.Text = "D";
            // 
            // dpSchedule
            // 
            this.dpSchedule.CustomFormat = "yyyy-MM-dd hh:mm";
            this.dpSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpSchedule.Location = new System.Drawing.Point(611, 0);
            this.dpSchedule.Name = "dpSchedule";
            this.dpSchedule.Size = new System.Drawing.Size(175, 21);
            this.dpSchedule.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "RepeateCount：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "航班性质：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "计划日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "suffix：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "航班号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "航空公司代码：";
            // 
            // txtRepeateCount
            // 
            this.txtRepeateCount.Location = new System.Drawing.Point(286, 29);
            this.txtRepeateCount.Name = "txtRepeateCount";
            this.txtRepeateCount.Size = new System.Drawing.Size(100, 21);
            this.txtRepeateCount.TabIndex = 1;
            this.txtRepeateCount.Text = "0";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(434, 3);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(100, 21);
            this.txtSuffix.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(269, 0);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 21);
            this.txtNumber.TabIndex = 1;
            // 
            // txtServerQueue
            // 
            this.txtServerQueue.Location = new System.Drawing.Point(100, 64);
            this.txtServerQueue.Name = "txtServerQueue";
            this.txtServerQueue.Size = new System.Drawing.Size(331, 21);
            this.txtServerQueue.TabIndex = 1;
            // 
            // txtAirline
            // 
            this.txtAirline.Location = new System.Drawing.Point(100, 3);
            this.txtAirline.Name = "txtAirline";
            this.txtAirline.Size = new System.Drawing.Size(100, 21);
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
            this.dgFlight.Location = new System.Drawing.Point(7, 91);
            this.dgFlight.Name = "dgFlight";
            this.dgFlight.RowTemplate.Height = 23;
            this.dgFlight.Size = new System.Drawing.Size(783, 287);
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
            // btnTestSelect
            // 
            this.btnTestSelect.Location = new System.Drawing.Point(231, 7);
            this.btnTestSelect.Name = "btnTestSelect";
            this.btnTestSelect.Size = new System.Drawing.Size(90, 23);
            this.btnTestSelect.TabIndex = 3;
            this.btnTestSelect.Text = "测试选中航班";
            this.btnTestSelect.UseVisualStyleBackColor = true;
            this.btnTestSelect.Click += new System.EventHandler(this.btnTestSelect_Click);
            // 
            // btnTestAllFlight
            // 
            this.btnTestAllFlight.Location = new System.Drawing.Point(377, 6);
            this.btnTestAllFlight.Name = "btnTestAllFlight";
            this.btnTestAllFlight.Size = new System.Drawing.Size(94, 23);
            this.btnTestAllFlight.TabIndex = 4;
            this.btnTestAllFlight.Text = "测试所有航班";
            this.btnTestAllFlight.UseVisualStyleBackColor = true;
            this.btnTestAllFlight.Click += new System.EventHandler(this.btnTestAllFlight_Click);
            // 
            // ScheduleFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 431);
            this.Controls.Add(this.tabControl1);
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

