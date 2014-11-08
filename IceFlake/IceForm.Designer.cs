﻿namespace IceFlake
{
    partial class IceForm
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
            this.rbLogBox = new System.Windows.Forms.RichTextBox();
            this.btnGeneratePath = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstScripts = new System.Windows.Forms.CheckedListBox();
            this.btnScriptCompile = new System.Windows.Forms.Button();
            this.btnScriptStop = new System.Windows.Forms.Button();
            this.btnScriptStart = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExecute = new System.Windows.Forms.Button();
            this.tbLUA = new System.Windows.Forms.TextBox();
            this.btnDump = new System.Windows.Forms.Button();
            this.GUITimer = new System.Windows.Forms.Timer(this.components);
            this.buttonDebug = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbLogBox
            // 
            this.rbLogBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rbLogBox.Location = new System.Drawing.Point(0, 536);
            this.rbLogBox.Name = "rbLogBox";
            this.rbLogBox.ReadOnly = true;
            this.rbLogBox.Size = new System.Drawing.Size(386, 309);
            this.rbLogBox.TabIndex = 0;
            this.rbLogBox.Text = "";
            // 
            // btnGeneratePath
            // 
            this.btnGeneratePath.Location = new System.Drawing.Point(0, 0);
            this.btnGeneratePath.Name = "btnGeneratePath";
            this.btnGeneratePath.Size = new System.Drawing.Size(75, 23);
            this.btnGeneratePath.TabIndex = 2;
            this.btnGeneratePath.Text = "Path";
            this.btnGeneratePath.UseVisualStyleBackColor = true;
            this.btnGeneratePath.Click += new System.EventHandler(this.btnGeneratePath_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(386, 536);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstScripts);
            this.tabPage1.Controls.Add(this.btnScriptCompile);
            this.tabPage1.Controls.Add(this.btnScriptStop);
            this.tabPage1.Controls.Add(this.btnScriptStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(378, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scripts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstScripts
            // 
            this.lstScripts.FormattingEnabled = true;
            this.lstScripts.Location = new System.Drawing.Point(6, 7);
            this.lstScripts.Name = "lstScripts";
            this.lstScripts.Size = new System.Drawing.Size(366, 469);
            this.lstScripts.TabIndex = 4;
            this.lstScripts.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstScripts_ItemCheck);
            this.lstScripts.SelectedIndexChanged += new System.EventHandler(this.lstScripts_SelectedIndexChanged);
            // 
            // btnScriptCompile
            // 
            this.btnScriptCompile.Location = new System.Drawing.Point(169, 483);
            this.btnScriptCompile.Name = "btnScriptCompile";
            this.btnScriptCompile.Size = new System.Drawing.Size(75, 23);
            this.btnScriptCompile.TabIndex = 3;
            this.btnScriptCompile.Text = "Compile";
            this.btnScriptCompile.UseVisualStyleBackColor = true;
            this.btnScriptCompile.Click += new System.EventHandler(this.btnScriptCompile_Click);
            // 
            // btnScriptStop
            // 
            this.btnScriptStop.Location = new System.Drawing.Point(88, 483);
            this.btnScriptStop.Name = "btnScriptStop";
            this.btnScriptStop.Size = new System.Drawing.Size(75, 23);
            this.btnScriptStop.TabIndex = 2;
            this.btnScriptStop.Text = "Stop";
            this.btnScriptStop.UseVisualStyleBackColor = true;
            this.btnScriptStop.Click += new System.EventHandler(this.btnScriptStop_Click);
            // 
            // btnScriptStart
            // 
            this.btnScriptStart.Location = new System.Drawing.Point(7, 483);
            this.btnScriptStart.Name = "btnScriptStart";
            this.btnScriptStart.Size = new System.Drawing.Size(75, 23);
            this.btnScriptStart.TabIndex = 1;
            this.btnScriptStart.Text = "Start";
            this.btnScriptStart.UseVisualStyleBackColor = true;
            this.btnScriptStart.Click += new System.EventHandler(this.btnScriptStart_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExecute);
            this.tabPage2.Controls.Add(this.tbLUA);
            this.tabPage2.Controls.Add(this.buttonDebug);
            this.tabPage2.Controls.Add(this.btnDump);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(378, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Debug";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(181, 160);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // tbLUA
            // 
            this.tbLUA.Location = new System.Drawing.Point(8, 162);
            this.tbLUA.Name = "tbLUA";
            this.tbLUA.Size = new System.Drawing.Size(167, 20);
            this.tbLUA.TabIndex = 1;
            // 
            // btnDump
            // 
            this.btnDump.Location = new System.Drawing.Point(8, 7);
            this.btnDump.Name = "btnDump";
            this.btnDump.Size = new System.Drawing.Size(75, 23);
            this.btnDump.TabIndex = 0;
            this.btnDump.Text = "Dump";
            this.btnDump.UseVisualStyleBackColor = true;
            this.btnDump.Click += new System.EventHandler(this.btnDump_Click);
            // 
            // GUITimer
            // 
            this.GUITimer.Enabled = true;
            this.GUITimer.Interval = 500;
            this.GUITimer.Tick += new System.EventHandler(this.GUITimer_Tick);
            // 
            // buttonDebug
            // 
            this.buttonDebug.Location = new System.Drawing.Point(295, 7);
            this.buttonDebug.Name = "buttonDebug";
            this.buttonDebug.Size = new System.Drawing.Size(75, 23);
            this.buttonDebug.TabIndex = 0;
            this.buttonDebug.Text = "Debug";
            this.buttonDebug.UseVisualStyleBackColor = true;
            this.buttonDebug.Click += new System.EventHandler(this.buttonDebug_Click);
            // 
            // IceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 845);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnGeneratePath);
            this.Controls.Add(this.rbLogBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IceForm";
            this.ShowIcon = false;
            this.Text = "IceFlake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IceForm_FormClosing);
            this.Load += new System.EventHandler(this.IceForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rbLogBox;
        private System.Windows.Forms.Button btnGeneratePath;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnScriptCompile;
        private System.Windows.Forms.Button btnScriptStop;
        private System.Windows.Forms.Button btnScriptStart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDump;
        private System.Windows.Forms.CheckedListBox lstScripts;
        private System.Windows.Forms.Timer GUITimer;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox tbLUA;
        private System.Windows.Forms.Button buttonDebug;
    }
}

