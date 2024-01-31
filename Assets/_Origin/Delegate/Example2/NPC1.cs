#pragma warning disable
using System;
using UnityEngine;

// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo

namespace Delegate.Example2
{
    // Такой же пример как в прошлый раз, но уже похожий на игру
    public class Npc1 : MonoBehaviour
    {
        // Статы игрока
        private string _name = "NPC";
        private int _level = 100;
        // Очень внимательно, у нпс нет икспы, как поставил разработчик ему уровень так и будет
        // Это в данном случае
        // private int _xp = 100;
        
        private Monster _monster;

        private void Awake()
        {
            // В игре обычно это по райкасте, мы находим его, но это не важно
            _monster = gameObject.AddComponent<Monster>();
        }

        private void Start()
        {
            // Тут просто в консоль что бы видеть что происходит
            Debug.Log("===================================");
            Debug.Log("NPC IS HERE");
            Debug.Log("===================================");
            // Очень внимательно, мы также убиваем монстра, но теперь, нам икспа не нужна
            // Мы отправляем так же наш метод KillMonster, но у нас теперь он по другому выглядит
            _monster.Die(KillMonsterWithoutXP);
        }

        // Самое классно что класс монстр мы даже не трогаем, мы просто отправили ему функцию как
        // он должен умереть
        private void KillMonsterWithoutXP(string name, int xp)
        {
            Debug.Log($"Monster {name}, killed by me");
            Debug.Log($"====================================");
            Debug.Log($"");
            Debug.Log($"");
            Debug.Log($"");
            Debug.Log($"");
            Debug.Log($"");
        }
    }
}