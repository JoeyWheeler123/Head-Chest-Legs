using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public Text playerOneHealth;
    public Text playerTwoHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        playerOneHealth.text = "Health: 5";
        playerTwoHealth.text = "Health: 5";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
