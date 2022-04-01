using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI ScoreUI;
    public static int TotalScore;
    
    // Start is called before the first frame update
    void Start()
    {
        TotalScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreUI.text = TotalScore.ToString();
    }
}
