using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSky : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 0.1f;

    [SerializeField] private Transform player;
    [SerializeField] private Transform parent;

    private Renderer renderer;
    private Material material;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        material = renderer.material;
    }

    private void Update()
    {
        Vector3 newPosition = parent.position;
        newPosition.x = player.position.x;
        parent.position = newPosition;

        float offsetX = Time.time * scrollSpeed;
        Vector2 offset = new Vector2(offsetX, 0);
        material.mainTextureOffset = offset;
    }
}
