using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Collider colider;

    void Start()
    {
        colider = GetComponent<Collider>();
    }
        void Update ()
    {
        if(Input.GetKeyDown(KeyCode.E))
            {
            colider.isTrigger = true;
        }
        else
        {
            colider.isTrigger = false;
        }

    }
    

  void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag== "Player" ) 
        {
            Destroy(gameObject);
        }

    }
     
    }
 

