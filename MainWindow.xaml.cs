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

namespace Week_9_Enumerables_and_images
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FillComboBox();



            
        }//MainWindow


        public void FillComboBox()
        {
            Art nighthawks = new Art("Nighthawks", Art.STYLE.Impressionism);


            runDisplay.Text = nighthawks.ToString();

            //controlName.ItemsSource = Enum.GetValues(typeof(enumName)).Cast<enumName>().ToList();

            cmbStyles.ItemsSource =
                Enum.GetValues<Art.STYLE>().Cast<Art.STYLE>().ToList();
        }

    }
}