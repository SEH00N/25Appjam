using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeSky : MonoBehaviour
{
    [SerializeField] private int matNum = 1;
    
    [SerializeField] private Material[] skyMat;
    [SerializeField] private GameObject cloudObject;

    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(SkyChange());
        }
    }

    public IEnumerator SkyChange()
    {
        renderer.material.DOColor(Color.black, 0.5f);
        cloudObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);

        renderer.material = skyMat[matNum];

        renderer.material.DOColor(Color.white, 0.5f);   
        yield return new WaitForSeconds(0.4f);
        cloudObject.SetActive(true);

        matNum++;
        if (matNum == skyMat.Length)
            matNum = 0;
    }
}
