using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        // Конструктор
        public Form1()
        {
            InitializeComponent();
            // Инициализация курсов в ComboBox
            comboBoxCourse.Items.Add("Математика");
            comboBoxCourse.Items.Add("Физика");
            comboBoxCourse.Items.Add("Химия");
            comboBoxCourse.Items.Add("Биология");
        }

        // Обработчик события для кнопки "Добавить"
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text; // Получение полного имени
            string course = comboBoxCourse.SelectedItem?.ToString() ?? "Не выбрано"; // Получение выбранного курса
            string grade = textBoxGrades.Text; // Получение оценки

            if (!string.IsNullOrWhiteSpace(fullName) && !string.IsNullOrWhiteSpace(grade))
            {
                // Добавление студента в список
                listBoxStudents.Items.Add($"{fullName} - {course} - Оценка: {grade}");
                // Очистка полей ввода
                textBoxFullName.Clear();
                comboBoxCourse.SelectedIndex = -1;
                textBoxGrades.Clear();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик события для кнопки "Удалить"
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem != null)
            {
                // Удаление выбранного студента из списка
                listBoxStudents.Items.Remove(listBoxStudents.SelectedItem);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите студента для удаления.", "Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
