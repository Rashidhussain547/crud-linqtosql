using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace crudlinqtosql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bookDataContext db = new bookDataContext();
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (bookDataContext db = new bookDataContext())
            {
                // Create a new book record
                var newBook = new Book
                {
                    BookId = int.Parse(textBox1.Text),
                    TITLE = textBox2.Text,
                    AUTHOR = textBox3.Text,
                    ISBN = textBox4.Text,
                    GENRE = textBox5.Text,
                };

                db.Books.InsertOnSubmit(newBook);
                db.SubmitChanges();
                MessageBox.Show("Successfully saved");
                LoadData();
            }

            
        }
        void LoadData()
        {
            var newBook = from s in db.Books select s;
            dataGridView1.DataSource = newBook;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            // update  book record
            var newBook = (from s in db.Books where s.BookId == int.Parse(textBox1.Text) select s).First();
            newBook.TITLE = textBox2.Text;
            newBook.AUTHOR = textBox3.Text;
            newBook.ISBN = textBox4.Text;
            newBook.GENRE = textBox5.Text;
            db.SubmitChanges();
            MessageBox.Show("Successfully updated");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // update  book record
            var newBook = (from s in db.Books where s.BookId == int.Parse(textBox1.Text) select s).First();
            textBox2.Text = newBook.TITLE;
            textBox3.Text = newBook.AUTHOR;
            textBox4.Text = newBook.ISBN;
            textBox5.Text = newBook.GENRE;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (bookDataContext context = new bookDataContext()) 
            {
                // Query your database table using LINQ
                var query = from book in context.Books
                            select new
                            {
                                book.BookId,
                                book.TITLE,
                                book.AUTHOR,
                                book.ISBN,
                                book.GENRE
                            };

                // Bind the query result to the DataGridView
                dataGridView1.DataSource = query.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newBook = (from s in db.Books where s.BookId == int.Parse(textBox1.Text) select s).First();
            db.Books.DeleteOnSubmit(newBook);
            db.SubmitChanges();
            MessageBox.Show("Successfully Deleted");
            LoadData();
        }
    }
}
