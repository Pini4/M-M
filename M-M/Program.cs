internal class Program
{
    private static void Main(string[] args)
    {
        /*
         int[] array = { 1, 2, 3, 4, 5, 6, 7 };

         Random rnd = new Random();

         array[0] = rnd.Next(16, 30);
         string[] pers_array = { "Грибоедов Алексей Васильевич", "Сорокин Александр Николаевич", "Быстроногов Афанасий Александрович", "Новиков Артур Владиславович", "Михайлов Антон Юрьевич", "Булкин Анатолий Павлович", "Лопухов Андрей Иванович" };
         string[] cities_array = { "Москва", "Санкт-Петербург", "Самара", "Казань", "Новосибирск", "Екатеринбург", "Нижний Новгород" };

         int Age = array[0];
         int index1 = rnd.Next(1, 7);
         int index = rnd.Next(1, 7);


         Console.WriteLine($" {pers_array[index]} проживает в городе {cities_array[index1]}");
         */
        int[] age = { 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        string[] fio = { "Василий Иванович Петров", "Петр Васильевич Иванов", "Иван Петрович Васильев" };
        string[] cities = { "Казань", "Ульяновск", "Москва", "Питер", "Рязань", "Нижний Новгород", "Новосибирск" };

        Random rand = new Random();
        Response(fio[rand.Next(fio.Length)], age[rand.Next(age.Length)], cities[rand.Next(cities.Length)]);
        string resp = Response(fio[rand.Next(fio.Length)], age[rand.Next(age.Length)], cities[rand.Next(cities.Length)]);
        static string Response(string fio, int age, string city)
        {
            Console.WriteLine($"Имя: {fio}. Возраст:{age}. Город: {city}.");
            return $"Имя: {fio}. Возраст:{age}. Город: {city}.";
        }


    }
}