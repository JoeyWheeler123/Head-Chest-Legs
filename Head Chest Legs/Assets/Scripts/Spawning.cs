using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject char1;
    public GameObject char2;
    public GameObject char3;
    public GameObject char4;

    public Transform player1;
    public Transform player2;

    int savedPlayer1;
    int savedPlayer2;

    //int character;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {
        savedPlayer1 = PlayerPrefs.GetInt("SelectedPlayer1");
        savedPlayer2 = PlayerPrefs.GetInt("SelectedPlayer2");

        if(savedPlayer1 == 0)
        {
            Instantiate(char1, player1);
        }
        else if (savedPlayer1 == 1)
        {
            Instantiate(char2, player1);
        }
        else if (savedPlayer1 == 2)
        {
            Instantiate(char3, player1);
        }
        else if (savedPlayer1 == 3)
        {
            Instantiate(char4, player1);
        }

        if (savedPlayer2 == 0)
        {
            Instantiate(char1, player2);
        }
        else if (savedPlayer2 == 1)
        {
            Instantiate(char2, player2);
        }
        else if (savedPlayer2 == 2)
        {
            Instantiate(char3, player2);
        }
        else if (savedPlayer2 == 3)
        {
            Instantiate(char4, player2);
        }
    }
}
