using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class Item : MonoBehaviour
{
    public Collider colider;
    public string mensaje="Pulsa E para cogerlo";
    public bool activo=false;
    public GUIStyle font;
    
    


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
    void OnGUI()
    {

        if (activo)
        {

           
            GUI.Label(new Rect(Screen.width / 2 - 100, 50, 200, 30), mensaje, font );
          

        }

    }

        void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag== "Player" ) 
        {
            Destroy(gameObject);
        }

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            activo = true;
        }
        
            
        
    }
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            activo = false;
        }
    }
    
    }

 

