using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    TMP_Text myText;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        myText.text = "Score: " + GameData.Score;
    }
}
