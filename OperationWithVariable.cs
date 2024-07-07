using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
   private void Start()
         {
        //use int as datatype
        int a = 4;
        int b= 5;
        int c = a + b;
        int d = a - b;
        int e = a * b;
        int f = a / b;

        //use datatype as float
        float g = 4.7f;
        float h = 5.2f;
        float i = g + h;
        float j = g - h;
        float k = g * h;
        float l = g / h;

        string m = "hi";
        string n = "hello";
        string o = m + n;
        
        //print them to see in console
        Debug.Log(a + "+" + b + "=" + c);
        Debug.Log(a + "+" + b + "=" + d);
        Debug.Log(a + "+" + b + "=" + e);
        Debug.Log(a + "+" + b + "=" + f);

        //print them in float
        Debug.Log(g + "+" + h + "=" + i);
        Debug.Log(g + "+" + h + "=" + j);
        Debug.Log(g + "+" + h + "=" + k);
        Debug.Log(g + "+" + h + "=" + l);
        //print the concate option on string
        Debug.Log(m + "+" + n + "=" + o);
    }
}
