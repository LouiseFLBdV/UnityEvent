using UnityEngine;

// ReSharper disable CommentTypo

namespace Delegate.Example0
{
    public class DelegateEx2 : MonoBehaviour
    {
        public delegate void Delegate1(string str);
        public delegate void Delegate2();
        void Start()
        {
            Delegate1 delegate1 = null;
            Delegate2 delegate2 = null;
            //
            // delegate1("Hello"); Если мы бы вызвали делегат до того как мы бы подписались на него, то была бы ошибка null refference exception
            // что бы этого избежать надо проверить на null
            if (delegate1 != null)
            {
                delegate1("Hello");
            }
            // В этом коде понятно что он Null, но не всегда мы властны и есть более простой способ вообще работать с делегатами, это метод Invoke()
            // delegate1.Invoke("Hello");
            // Но и тут если он null выдаст ошибку но как раз можно добавить знак вопроса, который проверяет как if если он Null
            delegate1?.Invoke("Hello");
            // В данном случае ошибки не будет и ничего не сломается, так что всегда для делегаторов надо использовать Invoke();
            Debug.Log("----------------------------");
            delegate1 = ShowMessage3;
            delegate2 += ShowMessage1;
            delegate2 += ShowMessage2;

            delegate1.Invoke("qwerty");
            delegate2.Invoke();
            Debug.Log("----------------------------");
            // Что бы посмотреть что будет в консоли в обьекте ScriptTest подключите Script DelegateEx3
        }

        // Тут 3 метода которые подписались на делегат
        public static void ShowMessage1()
        {
            Debug.Log("Пусто, без текста");
        }

        public static void ShowMessage2()
        {
            Debug.Log("Пусто, без текста");
        }
        public static void ShowMessage3(string str)
        {
            Debug.Log("ShowMessage3: " + str);
        }
    }
}