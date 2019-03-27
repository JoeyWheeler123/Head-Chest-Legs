using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public int p1;
    public int p2;

    // Start is called before the first frame update
    void Start()
    {
        GameObject char1 = GameObject.Find("Player 1 Characters");
        GameObject char2 = GameObject.Find("Player 2 Characters");

        CharacterRotate characterRotate1 = char1.GetComponent<CharacterRotate>();
        CharacterRotate characterRotate2 = char2.GetComponent<CharacterRotate>();

        characterRotate1.index = p1;
        characterRotate2.index = p2;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Confirm()
    {
        PlayerPrefs.SetInt("CharacterSelected1", p1);
        PlayerPrefs.SetInt("CharacterSelected2", p2);
        SceneManager.LoadScene("Connor Test Scene");
    }

    public void Clear()
    {
        PlayerPrefs.DeleteAll();
    }
}
