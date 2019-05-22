namespace Android_Emulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LB_commands = new System.Windows.Forms.ListBox();
            this.Commands = new System.Windows.Forms.Label();
            this.btn_createCMD = new System.Windows.Forms.Button();
            this.LB_chosenCMDs = new System.Windows.Forms.ListBox();
            this.BTN_addCMD = new System.Windows.Forms.Button();
            this.CB_presets = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_presetAdd = new System.Windows.Forms.Button();
            this.BTN_runStop = new System.Windows.Forms.Button();
            this.CB_emulators = new System.Windows.Forms.ComboBox();
            this.cmd_removeCMD = new System.Windows.Forms.Button();
            this.tb_newCMD = new System.Windows.Forms.TextBox();
            this.BTN_deleteCMD = new System.Windows.Forms.Button();
            this.CB_hideConsole = new System.Windows.Forms.CheckBox();
            this.BTN_presetRemove = new System.Windows.Forms.Button();
            this.TB_addNewPreset = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LB_commands
            // 
            this.LB_commands.FormattingEnabled = true;
            this.LB_commands.ItemHeight = 16;
            this.LB_commands.Location = new System.Drawing.Point(12, 29);
            this.LB_commands.Name = "LB_commands";
            this.LB_commands.Size = new System.Drawing.Size(244, 324);
            this.LB_commands.TabIndex = 0;
            // 
            // Commands
            // 
            this.Commands.AutoSize = true;
            this.Commands.Location = new System.Drawing.Point(9, 9);
            this.Commands.Name = "Commands";
            this.Commands.Size = new System.Drawing.Size(78, 17);
            this.Commands.TabIndex = 1;
            this.Commands.Text = "Commands";
            // 
            // btn_createCMD
            // 
            this.btn_createCMD.Location = new System.Drawing.Point(230, 359);
            this.btn_createCMD.Name = "btn_createCMD";
            this.btn_createCMD.Size = new System.Drawing.Size(26, 23);
            this.btn_createCMD.TabIndex = 2;
            this.btn_createCMD.Text = "+";
            this.btn_createCMD.UseVisualStyleBackColor = true;
            this.btn_createCMD.Click += new System.EventHandler(this.btn_createCMD_Click);
            // 
            // LB_chosenCMDs
            // 
            this.LB_chosenCMDs.FormattingEnabled = true;
            this.LB_chosenCMDs.ItemHeight = 16;
            this.LB_chosenCMDs.Location = new System.Drawing.Point(312, 61);
            this.LB_chosenCMDs.Name = "LB_chosenCMDs";
            this.LB_chosenCMDs.Size = new System.Drawing.Size(262, 292);
            this.LB_chosenCMDs.TabIndex = 4;
            // 
            // BTN_addCMD
            // 
            this.BTN_addCMD.Location = new System.Drawing.Point(262, 154);
            this.BTN_addCMD.Name = "BTN_addCMD";
            this.BTN_addCMD.Size = new System.Drawing.Size(44, 27);
            this.BTN_addCMD.TabIndex = 5;
            this.BTN_addCMD.Text = ">>";
            this.BTN_addCMD.UseVisualStyleBackColor = true;
            this.BTN_addCMD.Click += new System.EventHandler(this.BTN_addCMD_Click);
            // 
            // CB_presets
            // 
            this.CB_presets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_presets.FormattingEnabled = true;
            this.CB_presets.Location = new System.Drawing.Point(312, 31);
            this.CB_presets.Name = "CB_presets";
            this.CB_presets.Size = new System.Drawing.Size(183, 24);
            this.CB_presets.TabIndex = 6;
            this.CB_presets.SelectedIndexChanged += new System.EventHandler(this.CB_presets_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Execution";
            // 
            // BTN_presetAdd
            // 
            this.BTN_presetAdd.Location = new System.Drawing.Point(501, 29);
            this.BTN_presetAdd.Name = "BTN_presetAdd";
            this.BTN_presetAdd.Size = new System.Drawing.Size(29, 26);
            this.BTN_presetAdd.TabIndex = 8;
            this.BTN_presetAdd.Text = "+";
            this.BTN_presetAdd.UseVisualStyleBackColor = true;
            this.BTN_presetAdd.Click += new System.EventHandler(this.BTN_presetAdd_Click);
            // 
            // BTN_runStop
            // 
            this.BTN_runStop.Location = new System.Drawing.Point(499, 359);
            this.BTN_runStop.Name = "BTN_runStop";
            this.BTN_runStop.Size = new System.Drawing.Size(75, 25);
            this.BTN_runStop.TabIndex = 10;
            this.BTN_runStop.Text = "Run";
            this.BTN_runStop.UseVisualStyleBackColor = true;
            this.BTN_runStop.Click += new System.EventHandler(this.BTN_runStop_Click);
            // 
            // CB_emulators
            // 
            this.CB_emulators.FormattingEnabled = true;
            this.CB_emulators.Location = new System.Drawing.Point(312, 360);
            this.CB_emulators.Name = "CB_emulators";
            this.CB_emulators.Size = new System.Drawing.Size(181, 24);
            this.CB_emulators.TabIndex = 11;
            // 
            // cmd_removeCMD
            // 
            this.cmd_removeCMD.Location = new System.Drawing.Point(262, 187);
            this.cmd_removeCMD.Name = "cmd_removeCMD";
            this.cmd_removeCMD.Size = new System.Drawing.Size(44, 27);
            this.cmd_removeCMD.TabIndex = 13;
            this.cmd_removeCMD.Text = "<<";
            this.cmd_removeCMD.UseVisualStyleBackColor = true;
            this.cmd_removeCMD.Click += new System.EventHandler(this.cmd_removeCMD_Click);
            // 
            // tb_newCMD
            // 
            this.tb_newCMD.Location = new System.Drawing.Point(12, 360);
            this.tb_newCMD.Name = "tb_newCMD";
            this.tb_newCMD.Size = new System.Drawing.Size(212, 22);
            this.tb_newCMD.TabIndex = 14;
            // 
            // BTN_deleteCMD
            // 
            this.BTN_deleteCMD.Location = new System.Drawing.Point(12, 388);
            this.BTN_deleteCMD.Name = "BTN_deleteCMD";
            this.BTN_deleteCMD.Size = new System.Drawing.Size(244, 27);
            this.BTN_deleteCMD.TabIndex = 15;
            this.BTN_deleteCMD.Text = "Remove";
            this.BTN_deleteCMD.UseVisualStyleBackColor = true;
            this.BTN_deleteCMD.Click += new System.EventHandler(this.BTN_deleteCMD_Click);
            // 
            // CB_hideConsole
            // 
            this.CB_hideConsole.AutoSize = true;
            this.CB_hideConsole.Checked = true;
            this.CB_hideConsole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_hideConsole.Location = new System.Drawing.Point(312, 392);
            this.CB_hideConsole.Name = "CB_hideConsole";
            this.CB_hideConsole.Size = new System.Drawing.Size(122, 21);
            this.CB_hideConsole.TabIndex = 18;
            this.CB_hideConsole.Text = "Hide Console?";
            this.CB_hideConsole.UseVisualStyleBackColor = true;
            // 
            // BTN_presetRemove
            // 
            this.BTN_presetRemove.Location = new System.Drawing.Point(536, 29);
            this.BTN_presetRemove.Name = "BTN_presetRemove";
            this.BTN_presetRemove.Size = new System.Drawing.Size(29, 26);
            this.BTN_presetRemove.TabIndex = 19;
            this.BTN_presetRemove.Text = "-";
            this.BTN_presetRemove.UseVisualStyleBackColor = true;
            this.BTN_presetRemove.Click += new System.EventHandler(this.BTN_presetRemove_Click);
            // 
            // TB_addNewPreset
            // 
            this.TB_addNewPreset.Location = new System.Drawing.Point(312, 32);
            this.TB_addNewPreset.Name = "TB_addNewPreset";
            this.TB_addNewPreset.Size = new System.Drawing.Size(183, 22);
            this.TB_addNewPreset.TabIndex = 20;
            this.TB_addNewPreset.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 423);
            this.Controls.Add(this.TB_addNewPreset);
            this.Controls.Add(this.BTN_presetRemove);
            this.Controls.Add(this.CB_hideConsole);
            this.Controls.Add(this.BTN_deleteCMD);
            this.Controls.Add(this.tb_newCMD);
            this.Controls.Add(this.cmd_removeCMD);
            this.Controls.Add(this.CB_emulators);
            this.Controls.Add(this.BTN_runStop);
            this.Controls.Add(this.BTN_presetAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_presets);
            this.Controls.Add(this.BTN_addCMD);
            this.Controls.Add(this.LB_chosenCMDs);
            this.Controls.Add(this.btn_createCMD);
            this.Controls.Add(this.Commands);
            this.Controls.Add(this.LB_commands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Android  Emulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_commands;
        private System.Windows.Forms.Label Commands;
        private System.Windows.Forms.Button btn_createCMD;
        private System.Windows.Forms.ListBox LB_chosenCMDs;
        private System.Windows.Forms.Button BTN_addCMD;
        private System.Windows.Forms.ComboBox CB_presets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_presetAdd;
        private System.Windows.Forms.Button BTN_runStop;
        private System.Windows.Forms.ComboBox CB_emulators;
        private System.Windows.Forms.Button cmd_removeCMD;
        private System.Windows.Forms.TextBox tb_newCMD;
        private System.Windows.Forms.Button BTN_deleteCMD;
        private System.Windows.Forms.CheckBox CB_hideConsole;
        private System.Windows.Forms.Button BTN_presetRemove;
        private System.Windows.Forms.TextBox TB_addNewPreset;
    }
}

