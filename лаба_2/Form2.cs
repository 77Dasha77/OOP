using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static лаба_2.Form1;

namespace лаба_2
{
    public partial class Form2 : Form
    {
        string connectionString = "Host=localhost;Port=5432;Database=films;Username=postgres;Password=d5a8s9h6a";
        private Film _film; // Объявление приватного поля, которое будет хранить объект фильма, переданного в форму
        public Form2(Film film)
        {
            InitializeComponent();
            _film = film;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_film != null)
            {
                _film.Financing();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_film != null)
            {
                _film.Shooting();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_film is EntertainmentFilm entertainmentFilm)
            {
                _film.Sounds();
            }
            else if (_film is ScientificFilm scienceFilm)
            {
                _film.Sounds();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_film is EntertainmentFilm entertainmentFilm)
            {
                _film.EmotionalImpact();
            }
            else if (_film is ScientificFilm scienceFilm)
            {
                _film.EmotionalImpact();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_film is EntertainmentFilm entertainmentFilm)
            {
                entertainmentFilm.Entertain();
            }
            else if (_film is ScientificFilm scienceFilm)
            {
                MessageBox.Show("Эта функция доступна только для развлекательных фильмов!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_film is EntertainmentFilm entertainmentFilm)
            {
                entertainmentFilm.Relax();
            }
            else if (_film is ScientificFilm scienceFilm)
            {
                MessageBox.Show("Эта функция доступна только для развлекательных фильмов!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_film is EntertainmentFilm entertainmentFilm)
            {
                MessageBox.Show("Эта функция доступна только для научных фильмов!");
            }
            else if (_film is ScientificFilm scienceFilm)
            {
                scienceFilm.Educate();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_film is EntertainmentFilm entertainmentFilm)
            {
                MessageBox.Show("Эта функция доступна только для научных фильмов!");
            }
            else if (_film is ScientificFilm scienceFilm)
            {
                scienceFilm.Motivate();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Проверяем, что выбрана строка
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите фильм для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0]; // Получаем выбранную строку
            int filmId = Convert.ToInt32(selectedRow.Cells["id"].Value); // Предполагаем, что в таблице есть столбец с именем "id"

            string tableName;

            if (_film is EntertainmentFilm)
            {
                tableName = "films_schema.films"; // Установка имени таблицы для развлекательных фильмов
            }
            else if (_film is ScientificFilm)
            {
                tableName = "films_schema.films2";
            }
            else
            {
                MessageBox.Show("Неизвестный тип фильма.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open(); // Открываем соединение с базой данных

                string deleteSql = $"DELETE FROM {tableName} WHERE id = @filmId"; // Формируем SQL-запрос для удаления фильма с указанным ID
                using (NpgsqlCommand deleteCommand = new NpgsqlCommand(deleteSql, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@filmId", filmId);
                    int rowsAffected = deleteCommand.ExecuteNonQuery(); // Выполняем SQL-запрос на удаление и получаем количество затронутых строк

                    if (rowsAffected > 0)
                    {
                        // Если rowsAffected > 0, то фильм был успешно удалён
                        MessageBox.Show($"Фильм (ID: {filmId}) удалён из таблицы {tableName}.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка при удалении фильма (ID: {filmId}) из таблицы {tableName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoadFilmsData();
        }
        private void LoadFilmsData()
        {
            string sqlQuery = "";  
            string tableName = "";

            if (_film is EntertainmentFilm)
            {
                sqlQuery = "SELECT * FROM films_schema.films";
                tableName = "films_schema.films";
            }
            else if (_film is ScientificFilm)
            {
                sqlQuery = "SELECT * FROM films_schema.films2";
                tableName = "films_schema.films2";
            }
            else
            {
                MessageBox.Show("Неизвестный тип фильма.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sqlQuery, connection))
                    {
                        DataTable dataTable = new DataTable();

                        dataAdapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных из таблицы {tableName}: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (_film is EntertainmentFilm)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    textBox1.Text = selectedRow.Cells[selectedRow.Cells.Count - 1].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Выберите фильм для изменения информации.");
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Проверяем, что выбрана строка
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получаем выбранную строку
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string newValue = textBox1.Text;

                selectedRow.Cells[selectedRow.Cells.Count - 1].Value = newValue;
                UpdateMovieInDatabase(selectedRow.Index, newValue); // Передаем индекс строки и новое значение

                MessageBox.Show("Информация успешно обновлена.");
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите фильм для изменения информации.");
            }
        }
        private void UpdateMovieInDatabase(int rowIndex, string newValue)
        {
            int movieId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value); 

            using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=films;Username=postgres;Password=d5a8s9h6a"))
            {
                connection.Open();
                string query = "UPDATE films_schema.films SET age_restriction = @NewValue WHERE Id = @id"; 
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue); 
                    command.Parameters.AddWithValue("@id", movieId); 
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (_film is ScientificFilm)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    textBox2.Text = selectedRow.Cells[selectedRow.Cells.Count - 1].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Выберите фильм для изменения информации.");
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Проверяем, что выбрана строка
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получаем выбранную строку
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string newValue = textBox2.Text;

                selectedRow.Cells[selectedRow.Cells.Count - 1].Value = newValue;
                UpdateMovieInDatabase1(selectedRow.Index, newValue); // Передаем индекс строки и новое значение

                MessageBox.Show("Информация успешно обновлена.");
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите фильм для изменения информации.");
            }
        }
        private void UpdateMovieInDatabase1(int rowIndex, string newValue)
        {
            int movieId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value);

            using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=films;Username=postgres;Password=d5a8s9h6a"))
            {
                connection.Open();
                string query = "UPDATE films_schema.films2 SET audience = @NewValue WHERE Id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@id", movieId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}