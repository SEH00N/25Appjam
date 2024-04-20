using DG.Tweening;

namespace Tweens
{
    [System.Serializable]
    public struct TweenParam
    {
        public string Caption;
        public float Delay;
        public float Duration;
        public float Value;
        public Ease Ease;
    }
}