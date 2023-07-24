using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion : MonoBehaviour
{
    public Transform target;

    [SerializeField] bool activo;
    void Update()
    {
        if (activo)
        {
            Vector3 relativePos = target.position - transform.position;
            transform.rotation = Quaternion.LookRotation(relativePos);
        }
    }
}