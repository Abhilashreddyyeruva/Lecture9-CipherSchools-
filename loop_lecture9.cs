using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      /*  for(int i = 0; i < 10; i++) 
            {   Debug.Log("the value of i is " + i); }*/

        int i = 0;

        /* while (i < 10)
         {
             Debug.Log("value of i is " + i);

             i = i + 2;
         }*/

        do
        {
            Debug.Log("value of i is" + i);
            i++;
        }
        while (i < 10); 
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
