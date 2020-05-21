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

namespace TodoList
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

        private void TxbInput_OnKeyUp(object sender, KeyEventArgs e)
        {
            if (txbInput.Text.Length == 0)
            {
                btnAdd.IsEnabled = false;
            }
            else
            {
                btnAdd.IsEnabled = true;
                if (e.Key == Key.Enter)
                {
                    AddToListBox(txbInput.Text);
                    txbInput.Text = "";
                }
            }
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnDelete.IsEnabled = true;
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            AddToListBox(txbInput.Text);
            btnAdd.IsEnabled = false;
        }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            lbxTasks.Items.Remove(lbxTasks.SelectedItem);
            btnDelete.IsEnabled = false;
        }

        private void AddToListBox(string task)
        {
            lbxTasks.Items.Add(task);
            txbInput.Text = "";
        }
    }
}
