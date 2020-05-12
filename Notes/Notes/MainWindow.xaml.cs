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
using System.IO;

namespace Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int LastNoteNumber = 0;   
        public MainWindow()  
        {
            InitializeComponent();
            string s = File.ReadAllText("..\\..\\Number.txt");
            LastNoteNumber = int.Parse(s);
            int i;
            for (i = 0; i <= LastNoteNumber; i++)
            {
                
                s = File.ReadAllText("Note" + i.ToString() + ".txt");
                NoteList.Items.Add(s);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          // Мы увеличиваем номер последней заметки на 1. Сохраняем файл Note{номер заметки}.txt
          // Сохраняем обновленный последний номер заметки.
            LastNoteNumber = LastNoteNumber + 1;
            File.WriteAllText("Note" + LastNoteNumber.ToString() + ".txt", Note.Text);
            File.WriteAllText("..\\..\\Number.txt", LastNoteNumber.ToString());
            NoteList.Items.Add(Note.Text);
           MessageBox.Show("Заметка сохранена");
            

        }

        private void NoteList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Note.Text = ((string)NoteList.SelectedItem);
        }

      
        
    }
}
