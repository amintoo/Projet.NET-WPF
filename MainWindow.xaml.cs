using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace projet_UI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Ville> villes = new ObservableCollection<Ville>();

        public ObservableCollection<Ville> Villes { get => villes; set => villes = value; }

        public MainWindow()
        {
            this.DataContext = this;
            InitializeComponent();
        }

     
        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse el = new Ellipse();
            el.Width = 2;
            el.Height = 2;
            el.Fill = Brushes.Red;

            // TODO : Dialog

            double x = e.GetPosition(sender as IInputElement).X;
            double y = e.GetPosition(sender as IInputElement).Y;

            var dialog = new Input_ville();

            string villename = null;

            if (dialog.ShowDialog() == true)
            {
                villename = dialog.ResponseText;
            }
            

            Thickness t = new Thickness(x,y, 0, 0);
             el.Margin = t;

            // creation de la ville
            Ville town = new Ville(Convert.ToInt32(x), Convert.ToInt32(y), villename);
       
            Villes.Add(town);


            canva.Children.Add(el);
            
        }
    }


}
