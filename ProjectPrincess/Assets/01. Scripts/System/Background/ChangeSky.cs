using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeSky : MonoBehaviour
{
    [SerializeField] private int matNum = 1;
    [SerializeField] private float fadeSpeed = 0.5f;
    [SerializeField] private float changeSpeed = 10f;
    
    private float currentSpeed = 10f;

    [SerializeField] private Material[] skyMat;
    [SerializeField] private GameObject cloudObject;

    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (currentSpeed > 0)
        {
            currentSpeed -= Time.deltaTime;
            if (currentSpeed <= 0)
            {
                StartCoroutine(SkyChange());
                currentSpeed = changeSpeed;
            }
        }
    }

    public IEnumerator SkyChange()
    {
        renderer.material.DOColor(Color.black, fadeSpeed);
        cloudObject.SetActive(false);
        yield return new WaitForSeconds(fadeSpeed);

        renderer.material = skyMat[matNum];

        renderer.material.DOColor(Color.white, fadeSpeed);
        yield return new WaitForSeconds(fadeSpeed - 1f);
        cloudObject.SetActive(true);

        matNum++;
        if (matNum == skyMat.Length)
            matNum = 0;

        // changeSpeed �ʱ�ȭ
        changeSpeed = 10f;
    }
}
