using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace HelloWorldWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static ResourceDictionary d;
        public MainWindow()
        {
            InitializeComponent();
            string s;
            try
            {
                d = this.FindResource(CultureInfo.CurrentCulture.TwoLetterISOLanguageName) as ResourceDictionary;
            }
            catch (ResourceReferenceKeyNotFoundException ex)
            { d = this.FindResource("en") as ResourceDictionary; }
            numeronesoft.Text = d["numeronesoft"] as string;
            inseriscinome.Text = d["inseriscinome"] as string;
        }
        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            String s = d["ciao"] as String;
            String s1 = d["festafinita"] as String;
            ciaofrancesca.Text = s + " " + Nome.Text + " " + s1;
            Ok.IsEnabled = false;
        }
    }
}
