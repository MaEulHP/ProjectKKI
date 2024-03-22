using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DaysText : MonoBehaviour
{
    public Text days_text;
    // Start is called before the first frame update
    void Start()
    {
        this.days_text = GameObject.Find("Days").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        days_text.text = "Days : " + CostManager.days_cnt.ToString();
    }
}
