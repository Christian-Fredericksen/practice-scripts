using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    //Should calculate the average of 5 quiz grades

    //Should randomly generate a grade for each quiz at start up

    //Need to create variables to store the value of the grades
    //Need to create a variable to stor the average
    //int num = Random.Range(0, 100);
    public int quiz1;
    public int quiz2;
    public int quiz3;
    public int quiz4;
    public int quiz5;

    public float average;
    // Start is called before the first frame update
    void Start()
    {
        quiz1 = Random.Range(0, 101);
        quiz2 = Random.Range(0, 101);
        quiz3 = Random.Range(0, 101);
        quiz4 = Random.Range(0, 101);
        quiz5 = Random.Range(0, 101);
        int totalPoints = quiz1 + quiz2 + quiz3 + quiz4 + quiz5;
        average = totalPoints / 5f;
        float gradeAverage = (float)System.Math.Round(average * 100f) / 100f;
        Debug.Log("Your GPA is: " + gradeAverage);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
