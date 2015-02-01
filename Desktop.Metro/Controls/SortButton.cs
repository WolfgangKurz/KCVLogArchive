﻿using System.Windows;

namespace Desktop.Metro.Controls
{
	public class SortButton : CallMethodButton
	{
		static SortButton()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(SortButton), new FrameworkPropertyMetadata(typeof(SortButton)));
		}

		#region Direction 依存関係プロパティ

		public SortDirection Direction
		{
			get { return (SortDirection)this.GetValue(DirectionProperty); }
			set { this.SetValue(DirectionProperty, value); }
		}
		public static readonly DependencyProperty DirectionProperty =
			DependencyProperty.Register("Direction", typeof(SortDirection), typeof(SortButton), new UIPropertyMetadata(SortDirection.None));

		#endregion
	}
}
