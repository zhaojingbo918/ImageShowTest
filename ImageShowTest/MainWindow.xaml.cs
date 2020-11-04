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
using System.Windows.Threading;

namespace ImageShowTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        ImageBuilder imageBuilder = new ImageBuilder();
        DispatcherTimer m_Timer;
        public MainWindow()
        {
            InitializeComponent();


            m_Timer = new DispatcherTimer() { Interval = TimeSpan.FromMilliseconds(5) };
            m_Timer.Tick += M_Timer_Tick;
            m_Timer.Start();
        }

        private void M_Timer_Tick(object sender, EventArgs e)
        {
            this.image.Source = imageBuilder.CreateImage();
        }
    }
}
