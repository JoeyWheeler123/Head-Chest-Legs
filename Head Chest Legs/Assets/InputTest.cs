using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    int playerOneTurn = 0;
    int playerTwoTurn = 0;
    List<string> playerOneMoves;
    List<string> playerTwoMoves;

    // Start is called before the first frame update
    void Start()
    {
        playerOneMoves = new List<string>();
        playerTwoMoves = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerOneTurn < 3)
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
            else if (Input.GetButtonUp("Leg Attack"))
            {
                print("Leg Attack");
                playerOneTurn += 1;
                playerOneMoves.Add("Leg Attack");
            }
            else if (Input.GetButtonUp("Leg Block"))
            {
                print("Leg Block");
                playerOneTurn += 1;
                playerOneMoves.Add("Leg Block");
            }
        }

        // if(Input.GetAxis("Horizontal") >= 0.1f)
        //{
        //    print("AXIS POSITIVE");
        //} else if(Input.GetAxis("Horizontal") <= -0.1f)
        //{
        //    print("AXIS NEGATIVE");
        //}
        if (playerTwoTurn < 3)
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
            else if (Input.GetButtonUp("Chest Attack 2"))
            {
                print("Chest Attack 2");
                playerTwoTurn += 1;
                playerTwoMoves.Add("Chest Attack");
            }
            else if (Input.GetButtonUp("Chest Block 2"))
            {
                print("Chest Block 2");
                playerTwoTurn += 1;
                playerTwoMoves.Add("Chest Block");
            }
            else if (Input.GetButtonUp("Leg Attack 2"))
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

        if(playerOneTurn == 3 && playerTwoTurn == 3)
        {
            print("Round Play");
            for(int i = 0; i < playerOneMoves.Count; i ++)
            {
                if(playerOneMoves[i] == "Head Attack")
                {
                    print("1 High Attack");
                } else if(playerOneMoves[i] == "Head Block")
                {
                    print("1 High Block");
                } else if(playerOneMoves[i] == "Chest Attack")
                {
                    print("1 Mid Attack");
                } else if(playerOneMoves[i] == "Chest Block")
                {
                    print("1 Mid Block");
                }else if(playerOneMoves[i] == "Leg Attack")
                {
                    print("1 Low Attack");
                } else if(playerOneMoves[i] == "Leg Block")
                {
                    print("1 Low Block");
                }

                if(i == 2)
                {
                    playerOneTurn = 0;
                    playerOneMoves.Clear();
                }
            }

            for(int i = 0; i < playerTwoMoves.Count; i ++)
            {
                if (playerTwoMoves[i] == "Head Attack")
                {
                    print("2 High Attack");
                }
                else if (playerTwoMoves[i] == "Head Block")
                {
                    print("2 High Block");
                }
                else if (playerTwoMoves[i] == "Chest Attack")
                {
                    print("2 Mid Attack");
                }
                else if (playerTwoMoves[i] == "Chest Block")
                {
                    print("2 Mid Block");
                }
                else if (playerTwoMoves[i] == "Leg Attack")
                {
                    print("2 Low Attack");
                }
                else if (playerTwoMoves[i] == "Leg Block")
                {
                    print("2 Low Block");
                }

                if (i == 2)
                {
                    playerTwoTurn = 0;
                    playerTwoMoves.Clear();
                }
            }
        }
    }
}
