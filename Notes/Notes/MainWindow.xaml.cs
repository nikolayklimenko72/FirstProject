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
    class Note
    {
        public string Title;
        public string Text;
        public string DateCreation;
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int LastNoteNumber = 0;
        string[] files; // Эта переменная хранит массив имен файлов с заметками.
        int CurrentNote;
        public MainWindow()  
        {
            InitializeComponent();
            ReadNotes();
            ReadNote("Note21.txt");
            
        }
        void ReadNotes()
        {
            string s = File.ReadAllText("..\\..\\Number.txt");
            LastNoteNumber = int.Parse(s);
            files = new string[LastNoteNumber + 1]; 
            int i;
            NoteList.Items.Clear(); // Удаляет все элементы списка.
            int poz = 0;

            string currentFile;

            for (i = 0; i <= LastNoteNumber; i++)
            {
                currentFile = "Note" + i.ToString() + ".txt";
                if (File.Exists(currentFile))
                {
                    s = File.ReadAllText(currentFile);
                    files[poz] = currentFile;
                    NoteList.Items.Add(s);
                    poz = poz + 1;
                    
                }

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NameNotes NewNote = new NameNotes();
            NewNote.ShowDialog();
            // Мы увеличиваем номер последней заметки на 1. Сохраняем файл Note{номер заметки}.txt
          // Сохраняем обновленный последний номер заметки. 
            LastNoteNumber = LastNoteNumber + 1;
            File.WriteAllText("Note" + LastNoteNumber.ToString() + ".txt", NewNote.NoteText + "\n" + Note.Text);
            File.WriteAllText("..\\..\\Number.txt", LastNoteNumber.ToString());
            NoteList.Items.Add(Note.Text);
           MessageBox.Show("Заметка сохранена");
           ReadNotes();
        }

        private void NoteList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Note.Text = ((string)NoteList.SelectedItem);
            CurrentNote = NoteList.SelectedIndex;
            btnSave.Visibility = System.Windows.Visibility.Visible;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            int number = NoteList.SelectedIndex;
            if (number != -1)
            {
                File.WriteAllText(files[number], Note.Text);
                ReadNotes();
            }
            
        }

        private void btnDelete_Click_1(object sender, RoutedEventArgs e)
        {
            int number = NoteList.SelectedIndex;
            if (number != -1)
            {
                NoteList.Items.RemoveAt(number);
                File.Delete(files[number]);
            }
           
        }

        private void NoteList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            Note.Text = "Был выбран другой элемент списка";
        }

        private void ReadNote(string filename)
        {
            // название заметки - 1 строка в файле
            // все последующие строки - текст заметки
            string[] Data;
            Data = File.ReadAllLines(filename);
        }
        
    }
}
