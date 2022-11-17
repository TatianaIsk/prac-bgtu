using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class IntelligenseTypeData<T>
    {
        public string Intelligence(T value)
        {
            string output = string.Empty;
            output += $"Имя: {value.GetType().Name}\n";
            output += $"Полное имя: {value.GetType().FullName}\n";
            output += $"Пространство имён: {value.GetType().Namespace}\n";
            output += $"Примитивный? {value.GetType().IsPrimitive}\n";
            output += $"Класс?: {value.GetType().IsClass}\n";
            output += $"Публичный??: {value.GetType().IsPublic}\n";
            var perem = value.GetType().Name.ToLower();
            if (value.GetType().IsPrimitive)
            {
                switch (perem)
                {
                    case "byte":
                        {
                            output += $"Максимальное значение: {byte.MaxValue}\n";
                            output += $"Минимальное значение: {byte.MinValue}\n";
                            break;
                        }
                    case "int32":
                        {
                            output += $"Максимальное значение: {int.MaxValue}\n";
                            output += $"Минимальное значение: {int.MinValue}\n";
                            break;
                        }
                    case "double":
                        {
                            output += $"Максимальное значение: {double.MaxValue}\n";
                            output += $"Минимальное значение: {double.MinValue}\n";
                            break;
                        }
                    case "int16":
                        {
                            output += $"Максимальное значение: {short.MaxValue}\n";
                            output += $"Минимальное значение: {short.MinValue}\n";
                            break;
                        }
                    case "int64":
                        {
                            output += $"Максимальное значение: {long.MaxValue}\n";
                            output += $"Минимальное значение: {long.MinValue}\n";
                            break;
                        }
                    case "decimal":
                        {
                            output += $"Максимальное значение: {decimal.MaxValue}\n";
                            output += $"Минимальное значение: {decimal.MinValue}\n";
                            break;
                        }
                        // и так далее...
                }
            }
            return output;
        }
    }

 }
