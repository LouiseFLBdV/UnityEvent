using UnityEngine;

// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo

namespace Delegate.Example1
{
    // Сначала открой класс Stats в этой же директории
    public class ExampleStats1 : MonoBehaviour
    {
        // Просто получаем обьект статс
        private Stats _stats;

        private void Start()
        {
            _stats = gameObject.AddComponent<Stats>();
            // А тут как раз передаем
            // как и в первом примере delegate1 = ShowMessage1;
            // только тут мы уже отправляем его в метод, на 1 раз
            _stats.ReturnStats(DebugStats);
            Debug.Log("---------------------------------------------");
            _stats.ReturnStats(DebugStats2);
        }

        // на строчке с 45 Stats.cs мы 3 раза вызываем метод, который тут передали
        // на 20 строчке
        // Это как инструкция что делать с value и name
        public static void DebugStats(int value, string name)
        {
            Debug.Log(value + name);
        }
        // Логика в том что мы можем разными правилами работать с int value, string name
        // И вызвать как хотим
        public static void DebugStats2(int value, string name)
        {
            Debug.Log(value);
        }
        // Не проблема если не поймете как работает это сейчас, я бы сказал
        // Это что бы понимать надо быть близко к мидлу
        // Но потратить часа 3-6 на понимание, повторения стоит
        // можно придумать свои виды этого вида delegate, поможет понять лучше
        // В данном примере Stats, это класс который хранит данные, урон, скорость, здоровье
        // и так же хранит интерфейс  для работы с этими статами
        // А класс ExampleStats1 просто класс бизнесс логики, который
        // работает с классом Stats
    }
}