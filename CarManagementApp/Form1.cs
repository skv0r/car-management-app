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
            string carName = textBoxCarName.Text;
            if (int.TryParse(textBoxFuelConsumption.Text, out int fuelConsumption) && fuelConsumption > 0)
            {
                if (!string.IsNullOrEmpty(carName))
                {
                    try
                    {
                        Car newCar = new Car(carName, 150, fuelConsumption, 50); // Создаем новый автомобиль
                        carPark.AddCar(newCar); // Добавляем его в автопарк
                        listBoxCars.Items.Add(carName); // Добавляем его в список на форме
                        listBoxActions.Items.Add($"Автомобиль '{carName}' добавлен. Расход топлива: {fuelConsumption} л/100 км.");
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message); // Показываем сообщение об ошибке, если машина с таким именем уже существует
                    }
                }
                else
                {
                    MessageBox.Show("Введите название автомобиля!");
                }
            }
            else
            {
                MessageBox.Show("Введите корректный расход топлива!");
            }
        }

        // Запустить двигатель
        private void btnStartEngine_Click(object sender, EventArgs e)
        {
            string selectedCar = listBoxCars.SelectedItem?.ToString();
            if (selectedCar != null)
            {
                Car car = carPark.GetCar(selectedCar);
                if (car != null)
                {
                    car.StartEngine();
                    listBoxActions.Items.Add($"Двигатель автомобиля '{car.Name}' запущен.");
                }
                else
                {
                    MessageBox.Show("Автомобиль не найден в парке.");
                }
            }
            else
            {
                MessageBox.Show("Выберите автомобиль для запуска двигателя.");
            }
        }

        // Остановить двигатель
        private void btnStopEngine_Click(object sender, EventArgs e)
        {
            string selectedCar = listBoxCars.SelectedItem?.ToString();
            if (selectedCar != null)
            {
                Car car = carPark.GetCar(selectedCar);
                if (car != null)
                {
                    car.StopEngine();
                    listBoxActions.Items.Add($"Двигатель автомобиля '{car.Name}' остановлен.");
                }
                else
                {
                    MessageBox.Show("Автомобиль не найден в парке.");
                }
            }
            else
            {
                MessageBox.Show("Выберите автомобиль для остановки двигателя.");
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
                else
                {
                    MessageBox.Show("Автомобиль не найден в парке.");
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
                carPark.RemoveCar(selectedCar); // Удаляем автомобиль из автопарка
                listBoxCars.Items.Remove(selectedCar); // Удаляем из списка на форме
                listBoxActions.Items.Add($"Автомобиль '{selectedCar}' удалён из автопарка.");
            }
            else
            {
                MessageBox.Show("Выберите автомобиль для удаления.");
            }
        }

        // Показать информацию об автомобиле
        private void btnShowCarInfo_Click(object sender, EventArgs e)
        {
            string selectedCar = listBoxCars.SelectedItem?.ToString();
            if (selectedCar != null)
            {
                Car car = carPark.GetCar(selectedCar);
                if (car != null)
                {
                    MessageBox.Show(car.GetCarInfo(), "Информация об автомобиле");
                }
                else
                {
                    MessageBox.Show("Автомобиль не найден в парке.");
                }
            }
            else
            {
                MessageBox.Show("Выберите автомобиль для отображения информации.");
            }
        }

        // Передвижение автомобиля
        private void btnMoveCar_Click(object sender, EventArgs e)
        {
            string selectedCar = listBoxCars.SelectedItem?.ToString();
            if (selectedCar != null)
            {
                Car car = carPark.GetCar(selectedCar);
                if (car != null)
                {
                    if (car.IsEngineOn)
                    {
                        int distance = 0;
                        if (int.TryParse(textBoxMoveDistance.Text, out distance))
                        {
                            try
                            {
                                car.Move(distance); // Передвижение на указанное расстояние
                                listBoxActions.Items.Add($"Автомобиль '{car.Name}' проехал {distance} км. Остаток топлива: {car.Fuel}/{car.FuelTankCapacity} л.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Введите корректное расстояние.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Двигатель автомобиля выключен! Сначала запустите двигатель.");
                    }
                }
                else
                {
                    MessageBox.Show("Автомобиль не найден в парке.");
                }
            }
            else
            {
                MessageBox.Show("Выберите автомобиль.");
            }
        }

        // Заправка автомобиля
        private void btnRefuelCar_Click(object sender, EventArgs e)
        {
            string selectedCar = listBoxCars.SelectedItem?.ToString();
            if (selectedCar != null)
            {
                Car car = carPark.GetCar(selectedCar);
                if (car != null)
                {
                    int refuelAmount = 0;
                    if (int.TryParse(textBoxRefuelAmount.Text, out refuelAmount) && refuelAmount > 0)
                    {
                        car.Refuel(refuelAmount); // Заправляем на указанное количество литров
                        listBoxActions.Items.Add($"Автомобиль '{car.Name}' заправлен на {refuelAmount} литров.");
                    }
                    else
                    {
                        MessageBox.Show("Введите корректное количество топлива для заправки.");
                    }
                }
                else
                {
                    MessageBox.Show("Автомобиль не найден в парке.");
                }
            }
            else
            {
                MessageBox.Show("Выберите автомобиль.");
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
