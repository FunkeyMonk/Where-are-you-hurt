using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenuButtons : MonoBehaviour
{
    static int binaryGender = 0;
    static Icon icon;
    static GetSliderInput sliderInput;
    public TMP_Text pain;

    private void Start()
    {
        
    }
    public void LoadMaleBody()
    {
        SceneManager.LoadScene("Body Male");
        binaryGender = 1;
    }

    public void LoadFemaleBody()
    {
        SceneManager.LoadScene("Body Female");
        binaryGender = 0;
    }

    public void GoBackMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void GoBackBody()
    {
        if (binaryGender == 0)
        {
            SceneManager.LoadScene("Body Female");
        }
        if (binaryGender == 1)
        {
            SceneManager.LoadScene("Body Male");
        }
    }
    /*
    public void Confirm()
    {
        pain.text = "2";
        SceneManager.LoadScene("Body Female");
    }
    */

    //Front and Back Arms
    public void RightArm()
    {
        SceneManager.LoadScene("Right Arm");
    }
    public void LeftArm()
    {
        SceneManager.LoadScene("Left Arm");
    }

    //Front and Back Legs
    public void RightLeg()
    {
        SceneManager.LoadScene("Right Leg");
    }
    public void LeftLeg()
    {
        SceneManager.LoadScene("Left Leg");
    }

    //Others
    public void FrontHead()
    {
        SceneManager.LoadScene("Front Head");
    }
    public void BackHead()
    {
        SceneManager.LoadScene("Back Head");
    }
    public void FemaleFrontTorso()
    {
        SceneManager.LoadScene("Female Front Torso");
    }
    public void FemaleBackTorso()
    {
        SceneManager.LoadScene("Female Back Torso");
    }
    public void MaleFrontTorso()
    {
        SceneManager.LoadScene("Male Front Torso");
    }
    public void MaleBackTorso()
    {
        SceneManager.LoadScene("Male Back Torso");
    }
}
