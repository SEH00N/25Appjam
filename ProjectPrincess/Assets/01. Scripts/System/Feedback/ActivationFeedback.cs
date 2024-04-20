using Extensions;
using UnityEngine;

namespace Feedbacks
{
    public class ActivationFeedback : Feedback
    {
        [SerializeField] GameObject targetObject = null;
        [SerializeField] bool activation = false;
        [SerializeField] float turnOffTime = 1f;

        public override void Play(Transform playTrm)
        {
            StopAllCoroutines();

            targetObject.SetActive(activation);
            if(turnOffTime != 0f)
                StartCoroutine(this.DelayCoroutine(turnOffTime, () => targetObject.SetActive(!activation)));
        }
    }
}
