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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Create a member Object
            Member memb = new Member("Jon",
                "Jones",
                "Bones",
                "american",
                "jon.jones@gmail.com",
                25,
                76.23,
                45892345,
                true,
                12,
                5,
                0,
                12,
                0,
                0,
                "Hans Andersen street");

            Console.WriteLine();
        }
    }
}
