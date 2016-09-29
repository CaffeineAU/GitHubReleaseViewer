using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
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
using System.Web.Script.Serialization;
using System.Collections.ObjectModel;

namespace GitHubReleaseViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        private String repositoryName;

        public String RepositoryName
        {
            get { return repositoryName; }
            set { repositoryName = value;
                OnPropertyChanged("RepositoryName");
            }
        }

        private ObservableCollection<GitHub_Release> releases = new ObservableCollection<GitHub_Release>();

        public ObservableCollection<GitHub_Release> Releases
        {
            get { return releases; }
            set
            {
                releases = value;
                OnPropertyChanged("Releases");
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            WebClient wc = new WebClient();

            wc.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            String responseString = "";


            using (Stream responseStream = new MemoryStream(wc.DownloadData("https://api.github.com/repos/CaffeineAU/TTSAutomate/releases")))
            {
                responseString = new StreamReader(responseStream).ReadToEnd();
            }

            Releases =  new ObservableCollection<GitHub_Release>(new JavaScriptSerializer().Deserialize<List<GitHub_Release>>(responseString));


        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(String name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}
