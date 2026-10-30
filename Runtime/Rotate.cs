using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float Speed = -20f;
    void Update() =>
        transform.Rotate(Speed * Time.deltaTime,0 , 0);
}