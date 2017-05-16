namespace QueryGenerator
{
    partial class QueryGenerator
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
            this.panelResults = new System.Windows.Forms.Panel();
            this.dataListGrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.addQueryBtn = new System.Windows.Forms.Button();
            this.createListFromQuery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCity = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cityCB = new System.Windows.Forms.ComboBox();
            this.panelAlcohol = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.AlcoholCB = new System.Windows.Forms.ComboBox();
            this.panelAge = new System.Windows.Forms.Panel();
            this.ageToNumeric = new System.Windows.Forms.NumericUpDown();
            this.ageFromNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelGender = new System.Windows.Forms.Panel();
            this.Radio_unknowGender = new System.Windows.Forms.RadioButton();
            this.Radio_woman = new System.Windows.Forms.RadioButton();
            this.Radio_men = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panelQuery = new System.Windows.Forms.Panel();
            this.cb_appearance = new System.Windows.Forms.CheckBox();
            this.cb_alcohol = new System.Windows.Forms.CheckBox();
            this.cb_city = new System.Windows.Forms.CheckBox();
            this.cb_age = new System.Windows.Forms.CheckBox();
            this.cb_gender = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.QueryListBox = new System.Windows.Forms.ListBox();
            this.remove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelDate = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.queryBox = new System.Windows.Forms.GroupBox();
            this.panelResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListGrid)).BeginInit();
            this.panelCity.SuspendLayout();
            this.panelAlcohol.SuspendLayout();
            this.panelAge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageToNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFromNumeric)).BeginInit();
            this.panelGender.SuspendLayout();
            this.panelQuery.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.queryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResults
            // 
            this.panelResults.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelResults.Controls.Add(this.dataListGrid);
            this.panelResults.Controls.Add(this.button3);
            this.panelResults.Controls.Add(this.button1);
            this.panelResults.Controls.Add(this.label1);
            this.panelResults.Controls.Add(this.progressBar1);
            this.panelResults.Location = new System.Drawing.Point(26, 14);
            this.panelResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(1194, 1028);
            this.panelResults.TabIndex = 0;
            // 
            // dataListGrid
            // 
            this.dataListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListGrid.Location = new System.Drawing.Point(314, 62);
            this.dataListGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataListGrid.Name = "dataListGrid";
            this.dataListGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataListGrid.Size = new System.Drawing.Size(666, 889);
            this.dataListGrid.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 474);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "<-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1312, 474);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1088, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = ":תוצאות";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(154, 15);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(920, 15);
            this.progressBar1.TabIndex = 4;
            // 
            // addQueryBtn
            // 
            this.addQueryBtn.Location = new System.Drawing.Point(26, 78);
            this.addQueryBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addQueryBtn.Name = "addQueryBtn";
            this.addQueryBtn.Size = new System.Drawing.Size(82, 40);
            this.addQueryBtn.TabIndex = 1;
            this.addQueryBtn.Text = "הוסף";
            this.addQueryBtn.UseVisualStyleBackColor = true;
            this.addQueryBtn.Click += new System.EventHandler(this.addQueryBtn_Click);
            // 
            // createListFromQuery
            // 
            this.createListFromQuery.Location = new System.Drawing.Point(1402, 832);
            this.createListFromQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createListFromQuery.Name = "createListFromQuery";
            this.createListFromQuery.Size = new System.Drawing.Size(94, 35);
            this.createListFromQuery.TabIndex = 2;
            this.createListFromQuery.Text = "חיפוש";
            this.createListFromQuery.UseVisualStyleBackColor = true;
            this.createListFromQuery.Click += new System.EventHandler(this.createListFromQuery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = ":בחר שאילתות";
            // 
            // panelCity
            // 
            this.panelCity.Controls.Add(this.label6);
            this.panelCity.Controls.Add(this.cityCB);
            this.panelCity.Location = new System.Drawing.Point(12, 18);
            this.panelCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCity.Name = "panelCity";
            this.panelCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelCity.Size = new System.Drawing.Size(234, 108);
            this.panelCity.TabIndex = 4;
            this.panelCity.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(104, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = ":בחר עיר";
            // 
            // cityCB
            // 
            this.cityCB.FormattingEnabled = true;
            this.cityCB.Location = new System.Drawing.Point(21, 54);
            this.cityCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cityCB.Name = "cityCB";
            this.cityCB.Size = new System.Drawing.Size(166, 28);
            this.cityCB.TabIndex = 0;
            // 
            // panelAlcohol
            // 
            this.panelAlcohol.BackColor = System.Drawing.SystemColors.Control;
            this.panelAlcohol.Controls.Add(this.label7);
            this.panelAlcohol.Controls.Add(this.AlcoholCB);
            this.panelAlcohol.Location = new System.Drawing.Point(26, 336);
            this.panelAlcohol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAlcohol.Name = "panelAlcohol";
            this.panelAlcohol.Size = new System.Drawing.Size(206, 91);
            this.panelAlcohol.TabIndex = 11;
            this.panelAlcohol.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(69, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = ":בחר ";
            // 
            // AlcoholCB
            // 
            this.AlcoholCB.FormattingEnabled = true;
            this.AlcoholCB.Location = new System.Drawing.Point(4, 40);
            this.AlcoholCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlcoholCB.Name = "AlcoholCB";
            this.AlcoholCB.Size = new System.Drawing.Size(170, 28);
            this.AlcoholCB.TabIndex = 0;
            // 
            // panelAge
            // 
            this.panelAge.Controls.Add(this.ageToNumeric);
            this.panelAge.Controls.Add(this.ageFromNumeric);
            this.panelAge.Controls.Add(this.label5);
            this.panelAge.Controls.Add(this.label4);
            this.panelAge.Location = new System.Drawing.Point(39, 189);
            this.panelAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAge.Name = "panelAge";
            this.panelAge.Size = new System.Drawing.Size(234, 82);
            this.panelAge.TabIndex = 0;
            this.panelAge.Visible = false;
            // 
            // ageToNumeric
            // 
            this.ageToNumeric.Location = new System.Drawing.Point(4, 22);
            this.ageToNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ageToNumeric.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.ageToNumeric.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ageToNumeric.Name = "ageToNumeric";
            this.ageToNumeric.Size = new System.Drawing.Size(74, 26);
            this.ageToNumeric.TabIndex = 7;
            this.ageToNumeric.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // ageFromNumeric
            // 
            this.ageFromNumeric.Location = new System.Drawing.Point(126, 20);
            this.ageFromNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ageFromNumeric.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.ageFromNumeric.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ageFromNumeric.Name = "ageFromNumeric";
            this.ageFromNumeric.Size = new System.Drawing.Size(74, 26);
            this.ageFromNumeric.TabIndex = 6;
            this.ageFromNumeric.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "עד:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "מ:";
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.Radio_unknowGender);
            this.panelGender.Controls.Add(this.Radio_woman);
            this.panelGender.Controls.Add(this.Radio_men);
            this.panelGender.Location = new System.Drawing.Point(39, 71);
            this.panelGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelGender.Name = "panelGender";
            this.panelGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelGender.Size = new System.Drawing.Size(232, 109);
            this.panelGender.TabIndex = 3;
            this.panelGender.Visible = false;
            // 
            // Radio_unknowGender
            // 
            this.Radio_unknowGender.AutoSize = true;
            this.Radio_unknowGender.Location = new System.Drawing.Point(76, 74);
            this.Radio_unknowGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Radio_unknowGender.Name = "Radio_unknowGender";
            this.Radio_unknowGender.Size = new System.Drawing.Size(86, 24);
            this.Radio_unknowGender.TabIndex = 2;
            this.Radio_unknowGender.TabStop = true;
            this.Radio_unknowGender.Text = "לא ידוע";
            this.Radio_unknowGender.UseVisualStyleBackColor = true;
            // 
            // Radio_woman
            // 
            this.Radio_woman.AutoSize = true;
            this.Radio_woman.Location = new System.Drawing.Point(100, 38);
            this.Radio_woman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Radio_woman.Name = "Radio_woman";
            this.Radio_woman.Size = new System.Drawing.Size(67, 24);
            this.Radio_woman.TabIndex = 1;
            this.Radio_woman.TabStop = true;
            this.Radio_woman.Text = "נקבה";
            this.Radio_woman.UseVisualStyleBackColor = true;
            // 
            // Radio_men
            // 
            this.Radio_men.AutoSize = true;
            this.Radio_men.Location = new System.Drawing.Point(112, 3);
            this.Radio_men.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Radio_men.Name = "Radio_men";
            this.Radio_men.Size = new System.Drawing.Size(57, 24);
            this.Radio_men.TabIndex = 0;
            this.Radio_men.TabStop = true;
            this.Radio_men.Text = "זכר";
            this.Radio_men.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1720, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = ":שאילתה";
            // 
            // panelQuery
            // 
            this.panelQuery.Controls.Add(this.cb_appearance);
            this.panelQuery.Controls.Add(this.cb_alcohol);
            this.panelQuery.Controls.Add(this.cb_city);
            this.panelQuery.Controls.Add(this.cb_age);
            this.panelQuery.Controls.Add(this.cb_gender);
            this.panelQuery.Location = new System.Drawing.Point(365, 62);
            this.panelQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(178, 189);
            this.panelQuery.TabIndex = 10;
            // 
            // cb_appearance
            // 
            this.cb_appearance.AutoSize = true;
            this.cb_appearance.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_appearance.Location = new System.Drawing.Point(79, 145);
            this.cb_appearance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_appearance.Name = "cb_appearance";
            this.cb_appearance.Size = new System.Drawing.Size(79, 24);
            this.cb_appearance.TabIndex = 4;
            this.cb_appearance.Text = "נוכחות";
            this.cb_appearance.UseVisualStyleBackColor = true;
            this.cb_appearance.CheckedChanged += new System.EventHandler(this.appearanceCB_CheckedChanged);
            // 
            // cb_alcohol
            // 
            this.cb_alcohol.AutoSize = true;
            this.cb_alcohol.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_alcohol.Location = new System.Drawing.Point(-1, 113);
            this.cb_alcohol.Name = "cb_alcohol";
            this.cb_alcohol.Size = new System.Drawing.Size(145, 24);
            this.cb_alcohol.TabIndex = 3;
            this.cb_alcohol.Text = "שימוש באלכוהול";
            this.cb_alcohol.UseVisualStyleBackColor = true;
            this.cb_alcohol.CheckedChanged += new System.EventHandler(this.cb_alcohol_CheckedChanged);
            // 
            // cb_city
            // 
            this.cb_city.AutoSize = true;
            this.cb_city.Location = new System.Drawing.Point(62, 82);
            this.cb_city.Name = "cb_city";
            this.cb_city.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_city.Size = new System.Drawing.Size(97, 24);
            this.cb_city.TabIndex = 2;
            this.cb_city.Text = "עיר מוצא";
            this.cb_city.UseVisualStyleBackColor = true;
            this.cb_city.CheckedChanged += new System.EventHandler(this.cb_city_CheckedChanged);
            // 
            // cb_age
            // 
            this.cb_age.AutoSize = true;
            this.cb_age.Location = new System.Drawing.Point(104, 44);
            this.cb_age.Name = "cb_age";
            this.cb_age.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_age.Size = new System.Drawing.Size(56, 24);
            this.cb_age.TabIndex = 1;
            this.cb_age.Text = "גיל";
            this.cb_age.UseVisualStyleBackColor = true;
            this.cb_age.CheckedChanged += new System.EventHandler(this.cb_age_CheckedChanged);
            // 
            // cb_gender
            // 
            this.cb_gender.AutoSize = true;
            this.cb_gender.Location = new System.Drawing.Point(103, 10);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_gender.Size = new System.Drawing.Size(57, 24);
            this.cb_gender.TabIndex = 0;
            this.cb_gender.Text = "מין";
            this.cb_gender.UseVisualStyleBackColor = true;
            this.cb_gender.CheckedChanged += new System.EventHandler(this.cb_gender_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1634, 832);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 35);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "אפס";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // QueryListBox
            // 
            this.QueryListBox.FormattingEnabled = true;
            this.QueryListBox.ItemHeight = 20;
            this.QueryListBox.Location = new System.Drawing.Point(254, 35);
            this.QueryListBox.Name = "QueryListBox";
            this.QueryListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QueryListBox.Size = new System.Drawing.Size(288, 264);
            this.QueryListBox.TabIndex = 12;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(118, 78);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(98, 40);
            this.remove.TabIndex = 13;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelAlcohol);
            this.groupBox1.Controls.Add(this.panelDate);
            this.groupBox1.Controls.Add(this.panelAge);
            this.groupBox1.Controls.Add(this.panelCity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panelQuery);
            this.groupBox1.Controls.Add(this.panelGender);
            this.groupBox1.Location = new System.Drawing.Point(1250, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 398);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // panelDate
            // 
            this.panelDate.Controls.Add(this.label9);
            this.panelDate.Controls.Add(this.label8);
            this.panelDate.Controls.Add(this.dateEnd);
            this.panelDate.Controls.Add(this.dateStart);
            this.panelDate.Location = new System.Drawing.Point(33, 279);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(492, 119);
            this.panelDate.TabIndex = 11;
            this.panelDate.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "-עד";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "-מ";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(13, 23);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 26);
            this.dateEnd.TabIndex = 1;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(249, 23);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 26);
            this.dateStart.TabIndex = 0;
            // 
            // queryBox
            // 
            this.queryBox.Controls.Add(this.QueryListBox);
            this.queryBox.Controls.Add(this.remove);
            this.queryBox.Controls.Add(this.addQueryBtn);
            this.queryBox.Location = new System.Drawing.Point(1250, 452);
            this.queryBox.Name = "queryBox";
            this.queryBox.Size = new System.Drawing.Size(592, 329);
            this.queryBox.TabIndex = 15;
            this.queryBox.TabStop = false;
            // 
            // QueryGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1912, 1038);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.createListFromQuery);
            this.Controls.Add(this.queryBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelResults);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QueryGenerator";
            this.Text = "הפקת דוחות החוט המשולש";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListGrid)).EndInit();
            this.panelCity.ResumeLayout(false);
            this.panelCity.PerformLayout();
            this.panelAlcohol.ResumeLayout(false);
            this.panelAlcohol.PerformLayout();
            this.panelAge.ResumeLayout(false);
            this.panelAge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageToNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFromNumeric)).EndInit();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.queryBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button addQueryBtn;
        private System.Windows.Forms.Button createListFromQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelAge;
        private System.Windows.Forms.RadioButton Radio_woman;
        private System.Windows.Forms.RadioButton Radio_men;
        private System.Windows.Forms.RadioButton Radio_unknowGender;
        private System.Windows.Forms.Panel panelQuery;
        private System.Windows.Forms.CheckBox cb_city;
        private System.Windows.Forms.CheckBox cb_age;
        private System.Windows.Forms.CheckBox cb_gender;
        private System.Windows.Forms.NumericUpDown ageToNumeric;
        private System.Windows.Forms.NumericUpDown ageFromNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.Panel panelCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cityCB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataListGrid;
        private System.Windows.Forms.ListBox QueryListBox;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox queryBox;
        private System.Windows.Forms.CheckBox cb_alcohol;
        private System.Windows.Forms.Panel panelAlcohol;
        private System.Windows.Forms.ComboBox AlcoholCB;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.CheckBox cb_appearance;
        private System.Windows.Forms.Label label7;
    }
}

