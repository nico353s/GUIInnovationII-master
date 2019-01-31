using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace GuiInnovationII
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DropDown.SelectedItem == Vej1)
            {
                List<Order> items = new List<Order>();
                items.Add(new Order() { ID = 100, Antal = 100, Modtagelsesdato = "01/02-2019", Kategori = "Arla Minimælk", Udløbsdato = "10/02-2019" });
                items.Add(new Order() { ID = 101, Antal = 100, Modtagelsesdato = "01/02-2019", Kategori = "Arla Skummetmælk", Udløbsdato = "10/02-2019" });
                items.Add(new Order() { ID = 200, Antal = 30, Modtagelsesdato = "01/02-2019", Kategori = "Kyllingefilet 7-10%", Udløbsdato = "08/02-2019" });
                items.Add(new Order() { ID = 201, Antal = 30, Modtagelsesdato = "01/02-2019", Kategori = "Hakket Oksekød 5-7%", Udløbsdato = "08/02-2019" });
                items.Add(new Order() { ID = 504, Antal = 50, Modtagelsesdato = "01/02-2019", Kategori = "Schulstad Levebrød", Udløbsdato = "07/02-2019" });
                items.Add(new Order() { ID = 301, Antal = 50, Modtagelsesdato = "01/02-2019", Kategori = "Stryhns Leverpostej", Udløbsdato = "14/02-2019" });
                items.Add(new Order() { ID = 152, Antal = 30, Modtagelsesdato = "01/02-2019", Kategori = "Yoggi Yoghurt Bær", Udløbsdato = "10/02-2019" });
                items.Add(new Order() { ID = 153, Antal = 30, Modtagelsesdato = "01/02-2019", Kategori = "Yoggi Yoghurt Banan", Udløbsdato = "10/02-2019" });

                lvUsers.ItemsSource = items;
               
            }
            else if(DropDown.SelectedItem == Vej2)
            {
                List<Order> items = new List<Order>();
                items.Add(new Order() { ID = 102, Antal = 80, Modtagelsesdato = "02/02-2019", Kategori = "Arla Letmælk", Udløbsdato = "11/02-2019" });
                items.Add(new Order() { ID = 103, Antal = 80, Modtagelsesdato = "02/02-2019", Kategori = "Arla Sødmælk", Udløbsdato = "11/02-2019" });
                items.Add(new Order() { ID = 202, Antal = 40, Modtagelsesdato = "02/02-2019", Kategori = "Fiskefars", Udløbsdato = "10/02-2019" });
                items.Add(new Order() { ID = 203, Antal = 50, Modtagelsesdato = "02/02-2019", Kategori = "Hakket Svinekød 10-12%", Udløbsdato = "09/02-2019" });
                items.Add(new Order() { ID = 505, Antal = 40, Modtagelsesdato = "02/02-2019", Kategori = "Solsikkebrød", Udløbsdato = "08/02-2019" });
                items.Add(new Order() { ID = 30, Antal = 30, Modtagelsesdato = "02/02-2019", Kategori = "Stryhns Franskpostej", Udløbsdato = "13/02-2019" });
                items.Add(new Order() { ID = 156, Antal = 20, Modtagelsesdato = "02/02-2019", Kategori = "Yoggi Yoghurt Jordbær", Udløbsdato = "11/02-2019" });
                items.Add(new Order() { ID = 155, Antal = 20, Modtagelsesdato = "02/02-2019", Kategori = "Yoggi Yoghurt Kokos", Udløbsdato = "11/02-2019" });
                lvUsers.ItemsSource = items;
            }
            
        }
    }

    public class Order
    {
        public int ID { get; set; }
        public int Antal { get; set; }
        public string Modtagelsesdato { get; set; }
        public string Kategori { get; set; }
        public string Udløbsdato { get; set; }

    }
}
