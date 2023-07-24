using UnityEngine;
public class imputcontrol : MonoBehaviour
{
    public Vector2 move() 
    {
        float x  = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        return new Vector2(x, y);
    }
}