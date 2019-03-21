using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTurn : MonoBehaviour
{
    int playerOneTurn = 0;
    int playerTwoTurn = 0;
    List<string> playerOneMoves;
    List<string> playerTwoMoves;
    private bool axisOnePressed = false;
    private bool axisTwoPressed = false;
    private bool rightTriggerPressed = false;
    private bool leftTriggerPressed = false;
    public int actionLimit = 3;

    // Start is called before the first frame update
    void Start()
    {
        playerOneMoves = new List<string>();
        playerTwoMoves = new List<string>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerOneTurn < actionLimit)
        {
            if (Input.GetButtonUp("Head Attack"))
            {
                print("Head Attack");
                playerOneTurn += 1;
                playerOneMoves.Add("Head Attack");
            }
            else if (Input.GetButtonUp("Head Block"))
            {
                print("Head Block");
                playerOneTurn += 1;
                playerOneMoves.Add("Head Block");
            }
            else if (Input.GetButtonUp("Chest Attack"))
            {
                print("Chest Attack");
                playerOneTurn += 1;
                playerOneMoves.Add("Chest Attack");
            }
            else if (Input.GetButtonUp("Chest Block"))
            {
                print("Chest Block");
                playerOneTurn += 1;
                playerOneMoves.Add("Chest Block");
            }
            else if (Input.GetAxis("Leg Attack") > 0.1f && !axisTwoPressed)
            {
                axisTwoPressed = true;
                print("Leg Attack");
                playerOneTurn += 1;
                playerOneMoves.Add("Leg Attack");
            }
        else if (Input.GetAxis("Leg Attack") < -0.1f && !axisOnePressed)
            {
                axisOnePressed = true;
                print("Leg Block");
                playerOneTurn += 1;
                playerOneMoves.Add("Leg Block");
            }else if (Input.GetAxis("Leg Attack") < 0.1f && Input.GetAxis("Leg Attack") > -0.1f)
            {
                axisOnePressed = false;
            }
        }

        // if(Input.GetAxis("Horizontal") >= 0.1f)
        //{
        //    print("AXIS POSITIVE");
        //} else if(Input.GetAxis("Horizontal") <= -0.1f)
        //{
        //    print("AXIS NEGATIVE");
        //}
        
        if (playerTwoTurn < actionLimit)
        {
            if (Input.GetButtonUp("Head Attack 2"))
            {
                print("Head Attack 2");
                playerTwoTurn += 1;
                playerTwoMoves.Add("Head Attack");
            }
            else if (Input.GetButtonUp("Head Block 2"))
            {
                print("Head Block 2");
                playerTwoTurn += 1;
                playerTwoMoves.Add("Head Block");
            }
           
            if (Input.GetAxis("Chest Attack 2") > 0.1f && !rightTriggerPressed)
            {
                rightTriggerPressed = true;
                print("Chest Attack 2");
                playerTwoTurn += 1;
                playerTwoMoves.Add("Chest Attack");
            }
            else if(Input.GetAxis("Chest Attack 2") < 0.1f)
            {
                rightTriggerPressed = false;
            }
            
            if (Input.GetAxis("Chest Block 2") > 0.1f && !leftTriggerPressed)
            {
                leftTriggerPressed = true;
                print("Chest Block 2");
                playerTwoTurn += 1;
                playerTwoMoves.Add("Chest Block");
            } else if (Input.GetAxis("Chest Block 2") < 0.1f)
            {
                leftTriggerPressed = false;
            } 
            
            if (Input.GetButtonUp("Leg Attack 2"))
            {
                print("Leg Attack 2");
                playerTwoTurn += 1;
                playerTwoMoves.Add("Leg Attack");
            }
            else if (Input.GetButtonUp("Leg Block 2"))
            {
                print("Leg Block 2");
                playerTwoTurn += 1;
                playerTwoMoves.Add("Leg Block");
            }
        }

        if(playerOneTurn == actionLimit && playerTwoTurn == actionLimit)
        {
            bool headBlock = false;
            bool chestBlock = false;
            bool legBlock = false;
            bool headBlockTwo  = false;
            bool chestBlockTwo = false;
            bool legBlockTwo = false;
            
            print("Round Play");
            for (int i = 0; i < playerOneMoves.Count; i++)
            {
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

                if (playerOneMoves[i] == "Head Attack")
                {
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

                if (playerTwoMoves[i] == "Head Attack")
                {
                    if (!headBlock)
                    {
                        print("Player 1 Head Hit");
                        PlayerHealth.oneHealthValue -= 0.1f;
                    }
                    else
                    {
                        print("Player 1 Head Blocked");
                    }
                } else if (playerTwoMoves[i] == "Chest Attack")
                {
                    if (!chestBlock)
                    {
                        print("Player 1 Chest Hit");
                        PlayerHealth.oneHealthValue -= 0.1f;
                    }
                    else
                    {
                        print("Player 1 Chest Blocked");
                    }
                } else if (playerTwoMoves[i] == "Leg Attack")
                {
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

            if(i == 2)
                {
                    actionLimit += 1;
                    
                    playerOneTurn = 0;
                    playerOneMoves.Clear();
                    axisOnePressed = false;
                    axisTwoPressed = false;

                    playerTwoTurn = 0;
                    playerTwoMoves.Clear();
                    leftTriggerPressed = false;
                    rightTriggerPressed = false;
                }
            }
        }
    }
}
