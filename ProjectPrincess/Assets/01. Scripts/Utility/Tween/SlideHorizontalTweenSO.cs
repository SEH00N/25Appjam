using DG.Tweening;
using UnityEngine;

namespace Tweens
{
    [CreateAssetMenu(menuName = "SO/Tween/SlideHorizontalTween")]
    public class SlideHorizontalTweenSO : TweenSO
    {
        [Space(15f)]
        [SerializeField] float endValue = 0f;

        protected override void OnTween(Sequence sequence)
        {
            TweenParam param;
            Tween tween;

            for (int i = 0; i < tweenParams.Count; ++i)
            {
                param = GetParam(i);
                tween = body.DOLocalMoveX(param.Value, param.Duration).SetDelay(param.Delay).SetEase(param.Ease);
                sequence.Append(tween);
            }
        }

        protected override void HandleTweenCompleted()
        {
            base.HandleTweenCompleted();
            body.localPosition = new Vector3(endValue, body.localPosition.y, body.localPosition.z);
        }
    }
}
