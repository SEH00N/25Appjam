using UnityEngine;
using Utility;

namespace Players
{
    public class Player : MonoBehaviour
    {
        [SerializeField] Transform playerPosition = null;
        private BasicMovement movement = null;

        private void Awake()
        {
            movement = GetComponent<BasicMovement>();
        }

        public void ResetPlayer()
        {
            movement.SetActive(false);

            transform.position = playerPosition.position;
            gameObject.SetActive(true);
        }   
    }
}
