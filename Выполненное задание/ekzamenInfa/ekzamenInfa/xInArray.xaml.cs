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
using System.Windows.Shapes;

namespace ekzamenInfa
{
    /// <summary>
    /// Логика взаимодействия для xInArray.xaml
    /// </summary>
    public partial class xInArray : Window
    {
        private readonly char[] Separator = { ',', ' ', '.' };
        private string[] Array;
        private int Input = 0;

        public xInArray()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if(ArrayInput.Text == null)
            {
                MessageBox.Show("Заполните массив");
            } 
            else
            {
                Array = ArrayInput.Text.Split(Separator);
                for(var i = 0; i < Array.Length; i++)
                {
                    if(Array[i] == "0")
                    {
                        Input++;
                    }
                }
                CountZero.Text = Convert.ToString(Input);
                Input = 0;
            }
        }

        private void RandomBtn_Click(object sender, RoutedEventArgs e)
        {
            string ret
            ret = "1,0,1,0,10";
            ArrayInput.Text = ret;
        }
    }
}
