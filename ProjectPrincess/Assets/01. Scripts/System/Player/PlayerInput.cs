using Inputs;
using UnityEngine;
using UnityEngine.Events;

namespace Players
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] IngameInputSO input = null;

        [Space(15f)]
        [SerializeField] UnityEvent onStackingEvent = null;

        private void Awake()
        {
            InputManager.ChangeInputMap(InputMapType.Ingame);

            input.OnStackEvent += HandleStack;
        }

        private void OnDestroy()
        {
            input.OnStackEvent -= HandleStack;
        }

        private void HandleStack()
        {
            if(gameObject.activeInHierarchy == false)
                return;

            onStackingEvent?.Invoke();
        }
    }
}
