using Stacks;
using UnityEngine;

namespace Players
{
    public class PlayerStacker : MonoBehaviour
    {
        [SerializeField] Transform stackPosition = null;
        [SerializeField] float offset = 10f;
    
        private StackContainer stackContainer = null;

        private void Awake()
        {
            stackContainer = GetComponent<StackContainer>();
        }

        public void AddStackObject(StackObject stack)
        {
            stackContainer.Enqueue(stack);
            
        }

        public void Stack()
        {
            StackObject instance = stackContainer.Dequeue();
            if(instance == null)
                return;

            transform.position += Vector3.up * offset;
            instance.Stack(stackPosition.position);
        }
    }
}
