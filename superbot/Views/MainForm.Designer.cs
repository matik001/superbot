﻿
namespace superbot.Views
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxBotSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxLoop = new System.Windows.Forms.CheckBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.buttonDuplicate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxWaitMs = new System.Windows.Forms.TextBox();
            this.groupBoxPosition = new System.Windows.Forms.GroupBox();
            this.textBoxPosY = new System.Windows.Forms.TextBox();
            this.textBoxPosX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxRecordSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxIgnoreMouseMove = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelBot = new System.Windows.Forms.Panel();
            this.labelBot = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRecord = new System.Windows.Forms.Panel();
            this.labelRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPolecenia = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxBotSettings.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxPosition.SuspendLayout();
            this.groupBoxRecordSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelBot.SuspendLayout();
            this.panelRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.informacjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1107, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.otwórzToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.informacjeToolStripMenuItem.Text = "Informacje";
            // 
            // groupBoxBotSettings
            // 
            this.groupBoxBotSettings.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxBotSettings.Controls.Add(this.checkBoxLoop);
            this.groupBoxBotSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxBotSettings.Location = new System.Drawing.Point(24, 556);
            this.groupBoxBotSettings.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxBotSettings.Name = "groupBoxBotSettings";
            this.groupBoxBotSettings.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxBotSettings.Size = new System.Drawing.Size(333, 165);
            this.groupBoxBotSettings.TabIndex = 13;
            this.groupBoxBotSettings.TabStop = false;
            this.groupBoxBotSettings.Text = "Bot settings";
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.AutoSize = true;
            this.checkBoxLoop.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxLoop.Location = new System.Drawing.Point(17, 34);
            this.checkBoxLoop.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLoop.Name = "checkBoxLoop";
            this.checkBoxLoop.Size = new System.Drawing.Size(67, 27);
            this.checkBoxLoop.TabIndex = 2;
            this.checkBoxLoop.Text = "Loop";
            this.checkBoxLoop.UseVisualStyleBackColor = true;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEdit.Controls.Add(this.buttonDuplicate);
            this.groupBoxEdit.Controls.Add(this.buttonDelete);
            this.groupBoxEdit.Controls.Add(this.textBoxWaitMs);
            this.groupBoxEdit.Controls.Add(this.groupBoxPosition);
            this.groupBoxEdit.Controls.Add(this.label7);
            this.groupBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxEdit.Location = new System.Drawing.Point(383, 32);
            this.groupBoxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEdit.Size = new System.Drawing.Size(333, 689);
            this.groupBoxEdit.TabIndex = 14;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit";
            // 
            // buttonDuplicate
            // 
            this.buttonDuplicate.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonDuplicate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDuplicate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDuplicate.Location = new System.Drawing.Point(171, 48);
            this.buttonDuplicate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDuplicate.Name = "buttonDuplicate";
            this.buttonDuplicate.Size = new System.Drawing.Size(129, 58);
            this.buttonDuplicate.TabIndex = 9;
            this.buttonDuplicate.Text = "Duplicate";
            this.buttonDuplicate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(33, 48);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(129, 58);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // textBoxWaitMs
            // 
            this.textBoxWaitMs.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.textBoxWaitMs.Location = new System.Drawing.Point(135, 132);
            this.textBoxWaitMs.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWaitMs.Name = "textBoxWaitMs";
            this.textBoxWaitMs.Size = new System.Drawing.Size(159, 23);
            this.textBoxWaitMs.TabIndex = 7;
            // 
            // groupBoxPosition
            // 
            this.groupBoxPosition.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPosition.Controls.Add(this.textBoxPosY);
            this.groupBoxPosition.Controls.Add(this.textBoxPosX);
            this.groupBoxPosition.Controls.Add(this.label4);
            this.groupBoxPosition.Controls.Add(this.label5);
            this.groupBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxPosition.Location = new System.Drawing.Point(33, 185);
            this.groupBoxPosition.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPosition.Name = "groupBoxPosition";
            this.groupBoxPosition.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPosition.Size = new System.Drawing.Size(267, 151);
            this.groupBoxPosition.TabIndex = 6;
            this.groupBoxPosition.TabStop = false;
            this.groupBoxPosition.Text = "Position";
            // 
            // textBoxPosY
            // 
            this.textBoxPosY.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.textBoxPosY.Location = new System.Drawing.Point(71, 86);
            this.textBoxPosY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPosY.Name = "textBoxPosY";
            this.textBoxPosY.Size = new System.Drawing.Size(159, 23);
            this.textBoxPosY.TabIndex = 9;
            // 
            // textBoxPosX
            // 
            this.textBoxPosX.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.textBoxPosX.Location = new System.Drawing.Point(71, 46);
            this.textBoxPosX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPosX.Name = "textBoxPosX";
            this.textBoxPosX.Size = new System.Drawing.Size(159, 23);
            this.textBoxPosX.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(33, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(33, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(29, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Wait(ms):";
            // 
            // groupBoxRecordSettings
            // 
            this.groupBoxRecordSettings.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRecordSettings.Controls.Add(this.checkBoxIgnoreMouseMove);
            this.groupBoxRecordSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxRecordSettings.Location = new System.Drawing.Point(24, 375);
            this.groupBoxRecordSettings.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxRecordSettings.Name = "groupBoxRecordSettings";
            this.groupBoxRecordSettings.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxRecordSettings.Size = new System.Drawing.Size(333, 165);
            this.groupBoxRecordSettings.TabIndex = 12;
            this.groupBoxRecordSettings.TabStop = false;
            this.groupBoxRecordSettings.Text = "Record settings";
            // 
            // checkBoxIgnoreMouseMove
            // 
            this.checkBoxIgnoreMouseMove.AutoSize = true;
            this.checkBoxIgnoreMouseMove.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxIgnoreMouseMove.Location = new System.Drawing.Point(17, 34);
            this.checkBoxIgnoreMouseMove.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxIgnoreMouseMove.Name = "checkBoxIgnoreMouseMove";
            this.checkBoxIgnoreMouseMove.Size = new System.Drawing.Size(185, 27);
            this.checkBoxIgnoreMouseMove.TabIndex = 3;
            this.checkBoxIgnoreMouseMove.Text = "Ignore Mouse Move";
            this.checkBoxIgnoreMouseMove.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panelBot);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panelRecord);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(24, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(333, 336);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hot keys";
            // 
            // panelBot
            // 
            this.panelBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panelBot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBot.Controls.Add(this.labelBot);
            this.panelBot.Controls.Add(this.label6);
            this.panelBot.Location = new System.Drawing.Point(25, 226);
            this.panelBot.Margin = new System.Windows.Forms.Padding(4);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(265, 72);
            this.panelBot.TabIndex = 4;
            // 
            // labelBot
            // 
            this.labelBot.AutoSize = true;
            this.labelBot.BackColor = System.Drawing.Color.Transparent;
            this.labelBot.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBot.ForeColor = System.Drawing.Color.Gold;
            this.labelBot.Location = new System.Drawing.Point(142, 24);
            this.labelBot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBot.Name = "labelBot";
            this.labelBot.Size = new System.Drawing.Size(36, 18);
            this.labelBot.TabIndex = 3;
            this.labelBot.Text = "Off";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(91, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bot:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start/Stop Bot: Ctrl+Alt+S";
            // 
            // panelRecord
            // 
            this.panelRecord.BackColor = System.Drawing.Color.Green;
            this.panelRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecord.Controls.Add(this.labelRecord);
            this.panelRecord.Controls.Add(this.label3);
            this.panelRecord.Location = new System.Drawing.Point(25, 148);
            this.panelRecord.Margin = new System.Windows.Forms.Padding(4);
            this.panelRecord.Name = "panelRecord";
            this.panelRecord.Size = new System.Drawing.Size(265, 68);
            this.panelRecord.TabIndex = 2;
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.BackColor = System.Drawing.Color.Transparent;
            this.labelRecord.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRecord.ForeColor = System.Drawing.Color.Chocolate;
            this.labelRecord.Location = new System.Drawing.Point(155, 24);
            this.labelRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(42, 18);
            this.labelRecord.TabIndex = 3;
            this.labelRecord.Text = "OFF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(76, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Record:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start/Stop Record: Ctrl+Alt+R";
            // 
            // listBoxPolecenia
            // 
            this.listBoxPolecenia.BackColor = System.Drawing.Color.DarkBlue;
            this.listBoxPolecenia.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxPolecenia.ForeColor = System.Drawing.Color.White;
            this.listBoxPolecenia.FormattingEnabled = true;
            this.listBoxPolecenia.ItemHeight = 23;
            this.listBoxPolecenia.Location = new System.Drawing.Point(743, 45);
            this.listBoxPolecenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPolecenia.Name = "listBoxPolecenia";
            this.listBoxPolecenia.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPolecenia.Size = new System.Drawing.Size(332, 671);
            this.listBoxPolecenia.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 743);
            this.Controls.Add(this.groupBoxBotSettings);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxRecordSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxPolecenia);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "SuperBot by Mateusz Kisiel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxBotSettings.ResumeLayout(false);
            this.groupBoxBotSettings.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBoxPosition.ResumeLayout(false);
            this.groupBoxPosition.PerformLayout();
            this.groupBoxRecordSettings.ResumeLayout(false);
            this.groupBoxRecordSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelBot.ResumeLayout(false);
            this.panelBot.PerformLayout();
            this.panelRecord.ResumeLayout(false);
            this.panelRecord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxBotSettings;
        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button buttonDuplicate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxWaitMs;
        private System.Windows.Forms.GroupBox groupBoxPosition;
        private System.Windows.Forms.TextBox textBoxPosY;
        private System.Windows.Forms.TextBox textBoxPosX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxRecordSettings;
        private System.Windows.Forms.CheckBox checkBoxIgnoreMouseMove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Label labelBot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelRecord;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPolecenia;
    }
}