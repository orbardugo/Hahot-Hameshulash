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
            this.label1 = new System.Windows.Forms.Label();
            this.createListFromQuery = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.QueryListBox = new System.Windows.Forms.ListBox();
            this.remove = new System.Windows.Forms.Button();
            this.generateChart = new System.Windows.Forms.Button();
            this.chartList = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_chartType = new System.Windows.Forms.ComboBox();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.queryBox = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelChooseQuery = new System.Windows.Forms.GroupBox();
            this.cb_gender = new System.Windows.Forms.CheckBox();
            this.cb_age = new System.Windows.Forms.CheckBox();
            this.cb_city = new System.Windows.Forms.CheckBox();
            this.cb_alcohol = new System.Windows.Forms.CheckBox();
            this.cb_drug = new System.Windows.Forms.CheckBox();
            this.cb_useDrug = new System.Windows.Forms.CheckBox();
            this.cb_religion = new System.Windows.Forms.CheckBox();
            this.cb_occupation = new System.Windows.Forms.CheckBox();
            this.cb_criminalRecord = new System.Windows.Forms.CheckBox();
            this.cb_externalContact = new System.Windows.Forms.CheckBox();
            this.panelQuery = new System.Windows.Forms.Panel();
            this.religionCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panelReligion = new System.Windows.Forms.Panel();
            this.drugsCB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelDrug = new System.Windows.Forms.Panel();
            this.criminalRecordCB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panelCriminalRecord = new System.Windows.Forms.Panel();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelDate = new System.Windows.Forms.Panel();
            this.addQueryBtn = new System.Windows.Forms.Button();
            this.AlcoholCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelAlcohol = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ageFromNumeric = new System.Windows.Forms.NumericUpDown();
            this.ageToNumeric = new System.Windows.Forms.NumericUpDown();
            this.panelAge = new System.Windows.Forms.Panel();
            this.externalContactCB = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panelExternalContact = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.occupationCB = new System.Windows.Forms.ComboBox();
            this.panelOccupation = new System.Windows.Forms.Panel();
            this.Radio_men = new System.Windows.Forms.RadioButton();
            this.Radio_woman = new System.Windows.Forms.RadioButton();
            this.Radio_unknowGender = new System.Windows.Forms.RadioButton();
            this.panelGender = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cityCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelCity = new System.Windows.Forms.Panel();
            this.panelResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListGrid)).BeginInit();
            this.panelGraph.SuspendLayout();
            this.queryBox.SuspendLayout();
            this.panelChooseQuery.SuspendLayout();
            this.panelQuery.SuspendLayout();
            this.panelReligion.SuspendLayout();
            this.panelDrug.SuspendLayout();
            this.panelCriminalRecord.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.panelAlcohol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageFromNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageToNumeric)).BeginInit();
            this.panelAge.SuspendLayout();
            this.panelExternalContact.SuspendLayout();
            this.panelOccupation.SuspendLayout();
            this.panelGender.SuspendLayout();
            this.panelCity.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResults
            // 
            this.panelResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelResults.Controls.Add(this.dataListGrid);
            this.panelResults.Controls.Add(this.label1);
            this.panelResults.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelResults.Location = new System.Drawing.Point(14, 12);
            this.panelResults.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(945, 569);
            this.panelResults.TabIndex = 0;
            // 
            // dataListGrid
            // 
            this.dataListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListGrid.Location = new System.Drawing.Point(2, 46);
            this.dataListGrid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataListGrid.Name = "dataListGrid";
            this.dataListGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataListGrid.Size = new System.Drawing.Size(916, 478);
            this.dataListGrid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(405, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(114, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = ":תוצאות";
            // 
            // createListFromQuery
            // 
            this.createListFromQuery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createListFromQuery.Location = new System.Drawing.Point(1075, 599);
            this.createListFromQuery.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.createListFromQuery.Name = "createListFromQuery";
            this.createListFromQuery.Size = new System.Drawing.Size(111, 30);
            this.createListFromQuery.TabIndex = 2;
            this.createListFromQuery.Text = "חיפוש";
            this.createListFromQuery.UseVisualStyleBackColor = true;
            this.createListFromQuery.Click += new System.EventHandler(this.createListFromQuery_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(0, 155);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "אפס";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // QueryListBox
            // 
            this.QueryListBox.FormattingEnabled = true;
            this.QueryListBox.ItemHeight = 15;
            this.QueryListBox.Location = new System.Drawing.Point(2, 12);
            this.QueryListBox.Margin = new System.Windows.Forms.Padding(2);
            this.QueryListBox.Name = "QueryListBox";
            this.QueryListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QueryListBox.Size = new System.Drawing.Size(321, 139);
            this.QueryListBox.TabIndex = 12;
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(216, 155);
            this.remove.Margin = new System.Windows.Forms.Padding(2);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(107, 30);
            this.remove.TabIndex = 13;
            this.remove.Text = "הסר";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // generateChart
            // 
            this.generateChart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateChart.Location = new System.Drawing.Point(27, 0);
            this.generateChart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateChart.Name = "generateChart";
            this.generateChart.Size = new System.Drawing.Size(111, 30);
            this.generateChart.TabIndex = 16;
            this.generateChart.Text = "הצג";
            this.generateChart.UseVisualStyleBackColor = true;
            this.generateChart.Click += new System.EventHandler(this.generateChart_Click);
            // 
            // chartList
            // 
            this.chartList.AutoCompleteCustomSource.AddRange(new string[] {
            "מין",
            "עיר",
            "רקע",
            "שימוש בסמים",
            "שימוש באלכוהול",
            "גיל"});
            this.chartList.FormattingEnabled = true;
            this.chartList.Items.AddRange(new object[] {
            "מין",
            "עיר",
            "רקע",
            "גיל",
            "שימוש באלכוהול",
            "שימוש בסמים"});
            this.chartList.Location = new System.Drawing.Point(464, 4);
            this.chartList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chartList.Name = "chartList";
            this.chartList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chartList.Size = new System.Drawing.Size(117, 23);
            this.chartList.TabIndex = 17;
            this.chartList.Text = "הצג לפי";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(597, 8);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "הצג שאילתא בגרף";
            // 
            // cb_chartType
            // 
            this.cb_chartType.FormattingEnabled = true;
            this.cb_chartType.Items.AddRange(new object[] {
            "עוגה",
            "עמודות"});
            this.cb_chartType.Location = new System.Drawing.Point(283, 4);
            this.cb_chartType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_chartType.Name = "cb_chartType";
            this.cb_chartType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_chartType.Size = new System.Drawing.Size(146, 23);
            this.cb_chartType.TabIndex = 19;
            this.cb_chartType.Text = "סוג גרף";
            // 
            // panelGraph
            // 
            this.panelGraph.Controls.Add(this.cb_chartType);
            this.panelGraph.Controls.Add(this.generateChart);
            this.panelGraph.Controls.Add(this.label15);
            this.panelGraph.Controls.Add(this.chartList);
            this.panelGraph.Location = new System.Drawing.Point(92, 602);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(786, 30);
            this.panelGraph.TabIndex = 20;
            // 
            // queryBox
            // 
            this.queryBox.Controls.Add(this.QueryListBox);
            this.queryBox.Controls.Add(this.remove);
            this.queryBox.Controls.Add(this.btnClear);
            this.queryBox.Location = new System.Drawing.Point(963, 385);
            this.queryBox.Name = "queryBox";
            this.queryBox.Size = new System.Drawing.Size(329, 196);
            this.queryBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1225, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = ":שאילתה";
            // 
            // panelChooseQuery
            // 
            this.panelChooseQuery.Controls.Add(this.panelAge);
            this.panelChooseQuery.Controls.Add(this.panelAlcohol);
            this.panelChooseQuery.Controls.Add(this.panelReligion);
            this.panelChooseQuery.Controls.Add(this.panelCriminalRecord);
            this.panelChooseQuery.Controls.Add(this.panelCity);
            this.panelChooseQuery.Controls.Add(this.label2);
            this.panelChooseQuery.Controls.Add(this.panelGender);
            this.panelChooseQuery.Controls.Add(this.panelOccupation);
            this.panelChooseQuery.Controls.Add(this.panelExternalContact);
            this.panelChooseQuery.Controls.Add(this.addQueryBtn);
            this.panelChooseQuery.Controls.Add(this.panelDate);
            this.panelChooseQuery.Controls.Add(this.panelDrug);
            this.panelChooseQuery.Controls.Add(this.panelQuery);
            this.panelChooseQuery.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelChooseQuery.Location = new System.Drawing.Point(963, 10);
            this.panelChooseQuery.Margin = new System.Windows.Forms.Padding(2);
            this.panelChooseQuery.Name = "panelChooseQuery";
            this.panelChooseQuery.Padding = new System.Windows.Forms.Padding(2);
            this.panelChooseQuery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelChooseQuery.Size = new System.Drawing.Size(329, 370);
            this.panelChooseQuery.TabIndex = 14;
            this.panelChooseQuery.TabStop = false;
            // 
            // cb_gender
            // 
            this.cb_gender.AutoSize = true;
            this.cb_gender.Location = new System.Drawing.Point(87, 10);
            this.cb_gender.Margin = new System.Windows.Forms.Padding(2);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_gender.Size = new System.Drawing.Size(39, 19);
            this.cb_gender.TabIndex = 0;
            this.cb_gender.Text = "מין";
            this.cb_gender.UseVisualStyleBackColor = true;
            this.cb_gender.CheckedChanged += new System.EventHandler(this.cb_gender_CheckedChanged);
            // 
            // cb_age
            // 
            this.cb_age.AutoSize = true;
            this.cb_age.Location = new System.Drawing.Point(86, 31);
            this.cb_age.Margin = new System.Windows.Forms.Padding(2);
            this.cb_age.Name = "cb_age";
            this.cb_age.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_age.Size = new System.Drawing.Size(40, 19);
            this.cb_age.TabIndex = 1;
            this.cb_age.Text = "גיל";
            this.cb_age.UseVisualStyleBackColor = true;
            this.cb_age.CheckedChanged += new System.EventHandler(this.cb_age_CheckedChanged);
            // 
            // cb_city
            // 
            this.cb_city.AutoSize = true;
            this.cb_city.Location = new System.Drawing.Point(58, 54);
            this.cb_city.Margin = new System.Windows.Forms.Padding(2);
            this.cb_city.Name = "cb_city";
            this.cb_city.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_city.Size = new System.Drawing.Size(68, 19);
            this.cb_city.TabIndex = 2;
            this.cb_city.Text = "עיר מוצא";
            this.cb_city.UseVisualStyleBackColor = true;
            this.cb_city.CheckedChanged += new System.EventHandler(this.cb_city_CheckedChanged);
            // 
            // cb_alcohol
            // 
            this.cb_alcohol.AutoSize = true;
            this.cb_alcohol.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_alcohol.Location = new System.Drawing.Point(22, 76);
            this.cb_alcohol.Margin = new System.Windows.Forms.Padding(2);
            this.cb_alcohol.Name = "cb_alcohol";
            this.cb_alcohol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_alcohol.Size = new System.Drawing.Size(104, 19);
            this.cb_alcohol.TabIndex = 3;
            this.cb_alcohol.Text = "שימוש באלכוהול";
            this.cb_alcohol.UseVisualStyleBackColor = true;
            this.cb_alcohol.CheckedChanged += new System.EventHandler(this.cb_alcohol_CheckedChanged);
            // 
            // cb_drug
            // 
            this.cb_drug.AutoSize = true;
            this.cb_drug.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_drug.Location = new System.Drawing.Point(69, 122);
            this.cb_drug.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_drug.Name = "cb_drug";
            this.cb_drug.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_drug.Size = new System.Drawing.Size(57, 19);
            this.cb_drug.TabIndex = 4;
            this.cb_drug.Text = "נוכחות";
            this.cb_drug.UseVisualStyleBackColor = true;
            this.cb_drug.CheckedChanged += new System.EventHandler(this.appearanceCB_CheckedChanged);
            // 
            // cb_useDrug
            // 
            this.cb_useDrug.AutoSize = true;
            this.cb_useDrug.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_useDrug.Location = new System.Drawing.Point(35, 99);
            this.cb_useDrug.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_useDrug.Name = "cb_useDrug";
            this.cb_useDrug.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_useDrug.Size = new System.Drawing.Size(91, 19);
            this.cb_useDrug.TabIndex = 5;
            this.cb_useDrug.Text = "שימוש בסמים";
            this.cb_useDrug.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_useDrug.UseVisualStyleBackColor = true;
            this.cb_useDrug.CheckedChanged += new System.EventHandler(this.cb_useDrug_CheckedChanged);
            // 
            // cb_religion
            // 
            this.cb_religion.AutoSize = true;
            this.cb_religion.Location = new System.Drawing.Point(80, 142);
            this.cb_religion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_religion.Name = "cb_religion";
            this.cb_religion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_religion.Size = new System.Drawing.Size(46, 19);
            this.cb_religion.TabIndex = 6;
            this.cb_religion.Text = "רקע";
            this.cb_religion.UseVisualStyleBackColor = true;
            this.cb_religion.CheckedChanged += new System.EventHandler(this.cb_religion_CheckedChanged);
            // 
            // cb_occupation
            // 
            this.cb_occupation.AutoSize = true;
            this.cb_occupation.Location = new System.Drawing.Point(47, 165);
            this.cb_occupation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_occupation.Name = "cb_occupation";
            this.cb_occupation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_occupation.Size = new System.Drawing.Size(79, 19);
            this.cb_occupation.TabIndex = 7;
            this.cb_occupation.Text = "עיסוק נוכחי";
            this.cb_occupation.UseVisualStyleBackColor = true;
            this.cb_occupation.CheckedChanged += new System.EventHandler(this.cb_occupation_CheckedChanged);
            // 
            // cb_criminalRecord
            // 
            this.cb_criminalRecord.AutoSize = true;
            this.cb_criminalRecord.Location = new System.Drawing.Point(43, 187);
            this.cb_criminalRecord.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_criminalRecord.Name = "cb_criminalRecord";
            this.cb_criminalRecord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_criminalRecord.Size = new System.Drawing.Size(83, 19);
            this.cb_criminalRecord.TabIndex = 8;
            this.cb_criminalRecord.Text = "רישום פלילי";
            this.cb_criminalRecord.UseVisualStyleBackColor = true;
            this.cb_criminalRecord.CheckedChanged += new System.EventHandler(this.cb_criminalRecord_CheckedChanged);
            // 
            // cb_externalContact
            // 
            this.cb_externalContact.AutoSize = true;
            this.cb_externalContact.Location = new System.Drawing.Point(11, 211);
            this.cb_externalContact.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_externalContact.Name = "cb_externalContact";
            this.cb_externalContact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_externalContact.Size = new System.Drawing.Size(115, 19);
            this.cb_externalContact.TabIndex = 9;
            this.cb_externalContact.Text = "קשר עם גורם נוסף";
            this.cb_externalContact.UseVisualStyleBackColor = true;
            this.cb_externalContact.CheckedChanged += new System.EventHandler(this.cb_externalContact_CheckedChanged);
            // 
            // panelQuery
            // 
            this.panelQuery.Controls.Add(this.cb_externalContact);
            this.panelQuery.Controls.Add(this.cb_criminalRecord);
            this.panelQuery.Controls.Add(this.cb_occupation);
            this.panelQuery.Controls.Add(this.cb_religion);
            this.panelQuery.Controls.Add(this.cb_useDrug);
            this.panelQuery.Controls.Add(this.cb_drug);
            this.panelQuery.Controls.Add(this.cb_alcohol);
            this.panelQuery.Controls.Add(this.cb_city);
            this.panelQuery.Controls.Add(this.cb_age);
            this.panelQuery.Controls.Add(this.cb_gender);
            this.panelQuery.Location = new System.Drawing.Point(191, 50);
            this.panelQuery.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(134, 229);
            this.panelQuery.TabIndex = 10;
            // 
            // religionCB
            // 
            this.religionCB.FormattingEnabled = true;
            this.religionCB.Location = new System.Drawing.Point(10, 37);
            this.religionCB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.religionCB.Name = "religionCB";
            this.religionCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.religionCB.Size = new System.Drawing.Size(106, 23);
            this.religionCB.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = ":בחר רקע";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panelReligion
            // 
            this.panelReligion.Controls.Add(this.label11);
            this.panelReligion.Controls.Add(this.religionCB);
            this.panelReligion.Location = new System.Drawing.Point(64, 217);
            this.panelReligion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelReligion.Name = "panelReligion";
            this.panelReligion.Size = new System.Drawing.Size(118, 74);
            this.panelReligion.TabIndex = 13;
            this.panelReligion.Visible = false;
            // 
            // drugsCB
            // 
            this.drugsCB.FormattingEnabled = true;
            this.drugsCB.Location = new System.Drawing.Point(11, 37);
            this.drugsCB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.drugsCB.Name = "drugsCB";
            this.drugsCB.Size = new System.Drawing.Size(109, 23);
            this.drugsCB.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = ":בחר סוג שימוש ";
            // 
            // panelDrug
            // 
            this.panelDrug.Controls.Add(this.label10);
            this.panelDrug.Controls.Add(this.drugsCB);
            this.panelDrug.Location = new System.Drawing.Point(156, 61);
            this.panelDrug.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelDrug.Name = "panelDrug";
            this.panelDrug.Size = new System.Drawing.Size(128, 75);
            this.panelDrug.TabIndex = 12;
            this.panelDrug.Visible = false;
            // 
            // criminalRecordCB
            // 
            this.criminalRecordCB.FormattingEnabled = true;
            this.criminalRecordCB.Location = new System.Drawing.Point(17, 38);
            this.criminalRecordCB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.criminalRecordCB.Name = "criminalRecordCB";
            this.criminalRecordCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.criminalRecordCB.Size = new System.Drawing.Size(109, 23);
            this.criminalRecordCB.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(129, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = ":בחר רישום פלילי";
            // 
            // panelCriminalRecord
            // 
            this.panelCriminalRecord.Controls.Add(this.label13);
            this.panelCriminalRecord.Controls.Add(this.criminalRecordCB);
            this.panelCriminalRecord.Location = new System.Drawing.Point(26, 26);
            this.panelCriminalRecord.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelCriminalRecord.Name = "panelCriminalRecord";
            this.panelCriminalRecord.Size = new System.Drawing.Size(137, 74);
            this.panelCriminalRecord.TabIndex = 14;
            this.panelCriminalRecord.Visible = false;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(6, 17);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(113, 20);
            this.dateStart.TabIndex = 0;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(6, 46);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(113, 20);
            this.dateEnd.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(120, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(22, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "-מ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(119, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(29, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "-עד";
            // 
            // panelDate
            // 
            this.panelDate.Controls.Add(this.label9);
            this.panelDate.Controls.Add(this.label8);
            this.panelDate.Controls.Add(this.dateEnd);
            this.panelDate.Controls.Add(this.dateStart);
            this.panelDate.Location = new System.Drawing.Point(7, 193);
            this.panelDate.Margin = new System.Windows.Forms.Padding(2);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(144, 89);
            this.panelDate.TabIndex = 11;
            this.panelDate.Visible = false;
            // 
            // addQueryBtn
            // 
            this.addQueryBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQueryBtn.Location = new System.Drawing.Point(112, 320);
            this.addQueryBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addQueryBtn.Name = "addQueryBtn";
            this.addQueryBtn.Size = new System.Drawing.Size(111, 30);
            this.addQueryBtn.TabIndex = 1;
            this.addQueryBtn.Text = "הוסף";
            this.addQueryBtn.UseVisualStyleBackColor = true;
            this.addQueryBtn.Click += new System.EventHandler(this.addQueryBtn_Click);
            // 
            // AlcoholCB
            // 
            this.AlcoholCB.FormattingEnabled = true;
            this.AlcoholCB.Location = new System.Drawing.Point(3, 27);
            this.AlcoholCB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AlcoholCB.Name = "AlcoholCB";
            this.AlcoholCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AlcoholCB.Size = new System.Drawing.Size(99, 23);
            this.AlcoholCB.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = ":בחר ";
            // 
            // panelAlcohol
            // 
            this.panelAlcohol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelAlcohol.Controls.Add(this.label7);
            this.panelAlcohol.Controls.Add(this.AlcoholCB);
            this.panelAlcohol.Location = new System.Drawing.Point(9, 23);
            this.panelAlcohol.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelAlcohol.Name = "panelAlcohol";
            this.panelAlcohol.Size = new System.Drawing.Size(118, 74);
            this.panelAlcohol.TabIndex = 11;
            this.panelAlcohol.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "מ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "עד:";
            // 
            // ageFromNumeric
            // 
            this.ageFromNumeric.Location = new System.Drawing.Point(55, 8);
            this.ageFromNumeric.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.ageFromNumeric.Size = new System.Drawing.Size(41, 20);
            this.ageFromNumeric.TabIndex = 6;
            this.ageFromNumeric.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // ageToNumeric
            // 
            this.ageToNumeric.Location = new System.Drawing.Point(55, 38);
            this.ageToNumeric.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.ageToNumeric.Size = new System.Drawing.Size(41, 20);
            this.ageToNumeric.TabIndex = 7;
            this.ageToNumeric.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.ageToNumeric.ValueChanged += new System.EventHandler(this.ageToNumeric_ValueChanged);
            // 
            // panelAge
            // 
            this.panelAge.Controls.Add(this.ageToNumeric);
            this.panelAge.Controls.Add(this.ageFromNumeric);
            this.panelAge.Controls.Add(this.label5);
            this.panelAge.Controls.Add(this.label4);
            this.panelAge.Location = new System.Drawing.Point(9, 132);
            this.panelAge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelAge.Name = "panelAge";
            this.panelAge.Size = new System.Drawing.Size(130, 61);
            this.panelAge.TabIndex = 0;
            this.panelAge.Visible = false;
            // 
            // externalContactCB
            // 
            this.externalContactCB.FormattingEnabled = true;
            this.externalContactCB.Location = new System.Drawing.Point(2, 40);
            this.externalContactCB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.externalContactCB.Name = "externalContactCB";
            this.externalContactCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.externalContactCB.Size = new System.Drawing.Size(109, 23);
            this.externalContactCB.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 14);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = ":בחר קשר";
            // 
            // panelExternalContact
            // 
            this.panelExternalContact.Controls.Add(this.label14);
            this.panelExternalContact.Controls.Add(this.externalContactCB);
            this.panelExternalContact.Location = new System.Drawing.Point(7, 287);
            this.panelExternalContact.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelExternalContact.Name = "panelExternalContact";
            this.panelExternalContact.Size = new System.Drawing.Size(118, 74);
            this.panelExternalContact.TabIndex = 15;
            this.panelExternalContact.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 13);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(100, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = ":בחר סוג עיסוק";
            // 
            // occupationCB
            // 
            this.occupationCB.FormattingEnabled = true;
            this.occupationCB.Location = new System.Drawing.Point(4, 34);
            this.occupationCB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.occupationCB.Name = "occupationCB";
            this.occupationCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.occupationCB.Size = new System.Drawing.Size(117, 28);
            this.occupationCB.TabIndex = 11;
            // 
            // panelOccupation
            // 
            this.panelOccupation.Controls.Add(this.occupationCB);
            this.panelOccupation.Controls.Add(this.label12);
            this.panelOccupation.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.panelOccupation.Location = new System.Drawing.Point(146, 297);
            this.panelOccupation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelOccupation.Name = "panelOccupation";
            this.panelOccupation.Size = new System.Drawing.Size(118, 74);
            this.panelOccupation.TabIndex = 14;
            this.panelOccupation.Visible = false;
            // 
            // Radio_men
            // 
            this.Radio_men.AutoSize = true;
            this.Radio_men.Location = new System.Drawing.Point(83, 5);
            this.Radio_men.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Radio_men.Name = "Radio_men";
            this.Radio_men.Size = new System.Drawing.Size(41, 19);
            this.Radio_men.TabIndex = 0;
            this.Radio_men.TabStop = true;
            this.Radio_men.Text = "זכר";
            this.Radio_men.UseVisualStyleBackColor = true;
            // 
            // Radio_woman
            // 
            this.Radio_woman.AutoSize = true;
            this.Radio_woman.Location = new System.Drawing.Point(75, 30);
            this.Radio_woman.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Radio_woman.Name = "Radio_woman";
            this.Radio_woman.Size = new System.Drawing.Size(49, 19);
            this.Radio_woman.TabIndex = 1;
            this.Radio_woman.TabStop = true;
            this.Radio_woman.Text = "נקבה";
            this.Radio_woman.UseVisualStyleBackColor = true;
            // 
            // Radio_unknowGender
            // 
            this.Radio_unknowGender.AutoSize = true;
            this.Radio_unknowGender.Location = new System.Drawing.Point(65, 55);
            this.Radio_unknowGender.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Radio_unknowGender.Name = "Radio_unknowGender";
            this.Radio_unknowGender.Size = new System.Drawing.Size(59, 19);
            this.Radio_unknowGender.TabIndex = 2;
            this.Radio_unknowGender.TabStop = true;
            this.Radio_unknowGender.Text = "לא ידוע";
            this.Radio_unknowGender.UseVisualStyleBackColor = true;
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.Radio_unknowGender);
            this.panelGender.Controls.Add(this.Radio_woman);
            this.panelGender.Controls.Add(this.Radio_men);
            this.panelGender.Location = new System.Drawing.Point(12, 63);
            this.panelGender.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelGender.Name = "panelGender";
            this.panelGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelGender.Size = new System.Drawing.Size(129, 82);
            this.panelGender.TabIndex = 3;
            this.panelGender.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(186, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = ":בחר שאילתות";
            // 
            // cityCB
            // 
            this.cityCB.FormattingEnabled = true;
            this.cityCB.Location = new System.Drawing.Point(22, 38);
            this.cityCB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cityCB.Name = "cityCB";
            this.cityCB.Size = new System.Drawing.Size(97, 23);
            this.cityCB.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = ":בחר עיר";
            // 
            // panelCity
            // 
            this.panelCity.Controls.Add(this.label6);
            this.panelCity.Controls.Add(this.cityCB);
            this.panelCity.Location = new System.Drawing.Point(148, 150);
            this.panelCity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelCity.Name = "panelCity";
            this.panelCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelCity.Size = new System.Drawing.Size(130, 81);
            this.panelCity.TabIndex = 4;
            this.panelCity.Visible = false;
            // 
            // QueryGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1303, 643);
            this.Controls.Add(this.queryBox);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.createListFromQuery);
            this.Controls.Add(this.panelChooseQuery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelResults);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "QueryGenerator";
            this.Text = "הפקת דוחות החוט המשולש";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QueryGenerator_Load);
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListGrid)).EndInit();
            this.panelGraph.ResumeLayout(false);
            this.panelGraph.PerformLayout();
            this.queryBox.ResumeLayout(false);
            this.panelChooseQuery.ResumeLayout(false);
            this.panelChooseQuery.PerformLayout();
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            this.panelReligion.ResumeLayout(false);
            this.panelReligion.PerformLayout();
            this.panelDrug.ResumeLayout(false);
            this.panelDrug.PerformLayout();
            this.panelCriminalRecord.ResumeLayout(false);
            this.panelCriminalRecord.PerformLayout();
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.panelAlcohol.ResumeLayout(false);
            this.panelAlcohol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageFromNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageToNumeric)).EndInit();
            this.panelAge.ResumeLayout(false);
            this.panelAge.PerformLayout();
            this.panelExternalContact.ResumeLayout(false);
            this.panelExternalContact.PerformLayout();
            this.panelOccupation.ResumeLayout(false);
            this.panelOccupation.PerformLayout();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            this.panelCity.ResumeLayout(false);
            this.panelCity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createListFromQuery;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataListGrid;
        private System.Windows.Forms.ListBox QueryListBox;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button generateChart;
        private System.Windows.Forms.ComboBox chartList;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_chartType;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Panel queryBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox panelChooseQuery;
        private System.Windows.Forms.Panel panelCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cityCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.RadioButton Radio_unknowGender;
        private System.Windows.Forms.RadioButton Radio_woman;
        private System.Windows.Forms.RadioButton Radio_men;
        private System.Windows.Forms.Panel panelOccupation;
        private System.Windows.Forms.ComboBox occupationCB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelExternalContact;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox externalContactCB;
        private System.Windows.Forms.Panel panelAge;
        private System.Windows.Forms.NumericUpDown ageToNumeric;
        private System.Windows.Forms.NumericUpDown ageFromNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelAlcohol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AlcoholCB;
        private System.Windows.Forms.Button addQueryBtn;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Panel panelCriminalRecord;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox criminalRecordCB;
        private System.Windows.Forms.Panel panelDrug;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox drugsCB;
        private System.Windows.Forms.Panel panelReligion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox religionCB;
        private System.Windows.Forms.Panel panelQuery;
        private System.Windows.Forms.CheckBox cb_externalContact;
        private System.Windows.Forms.CheckBox cb_criminalRecord;
        private System.Windows.Forms.CheckBox cb_occupation;
        private System.Windows.Forms.CheckBox cb_religion;
        private System.Windows.Forms.CheckBox cb_useDrug;
        private System.Windows.Forms.CheckBox cb_drug;
        private System.Windows.Forms.CheckBox cb_alcohol;
        private System.Windows.Forms.CheckBox cb_city;
        private System.Windows.Forms.CheckBox cb_age;
        private System.Windows.Forms.CheckBox cb_gender;
    }
}

