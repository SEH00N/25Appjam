using System;
using Input;
using UnityEngine;

namespace Test
{
    public class TInput : MonoBehaviour
    {
        [SerializeField] IngameInputSO input = null;

        private void Awake()
        {
            InputManager.ChangeInputMap(InputMapType.Ingame);

            input.OnStackEvent += HandleStack;
        }

        private void HandleStack()
        {
            Debug.Log("Stack");
        }
    }
}
