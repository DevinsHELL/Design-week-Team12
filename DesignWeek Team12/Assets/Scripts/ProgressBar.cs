using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider; // Reference to the slider
    public float duration = 10f; // Duration in seconds for the slider to fill

    private float timeElapsed = 0f; // Time elapsed since the start

    void Update()
    {
        if (slider != null)
        {
            timeElapsed += Time.deltaTime; // Increment the time elapsed
            slider.value = Mathf.Clamp01(timeElapsed / duration); // Update the slider value
            if(timeElapsed > duration)
            {
                SceneManager.LoadScene("EndScreen");
            }
        }
    }
}
