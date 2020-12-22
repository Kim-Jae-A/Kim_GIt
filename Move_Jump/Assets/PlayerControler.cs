using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private MovingPlayer movement2D;

    private void Awake()
    {
        movement2D = GetComponent<MovingPlayer>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        movement2D.Move(x);
    }
}
