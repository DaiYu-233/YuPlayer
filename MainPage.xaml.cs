using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace YuPlayer
{
    /// <summary>
    /// MainPage.xaml 的交互逻辑
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AutoSuggestBox_QuerySubmitted(iNKORE.UI.WPF.Modern.Controls.AutoSuggestBox sender, iNKORE.UI.WPF.Modern.Controls.AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            Debug.WriteLine("ssss");
        }
    }
}
