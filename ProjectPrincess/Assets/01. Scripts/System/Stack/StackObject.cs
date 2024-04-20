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
            child.Init(childContainer.position);
            this.child = child;
        }

        public void Init(Vector3 position)
        {
            transform.position = position;
            movement.SetActive(true);
        }
    }
}
