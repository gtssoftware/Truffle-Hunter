using UnityEngine;

public class Mover : MonoBehaviour
{
    float moveAmount = 0.01f;

    public void Move()
    {
        transform.position += new Vector3(moveAmount, 0, 0);
    }
}