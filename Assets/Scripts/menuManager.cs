using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour {

   public GameObject player;
   public GameObject mainmenu;

    
    
    // Use this for initialization
    void Start()
    {
       

        player.SetActive(true);
        mainmenu = GetComponent<GameObject>();
        mainmenu.SetActive(false);
    }

    // Update is called once per frame
    void Update() {






        if (Input.GetKey("space") || Input.GetKey("return")) ;

        player.SetActive(true);
        mainmenu.SetActive(false);
    

	}
    
     }

