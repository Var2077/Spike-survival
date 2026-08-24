using UnityEngine;

public class GoldMoveScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float deadZone = -15f;

    private void Update ()
    {
        transform.position = transform.position +
            (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy (gameObject);
        }
    }
}