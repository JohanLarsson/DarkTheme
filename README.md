# DarkTheme

Based on [AngryCarrot789/WPFDarkTheme](https://github.com/AngryCarrot789/WPFDarkTheme)

![image](https://github.com/user-attachments/assets/1d886289-9f3b-4f3b-a853-5a9481e9cb7a)

Simple dark theme for copy.
1. Copy `Dark.xaml` and `Dark.Xaml.cs` to your project
2. Fix namespace in xaml and code behind
3. Reference in App.xaml, see sample below
4. Due to WPF being weird explicit setting of stye on window is needed `Style="{StaticResource {x:Type Window}}"`

```xaml
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="Resources/Dark.xaml"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
```
