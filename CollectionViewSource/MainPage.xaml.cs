using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CollectionViewSource
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public List<Subset> subsets = new List<Subset>();

        public MainPage()
        {
            this.InitializeComponent();

            // Adding Subsets, each with a list of Decks
            subsets.Add(new Subset() { Name = "Chemistry",
                Decks = new List<Deck>() {
                    new Deck() { Name = "Polyatomic Ions" },
                    new Deck() { Name = "Periodic Table" },
                    new Deck() { Name = "Famous Chemists" }
                }
            });

            subsets.Add(new Subset()
            {
                Name = "History",
                Decks = new List<Deck>() {
                    new Deck() { Name = "US Presidents" },
                    new Deck() { Name = "Constitutional Amendments" },
                    new Deck() { Name = "The Crusades" }
                }
            });

            subsets.Add(new Subset()
            {
                Name = "English",
                Decks = new List<Deck>() {
                    new Deck() { Name = "US Presidents" },
                    new Deck() { Name = "Constitutional Amendments" },
                    new Deck() { Name = "The Crusades" }
                }
            });

            //Setting the source of the XAML CVS
            CVSInfo.Source = subsets;
        }
    }
}
