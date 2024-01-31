using UnityEngine;

// ReSharper disable CommentTypo

namespace _Origin.Event.Example0
{
    public class EventEx0 : MonoBehaviour
    {
        public delegate void MyDelegate();
        public event MyDelegate MyEvent;
        
        void Start()
        {
        }
    }
}