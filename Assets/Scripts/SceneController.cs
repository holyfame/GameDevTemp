using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public const int gridRows = 2;
    public const int gridCols = 4;
    public const float offsetX = 4f;
    public const float offsetY = 5f;

    [SerializeField] private Player[] players;

    private int _score = 0;
   // [SerializeField] private TextMesh scoreLabel;

    public void Restart()
    {
        // SceneManager.LoadScene("SampleScene");
        _score++;
        //scoreLabel.text = "Score: " + _score;
        players[0].scoreLabel.text = "Score: " + _score;
    }
}
