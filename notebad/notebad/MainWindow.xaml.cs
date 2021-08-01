using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Drawing;

namespace notebad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public string texti_get { get { return texti; } }

        public string texti
        {
            get
            {
                TextRange textRange = new TextRange(text.Document.ContentStart, text.Document.ContentEnd);

                return textRange.Text;
            }
        }
        public MainWindow()
        {
            
            InitializeComponent();

            string[] cmdLine = Environment.GetCommandLineArgs();
            for (int i = 1; i < cmdLine.Length; i++)
            {
                FlowDocument flowDocument = new FlowDocument();
                Paragraph paragraph = new Paragraph();
                paragraph.Inlines.Add(new Run(File.ReadAllText(cmdLine[i])));
                flowDocument.Blocks.Add(paragraph);
                text.Document = flowDocument;

            }

            
            
                
           
        }

        private void save_as_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                code.fileF.save_as();
                File.WriteAllText(code.fileF.path, texti);
            }
            catch { }
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                code.fileF.load();
                text.Document = code.fileF.flowDocument;
            }
            catch { }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var mb = MessageBox.Show("Do you want to save ? ", "Text editor", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (mb == MessageBoxResult.Yes)
                {
                    File.WriteAllText(code.fileF.path, texti);
                }
            }
            catch
            {
                MessageBox.Show("No text file is loaded", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            

        }

        private void new_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument flowDocument = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(new Run(""));
            flowDocument.Blocks.Add(paragraph);
            text.Document = flowDocument;
            
            code.fileF.path = null;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            settingsWindow settings = new settingsWindow();
            settings.Show();
        }
       

        private void Replace_Click(object sender, RoutedEventArgs e)
        {
            
            
        }
        static void cool()
        {
            
        }

        private void new_window_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ei valmis");
        }
        public bool FindMyText(string text)
        {
            // Initialize the return value to false by default.
            bool returnValue = false;

            // Ensure a search string has been specified.
            if (text.Length > 0)
            {
                // Obtain the location of the search string in richTextBox1.
                int indexToText = text.Find(text);
                // Determine whether the text was found in richTextBox1.
                if (indexToText >= 0)
                {
                    returnValue = true;
                }
            }

            return returnValue;
        }

    }
}
