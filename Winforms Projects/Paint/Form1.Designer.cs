
namespace Paint
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.labelRed = new System.Windows.Forms.ToolStripLabel();
            this.labelGreen = new System.Windows.Forms.ToolStripLabel();
            this.labelBlue = new System.Windows.Forms.ToolStripLabel();
            this.labelYellow = new System.Windows.Forms.ToolStripLabel();
            this.labelPurple = new System.Windows.Forms.ToolStripLabel();
            this.buttonClear = new System.Windows.Forms.ToolStripButton();
            this.labelWidth = new System.Windows.Forms.ToolStripLabel();
            this.inputWidth = new System.Windows.Forms.ToolStripTextBox();
            this.labelHeight = new System.Windows.Forms.ToolStripLabel();
            this.inputHeight = new System.Windows.Forms.ToolStripTextBox();
            this.buttonOK = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionFile
            // 
            this.actionFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSave,
            this.toolStripSeparator1,
            this.itemExit});
            this.actionFile.Name = "actionFile";
            this.actionFile.Size = new System.Drawing.Size(37, 20);
            this.actionFile.Text = "File";
            // 
            // itemSave
            // 
            this.itemSave.Image = ((System.Drawing.Image)(resources.GetObject("itemSave.Image")));
            this.itemSave.Name = "itemSave";
            this.itemSave.Size = new System.Drawing.Size(98, 22);
            this.itemSave.Text = "Save";
            this.itemSave.Click += new System.EventHandler(this.itemSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // itemExit
            // 
            this.itemExit.Image = ((System.Drawing.Image)(resources.GetObject("itemExit.Image")));
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(98, 22);
            this.itemExit.Text = "Exit";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 49);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(734, 412);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRed,
            this.labelGreen,
            this.labelBlue,
            this.labelYellow,
            this.labelPurple,
            this.buttonClear,
            this.labelWidth,
            this.inputWidth,
            this.labelHeight,
            this.inputHeight,
            this.buttonOK});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(734, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // labelRed
            // 
            this.labelRed.ActiveLinkColor = System.Drawing.Color.White;
            this.labelRed.AutoSize = false;
            this.labelRed.BackColor = System.Drawing.Color.Red;
            this.labelRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(50, 22);
            this.labelRed.Click += new System.EventHandler(this.labelRed_Click);
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = false;
            this.labelGreen.BackColor = System.Drawing.Color.Lime;
            this.labelGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(50, 22);
            this.labelGreen.Click += new System.EventHandler(this.labelGreen_Click);
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = false;
            this.labelBlue.BackColor = System.Drawing.Color.Blue;
            this.labelBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(50, 22);
            this.labelBlue.Click += new System.EventHandler(this.labelBlue_Click);
            // 
            // labelYellow
            // 
            this.labelYellow.AutoSize = false;
            this.labelYellow.BackColor = System.Drawing.Color.Yellow;
            this.labelYellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.labelYellow.Name = "labelYellow";
            this.labelYellow.Size = new System.Drawing.Size(50, 22);
            this.labelYellow.Click += new System.EventHandler(this.labelYellow_Click);
            // 
            // labelPurple
            // 
            this.labelPurple.AutoSize = false;
            this.labelPurple.BackColor = System.Drawing.Color.Fuchsia;
            this.labelPurple.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.labelPurple.Name = "labelPurple";
            this.labelPurple.Size = new System.Drawing.Size(50, 22);
            this.labelPurple.Click += new System.EventHandler(this.labelPurple_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Black;
            this.buttonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
            this.buttonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonClear.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(39, 22);
            this.buttonClear.Text = "Clear";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelWidth
            // 
            this.labelWidth.BackColor = System.Drawing.Color.Black;
            this.labelWidth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.ForeColor = System.Drawing.Color.White;
            this.labelWidth.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(47, 22);
            this.labelWidth.Text = "Width: ";
            // 
            // inputWidth
            // 
            this.inputWidth.MaxLength = 4;
            this.inputWidth.Name = "inputWidth";
            this.inputWidth.Size = new System.Drawing.Size(100, 25);
            this.inputWidth.Text = "750";
            this.inputWidth.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHeight
            // 
            this.labelHeight.BackColor = System.Drawing.Color.Black;
            this.labelHeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.ForeColor = System.Drawing.Color.White;
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(51, 22);
            this.labelHeight.Text = "Height: ";
            // 
            // inputHeight
            // 
            this.inputHeight.MaxLength = 4;
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(100, 25);
            this.inputHeight.Text = "500";
            this.inputHeight.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonOK
            // 
            this.buttonOK.AutoSize = false;
            this.buttonOK.BackColor = System.Drawing.Color.Green;
            this.buttonOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonOK.Image")));
            this.buttonOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(50, 22);
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionFile;
        private System.Windows.Forms.ToolStripMenuItem itemSave;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel labelRed;
        private System.Windows.Forms.ToolStripLabel labelGreen;
        private System.Windows.Forms.ToolStripLabel labelBlue;
        private System.Windows.Forms.ToolStripLabel labelYellow;
        private System.Windows.Forms.ToolStripLabel labelPurple;
        private System.Windows.Forms.ToolStripButton buttonClear;
        private System.Windows.Forms.ToolStripLabel labelWidth;
        private System.Windows.Forms.ToolStripTextBox inputWidth;
        private System.Windows.Forms.ToolStripLabel labelHeight;
        private System.Windows.Forms.ToolStripTextBox inputHeight;
        private System.Windows.Forms.ToolStripButton buttonOK;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

