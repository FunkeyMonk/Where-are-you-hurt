using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public void LoadMaleBody()
    {
        SceneManager.LoadScene("Body Male");
    }

    public void LoadFemaleBody()
    {
        SceneManager.LoadScene("Body Female");
    }

    public void GoBackMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadFrontRightArm()
    {
        SceneManager.LoadScene("Front Right Arm");
    }

    public void LoadFrontLeftArm()
    {
        SceneManager.LoadScene("Front Left Arm");
    }
}
