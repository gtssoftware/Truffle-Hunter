using UnityEngine;

public class SingleInputCheck : MonoBehaviour
{
    Mover mover;

    void Start()
    {
        mover = GetComponent<Mover>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            PerformAction();
        }
    }

    void PerformAction()
    {
        mover.Move();
    }
}