namespace 간단한_이름_바꾸기
{
    partial class ChangeName
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
            this.btnFolder = new System.Windows.Forms.Button();
            this.txtFileExt = new System.Windows.Forms.TextBox();
            this.lblFileExt = new System.Windows.Forms.Label();
            this.cbxFileExt = new System.Windows.Forms.ComboBox();
            this.ckbSubfolders = new System.Windows.Forms.CheckBox();
            this.lblBeforeText = new System.Windows.Forms.Label();
            this.lblAfterText = new System.Windows.Forms.Label();
            this.btnCalcel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.lblHead = new System.Windows.Forms.Label();
            this.ckbHead = new System.Windows.Forms.CheckBox();
            this.ckbTail = new System.Windows.Forms.CheckBox();
            this.lblTail = new System.Windows.Forms.Label();
            this.ckbCount = new System.Windows.Forms.CheckBox();
            this.lblCountHead = new System.Windows.Forms.Label();
            this.rdbHead = new System.Windows.Forms.RadioButton();
            this.rdbTail = new System.Windows.Forms.RadioButton();
            this.lblCountTail = new System.Windows.Forms.Label();
            this.gpbCount = new System.Windows.Forms.GroupBox();
            this.lblCountNumber = new System.Windows.Forms.Label();
            this.cbxFolder = new System.Windows.Forms.ComboBox();
            this.cbxHead = new System.Windows.Forms.ComboBox();
            this.cbxTail = new System.Windows.Forms.ComboBox();
            this.cbxCountHead = new System.Windows.Forms.ComboBox();
            this.cbxCountNumber = new System.Windows.Forms.ComboBox();
            this.cbxCountTail = new System.Windows.Forms.ComboBox();
            this.cbxBeforeText = new System.Windows.Forms.ComboBox();
            this.cbxAfterText = new System.Windows.Forms.ComboBox();
            this.ckbChangeExt = new System.Windows.Forms.CheckBox();
            this.cbxChangeExt = new System.Windows.Forms.ComboBox();
            this.cbxPositionChangeEnd = new System.Windows.Forms.ComboBox();
            this.cbxPositionChangeStart = new System.Windows.Forms.ComboBox();
            this.lblPositionChangeEnd = new System.Windows.Forms.Label();
            this.ckbPositionChange = new System.Windows.Forms.CheckBox();
            this.lblPositionChangeStart = new System.Windows.Forms.Label();
            this.gpbPositionChange = new System.Windows.Forms.GroupBox();
            this.rdbPositionChangeFirst = new System.Windows.Forms.RadioButton();
            this.rdbPositionChangeLast = new System.Windows.Forms.RadioButton();
            this.ckbPositionChangeFirst = new System.Windows.Forms.CheckBox();
            this.ckbPositionChangeLast = new System.Windows.Forms.CheckBox();
            this.ckbTextChange = new System.Windows.Forms.CheckBox();
            this.gpbCount.SuspendLayout();
            this.gpbPositionChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(469, 13);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFolder.TabIndex = 20;
            this.btnFolder.Text = "폴더 선택";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // txtFileExt
            // 
            this.txtFileExt.Location = new System.Drawing.Point(13, 63);
            this.txtFileExt.Name = "txtFileExt";
            this.txtFileExt.Size = new System.Drawing.Size(76, 21);
            this.txtFileExt.TabIndex = 30;
            this.txtFileExt.Text = "*.*";
            this.txtFileExt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFileExt
            // 
            this.lblFileExt.AutoSize = true;
            this.lblFileExt.Location = new System.Drawing.Point(12, 48);
            this.lblFileExt.Name = "lblFileExt";
            this.lblFileExt.Size = new System.Drawing.Size(57, 12);
            this.lblFileExt.TabIndex = 2;
            this.lblFileExt.Text = "파일 형식";
            // 
            // cbxFileExt
            // 
            this.cbxFileExt.DisplayMember = "0";
            this.cbxFileExt.FormattingEnabled = true;
            this.cbxFileExt.Items.AddRange(new object[] {
            "*.*",
            "*.alz",
            "*.lzh",
            "*.rar",
            "*.z",
            "*.zip",
            "*.BMP",
            "*.GIF",
            "*.Ico",
            "*.JPEG",
            "*.PNG",
            "*.psd",
            "*.tif",
            "*.tiff",
            "*.WebP",
            "*.Tga",
            "*.alz;*.lzh;*.rar;*.z;*.zip;",
            "*.arw;*.BMP;*.cr2;*.crw;*.dng;*.GIF;*.icns;*.Ico;*.JPEG;*.mrw;*.nef;*.orf;*.pef;*" +
                ".PNG;*.ppm;*.psd;*.raf;*.raw;*.tif;*.tiff;*.WebP;*.x3f;*.xcf;",
            "*.AI;*.cdr;*.cgm;*.emf;*.SVG;*.vsd;*.wmf;"});
            this.cbxFileExt.Location = new System.Drawing.Point(95, 63);
            this.cbxFileExt.Name = "cbxFileExt";
            this.cbxFileExt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxFileExt.Size = new System.Drawing.Size(74, 20);
            this.cbxFileExt.TabIndex = 40;
            this.cbxFileExt.SelectedIndexChanged += new System.EventHandler(this.cbxFileExt_SelectedIndexChanged);
            // 
            // ckbSubfolders
            // 
            this.ckbSubfolders.AutoSize = true;
            this.ckbSubfolders.Location = new System.Drawing.Point(185, 63);
            this.ckbSubfolders.Name = "ckbSubfolders";
            this.ckbSubfolders.Size = new System.Drawing.Size(116, 16);
            this.ckbSubfolders.TabIndex = 50;
            this.ckbSubfolders.Text = "서브 폴더도 적용";
            this.ckbSubfolders.UseVisualStyleBackColor = true;
            // 
            // lblBeforeText
            // 
            this.lblBeforeText.AutoSize = true;
            this.lblBeforeText.Location = new System.Drawing.Point(11, 524);
            this.lblBeforeText.Name = "lblBeforeText";
            this.lblBeforeText.Size = new System.Drawing.Size(73, 12);
            this.lblBeforeText.TabIndex = 20;
            this.lblBeforeText.Text = "변경 전 문자";
            // 
            // lblAfterText
            // 
            this.lblAfterText.AutoSize = true;
            this.lblAfterText.Location = new System.Drawing.Point(12, 578);
            this.lblAfterText.Name = "lblAfterText";
            this.lblAfterText.Size = new System.Drawing.Size(77, 12);
            this.lblAfterText.TabIndex = 22;
            this.lblAfterText.Text = "변경 후 문자 ";
            // 
            // btnCalcel
            // 
            this.btnCalcel.Location = new System.Drawing.Point(373, 633);
            this.btnCalcel.Name = "btnCalcel";
            this.btnCalcel.Size = new System.Drawing.Size(75, 23);
            this.btnCalcel.TabIndex = 1020;
            this.btnCalcel.Text = "취소";
            this.btnCalcel.UseVisualStyleBackColor = true;
            this.btnCalcel.Click += new System.EventHandler(this.btnCalcel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(468, 633);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1030;
            this.btnOK.Text = "실행";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // fbdFolder
            // 
            this.fbdFolder.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Location = new System.Drawing.Point(11, 123);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(69, 12);
            this.lblHead.TabIndex = 9;
            this.lblHead.Text = "머릿말 달기";
            // 
            // ckbHead
            // 
            this.ckbHead.AutoSize = true;
            this.ckbHead.Location = new System.Drawing.Point(12, 100);
            this.ckbHead.Name = "ckbHead";
            this.ckbHead.Size = new System.Drawing.Size(88, 16);
            this.ckbHead.TabIndex = 80;
            this.ckbHead.Text = "머릿말 달기";
            this.ckbHead.UseVisualStyleBackColor = true;
            this.ckbHead.CheckedChanged += new System.EventHandler(this.ckbHead_CheckedChanged);
            // 
            // ckbTail
            // 
            this.ckbTail.AutoSize = true;
            this.ckbTail.Location = new System.Drawing.Point(12, 173);
            this.ckbTail.Name = "ckbTail";
            this.ckbTail.Size = new System.Drawing.Size(88, 16);
            this.ckbTail.TabIndex = 110;
            this.ckbTail.Text = "꼬릿말 달기";
            this.ckbTail.UseVisualStyleBackColor = true;
            this.ckbTail.CheckedChanged += new System.EventHandler(this.ckbTail_CheckedChanged);
            // 
            // lblTail
            // 
            this.lblTail.AutoSize = true;
            this.lblTail.Location = new System.Drawing.Point(11, 196);
            this.lblTail.Name = "lblTail";
            this.lblTail.Size = new System.Drawing.Size(69, 12);
            this.lblTail.TabIndex = 10;
            this.lblTail.Text = "꼬릿말 달기";
            // 
            // ckbCount
            // 
            this.ckbCount.AutoSize = true;
            this.ckbCount.Location = new System.Drawing.Point(13, 247);
            this.ckbCount.Name = "ckbCount";
            this.ckbCount.Size = new System.Drawing.Size(60, 16);
            this.ckbCount.TabIndex = 130;
            this.ckbCount.Text = "카운트";
            this.ckbCount.UseVisualStyleBackColor = true;
            this.ckbCount.CheckedChanged += new System.EventHandler(this.ckbCount_CheckedChanged);
            // 
            // lblCountHead
            // 
            this.lblCountHead.AutoSize = true;
            this.lblCountHead.Location = new System.Drawing.Point(11, 276);
            this.lblCountHead.Name = "lblCountHead";
            this.lblCountHead.Size = new System.Drawing.Size(81, 12);
            this.lblCountHead.TabIndex = 16;
            this.lblCountHead.Text = "카운트 머릿말";
            // 
            // rdbHead
            // 
            this.rdbHead.AutoSize = true;
            this.rdbHead.Location = new System.Drawing.Point(6, 11);
            this.rdbHead.Name = "rdbHead";
            this.rdbHead.Size = new System.Drawing.Size(75, 16);
            this.rdbHead.TabIndex = 140;
            this.rdbHead.TabStop = true;
            this.rdbHead.Text = "앞에 달기";
            this.rdbHead.UseVisualStyleBackColor = true;
            // 
            // rdbTail
            // 
            this.rdbTail.AutoSize = true;
            this.rdbTail.Checked = true;
            this.rdbTail.Location = new System.Drawing.Point(87, 11);
            this.rdbTail.Name = "rdbTail";
            this.rdbTail.Size = new System.Drawing.Size(75, 16);
            this.rdbTail.TabIndex = 150;
            this.rdbTail.TabStop = true;
            this.rdbTail.Text = "뒤에 달기";
            this.rdbTail.UseVisualStyleBackColor = true;
            // 
            // lblCountTail
            // 
            this.lblCountTail.AutoSize = true;
            this.lblCountTail.Location = new System.Drawing.Point(11, 319);
            this.lblCountTail.Name = "lblCountTail";
            this.lblCountTail.Size = new System.Drawing.Size(81, 12);
            this.lblCountTail.TabIndex = 18;
            this.lblCountTail.Text = "카운트 꼬릿말";
            // 
            // gpbCount
            // 
            this.gpbCount.Controls.Add(this.rdbHead);
            this.gpbCount.Controls.Add(this.rdbTail);
            this.gpbCount.Enabled = false;
            this.gpbCount.Location = new System.Drawing.Point(116, 238);
            this.gpbCount.Name = "gpbCount";
            this.gpbCount.Size = new System.Drawing.Size(168, 35);
            this.gpbCount.TabIndex = 25;
            this.gpbCount.TabStop = false;
            // 
            // lblCountNumber
            // 
            this.lblCountNumber.AutoSize = true;
            this.lblCountNumber.Location = new System.Drawing.Point(306, 252);
            this.lblCountNumber.Name = "lblCountNumber";
            this.lblCountNumber.Size = new System.Drawing.Size(81, 12);
            this.lblCountNumber.TabIndex = 14;
            this.lblCountNumber.Text = "카운트 자릿수";
            // 
            // cbxFolder
            // 
            this.cbxFolder.FormattingEnabled = true;
            this.cbxFolder.Location = new System.Drawing.Point(14, 13);
            this.cbxFolder.Name = "cbxFolder";
            this.cbxFolder.Size = new System.Drawing.Size(434, 20);
            this.cbxFolder.TabIndex = 10;
            // 
            // cbxHead
            // 
            this.cbxHead.Enabled = false;
            this.cbxHead.FormattingEnabled = true;
            this.cbxHead.Location = new System.Drawing.Point(12, 139);
            this.cbxHead.Name = "cbxHead";
            this.cbxHead.Size = new System.Drawing.Size(531, 20);
            this.cbxHead.TabIndex = 100;
            // 
            // cbxTail
            // 
            this.cbxTail.Enabled = false;
            this.cbxTail.FormattingEnabled = true;
            this.cbxTail.Location = new System.Drawing.Point(12, 211);
            this.cbxTail.Name = "cbxTail";
            this.cbxTail.Size = new System.Drawing.Size(531, 20);
            this.cbxTail.TabIndex = 12;
            // 
            // cbxCountHead
            // 
            this.cbxCountHead.Enabled = false;
            this.cbxCountHead.FormattingEnabled = true;
            this.cbxCountHead.Location = new System.Drawing.Point(12, 291);
            this.cbxCountHead.Name = "cbxCountHead";
            this.cbxCountHead.Size = new System.Drawing.Size(531, 20);
            this.cbxCountHead.TabIndex = 170;
            // 
            // cbxCountNumber
            // 
            this.cbxCountNumber.Enabled = false;
            this.cbxCountNumber.FormattingEnabled = true;
            this.cbxCountNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxCountNumber.Location = new System.Drawing.Point(393, 249);
            this.cbxCountNumber.Name = "cbxCountNumber";
            this.cbxCountNumber.Size = new System.Drawing.Size(56, 20);
            this.cbxCountNumber.TabIndex = 160;
            // 
            // cbxCountTail
            // 
            this.cbxCountTail.Enabled = false;
            this.cbxCountTail.FormattingEnabled = true;
            this.cbxCountTail.Location = new System.Drawing.Point(12, 334);
            this.cbxCountTail.Name = "cbxCountTail";
            this.cbxCountTail.Size = new System.Drawing.Size(531, 20);
            this.cbxCountTail.TabIndex = 180;
            // 
            // cbxBeforeText
            // 
            this.cbxBeforeText.FormattingEnabled = true;
            this.cbxBeforeText.Location = new System.Drawing.Point(13, 539);
            this.cbxBeforeText.Name = "cbxBeforeText";
            this.cbxBeforeText.Size = new System.Drawing.Size(531, 20);
            this.cbxBeforeText.TabIndex = 1000;
            // 
            // cbxAfterText
            // 
            this.cbxAfterText.FormattingEnabled = true;
            this.cbxAfterText.Location = new System.Drawing.Point(12, 593);
            this.cbxAfterText.Name = "cbxAfterText";
            this.cbxAfterText.Size = new System.Drawing.Size(531, 20);
            this.cbxAfterText.TabIndex = 1010;
            // 
            // ckbChangeExt
            // 
            this.ckbChangeExt.AutoSize = true;
            this.ckbChangeExt.Location = new System.Drawing.Point(318, 63);
            this.ckbChangeExt.Name = "ckbChangeExt";
            this.ckbChangeExt.Size = new System.Drawing.Size(88, 16);
            this.ckbChangeExt.TabIndex = 60;
            this.ckbChangeExt.Text = "확장자 변경";
            this.ckbChangeExt.UseVisualStyleBackColor = true;
            this.ckbChangeExt.CheckedChanged += new System.EventHandler(this.ckbChangeExt_CheckedChanged);
            // 
            // cbxChangeExt
            // 
            this.cbxChangeExt.Enabled = false;
            this.cbxChangeExt.FormattingEnabled = true;
            this.cbxChangeExt.Items.AddRange(new object[] {
            "alz",
            "lzh",
            "rar",
            "z",
            "zip",
            "BMP",
            "GIF",
            "Ico",
            "JPEG",
            "PNG",
            "psd",
            "tif",
            "tiff",
            "WebP",
            "Tga"});
            this.cbxChangeExt.Location = new System.Drawing.Point(413, 58);
            this.cbxChangeExt.Name = "cbxChangeExt";
            this.cbxChangeExt.Size = new System.Drawing.Size(121, 20);
            this.cbxChangeExt.TabIndex = 70;
            // 
            // cbxPositionChangeEnd
            // 
            this.cbxPositionChangeEnd.Enabled = false;
            this.cbxPositionChangeEnd.FormattingEnabled = true;
            this.cbxPositionChangeEnd.Location = new System.Drawing.Point(11, 458);
            this.cbxPositionChangeEnd.Name = "cbxPositionChangeEnd";
            this.cbxPositionChangeEnd.Size = new System.Drawing.Size(531, 20);
            this.cbxPositionChangeEnd.TabIndex = 230;
            // 
            // cbxPositionChangeStart
            // 
            this.cbxPositionChangeStart.Enabled = false;
            this.cbxPositionChangeStart.FormattingEnabled = true;
            this.cbxPositionChangeStart.Location = new System.Drawing.Point(11, 415);
            this.cbxPositionChangeStart.Name = "cbxPositionChangeStart";
            this.cbxPositionChangeStart.Size = new System.Drawing.Size(531, 20);
            this.cbxPositionChangeStart.TabIndex = 220;
            // 
            // lblPositionChangeEnd
            // 
            this.lblPositionChangeEnd.AutoSize = true;
            this.lblPositionChangeEnd.Location = new System.Drawing.Point(10, 443);
            this.lblPositionChangeEnd.Name = "lblPositionChangeEnd";
            this.lblPositionChangeEnd.Size = new System.Drawing.Size(73, 12);
            this.lblPositionChangeEnd.TabIndex = 31;
            this.lblPositionChangeEnd.Text = "구간 위치 끝";
            // 
            // ckbPositionChange
            // 
            this.ckbPositionChange.AutoSize = true;
            this.ckbPositionChange.Location = new System.Drawing.Point(12, 371);
            this.ckbPositionChange.Name = "ckbPositionChange";
            this.ckbPositionChange.Size = new System.Drawing.Size(104, 16);
            this.ckbPositionChange.TabIndex = 190;
            this.ckbPositionChange.Text = "구간 위치 변경";
            this.ckbPositionChange.UseVisualStyleBackColor = true;
            this.ckbPositionChange.CheckedChanged += new System.EventHandler(this.ckbPositionChange_CheckedChanged);
            // 
            // lblPositionChangeStart
            // 
            this.lblPositionChangeStart.AutoSize = true;
            this.lblPositionChangeStart.Location = new System.Drawing.Point(10, 400);
            this.lblPositionChangeStart.Name = "lblPositionChangeStart";
            this.lblPositionChangeStart.Size = new System.Drawing.Size(85, 12);
            this.lblPositionChangeStart.TabIndex = 28;
            this.lblPositionChangeStart.Text = "구간 위치 시작";
            // 
            // gpbPositionChange
            // 
            this.gpbPositionChange.Controls.Add(this.rdbPositionChangeFirst);
            this.gpbPositionChange.Controls.Add(this.rdbPositionChangeLast);
            this.gpbPositionChange.Enabled = false;
            this.gpbPositionChange.Location = new System.Drawing.Point(122, 360);
            this.gpbPositionChange.Name = "gpbPositionChange";
            this.gpbPositionChange.Size = new System.Drawing.Size(168, 35);
            this.gpbPositionChange.TabIndex = 195;
            this.gpbPositionChange.TabStop = false;
            // 
            // rdbPositionChangeFirst
            // 
            this.rdbPositionChangeFirst.AutoSize = true;
            this.rdbPositionChangeFirst.Location = new System.Drawing.Point(6, 11);
            this.rdbPositionChangeFirst.Name = "rdbPositionChangeFirst";
            this.rdbPositionChangeFirst.Size = new System.Drawing.Size(59, 16);
            this.rdbPositionChangeFirst.TabIndex = 200;
            this.rdbPositionChangeFirst.TabStop = true;
            this.rdbPositionChangeFirst.Text = "앞으로";
            this.rdbPositionChangeFirst.UseVisualStyleBackColor = true;
            // 
            // rdbPositionChangeLast
            // 
            this.rdbPositionChangeLast.AutoSize = true;
            this.rdbPositionChangeLast.Checked = true;
            this.rdbPositionChangeLast.Location = new System.Drawing.Point(87, 11);
            this.rdbPositionChangeLast.Name = "rdbPositionChangeLast";
            this.rdbPositionChangeLast.Size = new System.Drawing.Size(47, 16);
            this.rdbPositionChangeLast.TabIndex = 210;
            this.rdbPositionChangeLast.TabStop = true;
            this.rdbPositionChangeLast.Text = "뒤로";
            this.rdbPositionChangeLast.UseVisualStyleBackColor = true;
            // 
            // ckbPositionChangeFirst
            // 
            this.ckbPositionChangeFirst.AutoSize = true;
            this.ckbPositionChangeFirst.Enabled = false;
            this.ckbPositionChangeFirst.Location = new System.Drawing.Point(318, 371);
            this.ckbPositionChangeFirst.Name = "ckbPositionChangeFirst";
            this.ckbPositionChangeFirst.Size = new System.Drawing.Size(60, 16);
            this.ckbPositionChangeFirst.TabIndex = 213;
            this.ckbPositionChangeFirst.Text = "머리말";
            this.ckbPositionChangeFirst.UseVisualStyleBackColor = true;
            this.ckbPositionChangeFirst.CheckedChanged += new System.EventHandler(this.ckbPositionChangeFirst_CheckedChanged);
            // 
            // ckbPositionChangeLast
            // 
            this.ckbPositionChangeLast.AutoSize = true;
            this.ckbPositionChangeLast.Enabled = false;
            this.ckbPositionChangeLast.Location = new System.Drawing.Point(389, 371);
            this.ckbPositionChangeLast.Name = "ckbPositionChangeLast";
            this.ckbPositionChangeLast.Size = new System.Drawing.Size(48, 16);
            this.ckbPositionChangeLast.TabIndex = 216;
            this.ckbPositionChangeLast.Text = "끝말";
            this.ckbPositionChangeLast.UseVisualStyleBackColor = true;
            this.ckbPositionChangeLast.CheckedChanged += new System.EventHandler(this.ckbPositionChangeLast_CheckedChanged);
            // 
            // ckbTextChange
            // 
            this.ckbTextChange.AutoSize = true;
            this.ckbTextChange.Checked = true;
            this.ckbTextChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbTextChange.Location = new System.Drawing.Point(11, 496);
            this.ckbTextChange.Name = "ckbTextChange";
            this.ckbTextChange.Size = new System.Drawing.Size(76, 16);
            this.ckbTextChange.TabIndex = 950;
            this.ckbTextChange.Text = "문자 변경";
            this.ckbTextChange.UseVisualStyleBackColor = true;
            this.ckbTextChange.CheckedChanged += new System.EventHandler(this.ckbTextChange_CheckedChanged);
            // 
            // ChangeName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 742);
            this.Controls.Add(this.ckbTextChange);
            this.Controls.Add(this.ckbPositionChangeLast);
            this.Controls.Add(this.ckbPositionChangeFirst);
            this.Controls.Add(this.gpbPositionChange);
            this.Controls.Add(this.cbxPositionChangeEnd);
            this.Controls.Add(this.cbxPositionChangeStart);
            this.Controls.Add(this.lblPositionChangeEnd);
            this.Controls.Add(this.ckbPositionChange);
            this.Controls.Add(this.lblPositionChangeStart);
            this.Controls.Add(this.cbxChangeExt);
            this.Controls.Add(this.ckbChangeExt);
            this.Controls.Add(this.cbxAfterText);
            this.Controls.Add(this.cbxBeforeText);
            this.Controls.Add(this.cbxCountTail);
            this.Controls.Add(this.cbxCountNumber);
            this.Controls.Add(this.cbxCountHead);
            this.Controls.Add(this.cbxTail);
            this.Controls.Add(this.cbxHead);
            this.Controls.Add(this.cbxFolder);
            this.Controls.Add(this.lblCountNumber);
            this.Controls.Add(this.gpbCount);
            this.Controls.Add(this.lblCountTail);
            this.Controls.Add(this.ckbCount);
            this.Controls.Add(this.lblCountHead);
            this.Controls.Add(this.ckbTail);
            this.Controls.Add(this.lblTail);
            this.Controls.Add(this.ckbHead);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCalcel);
            this.Controls.Add(this.lblAfterText);
            this.Controls.Add(this.lblBeforeText);
            this.Controls.Add(this.ckbSubfolders);
            this.Controls.Add(this.cbxFileExt);
            this.Controls.Add(this.lblFileExt);
            this.Controls.Add(this.txtFileExt);
            this.Controls.Add(this.btnFolder);
            this.Name = "ChangeName";
            this.Text = "간단한 이름 바꾸기 툴";
            this.gpbCount.ResumeLayout(false);
            this.gpbCount.PerformLayout();
            this.gpbPositionChange.ResumeLayout(false);
            this.gpbPositionChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.TextBox txtFileExt;
        private System.Windows.Forms.Label lblFileExt;
        private System.Windows.Forms.ComboBox cbxFileExt;
        private System.Windows.Forms.CheckBox ckbSubfolders;
        private System.Windows.Forms.Label lblBeforeText;
        private System.Windows.Forms.Label lblAfterText;
        private System.Windows.Forms.Button btnCalcel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.CheckBox ckbHead;
        private System.Windows.Forms.CheckBox ckbTail;
        private System.Windows.Forms.Label lblTail;
        private System.Windows.Forms.CheckBox ckbCount;
        private System.Windows.Forms.Label lblCountHead;
        private System.Windows.Forms.RadioButton rdbHead;
        private System.Windows.Forms.RadioButton rdbTail;
        private System.Windows.Forms.Label lblCountTail;
        private System.Windows.Forms.GroupBox gpbCount;
        private System.Windows.Forms.Label lblCountNumber;
        private System.Windows.Forms.ComboBox cbxFolder;
        private System.Windows.Forms.ComboBox cbxHead;
        private System.Windows.Forms.ComboBox cbxTail;
        private System.Windows.Forms.ComboBox cbxCountHead;
        private System.Windows.Forms.ComboBox cbxCountNumber;
        private System.Windows.Forms.ComboBox cbxCountTail;
        private System.Windows.Forms.ComboBox cbxBeforeText;
        private System.Windows.Forms.ComboBox cbxAfterText;
        private System.Windows.Forms.CheckBox ckbChangeExt;
        private System.Windows.Forms.ComboBox cbxChangeExt;
        private System.Windows.Forms.ComboBox cbxPositionChangeEnd;
        private System.Windows.Forms.ComboBox cbxPositionChangeStart;
        private System.Windows.Forms.Label lblPositionChangeEnd;
        private System.Windows.Forms.CheckBox ckbPositionChange;
        private System.Windows.Forms.Label lblPositionChangeStart;
        private System.Windows.Forms.GroupBox gpbPositionChange;
        private System.Windows.Forms.RadioButton rdbPositionChangeFirst;
        private System.Windows.Forms.RadioButton rdbPositionChangeLast;
        private System.Windows.Forms.CheckBox ckbPositionChangeFirst;
        private System.Windows.Forms.CheckBox ckbPositionChangeLast;
        private System.Windows.Forms.CheckBox ckbTextChange;
    }
}

