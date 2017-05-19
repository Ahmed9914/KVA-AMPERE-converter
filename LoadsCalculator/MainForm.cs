using System;
using System.Windows.Forms;

namespace LoadsCalculator
{
	public partial class MainForm : Form
	{
		
		const string kva = "kva";
		const string ampere = "a";
		
		// Voltages
		const double LV_400V = 0.4;
		const double LV_231V = 0.231;
		const double MV_13V = 13.8;
		const double MV_33V = 33.0;
		double getVoltage(int comboIndex)
		{
			if  (comboIndex == 0) return LV_400V;
			if (comboIndex == 1) return LV_231V;
			if (comboIndex == 2) return MV_13V;
			if (comboIndex== 3) return MV_33V;
			return -1.0;
			
		}
		
		double converter(string from, double input, double voltLevel)
		{
			if (from.Equals(kva))
			{
				return input / (Math.Sqrt(3) * voltLevel);
			}
			if (from.Equals(ampere))
			{
				return input * (Math.Sqrt(3) * voltLevel);
			}
			return -1.0;
			
		}
		
		public MainForm()
		{
			InitializeComponent();
			
			VoltageCombo.SelectedIndex = 0;
		}
		
		void KvaToARadioCheckedChanged(object sender, EventArgs e)
		{
			if (KvaToARadio.Checked)
			{
				inputLabel.Text = "KVA equals ";
				outputLabel.Text = "A";
				string result = Math.Round(converter(kva, double.Parse(inputTextBox.Text),
				                                     getVoltage(VoltageCombo.SelectedIndex)),3).ToString();
				// Check we have input or no
				outputText.Text = result;
					
			}
	
		}
		
		void AmpToKvaRadioCheckedChanged(object sender, EventArgs e)
		{
			if (AmpToKvaRadio.Checked)
			{
				inputLabel.Text = "A equals ";
				outputLabel.Text = "KVA";
				string result = Math.Round(converter(ampere, double.Parse(inputTextBox.Text),
				                                     getVoltage(VoltageCombo.SelectedIndex)), 3).ToString();
				// Check we have input or no
				outputText.Text = result;
			}
	
		}
		
		void InputTextBoxTextChanged(object sender, EventArgs e)
		{
			double s;
			if (Double.TryParse(inputTextBox.Text, out s)) {
				if (AmpToKvaRadio.Checked) {
					outputText.Text = Math.Round(converter(ampere, s,
							getVoltage(VoltageCombo.SelectedIndex)), 3).ToString();
				
				}
				
				if (KvaToARadio.Checked) {
					outputText.Text = Math.Round(converter(kva, s,
							getVoltage(VoltageCombo.SelectedIndex)), 3).ToString();
				
				}
				
			}
			else 
			{
				outputText.Text = "0";
			}
			
	
		}
		
		void InputTextBoxKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
				e.Handled = true;
	
		}
		
		void VoltageComboSelectedIndexChanged(object sender, EventArgs e)
		{
			outputText.Text = "0";
			double s;
			if (Double.TryParse(inputTextBox.Text, out s)) {
				if (AmpToKvaRadio.Checked) {
					outputText.Text = Math.Round(converter(ampere, s,
							getVoltage(VoltageCombo.SelectedIndex)), 3).ToString();
				
				}
				
				if (KvaToARadio.Checked) {
					outputText.Text = Math.Round(converter(kva, s,
							getVoltage(VoltageCombo.SelectedIndex)), 3).ToString();
				
				}
				
			}
	
		}
		
		
	}
}
