using System;
using System.Windows.Forms;
using CarManagementApp;

namespace CarManagementApp
{
    public partial class Form1 : Form
    {
        private CarPark carPark = new CarPark();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxCarName.Text;
                int horsePower = int.Parse(textBoxHorsePower.Text);
                int fuelConsumption = int.Parse(textBoxFuelConsumption.Text);
                int fuelTankCapacity = int.Parse(textBoxFuelTankCapacity.Text);
                var car = new Car(name, horsePower, fuelConsumption, fuelTankCapacity);
                carPark.AddCar(car);
                listBoxCars.Items.Add(name);
                listBoxActions.Items.Add($"Добавлен автомобиль: {name}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении автомобиля: {ex.Message}");
            }
        }

        private void buttonRemoveCar_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCar = listBoxCars.SelectedItem?.ToString();
                if (selectedCar != null)
                {
                    carPark.RemoveCar(selectedCar);
                    listBoxCars.Items.Remove(selectedCar);
                    listBoxActions.Items.Add($"Удален автомобиль: {selectedCar}");
                }
                else
                {
                    MessageBox.Show("Выберите автомобиль для удаления.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении автомобиля: {ex.Message}");
            }
        }

        private void buttonStartEngine_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCar = listBoxCars.SelectedItem?.ToString();
                if (selectedCar != null)
                {
                    Car car = carPark.GetCar(selectedCar);
                    car.StartEngine();
                    listBoxActions.Items.Add($"Двигатель автомобиля {selectedCar} запущен.");
                }
                else
                {
                    MessageBox.Show("Выберите автомобиль для запуска двигателя.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске двигателя: {ex.Message}");
            }
        }

        private void buttonStopEngine_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCar = listBoxCars.SelectedItem?.ToString();
                if (selectedCar != null)
                {
                    Car car = carPark.GetCar(selectedCar);
                    car.StopEngine();
                    listBoxActions.Items.Add($"Двигатель автомобиля {selectedCar} остановлен.");
                }
                else
                {
                    MessageBox.Show("Выберите автомобиль для остановки двигателя.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при остановке двигателя: {ex.Message}");
            }
        }

        private void buttonRefuel_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCar = listBoxCars.SelectedItem?.ToString();
                if (selectedCar != null)
                {
                    Car car = carPark.GetCar(selectedCar);
                    int fuelAmount = int.Parse(textBoxFuelAmount.Text);
                    car.Refuel(fuelAmount);
                    listBoxActions.Items.Add($"Автомобиль {selectedCar} заправлен на {fuelAmount} литров.");
                }
                else
                {
                    MessageBox.Show("Выберите автомобиль для заправки.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при заправке автомобиля: {ex.Message}");
            }
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCar = listBoxCars.SelectedItem?.ToString();
                if (selectedCar != null)
                {
                    Car car = carPark.GetCar(selectedCar);
                    int distance = int.Parse(textBoxDistance.Text);

                    // Проверка, выбрал ли пользователь ускоренный режим движения
                    bool isFast = checkBoxFastMode.Checked; // предположим, что это CheckBox для высокой скорости

                    // Вызов перегруженного метода Move с параметром для высокой скорости
                    if (isFast)
                    {
                        car.Move(distance, true); // Перегруженная версия метода Move с параметром isFast
                        listBoxActions.Items.Add($"Автомобиль {selectedCar} проехал {distance} км с высокой скоростью.");
                    }
                    else
                    {
                        car.Move(distance); // Стандартная версия метода Move
                        listBoxActions.Items.Add($"Автомобиль {selectedCar} проехал {distance} км.");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите автомобиль для передвижения.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при движении автомобиля: {ex.Message}");
            }
        }

        private void buttonReplaceWheel_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCar = listBoxCars.SelectedItem?.ToString();
                if (selectedCar != null)
                {
                    Car car = carPark.GetCar(selectedCar);
                    car.ReplaceBrokenWheel();
                    listBoxActions.Items.Add($"Колесо автомобиля {selectedCar} заменено.");
                }
                else
                {
                    MessageBox.Show("Выберите автомобиль для замены колеса.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при замене колеса: {ex.Message}");
            }
        }

        // Обработчик кнопки для отображения подробной информации о машине
        private void buttonShowInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCar = listBoxCars.SelectedItem?.ToString();
                if (selectedCar != null)
                {
                    Car car = carPark.GetCar(selectedCar);
                    bool showDetails = checkBoxShowDetails.Checked;  // Получаем состояние чекбокса
                    string info = car.GetCarInfo(showDetails);  // Получаем подробную информацию, если чекбокс выбран
                    MessageBox.Show(info);
                }
                else
                {
                    MessageBox.Show("Выберите автомобиль для отображения информации.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отображении информации: {ex.Message}");
            }
        }


        private void label1_Click(object sender, EventArgs e) { }
        private void labelFuel_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void labelFuelPerKm_Click(object sender, EventArgs e) { }
    }
}
