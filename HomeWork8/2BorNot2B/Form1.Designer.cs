
namespace _2BorNot2B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuFileNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuHelpAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDown = new System.Windows.Forms.Panel();
            this.listNumber = new System.Windows.Forms.NumericUpDown();
            this.lableInfoListNumber = new System.Windows.Forms.Label();
            this.buttonSaveToList = new System.Windows.Forms.Button();
            this.buttonDeletFromList = new System.Windows.Forms.Button();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.panelUp = new System.Windows.Forms.Panel();
            this.labelInfo2B = new System.Windows.Forms.Label();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.checkTrue = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picture = new System.Windows.Forms.PictureBox();
            this.textTag = new System.Windows.Forms.TextBox();
            this.toolStrip.SuspendLayout();
            this.panelDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listNumber)).BeginInit();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonFile,
            this.toolStripDropDownButtonHelp});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonFile
            // 
            this.toolStripDropDownButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNewFile,
            this.menuFileOpenFile,
            this.menuFileSaveFile,
            this.menuFileSaveAs,
            this.toolStripSeparator,
            this.menuFileExit});
            this.toolStripDropDownButtonFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFile.Image")));
            this.toolStripDropDownButtonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFile.Name = "toolStripDropDownButtonFile";
            this.toolStripDropDownButtonFile.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButtonFile.Text = "File";
            // 
            // menuFileNewFile
            // 
            this.menuFileNewFile.Name = "menuFileNewFile";
            this.menuFileNewFile.Size = new System.Drawing.Size(180, 22);
            this.menuFileNewFile.Text = "New file";
            this.menuFileNewFile.Click += new System.EventHandler(this.menuItemFileNew_Click);
            // 
            // menuFileOpenFile
            // 
            this.menuFileOpenFile.Name = "menuFileOpenFile";
            this.menuFileOpenFile.Size = new System.Drawing.Size(180, 22);
            this.menuFileOpenFile.Text = "Open file";
            this.menuFileOpenFile.Click += new System.EventHandler(this.menuFileOpenFile_Click);
            // 
            // menuFileSaveFile
            // 
            this.menuFileSaveFile.Name = "menuFileSaveFile";
            this.menuFileSaveFile.Size = new System.Drawing.Size(180, 22);
            this.menuFileSaveFile.Text = "Save file";
            this.menuFileSaveFile.Click += new System.EventHandler(this.menuFileSaveFile_Click);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(180, 22);
            this.menuFileSaveAs.Text = "Save As";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(180, 22);
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // toolStripDropDownButtonHelp
            // 
            this.toolStripDropDownButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAboutProgram});
            this.toolStripDropDownButtonHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonHelp.Image")));
            this.toolStripDropDownButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonHelp.Name = "toolStripDropDownButtonHelp";
            this.toolStripDropDownButtonHelp.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButtonHelp.Text = "Help";
            // 
            // menuHelpAboutProgram
            // 
            this.menuHelpAboutProgram.Name = "menuHelpAboutProgram";
            this.menuHelpAboutProgram.Size = new System.Drawing.Size(180, 22);
            this.menuHelpAboutProgram.Text = "About the program";
            this.menuHelpAboutProgram.Click += new System.EventHandler(this.menuHelpAboutProgram_Click);
            // 
            // panelDown
            // 
            this.panelDown.Controls.Add(this.listNumber);
            this.panelDown.Controls.Add(this.lableInfoListNumber);
            this.panelDown.Controls.Add(this.buttonSaveToList);
            this.panelDown.Controls.Add(this.buttonDeletFromList);
            this.panelDown.Controls.Add(this.buttonAddToList);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(0, 406);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(800, 44);
            this.panelDown.TabIndex = 2;
            // 
            // listNumber
            // 
            this.listNumber.Location = new System.Drawing.Point(742, 12);
            this.listNumber.Name = "listNumber";
            this.listNumber.Size = new System.Drawing.Size(46, 20);
            this.listNumber.TabIndex = 4;
            this.listNumber.ValueChanged += new System.EventHandler(this.listNumber_ValueChanged);
            // 
            // lableInfoListNumber
            // 
            this.lableInfoListNumber.AutoSize = true;
            this.lableInfoListNumber.Location = new System.Drawing.Point(662, 14);
            this.lableInfoListNumber.Name = "lableInfoListNumber";
            this.lableInfoListNumber.Size = new System.Drawing.Size(64, 13);
            this.lableInfoListNumber.TabIndex = 3;
            this.lableInfoListNumber.Text = "List number:";
            // 
            // buttonSaveToList
            // 
            this.buttonSaveToList.Location = new System.Drawing.Point(186, 9);
            this.buttonSaveToList.Name = "buttonSaveToList";
            this.buttonSaveToList.Size = new System.Drawing.Size(67, 23);
            this.buttonSaveToList.TabIndex = 2;
            this.buttonSaveToList.Text = "Save to list";
            this.buttonSaveToList.UseVisualStyleBackColor = true;
            this.buttonSaveToList.Click += new System.EventHandler(this.buttonSaveToList_Click);
            // 
            // buttonDeletFromList
            // 
            this.buttonDeletFromList.Location = new System.Drawing.Point(99, 9);
            this.buttonDeletFromList.Name = "buttonDeletFromList";
            this.buttonDeletFromList.Size = new System.Drawing.Size(81, 23);
            this.buttonDeletFromList.TabIndex = 1;
            this.buttonDeletFromList.Text = "Delet from list";
            this.buttonDeletFromList.UseVisualStyleBackColor = true;
            this.buttonDeletFromList.Click += new System.EventHandler(this.buttonDeletFromList_Click);
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.Location = new System.Drawing.Point(12, 9);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(81, 23);
            this.buttonAddToList.TabIndex = 0;
            this.buttonAddToList.Text = "Add to the list";
            this.buttonAddToList.UseVisualStyleBackColor = true;
            this.buttonAddToList.Click += new System.EventHandler(this.buttonAddToList_Click);
            // 
            // panelUp
            // 
            this.panelUp.Controls.Add(this.labelInfo2B);
            this.panelUp.Controls.Add(this.buttonUploadImage);
            this.panelUp.Controls.Add(this.checkTrue);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 25);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(800, 43);
            this.panelUp.TabIndex = 3;
            // 
            // labelInfo2B
            // 
            this.labelInfo2B.AutoSize = true;
            this.labelInfo2B.Location = new System.Drawing.Point(662, 14);
            this.labelInfo2B.Name = "labelInfo2B";
            this.labelInfo2B.Size = new System.Drawing.Size(72, 13);
            this.labelInfo2B.TabIndex = 2;
            this.labelInfo2B.Text = "2B or not 2B?";
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Location = new System.Drawing.Point(12, 9);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(81, 23);
            this.buttonUploadImage.TabIndex = 1;
            this.buttonUploadImage.Text = "Upload image";
            this.buttonUploadImage.UseVisualStyleBackColor = true;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // checkTrue
            // 
            this.checkTrue.AutoSize = true;
            this.checkTrue.Location = new System.Drawing.Point(740, 13);
            this.checkTrue.Name = "checkTrue";
            this.checkTrue.Size = new System.Drawing.Size(48, 17);
            this.checkTrue.TabIndex = 0;
            this.checkTrue.Text = "True";
            this.checkTrue.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 68);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.picture);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textTag);
            this.splitContainer1.Size = new System.Drawing.Size(800, 338);
            this.splitContainer1.SplitterDistance = 539;
            this.splitContainer1.TabIndex = 4;
            // 
            // picture
            // 
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(539, 338);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // textTag
            // 
            this.textTag.BackColor = System.Drawing.SystemColors.Window;
            this.textTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTag.Location = new System.Drawing.Point(0, 0);
            this.textTag.Multiline = true;
            this.textTag.Name = "textTag";
            this.textTag.Size = new System.Drawing.Size(257, 338);
            this.textTag.TabIndex = 0;
            this.textTag.Text = "Введите тэги через запятую";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.toolStrip);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "2B or not 2B";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panelDown.ResumeLayout(false);
            this.panelDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listNumber)).EndInit();
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNewFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAboutProgram;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Label lableInfoListNumber;
        private System.Windows.Forms.Button buttonSaveToList;
        private System.Windows.Forms.Button buttonDeletFromList;
        private System.Windows.Forms.Button buttonAddToList;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.CheckBox checkTrue;
        private System.Windows.Forms.Label labelInfo2B;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox textTag;
        private System.Windows.Forms.NumericUpDown listNumber;
    }
}

