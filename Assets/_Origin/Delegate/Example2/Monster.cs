#pragma warning disable
using System;
using UnityEngine;

// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo

namespace Delegate.Example2
{
    // Сначала открой класс Stats в этой же директории
    public class Monster : MonoBehaviour
    {
        private string _name = "Boss";
        private int _xp = 1000;
        private bool _isAlive = true;

        public delegate void Callback(string name, int xp);
        
        public void Die(Callback callback)
        {
            Destroy();
            callback?.Invoke(_name, _xp);
        }

        private void Destroy()
        {
            _isAlive = false;
            // Можно добавить коурутину что бы он анимацию смерии
            // прошел и потом умер
            Destroy(this);
        }
    }
}