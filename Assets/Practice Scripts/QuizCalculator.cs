using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    //Should calculate the average of 5 quiz grades
    //Should randomly generate a grade for each quiz at start up

    //Need to create variables to store the value of the grades
    //Need to create a variable to stor the average
    

    public float quiz1 = Random.Range(0.0f, 100.0f);
    public float quiz2 = Random.Range(0.0f, 100.0f);
    public float quiz3 = Random.Range(0.0f, 100.0f);
    public float quiz4 = Random.Range(0.0f, 100.0f);
    public float quiz5 = Random.Range(0.0f, 100.0f);

    public float average;
    // Start is called before the first frame update
    void Start()
    {
        
        float totalPoints = quiz1 + quiz2 + quiz3 + quiz4 + quiz5;
        float average = totalPoints / 100f;
        float gradeAverage = (float)System.Math.Round(average * 100f) / 100f;
        Debug.Log("Your GPA is: " + gradeAverage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
