using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Examination : MonoBehaviour
{
    public Color color;
    public SpriteRenderer rend;
    public float speed = 8;
    public float Timer = 0;
    public int DiceRollColor = 0;
    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-11, 11));
        //Gör så att man randomiserar spawnpointen på mappen
        speed = Random.Range(2, 8);
        //Gör så att vid början av spelet skeppet spawnar med olika fart.
    }








    // Update is called once per frame
    void Update()

    {
        transform.Translate(0, speed * Time.deltaTime, 0);
        //Gör så att skeppet åker konstant frammåt
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -360f * Time.deltaTime);
            //Gör så att skeppet roterar i 360 grander per sekund åt höger
            rend.color = Color.blue;
            //Gör så att skeppet blir blått när man trycker på A
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 180f * Time.deltaTime);
            //Gör så att skeppet roterar i 180 grader per sekund åt vänster
            rend.color = Color.green;
            //Gör så att skeppet blir grönt när man trycker på D
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed / 2 * Time.deltaTime, 0, Space.Self);
            //Gör så att skeppet åker hälften så snabbt
        }
        if (Input.GetKeyDown(KeyCode.Space))
            //Gör så att när man trycker spacebar så blir det en random färg beroende på vilket nummer då får nedanför.
        {
            DiceRollColor = Random.Range(1, 5);

            if (DiceRollColor == 1)
            {
                rend.color = new Color(0.52f, 0.20f, 0.10f);
            }
            else if (DiceRollColor == 2)
            {
                rend.color = new Color(0.20f, 0.30f, 0.40f);
            }
            else if (DiceRollColor == 3)
            {
                rend.color = new Color(0.30f, 0.40f, 0.50f);
            }
            else if (DiceRollColor == 4)
            {
                rend.color = new Color(0.95f, 0.20f, 0.15f);
            }

        }
        NewMethod();
        Timer = Timer + 1 * Time.deltaTime;
        //Gör så att timern räknar uppåt med 1 per sekund

    }

    private void NewMethod()
    {
        if (transform.position.x < -11.5)
            //Gör så att om skeppet åker utanför x -11.5 så teleporterar den till andra sidan på samma y position
        {
            transform.position = new Vector3(11.5f, (transform.position.y));
        }
        if (transform.position.x > 11.5)
        //Gör så att om skeppet åker utanför x 11.5 så teleporterar den till andra sidan på samma y position
        {
            transform.position = new Vector3(-11.5f, (transform.position.y));
        }
        if (transform.position.y < -5)
            //Gör så att om skeppet åker utanför y -5 så teleporterar den till andra sidan på samma x position
        {
            transform.position = new Vector3((transform.position.x), 5);
        }
        if (transform.position.y > 5)
        //Gör så att om skeppet åker utanför y 5 så teleporterar den till andra sidan på samma x position
        {
            transform.position = new Vector3((transform.position.x), -5);



        }
    }
}