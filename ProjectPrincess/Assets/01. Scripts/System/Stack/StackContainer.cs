using UnityEngine;

namespace Stacks
{
    public class StackContainer : MonoBehaviour
    {
        [SerializeField] Transform defaultPosition = null;
        private StackObject currentObject = null;
        private StackObject lastObject = null;

        private float yOffset = 0f;

        private void Awake()
        {
            yOffset = defaultPosition.position.y;
        }

        public void Enqueue(StackObject stack)
        {
            if(currentObject == null)
            {
                currentObject = stack;
                lastObject = currentObject;

                Vector3 position = defaultPosition.position;
                position.y = yOffset;
                lastObject.SetPosition(position);
            }
            else
            {
                lastObject.SetChild(stack, yOffset);
                lastObject = stack;
            }
        }

        public StackObject Dequeue()
        {
            if(currentObject == null)
                return null;
            
            StackObject value = currentObject;
            currentObject = currentObject.Child;
            currentObject?.PushPosition(defaultPosition, yOffset);

            return value;
        }
    }
}
