using System.Windows.Controls;
using finderApp.ViewModels;

namespace finderApp.UserControls
{
    public partial class TreeViewUserControl : UserControl
    {
        public TreeViewUserControl()
        {
            InitializeComponent();
            DataContext = new DirectoryStructureViewModel();
        }
    }
}