using Utility;
using UnityEngine;

namespace Tweens
{
    [System.Serializable]
    public class TweenOptOption : OptOption<TweenSO>
    {
        public void Init(Transform body)
        {
            PositiveOption = PositiveOption?.CreateInstance(body);
            NegativeOption = NegativeOption?.CreateInstance(body);
        }

        public void PlayPositiveTween()
        {
            PositiveOption?.PlayTween();
        }

        public void PlayNegativeTween()
        {
            NegativeOption?.PlayTween();
        }
    }
}
