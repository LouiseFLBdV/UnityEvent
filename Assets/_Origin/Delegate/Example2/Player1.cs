#pragma warning disable
using System;
using UnityEngine;

// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo

namespace Delegate.Example2
{
    // Такой же пример как в прошлый раз, но уже похожий на игру
    public class Player1 : MonoBehaviour
    {
        // Статы игрока
        private string _name = "Player1";
        private int _level = 5;
        private int _xp = 100;
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
            Debug.Log("Player");
            Debug.Log($"I have {_xp} xp");
            Debug.Log("===================================");
            // Мы убиваем монстра, отправляю при помощи чего убиваем, если это игрок, но он получит
            // икспу, так как на 38 строчке у нас _xp += xp
            _monster.Die(KillMonster);
        }

        private void KillMonster(string name, int xp)
        {
            _xp += xp;
            Debug.Log($"Monster {name}, killed by me");
            Debug.Log($"I have {_xp} xp");
            Debug.Log($"====================================");
        }
    }
}