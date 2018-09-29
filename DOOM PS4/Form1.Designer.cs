namespace PS4_Debugger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cnct = new System.Windows.Forms.Button();
            this.atch = new System.Windows.Forms.Button();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._val = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._BP = new System.Windows.Forms.CheckBox();
            this.eView = new System.Windows.Forms.CheckBox();
            this.DisassemblyTextBox = new System.Windows.Forms.TextBox();
            this._wp = new System.Windows.Forms.RadioButton();
            this.@__bp = new System.Windows.Forms.RadioButton();
            this.WPLength = new System.Windows.Forms.ComboBox();
            this.WPType = new System.Windows.Forms.ComboBox();
            this.dView = new System.Windows.Forms.CheckBox();
            this.mView = new System.Windows.Forms.CheckBox();
            this._peek = new System.Windows.Forms.Button();
            this.DebugLayout = new System.Windows.Forms.TableLayoutPanel();
            this.hexCode = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.offsetsText = new System.Windows.Forms.RichTextBox();
            this.asciiText = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.aFresh = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.jumpoff = new System.Windows.Forms.Label();
            this.jumpbox = new System.Windows.Forms.TextBox();
            this.offsetTxt = new System.Windows.Forms.TextBox();
            this.writebox = new System.Windows.Forms.TextBox();
            this.jumpminus = new System.Windows.Forms.Button();
            this.jumpplus = new System.Windows.Forms.Button();
            this.writebyte = new System.Windows.Forms.Button();
            this.binput = new System.Windows.Forms.Label();
            this.seloff = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this._asm = new System.Windows.Forms.Button();
            this._asmBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this._li = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._asmCaveBox = new System.Windows.Forms.TextBox();
            this.cBox = new System.Windows.Forms.TextBox();
            this.stBox = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.RGLogo = new System.Windows.Forms.PictureBox();
            this.Cain532 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DebugLayout.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cain532)).BeginInit();
            this.SuspendLayout();
            // 
            // cnct
            // 
            this.cnct.Enabled = false;
            this.cnct.Location = new System.Drawing.Point(16, 38);
            this.cnct.Name = "cnct";
            this.cnct.Size = new System.Drawing.Size(121, 23);
            this.cnct.TabIndex = 0;
            this.cnct.Text = "Connect";
            this.cnct.UseVisualStyleBackColor = true;
            this.cnct.Click += new System.EventHandler(this.button1_Click);
            // 
            // atch
            // 
            this.atch.Enabled = false;
            this.atch.Location = new System.Drawing.Point(150, 38);
            this.atch.Name = "atch";
            this.atch.Size = new System.Drawing.Size(121, 23);
            this.atch.TabIndex = 6;
            this.atch.Text = "Attach";
            this.atch.UseVisualStyleBackColor = true;
            this.atch.Click += new System.EventHandler(this.button4_Click);
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(12, 12);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(259, 20);
            this.IPBox.TabIndex = 8;
            this.IPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IPBox.TextChanged += new System.EventHandler(this.IPBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(304, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Never Stop";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(304, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "▶";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Process_Clicky);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextBox.Location = new System.Drawing.Point(181, 109);
            this.AddressTextBox.MaxLength = 16;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(108, 23);
            this.AddressTextBox.TabIndex = 15;
            this.AddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.dasAddress_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._reg,
            this._val});
            this.dataGridView1.Location = new System.Drawing.Point(16, 162);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(273, 293);
            this.dataGridView1.TabIndex = 16;
            // 
            // _reg
            // 
            this._reg.HeaderText = "Registers";
            this._reg.MaxInputLength = 6;
            this._reg.Name = "_reg";
            this._reg.ReadOnly = true;
            this._reg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._reg.Width = 76;
            // 
            // _val
            // 
            this._val.HeaderText = "Value";
            this._val.Name = "_val";
            this._val.Width = 59;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // _BP
            // 
            this._BP.AutoSize = true;
            this._BP.Location = new System.Drawing.Point(160, 112);
            this._BP.Name = "_BP";
            this._BP.Size = new System.Drawing.Size(15, 14);
            this._BP.TabIndex = 18;
            this._BP.UseVisualStyleBackColor = true;
            this._BP.CheckedChanged += new System.EventHandler(this._BP_CheckedChanged);
            // 
            // eView
            // 
            this.eView.AutoSize = true;
            this.eView.Location = new System.Drawing.Point(59, 9);
            this.eView.Name = "eView";
            this.eView.Size = new System.Drawing.Size(15, 14);
            this.eView.TabIndex = 20;
            this.eView.UseVisualStyleBackColor = true;
            // 
            // DisassemblyTextBox
            // 
            this.DisassemblyTextBox.BackColor = System.Drawing.Color.Black;
            this.DisassemblyTextBox.Font = new System.Drawing.Font("Verdana", 11F);
            this.DisassemblyTextBox.ForeColor = System.Drawing.Color.White;
            this.DisassemblyTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DisassemblyTextBox.Location = new System.Drawing.Point(586, 133);
            this.DisassemblyTextBox.Multiline = true;
            this.DisassemblyTextBox.Name = "DisassemblyTextBox";
            this.DisassemblyTextBox.ReadOnly = true;
            this.DisassemblyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisassemblyTextBox.Size = new System.Drawing.Size(792, 322);
            this.DisassemblyTextBox.TabIndex = 0;
            this.DisassemblyTextBox.WordWrap = false;
            // 
            // _wp
            // 
            this._wp.AutoSize = true;
            this._wp.Location = new System.Drawing.Point(16, 112);
            this._wp.Name = "_wp";
            this._wp.Size = new System.Drawing.Size(43, 17);
            this._wp.TabIndex = 22;
            this._wp.Text = "WP";
            this._wp.UseVisualStyleBackColor = true;
            // 
            // __bp
            // 
            this.@__bp.AutoSize = true;
            this.@__bp.Checked = true;
            this.@__bp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.@__bp.Location = new System.Drawing.Point(109, 110);
            this.@__bp.Name = "__bp";
            this.@__bp.Size = new System.Drawing.Size(45, 18);
            this.@__bp.TabIndex = 23;
            this.@__bp.TabStop = true;
            this.@__bp.Text = "BP";
            this.@__bp.UseVisualStyleBackColor = true;
            // 
            // WPLength
            // 
            this.WPLength.FormattingEnabled = true;
            this.WPLength.Items.AddRange(new object[] {
            "1 byte",
            "2 bytes",
            "4 bytes",
            "8 bytes"});
            this.WPLength.Location = new System.Drawing.Point(168, 135);
            this.WPLength.Name = "WPLength";
            this.WPLength.Size = new System.Drawing.Size(121, 21);
            this.WPLength.TabIndex = 24;
            this.WPLength.Text = "4 bytes";
            // 
            // WPType
            // 
            this.WPType.FormattingEnabled = true;
            this.WPType.Items.AddRange(new object[] {
            "execute",
            "write",
            "read/write"});
            this.WPType.Location = new System.Drawing.Point(16, 135);
            this.WPType.Name = "WPType";
            this.WPType.Size = new System.Drawing.Size(121, 21);
            this.WPType.TabIndex = 25;
            this.WPType.Text = "write";
            // 
            // dView
            // 
            this.dView.AutoSize = true;
            this.dView.Checked = true;
            this.dView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dView.Location = new System.Drawing.Point(586, 110);
            this.dView.Name = "dView";
            this.dView.Size = new System.Drawing.Size(89, 17);
            this.dView.TabIndex = 26;
            this.dView.Text = "Dissassembly";
            this.dView.UseVisualStyleBackColor = true;
            this.dView.CheckedChanged += new System.EventHandler(this.Peeper);
            // 
            // mView
            // 
            this.mView.AutoSize = true;
            this.mView.Location = new System.Drawing.Point(680, 110);
            this.mView.Name = "mView";
            this.mView.Size = new System.Drawing.Size(63, 17);
            this.mView.TabIndex = 27;
            this.mView.Text = "Memory";
            this.mView.UseVisualStyleBackColor = true;
            this.mView.CheckedChanged += new System.EventHandler(this.Peeper);
            // 
            // _peek
            // 
            this._peek.Location = new System.Drawing.Point(6, 4);
            this._peek.Name = "_peek";
            this._peek.Size = new System.Drawing.Size(265, 71);
            this._peek.TabIndex = 28;
            this._peek.Text = "Refresh Memory";
            this._peek.UseVisualStyleBackColor = true;
            this._peek.Click += new System.EventHandler(this._peek_Click);
            // 
            // DebugLayout
            // 
            this.DebugLayout.BackColor = System.Drawing.Color.Transparent;
            this.DebugLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.DebugLayout.ColumnCount = 3;
            this.DebugLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.DebugLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 437F));
            this.DebugLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DebugLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DebugLayout.Controls.Add(this.hexCode, 1, 1);
            this.DebugLayout.Controls.Add(this.richTextBox4, 2, 0);
            this.DebugLayout.Controls.Add(this.richTextBox3, 1, 0);
            this.DebugLayout.Controls.Add(this.offsetsText, 0, 1);
            this.DebugLayout.Controls.Add(this.asciiText, 2, 1);
            this.DebugLayout.Controls.Add(this.richTextBox2, 0, 0);
            this.DebugLayout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DebugLayout.Location = new System.Drawing.Point(586, 135);
            this.DebugLayout.Margin = new System.Windows.Forms.Padding(0);
            this.DebugLayout.Name = "DebugLayout";
            this.DebugLayout.RowCount = 2;
            this.DebugLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.DebugLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DebugLayout.Size = new System.Drawing.Size(792, 322);
            this.DebugLayout.TabIndex = 29;
            this.DebugLayout.Visible = false;
            // 
            // hexCode
            // 
            this.hexCode.BackColor = System.Drawing.SystemColors.Control;
            this.hexCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hexCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexCode.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexCode.ForeColor = System.Drawing.Color.Blue;
            this.hexCode.Location = new System.Drawing.Point(161, 35);
            this.hexCode.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.hexCode.Name = "hexCode";
            this.hexCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.hexCode.Size = new System.Drawing.Size(429, 282);
            this.hexCode.TabIndex = 8;
            this.hexCode.Text = "";
            this.hexCode.Click += new System.EventHandler(this.hexCode_Click);
            this.hexCode.DoubleClick += new System.EventHandler(this.hexCode_DoubleClick);
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.ForeColor = System.Drawing.Color.ForestGreen;
            this.richTextBox4.Location = new System.Drawing.Point(598, 5);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(169, 22);
            this.richTextBox4.TabIndex = 12;
            this.richTextBox4.Text = "ASCII";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.ForestGreen;
            this.richTextBox3.Location = new System.Drawing.Point(159, 5);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(431, 22);
            this.richTextBox3.TabIndex = 11;
            this.richTextBox3.Text = "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F";
            // 
            // offsetsText
            // 
            this.offsetsText.BackColor = System.Drawing.SystemColors.Control;
            this.offsetsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.offsetsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offsetsText.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offsetsText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.offsetsText.Location = new System.Drawing.Point(5, 35);
            this.offsetsText.Name = "offsetsText";
            this.offsetsText.ReadOnly = true;
            this.offsetsText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.offsetsText.Size = new System.Drawing.Size(146, 282);
            this.offsetsText.TabIndex = 7;
            this.offsetsText.Text = "0x00000000";
            // 
            // asciiText
            // 
            this.asciiText.BackColor = System.Drawing.SystemColors.Control;
            this.asciiText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.asciiText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asciiText.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asciiText.Location = new System.Drawing.Point(598, 35);
            this.asciiText.Name = "asciiText";
            this.asciiText.Size = new System.Drawing.Size(189, 282);
            this.asciiText.TabIndex = 9;
            this.asciiText.Text = ".";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.ForestGreen;
            this.richTextBox2.Location = new System.Drawing.Point(5, 5);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 22);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "Offset";
            // 
            // aFresh
            // 
            this.aFresh.AutoSize = true;
            this.aFresh.Checked = true;
            this.aFresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aFresh.Location = new System.Drawing.Point(749, 110);
            this.aFresh.Name = "aFresh";
            this.aFresh.Size = new System.Drawing.Size(88, 17);
            this.aFresh.TabIndex = 30;
            this.aFresh.Text = "Auto Refresh";
            this.aFresh.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(348, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "❚❚";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Process_Clicky);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(392, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "■";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Process_Clicky);
            // 
            // jumpoff
            // 
            this.jumpoff.AutoSize = true;
            this.jumpoff.Location = new System.Drawing.Point(7, 216);
            this.jumpoff.Name = "jumpoff";
            this.jumpoff.Size = new System.Drawing.Size(38, 13);
            this.jumpoff.TabIndex = 43;
            this.jumpoff.Text = "Jump -";
            // 
            // jumpbox
            // 
            this.jumpbox.Enabled = false;
            this.jumpbox.Location = new System.Drawing.Point(10, 232);
            this.jumpbox.Name = "jumpbox";
            this.jumpbox.Size = new System.Drawing.Size(261, 20);
            this.jumpbox.TabIndex = 42;
            this.jumpbox.Text = "0x50";
            this.jumpbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jumpbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressTextBox_KeyPress);
            // 
            // offsetTxt
            // 
            this.offsetTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offsetTxt.Location = new System.Drawing.Point(10, 121);
            this.offsetTxt.MaxLength = 18;
            this.offsetTxt.Name = "offsetTxt";
            this.offsetTxt.Size = new System.Drawing.Size(261, 22);
            this.offsetTxt.TabIndex = 35;
            this.offsetTxt.Text = "0x00010000";
            this.offsetTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.offsetTxt.TextChanged += new System.EventHandler(this.dasAddress_TextChanged);
            this.offsetTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressTextBox_KeyPress);
            // 
            // writebox
            // 
            this.writebox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writebox.Location = new System.Drawing.Point(10, 162);
            this.writebox.Name = "writebox";
            this.writebox.Size = new System.Drawing.Size(261, 22);
            this.writebox.TabIndex = 36;
            this.writebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.writebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressTextBox_KeyPress);
            // 
            // jumpminus
            // 
            this.jumpminus.Location = new System.Drawing.Point(10, 258);
            this.jumpminus.Name = "jumpminus";
            this.jumpminus.Size = new System.Drawing.Size(121, 23);
            this.jumpminus.TabIndex = 41;
            this.jumpminus.Text = "-";
            this.jumpminus.UseVisualStyleBackColor = true;
            this.jumpminus.Click += new System.EventHandler(this.PlusMinus_Clicky);
            // 
            // jumpplus
            // 
            this.jumpplus.Location = new System.Drawing.Point(150, 258);
            this.jumpplus.Name = "jumpplus";
            this.jumpplus.Size = new System.Drawing.Size(121, 23);
            this.jumpplus.TabIndex = 40;
            this.jumpplus.Text = "+";
            this.jumpplus.UseVisualStyleBackColor = true;
            this.jumpplus.Click += new System.EventHandler(this.PlusMinus_Clicky);
            // 
            // writebyte
            // 
            this.writebyte.Location = new System.Drawing.Point(30, 190);
            this.writebyte.Name = "writebyte";
            this.writebyte.Size = new System.Drawing.Size(224, 23);
            this.writebyte.TabIndex = 34;
            this.writebyte.Text = "Write";
            this.writebyte.UseVisualStyleBackColor = true;
            this.writebyte.Click += new System.EventHandler(this.writebyte_Click);
            // 
            // binput
            // 
            this.binput.AutoSize = true;
            this.binput.Location = new System.Drawing.Point(7, 146);
            this.binput.Name = "binput";
            this.binput.Size = new System.Drawing.Size(55, 13);
            this.binput.TabIndex = 38;
            this.binput.Text = "Byte Input";
            // 
            // seloff
            // 
            this.seloff.AutoSize = true;
            this.seloff.Location = new System.Drawing.Point(7, 105);
            this.seloff.Name = "seloff";
            this.seloff.Size = new System.Drawing.Size(80, 13);
            this.seloff.TabIndex = 37;
            this.seloff.Text = "Selected Offset";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(295, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(285, 348);
            this.tabControl1.TabIndex = 44;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.jumpoff);
            this.tabPage1.Controls.Add(this.seloff);
            this.tabPage1.Controls.Add(this.jumpbox);
            this.tabPage1.Controls.Add(this.binput);
            this.tabPage1.Controls.Add(this._peek);
            this.tabPage1.Controls.Add(this.offsetTxt);
            this.tabPage1.Controls.Add(this.writebyte);
            this.tabPage1.Controls.Add(this.writebox);
            this.tabPage1.Controls.Add(this.jumpplus);
            this.tabPage1.Controls.Add(this.jumpminus);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(277, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Memory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sBox);
            this.tabPage2.Controls.Add(this.eView);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(277, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Seperator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sBox
            // 
            this.sBox.Location = new System.Drawing.Point(6, 39);
            this.sBox.Multiline = true;
            this.sBox.Name = "sBox";
            this.sBox.Size = new System.Drawing.Size(265, 277);
            this.sBox.TabIndex = 21;
            this.sBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sBox.Click += new System.EventHandler(this.sBox_Click);
            this.sBox.DoubleClick += new System.EventHandler(this.sBox_DoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this._asm);
            this.tabPage3.Controls.Add(this._asmBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(277, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Assembly";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // _asm
            // 
            this._asm.Location = new System.Drawing.Point(6, 281);
            this._asm.Name = "_asm";
            this._asm.Size = new System.Drawing.Size(265, 35);
            this._asm.TabIndex = 23;
            this._asm.Text = "Assemble";
            this._asm.UseVisualStyleBackColor = true;
            this._asm.Click += new System.EventHandler(this._asm_Click);
            // 
            // _asmBox
            // 
            this._asmBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._asmBox.Location = new System.Drawing.Point(6, 9);
            this._asmBox.Multiline = true;
            this._asmBox.Name = "_asmBox";
            this._asmBox.Size = new System.Drawing.Size(265, 266);
            this._asmBox.TabIndex = 22;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this._li);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this._asmCaveBox);
            this.tabPage4.Controls.Add(this.cBox);
            this.tabPage4.Controls.Add(this.stBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(277, 322);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Code Cave";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // _li
            // 
            this._li.AutoSize = true;
            this._li.Checked = true;
            this._li.CheckState = System.Windows.Forms.CheckState.Checked;
            this._li.Location = new System.Drawing.Point(6, 261);
            this._li.Name = "_li";
            this._li.Size = new System.Drawing.Size(135, 17);
            this._li.TabIndex = 48;
            this._li.Text = "Include Last instruction";
            this._li.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(265, 35);
            this.button4.TabIndex = 24;
            this.button4.Text = "Assemble";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cave Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Address";
            // 
            // _asmCaveBox
            // 
            this._asmCaveBox.Location = new System.Drawing.Point(6, 46);
            this._asmCaveBox.Multiline = true;
            this._asmCaveBox.Name = "_asmCaveBox";
            this._asmCaveBox.Size = new System.Drawing.Size(265, 209);
            this._asmCaveBox.TabIndex = 2;
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(146, 20);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(125, 20);
            this.cBox.TabIndex = 1;
            this.cBox.Text = "0x00010000";
            this.cBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressTextBox_KeyPress);
            // 
            // stBox
            // 
            this.stBox.Location = new System.Drawing.Point(6, 20);
            this.stBox.Name = "stBox";
            this.stBox.Size = new System.Drawing.Size(125, 20);
            this.stBox.TabIndex = 0;
            this.stBox.Text = "0x00010000";
            this.stBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressTextBox_KeyPress);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(277, 322);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(648, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 70);
            this.label1.TabIndex = 45;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // RGLogo
            // 
            this.RGLogo.BackgroundImage = global::PS4_Debugger.Properties.Resources.logo_dark;
            this.RGLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RGLogo.Location = new System.Drawing.Point(1309, 31);
            this.RGLogo.Name = "RGLogo";
            this.RGLogo.Size = new System.Drawing.Size(69, 69);
            this.RGLogo.TabIndex = 47;
            this.RGLogo.TabStop = false;
            this.RGLogo.Click += new System.EventHandler(this.RGLogo_Click);
            // 
            // Cain532
            // 
            this.Cain532.BackgroundImage = global::PS4_Debugger.Properties.Resources.Cain532;
            this.Cain532.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cain532.Location = new System.Drawing.Point(1211, 31);
            this.Cain532.Name = "Cain532";
            this.Cain532.Size = new System.Drawing.Size(69, 69);
            this.Cain532.TabIndex = 46;
            this.Cain532.TabStop = false;
            this.Cain532.Click += new System.EventHandler(this.Cain532_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(592, 137);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(760, 314);
            this.richTextBox1.TabIndex = 48;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1399, 466);
            this.Controls.Add(this.RGLogo);
            this.Controls.Add(this.Cain532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.aFresh);
            this.Controls.Add(this.mView);
            this.Controls.Add(this.dView);
            this.Controls.Add(this.WPType);
            this.Controls.Add(this.WPLength);
            this.Controls.Add(this.@__bp);
            this.Controls.Add(this._wp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this._BP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.atch);
            this.Controls.Add(this.cnct);
            this.Controls.Add(this.DebugLayout);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DisassemblyTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1415, 505);
            this.MinimumSize = new System.Drawing.Size(300, 120);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS4 Debugger - Cain532";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DebugLayout.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cain532)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cnct;
        private System.Windows.Forms.Button atch;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox _BP;
        private System.Windows.Forms.CheckBox eView;
        private System.Windows.Forms.TextBox DisassemblyTextBox;
        private System.Windows.Forms.RadioButton _wp;
        private System.Windows.Forms.RadioButton __bp;
        private System.Windows.Forms.ComboBox WPLength;
        private System.Windows.Forms.ComboBox WPType;
        private System.Windows.Forms.CheckBox dView;
        private System.Windows.Forms.CheckBox mView;
        private System.Windows.Forms.Button _peek;
        private System.Windows.Forms.TableLayoutPanel DebugLayout;
        private System.Windows.Forms.RichTextBox hexCode;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox offsetsText;
        private System.Windows.Forms.RichTextBox asciiText;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.CheckBox aFresh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label jumpoff;
        private System.Windows.Forms.TextBox jumpbox;
        private System.Windows.Forms.TextBox offsetTxt;
        private System.Windows.Forms.TextBox writebox;
        private System.Windows.Forms.Button jumpminus;
        private System.Windows.Forms.Button jumpplus;
        private System.Windows.Forms.Button writebyte;
        private System.Windows.Forms.Label binput;
        private System.Windows.Forms.Label seloff;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox sBox;
        private System.Windows.Forms.Button _asm;
        private System.Windows.Forms.TextBox _asmBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn _val;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Cain532;
        private System.Windows.Forms.PictureBox RGLogo;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _asmCaveBox;
        private System.Windows.Forms.TextBox cBox;
        private System.Windows.Forms.TextBox stBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox _li;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

