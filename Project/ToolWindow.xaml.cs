using Project.Frames.FoundationalPagesTables;
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
using System.Windows.Shapes;
using WpfApp5;
using WpfApp5.Frames;

namespace Project
{
    /// <summary>
    /// Логика взаимодействия для ToolWindow.xaml
    /// </summary>
    public partial class ToolWindow : Window
    {
        public ToolWindow()
        {
            InitializeComponent();
        }

        private void LeftBtnMousePositionWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnLoadDistribution(object sender, RoutedEventArgs e)
        {
            // this.GeneralFrame.NavigationService.StopLoading();
            GeneralFrame.NavigationService.Navigate(new LoadDistribution());
        }

        private void BtnReports(object sender, RoutedEventArgs e)
        {
            // this.GeneralFrame.NavigationService.StopLoading();
            GeneralFrame.NavigationService.Navigate(new Reports());
        }

        private void BtnMonitoring(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new Monitoring());
        }

        private void BtnCloseCalculationStates(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new CloseCalculationStates());
        }

        private void BtnDegrees(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new DegreesPage());
        }

        private void BtnPosition(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new PositionsPage());
        }
        private void BtnCompatibility(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new CompatibilityPage());
        }
        private void BtnPCK(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new PCKPage());
        }
        private void BtnUsers(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new UsersPage());
        }

        private void BtnTeachers(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new TeachersPage());
        }
        private void BtnTable_Access(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new Table_AccessPage());
        }

        private void BtnActual_Load(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new Actual_LoadPage());
        }
        private void BtnDisciplines(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new DisciplinesPage());
        }
        private void BtnLoad_po_UP(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new Load_po_UPPage());
        }
        private void BtnGroups(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new GroupsPage());
        }

        private void BtnCycles_Discipline(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new Cycles_DisciplinePage());
        }
        private void BtnUP(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new UPPage());
        }
        private void BtnGroup_UG(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new Group_UGPage());
        }
        private void BtnSpecialties(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new SpecialtiesPage());
        }
        private void BtnYears_Academic(object sender, RoutedEventArgs e)
        {
            GeneralFrame.NavigationService.Navigate(new Years_AcademicPage());
        }

    }
}