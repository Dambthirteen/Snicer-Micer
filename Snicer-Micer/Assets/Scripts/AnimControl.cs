using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimControl : MonoBehaviour
{
    Animation SnicerAnim;
    

    void Awake()
    {
        SnicerAnim = GetComponent<Animation>();
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SnicerAnim.Play("SliceAnimationtwo");
        }
       
    }
}
