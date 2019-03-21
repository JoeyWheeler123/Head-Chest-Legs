using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Image oneHealth;
    public Image twoHealth;

    public static float oneHealthValue = 1;
    public static float twoHealthValue = 1;

    public float lerpValue = 1;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*oneHealth.fillAmount = oneHealthValue;
        twoHealth.fillAmount = twoHealthValue;*/
        
        if (Input.GetKeyUp(KeyCode.Space))
        {
            oneHealthValue -= 0.1f;
        }

        if (oneHealth.fillAmount != oneHealthValue)
        {
            oneHealth.fillAmount = Mathf.Lerp(oneHealth.fillAmount, oneHealthValue, Time.deltaTime * lerpValue);
        }

        if (twoHealth.fillAmount != twoHealthValue)
        {
            twoHealth.fillAmount = Mathf.Lerp(twoHealth.fillAmount, twoHealthValue, Time.deltaTime * lerpValue);
        }
    }
}
