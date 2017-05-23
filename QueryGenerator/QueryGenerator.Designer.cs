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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panelAlcohol = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.AlcoholCB = new System.Windows.Forms.ComboBox();
            this.panelOccupation = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.occupationCB = new System.Windows.Forms.ComboBox();
            this.panelReligion = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.religionCB = new System.Windows.Forms.ComboBox();
            this.panelCity = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cityCB = new System.Windows.Forms.ComboBox();
            this.panelCriminalRecord = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.criminalRecordCB = new System.Windows.Forms.ComboBox();
            this.panelExternalContact = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.externalContactCB = new System.Windows.Forms.ComboBox();
            this.panelQuery = new System.Windows.Forms.Panel();
            this.cb_externalContact = new System.Windows.Forms.CheckBox();
            this.cb_criminalRecord = new System.Windows.Forms.CheckBox();
            this.cb_occupation = new System.Windows.Forms.CheckBox();
            this.cb_religion = new System.Windows.Forms.CheckBox();
            this.cb_useDrug = new System.Windows.Forms.CheckBox();
            this.cb_drug = new System.Windows.Forms.CheckBox();
            this.cb_alcohol = new System.Windows.Forms.CheckBox();
            this.cb_city = new System.Windows.Forms.CheckBox();
            this.cb_age = new System.Windows.Forms.CheckBox();
            this.cb_gender = new System.Windows.Forms.CheckBox();
            this.panelDrug = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.drugsCB = new System.Windows.Forms.ComboBox();
            this.addQueryBtn = new System.Windows.Forms.Button();
            this.createListFromQuery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.generateChart = new System.Windows.Forms.Button();
            this.chartList = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_chartType = new System.Windows.Forms.ComboBox();
            this.panelResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListGrid)).BeginInit();
            this.panelAlcohol.SuspendLayout();
            this.panelOccupation.SuspendLayout();
            this.panelReligion.SuspendLayout();
            this.panelCity.SuspendLayout();
            this.panelCriminalRecord.SuspendLayout();
            this.panelExternalContact.SuspendLayout();
            this.panelQuery.SuspendLayout();
            this.panelDrug.SuspendLayout();
            this.panelAge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageToNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFromNumeric)).BeginInit();
            this.panelGender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.queryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResults
            // 
            this.panelResults.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelResults.Controls.Add(this.dataListGrid);
            this.panelResults.Controls.Add(this.button1);
            this.panelResults.Controls.Add(this.label1);
            this.panelResults.Controls.Add(this.progressBar1);
            this.panelResults.Location = new System.Drawing.Point(17, 9);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(796, 588);
            this.panelResults.TabIndex = 0;
            // 
            // dataListGrid
            // 
            this.dataListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListGrid.Location = new System.Drawing.Point(3, 40);
            this.dataListGrid.Name = "dataListGrid";
            this.dataListGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataListGrid.Size = new System.Drawing.Size(786, 530);
            this.dataListGrid.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(875, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(725, 4);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = ":תוצאות";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(103, 10);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(613, 10);
            this.progressBar1.TabIndex = 4;
            // 
            // panelAlcohol
            // 
            this.panelAlcohol.BackColor = System.Drawing.SystemColors.Control;
            this.panelAlcohol.Controls.Add(this.label7);
            this.panelAlcohol.Controls.Add(this.AlcoholCB);
            this.panelAlcohol.Location = new System.Drawing.Point(15, 17);
            this.panelAlcohol.Name = "panelAlcohol";
            this.panelAlcohol.Size = new System.Drawing.Size(137, 59);
            this.panelAlcohol.TabIndex = 11;
            this.panelAlcohol.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 5);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = ":בחר ";
            // 
            // AlcoholCB
            // 
            this.AlcoholCB.FormattingEnabled = true;
            this.AlcoholCB.Location = new System.Drawing.Point(3, 26);
            this.AlcoholCB.Name = "AlcoholCB";
            this.AlcoholCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AlcoholCB.Size = new System.Drawing.Size(115, 21);
            this.AlcoholCB.TabIndex = 0;
            // 
            // panelOccupation
            // 
            this.panelOccupation.Controls.Add(this.label12);
            this.panelOccupation.Controls.Add(this.occupationCB);
            this.panelOccupation.Location = new System.Drawing.Point(12, 35);
            this.panelOccupation.Name = "panelOccupation";
            this.panelOccupation.Size = new System.Drawing.Size(142, 64);
            this.panelOccupation.TabIndex = 14;
            this.panelOccupation.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 6);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(116, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = ":בחר סוג עיסוק";
            // 
            // occupationCB
            // 
            this.occupationCB.FormattingEnabled = true;
            this.occupationCB.Location = new System.Drawing.Point(3, 34);
            this.occupationCB.Name = "occupationCB";
            this.occupationCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.occupationCB.Size = new System.Drawing.Size(136, 21);
            this.occupationCB.TabIndex = 11;
            // 
            // panelReligion
            // 
            this.panelReligion.Controls.Add(this.label11);
            this.panelReligion.Controls.Add(this.religionCB);
            this.panelReligion.Location = new System.Drawing.Point(876, 12);
            this.panelReligion.Name = "panelReligion";
            this.panelReligion.Size = new System.Drawing.Size(142, 64);
            this.panelReligion.TabIndex = 13;
            this.panelReligion.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 12);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = ":בחר דת";
            // 
            // religionCB
            // 
            this.religionCB.FormattingEnabled = true;
            this.religionCB.Location = new System.Drawing.Point(3, 35);
            this.religionCB.Name = "religionCB";
            this.religionCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.religionCB.Size = new System.Drawing.Size(126, 21);
            this.religionCB.TabIndex = 11;
            // 
            // panelCity
            // 
            this.panelCity.Controls.Add(this.label6);
            this.panelCity.Controls.Add(this.cityCB);
            this.panelCity.Location = new System.Drawing.Point(18, 58);
            this.panelCity.Name = "panelCity";
            this.panelCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelCity.Size = new System.Drawing.Size(156, 70);
            this.panelCity.TabIndex = 4;
            this.panelCity.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 14);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = ":בחר עיר";
            // 
            // cityCB
            // 
            this.cityCB.FormattingEnabled = true;
            this.cityCB.Location = new System.Drawing.Point(14, 35);
            this.cityCB.Name = "cityCB";
            this.cityCB.Size = new System.Drawing.Size(112, 21);
            this.cityCB.TabIndex = 0;
            // 
            // panelCriminalRecord
            // 
            this.panelCriminalRecord.Controls.Add(this.label13);
            this.panelCriminalRecord.Controls.Add(this.criminalRecordCB);
            this.panelCriminalRecord.Location = new System.Drawing.Point(188, 1);
            this.panelCriminalRecord.Name = "panelCriminalRecord";
            this.panelCriminalRecord.Size = new System.Drawing.Size(142, 64);
            this.panelCriminalRecord.TabIndex = 14;
            this.panelCriminalRecord.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 14);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(134, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = ":בחר רישום פלילי";
            // 
            // criminalRecordCB
            // 
            this.criminalRecordCB.FormattingEnabled = true;
            this.criminalRecordCB.Location = new System.Drawing.Point(3, 35);
            this.criminalRecordCB.Name = "criminalRecordCB";
            this.criminalRecordCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.criminalRecordCB.Size = new System.Drawing.Size(126, 21);
            this.criminalRecordCB.TabIndex = 11;
            // 
            // panelExternalContact
            // 
            this.panelExternalContact.Controls.Add(this.panelOccupation);
            this.panelExternalContact.Controls.Add(this.label14);
            this.panelExternalContact.Controls.Add(this.panelCity);
            this.panelExternalContact.Controls.Add(this.externalContactCB);
            this.panelExternalContact.Location = new System.Drawing.Point(5, 1);
            this.panelExternalContact.Name = "panelExternalContact";
            this.panelExternalContact.Size = new System.Drawing.Size(142, 64);
            this.panelExternalContact.TabIndex = 15;
            this.panelExternalContact.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(51, 14);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(77, 18);
            this.label14.TabIndex = 12;
            this.label14.Text = ":בחר קשר";
            // 
            // externalContactCB
            // 
            this.externalContactCB.FormattingEnabled = true;
            this.externalContactCB.Location = new System.Drawing.Point(3, 35);
            this.externalContactCB.Name = "externalContactCB";
            this.externalContactCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.externalContactCB.Size = new System.Drawing.Size(126, 21);
            this.externalContactCB.TabIndex = 11;
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
            this.panelQuery.Location = new System.Drawing.Point(265, 39);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(119, 222);
            this.panelQuery.TabIndex = 10;
            // 
            // cb_externalContact
            // 
            this.cb_externalContact.AutoSize = true;
            this.cb_externalContact.Location = new System.Drawing.Point(-3, 203);
            this.cb_externalContact.Name = "cb_externalContact";
            this.cb_externalContact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_externalContact.Size = new System.Drawing.Size(119, 17);
            this.cb_externalContact.TabIndex = 9;
            this.cb_externalContact.Text = "קשר עם גורם נוסף";
            this.cb_externalContact.UseVisualStyleBackColor = true;
            this.cb_externalContact.CheckedChanged += new System.EventHandler(this.cb_externalContact_CheckedChanged);
            // 
            // cb_criminalRecord
            // 
            this.cb_criminalRecord.AutoSize = true;
            this.cb_criminalRecord.Location = new System.Drawing.Point(24, 182);
            this.cb_criminalRecord.Name = "cb_criminalRecord";
            this.cb_criminalRecord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_criminalRecord.Size = new System.Drawing.Size(92, 17);
            this.cb_criminalRecord.TabIndex = 8;
            this.cb_criminalRecord.Text = "רישום פלילי";
            this.cb_criminalRecord.UseVisualStyleBackColor = true;
            this.cb_criminalRecord.CheckedChanged += new System.EventHandler(this.cb_criminalRecord_CheckedChanged);
            // 
            // cb_occupation
            // 
            this.cb_occupation.AutoSize = true;
            this.cb_occupation.Location = new System.Drawing.Point(27, 162);
            this.cb_occupation.Name = "cb_occupation";
            this.cb_occupation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_occupation.Size = new System.Drawing.Size(89, 17);
            this.cb_occupation.TabIndex = 7;
            this.cb_occupation.Text = "עיסוק נוכחי";
            this.cb_occupation.UseVisualStyleBackColor = true;
            this.cb_occupation.CheckedChanged += new System.EventHandler(this.cb_occupation_CheckedChanged);
            // 
            // cb_religion
            // 
            this.cb_religion.AutoSize = true;
            this.cb_religion.Location = new System.Drawing.Point(76, 142);
            this.cb_religion.Name = "cb_religion";
            this.cb_religion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_religion.Size = new System.Drawing.Size(40, 17);
            this.cb_religion.TabIndex = 6;
            this.cb_religion.Text = "דת";
            this.cb_religion.UseVisualStyleBackColor = true;
            this.cb_religion.CheckedChanged += new System.EventHandler(this.cb_religion_CheckedChanged);
            // 
            // cb_useDrug
            // 
            this.cb_useDrug.AutoSize = true;
            this.cb_useDrug.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_useDrug.Location = new System.Drawing.Point(19, 95);
            this.cb_useDrug.Name = "cb_useDrug";
            this.cb_useDrug.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_useDrug.Size = new System.Drawing.Size(97, 17);
            this.cb_useDrug.TabIndex = 5;
            this.cb_useDrug.Text = "שימוש בסמים";
            this.cb_useDrug.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_useDrug.UseVisualStyleBackColor = true;
            this.cb_useDrug.CheckedChanged += new System.EventHandler(this.cb_useDrug_CheckedChanged);
            // 
            // cb_drug
            // 
            this.cb_drug.AutoSize = true;
            this.cb_drug.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_drug.Location = new System.Drawing.Point(54, 119);
            this.cb_drug.Name = "cb_drug";
            this.cb_drug.Size = new System.Drawing.Size(62, 17);
            this.cb_drug.TabIndex = 4;
            this.cb_drug.Text = "נוכחות";
            this.cb_drug.UseVisualStyleBackColor = true;
            this.cb_drug.CheckedChanged += new System.EventHandler(this.appearanceCB_CheckedChanged);
            // 
            // cb_alcohol
            // 
            this.cb_alcohol.AutoSize = true;
            this.cb_alcohol.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_alcohol.Location = new System.Drawing.Point(-1, 73);
            this.cb_alcohol.Margin = new System.Windows.Forms.Padding(2);
            this.cb_alcohol.Name = "cb_alcohol";
            this.cb_alcohol.Size = new System.Drawing.Size(117, 17);
            this.cb_alcohol.TabIndex = 3;
            this.cb_alcohol.Text = "שימוש באלכוהול";
            this.cb_alcohol.UseVisualStyleBackColor = true;
            this.cb_alcohol.CheckedChanged += new System.EventHandler(this.cb_alcohol_CheckedChanged);
            // 
            // cb_city
            // 
            this.cb_city.AutoSize = true;
            this.cb_city.Location = new System.Drawing.Point(41, 53);
            this.cb_city.Margin = new System.Windows.Forms.Padding(2);
            this.cb_city.Name = "cb_city";
            this.cb_city.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_city.Size = new System.Drawing.Size(74, 17);
            this.cb_city.TabIndex = 2;
            this.cb_city.Text = "עיר מוצא";
            this.cb_city.UseVisualStyleBackColor = true;
            this.cb_city.CheckedChanged += new System.EventHandler(this.cb_city_CheckedChanged);
            // 
            // cb_age
            // 
            this.cb_age.AutoSize = true;
            this.cb_age.Location = new System.Drawing.Point(69, 29);
            this.cb_age.Margin = new System.Windows.Forms.Padding(2);
            this.cb_age.Name = "cb_age";
            this.cb_age.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_age.Size = new System.Drawing.Size(44, 17);
            this.cb_age.TabIndex = 1;
            this.cb_age.Text = "גיל";
            this.cb_age.UseVisualStyleBackColor = true;
            this.cb_age.CheckedChanged += new System.EventHandler(this.cb_age_CheckedChanged);
            // 
            // cb_gender
            // 
            this.cb_gender.AutoSize = true;
            this.cb_gender.Location = new System.Drawing.Point(69, 6);
            this.cb_gender.Margin = new System.Windows.Forms.Padding(2);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_gender.Size = new System.Drawing.Size(43, 17);
            this.cb_gender.TabIndex = 0;
            this.cb_gender.Text = "מין";
            this.cb_gender.UseVisualStyleBackColor = true;
            this.cb_gender.CheckedChanged += new System.EventHandler(this.cb_gender_CheckedChanged);
            // 
            // panelDrug
            // 
            this.panelDrug.Controls.Add(this.label10);
            this.panelDrug.Controls.Add(this.drugsCB);
            this.panelDrug.Location = new System.Drawing.Point(827, 99);
            this.panelDrug.Name = "panelDrug";
            this.panelDrug.Size = new System.Drawing.Size(139, 64);
            this.panelDrug.TabIndex = 12;
            this.panelDrug.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 14);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(126, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = ":בחר סוג שימוש ";
            // 
            // drugsCB
            // 
            this.drugsCB.FormattingEnabled = true;
            this.drugsCB.Location = new System.Drawing.Point(3, 36);
            this.drugsCB.Name = "drugsCB";
            this.drugsCB.Size = new System.Drawing.Size(126, 21);
            this.drugsCB.TabIndex = 11;
            // 
            // addQueryBtn
            // 
            this.addQueryBtn.Location = new System.Drawing.Point(17, 51);
            this.addQueryBtn.Name = "addQueryBtn";
            this.addQueryBtn.Size = new System.Drawing.Size(55, 26);
            this.addQueryBtn.TabIndex = 1;
            this.addQueryBtn.Text = "הוסף";
            this.addQueryBtn.UseVisualStyleBackColor = true;
            this.addQueryBtn.Click += new System.EventHandler(this.addQueryBtn_Click);
            // 
            // createListFromQuery
            // 
            this.createListFromQuery.Location = new System.Drawing.Point(935, 541);
            this.createListFromQuery.Name = "createListFromQuery";
            this.createListFromQuery.Size = new System.Drawing.Size(63, 23);
            this.createListFromQuery.TabIndex = 2;
            this.createListFromQuery.Text = "חיפוש";
            this.createListFromQuery.UseVisualStyleBackColor = true;
            this.createListFromQuery.Click += new System.EventHandler(this.createListFromQuery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 15);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = ":בחר שאילתות";
            // 
            // panelAge
            // 
            this.panelAge.Controls.Add(this.ageToNumeric);
            this.panelAge.Controls.Add(this.ageFromNumeric);
            this.panelAge.Controls.Add(this.label5);
            this.panelAge.Controls.Add(this.label4);
            this.panelAge.Location = new System.Drawing.Point(26, 123);
            this.panelAge.Name = "panelAge";
            this.panelAge.Size = new System.Drawing.Size(156, 53);
            this.panelAge.TabIndex = 0;
            this.panelAge.Visible = false;
            // 
            // ageToNumeric
            // 
            this.ageToNumeric.Location = new System.Drawing.Point(3, 14);
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
            this.ageToNumeric.Size = new System.Drawing.Size(49, 20);
            this.ageToNumeric.TabIndex = 7;
            this.ageToNumeric.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // ageFromNumeric
            // 
            this.ageFromNumeric.Location = new System.Drawing.Point(84, 13);
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
            this.ageFromNumeric.Size = new System.Drawing.Size(49, 20);
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
            this.label5.Location = new System.Drawing.Point(54, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "עד:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "מ:";
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.panelAlcohol);
            this.panelGender.Controls.Add(this.Radio_unknowGender);
            this.panelGender.Controls.Add(this.Radio_woman);
            this.panelGender.Controls.Add(this.Radio_men);
            this.panelGender.Location = new System.Drawing.Point(26, 46);
            this.panelGender.Name = "panelGender";
            this.panelGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelGender.Size = new System.Drawing.Size(155, 71);
            this.panelGender.TabIndex = 3;
            this.panelGender.Visible = false;
            // 
            // Radio_unknowGender
            // 
            this.Radio_unknowGender.AutoSize = true;
            this.Radio_unknowGender.Location = new System.Drawing.Point(51, 48);
            this.Radio_unknowGender.Name = "Radio_unknowGender";
            this.Radio_unknowGender.Size = new System.Drawing.Size(67, 17);
            this.Radio_unknowGender.TabIndex = 2;
            this.Radio_unknowGender.TabStop = true;
            this.Radio_unknowGender.Text = "לא ידוע";
            this.Radio_unknowGender.UseVisualStyleBackColor = true;
            // 
            // Radio_woman
            // 
            this.Radio_woman.AutoSize = true;
            this.Radio_woman.Location = new System.Drawing.Point(67, 25);
            this.Radio_woman.Name = "Radio_woman";
            this.Radio_woman.Size = new System.Drawing.Size(51, 17);
            this.Radio_woman.TabIndex = 1;
            this.Radio_woman.TabStop = true;
            this.Radio_woman.Text = "נקבה";
            this.Radio_woman.UseVisualStyleBackColor = true;
            // 
            // Radio_men
            // 
            this.Radio_men.AutoSize = true;
            this.Radio_men.Location = new System.Drawing.Point(75, 2);
            this.Radio_men.Name = "Radio_men";
            this.Radio_men.Size = new System.Drawing.Size(43, 17);
            this.Radio_men.TabIndex = 0;
            this.Radio_men.TabStop = true;
            this.Radio_men.Text = "זכר";
            this.Radio_men.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1147, 253);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = ":שאילתה";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1089, 541);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "אפס";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // QueryListBox
            // 
            this.QueryListBox.FormattingEnabled = true;
            this.QueryListBox.Location = new System.Drawing.Point(169, 23);
            this.QueryListBox.Margin = new System.Windows.Forms.Padding(2);
            this.QueryListBox.Name = "QueryListBox";
            this.QueryListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QueryListBox.Size = new System.Drawing.Size(193, 173);
            this.QueryListBox.TabIndex = 12;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(79, 51);
            this.remove.Margin = new System.Windows.Forms.Padding(2);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(65, 26);
            this.remove.TabIndex = 13;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelDate);
            this.groupBox1.Controls.Add(this.panelAge);
            this.groupBox1.Controls.Add(this.panelCriminalRecord);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panelGender);
            this.groupBox1.Controls.Add(this.panelQuery);
            this.groupBox1.Controls.Add(this.panelExternalContact);
            this.groupBox1.Location = new System.Drawing.Point(833, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(395, 259);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // panelDate
            // 
            this.panelDate.Controls.Add(this.label9);
            this.panelDate.Controls.Add(this.label8);
            this.panelDate.Controls.Add(this.dateEnd);
            this.panelDate.Controls.Add(this.dateStart);
            this.panelDate.Location = new System.Drawing.Point(22, 181);
            this.panelDate.Margin = new System.Windows.Forms.Padding(2);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(328, 77);
            this.panelDate.TabIndex = 11;
            this.panelDate.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "-עד";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "-מ";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(9, 15);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(135, 20);
            this.dateEnd.TabIndex = 1;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(166, 15);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(135, 20);
            this.dateStart.TabIndex = 0;
            // 
            // queryBox
            // 
            this.queryBox.Controls.Add(this.QueryListBox);
            this.queryBox.Controls.Add(this.remove);
            this.queryBox.Controls.Add(this.addQueryBtn);
            this.queryBox.Location = new System.Drawing.Point(833, 294);
            this.queryBox.Margin = new System.Windows.Forms.Padding(2);
            this.queryBox.Name = "queryBox";
            this.queryBox.Padding = new System.Windows.Forms.Padding(2);
            this.queryBox.Size = new System.Drawing.Size(395, 214);
            this.queryBox.TabIndex = 15;
            this.queryBox.TabStop = false;
            // 
            // generateChart
            // 
            this.generateChart.Location = new System.Drawing.Point(164, 625);
            this.generateChart.Name = "generateChart";
            this.generateChart.Size = new System.Drawing.Size(83, 33);
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
            this.chartList.Location = new System.Drawing.Point(497, 632);
            this.chartList.Name = "chartList";
            this.chartList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chartList.Size = new System.Drawing.Size(140, 21);
            this.chartList.TabIndex = 17;
            this.chartList.Text = "הצג לפי";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(656, 635);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "הצג שאילתא בגרף";
            // 
            // cb_chartType
            // 
            this.cb_chartType.FormattingEnabled = true;
            this.cb_chartType.Items.AddRange(new object[] {
            "עוגה",
            "עמודות"});
            this.cb_chartType.Location = new System.Drawing.Point(280, 632);
            this.cb_chartType.Name = "cb_chartType";
            this.cb_chartType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_chartType.Size = new System.Drawing.Size(174, 21);
            this.cb_chartType.TabIndex = 19;
            this.cb_chartType.Text = "סוג גרף";
            // 
            // QueryGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1253, 689);
            this.Controls.Add(this.cb_chartType);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.chartList);
            this.Controls.Add(this.generateChart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.createListFromQuery);
            this.Controls.Add(this.panelReligion);
            this.Controls.Add(this.queryBox);
            this.Controls.Add(this.panelDrug);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelResults);
            this.Name = "QueryGenerator";
            this.Text = "הפקת דוחות החוט המשולש";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListGrid)).EndInit();
            this.panelAlcohol.ResumeLayout(false);
            this.panelAlcohol.PerformLayout();
            this.panelOccupation.ResumeLayout(false);
            this.panelOccupation.PerformLayout();
            this.panelReligion.ResumeLayout(false);
            this.panelReligion.PerformLayout();
            this.panelCity.ResumeLayout(false);
            this.panelCity.PerformLayout();
            this.panelCriminalRecord.ResumeLayout(false);
            this.panelCriminalRecord.PerformLayout();
            this.panelExternalContact.ResumeLayout(false);
            this.panelExternalContact.PerformLayout();
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            this.panelDrug.ResumeLayout(false);
            this.panelDrug.PerformLayout();
            this.panelAge.ResumeLayout(false);
            this.panelAge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageToNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFromNumeric)).EndInit();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
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
        private System.Windows.Forms.CheckBox cb_drug;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_useDrug;
        private System.Windows.Forms.Panel panelDrug;
        private System.Windows.Forms.ComboBox drugsCB;
        private System.Windows.Forms.CheckBox cb_religion;
        private System.Windows.Forms.Panel panelReligion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox religionCB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cb_occupation;
        private System.Windows.Forms.Panel panelOccupation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox occupationCB;
        private System.Windows.Forms.CheckBox cb_criminalRecord;
        private System.Windows.Forms.Panel panelCriminalRecord;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox criminalRecordCB;
        private System.Windows.Forms.CheckBox cb_externalContact;
        private System.Windows.Forms.Panel panelExternalContact;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox externalContactCB;
        private System.Windows.Forms.Button generateChart;
        private System.Windows.Forms.ComboBox chartList;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_chartType;
    }
}

