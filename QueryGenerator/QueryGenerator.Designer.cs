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
            this.panelAge = new System.Windows.Forms.Panel();
            this.ageToNumeric = new System.Windows.Forms.NumericUpDown();
            this.ageFromNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelGender = new System.Windows.Forms.Panel();
            this.Radio_unknowGender = new System.Windows.Forms.RadioButton();
            this.Radio_woman = new System.Windows.Forms.RadioButton();
            this.Radio_men = new System.Windows.Forms.RadioButton();
            this.queryList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelQuery = new System.Windows.Forms.Panel();
            this.cb_city = new System.Windows.Forms.CheckBox();
            this.cb_age = new System.Windows.Forms.CheckBox();
            this.cb_gender = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataListGrid = new System.Windows.Forms.DataGridView();
            this.panelResults.SuspendLayout();
            this.panelCity.SuspendLayout();
            this.panelAge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageToNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFromNumeric)).BeginInit();
            this.panelGender.SuspendLayout();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListGrid)).BeginInit();
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
            this.panelResults.Location = new System.Drawing.Point(6, 12);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(925, 673);
            this.panelResults.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "<-";
            this.button3.UseVisualStyleBackColor = true;
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
            // addQueryBtn
            // 
            this.addQueryBtn.Location = new System.Drawing.Point(1250, 647);
            this.addQueryBtn.Name = "addQueryBtn";
            this.addQueryBtn.Size = new System.Drawing.Size(55, 26);
            this.addQueryBtn.TabIndex = 1;
            this.addQueryBtn.Text = "הוסף";
            this.addQueryBtn.UseVisualStyleBackColor = true;
            this.addQueryBtn.Click += new System.EventHandler(this.addQueryBtn_Click);
            // 
            // createListFromQuery
            // 
            this.createListFromQuery.Location = new System.Drawing.Point(1008, 650);
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
            this.label2.Location = new System.Drawing.Point(1202, 9);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = ":בחר שאילתות";
            // 
            // panelCity
            // 
            this.panelCity.Controls.Add(this.label6);
            this.panelCity.Controls.Add(this.cityCB);
            this.panelCity.Location = new System.Drawing.Point(1003, 39);
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
            this.label6.Location = new System.Drawing.Point(32, 14);
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
            // panelAge
            // 
            this.panelAge.Controls.Add(this.ageToNumeric);
            this.panelAge.Controls.Add(this.ageFromNumeric);
            this.panelAge.Controls.Add(this.label5);
            this.panelAge.Controls.Add(this.label4);
            this.panelAge.Location = new System.Drawing.Point(1003, 110);
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
            this.panelGender.Controls.Add(this.Radio_unknowGender);
            this.panelGender.Controls.Add(this.Radio_woman);
            this.panelGender.Controls.Add(this.Radio_men);
            this.panelGender.Location = new System.Drawing.Point(1004, 169);
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
            // queryList
            // 
            this.queryList.BackColor = System.Drawing.SystemColors.Window;
            this.queryList.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.queryList.Location = new System.Drawing.Point(1009, 459);
            this.queryList.Multiline = true;
            this.queryList.Name = "queryList";
            this.queryList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.queryList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.queryList.Size = new System.Drawing.Size(303, 152);
            this.queryList.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1242, 438);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = ":שאילתה";
            // 
            // panelQuery
            // 
            this.panelQuery.Controls.Add(this.cb_city);
            this.panelQuery.Controls.Add(this.cb_age);
            this.panelQuery.Controls.Add(this.cb_gender);
            this.panelQuery.Location = new System.Drawing.Point(1172, 39);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(139, 153);
            this.panelQuery.TabIndex = 10;
            // 
            // cb_city
            // 
            this.cb_city.AutoSize = true;
            this.cb_city.Location = new System.Drawing.Point(60, 59);
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
            this.cb_age.Location = new System.Drawing.Point(90, 36);
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
            this.cb_gender.Location = new System.Drawing.Point(91, 13);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_gender.Size = new System.Drawing.Size(43, 17);
            this.cb_gender.TabIndex = 0;
            this.cb_gender.Text = "מין";
            this.cb_gender.UseVisualStyleBackColor = true;
            this.cb_gender.CheckedChanged += new System.EventHandler(this.cb_gender_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1121, 650);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "אפס";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataListGrid
            // 
            this.dataListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListGrid.Location = new System.Drawing.Point(40, 40);
            this.dataListGrid.Name = "dataListGrid";
            this.dataListGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataListGrid.Size = new System.Drawing.Size(829, 621);
            this.dataListGrid.TabIndex = 2;
            // 
            // QueryGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1324, 697);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panelGender);
            this.Controls.Add(this.panelCity);
            this.Controls.Add(this.panelAge);
            this.Controls.Add(this.panelQuery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.queryList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createListFromQuery);
            this.Controls.Add(this.addQueryBtn);
            this.Controls.Add(this.panelResults);
            this.Name = "QueryGenerator";
            this.Text = "הפקת דוחות החוט המשולש";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QueryGenerator_Load);
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            this.panelCity.ResumeLayout(false);
            this.panelCity.PerformLayout();
            this.panelAge.ResumeLayout(false);
            this.panelAge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageToNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFromNumeric)).EndInit();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListGrid)).EndInit();
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
        private System.Windows.Forms.TextBox queryList;
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
    }
}

