using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageGenerator : MonoBehaviour
{
    public Sprite eyes;
    public Sprite forehead;
    public Sprite ears;

    public TMP_Text bodyPartText;

    public GameObject image;

    private void Start()
    {
        
    }
    public void Eyes()
    {
        image.GetComponent<Image>().sprite = eyes;
        bodyPartText.text = "Eyes";
    }

}
