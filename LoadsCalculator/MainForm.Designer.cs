/*
 * Created by SharpDevelop.
 * User: 106049
 * Date: 04/05/2017
 * Time: 09:24 ص
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LoadsCalculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox VoltageCombo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton AmpToKvaRadio;
		private System.Windows.Forms.RadioButton KvaToARadio;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Label inputLabel;
		private System.Windows.Forms.Label outputLabel;
		private System.Windows.Forms.TextBox outputText;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.VoltageCombo = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.AmpToKvaRadio = new System.Windows.Forms.RadioButton();
			this.KvaToARadio = new System.Windows.Forms.RadioButton();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.inputLabel = new System.Windows.Forms.Label();
			this.outputLabel = new System.Windows.Forms.Label();
			this.outputText = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Stencil", 12F);
			this.label1.Location = new System.Drawing.Point(30, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Voltage:";
			// 
			// VoltageCombo
			// 
			this.VoltageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VoltageCombo.Font = new System.Drawing.Font("Stencil", 12F);
			this.VoltageCombo.FormattingEnabled = true;
			this.VoltageCombo.Items.AddRange(new object[] {
			"400V",
			"231V",
			"13.8KV",
			"33KV"});
			this.VoltageCombo.Location = new System.Drawing.Point(124, 14);
			this.VoltageCombo.Name = "VoltageCombo";
			this.VoltageCombo.Size = new System.Drawing.Size(93, 27);
			this.VoltageCombo.TabIndex = 1;
			this.VoltageCombo.SelectedIndexChanged += new System.EventHandler(this.VoltageComboSelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.AmpToKvaRadio);
			this.groupBox1.Controls.Add(this.KvaToARadio);
			this.groupBox1.Location = new System.Drawing.Point(8, 47);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(377, 58);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// AmpToKvaRadio
			// 
			this.AmpToKvaRadio.Font = new System.Drawing.Font("Stencil", 12F);
			this.AmpToKvaRadio.Location = new System.Drawing.Point(203, 19);
			this.AmpToKvaRadio.Name = "AmpToKvaRadio";
			this.AmpToKvaRadio.Size = new System.Drawing.Size(168, 24);
			this.AmpToKvaRadio.TabIndex = 1;
			this.AmpToKvaRadio.Text = " Ampere to KVA";
			this.AmpToKvaRadio.UseVisualStyleBackColor = true;
			this.AmpToKvaRadio.CheckedChanged += new System.EventHandler(this.AmpToKvaRadioCheckedChanged);
			// 
			// KvaToARadio
			// 
			this.KvaToARadio.Checked = true;
			this.KvaToARadio.Font = new System.Drawing.Font("Stencil", 12F);
			this.KvaToARadio.Location = new System.Drawing.Point(6, 19);
			this.KvaToARadio.Name = "KvaToARadio";
			this.KvaToARadio.Size = new System.Drawing.Size(156, 24);
			this.KvaToARadio.TabIndex = 0;
			this.KvaToARadio.TabStop = true;
			this.KvaToARadio.Text = "KVA to Ampere";
			this.KvaToARadio.UseVisualStyleBackColor = true;
			this.KvaToARadio.CheckedChanged += new System.EventHandler(this.KvaToARadioCheckedChanged);
			// 
			// inputTextBox
			// 
			this.inputTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
			this.inputTextBox.Font = new System.Drawing.Font("Stencil", 12F);
			this.inputTextBox.Location = new System.Drawing.Point(8, 111);
			this.inputTextBox.MaxLength = 9;
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(88, 26);
			this.inputTextBox.TabIndex = 0;
			this.inputTextBox.Text = "0";
			this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.inputTextBox.TextChanged += new System.EventHandler(this.InputTextBoxTextChanged);
			this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBoxKeyPress);
			// 
			// inputLabel
			// 
			this.inputLabel.Font = new System.Drawing.Font("Stencil", 12F);
			this.inputLabel.Location = new System.Drawing.Point(107, 112);
			this.inputLabel.Name = "inputLabel";
			this.inputLabel.Size = new System.Drawing.Size(110, 23);
			this.inputLabel.TabIndex = 4;
			this.inputLabel.Text = "KVA equals ";
			this.inputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// outputLabel
			// 
			this.outputLabel.Font = new System.Drawing.Font("Stencil", 12F);
			this.outputLabel.Location = new System.Drawing.Point(344, 111);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(41, 23);
			this.outputLabel.TabIndex = 5;
			this.outputLabel.Text = "A";
			this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// outputText
			// 
			this.outputText.Font = new System.Drawing.Font("Stencil", 12F);
			this.outputText.Location = new System.Drawing.Point(223, 111);
			this.outputText.MaxLength = 12;
			this.outputText.Name = "outputText";
			this.outputText.ReadOnly = true;
			this.outputText.Size = new System.Drawing.Size(115, 26);
			this.outputText.TabIndex = 6;
			this.outputText.Text = "0";
			this.outputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(397, 149);
			this.Controls.Add(this.outputText);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.inputLabel);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.VoltageCombo);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "KVA/Ampere converter";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
