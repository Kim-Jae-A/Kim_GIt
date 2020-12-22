using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private float moveSpeed = 7.0f;
    private Vector3 moveDirection;

    public void Setup(Vector3 direction)
    {
        moveDirection = direction;
    }

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}