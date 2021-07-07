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

namespace Notepad
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        Thickness LeftSide = new Thickness(-39, 0, 0, 0);
        Thickness RightSide = new Thickness(0, 0, -39, 0);
        SolidColorBrush firstcolor = new SolidColorBrush(Color.FromRgb(250, 0, 0));
        SolidColorBrush secondcolor = new SolidColorBrush(Color.FromRgb(130, 190, 125));
        public bool pressed { get; set; } = false;
        public UserControl1()
        {
            InitializeComponent();
            InitializeComponent();
            pressed = false;
            Dot.Margin = LeftSide;
            Back.Fill = firstcolor;
        }

        private void Dot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (pressed == false)
            {
                Dot.Margin = RightSide;
                Back.Fill = secondcolor;
                pressed = true;
            }
            else if (pressed)
            {
                Dot.Margin = LeftSide;
                Back.Fill = firstcolor;
                pressed = false;
            }
        }
    }
}
