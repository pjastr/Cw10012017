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

namespace WpfApplication12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Osoba osoba1;
        public MainWindow()
        {
            InitializeComponent();
            osoba1 = new Osoba();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string tekst = Data.Text;
            //DateTime data;
            //if (DateTime.TryParse(tekst, out data))
            //{
            //    osoba1.UstawDane(Imie.Text, Nazwisko.Text, data);
            //    Opis.Text = osoba1.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("błędna data");
            //}
            osoba1.UstawDane(Imie.Text, Nazwisko.Text, Data2.SelectedDate.Value.Date);
            Opis.Text = osoba1.ToString();
                
        }
    }
}
