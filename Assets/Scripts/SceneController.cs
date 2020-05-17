using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private Player church;
    [SerializeField] private Player army;
    [SerializeField] private Player science;
    [SerializeField] private Player rich;

    private int church_score = 0;
    private int army_score = 0;
    private int science_score = 0;
    private int rich_score = 0;

    public void Pass(int d_church, int d_army, int d_science, int d_rich)
    {
        UnityEngine.Debug.Log("pass!");

        church_score += d_church;
        church.scoreLabel.text = "Score: " + church_score;

        army_score += d_army;
        army.scoreLabel.text = "Score: " + army_score;

        science_score += d_science;
        science.scoreLabel.text = "Score: " + science_score;

        rich_score += d_rich;
        rich.scoreLabel.text = "Score: " + rich_score;
    }
}
