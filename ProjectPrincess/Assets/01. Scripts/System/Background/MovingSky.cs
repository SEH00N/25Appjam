using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSky : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float parallaxEffect = 0.5f; 

    private float startPosX;
    private float length = 19f;

    void Start()
    {
        startPosX = transform.position.x; 
    }

    void Update()
    {
        float distanceX = (playerTransform.position.x - startPosX) * parallaxEffect; 
        transform.position = new Vector3(startPosX + distanceX, transform.position.y, transform.position.z);

        if (playerTransform.position.x > startPosX + length)
            startPosX += length;
        else if (playerTransform.position.x < startPosX - length)
            startPosX -= length;
    }
}