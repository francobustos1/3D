using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cambiarnivel : MonoBehaviour
{
    public void cambiar(string nivel)
    {
        SceneManager.LoadScene(nivel);
    }
}
