using System;
using UnityEngine;
using UnityEngine.InputSystem;
using static Controls;

namespace Input
{
    [CreateAssetMenu(menuName = "SO/Input/Ingame")]
    public class IngameInputSO : InputSO, IIngameActions
    {
        public event Action OnStackEvent = null;

        protected override void OnEnable()
        {
            base.OnEnable();

            IngameActions ingame = InputManager.controls.Ingame;
            ingame.SetCallbacks(this);
            InputManager.RegistInputMap(this, ingame.Get());
        }

        public void OnStack(InputAction.CallbackContext context)
        {
            if(context.performed)
                OnStackEvent?.Invoke();
        }
    }
}
