using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageGenerator : MonoBehaviour
{
    public Sprite eyes; // I attched these from editor
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

    /*
    public int imgNumberCount;


    public void changeImages() // make sure to attach this to event trigger
    {
        switch (imgNumberCount)
        {

            case 0:
                GetComponent<Image>().sprite = eyes;
                imgNumberCount++; //increase count so it gets higher and switches to different sprite
                break;
            case 1:
                GetComponent<Image>().sprite = forehead;
                imgNumberCount++;
                break;
            case 2:
                GetComponent<Image>().sprite = ears;
                imgNumberCount++;
                imgNumberCount = 0; //Reset it to 0
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }
    */

}
