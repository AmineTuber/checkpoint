using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    
    void Start()
    {
        
    }
        


    
   
    
    
    

        // Update is called once per frame
        void Update()
    {
        

        int a=testscript(1,5);
       int b= testscript(-2, 6);
        Debug.Log(a);
        Debug.Log(b);
        int c = checkpoint1(9 , 3);
        Debug.Log(c);
        int e = checkpoint2(8, 2);
        Debug.Log(e);
    }
        int testscript(int a , int b)
        {
       
        return a + b;  


        }
        int checkpoint1(int c, int d)
        {


        return c/d;


        }
        int checkpoint2(int e , int f)
    {

        return e * f;

    }
}
