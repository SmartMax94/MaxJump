using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class LevelNumberText : MonoBehaviour
{
    public Text Text;
    public Game Game;


    private void Start()
    {
        Text.text = "Level " + (Game.LevelIndex + 1).ToString();
    }
          
    }

