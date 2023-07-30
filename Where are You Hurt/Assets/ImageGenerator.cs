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
        bodyPartText.text = "Thumb";
    }
    public void LeftIndex()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftIndex;
        bodyPartText.text = "Index";
    }
    public void LeftMiddle()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftMiddle;
        bodyPartText.text = "Middle";
    }
    public void LeftRing()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftRing;
        bodyPartText.text = "Ring";
    }
    public void LeftPinky()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftPinky;
        bodyPartText.text = "Pinky";
    }
    public void LeftUpperArm()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftUpperArm;
        bodyPartText.text = "Upper Arm";
    }
    public void LeftElbow()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftElbow;
        bodyPartText.text = "Elbow";
    }
    public void LeftForearm()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftForearm;
        bodyPartText.text = "Forearm";
    }
    public void LeftShoulder()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftShoulder;
        bodyPartText.text = "Shoulder";
    }

    //----------------Right Arm----------------------
    public void RightThumb()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = rightThumb;
        bodyPartText.text = "Thumb";
    }
    public void RightIndex()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = rightIndex;
        bodyPartText.text = "Index";
    }
    public void RightMiddle()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = rightMiddle;
        bodyPartText.text = "Middle";
    }
    public void RightRing()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = rightRing;
        bodyPartText.text = "Ring";
    }
    public void RightPinky()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = rightPinky;
        bodyPartText.text = "Pinky";
    }
    public void RightUpperArm()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = rightUpperArm;
        bodyPartText.text = "Upper Arm";
    }
    public void RightElbow()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = rightElbow;
        bodyPartText.text = "Elbow";
    }
    public void RightForearm()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = rightForearm;
        bodyPartText.text = "Forearm";
    }
    public void RightShoulder()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = rightShoulder;
        bodyPartText.text = "Shoulder";
    }
    //----------------Left Leg----------------------
    public void LeftThigh()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftThigh;
        bodyPartText.text = "Thigh";
    }
    public void LeftKnee()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftKnee;
        bodyPartText.text = "Knee";
    }
    public void LeftBehindKnee()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftBehindKnee;
        bodyPartText.text = "Knee";
    }
    public void LeftCalf()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftCalf;
        bodyPartText.text = "Calf";
    }
    public void LeftAnkle()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftAnkle;
        bodyPartText.text = "Ankle";
    }
    public void LeftToes()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = leftToes;
        bodyPartText.text = "Toes";
    }
    //----------------Right Leg----------------------
    public void RightThigh()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = rightThigh;
        bodyPartText.text = "Thigh";
    }
    public void RightKnee()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = rightKnee;
        bodyPartText.text = "Knee";
    }
    public void RightBehindKnee()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = rightBehindKnee;
        bodyPartText.text = "Knee";
    }
    public void RightCalf()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = rightCalf;
        bodyPartText.text = "Calf";
    }
    public void RightAnkle()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = rightAnkle;
        bodyPartText.text = "Ankle";
    }
    public void RightToes()
    {
        sliderThingy.SetActive(true);
        image.GetComponent<Image>().sprite = rightToes;
        bodyPartText.text = "Toes";
    }
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
