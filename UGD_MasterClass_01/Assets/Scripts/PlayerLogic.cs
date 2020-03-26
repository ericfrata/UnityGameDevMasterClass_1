using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    CharacterController m_characteController;
    
    float m_movimentSpeed = 1.0f;

    float m_horizontalInput; 

    float m_jumpHeight = 0.5f;
    float m_gravity = 0.045f; 
    bool m_jump = false; 


    public Vector3 m_moviment; 

    // Start is called before the first frame update
    void Start()
    {
        m_characteController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
       m_horizontalInput = Input.GetAxis("Horizontal");

       if(!m_jump && Input.GetButtonDown("Jump"))
       {
           m_jump = true; 
       }

    }

    void FixedUpdate() 
    {
        m_moviment.x = m_horizontalInput * m_movimentSpeed * Time.deltaTime;
        
        // Apply gravity
        if(!m_characteController.isGrounded){
            if(m_moviment.y > 0)
            {
                m_moviment.y -= m_gravity;
            }
            else
            {
                 m_moviment.y -= m_gravity * 1.5f;
            }
            
        }
        else
        {
            m_moviment.y = 0;
        }
        
        //Setting jumpHeight to moviment y

        if(m_jump)
        {
            m_moviment.y = m_jumpHeight;
            m_jump = false;
        }
      


        if(m_characteController)
        {
            m_characteController.Move(m_moviment);
        }
    }
}
