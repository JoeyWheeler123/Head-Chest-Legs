using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    private List<GameObject> characters;

    private int selectionIndex = 0;

    private void Start()
    {
        selectionIndex = PlayerPrefs.GetInt("CharacterSelected");
        characters = new List<GameObject>();
        foreach(Transform t in transform)
        {
            characters.Add(t.gameObject);
            t.gameObject.SetActive(false);
        }

        characters[selectionIndex].SetActive(true);
    }

    public void Select(int index)
    {
        if(index == selectionIndex)
        {
            return;
        }

        if(index < 0 || index >= characters.Count)
        {
            return;
        }

        characters[selectionIndex].SetActive(false);
        selectionIndex = index;
        characters[selectionIndex].SetActive(true);
    }

    public void Confirm()
    {
        PlayerPrefs.SetInt("CharacterSelected", selectionIndex);
        SceneManager.LoadScene("Main");
    }
}
