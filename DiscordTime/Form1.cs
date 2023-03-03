using System.Globalization;

namespace DiscordTime
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			for (int i = 0; i < Enum.GetValues(typeof(Formats)).Length; i++) // Populates the list making sure the index of the list matches the int value of each Enum
			{
				FormatsBox.Items.Add(FormatsBoxLabel((Formats)i));
			}
			FormatsBox.SelectedIndex = 0;
			dateTimePicker1.Value = DateTime.Now;
			BackColor = Color.FromArgb(86, 98, 246);
			TopMost = true;
		}

		private static string FormatsBoxLabel(Formats format)
		{
			return new CultureInfo("en-US", false).TextInfo.ToTitleCase(format.ToString().ToLower().Replace("_", " "));

		}

		public static string Timestamp(DateTime dateTime, Formats format = Formats.SHORT_DATE_TIME)
		{
			double seconds = (new DateTimeOffset(dateTime).ToUniversalTime() - DateTime.UnixEpoch).TotalSeconds;
			return $"<t:{(int)seconds}:{FormatString(format)}>";
		}

		private void CopyToClipboard(object sender, EventArgs e)
		{
			System.Windows.Forms.Clipboard.SetText(TimestampLabel.Text);
		}

		private void CalculateTimestamp()
		{
			TimestampLabel.Text = Timestamp(dateTimePicker1.Value, (Formats)FormatsBox.SelectedIndex);
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			CalculateTimestamp();
		}

		private void FormatsBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			CalculateTimestamp();
		}

		public static string FormatString(Formats format)
		{
			switch (format)
			{
				case Formats.SHORT_DATE_TIME:
					return "f";
				case Formats.LONG_DATE_TIME:
					return "F";
				case Formats.SHORT_DATE:
					return "d";
				case Formats.LONG_DATE:
					return "D";
				case Formats.SHORT_TIME:
					return "t";
				case Formats.LONG_TIME:
					return "T";
				case Formats.RELATIVE:
					return "R";
				default:
					throw new ArgumentException("You gave an option of the Formats class that I don't know how to deal with.");
			}
		}
	}

	public enum Formats
	{
		SHORT_DATE_TIME,
		LONG_DATE_TIME,
		SHORT_DATE,
		LONG_DATE,
		SHORT_TIME,
		LONG_TIME,
		RELATIVE
	}
}