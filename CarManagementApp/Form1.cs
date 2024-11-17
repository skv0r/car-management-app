using System;
using System.Windows.Forms;

namespace CarManagementApp
{
    public partial class Form1 : Form
    {
        private CarPark carPark = new CarPark(); // Автопарк для хранения автомобилей

        public Form1()
        {
            InitializeComponent();
        }

        // Добавить автомобиль
        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            string carName = textBoxCarName.Text; // Получаем текст из текстового поля
            if (!string.IsNullOrEmpty(carName))
            {
                Car newCar = new Car(carName, 150); // Создаём новый автомобиль с мощностью двигателя 150
                carPark.AddCar(newCar); // Добавляем автомобиль в автопарк
                listBoxActions.Items.Add($"Автомобиль '{carName}' добавлен в автопарк.");
                listBoxCars.Items.Add(carName); // Обновляем список автомобилей на форме
            }
            else
            {
                MessageBox.Show("Введите название автомобиля!");
            }
        }

        // Запустить двигатель для выбранного автомобиля
        private void btnStartEngine_Click(object sender, EventArgs e)
        {
            string selectedCar = listBoxCars.SelectedItem?.ToString();
            if (selectedCar != null)
            {
                Car car = carPark.GetCar(selectedCar);
                if (car != null)
                {
                    car.Engine.Start();
                    listBoxActions.Items.Add($"Двигатель автомобиля '{car.Name}' запущен.");
                }
            }
            else
            {
                MessageBox.Show("Выберите автомобиль для запуска двигателя.");
            }
        }

        // Заменить колесо
        private void btnReplaceWheel_Click(object sender, EventArgs e)
        {
            string selectedCar = listBoxCars.SelectedItem?.ToString();
            if (selectedCar != null)
            {
                Car car = carPark.GetCar(selectedCar);
                if (car != null)
                {
                    car.Wheels[0].Replace(); // Меняем первое колесо
                    listBoxActions.Items.Add($"Колесо автомобиля '{car.Name}' заменено.");
                }
            }
            else
            {
                MessageBox.Show("Выберите автомобиль для замены колеса.");
            }
        }

        // Удалить автомобиль
        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            string selectedCar = listBoxCars.SelectedItem?.ToString();
            if (selectedCar != null)
            {
                Car carToRemove = carPark.GetCar(selectedCar);
                if (carToRemove != null)
                {
                    carPark.RemoveCar(carToRemove); // Удаляем автомобиль из автопарка
                    listBoxCars.Items.Remove(selectedCar); // Удаляем из списка на форме
                    listBoxActions.Items.Add($"Автомобиль '{selectedCar}' удалён из автопарка.");
                }
            }
            else
            {
                MessageBox.Show("Выберите автомобиль для удаления.");
            }
        }

        // Пустые методы — удаляем
        // Удалите метод button1_Click, если он не используется
    }
}
