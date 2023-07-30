using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageGenerator : MonoBehaviour
{
    //Left Arm
    public Sprite leftThumb;
    public Sprite leftIndex;
    public Sprite leftMiddle;
    public Sprite leftRing;
    public Sprite leftPinky;
    public Sprite leftUpperArm;
    public Sprite leftElbow;
    public Sprite leftForearm;
    public Sprite leftShoulder;
    //Right Arm
    public Sprite rightThumb;
    public Sprite rightIndex;
    public Sprite rightMiddle;
    public Sprite rightRing;
    public Sprite rightPinky;
    public Sprite rightUpperArm;
    public Sprite rightElbow;
    public Sprite rightForearm;
    public Sprite rightShoulder;
    //Left Leg
    public Sprite leftToes;
    public Sprite leftThigh;
    public Sprite leftKnee;
    public Sprite leftBehindKnee;
    public Sprite leftCalf;
    public Sprite leftAnkle;
    //Right Leg
    public Sprite rightToes;
    public Sprite rightThigh;
    public Sprite rightKnee;
    public Sprite rightBehindKnee;
    public Sprite rightCalf;
    public Sprite rightAnkle;
    //Male Torso
    public Sprite maleChest;
    public Sprite maleStomach;
    public Sprite maleCrotch;
    //Male Back Torso
    public Sprite maleUpperBack;
    public Sprite maleLowerBack;
    //Female Torso
    public Sprite femaleChest;
    public Sprite femaleStomach;
    public Sprite femaleCrotch;
    //Female Back Torso
    public Sprite femaleUpperBack;
    public Sprite femaleLowerBack;
    //Front Head
    public Sprite eyes;
    public Sprite forehead;
    public Sprite ears;
    public Sprite nose;
    public Sprite mouth;
    public Sprite neck;
    //Back Head
    public Sprite backHeadTop;
    public Sprite backHeadBottom;
    public Sprite backNeck;

    public TMP_Text bodyPartText;

    public GameObject image;
    public GameObject sliderThingy;

    private void Start()
    {
        
    }
    //----------------Left Arm----------------------
    public void LeftThumb()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftThumb;
        bodyPartText.text = "Left Thumb";
    }
    public void LeftIndex()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftIndex;
        bodyPartText.text = "Left Index";
    }
    public void LeftMiddle()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftMiddle;
        bodyPartText.text = "Left Middle";
    }
    public void LeftRing()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftRing;
        bodyPartText.text = "Left Ring";
    }
    public void LeftPinky()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftPinky;
        bodyPartText.text = "Left Pinky";
    }
    public void LeftUpperArm()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftUpperArm;
        bodyPartText.text = "Left Upper Arm";
    }
    public void LeftElbow()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftElbow;
        bodyPartText.text = "Left Elbow";
    }
    public void LeftForearm()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftForearm;
        bodyPartText.text = "Left Forearm";
    }
    public void LeftShoulder()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftShoulder;
        bodyPartText.text = "Left Shoulder";
    }

    //----------------Right Arm----------------------

    //----------------Left Leg----------------------

    //----------------Right Leg----------------------

    //----------------Male Torso----------------------
    public void MaleChest()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = maleChest;
        bodyPartText.text = "Chest";
    }
    public void MaleStomach()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = maleStomach;
        bodyPartText.text = "Stomach";
    }
    public void MaleCrotch()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = maleCrotch;
        bodyPartText.text = "Hips";
    }
    //----------------Male Torso Back----------------------
    public void MaleUpperBack()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = maleUpperBack;
        bodyPartText.text = "Back";
    }
    public void MaleLowerBack()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = maleLowerBack;
        bodyPartText.text = "Back";
    }
    //----------------Female Torso----------------------
    public void FemaleChest()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = femaleChest;
        bodyPartText.text = "Chest";
    }
    public void FemaleStomach()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = femaleStomach;
        bodyPartText.text = "Stomach";
    }
    public void FemaleCrotch()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = femaleCrotch;
        bodyPartText.text = "Hips";
    }
    //----------------Female Torso Back----------------------
    public void FemaleUpperBack()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = femaleUpperBack;
        bodyPartText.text = "Back";
    }
    public void FemaleLowerBack()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = femaleLowerBack;
        bodyPartText.text = "Back";
    }

    //----------------Front Head----------------------
    public void Eyes()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = eyes;
        bodyPartText.text = "Eyes";
    }
    public void Forehead()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = forehead;
        bodyPartText.text = "Forehead";
    }
    public void Ears()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = ears;
        bodyPartText.text = "Ears";
    }
    public void Nose()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = nose;
        bodyPartText.text = "Nose";
    }
    public void Mouth()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = mouth;
        bodyPartText.text = "Mouth";
    }
    public void Neck()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = neck;
        bodyPartText.text = "Neck";
    }

    //----------------Back Head----------------------
    public void BackHeadTop()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = backHeadTop;
        bodyPartText.text = "Back Head";
    }
    public void BackHeadBottom()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = backHeadBottom;
        bodyPartText.text = "Back Head";
    }
    public void BackNeck()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = backNeck;
        bodyPartText.text = "Back Neck";
    }
}
