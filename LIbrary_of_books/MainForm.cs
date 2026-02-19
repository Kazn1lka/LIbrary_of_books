using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LIbrary_of_books
{
    public partial class MainWindow : Form
    {
        bool isAddingMode = false;
        public List<Book> Books = new List<Book>();
        public void LoadBooks()
        {
            string[] authors = File.ReadAllLines("files/Authors.txt");
            string[] genres = File.ReadAllLines("files/Genres.txt");
            string[] books = File.ReadAllLines("files/Books.txt");
            comboBoxAuthors.Items.AddRange(authors);
            comboBoxGenres.Items.AddRange(genres);
            List<string> cleanAuthors = new List<string>();
            foreach (string line in authors)
            {
                string name = line.Split('.')[1].Trim();
                cleanAuthors.Add(name);
            }

            List<string> cleanGenres = new List<string>();
            foreach (string line in genres)
            {
                string genre = line.Split('.')[1].Trim();
                cleanGenres.Add(genre);
            }
            foreach (string line in books)
            {
                string[] parts = line.Split(',', '.');
                if (parts.Length >= 4)
                {
                    string title = parts[1].Trim();
                    int authorId = int.Parse(parts[2].Trim());
                    int genreId = int.Parse(parts[3].Trim());
                    bool discount = bool.Parse(parts[4].Trim());
                    Books.Add(new Book(title, cleanAuthors[authorId - 1], cleanGenres[genreId - 1], discount));
                }
            }
            BooksList.DataSource = Books;
        } 
    public void BookFilter()
    {
        List<Book> filtered = new List<Book>();

        string selectedAuthor = comboBoxAuthors.Text.Trim();
        string selectedGenre = comboBoxGenres.Text.Trim();

        foreach (Book book in Books)
        {
            bool authorMatch = string.IsNullOrEmpty(selectedAuthor) || book.Author == selectedAuthor;
            bool genreMatch = string.IsNullOrEmpty(selectedGenre) || book.Genre == selectedGenre;

            if (genreMatch && authorMatch)
            {
                filtered.Add(book);
            }
        }
    BooksList.DataSource = null;
    BooksList.DataSource = filtered;
    }
        public MainWindow()
        {
            InitializeComponent();
            LoadBooks();
        }
        
        private void BooksList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void comboBoxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isAddingMode) { return; }
            BookFilter();
        }
        private void comboBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isAddingMode) { return; }
            BookFilter();
        }
        private void comboBoxAuthors_TextChanged(object sender, EventArgs e)
        {
            if (isAddingMode) { return; }
            BookFilter();
        }
        private void comboBoxGenres_TextChanged(object sender, EventArgs e)
        {
            if (isAddingMode) { return; }
            BookFilter();
        }

        private void BooksList_SelectionChanged(object sender, EventArgs e)
        {
            if (BooksList.CurrentRow == null || isAddingMode) { return; }
            Book book = BooksList.CurrentRow.DataBoundItem as Book;
            ShowGenre.Text = book.Genre;
            ShowAuthor.Text = book.Author;
            ShowTitle.Text = book.Title;
            rbDiscount.Checked = book.Discount;
            rbNotDiscount.Checked = !book.Discount;
        }


        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxAuthors.SelectedIndex = comboBoxGenres.SelectedIndex = -1;
            comboBoxAuthors.Text = comboBoxGenres.Text = "";
            ChangeToolStripMenuItem.Enabled = false;
            isAddingMode = true;
            rbDiscount.AutoCheck = rbNotDiscount.AutoCheck = true;
            ShowGenre.Visible = ShowAuthor.Visible = false;
            btnAddBook.Visible = true;
            comboBoxGenres.Text = ShowTitle.Text = comboBoxAuthors.Text = "";
            rbDiscount.Checked = rbNotDiscount.Checked = false;
            GenreSort.Text = "Выберите жанр"; AuthorSort.Text = "Выберите автора";
            GenreInfo.Visible = AuthorInfo.Visible = false;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            bool isTitleOk = !string.IsNullOrWhiteSpace(ShowTitle.Text);
            bool isAuthorOk = comboBoxAuthors.SelectedIndex != -1;
            bool isGenreOk = comboBoxGenres.SelectedIndex != -1;
            bool isDiscountOk = rbDiscount.Checked || rbNotDiscount.Checked;

            if (isTitleOk && isAuthorOk && isGenreOk && isDiscountOk)
            {
                Book newBook = new Book(ShowTitle.Text, ShowAuthor.Text, ShowGenre.Text, rbDiscount.Checked);
                Books.Add(newBook);
                BookFilter();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }

            btnAddBook.Visible = false;
            rbDiscount.AutoCheck = rbNotDiscount.AutoCheck = false;
            ShowGenre.Visible = ShowAuthor.Visible = true;
            GenreSort.Text = "Сортировать по жанру";
            AuthorSort.Text = "Сортировать по автору";
            GenreInfo.Visible = AuthorInfo.Visible = true;
            isAddingMode = false;
            ChangeToolStripMenuItem.Enabled = true;
            comboBoxAuthors.Text = comboBoxGenres.Text = "";
        }
        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxAuthors.SelectedIndex = comboBoxGenres.SelectedIndex = -1;
            comboBoxAuthors.Text = comboBoxGenres.Text = "";
            AddToolStripMenuItem.Enabled = false;
            rbDiscount.AutoCheck = rbNotDiscount.AutoCheck = true;
            isAddingMode = true;
            btnSaveChanges.Visible = true;
            GenreSort.Text = "Новый жанр"; AuthorSort.Text = "Новый автор";
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (BooksList.CurrentRow == null) { return; }

            var selectedBook = BooksList.CurrentRow.DataBoundItem as Book;

            selectedBook.Title = ShowTitle.Text;
            selectedBook.Author = comboBoxAuthors.Text;
            selectedBook.Genre = comboBoxGenres.Text;
            selectedBook.Discount = rbDiscount.Checked;

            BooksList.Refresh();
            rbDiscount.AutoCheck = rbNotDiscount.AutoCheck = false;
            isAddingMode = true;
            AddToolStripMenuItem.Enabled = true;
            btnSaveChanges.Visible = false;
            comboBoxAuthors.Text = comboBoxGenres.Text = "";

            GenreSort.Text = "Сортировать по жанру";
            AuthorSort.Text = "Сортировать по автору";
            MessageBox.Show("изменения сохранены");

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BooksList.CurrentRow == null) { return; }
            var selectedBook = BooksList.CurrentRow.DataBoundItem as Book;
            Books.Remove(selectedBook);
            BookFilter();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
