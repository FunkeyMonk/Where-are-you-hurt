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
}
