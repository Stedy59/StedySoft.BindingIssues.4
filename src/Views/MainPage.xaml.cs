using System;

using Microsoft.Maui.Controls;

namespace StedySoft.BindingIssues.Views {

	public partial class MainPage : ContentPage {

		public MainPage() =>
			this.InitializeComponent();

		public static readonly BindableProperty CheckBoxIsCheckedProperty =
			BindableProperty.Create(
				nameof(MainPage.CheckBoxIsChecked),
				typeof(bool),
				typeof(MainPage),
				true);

		public bool CheckBoxIsChecked {
			get => (bool)this.GetValue(MainPage.CheckBoxIsCheckedProperty);
			set => this.SetValue(MainPage.CheckBoxIsCheckedProperty, value);
		}

		private void OnSetBackingPropertyClicked(object sender, EventArgs e) =>
			this.CheckBoxIsChecked = !this.CheckBoxIsChecked;

		private void OnSetControlPropertyClicked(object sender, EventArgs e) =>
			this.CheckBoxControl.IsChecked = !this.CheckBoxControl.IsChecked;

	}

}
