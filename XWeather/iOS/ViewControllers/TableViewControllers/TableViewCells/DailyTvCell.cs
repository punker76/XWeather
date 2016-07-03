using System;

using Foundation;
using UIKit;
using XWeather.Domain;

namespace XWeather.iOS
{
	public partial class DailyTvCell : BaseTvCell
	{
		public DailyTvCell (IntPtr handle) : base (handle) { }

		public void SetData (ForecastDay forecast)
		{
			dayLabel.Text = forecast.date.weekday;
			precipLabel.Text = $"{forecast.pop}%";
			highTempLabel.Text = $"{forecast.high.FahrenheitValue}°";
			lowTempLabel.Text = $"{forecast.low.FahrenheitValue}°";
		}
	}
}