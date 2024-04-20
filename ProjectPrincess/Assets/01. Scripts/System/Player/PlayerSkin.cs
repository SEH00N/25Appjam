using Skins;
using UnityEngine;
using UnityEngine.Events;

namespace Players
{
    public class PlayerSkin : MonoBehaviour
    {
        [SerializeField] SkinListSO skinList = null;
        [SerializeField] UnityEvent onSkinChangedEvent = null;

        private Transform visualContainer = null;

        private void Awake()
        {
            visualContainer = transform.Find("Visual");
        }

        private void Start()
        {
            UpdateSkin(0);
        }

        public void UpdateSkin(int index)
        {
            Debug.Log(index);
            ClearVisual();

            GameObject skinInstance = Instantiate(skinList[index].Visual, visualContainer);
            skinInstance.transform.localPosition = Vector3.zero;
            skinInstance.transform.localRotation = Quaternion.identity;

            onSkinChangedEvent?.Invoke();
        }

        private void ClearVisual()
        {
            GameObject visual = visualContainer.GetChild(0)?.gameObject;
            if(visual != null)
                Destroy(visual);
        }
    }
}
