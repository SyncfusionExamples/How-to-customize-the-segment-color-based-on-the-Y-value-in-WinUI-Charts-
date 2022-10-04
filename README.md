This article explains how to set the different colors for the chart column segments based on its Y value in the [WinUI charts](https://www.syncfusion.com/winui-controls/charts).

WinUI charts allow you to customize the appearance of the series segments color by adding your own brushes in the preferred order and applying for the series [PaletteBrushes](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSeriesBase.html#Syncfusion_UI_Xaml_Charts_ChartSeriesBase_PaletteBrushes) property.

Consider the use-case to apply different colors for the column segments based on some ranges, i.e., set CadetBlue color for the segment’s Y value less than 20, set Gray color for the segment’s Y value between 20 and 40, and set Orange color for the segment’s value greater than 40. It has been achieved by setting the series [PaletteBrushes](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSeriesBase.html#Syncfusion_UI_Xaml_Charts_ChartSeriesBase_PaletteBrushes) property with its own Brush collection as in the below code example.

```
<chart:ColumnSeries ItemsSource="{Binding Data}"
                    XBindingPath="XValue" YBindingPath="YValue"
                    ShowDataLabels="True"
                    PaletteBrushes="{Binding CustomBrushes}">
 </chart:ColumnSeries>
```

```
public ObservableCollection<Brush> CustomBrushes { get; set; }

…
CustomBrushes = new ObservableCollection<Brush>();

foreach (var item in Data)
{
    if (item.YValue <= 20)
    {
        CustomBrushes.Add(new SolidColorBrush(Colors.CadetBlue));
    }
    else if (item.YValue > 20 && item.YValue <= 40)
    {
        CustomBrushes.Add(new SolidColorBrush(Colors.DarkGray));
    }
    else if (item.YValue >= 40) 
    {
        CustomBrushes.Add(new SolidColorBrush(Colors.Orange));
    }
}
```

## Output:

![Customized WinUI chart column series segment color based on the Y values](https://user-images.githubusercontent.com/53489303/193756740-cd6db33b-6100-4dd3-8891-71c53bec5eb6.png)

KB article - [How to customize the segment color based on the Y value in WinUI Charts?]()

## See also

[How to customize the appearance in WinUI Chart (SfCartesianChart)?](https://help.syncfusion.com/winui/cartesian-charts/appearance)

[How to create a Column Chart in WinUI?](https://www.syncfusion.com/kb/13539/how-to-create-a-column-chart-in-winui)
