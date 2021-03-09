using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookingProgressbar : MonoBehaviour
{
    public GameObject progressIcon;
    public Transform progressBar;
    public CookingStation cookingStation;

    [SerializeField] private float currentAmount;
    [SerializeField] private float speed;
    public bool cookingNow = false;

    // Start is called before the first frame update
    void Start()
    {
        cookingNow = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cookingNow)
        {
            if (progressIcon.activeSelf == false) 
            {
                progressIcon.SetActive(true); // Show the icon only if cooking
            } else
            {
                FillUpBar(); // Start filling up the bar once it is active
            }            
        }
    }

    void FillUpBar()
    {
        if (currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
        }
        else
        {
            // set the timer to false once it reaches 100?
            cookingNow = false;
            progressIcon.SetActive(false);
            currentAmount = 0; // Reset value for next cooking
            cookingStation.isCooking = false;
        }

        progressBar.GetComponent<Image>().fillAmount = currentAmount / 100;
        // Debug.Log("progress is now: " + currentAmount.ToString());
    }
}