/*
 * Создано в SharpDevelop.
 * Пользователь: RURUKOH
 * Дата: 04.08.2018
 * Время: 19:26
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace AbbTools
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.popMenuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.popMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.popMenuPast = new System.Windows.Forms.ToolStripMenuItem();
            this.popMenuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.popMenuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rTextBoxChangeDirecTo = new System.Windows.Forms.RichTextBox();
            this.btnTClearAll = new System.Windows.Forms.Button();
            this.btnTDel = new System.Windows.Forms.Button();
            this.btnTSelectAll = new System.Windows.Forms.Button();
            this.btnTPaste = new System.Windows.Forms.Button();
            this.btnTCopy = new System.Windows.Forms.Button();
            this.btnTCut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rTextBoxChangeDirecFrom = new System.Windows.Forms.RichTextBox();
            this.btnSClearAll = new System.Windows.Forms.Button();
            this.btnSSelectAll = new System.Windows.Forms.Button();
            this.btnSDel = new System.Windows.Forms.Button();
            this.btnSCopy = new System.Windows.Forms.Button();
            this.btnSPaste = new System.Windows.Forms.Button();
            this.btnSCut = new System.Windows.Forms.Button();
            this.btnConvertStart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popMenuCut,
            this.popMenuCopy,
            this.popMenuPast,
            this.popMenuDel,
            this.toolStripSeparator1,
            this.popMenuSelectAll});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 140);
            // 
            // popMenuCut
            // 
            this.popMenuCut.Image = global::abbConvertList.Properties.Resources.Cut_16x;
            this.popMenuCut.Name = "popMenuCut";
            this.popMenuCut.Size = new System.Drawing.Size(169, 26);
            this.popMenuCut.Text = "Вырезать";
            this.popMenuCut.Click += new System.EventHandler(this.popMenuCut_Click_1);
            // 
            // popMenuCopy
            // 
            this.popMenuCopy.Image = global::abbConvertList.Properties.Resources.ASX_Copy_grey_16x;
            this.popMenuCopy.Name = "popMenuCopy";
            this.popMenuCopy.Size = new System.Drawing.Size(169, 26);
            this.popMenuCopy.Text = "Копировать";
            this.popMenuCopy.Click += new System.EventHandler(this.popMenuCopy_Click);
            // 
            // popMenuPast
            // 
            this.popMenuPast.Image = global::abbConvertList.Properties.Resources.Paste_16x;
            this.popMenuPast.Name = "popMenuPast";
            this.popMenuPast.Size = new System.Drawing.Size(169, 26);
            this.popMenuPast.Text = "Вставить";
            this.popMenuPast.Click += new System.EventHandler(this.popMenuPast_Click);
            // 
            // popMenuDel
            // 
            this.popMenuDel.Image = global::abbConvertList.Properties.Resources.DeleteKPI_16x;
            this.popMenuDel.Name = "popMenuDel";
            this.popMenuDel.Size = new System.Drawing.Size(169, 26);
            this.popMenuDel.Text = "Удалить";
            this.popMenuDel.Click += new System.EventHandler(this.popMenuDel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // popMenuSelectAll
            // 
            this.popMenuSelectAll.Image = global::abbConvertList.Properties.Resources.SelectAll_16x;
            this.popMenuSelectAll.Name = "popMenuSelectAll";
            this.popMenuSelectAll.Size = new System.Drawing.Size(169, 26);
            this.popMenuSelectAll.Text = "Выбрать все";
            this.popMenuSelectAll.Click += new System.EventHandler(this.popMenuSelectAll_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1195, 674);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.btnConvertStart);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1187, 645);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change List direction";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.rTextBoxChangeDirecTo);
            this.panel2.Controls.Add(this.btnTClearAll);
            this.panel2.Controls.Add(this.btnTDel);
            this.panel2.Controls.Add(this.btnTSelectAll);
            this.panel2.Controls.Add(this.btnTPaste);
            this.panel2.Controls.Add(this.btnTCopy);
            this.panel2.Controls.Add(this.btnTCut);
            this.panel2.Location = new System.Drawing.Point(626, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 548);
            this.panel2.TabIndex = 6;
            // 
            // rTextBoxChangeDirecTo
            // 
            this.rTextBoxChangeDirecTo.BackColor = System.Drawing.Color.White;
            this.rTextBoxChangeDirecTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTextBoxChangeDirecTo.ContextMenuStrip = this.contextMenuStrip1;
            this.rTextBoxChangeDirecTo.Location = new System.Drawing.Point(3, 40);
            this.rTextBoxChangeDirecTo.Name = "rTextBoxChangeDirecTo";
            this.rTextBoxChangeDirecTo.Size = new System.Drawing.Size(545, 505);
            this.rTextBoxChangeDirecTo.TabIndex = 1;
            this.rTextBoxChangeDirecTo.Text = "";
            this.rTextBoxChangeDirecTo.WordWrap = false;
            this.rTextBoxChangeDirecTo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rTextBoxChangeDirecTo_MouseDown);
            this.rTextBoxChangeDirecTo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rTextBoxChangeDirecTo_MouseMove);
            this.rTextBoxChangeDirecTo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rTextBoxChangeDirecTo_MouseUp);
            // 
            // btnTClearAll
            // 
            this.btnTClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTClearAll.Location = new System.Drawing.Point(12, 4);
            this.btnTClearAll.Name = "btnTClearAll";
            this.btnTClearAll.Size = new System.Drawing.Size(77, 31);
            this.btnTClearAll.TabIndex = 5;
            this.btnTClearAll.Text = "Clear all";
            this.btnTClearAll.UseVisualStyleBackColor = true;
            this.btnTClearAll.Click += new System.EventHandler(this.btnTClearAll_Click);
            // 
            // btnTDel
            // 
            this.btnTDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTDel.Image = global::abbConvertList.Properties.Resources.DeleteKPI_16x;
            this.btnTDel.Location = new System.Drawing.Point(398, 9);
            this.btnTDel.Name = "btnTDel";
            this.btnTDel.Size = new System.Drawing.Size(25, 25);
            this.btnTDel.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnTDel, "Delete");
            this.btnTDel.UseVisualStyleBackColor = true;
            this.btnTDel.Click += new System.EventHandler(this.btnTDel_Click);
            // 
            // btnTSelectAll
            // 
            this.btnTSelectAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTSelectAll.Image = global::abbConvertList.Properties.Resources.SelectAll_16x;
            this.btnTSelectAll.Location = new System.Drawing.Point(367, 9);
            this.btnTSelectAll.Name = "btnTSelectAll";
            this.btnTSelectAll.Size = new System.Drawing.Size(25, 25);
            this.btnTSelectAll.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnTSelectAll, "Select all");
            this.btnTSelectAll.UseVisualStyleBackColor = true;
            this.btnTSelectAll.Click += new System.EventHandler(this.btnTSelectAll_Click);
            // 
            // btnTPaste
            // 
            this.btnTPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTPaste.Image = global::abbConvertList.Properties.Resources.Paste_16x;
            this.btnTPaste.Location = new System.Drawing.Point(517, 9);
            this.btnTPaste.Name = "btnTPaste";
            this.btnTPaste.Size = new System.Drawing.Size(25, 25);
            this.btnTPaste.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnTPaste, "Paste");
            this.btnTPaste.UseVisualStyleBackColor = true;
            this.btnTPaste.Click += new System.EventHandler(this.btnTPaste_Click);
            // 
            // btnTCopy
            // 
            this.btnTCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTCopy.Image = global::abbConvertList.Properties.Resources.ASX_Copy_grey_16x;
            this.btnTCopy.Location = new System.Drawing.Point(456, 9);
            this.btnTCopy.Name = "btnTCopy";
            this.btnTCopy.Size = new System.Drawing.Size(25, 25);
            this.btnTCopy.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnTCopy, "Copy");
            this.btnTCopy.UseVisualStyleBackColor = true;
            this.btnTCopy.Click += new System.EventHandler(this.btnTCopy_Click);
            // 
            // btnTCut
            // 
            this.btnTCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTCut.Image = global::abbConvertList.Properties.Resources.Cut_16x;
            this.btnTCut.Location = new System.Drawing.Point(487, 9);
            this.btnTCut.Name = "btnTCut";
            this.btnTCut.Size = new System.Drawing.Size(25, 25);
            this.btnTCut.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnTCut, "Cut");
            this.btnTCut.UseVisualStyleBackColor = true;
            this.btnTCut.Click += new System.EventHandler(this.btnTCut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.rTextBoxChangeDirecFrom);
            this.panel1.Controls.Add(this.btnSClearAll);
            this.panel1.Controls.Add(this.btnSSelectAll);
            this.panel1.Controls.Add(this.btnSDel);
            this.panel1.Controls.Add(this.btnSCopy);
            this.panel1.Controls.Add(this.btnSPaste);
            this.panel1.Controls.Add(this.btnSCut);
            this.panel1.Location = new System.Drawing.Point(7, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 548);
            this.panel1.TabIndex = 6;
            // 
            // rTextBoxChangeDirecFrom
            // 
            this.rTextBoxChangeDirecFrom.BackColor = System.Drawing.Color.White;
            this.rTextBoxChangeDirecFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTextBoxChangeDirecFrom.ContextMenuStrip = this.contextMenuStrip1;
            this.rTextBoxChangeDirecFrom.Location = new System.Drawing.Point(3, 40);
            this.rTextBoxChangeDirecFrom.Name = "rTextBoxChangeDirecFrom";
            this.rTextBoxChangeDirecFrom.Size = new System.Drawing.Size(545, 505);
            this.rTextBoxChangeDirecFrom.TabIndex = 0;
            this.rTextBoxChangeDirecFrom.Text = "";
            this.rTextBoxChangeDirecFrom.WordWrap = false;
            this.rTextBoxChangeDirecFrom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rTextBoxChangeDirecFrom_MouseDown);
            this.rTextBoxChangeDirecFrom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rTextBoxChangeDirecFrom_MouseMove);
            this.rTextBoxChangeDirecFrom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rTextBoxChangeDirecFrom_MouseUp);
            // 
            // btnSClearAll
            // 
            this.btnSClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSClearAll.Location = new System.Drawing.Point(8, 4);
            this.btnSClearAll.Name = "btnSClearAll";
            this.btnSClearAll.Size = new System.Drawing.Size(77, 31);
            this.btnSClearAll.TabIndex = 5;
            this.btnSClearAll.Text = "Clear all";
            this.btnSClearAll.UseVisualStyleBackColor = true;
            this.btnSClearAll.Click += new System.EventHandler(this.btnSClearAll_Click);
            // 
            // btnSSelectAll
            // 
            this.btnSSelectAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSSelectAll.Image = global::abbConvertList.Properties.Resources.SelectAll_16x;
            this.btnSSelectAll.Location = new System.Drawing.Point(368, 9);
            this.btnSSelectAll.Name = "btnSSelectAll";
            this.btnSSelectAll.Size = new System.Drawing.Size(25, 25);
            this.btnSSelectAll.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSSelectAll, "Select all");
            this.btnSSelectAll.UseVisualStyleBackColor = true;
            this.btnSSelectAll.Click += new System.EventHandler(this.btnSSelectAll_Click);
            // 
            // btnSDel
            // 
            this.btnSDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSDel.Image = global::abbConvertList.Properties.Resources.DeleteKPI_16x;
            this.btnSDel.Location = new System.Drawing.Point(399, 9);
            this.btnSDel.Name = "btnSDel";
            this.btnSDel.Size = new System.Drawing.Size(25, 25);
            this.btnSDel.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSDel, "Delete");
            this.btnSDel.UseVisualStyleBackColor = true;
            this.btnSDel.Click += new System.EventHandler(this.btnSDel_Click);
            // 
            // btnSCopy
            // 
            this.btnSCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSCopy.Image = global::abbConvertList.Properties.Resources.ASX_Copy_grey_16x;
            this.btnSCopy.Location = new System.Drawing.Point(457, 9);
            this.btnSCopy.Name = "btnSCopy";
            this.btnSCopy.Size = new System.Drawing.Size(25, 25);
            this.btnSCopy.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSCopy, "Copy");
            this.btnSCopy.UseVisualStyleBackColor = true;
            this.btnSCopy.Click += new System.EventHandler(this.btnSCopy_Click);
            // 
            // btnSPaste
            // 
            this.btnSPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSPaste.Image = global::abbConvertList.Properties.Resources.Paste_16x;
            this.btnSPaste.Location = new System.Drawing.Point(518, 9);
            this.btnSPaste.Name = "btnSPaste";
            this.btnSPaste.Size = new System.Drawing.Size(25, 25);
            this.btnSPaste.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSPaste, "Paste");
            this.btnSPaste.UseVisualStyleBackColor = true;
            this.btnSPaste.Click += new System.EventHandler(this.btnSPaste_Click);
            // 
            // btnSCut
            // 
            this.btnSCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSCut.Image = global::abbConvertList.Properties.Resources.Cut_16x;
            this.btnSCut.Location = new System.Drawing.Point(488, 9);
            this.btnSCut.Name = "btnSCut";
            this.btnSCut.Size = new System.Drawing.Size(25, 25);
            this.btnSCut.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSCut, "Cut");
            this.btnSCut.UseVisualStyleBackColor = true;
            this.btnSCut.Click += new System.EventHandler(this.btnSCut_Click);
            // 
            // btnConvertStart
            // 
            this.btnConvertStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConvertStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConvertStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertStart.Image = global::abbConvertList.Properties.Resources.HistoricalInstructionPointer_16x;
            this.btnConvertStart.Location = new System.Drawing.Point(564, 45);
            this.btnConvertStart.Name = "btnConvertStart";
            this.btnConvertStart.Size = new System.Drawing.Size(56, 31);
            this.btnConvertStart.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnConvertStart, "Convert");
            this.btnConvertStart.UseVisualStyleBackColor = false;
            this.btnConvertStart.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(622, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Target:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Source:";
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 600;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 620);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ListItemsChanger";
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rTextBoxChangeDirecTo;
        private System.Windows.Forms.RichTextBox rTextBoxChangeDirecFrom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem popMenuCut;
        private System.Windows.Forms.ToolStripMenuItem popMenuCopy;
        private System.Windows.Forms.ToolStripMenuItem popMenuPast;
        private System.Windows.Forms.ToolStripMenuItem popMenuDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem popMenuSelectAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSSelectAll;
        private System.Windows.Forms.Button btnSPaste;
        private System.Windows.Forms.Button btnSCut;
        private System.Windows.Forms.Button btnSDel;
        private System.Windows.Forms.Button btnSCopy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConvertStart;
        private System.Windows.Forms.Button btnTPaste;
        private System.Windows.Forms.Button btnTCut;
        private System.Windows.Forms.Button btnTCopy;
        private System.Windows.Forms.Button btnTDel;
        private System.Windows.Forms.Button btnTSelectAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnTClearAll;
        private System.Windows.Forms.Button btnSClearAll;
    }
}
