using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static Image oneHealth;
    public static Image twoHealth;
    public GameObject healthOne;
    public GameObject healthTwo;

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
    
        if (healthOne.transform.Find("Alien Health").gameObject.activeInHierarchy)
        {
            oneHealth = healthOne.transform.Find("Alien Health").transform.Find("Background").transform.Find("Mask")
                .transform.Find("Bar").gameObject.GetComponent<Image>();
        }

        if (healthOne.transform.Find("Fighter Health").gameObject.activeInHierarchy)
        {
            oneHealth = healthOne.transform.Find("Fighter Health").transform.Find("Background").transform.Find("Mask")
                .transform.Find("Bar").gameObject.GetComponent<Image>();
        }
        
        if (healthOne.transform.Find("Skivvy Health").gameObject.activeInHierarchy)
        {
            oneHealth = healthOne.transform.Find("Skivvy Health").transform.Find("Background").transform.Find("Mask")
                .transform.Find("Bar").gameObject.GetComponent<Image>();
        }
        
        if (healthTwo.transform.Find("Alien Health").gameObject.activeInHierarchy)
        {
            twoHealth = healthTwo.transform.Find("Alien Health").transform.Find("Background").transform.Find("Mask")
                .transform.Find("Bar").gameObject.GetComponent<Image>();
        }
        
        if (healthTwo.transform.Find("Fighter Health").gameObject.activeInHierarchy)
        {
            twoHealth = healthTwo.transform.Find("Fighter Health").transform.Find("Background").transform.Find("Mask")
                .transform.Find("Bar").gameObject.GetComponent<Image>();
        }
        
        if (healthTwo.transform.Find("Skivvy Health").gameObject.activeInHierarchy)
        {
            twoHealth = healthTwo.transform.Find("Skivvy Health").transform.Find("Background").transform.Find("Mask")
                .transform.Find("Bar").gameObject.GetComponent<Image>();
        }
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
