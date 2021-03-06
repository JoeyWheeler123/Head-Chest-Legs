﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTurn : MonoBehaviour
{
    int playerOneTurn = 0;
    int playerTwoTurn = 0;

    List<string> playerOneMoves;
    List<string> playerTwoMoves;

    private bool axisOnePressed = false;
    private bool axisTwoPressed = false;

    public int actionLimit = 3;

    public Animator player1;
    public Animator player2;

    public int roundCount = 1;
    public Text roundText;

    public int timer = 5;
    public Text timeText;

    public GameObject gameOverPanel;
    public GameObject playerOneWin;
    public GameObject playerTwoWin;

    public Text moveInputOne;
    public Text moveInputTwo;

    //Audio stuff
    public AudioClip[] audioClips1;
    public AudioClip[] audioClips2;

    public AudioSource audio1;
    public AudioSource audio2;

    // Start is called before the first frame update
    void Start()
    {
        playerOneMoves = new List<string>();
        playerTwoMoves = new List<string>();

        //audio = gameObject.GetComponent<AudioSource>();
        
        StartCoroutine(Timer());
    }

    void InputChecks()
    {
        if (playerOneTurn < actionLimit)
        {
            if (Input.GetButtonUp("Head Attack"))
            {
                print("Head Attack");
                playerOneTurn += 1;
                playerOneMoves.Add("Head Attack");
                moveInputOne.text = playerOneMoves.Count.ToString();
                audio1.clip = audioClips1[0];
                audio1.Play();
            }
            else if (Input.GetButtonUp("Head Block"))
            {
                print("Head Block");
                playerOneTurn += 1;
                playerOneMoves.Add("Head Block");
                moveInputOne.text = playerOneMoves.Count.ToString();
                audio1.clip = audioClips1[6];
                audio1.Play();
            }
            else if (Input.GetButtonUp("Chest Attack"))
            {
                print("Chest Attack");
                playerOneTurn += 1;
                playerOneMoves.Add("Chest Attack");
                moveInputOne.text = playerOneMoves.Count.ToString();
                audio1.clip = audioClips1[1];
                audio1.Play();

            }
            else if (Input.GetButtonUp("Chest Block"))
            {
                print("Chest Block");
                playerOneTurn += 1;
                playerOneMoves.Add("Chest Block");
                moveInputOne.text = playerOneMoves.Count.ToString();
                audio1.clip = audioClips1[4];
                audio1.Play();

            }
            else if (Input.GetButtonUp("Leg Attack"))
            {
                print("Leg Attack");
                playerOneTurn += 1;
                playerOneMoves.Add("Leg Attack");
                moveInputOne.text = playerOneMoves.Count.ToString();
                audio1.clip = audioClips1[2];
                audio1.Play();

            }
            else if (Input.GetButtonUp("Leg Block"))
            {
                print("Leg Block");
                playerOneTurn += 1;
                playerOneMoves.Add("Leg Block");
                moveInputOne.text = playerOneMoves.Count.ToString();
                audio1.clip = audioClips1[4];
                audio1.Play();
            }
        }

        if (playerTwoTurn < actionLimit)
        {
            if (Input.GetButtonUp("Head Attack 2"))
            {
                print("Head Attack 2");
                playerTwoTurn += 1;
                playerTwoMoves.Add("Head Attack");
                moveInputTwo.text = playerTwoMoves.Count.ToString();
                audio2.clip = audioClips2[0];
                audio2.Play();
            }
            else if (Input.GetButtonUp("Head Block 2"))
            {
                print("Head Block 2");
                playerTwoTurn += 1;
                playerTwoMoves.Add("Head Block");
                moveInputTwo.text = playerTwoMoves.Count.ToString();
                audio2.clip = audioClips2[6];
                audio2.Play();
            }
            else if (Input.GetAxis("Chests 2") > 0.1f && !axisOnePressed)
            {
                axisOnePressed = true;
                print("Chest Attack 2");
                playerTwoTurn += 1;
                playerTwoMoves.Add("Chest Attack");
                moveInputTwo.text = playerTwoMoves.Count.ToString();
                audio2.clip = audioClips2[1];
                audio2.Play();
            }
            else if (Input.GetAxis("Chests 2") < -0.1f && !axisOnePressed)
            {
                axisOnePressed = true;
                print("Chest Block 2");
                playerTwoTurn += 1;
                playerTwoMoves.Add("Chest Block");
                moveInputTwo.text = playerTwoMoves.Count.ToString();
                audio2.clip = audioClips2[4];
                audio2.Play();
            }
            else if (Input.GetAxis("Chests 2") < 0.1f && Input.GetAxis("Chests 2") > -0.1f)
            {
                axisOnePressed = false;
            }

            if (Input.GetAxis("Legs 2") > 0.1f && !axisTwoPressed)
            {
                axisTwoPressed = true;
                print("Leg Attack 2");
                playerTwoTurn += 1;
                playerTwoMoves.Add("Leg Attack");
                moveInputTwo.text = playerTwoMoves.Count.ToString();
                audio2.clip = audioClips2[2];
                audio2.Play();
            }
            else if (Input.GetAxis("Legs 2") < -0.1f && !axisTwoPressed)
            {
                axisTwoPressed = true;
                print("Leg Block 2");
                playerTwoTurn += 1;
                playerTwoMoves.Add("Leg Block");
                moveInputTwo.text = playerTwoMoves.Count.ToString();
                audio2.clip = audioClips2[4];
                audio2.Play();
            }
            else if (Input.GetAxis("Legs 2") < 0.1f && Input.GetAxis("Legs 2") > -0.1f)
            {
                axisTwoPressed = false;
            }
        }
    }

    void AttackChecks()
    {
        if (timer == -1 || playerOneTurn == actionLimit && playerTwoTurn == actionLimit)
        {
            bool headBlock = false;
            bool chestBlock = false;
            bool legBlock = false;
            bool headBlockTwo = false;
            bool chestBlockTwo = false;
            bool legBlockTwo = false;

            bool blockChecked = false;
            bool blockTwoChecked = false;
            bool attackChecked = false;
            bool attackTwoChecked = false;

            player1.SetBool("Idle", false);
            player2.SetBool("Idle", false);

            if (playerOneMoves.Count == 0)
            {
                blockChecked = true;
                attackChecked = true;
            }

            if (playerTwoMoves.Count == 0)
            {
                blockTwoChecked = true;
                attackTwoChecked = true;
            }
            
            print("Round Play");
            for (int i = 0; i < playerOneMoves.Count; i++)
            {
                print("Running");
                print(playerOneMoves.Count);
                if (playerOneMoves[i] == "Head Block")
                {
                    headBlock = true;
                }
                else if (playerOneMoves[i] == "Chest Block")
                {
                    chestBlock = true;
                }
                else if (playerOneMoves[i] == "Leg Block")
                {
                    legBlock = true;
                }

                if (i == playerOneMoves.Count - 1)
                {
                    print("Check 1");
                    blockChecked = true;
                }
            }

            for (int i = 0; i < playerTwoMoves.Count; i++)
            {
                if (playerTwoMoves[i] == "Head Block")
                {
                    headBlockTwo = true;
                }
                else if (playerTwoMoves[i] == "Chest Block")
                {
                    chestBlockTwo = true;
                }
                else if (playerTwoMoves[i] == "Leg Block")
                {
                    legBlockTwo = true;
                }

                if (i == playerTwoMoves.Count - 1)
                {
                    print("Check 2");
                    blockTwoChecked = true;
                }
            }

            for (int i = 0; i < playerOneMoves.Count; i++)
            {
                if (playerOneMoves[i] == "Head Attack")
                {
                    player1.SetTrigger("Head");
                    if (!headBlockTwo)
                    {
                        print("Player 2 Head Hit");
                        PlayerHealth.twoHealthValue -= 0.1f;
                    }
                    else
                    {
                        print("Player 2 Head Blocked");
                    }
                }
                else if (playerOneMoves[i] == "Chest Attack")
                {
                    player1.SetTrigger("Chest");
                    if (!chestBlockTwo)
                    {
                        print("Player 2 Chest Hit");
                        PlayerHealth.twoHealthValue -= 0.1f;
                    }
                    else
                    {
                        print("Player 2 Chest Blocked");
                    }
                }
                else if (playerOneMoves[i] == "Leg Attack")
                {
                    player1.SetTrigger("Legs");
                    if (!legBlockTwo)
                    {
                        print("Player 2 Leg Hit");
                        PlayerHealth.twoHealthValue -= 0.1f;
                    }
                    else
                    {
                        print("Player 2 Leg Blocked");
                    }
                }

                if (i == playerOneMoves.Count - 1)
                {
                    print("Check 3");
                    attackChecked = true;
                }
            }

            for (int i = 0; i < playerTwoMoves.Count; i++)
            {
                if (playerTwoMoves[i] == "Head Attack")
                {
                    player2.SetTrigger("Head");
                    if (!headBlock)
                    {
                        print("Player 1 Head Hit");
                        PlayerHealth.oneHealthValue -= 0.1f;
                    }
                    else
                    {
                        print("Player 1 Head Blocked");
                    }
                }
                else if (playerTwoMoves[i] == "Chest Attack")
                {
                    player2.SetTrigger("Chest");
                    if (!chestBlock)
                    {
                        print("Player 1 Chest Hit");
                        PlayerHealth.oneHealthValue -= 0.1f;
                    }
                    else
                    {
                        print("Player 1 Chest Blocked");
                    }
                }
                else if (playerTwoMoves[i] == "Leg Attack")
                {
                    player2.SetTrigger("Legs");
                    if (!legBlock)
                    {
                        print("Player 1 Leg Hit");
                        PlayerHealth.oneHealthValue -= 0.1f;
                    }
                    else
                    {
                        print("Player 1 Leg Blocked");
                    }
                }

                if (i == playerTwoMoves.Count - 1)
                {
                    print("Check 4");
                    attackTwoChecked = true;
                }
            }

            if (blockChecked && blockTwoChecked && attackChecked && attackTwoChecked)
            {
                print("All checked");
                actionLimit += 1;
                timer = actionLimit+2;
                roundCount++;

                playerOneTurn = 0;
                playerOneMoves.Clear();
                axisOnePressed = false;
                axisTwoPressed = false;

                playerTwoTurn = 0;
                playerTwoMoves.Clear();

                player1.SetBool("Idle", true);
                player2.SetBool("Idle", true);

                moveInputOne.text = "";
                moveInputTwo.text = "";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        player1 = GameObject.FindWithTag("Player 1").GetComponent<Animator>();
        player2 = GameObject.FindWithTag("Player 2").GetComponent<Animator>();

        audioClips1 = player1.GetComponent<Sounds>().clips;
        audioClips2 = player2.GetComponent<Sounds>().clips;

        if(player1 == null)
        {
            player1 = GameObject.FindWithTag("Player 1").GetComponentInChildren<Animator>();
        }

        if(player2 == null)
        {
            player2 = GameObject.FindWithTag("Player 2").GetComponentInChildren<Animator>();
        }

        InputChecks();
        AttackChecks();
        if (roundCount <= 3)
        {
            roundText.text = roundCount + "/3";
        }

        if (roundCount == 4)
        {
            gameOverPanel.SetActive(true);
            
            if (PlayerHealth.oneHealth.fillAmount > PlayerHealth.twoHealth.fillAmount)
            {
                playerOneWin.SetActive(true);
            } else if (PlayerHealth.twoHealth.fillAmount > PlayerHealth.oneHealth.fillAmount)
            {
                playerTwoWin.SetActive(true);
            }
        }

        if (PlayerHealth.oneHealth.fillAmount < 0.1f)
        {
            if (!playerTwoWin.activeInHierarchy)
            {
                gameOverPanel.SetActive(true);
                playerOneWin.SetActive(true);
                Time.timeScale = 0;
            }
        }

        if (PlayerHealth.twoHealth.fillAmount < 0.1f)
        {
            if (!playerOneWin.activeInHierarchy)
            {
                gameOverPanel.SetActive(true);
                playerTwoWin.SetActive(true);
                Time.timeScale = 0;
            }
        }
        timeText.text = timer.ToString();
    }

    IEnumerator Timer()
    {   
        while (timer >= -1 && roundCount <=3)
        {
            yield return new WaitForSeconds(1.0f);
            print("running");
            timer -= 1;
        }   
    }
    
}