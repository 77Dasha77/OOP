using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Npgsql;
using static лаба_2.Form2;
using static лаба_2.Form1;

namespace лаба_2
{
    public partial class Form1 : Form
    {
        public string FilmType { get; set; }
        string connectionString = "Host=localhost;Port=5432;Database=films;Username=postgres;Password=d5a8s9h6a";
        public Form1()
        {
            // Инициализируем визуальные компоненты формы.
            InitializeComponent();
            // Скрываем поля ввода и кнопку "ОК" при запуске
            HideInputFields();
        }
        // Базовый класс Фильм
        public class Film
        {
            // Объявление защищённых свойств
            protected string Scenario { get; set; } // get; set; означает, что можно получать и устанавливать значение этого свойства
            protected string Montage { get; set; }
            // Объявление конструктора класса Film
            public Film(string scenario, string montage)
            {
                Scenario = scenario;
                Montage = montage;
            }

            public virtual void Financing() { MessageBox.Show("Получение финансирования для фильма... Финансирование получено."); }
            public virtual void Shooting() { MessageBox.Show("Съёмки фильма... Съёмки фильма завершены."); }
            public virtual void Sounds() { MessageBox.Show("Воспроизведение стандартных звуковых эффектов... Стандартные звуковые эффекты воспроизведены."); }
            public virtual void EmotionalImpact() { MessageBox.Show("Стандартное воздействие на эмоции... Воздействие на эмоции завершено."); }
        }

        // Подкласс Развлекательный
        public class EntertainmentFilm : Film
        {
            public string Type { get; set; }
            public string AgeRestriction { get; set; }

            public EntertainmentFilm(string scenario, string montage, string type, string ageRestriction) : base(scenario, montage) // : base(scenario, montage) вызов конструктора базового класса Film
            {
                Type = type;
                AgeRestriction = ageRestriction;
            }

            public void Entertain() { MessageBox.Show("Развлечение зрителя..."); }
            public void Relax() { MessageBox.Show("Расслабление зрителя..."); }
            public override void Sounds() { MessageBox.Show("Громкие звуки..."); } // override - метод переопределяет метод из базового класса
            public override void EmotionalImpact() { MessageBox.Show("Широкий спектр эмоций..."); }
        }

        // Подкласс Научный
        public class ScientificFilm : Film
        {
            public string Field { get; set; }
            public string Audience { get; set; }

            public ScientificFilm(string scenario, string montage, string field, string audience) : base(scenario, montage)
            {
                Field = field;
                Audience = audience;
            }

            public void Educate() { MessageBox.Show("Обучение зрителя..."); }
            public void Motivate() { MessageBox.Show("Мотивация зрителя..."); }
            public override void Sounds() { MessageBox.Show("Спокойные ненавязчивые звуки..."); }
            public override void EmotionalImpact() { MessageBox.Show("Эмоции удивления, восхищения, размышления..."); }
        }
        private void HideInputFields()
        {
            labelScenario.Visible = false;
            textBoxScenario.Visible = false;
            labelMontage.Visible = false;
            textBoxMontage.Visible = false;
            labelType.Visible = false;
            textBoxType.Visible = false;
            labelAgeRestriction.Visible = false;
            textBoxAgeRestriction.Visible = false;
            labelField.Visible = false;
            textBoxField.Visible = false;
            labelAudience.Visible = false;
            textBoxAudience.Visible = false;
            buttonOK.Visible = false;
            button3.Visible = false;
        }
        private void ShowEntertainmentFields()
        {
            HideInputFields();  // Сначала скрываем все поля

            labelScenario.Visible = true;
            textBoxScenario.Visible = true;
            labelMontage.Visible = true;
            textBoxMontage.Visible = true;
            labelType.Visible = true;
            textBoxType.Visible = true;
            labelAgeRestriction.Visible = true;
            textBoxAgeRestriction.Visible = true;
            buttonOK.Visible = true;
            button3.Visible = true;
        }
        private void ShowScientificFields()
        {
            HideInputFields();  // Сначала скрываем все поля

            labelScenario.Visible = true;
            textBoxScenario.Visible = true;
            labelMontage.Visible = true;
            textBoxMontage.Visible = true;
            labelField.Visible = true;
            textBoxField.Visible = true;
            labelAudience.Visible = true;
            textBoxAudience.Visible = true;
            buttonOK.Visible = true;
            button3.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowEntertainmentFields();
            FilmType = "Entertainment"; //Сохраняем выбранный тип фильма
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowScientificFields();
            FilmType = "Scientific"; //Сохраняем выбранный тип фильма
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Считываем данные из полей ввода на форме
            string scenario = textBoxScenario.Text;
            string montage = textBoxMontage.Text;
            string type = textBoxType.Text;
            string ageRestriction = textBoxAgeRestriction.Text;
            string field = textBoxField.Text;
            string audience = textBoxAudience.Text;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open(); // Открываем соединение с базой данных.
                    if (FilmType == "Entertainment")
                    {
                        // Формируем SQL-запрос для вставки данных о развлекательном фильме в таблицу
                        string sql = "INSERT INTO films_schema.films (script, editing, type, age_restriction) VALUES (@scenario, @montage, @type, @ageRestriction)";
                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("scenario", scenario);
                            command.Parameters.AddWithValue("montage", montage);
                            command.Parameters.AddWithValue("type", type);
                            command.Parameters.AddWithValue("ageRestriction", ageRestriction);
                            // Выполняем SQL-запрос.
                            command.ExecuteNonQuery();
                        }
                        // Создаём объект EntertainmentFilm с данными из полей ввода
                        EntertainmentFilm entertainmentFilm = new EntertainmentFilm(textBoxScenario.Text, textBoxMontage.Text, textBoxType.Text, textBoxAgeRestriction.Text);
                        MessageBox.Show("Фильм добавлен в базу данных!");
                        // Создаём и отображаем вторую форму и передаём ей объект EntertainmentFilm
                        Form2 form2 = new Form2(entertainmentFilm);
                        form2.Show();
                    }
                    else if (FilmType == "Scientific")
                    {
                        string sql = "INSERT INTO films_schema.films2 (script, editing, area, audience) VALUES (@scenario, @montage, @field, @audience)";
                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("scenario", scenario);
                            command.Parameters.AddWithValue("montage", montage);
                            command.Parameters.AddWithValue("field", field);
                            command.Parameters.AddWithValue("audience", audience);
                            command.ExecuteNonQuery();
                        }
                        ScientificFilm scientificFilm = new ScientificFilm(textBoxScenario.Text, textBoxMontage.Text, textBoxField.Text, textBoxAudience.Text);
                        MessageBox.Show("Фильм добавлен в базу данных!");
                        Form2 form2 = new Form2(scientificFilm);
                        form2.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении фильма в базу данных: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FilmType == "Entertainment")
            {
                EntertainmentFilm entertainmentFilm = new EntertainmentFilm(textBoxScenario.Text, textBoxMontage.Text, textBoxType.Text, textBoxAgeRestriction.Text);
                Form2 form2 = new Form2(entertainmentFilm);
                form2.Show();
            }
            else if (FilmType == "Scientific")
            {
                ScientificFilm scientificFilm = new ScientificFilm(textBoxScenario.Text, textBoxMontage.Text, textBoxField.Text, textBoxAudience.Text);
                Form2 form2 = new Form2(scientificFilm);
                form2.Show();
            }
        }
    }
}