
namespace feelin_good
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
            this.background = new SkeetFramework.SkeetBackground();
            this.combatTab = new SkeetFramework.transparentPanel();
            this.skeetGroupBox1 = new SkeetFramework.SkeetGroupBox();
            this.deleteBtn = new SkeetFramework.SkeetButton();
            this.configName = new SkeetFramework.SkeetTextBox();
            this.saveBtn = new SkeetFramework.SkeetButton();
            this.createBtn = new SkeetFramework.SkeetButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.auto_groupbox = new SkeetFramework.SkeetGroupBox();
            this.enabledAC = new SkeetFramework.SkeetToggle();
            this.maxcps_slider = new SkeetFramework.SkeetSlider();
            this.mincps_slider = new SkeetFramework.SkeetSlider();
            this.miscL = new System.Windows.Forms.Label();
            this.visL = new System.Windows.Forms.Label();
            this.combatL = new System.Windows.Forms.Label();
            this.drag = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.resetBtn = new SkeetFramework.SkeetButton();
            this.background.SuspendLayout();
            this.combatTab.SuspendLayout();
            this.skeetGroupBox1.SuspendLayout();
            this.auto_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.background.Controls.Add(this.combatTab);
            this.background.Controls.Add(this.miscL);
            this.background.Controls.Add(this.visL);
            this.background.Controls.Add(this.combatL);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(537, 377);
            this.background.TabIndex = 0;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // combatTab
            // 
            this.combatTab.Controls.Add(this.skeetGroupBox1);
            this.combatTab.Controls.Add(this.auto_groupbox);
            this.combatTab.Location = new System.Drawing.Point(48, 99);
            this.combatTab.Name = "combatTab";
            this.combatTab.Size = new System.Drawing.Size(442, 249);
            this.combatTab.TabIndex = 4;
            this.combatTab.Visible = false;
            // 
            // skeetGroupBox1
            // 
            this.skeetGroupBox1.Controls.Add(this.resetBtn);
            this.skeetGroupBox1.Controls.Add(this.deleteBtn);
            this.skeetGroupBox1.Controls.Add(this.configName);
            this.skeetGroupBox1.Controls.Add(this.saveBtn);
            this.skeetGroupBox1.Controls.Add(this.createBtn);
            this.skeetGroupBox1.Controls.Add(this.listBox1);
            this.skeetGroupBox1.Font = new System.Drawing.Font("Verdana", 7F);
            this.skeetGroupBox1.Location = new System.Drawing.Point(223, 16);
            this.skeetGroupBox1.Name = "skeetGroupBox1";
            this.skeetGroupBox1.Size = new System.Drawing.Size(200, 209);
            this.skeetGroupBox1.TabIndex = 1;
            this.skeetGroupBox1.TabStop = false;
            this.skeetGroupBox1.Text = "cfg";
            this.skeetGroupBox1.Enter += new System.EventHandler(this.skeetGroupBox1_Enter);
            // 
            // deleteBtn
            // 
            this.deleteBtn.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.deleteBtn.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.deleteBtn.Font = new System.Drawing.Font("Verdana", 7F);
            this.deleteBtn.Location = new System.Drawing.Point(6, 151);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // configName
            // 
            this.configName.BackColor = System.Drawing.Color.Transparent;
            this.configName.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.configName.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.configName.FocusOnHover = false;
            this.configName.Location = new System.Drawing.Point(30, 108);
            this.configName.MaxLength = 32767;
            this.configName.Multiline = false;
            this.configName.Name = "configName";
            this.configName.ReadOnly = false;
            this.configName.Size = new System.Drawing.Size(134, 23);
            this.configName.TabIndex = 3;
            this.configName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.configName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.configName.UseSystemPasswordChar = false;
            // 
            // saveBtn
            // 
            this.saveBtn.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.saveBtn.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.saveBtn.Font = new System.Drawing.Font("Verdana", 7F);
            this.saveBtn.Location = new System.Drawing.Point(110, 180);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.createBtn.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.createBtn.Font = new System.Drawing.Font("Verdana", 7F);
            this.createBtn.Location = new System.Drawing.Point(6, 180);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create";
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(30, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(137, 84);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // auto_groupbox
            // 
            this.auto_groupbox.Controls.Add(this.enabledAC);
            this.auto_groupbox.Controls.Add(this.maxcps_slider);
            this.auto_groupbox.Controls.Add(this.mincps_slider);
            this.auto_groupbox.Font = new System.Drawing.Font("Verdana", 7F);
            this.auto_groupbox.Location = new System.Drawing.Point(14, 16);
            this.auto_groupbox.Name = "auto_groupbox";
            this.auto_groupbox.Size = new System.Drawing.Size(203, 151);
            this.auto_groupbox.TabIndex = 0;
            this.auto_groupbox.TabStop = false;
            this.auto_groupbox.Text = "Auto Clicker";
            // 
            // enabledAC
            // 
            this.enabledAC.BackColor = System.Drawing.Color.Transparent;
            this.enabledAC.Checked = false;
            this.enabledAC.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.enabledAC.ColorBottom1 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(161)))), ((int)(((byte)(27)))));
            this.enabledAC.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.enabledAC.ColorTop1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.enabledAC.Font = new System.Drawing.Font("Verdana", 7F);
            this.enabledAC.Location = new System.Drawing.Point(16, 23);
            this.enabledAC.Name = "enabledAC";
            this.enabledAC.Size = new System.Drawing.Size(75, 23);
            this.enabledAC.TabIndex = 3;
            this.enabledAC.Text = "Enabled";
            // 
            // maxcps_slider
            // 
            this.maxcps_slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.maxcps_slider.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Bold);
            this.maxcps_slider.FormatDecimal = 2;
            this.maxcps_slider.InvertTitleColor = false;
            this.maxcps_slider.Location = new System.Drawing.Point(6, 98);
            this.maxcps_slider.MaxValue = 20D;
            this.maxcps_slider.MinimumSize = new System.Drawing.Size(100, 40);
            this.maxcps_slider.MinValue = 1D;
            this.maxcps_slider.Name = "maxcps_slider";
            this.maxcps_slider.ShowTitle = true;
            this.maxcps_slider.ShowValue = true;
            this.maxcps_slider.Size = new System.Drawing.Size(102, 40);
            this.maxcps_slider.SliderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.maxcps_slider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.maxcps_slider.TabIndex = 2;
            this.maxcps_slider.Title = "Max Cps";
            this.maxcps_slider.Value = 1D;
            this.maxcps_slider.ValuePrefix = "";
            this.maxcps_slider.ValueSuffix = "";
            this.maxcps_slider.Load += new System.EventHandler(this.maxcps_slider_Load);
            // 
            // mincps_slider
            // 
            this.mincps_slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.mincps_slider.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Bold);
            this.mincps_slider.FormatDecimal = 2;
            this.mincps_slider.InvertTitleColor = false;
            this.mincps_slider.Location = new System.Drawing.Point(6, 52);
            this.mincps_slider.MaxValue = 20D;
            this.mincps_slider.MinimumSize = new System.Drawing.Size(100, 40);
            this.mincps_slider.MinValue = 1D;
            this.mincps_slider.Name = "mincps_slider";
            this.mincps_slider.ShowTitle = true;
            this.mincps_slider.ShowValue = true;
            this.mincps_slider.Size = new System.Drawing.Size(102, 40);
            this.mincps_slider.SliderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.mincps_slider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.mincps_slider.TabIndex = 1;
            this.mincps_slider.Title = "Min Cps";
            this.mincps_slider.Value = 1D;
            this.mincps_slider.ValuePrefix = "";
            this.mincps_slider.ValueSuffix = "";
            this.mincps_slider.Load += new System.EventHandler(this.mincps_slider_Load);
            // 
            // miscL
            // 
            this.miscL.AutoSize = true;
            this.miscL.Font = new System.Drawing.Font("Astriumtabs2", 28.75F);
            this.miscL.ForeColor = System.Drawing.Color.White;
            this.miscL.Location = new System.Drawing.Point(339, 22);
            this.miscL.Name = "miscL";
            this.miscL.Size = new System.Drawing.Size(56, 39);
            this.miscL.TabIndex = 3;
            this.miscL.Text = "F";
            this.miscL.Click += new System.EventHandler(this.miscL_Click);
            // 
            // visL
            // 
            this.visL.AutoSize = true;
            this.visL.Font = new System.Drawing.Font("Astriumtabs2", 28.75F);
            this.visL.ForeColor = System.Drawing.Color.White;
            this.visL.Location = new System.Drawing.Point(239, 22);
            this.visL.Name = "visL";
            this.visL.Size = new System.Drawing.Size(54, 39);
            this.visL.TabIndex = 2;
            this.visL.Text = "E";
            this.visL.Click += new System.EventHandler(this.visL_Click);
            // 
            // combatL
            // 
            this.combatL.AutoSize = true;
            this.combatL.Font = new System.Drawing.Font("Astriumtabs2", 28.75F);
            this.combatL.ForeColor = System.Drawing.Color.White;
            this.combatL.Location = new System.Drawing.Point(141, 22);
            this.combatL.Name = "combatL";
            this.combatL.Size = new System.Drawing.Size(57, 39);
            this.combatL.TabIndex = 0;
            this.combatL.Text = "C";
            this.combatL.Click += new System.EventHandler(this.combatL_Click);
            // 
            // drag
            // 
            this.drag.TargetControl = this.background;
            // 
            // resetBtn
            // 
            this.resetBtn.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.resetBtn.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.resetBtn.Font = new System.Drawing.Font("Verdana", 7F);
            this.resetBtn.Location = new System.Drawing.Point(110, 151);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 377);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.combatTab.ResumeLayout(false);
            this.skeetGroupBox1.ResumeLayout(false);
            this.auto_groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SkeetFramework.SkeetBackground background;
        private Siticone.UI.WinForms.SiticoneDragControl drag;
        private System.Windows.Forms.Label combatL;
        private System.Windows.Forms.Label miscL;
        private System.Windows.Forms.Label visL;
        private SkeetFramework.transparentPanel combatTab;
        private SkeetFramework.SkeetGroupBox auto_groupbox;
        private SkeetFramework.SkeetSlider mincps_slider;
        private SkeetFramework.SkeetSlider maxcps_slider;
        private SkeetFramework.SkeetToggle enabledAC;
        private SkeetFramework.SkeetGroupBox skeetGroupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private SkeetFramework.SkeetButton createBtn;
        private SkeetFramework.SkeetButton saveBtn;
        private SkeetFramework.SkeetTextBox configName;
        private SkeetFramework.SkeetButton deleteBtn;
        private SkeetFramework.SkeetButton resetBtn;
    }
}

