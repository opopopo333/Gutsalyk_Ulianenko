using System;
using System.Collections.Generic;

namespace ConsoleApp_FirstApp
{
    /// <summary>
    /// Основной класс программы, отвечающий за логику отображения данных о галактиках.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в приложение.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Galaxy News!");
            IterateThroughList();
            Console.ReadKey();
        }

        /// <summary>
        /// Создает коллекцию галактик и выводит информацию о каждой из них в консоль.
        /// </summary>
        private static void IterateThroughList()
        {
            var theGalaxies = new List<Galaxy>
            {
                new Galaxy() { Name="Tadpole", MegaLightYears=400, GalaxyType=new GType('S')},
                new Galaxy() { Name="Pinwheel", MegaLightYears=25, GalaxyType=new GType('S')},
                new Galaxy() { Name="Cartwheel", MegaLightYears=500, GalaxyType=new GType('L')},
                new Galaxy() { Name="Small Magellanic Cloud", MegaLightYears=.2, GalaxyType=new GType('I')},
                new Galaxy() { Name="Andromeda", MegaLightYears=3, GalaxyType=new GType('S')},
                new Galaxy() { Name="Maffei 1", MegaLightYears=11, GalaxyType=new GType('E')}
            };

            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears + ",  " + theGalaxy.GalaxyType.MyGType);
            }
        }
    }

    /// <summary>
    /// Представляет астрономический объект — галактику.
    /// </summary>
    public class Galaxy
    {
        /// <summary>
        /// Название галактики.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Расстояние до галактики в мегасветовых годах.
        /// </summary>
        public double MegaLightYears { get; set; }

        /// <summary>
        /// Классификационный тип галактики.
        /// </summary>
        public GType GalaxyType { get; set; }
    }

    /// <summary>
    /// Обертка для классификации типов галактик.
    /// </summary>
    public class GType
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="GType"/> на основе символьного кода.
        /// </summary>
        /// <param name="type">Символьный код типа: 'S' (Spiral), 'E' (Elliptical), 'I' (Irregular), 'L' (Lenticular).</param>
        public GType(char type)
        {
            switch (type)
            {
                case 'S':
                    MyGType = Type.Spiral;
                    break;
                case 'E':
                    MyGType = Type.Elliptical;
                    break;
                case 'I':
                    MyGType = Type.Irregular;
                    break;
                case 'L':
                    MyGType = Type.Lenticular;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Получает текстовое описание типа галактики.
        /// </summary>
        public object MyGType { get; set; }

        /// <summary>
        /// Перечисление внутренних категорий морфологии галактик.
        /// </summary>
        private enum Type { Spiral, Elliptical, Irregular, Lenticular }
    }
}