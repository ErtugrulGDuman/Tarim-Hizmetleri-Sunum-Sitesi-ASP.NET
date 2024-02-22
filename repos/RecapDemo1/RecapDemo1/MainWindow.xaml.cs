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

namespace RecapDemo1
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

        public object Conrols { get; private set; }
        public object Controls { get; private set; }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Button[,] buttons =new Button[8,8];
            int top=0;
            int left=0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i,j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].Background = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].Background = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);

                }
                top += 50;
                left = 0;
            }    
            
        }
    }
}
