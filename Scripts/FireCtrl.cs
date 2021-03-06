using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    private GameObject bulletPrefab;
    private Transform firePos;

    private void Awake()
    {
        bulletPrefab = Resources.Load<GameObject>("Prefabs/Bullet");

        Transform[] childran = GetComponentsInChildren<Transform>();

        foreach(Transform child in childran)
        {
            if (child.name == "FirePos")
                firePos = child;
        }
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
    private void Fire()
    {
        Instantiate(bulletPrefab, firePos.position, firePos.rotation);
    }
}
