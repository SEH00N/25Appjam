using UnityEngine;
using UnityEngine.Events;
using Utility;

namespace Stacks
{
    public class StackObject : MonoBehaviour
    {
        [SerializeField] Transform childContainer = null;
        [SerializeField] UnityEvent onStackEvent = null;

        private BasicMovement movement = null;

        private StackObject child = null;
        public StackObject Child => child;
        
        private void Awake()
        {
            movement = GetComponent<BasicMovement>();
        }

        public void SetChild(StackObject child, float yOffset)
        {
            Vector3 position = childContainer.position;
            position.y = yOffset;
            child.SetPosition(position);
            this.child = child;
        }

        public void SetPosition(Vector3 position)
        {
            transform.position = position;
            movement.SetActive(true);
        }

        public void PushPosition(Transform target, float yOffset)
        {
            Vector3 position = target.position;
            position.y = yOffset;
            transform.position = position;

            child?.PushPosition(childContainer, yOffset);
        }

        public void Stack(Vector3 position)
        {
            SetPosition(position);
            onStackEvent?.Invoke();
        }
    }
}
