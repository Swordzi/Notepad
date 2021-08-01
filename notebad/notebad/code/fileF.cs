using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Documents;

namespace notebad.code
{
    static class fileF
    {
        static public string path;
        static public void save_as()
        {

            SaveFileDialog SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.Filter = "Text Files | *.txt | all files | *";
            SaveFileDialog.FilterIndex = 1;
            if (SaveFileDialog.ShowDialog() == true)
            {
                path = SaveFileDialog.FileName;
                var file = File.Create(path);
                file.Close();

            }



        }
        static public FlowDocument flowDocument = new FlowDocument();
        static public void load()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text files | *.txt";
            if (openFileDialog.ShowDialog() == true)
            {

                path = openFileDialog.FileName;


                Paragraph paragraph = new Paragraph();
                paragraph.Inlines.Add(new Run(File.ReadAllText(path)));
                flowDocument.Blocks.Add(paragraph);
            }
        }
    }
}
