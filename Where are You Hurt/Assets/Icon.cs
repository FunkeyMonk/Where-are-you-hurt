using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Icon : MonoBehaviour
{
    public Slider slider;
    public TMP_Text pain;
    public TMP_Text bodyPart;
    public string painLevel;
    private void Start()
    {
        pain = FindObjectOfType<TextMeshProUGUI>();
    }
    public void Confirm()
    {
        pain.text = slider.value.ToString();
    }
}