using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NonePlayerCharacter : MonoBehaviour
{

    public float displayTime = 4.0f;
    public GameObject dialogBox;
    float timerDisplay;

    public GameObject dlgTextproGameObject;
    public TextMeshProUGUI textBox;
    int _currentPage = 0;
    int _totalPages;
    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(false);
        timerDisplay = -1.0f;
        textBox = dlgTextproGameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _totalPages = textBox.textInfo.pageCount;
        if(timerDisplay >= 0)
        {
            if(Input.GetKeyUp(KeyCode.Space))
            {
                if(_currentPage < _totalPages)
                {
                    _currentPage++;
                }
                else
                {
                    _currentPage = 1;
                }
                textBox.pageToDisplay= _currentPage;
            }


            timerDisplay -= Time.deltaTime;

        }
        else
        {
            dialogBox.SetActive(false);
        }
    }

    public void DisplayDialog()
    {
        timerDisplay = displayTime;
        dialogBox.SetActive(true);
    }
}
