namespace LIbrary_of_books
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.comboBoxGenres = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbDiscount = new System.Windows.Forms.RadioButton();
            this.rbNotDiscount = new System.Windows.Forms.RadioButton();
            this.BooksList = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ShowGenre = new System.Windows.Forms.TextBox();
            this.GenreInfo = new System.Windows.Forms.Label();
            this.AuthorInfo = new System.Windows.Forms.Label();
            this.CardInfo = new System.Windows.Forms.Label();
            this.GenreSort = new System.Windows.Forms.Label();
            this.AuthorSort = new System.Windows.Forms.Label();
            this.ShowAuthor = new System.Windows.Forms.TextBox();
            this.TitleInfo = new System.Windows.Forms.Label();
            this.ShowTitle = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksList)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(1452, 320);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(121, 33);
            this.comboBoxAuthors.TabIndex = 0;
            this.comboBoxAuthors.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthors_SelectedIndexChanged);
            this.comboBoxAuthors.TextChanged += new System.EventHandler(this.comboBoxAuthors_TextChanged);
            // 
            // comboBoxGenres
            // 
            this.comboBoxGenres.FormattingEnabled = true;
            this.comboBoxGenres.Location = new System.Drawing.Point(1452, 283);
            this.comboBoxGenres.Name = "comboBoxGenres";
            this.comboBoxGenres.Size = new System.Drawing.Size(121, 33);
            this.comboBoxGenres.TabIndex = 1;
            this.comboBoxGenres.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenres_SelectedIndexChanged);
            this.comboBoxGenres.TextChanged += new System.EventHandler(this.comboBoxGenres_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.ChangeToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1728, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(140, 36);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // ChangeToolStripMenuItem
            // 
            this.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem";
            this.ChangeToolStripMenuItem.Size = new System.Drawing.Size(143, 36);
            this.ChangeToolStripMenuItem.Text = "Изменить";
            this.ChangeToolStripMenuItem.Click += new System.EventHandler(this.ChangeToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(122, 36);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.ExitToolStripMenuItem.Text = "Выйти";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // rbDiscount
            // 
            this.rbDiscount.AutoCheck = false;
            this.rbDiscount.AutoSize = true;
            this.rbDiscount.Location = new System.Drawing.Point(1254, 377);
            this.rbDiscount.Name = "rbDiscount";
            this.rbDiscount.Size = new System.Drawing.Size(253, 29);
            this.rbDiscount.TabIndex = 3;
            this.rbDiscount.Text = "Скидка для студента";
            this.rbDiscount.UseVisualStyleBackColor = true;
            // 
            // rbNotDiscount
            // 
            this.rbNotDiscount.AutoCheck = false;
            this.rbNotDiscount.AutoSize = true;
            this.rbNotDiscount.Location = new System.Drawing.Point(1254, 412);
            this.rbNotDiscount.Name = "rbNotDiscount";
            this.rbNotDiscount.Size = new System.Drawing.Size(155, 29);
            this.rbNotDiscount.TabIndex = 4;
            this.rbNotDiscount.TabStop = true;
            this.rbNotDiscount.Text = "Нет скидки";
            this.rbNotDiscount.UseVisualStyleBackColor = true;
            // 
            // BooksList
            // 
            this.BooksList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BooksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksList.Location = new System.Drawing.Point(33, 73);
            this.BooksList.Name = "BooksList";
            this.BooksList.RowHeadersWidth = 82;
            this.BooksList.RowTemplate.Height = 33;
            this.BooksList.Size = new System.Drawing.Size(1112, 475);
            this.BooksList.TabIndex = 5;
            this.BooksList.SelectionChanged += new System.EventHandler(this.BooksList_SelectionChanged);
            // 
            // ShowGenre
            // 
            this.ShowGenre.Location = new System.Drawing.Point(1383, 141);
            this.ShowGenre.Name = "ShowGenre";
            this.ShowGenre.Size = new System.Drawing.Size(100, 31);
            this.ShowGenre.TabIndex = 6;
            // 
            // GenreInfo
            // 
            this.GenreInfo.AutoSize = true;
            this.GenreInfo.Location = new System.Drawing.Point(1291, 144);
            this.GenreInfo.Name = "GenreInfo";
            this.GenreInfo.Size = new System.Drawing.Size(73, 50);
            this.GenreInfo.TabIndex = 7;
            this.GenreInfo.Text = "Жанр:\r\n\r\n";
            // 
            // AuthorInfo
            // 
            this.AuthorInfo.AutoSize = true;
            this.AuthorInfo.Location = new System.Drawing.Point(1287, 191);
            this.AuthorInfo.Name = "AuthorInfo";
            this.AuthorInfo.Size = new System.Drawing.Size(77, 25);
            this.AuthorInfo.TabIndex = 8;
            this.AuthorInfo.Text = "Автор:";
            // 
            // CardInfo
            // 
            this.CardInfo.AutoSize = true;
            this.CardInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardInfo.Location = new System.Drawing.Point(1321, 73);
            this.CardInfo.Name = "CardInfo";
            this.CardInfo.Size = new System.Drawing.Size(114, 25);
            this.CardInfo.TabIndex = 9;
            this.CardInfo.Text = "Карточка";
            this.CardInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenreSort
            // 
            this.GenreSort.AutoSize = true;
            this.GenreSort.Location = new System.Drawing.Point(1174, 291);
            this.GenreSort.Name = "GenreSort";
            this.GenreSort.Size = new System.Drawing.Size(239, 25);
            this.GenreSort.TabIndex = 10;
            this.GenreSort.Text = "Сортировать по жанру";
            // 
            // AuthorSort
            // 
            this.AuthorSort.AutoSize = true;
            this.AuthorSort.Location = new System.Drawing.Point(1174, 328);
            this.AuthorSort.Name = "AuthorSort";
            this.AuthorSort.Size = new System.Drawing.Size(245, 25);
            this.AuthorSort.TabIndex = 11;
            this.AuthorSort.Text = "Сортировать по автору";
            // 
            // ShowAuthor
            // 
            this.ShowAuthor.Location = new System.Drawing.Point(1383, 185);
            this.ShowAuthor.Name = "ShowAuthor";
            this.ShowAuthor.Size = new System.Drawing.Size(100, 31);
            this.ShowAuthor.TabIndex = 12;
            // 
            // TitleInfo
            // 
            this.TitleInfo.AutoSize = true;
            this.TitleInfo.Location = new System.Drawing.Point(1249, 240);
            this.TitleInfo.Name = "TitleInfo";
            this.TitleInfo.Size = new System.Drawing.Size(115, 25);
            this.TitleInfo.TabIndex = 13;
            this.TitleInfo.Text = "Название:";
            // 
            // ShowTitle
            // 
            this.ShowTitle.Location = new System.Drawing.Point(1383, 240);
            this.ShowTitle.Name = "ShowTitle";
            this.ShowTitle.Size = new System.Drawing.Size(100, 31);
            this.ShowTitle.TabIndex = 14;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(1326, 475);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(137, 80);
            this.btnAddBook.TabIndex = 15;
            this.btnAddBook.Text = "Добавить книгу";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Visible = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(1326, 475);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(137, 80);
            this.btnSaveChanges.TabIndex = 16;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 724);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.ShowTitle);
            this.Controls.Add(this.TitleInfo);
            this.Controls.Add(this.ShowAuthor);
            this.Controls.Add(this.AuthorSort);
            this.Controls.Add(this.GenreSort);
            this.Controls.Add(this.CardInfo);
            this.Controls.Add(this.AuthorInfo);
            this.Controls.Add(this.GenreInfo);
            this.Controls.Add(this.ShowGenre);
            this.Controls.Add(this.BooksList);
            this.Controls.Add(this.rbNotDiscount);
            this.Controls.Add(this.rbDiscount);
            this.Controls.Add(this.comboBoxGenres);
            this.Controls.Add(this.comboBoxAuthors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Библиотека";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.ComboBox comboBoxGenres;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbDiscount;
        private System.Windows.Forms.RadioButton rbNotDiscount;
        private System.Windows.Forms.DataGridView BooksList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox ShowGenre;
        private System.Windows.Forms.Label GenreInfo;
        private System.Windows.Forms.Label AuthorInfo;
        private System.Windows.Forms.Label CardInfo;
        private System.Windows.Forms.Label GenreSort;
        private System.Windows.Forms.Label AuthorSort;
        private System.Windows.Forms.TextBox ShowAuthor;
        private System.Windows.Forms.Label TitleInfo;
        private System.Windows.Forms.TextBox ShowTitle;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}

