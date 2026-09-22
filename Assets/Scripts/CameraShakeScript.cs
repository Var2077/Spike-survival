using UnityEngine;
using System.Collections;

public class CameraShakeScript : MonoBehaviour
{
    public float shakeDuration = 0.2f;
    public float shakeMagnitude = 0.15f;

    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.localPosition;
    }

    public void Shake()
    {
        StartCoroutine(ShakeCamera());
    }

    IEnumerator ShakeCamera()
    {
        float elapsed = 0f;

        while (elapsed < shakeDuration)
        {
            float x = Random.Range(-1f, 1f) * shakeMagnitude;
            float y = Random.Range(-1f, 1f) * shakeMagnitude;

            transform.localPosition = originalPosition + new Vector3(x, y, 0);

            elapsed += Time.unscaledDeltaTime;

            yield return null;
        }

        transform.localPosition = originalPosition;
    }
}