using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour {
    public CharacterController controller;
    public Animator animator;
    public float speed = 5f;
    public Text textScore;

     public int score=0;

    void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(v*transform.forward.x*Time.deltaTime,0,v*transform.forward.z*Time.deltaTime);
        controller.Move(movement*speed);

        transform.Rotate(new Vector3(0,h*speed,0));
        
        if (v == 0 && h == 0)
           
        {
            animator.SetBool("isRun", false);
        }
        else
        {
            animator.SetBool("isRun", true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetTrigger("isJump");
        }

    }
    void OnTriggerEnter(Collider other)
    {
        score++;
        textScore.text = score.ToString();

        Destroy(other.gameObject);
    }
}
