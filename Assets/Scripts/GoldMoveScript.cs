using UnityEngine;

public class GoldMoveScript : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        transform.position = transform.position +
        (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}