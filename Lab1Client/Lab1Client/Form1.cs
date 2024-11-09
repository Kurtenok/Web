using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.AspNetCore.SignalR.Client;
namespace Lab1Client
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
            InitializeConnection();
        }
        private HubConnection connection;
        public class Book
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string LibraryNumber { get; set; }
        }

        private async void InitializeConnection()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/chathub")
                .Build();

            await connection.StartAsync();
        }


        private async void CommitBtn_Click(object sender, EventArgs e)
        {
            var book = new
            {
                Id = int.Parse(BookIDtextBox.Text),
                Title = BookNametextBox.Text,
                Author = AuthortextBox.Text,
                LibraryNumber = LibralyIDtextBox.Text
            };

            string json = JsonConvert.SerializeObject(book);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("http://localhost:5000/api/books", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Book added successfully.");
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Failed to add the book. Status code: {response.StatusCode}, Error: {errorMessage}");
            }
        }

        private async void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                int bookId = int.Parse(BookIDtextBox.Text);

                HttpResponseMessage response = await client.GetAsync($"http://localhost:5000/api/books/{bookId}");

                if (response.IsSuccessStatusCode)
                {

                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var book = JsonConvert.DeserializeObject<Book>(jsonResponse);


                    BookNametextBox.Text = book.Title;
                    AuthortextBox.Text = book.Author;
                    LibralyIDtextBox.Text = book.LibraryNumber;
                }
                else
                {
                    MessageBox.Show($"Book not found. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            var book = new
            {
                Id = int.Parse(BookIDtextBox.Text),
                Title = BookNametextBox.Text,
                Author = AuthortextBox.Text,
                LibraryNumber = LibralyIDtextBox.Text
            };

            string json = JsonConvert.SerializeObject(book);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            string url = $"http://localhost:5000/api/books/{book.Id}";

            HttpResponseMessage response = await client.PutAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Book updated successfully.");
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Failed to update the book. Status code: {response.StatusCode}, Error: {errorMessage}");
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(BookIDtextBox.Text);


            string url = $"http://localhost:5000/api/books/{bookId}";


            HttpResponseMessage response = await client.DeleteAsync(url);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Book deleted successfully.");
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Failed to delete the book. Status code: {response.StatusCode}, Error: {errorMessage}");
            }
        }

        private async void GetAllBtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost:5000/api/books");

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();

                var books = JsonConvert.DeserializeObject<List<Book>>(jsonResponse);

                StringBuilder bookInfo = new StringBuilder();
                foreach (var book in books)
                {
                    bookInfo.AppendLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Library Number: {book.LibraryNumber}");
                }

                richTextBox1.Text = bookInfo.ToString();
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Failed to get books. Status code: {response.StatusCode}, Error: {errorMessage}");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void SendMessageBtn_Click(object sender, EventArgs e)
        {
            string user = "Client";
            string message = ChatTextBox.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(message))
            {
                MessageBox.Show("User and message fields cannot be empty.");
                return;
            }

            try
            {
                await connection.InvokeAsync("SendMessage", user, message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending message: {ex.Message}");
            }
        }

        private async void InitializeSignalR()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/chathub")
                .Build();

            await connection.StartAsync();
        }
    }
}
