/* Задание 3.
а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных, 
обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» 
улучшения на свое усмотрение.
в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).
  
Демин Артем*/

namespace TrueFalseEditor
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
            this.panel = new System.Windows.Forms.Panel();
            this.lableInfoCountQuestion = new System.Windows.Forms.Label();
            this.numericUpDownCountQuestion = new System.Windows.Forms.NumericUpDown();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.buttonSaveQuestion = new System.Windows.Forms.Button();
            this.buttonDeleteQuestion = new System.Windows.Forms.Button();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.toolStrip.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountQuestion)).BeginInit();
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
            this.toolStrip.TabIndex = 0;
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
            this.menuFileNewFile.Click += new System.EventHandler(this.menuFileNewFile_Click);
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
            // panel
            // 
            this.panel.Controls.Add(this.lableInfoCountQuestion);
            this.panel.Controls.Add(this.numericUpDownCountQuestion);
            this.panel.Controls.Add(this.radioButtonYes);
            this.panel.Controls.Add(this.radioButtonNo);
            this.panel.Controls.Add(this.buttonSaveQuestion);
            this.panel.Controls.Add(this.buttonDeleteQuestion);
            this.panel.Controls.Add(this.buttonAddQuestion);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 396);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 54);
            this.panel.TabIndex = 1;
            // 
            // lableInfoCountQuestion
            // 
            this.lableInfoCountQuestion.AutoSize = true;
            this.lableInfoCountQuestion.Location = new System.Drawing.Point(521, 21);
            this.lableInfoCountQuestion.Name = "lableInfoCountQuestion";
            this.lableInfoCountQuestion.Size = new System.Drawing.Size(89, 13);
            this.lableInfoCountQuestion.TabIndex = 6;
            this.lableInfoCountQuestion.Text = "Номер вопроса:";
            // 
            // numericUpDownCountQuestion
            // 
            this.numericUpDownCountQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCountQuestion.Location = new System.Drawing.Point(616, 19);
            this.numericUpDownCountQuestion.Name = "numericUpDownCountQuestion";
            this.numericUpDownCountQuestion.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownCountQuestion.TabIndex = 5;
            this.numericUpDownCountQuestion.ValueChanged += new System.EventHandler(this.numericUpDownCountQuestion_ValueChanged);
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(685, 19);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(47, 17);
            this.radioButtonYes.TabIndex = 4;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "True";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(738, 19);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(50, 17);
            this.radioButtonNo.TabIndex = 3;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "False";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // buttonSaveQuestion
            // 
            this.buttonSaveQuestion.Location = new System.Drawing.Point(210, 16);
            this.buttonSaveQuestion.Name = "buttonSaveQuestion";
            this.buttonSaveQuestion.Size = new System.Drawing.Size(105, 23);
            this.buttonSaveQuestion.TabIndex = 2;
            this.buttonSaveQuestion.Text = "Save the question";
            this.buttonSaveQuestion.UseVisualStyleBackColor = true;
            this.buttonSaveQuestion.Click += new System.EventHandler(this.buttonSaveQuestion_Click);
            // 
            // buttonDeleteQuestion
            // 
            this.buttonDeleteQuestion.Location = new System.Drawing.Point(114, 16);
            this.buttonDeleteQuestion.Name = "buttonDeleteQuestion";
            this.buttonDeleteQuestion.Size = new System.Drawing.Size(90, 23);
            this.buttonDeleteQuestion.TabIndex = 1;
            this.buttonDeleteQuestion.Text = "Delete question";
            this.buttonDeleteQuestion.UseVisualStyleBackColor = true;
            this.buttonDeleteQuestion.Click += new System.EventHandler(this.buttonDeleteQuestion_Click);
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Location = new System.Drawing.Point(12, 16);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(96, 23);
            this.buttonAddQuestion.TabIndex = 0;
            this.buttonAddQuestion.Text = "Add ad question";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuestion.Location = new System.Drawing.Point(0, 25);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(800, 371);
            this.textBoxQuestion.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrueFalse Editor";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNewFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button buttonSaveQuestion;
        private System.Windows.Forms.Button buttonDeleteQuestion;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.NumericUpDown numericUpDownCountQuestion;
        private System.Windows.Forms.Label lableInfoCountQuestion;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAboutProgram;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
    }
}