using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Text.RegularExpressions;

namespace DiscordTime.Views;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
		
		DateFormats.SelectedIndex = 0;
		Date.SelectedDate = DateTime.Today;
		Time.SelectedTime = DateTime.Now.TimeOfDay;
		Width = 525;
		Height = 80; //Color: 86, 98, 246
	}
	
	private void Button_OnClick(object? sender, RoutedEventArgs e)
	{
		Clipboard.SetTextAsync(Timestamp.Text).Wait();
	}

	private void Time_OnSelectedTimeChanged(object? sender, TimePickerSelectedValueChangedEventArgs e)
	{
		SetTimestamp();
	}
	
	private void Date_OnSelectedDateChanged(object? sender, SelectionChangedEventArgs e)
	{
		SetTimestamp();
	}
	
	private void SetTimestamp()
	{
		if (Date?.SelectedDate is null || Time?.SelectedTime is null || DateFormats.SelectedIndex == -1)
		{
			return;
		}

		CalendarDatePicker date = Date;
		TimePicker time = Time;
		Formats format = ((FormatItem)DateFormats.SelectedItem)?.Format ?? Formats.ShortDateTime;

		DateTimeOffset offset = new DateTimeOffset((DateTime)date.SelectedDate).Add((TimeSpan)time.SelectedTime);

		double seconds = (offset.ToUniversalTime() - DateTime.UnixEpoch).TotalSeconds;
		Timestamp.Text = $"<t:{(int)seconds}:{FormatString(format)}>";
	}

	public static string FormatString(Formats format)
	{
		switch (format)
		{
			case Formats.ShortDateTime:
				return "f";
			case Formats.LongDateTime:
				return "F";
			case Formats.ShortDate:
				return "d";
			case Formats.LongDate:
				return "D";
			case Formats.ShortTime:
				return "t";
			case Formats.LongTime:
				return "T";
			case Formats.Relative:
				return "R";
			default:
				throw new ArgumentException(
					"You gave an option of the Formats class that I don't know how to deal with.");
		}
	}

	private void Window_OnLoaded(object? sender, RoutedEventArgs e)
	{
		if (DateFormats.SelectedIndex == -1)
		{
			DateFormats.SelectedIndex = 0;
		}
	}
}

public enum Formats
{
	ShortDateTime,
	LongDateTime,
	ShortDate,
	LongDate,
	ShortTime,
	LongTime,
	Relative
}

public class FormatItem
{
	private Formats _format;
	private string _formattedString;
	
	public Formats Format
	{
		get => _format;
		set
		{
			_format = value;
			_formattedString = Regex.Replace(value.ToString(), "([a-z])([A-Z])", "$1 $2");
		}
	}

	public string Text => _formattedString;
	
	public FormatItem(Formats format)
	{
		Format = format;
	}
}