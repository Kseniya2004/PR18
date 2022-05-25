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
using _14;

namespace PR18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        List<string> St = new List<string>()
        {
            "Вылечил Яблоко",
            "Да. Не знаю Зачем, Но Я Его Сделал.",
            "Влюбился В Пистолет",
            "Выпил Поезд",
            "Нарисовал Друга"
        };
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btnList_Click(object sender, RoutedEventArgs e)
        {           
            foreach(string c in St)
            {
                lstTable.Items.Add(c);
            }
            
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            STRING str = new STRING();
            for(int i = 0; i < lstTable.Items.Count; i++)
            {
                str.Stroka = lstTable.Items[i].ToString();
                
                lstTable.Items[i] = str.ChangeLine();
            }
            

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lstTable.Items.Clear();
        }
    }
}
 