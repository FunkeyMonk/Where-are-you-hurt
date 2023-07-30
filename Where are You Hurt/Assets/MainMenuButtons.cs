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
            binaryGender = 0;
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
    public void FrontRightArm()
    {
        SceneManager.LoadScene("Front Right Arm");
    }
    public void FrontLeftArm()
    {
        SceneManager.LoadScene("Front Left Arm");
    }
    public void BackLeftArm()
    {
        SceneManager.LoadScene("Back Left Arm");
    }
    public void BackRightArm()
    {
        SceneManager.LoadScene("Back Right Arm");
    }

    //Front and Back Legs
    public void FrontRightLeg()
    {
        SceneManager.LoadScene("Front Right Leg");
    }
    public void FrontLeftLeg()
    {
        SceneManager.LoadScene("Front Left Leg");
    }
    public void BackLeftLeg()
    {
        SceneManager.LoadScene("Back Left Leg");
    }
    public void BackRightLeg()
    {
        SceneManager.LoadScene("Back Right Leg");
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
    public void FemaleTorso()
    {
        SceneManager.LoadScene("Female Torso");
    }
    public void MaleTorso()
    {
        SceneManager.LoadScene("Male Torso");
    }
    public void BackSpine()
    {
        SceneManager.LoadScene("Back Spine");
    }
}
