using UnityEngine;

namespace Stacks
{
    public class StackContainer : MonoBehaviour
    {
        [SerializeField] Transform defaultPosition = null;
        private StackObject currentObject = null;
        private StackObject lastObject = null;

        public void Enqueue(StackObject stack)
        {
            if(lastObject == null)
            {
                currentObject = stack;
                lastObject = currentObject;
                lastObject.Init(defaultPosition.position);
            }
            else
            {
                lastObject.SetChild(stack);
                lastObject = stack;
            }
        }

        public StackObject Dequeue()
        {
            if(currentObject == null)
                return null;
            
            StackObject value = currentObject;
            currentObject = currentObject.Child;

            return value;
        }
    }
}
