using System;

namespace carSpace
{
    class carSpace
    {   
        static List<Car> carList = new();
        static int id = 0; 
        //static Car test = new Car(1, "Tesla", "Model", 2021 , "Red" ,1000, true);
        
        static void Main(string[] args)
        {
            Boolean exit = true;  
            while (exit) {
                Console.WriteLine("Выберите необходимое действие:");
                Console.WriteLine("1: Добавить автомобиль ADD");
                Console.WriteLine("2: Удалить автомобиль REMOVE");
                Console.WriteLine("3: Найти автомобиль по марке: FIND");
                Console.WriteLine("4: Вывести весь список автопарка PRINT");
                Console.WriteLine("5: Выход EXIT");
                int action = Convert.ToInt16(Console.ReadLine());
                switch (action){
                    case 1: 
                         carList.Add(AddToList());
                         break;
                    case 2: 
                         
                         DeleteFromList();
                         break;
                    case 3: 
                         FindCar();
                         break;   

                    case 4: 
                         foreach (Car elem in carList) {
                            elem.Print();
                         }
                         break;                               
                    case 5: 
                         exit = false;
                         break;
                    
                               
                }
            } 

        }

        static Car AddToList () {
            Console.WriteLine ("Введите новый автомобиль в формате:  Tesla Model 2021 Red 1000 True");
            String strCar = Console.ReadLine();
            String[] arrCar = strCar.Split(" ");
            id = id + 1;
            Car newCar = new Car(id, arrCar[0], arrCar[1], Convert.ToInt32(arrCar[2]), arrCar[3], Convert.ToDouble(arrCar[4]), true);
            return newCar;
        }

        static void DeleteFromList () {
            Console.WriteLine ("Введи номер позиции для удаления ###");
            int index = Convert.ToInt16(Console.ReadLine());
            carList.RemoveAt(index-1); 
            Console.WriteLine ("Данная позиция удалена");
        }

        static void FindCar () {
            Console.WriteLine ("Введи марку авто");
            String mark = Console.ReadLine();

            foreach(Car car in carList){
                if (car.mark.Equals(mark)){
                    car.Print();
                }
            }
        }

    }




}