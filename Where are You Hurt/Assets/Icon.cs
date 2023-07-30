using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Icon : MonoBehaviour
{
    public Slider slider;
    public TMP_Text Pain;
    public TMP_Text bodyPart;
    public string painLevel;
    private void Start()
    {
        //Pain = FindObjectOfType<TextMeshProUGUI>();
    }
    public void Confirm()
    {
        Pain.text = slider.value.ToString();
    }
}