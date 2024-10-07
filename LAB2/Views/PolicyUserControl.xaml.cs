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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB2.Views
{
    /// <summary>
    /// Interaction logic for PolicyUserControl.xaml
    /// </summary>
    public partial class PolicyUserControl : UserControl
    {
        public PolicyUserControl()
        {
            InitializeComponent();

            DoubleAnimation buttonAnimation = new DoubleAnimation();
            buttonAnimation.From = img.ActualWidth;
            buttonAnimation.To = 150;
            buttonAnimation.Duration = TimeSpan.FromSeconds(3);

            buttonAnimation.AutoReverse = true;
            buttonAnimation.RepeatBehavior = RepeatBehavior.Forever;

            img.BeginAnimation(Button.WidthProperty, buttonAnimation);
        }
    }
}
