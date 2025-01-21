namespace DarkTheme;

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class MainViewModel : INotifyPropertyChanged
{
    private bool _isChecked;

    public event PropertyChangedEventHandler? PropertyChanged;

    public ObservableCollection<Item> Items { get; } = [
        new Item{ Name = "Chad", Score = 5 },
        new Item{ Name = "Virgin", Score = 1 },
    ];

    public bool IsChecked
    {
        get => _isChecked;
        set
        {
            if (value == _isChecked) return;
            _isChecked = value;
            OnPropertyChanged();
        }
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}