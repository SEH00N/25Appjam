using Stacks;
using UnityEngine;
using Utility;

namespace Players
{
    public class Player : MonoBehaviour
    {
        [SerializeField] Transform playerPosition = null;
        private BasicMovement movement = null;

        private PlayerStacker stacker = null;

        private void Awake()
        {
            movement = GetComponent<BasicMovement>();
            stacker = GetComponent<PlayerStacker>();
        }

        public void ResetPlayer()
        {
            movement.SetActive(false);

            transform.position = playerPosition.position;
            gameObject.SetActive(true);
        }

        public void AddStackObject(StackObject stackObject)
        {
            stacker.AddStackObject(stackObject);
        }
    }
}
