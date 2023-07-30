using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnSlider : MonoBehaviour
{
    public GameObject slider;
    public GameObject mainButtons;

    public void spawnSlider()
    {
        slider.SetActive(true);
    }
}
