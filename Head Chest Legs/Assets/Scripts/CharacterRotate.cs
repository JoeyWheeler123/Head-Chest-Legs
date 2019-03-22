using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterRotate : MonoBehaviour
{
    private GameObject[] characters;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");

        characters = new GameObject[transform.childCount];

        for(int i = 0; i < transform.childCount; i ++)
        {
            characters[i] = transform.GetChild(i).gameObject;
        }

        foreach(GameObject go in characters)
        {
            go.SetActive(false);
        }

        if(characters[0])
        {
            characters[0].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Right()
    {
        characters[index].SetActive(false);

        index++;

        if (index == characters.Length)
        {
            index = 0;
        }

        characters[index].SetActive(true);
    }

    public void Left()
    {
        characters[index].SetActive(false);

        index--;

        if(index < 0)
        {
            index = characters.Length - 1;
        }

        characters[index].SetActive(true);
    }

    public void Confirm()
    {
        characters[index].tag = "Player 1";
        PlayerPrefs.SetInt("CharacterSelected", index);
        SceneManager.LoadScene("Main");
    }
}
