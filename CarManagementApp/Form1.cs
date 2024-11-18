using System;
using System.Windows.Forms;
using CarManagementApp;

namespace CarManagementApp
{
    public partial class Form1 : Form
    {
        // Объект автопарка, который будет хранить все автомобили
        private CarPark carPark = new CarPark();

        // Конструктор формы, инициализация компонентов
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик кнопки "Создать авто"
        // При нажатии создает новый объект Car с параметрами из текстовых полей, добавляет его в автопарк
        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем данные из текстовых полей
                string name = textBoxCarName.Text;
                int horsePower = int.Parse(textBoxHorsePower.Text);
                int fuelConsumption = int.Parse(textBoxFuelConsumption.Text);
                int fuelTankCapacity = int.Parse(textBoxFuelTankCapacity.Text);

                // Создаем новый автомобиль
                var car = new Car(name, horsePower, fuelConsumption, fuelTankCapacity);

                // Добавляем автомобиль в автопарк
                carPark.AddCar(car);

                // Обновляем интерфейс: добавляем машину в список и выводим действия
                listBoxCars.Items.Add(name);
                listBoxActions.Items.Add($"Добавлен автомобиль: {name}");
            }
            catch (Exception ex)
            {
                // В случае ошибки выводим сообщение
                MessageBox.Show($"Ошибка при добавлении автомобиля: {ex.Message}");
            }
        }

        // Обработчик кнопки "Удалить авто"
        // При нажатии удаляет выбранный автомобиль из автопарка
        private void buttonRemoveCar_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем выбранную машину из списка
                string selectedCar = listBoxCars.SelectedItem?.ToString();
                if (selectedCar != null)
                {
                    // Удаляем машину из автопарка
                    carPark.RemoveCar(selectedCar);

                    // Обновляем интерфейс: удаляем машину из списка и выводим действия
                    listBoxCars.Items.Remove(selectedCar);
                    listBoxActions.Items.Add($"Удален автомобиль: {selectedCar}");
                }
                else
                {
                    // Если машина не выбрана, выводим предупреждение
                    MessageBox.Show("Выберите автомобиль для удаления.");
                }
            }
            catch (Exception ex)
            {
                // В случае ошибки выводим сообщение
                MessageBox.Show($"Ошибка при удалении автомобиля: {ex.Message}");
            }
        }

        // Обработчик кнопки "Запустить двигатель"
        // При нажатии запускает двигатель выбранного автомобиля
        private void buttonStartEngine_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем выбранную машину из списка
                string selectedCar = listBoxCars.SelectedItem?.ToString();
                if (selectedCar != null)
                {
                    // Получаем объект автомобиля из автопарка и запускаем двигатель
                    Car car = carPark.GetCar(selectedCar);
                    car.StartEngine();

                    // Обновляем интерфейс: выводим действия
                    listBoxActions.Items.Add($"Двигатель автомобиля {selectedCar} запущен.");
                }
                else
                {
                    // Если машина не выбрана, выводим предупреждение
                    MessageBox.Show("Выберите автомобиль для запуска двигателя.");
                }
            }
            catch (Exception ex)
            {
                // В случае ошибки выводим сообщение
                MessageBox.Show($"Ошибка при запуске двигателя: {ex.Message}");
            }
        }

        // Обработчик кнопки "Выключить двигатель"
        // При нажатии выключает двигатель выбранного автомобиля
        private void buttonStopEngine_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем выбранную машину из списка
                string selectedCar = listBoxCars.SelectedItem?.ToString();
                if (selectedCar != null)
                {
                    // Получаем объект автомобиля из автопарка и выключаем двигатель
                    Car car = carPark.GetCar(selectedCar);
                    car.StopEngine();

                    // Обновляем интерфейс: выводим действия
                    listBoxActions.Items.Add($"Двигатель автомобиля {selectedCar} остановлен.");
                }
                else
                {
                    // Если машина не выбрана, выводим предупреждение
                    MessageBox.Show("Выберите автомобиль для остановки двигателя.");
                }
            }
            catch (Exception ex)
            {
                // В случае ошибки выводим сообщение
                MessageBox.Show($"Ошибка при остановке двигателя: {ex.Message}");
            }
        }

        // Обработчик кнопки "Заправка"
        // При нажатии заправляет выбранный автомобиль на указанное количество топлива
        private void buttonRefuel_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем выбранную машину из списка
                string selectedCar = listBoxCars.SelectedItem?.ToString();
                if (selectedCar != null)
                {
                    // Получаем количество топлива из текстового поля
                    int fuelAmount = int.Parse(textBoxFuelAmount.Text);

                    // Получаем объект автомобиля из автопарка и заправляем его
                    Car car = carPark.GetCar(selectedCar);
                    car.Refuel(fuelAmount);

                    // Обновляем интерфейс: выводим действия
                    listBoxActions.Items.Add($"Автомобиль {selectedCar} заправлен на {fuelAmount} литров.");
                }
                else
                {
                    // Если машина не выбрана, выводим предупреждение
                    MessageBox.Show("Выберите автомобиль для заправки.");
                }
            }
            catch (Exception ex)
            {
                // В случае ошибки выводим сообщение
                MessageBox.Show($"Ошибка при заправке автомобиля: {ex.Message}");
            }
        }

        // Обработчик кнопки "Передвижение"
        // При нажатии передвигает выбранный автомобиль на указанное расстояние
        private void buttonMove_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем выбранную машину из списка
                string selectedCar = listBoxCars.SelectedItem?.ToString();
                if (selectedCar != null)
                {
                    // Получаем расстояние из текстового поля
                    int distance = int.Parse(textBoxDistance.Text);

                    // Проверка, выбрал ли пользователь ускоренный режим движения
                    bool isFast = checkBoxFastMode.Checked;

                    // Вызов перегруженного метода Move с параметром для высокой скорости
                    if (isFast)
                    {
                        // Перемещение с высокой скоростью
                        Car car = carPark.GetCar(selectedCar);
                        car.Move(distance, true); // Перегруженная версия метода Move с параметром isFast
                        listBoxActions.Items.Add($"Автомобиль {selectedCar} проехал {distance} км с высокой скоростью.");
                    }
                    else
                    {
                        // Стандартное перемещение
                        Car car = carPark.GetCar(selectedCar);
                        car.Move(distance); // Стандартная версия метода Move
                        listBoxActions.Items.Add($"Автомобиль {selectedCar} проехал {distance} км.");
                    }
                }
                else
                {
                    // Если машина не выбрана, выводим предупреждение
                    MessageBox.Show("Выберите автомобиль для передвижения.");
                }
            }
            catch (Exception ex)
            {
                // В случае ошибки выводим сообщение
                MessageBox.Show($"Ошибка при движении автомобиля: {ex.Message}");
            }
        }

        // Обработчик кнопки "Заменить колесо"
        // При нажатии заменяет сломанное колесо выбранного автомобиля
        private void buttonReplaceWheel_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем выбранную машину из списка
                string selectedCar = listBoxCars.SelectedItem?.ToString();
                if (selectedCar != null)
                {
                    // Получаем объект автомобиля из автопарка и заменяем колесо
                    Car car = carPark.GetCar(selectedCar);
                    car.ReplaceBrokenWheel();

                    // Обновляем интерфейс: выводим действия
                    listBoxActions.Items.Add($"Колесо автомобиля {selectedCar} заменено.");
                }
                else
                {
                    // Если машина не выбрана, выводим предупреждение
                    MessageBox.Show("Выберите автомобиль для замены колеса.");
                }
            }
            catch (Exception ex)
            {
                // В случае ошибки выводим сообщение
                MessageBox.Show($"Ошибка при замене колеса: {ex.Message}");
            }
        }

        // Обработчик кнопки "Показать информацию"
        // При нажатии отображает информацию о выбранном автомобиле
        private void buttonShowInfo_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем выбранную машину из списка
                string selectedCar = listBoxCars.SelectedItem?.ToString();
                if (selectedCar != null)
                {
                    // Получаем объект автомобиля из автопарка
                    Car car = carPark.GetCar(selectedCar);
                    bool showDetails = checkBoxShowDetails.Checked;  // Получаем состояние чекбокса для подробной информации

                    // Получаем информацию о машине
                    string info = car.GetCarInfo(showDetails);  // Получаем подробную информацию, если чекбокс выбран
                    MessageBox.Show(info);  // Показываем информацию о машине
                }
                else
                {
                    // Если машина не выбрана, выводим предупреждение
                    MessageBox.Show("Выберите автомобиль для отображения информации.");
                }
            }
            catch (Exception ex)
            {
                // В случае ошибки выводим сообщение
                MessageBox.Show($"Ошибка при отображении информации: {ex.Message}");
            }
        }
    }
}
