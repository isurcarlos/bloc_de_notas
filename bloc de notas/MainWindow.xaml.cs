using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace bloc_de_notas
    
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
              
        }
        Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
        Microsoft.Win32.SaveFileDialog dlg1 = new Microsoft.Win32.SaveFileDialog();
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            bool? checarOK = dlg.ShowDialog();


            if (checarOK == true)
            {
                StreamReader archivo = new StreamReader(dlg.FileName);

                while (archivo.Peek() >= 0)
                {
                    textBox1.Text += archivo.ReadLine() + "\r\n";
                }

            } 
        }        
        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            dlg1.FileName = "sin titulo.txt";
            dlg1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            var sf = dlg1.ShowDialog();
            if (sf == true)
            {
                using (var savefile = new System.IO.StreamWriter(dlg1.FileName))
                {
                    savefile.WriteLine(textBox1.Text);  
                }
            }

            
        }
    }

     
    }

