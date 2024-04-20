using UnityEngine;

namespace Utility
{
    public class BasicMovement : MonoBehaviour
    {
        [SerializeField] Vector3 direction = Vector3.right;
        [SerializeField] Transform body = null;

        [Space(15f)]
        [SerializeField] bool active = true;

        private void Awake()
        {
            if(body == null)
                body = transform;
        }

        private void FixedUpdate()
        {
            if(active == false)
                return;

            body.transform.position += direction * Time.fixedDeltaTime;
        }   

        public void SetActive(bool active)
        {
            this.active = active;
        }
    }
}
