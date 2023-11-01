using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            uxColorSelect.DataContext = GetColorList();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            var r = (byte)rSlider.Value;
            var g = (byte)gSlider.Value;
            var b = (byte)bSlider.Value;
            colorArea.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void StockButton_Click(object sender, RoutedEventArgs e) {
            var R = (byte)rSlider.Value;
            var G = (byte)gSlider.Value;
            var B = (byte)bSlider.Value;
            var color = Color.FromRgb(R, G, B);
            var name = GetColorList().FirstOrDefault(c => c.Color == color)?.Name;
            ColorList.Items.Add(
                new MyColor {
                    Color = color,
                    Name = name
                });
        }

        private void uxColorSelect_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            ColorSet(mycolor);
        }

        private void ColorList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ListBox)sender).SelectedItem;
            ColorSet(mycolor);
        }

        private void ColorSet(MyColor mycolor) {
            var color = mycolor.Color;
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }

            public override string ToString() {
                return Name ?? $"R:{Color.R} G:{Color.G} B:{Color.B}";
            }
        }
    }
}
