using Players;
using UnityEngine;

namespace Stacks
{
    public class StackObjectCollision : MonoBehaviour
    {
        [SerializeField] LayerMask playerLayer = 0;
        private StackObject stackObject = null;


        private Collider col = null;
        private Rigidbody rb = null;
        
        private void Awake()
        {
            stackObject = GetComponent<StackObject>();
            rb = GetComponent<Rigidbody>();
            col = GetComponent<Collider>();

            stackObject.OnStateChangedEvent += HandleStackObjectChanged;
        }

        private void OnTriggerEnter(Collider other) // 플레이어 감지용
        {
            int otherLayer = 1 << other.gameObject.layer;
            if((otherLayer & playerLayer) == 0)
                return;

            if(other.TryGetComponent<Player>(out Player player))
                player.AddStackObject(stackObject);
        }

        public void HandleStackObjectChanged(StackObjectState state)
        {
            if(state == StackObjectState.Queue)
                rb.useGravity = true;
            else if(state == StackObjectState.Stack)
                col.isTrigger = false;
        }
    }
}
