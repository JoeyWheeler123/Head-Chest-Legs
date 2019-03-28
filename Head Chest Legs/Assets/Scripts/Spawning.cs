using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject skarab;
    public GameObject skivvy;
    public GameObject alien;
    public GameObject skarab2;
    public GameObject skivvy2;
    public GameObject alien2;

    public GameObject skarabHP;
    public GameObject skivvyHP;
    public GameObject alienHP;
    public GameObject skarab2HP;
    public GameObject skivvy2HP;
    public GameObject alien2HP;

    GameObject p1;
    GameObject p2;

    public Transform player1;
    public Transform player2;

    //public int savedPlayer1;
    //public int savedPlayer2;

    //int character;

    // Start is called before the first frame update
    void Start()
    {
        print(PlayerPrefs.GetInt("CharacterSelected1"));
        print(PlayerPrefs.GetInt("CharacterSelected2"));
        int savedPlayer1 = PlayerPrefs.GetInt("CharacterSelected1");
        int savedPlayer2 = PlayerPrefs.GetInt("CharacterSelected2");
        Debug.Log(savedPlayer1);
        Debug.Log(savedPlayer2);

        if (savedPlayer1 == 0)
        {
            p1 = Instantiate(skarab, player1);
            p1.tag = "Player 1";
            p1.SetActive(true);
            skarabHP.SetActive(true);
        }
        else if (savedPlayer1 == 1)
        {
            p1 = Instantiate(skivvy, player1);
            p1.tag = "Player 1";
            p1.SetActive(true);
            skivvyHP.SetActive(true);
        }
        else if (savedPlayer1 == 2)
        {
            p1 = Instantiate(alien, player1);
            p1.tag = "Player 1";
            p1.SetActive(true);
            alienHP.SetActive(true);
        }

        if (savedPlayer2 == 0)
        {
            p2 = Instantiate(skarab2, player2);
            p2.tag = "Player 2";
            p2.SetActive(true);
            skarab2HP.SetActive(true);
        }
        else if (savedPlayer2 == 1)
        {
            p2 = Instantiate(skivvy2, player2);
            p2.tag = "Player 2";
            p2.SetActive(true);
            skivvy2HP.SetActive(true);
        }
        else if (savedPlayer2 == 2)
        {
            p2 = Instantiate(alien2, player2);
            p2.tag = "Player 2";
            p2.SetActive(true);
            alien2HP.SetActive(true);
        }
    }

    private void Awake()
    {
        
    }
}
