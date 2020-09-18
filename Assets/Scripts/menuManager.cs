using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class menuManager : MonoBehaviour {

    public GameObject player;
    public GameObject mainmenu;
    public GameObject cursor;
    public GameObject[] curserPositions;
    public GameObject playerSelectIndicator;
    public GameObject level01;
   
    private bool onStartGameSelection;




    // Start is called before the first frame update
    void Start()
    {
        onStartGameSelection = false;

       
    }

    // Update is called once per frame
    void Update() {


        // if space or return is pressed  



        //if (input.getkey("space") || input.getkey("return")) ;

        //player.setactive(true);
        //mainmenu.setactive(false);



        if(Input.GetKeyDown("up") || Input.GetKeyDown("down"))
        {

            if(onStartGameSelection)
            {
                onStartGameSelection = false;


            }
            else
            {

                onStartGameSelection = true;
            }

          
         
        }



        if (onStartGameSelection)
        {
            cursor.transform.position = curserPositions[1].transform.position;
        }
        else
        {

            cursor.transform.position = curserPositions[0].transform.position;
        }
        if (onStartGameSelection == false && Input.GetKeyDown("space")){
            mainmenu.SetActive(false);
        }


    }





}
