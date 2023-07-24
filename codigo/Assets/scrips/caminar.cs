using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caminar : MonoBehaviour
{
    [SerializeField] AudioSource mover;
    void Start()
    {
        if (Input.GetButtonDown("Vertical"))
        {
            mover.Play();

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Vertical"))
        {
            mover.Play();

        }
        if (Input.GetButtonUp("Vertical"))
        {
            mover.Pause();
        }
    }
}
