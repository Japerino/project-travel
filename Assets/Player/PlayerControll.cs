using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour {
    public float moveSpeed;
    /*  -JP 06\28\18
     * .GetAxisRaw this will use almost any form of input whether it be the arrow keys or WASD both will work
     * just so you know.
     */
    private Animator anime;// this is used to interact with the animation stuff

    void Start() {
        anime = GetComponent<Animator>();
        anime.SetBool("Moving", false);// Making sure that the character is in idel at the start
    }
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f){// checks if there any horizontal input up or down
            anime.SetBool("Moving", true);//moving animation
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));// gets the input from the "contoller" aka wasd and arrow keys
        }
        else {
            anime.SetBool("Moving", false);
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f){// checks if there any vertical input left or right
            anime.SetBool("Moving", true);//moving animation
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));// gets the input from the "contoller" aka wasd and arrow keys

        }
        // small little meme of makeing of the attack animation
        // hold f to see
        if (Input.GetKey("f"))
            anime.SetBool("attack", true);
        else
            anime.SetBool("attack", false);
    }



}
