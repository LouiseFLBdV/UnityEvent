using UnityEngine;

// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo

namespace Delegate.Example1
{
    // Очень сложный пример, ну упростить невозможно, просто надо
    // чуток больше времени на понимания
    // Прошлый пример можно было упрастить до Редактора журнала и те которые подписываются
    // А тут сразу в бой, как часто используется в unity и в разных ассетов
    public class Stats : MonoBehaviour
    {
        // Тут мы просто храним данные игрока к примеру, у него урон, здоровье и скорость
        private int _damage = 10;
        private int _hp = 100;
        private int _speed = 1;

        // Сложность появляется тут, мы создаем delegate
        // Это как инструкция
        public delegate void StatsCallback(int value, string name);
        // в прошлом примере тоже создавали, но логика была по проще
        // todo public delegate void Delegate1(string str);
        // ...
        // Вот тут мы подписывали ShowMessage1 к делегату
        // todo delegate1 = ShowMessage1;
        // А тут Делегат уже разносил к примиру газеты
        // todo delegate1.Invoke("Газета");
        // ...
        // todo public static void ShowMessage1(string str)
        // todo {
        // todo     Debug.Log("ShowMessage1: " + str);
        // todo }
        
        
        // А тут мы получаем этот ShowMessage1 с другого класса(ExampleStats1)
        // И 3 раза вызываем Invoke тоесть 3 раза вызавим метод который получим
        // но обязательно метод должен иметь (int и string)
        // так как на строчке 21 мы задали каким должен быть метод
        // StatsCallback(int value, string name)
        // В сущности это так же как в первом примери, только по другому
        // структурированно
        public void ReturnStats(StatsCallback statsCallback)
        {
            statsCallback?.Invoke(_damage, " Урона");
            statsCallback?.Invoke(_hp, " Здоровья");
            statsCallback?.Invoke(_speed, " Скорости");
        }
    }
}