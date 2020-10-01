
using System.Windows;

namespace FirstApp { 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            FirstApp.ViewModel.StudentViewModel studentViewModelObject =
               new FirstApp.ViewModel.StudentViewModel();
            studentViewModelObject.LoadStudents();

            StudentViewControl.DataContext = studentViewModelObject;
        }
    }
}
