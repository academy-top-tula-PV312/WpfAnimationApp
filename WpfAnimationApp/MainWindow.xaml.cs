using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Media.Animation;

namespace WpfAnimationApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation btnWidthAnimation = new DoubleAnimation();
            btnWidthAnimation.From = btn.ActualWidth;
            btnWidthAnimation.To = 50;
            btnWidthAnimation.Duration = TimeSpan.FromSeconds(2);
            btnWidthAnimation.RepeatBehavior = new RepeatBehavior(2);
            btnWidthAnimation.AutoReverse = true;
            btnWidthAnimation.Completed += BtnWidthAnimation_Completed;

            DoubleAnimation btnHeightAnimation = new DoubleAnimation();
            btnHeightAnimation.From = btn.ActualHeight;
            btnHeightAnimation.To = 250;
            btnHeightAnimation.Duration = TimeSpan.FromSeconds(2);
            btnHeightAnimation.RepeatBehavior = new RepeatBehavior(2);
            btnHeightAnimation.AutoReverse = true;
            


            //ColorAnimation btnColorAnimation = new ColorAnimation();
            //btnColorAnimation.From = Colors.Red;
            //btnColorAnimation.To = Colors.Blue;
            //btnWidthAnimation.Duration = TimeSpan.FromSeconds(2);
            //btnWidthAnimation.RepeatBehavior = new RepeatBehavior(2);
            //btnWidthAnimation.AutoReverse = true;

            btn.BeginAnimation(Button.WidthProperty, btnWidthAnimation);
            btn.BeginAnimation(Button.HeightProperty, btnHeightAnimation);
        }

        private void BtnWidthAnimation_Completed(object? sender, EventArgs e)
        {
            btn.Content = "Animation Completed";
        }
    }
}