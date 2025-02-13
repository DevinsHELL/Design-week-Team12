using System.Collections;
using UnityEngine;

public class SkyMover : MonoBehaviour
{
    public float duration = 60f; // Duration for the movement
    public float startY = -5.26f; // Starting y-position
    public float endY = 19f; // Ending y-position

    private void Start()
    {
        StartCoroutine(MoveUpCoroutine());
    }

    private IEnumerator MoveUpCoroutine()
    {
        Vector3 startPosition = new Vector3(transform.position.x, startY, transform.position.z);
        Vector3 endPosition = new Vector3(transform.position.x, endY, transform.position.z);

        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null; // Wait for the next frame
        }

        // Ensure the final position is set exactly to the end position
        transform.position = endPosition;
    }
}
