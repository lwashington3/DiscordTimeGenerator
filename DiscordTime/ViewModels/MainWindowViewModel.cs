using System;
using System.Collections.ObjectModel;
using DiscordTime.Views;

namespace DiscordTime.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
	private ObservableCollection<FormatItem> _formats;

	public ObservableCollection<FormatItem> FormatsList
	{
		get => _formats;
		set
		{
			_formats = value;
		}
	}

	public int DateTimeHeight => 30;
	public int TimestampHeight => 18;

	public MainWindowViewModel() : base()
	{
		FormatsList = new ObservableCollection<FormatItem>();
		
		foreach (Formats format in Enum.GetValues<Formats>())
		{
			FormatsList.Add(new FormatItem(format));
		}
	}
	
#pragma warning disable CA1822 // Mark members as static
	public string Greeting => "Welcome to Avalonia! This is my added text.";
#pragma warning restore CA1822 // Mark members as static
}