/*
 * Created by SharpDevelop.
 * User: User
 * Date: 5/23/2023
 * Time: 1:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CheckList
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckedListBox PartList;
		private System.Windows.Forms.TextBox PartPath;
		private System.Windows.Forms.Button OpnPrt;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button Dell1C;
		private System.Windows.Forms.ListBox List1C;
		private System.Windows.Forms.Button Add1C;
		private System.Windows.Forms.Button Compare;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PartList = new System.Windows.Forms.CheckedListBox();
			this.PartPath = new System.Windows.Forms.TextBox();
			this.OpnPrt = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.List1C = new System.Windows.Forms.ListBox();
			this.Dell1C = new System.Windows.Forms.Button();
			this.Add1C = new System.Windows.Forms.Button();
			this.Compare = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.PartList);
			this.groupBox1.Controls.Add(this.PartPath);
			this.groupBox1.Controls.Add(this.OpnPrt);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(421, 187);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Выбор файла с перечнем";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(409, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Выбор листов документа для сравнения";
			// 
			// PartList
			// 
			this.PartList.FormattingEnabled = true;
			this.PartList.Location = new System.Drawing.Point(6, 70);
			this.PartList.Name = "PartList";
			this.PartList.Size = new System.Drawing.Size(409, 109);
			this.PartList.TabIndex = 2;
			// 
			// PartPath
			// 
			this.PartPath.Location = new System.Drawing.Point(75, 21);
			this.PartPath.Name = "PartPath";
			this.PartPath.ReadOnly = true;
			this.PartPath.Size = new System.Drawing.Size(340, 20);
			this.PartPath.TabIndex = 1;
			// 
			// OpnPrt
			// 
			this.OpnPrt.Location = new System.Drawing.Point(6, 19);
			this.OpnPrt.Name = "OpnPrt";
			this.OpnPrt.Size = new System.Drawing.Size(63, 23);
			this.OpnPrt.TabIndex = 0;
			this.OpnPrt.Text = "Открыть";
			this.OpnPrt.UseVisualStyleBackColor = true;
			this.OpnPrt.Click += new System.EventHandler(this.OpnPrtClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.List1C);
			this.groupBox2.Controls.Add(this.Dell1C);
			this.groupBox2.Controls.Add(this.Add1C);
			this.groupBox2.Location = new System.Drawing.Point(13, 206);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(421, 157);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Выбор файлов экспорта 1C";
			// 
			// List1C
			// 
			this.List1C.FormattingEnabled = true;
			this.List1C.HorizontalScrollbar = true;
			this.List1C.Location = new System.Drawing.Point(75, 19);
			this.List1C.Name = "List1C";
			this.List1C.Size = new System.Drawing.Size(340, 134);
			this.List1C.TabIndex = 6;
			// 
			// Dell1C
			// 
			this.Dell1C.Location = new System.Drawing.Point(6, 48);
			this.Dell1C.Name = "Dell1C";
			this.Dell1C.Size = new System.Drawing.Size(63, 23);
			this.Dell1C.TabIndex = 5;
			this.Dell1C.Text = "-";
			this.Dell1C.UseVisualStyleBackColor = true;
			this.Dell1C.Click += new System.EventHandler(this.Dell1CClick);
			// 
			// Add1C
			// 
			this.Add1C.Location = new System.Drawing.Point(6, 19);
			this.Add1C.Name = "Add1C";
			this.Add1C.Size = new System.Drawing.Size(63, 23);
			this.Add1C.TabIndex = 0;
			this.Add1C.Text = "+";
			this.Add1C.UseVisualStyleBackColor = true;
			this.Add1C.Click += new System.EventHandler(this.Add1CClick);
			// 
			// Compare
			// 
			this.Compare.Location = new System.Drawing.Point(13, 369);
			this.Compare.Name = "Compare";
			this.Compare.Size = new System.Drawing.Size(421, 23);
			this.Compare.TabIndex = 5;
			this.Compare.Text = "Обновить статус деталей";
			this.Compare.UseVisualStyleBackColor = true;
			this.Compare.Click += new System.EventHandler(this.CompareClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 398);
			this.Controls.Add(this.Compare);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "CheckList";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
