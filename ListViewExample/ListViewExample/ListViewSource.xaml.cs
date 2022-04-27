using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {
        ObservableCollection<Employe> employes = new ObservableCollection<Employe>();
        
        public ObservableCollection<Employe> Employes { get { return employes; } }
        public ListViewSource()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employes;
            employes.Add(new Employe { DisplayName = "Rob Finnerty" });
            employes.Add(new Employe { DisplayName = "Bill Wrestler" });
            employes.Add(new Employe { DisplayName = "Dr. Geri-Beth Hooper" });
            employes.Add(new Employe { DisplayName = "Dr. Keith Joyce-Purdy" });
            employes.Add(new Employe { DisplayName = "Sheri Spruce" });
            employes.Add(new Employe { DisplayName = "Burt Indybrick" });
        }
    }
}