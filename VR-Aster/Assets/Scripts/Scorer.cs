using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int Score;
    public GameObject WinPanel;

    public void AddScore(int Increment)
    {
        Score += Increment;
    }
    public void Win()
    {
        WinPanel.gameObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag== "EndGoal")
        {
            Win();
        }
    }
}
