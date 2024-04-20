using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MapObj{
    public class DownFallObj : MonoBehaviour
    {
        [SerializeField] Transform target;

        [SerializeField] private float activeDistance;

        private Rigidbody rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if (Vector3.Distance(transform.position, target.position) < activeDistance)
            {
                rb.useGravity = true;
            }
        }
    }
}
