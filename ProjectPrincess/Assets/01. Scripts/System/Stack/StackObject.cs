using UnityEngine;
using Utility;

namespace Stacks
{
    public class StackObject : MonoBehaviour
    {
        [SerializeField] Transform childContainer = null;

        private BasicMovement movement = null;

        private StackObject child = null;
        public StackObject Child => child;
        
        private void Awake()
        {
            movement = GetComponent<BasicMovement>();
        }

        public void SetChild(StackObject child)
        {
            child.SetPosition(childContainer.position);
            this.child = child;
        }

        public void SetPosition(Vector3 position)
        {
            transform.position = position;
            movement.SetActive(true);
        }

        public void PushPosition(Transform target)
        {
            transform.position = target.position;
            child?.PushPosition(childContainer);
        }
    }
}
