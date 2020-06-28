namespace WindowsFormsApp2
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.ObjectBox = new System.Windows.Forms.ListBox();
            this.CategoryBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GenderBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eaterBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.foodList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.addStaffBtn = new System.Windows.Forms.Button();
            this.addFoodBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenText = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAsTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAsBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.hhToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileXML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileXMLImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileXMLExport = new System.Windows.Forms.ToolStripMenuItem();
            this.eeToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.ObjectBox);
            this.groupBox1.Controls.Add(this.CategoryBox);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal specifications";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Animal object";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 22);
            this.textBox1.TabIndex = 4;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(394, 200);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(188, 65);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add this new animal";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ObjectBox
            // 
            this.ObjectBox.FormattingEnabled = true;
            this.ObjectBox.ItemHeight = 16;
            this.ObjectBox.Location = new System.Drawing.Point(393, 47);
            this.ObjectBox.Name = "ObjectBox";
            this.ObjectBox.Size = new System.Drawing.Size(188, 148);
            this.ObjectBox.TabIndex = 2;
            this.ObjectBox.SelectedIndexChanged += new System.EventHandler(this.ObjectBox_SelectedIndexChanged);
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.ItemHeight = 16;
            this.CategoryBox.Location = new System.Drawing.Point(212, 47);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(175, 148);
            this.CategoryBox.TabIndex = 1;
            this.CategoryBox.SelectedIndexChanged += new System.EventHandler(this.CategoryBox_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(6, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(381, 81);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mammal Specifications";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tail length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "No. of teeth";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(206, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(169, 22);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 22);
            this.textBox3.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GenderBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 95);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gender";
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.ItemHeight = 16;
            this.GenderBox.Location = new System.Drawing.Point(9, 21);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(185, 68);
            this.GenderBox.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eaterBox);
            this.groupBox2.Controls.Add(this.deleteBtn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.foodList);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.infoBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1157, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of registered animals";
            // 
            // eaterBox
            // 
            this.eaterBox.BackColor = System.Drawing.SystemColors.Control;
            this.eaterBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eaterBox.ForeColor = System.Drawing.Color.Green;
            this.eaterBox.Location = new System.Drawing.Point(761, 22);
            this.eaterBox.Name = "eaterBox";
            this.eaterBox.Size = new System.Drawing.Size(390, 31);
            this.eaterBox.TabIndex = 3;
            // 
            // deleteBtn
            // 
            this.deleteBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.deleteBtn.Location = new System.Drawing.Point(329, 162);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(350, 34);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(682, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Eater type";
            // 
            // foodList
            // 
            this.foodList.BackColor = System.Drawing.SystemColors.Control;
            this.foodList.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodList.ForeColor = System.Drawing.Color.Green;
            this.foodList.FormattingEnabled = true;
            this.foodList.ItemHeight = 23;
            this.foodList.Location = new System.Drawing.Point(685, 53);
            this.foodList.Name = "foodList";
            this.foodList.Size = new System.Drawing.Size(466, 96);
            this.foodList.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "ID     Name     Age     Gender     Specials characteristics";
            // 
            // infoBox
            // 
            this.infoBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox.FormattingEnabled = true;
            this.infoBox.ItemHeight = 23;
            this.infoBox.Location = new System.Drawing.Point(6, 53);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(673, 96);
            this.infoBox.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.addStaffBtn);
            this.groupBox5.Controls.Add(this.addFoodBtn);
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Location = new System.Drawing.Point(612, 49);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(557, 256);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Food details";
            // 
            // addStaffBtn
            // 
            this.addStaffBtn.Location = new System.Drawing.Point(6, 90);
            this.addStaffBtn.Name = "addStaffBtn";
            this.addStaffBtn.Size = new System.Drawing.Size(109, 42);
            this.addStaffBtn.TabIndex = 10;
            this.addStaffBtn.Text = "Add staff";
            this.addStaffBtn.UseVisualStyleBackColor = true;
            this.addStaffBtn.Click += new System.EventHandler(this.addStaffBtn_Click);
            // 
            // addFoodBtn
            // 
            this.addFoodBtn.Location = new System.Drawing.Point(6, 38);
            this.addFoodBtn.Name = "addFoodBtn";
            this.addFoodBtn.Size = new System.Drawing.Size(109, 42);
            this.addFoodBtn.TabIndex = 9;
            this.addFoodBtn.Text = "Add food";
            this.addFoodBtn.UseVisualStyleBackColor = true;
            this.addFoodBtn.Click += new System.EventHandler(this.addFoodBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(121, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(430, 211);
            this.listBox1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.hhToolStripMenuItem,
            this.mnuFileXML,
            this.eeToolStripMenuItem,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(224, 26);
            this.mnuFileNew.Text = "New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpenBinary,
            this.mnuFileOpenText});
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(224, 26);
            this.mnuFileOpen.Text = "Open...";
            // 
            // mnuFileOpenBinary
            // 
            this.mnuFileOpenBinary.Name = "mnuFileOpenBinary";
            this.mnuFileOpenBinary.Size = new System.Drawing.Size(160, 26);
            this.mnuFileOpenBinary.Text = "Binary File";
            this.mnuFileOpenBinary.Click += new System.EventHandler(this.mnuFileOpenBinary_Click);
            // 
            // mnuFileOpenText
            // 
            this.mnuFileOpenText.Name = "mnuFileOpenText";
            this.mnuFileOpenText.Size = new System.Drawing.Size(160, 26);
            this.mnuFileOpenText.Text = "Text File";
            this.mnuFileOpenText.Click += new System.EventHandler(this.mnuFileOpenText_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(224, 26);
            this.mnuFileSave.Text = "Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileSaveAsTextFile,
            this.mnuFileSaveAsBinary});
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(224, 26);
            this.mnuFileSaveAs.Text = "Save As...";
            // 
            // mnuFileSaveAsTextFile
            // 
            this.mnuFileSaveAsTextFile.Name = "mnuFileSaveAsTextFile";
            this.mnuFileSaveAsTextFile.Size = new System.Drawing.Size(160, 26);
            this.mnuFileSaveAsTextFile.Text = "Text File";
            this.mnuFileSaveAsTextFile.Click += new System.EventHandler(this.mnuFileSaveAsTextFile_Click);
            // 
            // mnuFileSaveAsBinary
            // 
            this.mnuFileSaveAsBinary.Name = "mnuFileSaveAsBinary";
            this.mnuFileSaveAsBinary.Size = new System.Drawing.Size(160, 26);
            this.mnuFileSaveAsBinary.Text = "Binary File";
            this.mnuFileSaveAsBinary.Click += new System.EventHandler(this.mnuFileSaveAsBinary_Click);
            // 
            // hhToolStripMenuItem
            // 
            this.hhToolStripMenuItem.Name = "hhToolStripMenuItem";
            this.hhToolStripMenuItem.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuFileXML
            // 
            this.mnuFileXML.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileXMLImport,
            this.mnuFileXMLExport});
            this.mnuFileXML.Name = "mnuFileXML";
            this.mnuFileXML.Size = new System.Drawing.Size(224, 26);
            this.mnuFileXML.Text = "XML";
            // 
            // mnuFileXMLImport
            // 
            this.mnuFileXMLImport.Name = "mnuFileXMLImport";
            this.mnuFileXMLImport.Size = new System.Drawing.Size(233, 26);
            this.mnuFileXMLImport.Text = "Import from XML File";
            this.mnuFileXMLImport.Click += new System.EventHandler(this.mnuFileXMLImport_Click);
            // 
            // mnuFileXMLExport
            // 
            this.mnuFileXMLExport.Name = "mnuFileXMLExport";
            this.mnuFileXMLExport.Size = new System.Drawing.Size(233, 26);
            this.mnuFileXMLExport.Text = "Export to XML File";
            this.mnuFileXMLExport.Click += new System.EventHandler(this.mnuFileXMLExport_Click);
            // 
            // eeToolStripMenuItem
            // 
            this.eeToolStripMenuItem.Name = "eeToolStripMenuItem";
            this.eeToolStripMenuItem.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.mnuFileExit.Size = new System.Drawing.Size(224, 26);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 527);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Apu\'s Animal Hotel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox ObjectBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox GenderBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox infoBox;
        private System.Windows.Forms.ListBox CategoryBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox foodList;
        private System.Windows.Forms.TextBox eaterBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button addStaffBtn;
        private System.Windows.Forms.Button addFoodBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator hhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileXML;
        private System.Windows.Forms.ToolStripSeparator eeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAsTextFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAsBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuFileXMLImport;
        private System.Windows.Forms.ToolStripMenuItem mnuFileXMLExport;
    }
}

