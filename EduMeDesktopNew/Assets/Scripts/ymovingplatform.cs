using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ymovingplatform : MonoBehaviour
{
   
    [SerializeField]
    float MovementRadius=100f,MovementSpeed = 0.07f;

    float posY, number1 = 0f;

    bool movingUp = true;

    // Update is called once per frame
    void Update()
    {
        number1 = number1 + 1f;
        if (movingUp == true) posY = transform.position.y + MovementSpeed;
        if(movingUp ==false) posY = transform.position.y - MovementSpeed;

        transform.position = new Vector2(transform.position.x,posY);


        if (number1 >= MovementRadius/2)
            movingUp = false;
        if (number1 >= MovementRadius)
            movingUp = true ;
        if (number1 >= MovementRadius)
            number1 = 0f;


    }
}
