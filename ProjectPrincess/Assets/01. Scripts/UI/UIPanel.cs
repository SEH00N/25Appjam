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

        protected virtual void Awake()
        {
            tweenOption.Init(transform);
        }

        public virtual void Display(bool active)
        {
            onDisplayEvent.GetOption(active)?.Invoke();
            tweenOption.GetOption(active)?.PlayTween();
        }
    }
}
