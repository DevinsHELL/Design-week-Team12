using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void ContinueButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }

    public void StartButton()
    {
        SceneManager.LoadScene("InstructionScreen");
    }
}