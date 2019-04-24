using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void GetJokeButton_ClickAsync(object sender, EventArgs e)
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();
            MessageBox.Show(joke.JokeText);
        }

        private async void CategoriesComboBox_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            //IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            //CategoriesComboBox.DataSource = categories;
            //CategoriesComboBox.DisplayMember = "Categories";
        }

        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            CategoriesComboBox.DataSource = categories;
        }
    }
}
