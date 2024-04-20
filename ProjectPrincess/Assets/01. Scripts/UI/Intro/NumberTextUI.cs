using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace UI
{
    public class NumberTextUI : MonoBehaviour
    {
        [SerializeField] TMP_Text text = null;
        [SerializeField] string format = "";

        [Space(15f)]
        [SerializeField] UnityEvent<int> onTextChangedEvent = null;

        public void SetText(int number)
        {
            if(string.IsNullOrEmpty(format))
                text.text = number.ToString();
            else
                text.text = string.Format(format, number);

            onTextChangedEvent.Invoke(number);
        }
    }
}
