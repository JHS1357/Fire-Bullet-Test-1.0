using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    public float speed = 1000.0f;

    private Rigidbody rd;

    private void Awake()
    {
        rd = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        rd.AddForce(transform.forward * speed);
    }
}
