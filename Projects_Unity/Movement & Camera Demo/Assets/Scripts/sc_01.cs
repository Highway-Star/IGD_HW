using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sc_01 : MonoBehaviour
{
    public TMP_Text text;
    string tempText;
    [SerializeField]
    string originalText;
    // Start is called before the first frame update
    void Start()
    {
        text.text = originalText;
        //text.text = tempText;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            tempText = "Left";
            text.text = tempText;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            tempText = "Right";
            text.text = tempText;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            text.text = originalText;
        }
    }
}
