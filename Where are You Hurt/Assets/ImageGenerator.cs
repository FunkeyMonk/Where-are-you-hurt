using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageGenerator : MonoBehaviour
{
    //Front Head
    public Sprite eyes;
    public Sprite forehead;
    public Sprite ears;
    public Sprite nose;
    public Sprite mouth;
    public Sprite neck;

    public TMP_Text bodyPartText;

    public GameObject image;
    public GameObject sliderThingy;

    private void Start()
    {
        
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

}
