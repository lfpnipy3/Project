using Project.DataBaseModel;
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

namespace Project.Frames.FoundationalPagesTables
{
    /// <summary>
    /// Логика взаимодействия для Load_po_UPPage.xaml
    /// </summary>
    public partial class Load_po_UPPage : Page
    {
        public Load_po_UPPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridGeneral.ItemsSource = AppData.db.Load_po_UP.ToList();
        }
    }
}
