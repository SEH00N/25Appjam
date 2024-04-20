using Tweens;
using UnityEngine;
using UnityEngine.Events;
using Utility;

namespace UI
{
    public class UIPanel : MonoBehaviour
    {
        [SerializeField] OptOption<UnityEvent> onDisplayEvent = null;
        [SerializeField] TweenOptOption tweenOption = null;

        private void Awake()
        {
            tweenOption.Init(transform);
        }

        public void Display(bool active)
        {
            onDisplayEvent.GetOption(active)?.Invoke();
            tweenOption.GetOption(active)?.PlayTween();
        }
    }
}
