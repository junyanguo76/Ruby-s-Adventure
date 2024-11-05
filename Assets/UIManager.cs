using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Image HealthBar;
    float length;
    public static UIManager Instance;

    public void Awake()
    {
         Instance = this;
    }
    private void Start()
    {
        length = HealthBar.rectTransform.rect.width;
    }

    public void ShowHealth(float value)
    {
        HealthBar.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, value * length);    }

}
