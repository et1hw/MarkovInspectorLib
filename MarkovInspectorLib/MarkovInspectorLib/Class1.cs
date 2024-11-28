using System;
using System.Collections.Generic;

namespace InspectorLib
{
    public class FunctionInsp
    {
        // Данные автоинспекции
        private const string CarInspectionName = "Автоинспекция г. Чита";
        private string chiefInspector = "Васильев Василий Иванович";
        private readonly List<string> workers = new List<string>
        {
            "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И."
        };

        // Метод возвращает ФИО главного инспектора
        public string GetInspector()
        {
            return chiefInspector;
        }

        // Метод возвращает название автоинспекции
        public string GetCarInspection()
        {
            return CarInspectionName;
        }

        // Метод изменяет ФИО главного инспектора, если оно есть в списке сотрудников
        public bool SetInspector(string fullname)
        {
            if (workers.Contains(fullname))
            {
                chiefInspector = fullname;
                return true;
            }
            return false;
        }

        // Метод генерирует госномер
        public string GenerateNumber(int number, char symbol, int code)
        {
            symbol = char.ToUpper(symbol); // Приведение символа к верхнему регистру
            string formattedNumber = $"{symbol}{number:D4}_{code:D2}";
            return formattedNumber;
        }

        // Метод возвращает список сотрудников
        public List<string> GetWorker()
        {
            return new List<string>(workers); // Возвращаем копию списка сотрудников
        }

        // Метод добавляет нового сотрудника в список сотрудников
        public void AddWorker(string fullname)
        {
            if (!string.IsNullOrWhiteSpace(fullname) && !workers.Contains(fullname))
            {
                workers.Add(fullname);
            }
        }
    }
}
