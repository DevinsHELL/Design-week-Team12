using UnityEngine;

public class Slow : MonoBehaviour
{
    public float slowMultiplier = 0.5f; // Reduces speed by 50%
    private float originalSpeed;
    private bool isSlowed = false;

    private void OnTriggerEnter(Collider other)
    {
        Cow_movement player = other.GetComponent<Cow_movement>();
        if (player != null && !isSlowed)
        {
            originalSpeed = player.moveSpeedR;
            player.moveSpeedR *= slowMultiplier;
            isSlowed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Cow_movement player = other.GetComponent<Cow_movement>();
        if (player != null && isSlowed)
        {
            player.moveSpeedR = originalSpeed;
            isSlowed = false;
        }
    }
}

