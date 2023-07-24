using UnityEngine;
[RequireComponent(typeof(imputcontrol))]
public class personaje : MonoBehaviour
{
    [SerializeField] float _speed = 0f;
    [SerializeField] float _rotation = 0f;
    imputcontrol control = null;

     void Awake()
    {
        control = GetComponent<imputcontrol>();
    }
    void Update()
    {
        andar();
    }
   void andar()
   {
        Vector2 input = control.move();
        transform.position += transform.forward * input.y * _speed * Time.deltaTime;
        transform.Rotate(Vector3.up * input.x * _rotation * Time.deltaTime);
    }
}