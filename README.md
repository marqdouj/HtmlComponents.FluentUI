# HtmlComponents.FluentUI
- This is a collection of custom Html components based on FluentUI-Blazor.
- How to setup and configure [FluentUI-Blazor](https://www.fluentui-blazor.net/). 

## Demo
- The local 'Sandbox' project contains a demo on using the components
- A demo of this and some of my other NuGet packages can be found [here](https://github.com/marqdouj/BlazorSandbox)

## NuGet Package
- https://www.nuget.org/packages/Marqdouj.HtmlComponent.FluenUI/

## Components
- **ColorPicker**: Component for selecting an HTML Color Name
  - uses the HtmlColorName enum in my [HTML Common](https://github.com/marqdouj/HTMLCommon) NuGet package.
- [**Themes**](https://www.fluentui-blazor.net/DesignTheme)
  - **ThemeSwitch**: Component for toggling between light and dark themes.
  - **ThemeMode**: Component for selecting between system, light, and dark themes.
  - **ThemeColor**: Component for selecting theme color.
- **UIInput**. Components for user input that support binding to [`IUIModelValue`](https://github.com/marqdouj/HtmlComponents/tree/master/src/Marqdouj.HtmlComponents/Marqdouj.HtmlComponents/UI).
  - `UIColor`: Select from a list of HtmlColors (list of items is customizable).
  - `UISelect`: Select a value from a list (list of items is customizable).
  - `UIText`: Supports string, double, int32, and int64 binding.
  - `UIValuesGrid`: Displays the UIModel values as a grid.

## Release Notes
**8.1.0**
- `UIInput`. Added components.

**8.0.4**
- Update NuGet packages.

**8.0.3**
- `ColorPicker`. Added option to dilsplay the selected color adjacent to the control

**8.0.2**
- Updated NuGet pkgs

**8.0.1**
- Updated NuGet pkgs

**8.0.0**
- Added ColorPicker component
- Added Theme components
- Created Package
