using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Collection.Pages
{
    /// <summary>
    /// Interaction logic for TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        public TestPage()
        {
            InitializeComponent();
            DrawTetrisBlock();
            //Words();
        }

        public void Words()
        {
            FormattedText atoz = new FormattedText("ABC...XYZ", CultureInfo.CurrentCulture, 
                FlowDirection.LeftToRight, new Typeface("Arial"), 50.0, Brushes.Black);
            Geometry geo = atoz.BuildGeometry(new Point(0, 0));
            geoDrawing.Geometry = geo;
            geoDrawing.Pen = new Pen(Brushes.Black, 1.0);
            geoDrawing.Brush = Brushes.Yellow;
        }

        public void DrawTetrisBlock()
        {
//            var ellipses = new GeometryGroup();
//            geoDrawing.Geometry = ellipses;
//
//            // Paint the drawing with a gradient.
//            geoDrawing.Brush = new LinearGradientBrush(
//                    Colors.SkyBlue,
//                    Colors.SteelBlue,
//                    new Point(0, 0),
//                    new Point(0, 1));
//
//            // Outline the drawing with a solid color.
//            geoDrawing.Pen = new Pen(Brushes.Black, 2);            
//            
//            
//            ellipses.Children.Add(new RectangleGeometry(new Rect(0, 0, 20, 20), 0, 0));
//            ellipses.Children.Add(new RectangleGeometry(new Rect(0, 20, 20, 20), 0, 0));
//            ellipses.Children.Add(new RectangleGeometry(new Rect(20, 20, 20, 20), 0, 0));
//            ellipses.Children.Add(new RectangleGeometry(new Rect(0, 40, 20, 20), 0, 0));

        }
    }
}
