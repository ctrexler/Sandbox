using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DynamicPivot
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Model> ObsCol { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            

            ObsCol = new ObservableCollection<Model>() {
                new Model("Weston"),
                new Model("smells"),
                new Model("like"),
                new Model("toad"),
                new Model("fungus!")
            };

            this.DataContext = ObsCol;

            //PivotItem pi;
            //foreach (Model model in ObsCol)
            //{
            //    pi = new PivotItem();

            //    MyUserControl uc = new MyUserControl();

            //    //pi.Header = s;
            //    pi.Content = uc;
            //    BleepBloop.Items.Add(pi);
            //    pi = null;
            //}
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            PivotItem pi = new PivotItem();

            Rectangle r = new Rectangle();
            r.Fill = new SolidColorBrush(Colors.Turquoise);
            r.Margin = new Thickness(0, 0, 0, 0);

            pi.Content = r;
            BleepBloop.Items.Add(pi);
        }
    }
}
