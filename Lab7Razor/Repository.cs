using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab7Razor.Models;

namespace Lab7Razor
{
    public class Repository
    {
        private static List<Teacher> repositry = new List<Teacher>
        {
            new Teacher
            {
                FirstName = "Альберт",
                LastName = "Эйнштейн",
                Subject = "Физика",
                Description = "Физик-теоретик, один из основателей современной теоретической физики, лауреат Нобелевской премии по физике 1921 года, общественный деятель-гуманист. Жил в Германии (1879—1893, 1914—1933), Швейцарии (1893—1914) и США (1933—1955). Почётный доктор около 20 ведущих университетов мира, член многих Академий наук, в том числе иностранный почётный член АН СССР (1926)."
            },
            new Teacher
            {
                FirstName = "Рене",
                LastName = "Декарт",
                Subject = "Математика",
                Description = "Французский философ, математик, механик, физик и физиолог, создатель аналитической геометрии и современной алгебраической символики, автор метода радикального сомнения в философии, механицизма в физике, предтеча рефлексологии."
            },
            new Teacher
            {
                FirstName = "Иммануил",
                LastName = "Кант",
                Subject = "Философия",
                Description = "Немецкий философ, родоначальник немецкой классической философии, стоящий на грани эпох Просвещения и романтизма."
            }
        };

        public List<Teacher> Data => repositry;
    }
}