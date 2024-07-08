using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
   private void Start()
         {
        //Funtions
        int result;
        CalculateTwoNumber();
        CalculateTwoNumber(4, 6);
        returmTwoNo();
        result= returnTwoNo(23,78);
        Debug.Log("sum of two no" +result);
      
    }
    //a funtion doesnt return or Doesnt take parameter
    void CalculateTwoNumber()
    {
        int a = 2;
        int b = 3;
        Debug.Log("sum of two number" + (a + b));
    }
    //a funtion doesnt return or take parameter
    void CalculateTwoNumber(int a,int b)
    {
        Debug.Log("sum of two numbers" + (a + b));
    }
    //a funtion return or Doesnt take parameter
    int returmTwoNo()
    {
        return 78 + 89;
    }
    //a funtion return or  take parameter
    int returnTwoNo(int a,int b)
    {
        return a + b;

    }
    
}
