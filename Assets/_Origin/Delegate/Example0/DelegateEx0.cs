using UnityEngine;

// ReSharper disable CommentTypo

namespace Delegate.Example0
{
    public class DelegateEx0 : MonoBehaviour
    {
        // delegate это переменная которые хранит ссылки на методы. 
        // В данном случае переменная имеет назавание Delegate1
        public delegate void Delegate1(string str);
        // Разберем на состовные, -- public --, вы уже знаете, -- delegate --, это ключевое слово для языка программирования 
        // которая обозночает что переменная будет делегатором, -- void -- это что будет возвращать метод который храним в делегаторе
        // -- Delegate1 -- это название, -- string str -- это что будет принимать метод в коробке
        
        // Ноооооооо, это вообще суть методов, а в чем тогда смысл делегейт? В том что мы можем подключить 5 методов к 1 делегату, ниже пример.
        
        void Start()
        {
            // Вообще делегаты встроены в C#
            // Тут мы создаем delegate1 который будет иметь тип Delegate1
            Delegate1 delegate1;
            // а вот тут мы подписываем метод ShowMessage1 к делегатору
            delegate1 = ShowMessage1;
            
            // И наконецто после того как подписали мы вызываем его
            delegate1("Hello");
            //Просто что бы отделить консольные логи
            Debug.Log("---------------------------------------------------------");
            // Теперь к сути, мы можем сразу 3 метода подписать к одному делегату
            delegate1 = delegate1 + ShowMessage2;
            // илиже можно написать
            // delegate1 += ShowMessage2;
            delegate1 += ShowMessage3;

            // Вызываем всех кто подписался
            delegate1("Hi");
            // Что бы посмотреть что будет в консоли в обьекте ScriptTest подключите Script DelegateEx0
        }

        // Тут 3 метода которые подписались на делегат
        public static void ShowMessage1(string str)
        {
            Debug.Log("ShowMessage1: " + str);
        }

        public static void ShowMessage2(string str)
        {
            Debug.Log("ShowMessage2: " + str);
        }
        public static void ShowMessage3(string str)
        {
            Debug.Log("ShowMessage3: " + str);
        }
    }
}