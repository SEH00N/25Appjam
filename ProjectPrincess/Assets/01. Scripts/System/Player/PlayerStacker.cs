using System.Collections.Generic;
using Stacks;
using UnityEngine;

namespace Players
{
    public class PlayerStacker : MonoBehaviour
    {
        [SerializeField] Transform queuePosition = null;
        [SerializeField] float offset = 1.25f;
        private Player player = null;

        private Stack<StackObject> stackObjects = null;
        private float queuePositionY = 0f;
        
        private void Awake()
        {
            player = GetComponent<Player>();
            queuePositionY = queuePosition.position.y;

            stackObjects = new Stack<StackObject>();
        }

        public void AddStackObject(StackObject stackObject)
        {
            stackObjects.Push(stackObject);

            stackObject.ChangeState(StackObjectState.Queue);
            stackObject.transform.position = GetQueuePosition(stackObjects.Count);
        }

        public void SetStack()
        {
            if(stackObjects.Count <= 0)
                return;

            StackObject instance = stackObjects.Pop();
            instance.ChangeState(StackObjectState.Stack);
            instance.transform.position = transform.position;
            transform.position += Vector3.up * offset;
        }

        public void ResetStack()
        {
            while(stackObjects.Count > 0)
            {
                StackObject instance = stackObjects.Pop();
                if(instance != null && instance.gameObject != null)
                    Destroy(instance?.gameObject);
            }
            stackObjects.Clear();
        }

        private Vector3 GetQueuePosition(int count)
        {
            Vector3 position = queuePosition.position;
            position.y = queuePositionY;
            position.x -= count * offset;

            return position;
        }
    }
}
