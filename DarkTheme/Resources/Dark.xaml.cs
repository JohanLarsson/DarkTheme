namespace DarkTheme;

using System.Windows;

public partial class Dark
{
    private void OnMinimizeClick(object sender, RoutedEventArgs e)
    {
        if (e.Source is FrameworkElement fe &&
            Window.GetWindow(fe) is { } window)
        {
            window.WindowState = WindowState.Minimized;
        }
    }

    private void OnNormalClick(object sender, RoutedEventArgs e)
    {
        if (e.Source is FrameworkElement fe &&
            Window.GetWindow(fe) is { } window)
        {
            window.WindowState = WindowState.Normal;
        }
    }

    private void OnMaximizeClick(object sender, RoutedEventArgs e)
    {
        if (e.Source is FrameworkElement fe &&
            Window.GetWindow(fe) is { } window)
        {
            window.WindowState = WindowState.Maximized;
        }
    }

    private void OnCloseClick(object sender, RoutedEventArgs e)
    {
        if (e.Source is FrameworkElement fe &&
            Window.GetWindow(fe) is { } window)
        {
            window.Close();
        }
    }
}