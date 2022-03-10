using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    //Create a variable for the bill...should keep in mind the decimal point
    //Create a variable for the tip percentage
    //Create a variable for the tip amount or actuall dollar value
    //Create a variable for the toatl bill

    public float bill;
    public float tipPercent;

    // Start is called before the first frame update
    void Start()
    {
        float tipValue = bill * (tipPercent / 100);
        float totalBill = bill + tipValue;
        Debug.Log("After your tip of $" + tipValue + ", your total amount due is $" + totalBill + ".");
        
    }

}
