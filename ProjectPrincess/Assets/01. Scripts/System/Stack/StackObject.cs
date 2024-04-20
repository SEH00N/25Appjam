using UnityEngine;

namespace Stacks
{
    public class StackObject : MonoBehaviour
    {
        [SerializeField] Transform childContainer = null;

        private StackObject child = null;
        public StackObject Child => child;

        public void SetChild(StackObject child)
        {
            child.Init(childContainer.position);
            this.child = child;
        }

        public void Init(Vector3 position)
        {
            transform.position = position;
        }
    }
}
