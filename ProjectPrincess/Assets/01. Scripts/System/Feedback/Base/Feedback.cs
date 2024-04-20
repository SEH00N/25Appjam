using UnityEngine;

namespace Feedbacks
{
    public abstract class Feedback : MonoBehaviour
    {
        public abstract void Play(Transform playTrm);
    }
}
