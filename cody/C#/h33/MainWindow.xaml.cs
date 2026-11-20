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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //TextBlock.Text = "This is how button works!";
            //SecretText.Text = "";

            string vstup1 = Den.Text;
            string vstup2 = Mesic.Text;
            string vstup3 = Rok.Text;

            int den, rok, mesic;

            if (
                    !int.TryParse(vstup1, out den) ||
                    !int.TryParse(vstup2, out mesic) || 
                    !int.TryParse(vstup3, out rok)
                )
            {
                GTA.Text = "ERROR!";
                return;   
            }
            
            if (rok >= 2027)
            {
                GTA.Text = "GTA VI vysla";
                return;
            }
            else if (rok == 2026)
            {
                if (mesic == 12)
                {
                    GTA.Text = "GTA VI vysla";
                    return;
                }
                else if (mesic == 11)
                {
                    if (den >= 19)
                    {
                        GTA.Text = "GTA VI vysla";
                        return;
                    }
                }
            }

            GTA.Text = "GTA VI NEvysla";
            return;

            //if (!double.TryParse(text, out double res))
            //{
            //    GTA.Text = "ERROR!";
            //    return;
            //}
            //GTA.Text = $"Dvojnasovek : {res * 2}";

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //TextBlock.Text = TextBox.Text;
            //if (TextBox.Text == "secret")
            //{
            //    SecretText.Text = "You found a SECRET!";
            //    //Body.Background = "#FFC7EEFF";
            //}
        }
    }
}