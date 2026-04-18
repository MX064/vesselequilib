using System;
using Unity.VisualScripting;
using UnityEngine;


public class combat : MonoBehaviour
{
    public Transform Shader;
    [SerializeField] private GameObject goon1;
    [SerializeField] private GameObject goon2;
    [SerializeField] private GameObject goon3;
    [SerializeField] private GameObject goon4;              //declaring enemy game objects

    [SerializeField] private GameObject Nyra;
    private float goon1x;
    private float goon1y;
    private float goon2y;
    private float goon2x;
    private float goon3y;                                   //varaibles for each enemy x and y position as well as player's
    private float goon3x;
    private float goon4x;
    private float goon4y;
    private float shadery;
    private float shaderx;
    private float Nyray;

    private int goon1health=30;                       //health for each goon, used in if statements below
    private int goon2health=40;
    private int goon3health=50;
    private int goon4health=60;
    private int shaderhealth = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Start()
    {
        //make all goons invisble at start
        shadery = Shader.position.y;
        shaderx = Shader.position.x;
        goon1x = goon1.transform.position.x;
        goon1y = goon1.transform.position.y;
        Nyray = Nyra.transform.position.y;

        //add repeat loops ig

        if (Nyray == -13.0)
        {                                          //This ensure the player has spoken to Nyra first
            goon1.GetComponent<SpriteRenderer>().color = Color.black;
            if (Math.Abs(shaderx - goon1x) < 8 && Math.Abs(shadery - goon1y) < 8 && (goon1.GetComponent<SpriteRenderer>().color == Color.black))
            {
                Debug.Log("Press J to damage enemies.Press H to heal");
                if (Input.GetKey(KeyCode.J))
                {
                    goon1health = goon1health - 10;                          //goon attacks if Shader attacks
                    shaderhealth = shaderhealth - 2;
                    Debug.Log("Goon 1 health = " + goon1health + "Shader health = " + shaderhealth);
                }
                if (Input.GetKey(KeyCode.H))
                {
                    shaderhealth = shaderhealth + 5;                            //goon heals if Shader heals
                    goon1health = goon1health + 1;
                    Debug.Log("Goon 1 health = " + goon1health + "Shader health = " + shaderhealth);
                }
            }

            if (goon1health == 0)
            {
                goon1.GetComponent<SpriteRenderer>().color = Color.red;
                goon2.GetComponent<SpriteRenderer>().color = Color.black;
                Debug.Log("Defeat goon 2");
            }

            goon2x = goon2.transform.position.x;
            goon2y = goon2.transform.position.y;

            if (Math.Abs(shaderx - goon2x) < 2 && Math.Abs(shadery - goon2y) < 2 && (goon2.GetComponent<SpriteRenderer>().color == Color.black))
            {
                if (Input.GetKey(KeyCode.J))
                {
                    goon2health = goon2health - 10;                          //goon attacks if Shader attacks
                    shaderhealth = shaderhealth - 2;
                    Debug.Log("Goon 2 health = " + goon2health + "Shader health = " + shaderhealth);
                }
                if (Input.GetKey(KeyCode.H))
                {
                    shaderhealth = shaderhealth + 5;                            //goon heals if Shader heals
                    goon2health = goon2health + 1;
                    Debug.Log("Goon 2 health = " + goon2health + "Shader health = " + shaderhealth);
                }
            }

            if (goon2health == 0)
            {
                goon2.GetComponent<SpriteRenderer>().color = Color.red;
                goon3.GetComponent<SpriteRenderer>().color = Color.black;
                Debug.Log("Defeat goon 3");
            }
            goon3x = goon3.transform.position.x;
            goon3y = goon3.transform.position.y;

            if (Math.Abs(shaderx - goon3x) < 2 && Math.Abs(shadery - goon3y) < 2 && (goon3.GetComponent<SpriteRenderer>().color == Color.black))
            {
                if (Input.GetKey(KeyCode.J))
                {
                    goon3health = goon3health - 10;                          //goon attacks if Shader attacks
                    shaderhealth = shaderhealth - 2;
                    Debug.Log("Goon 3 health = " + goon3health + "Shader health = " + shaderhealth);
                }
                if (Input.GetKey(KeyCode.H))
                {
                    shaderhealth = shaderhealth + 5;                            //goon heals if Shader heals
                    goon3health = goon3health + 1;
                    Debug.Log("Goon 3 health = " + goon3health + "Shader health = " + shaderhealth);
                }
            }

            if (goon3health == 0)
            {
                goon3.GetComponent<SpriteRenderer>().color = Color.red;
                goon4.GetComponent<SpriteRenderer>().color = Color.black;
                Debug.Log("Defeat goon 4");
            }

            goon4x = goon4.transform.position.x;
            goon4y = goon4.transform.position.y;

            if (Math.Abs(shaderx - goon4x) < 2 && Math.Abs(shadery - goon4y) < 2 && (goon4.GetComponent<SpriteRenderer>().color == Color.black))
            {
                if (Input.GetKey(KeyCode.J))
                {
                    goon4health = goon4health - 10;                          //goon attacks if Shader attacks
                    shaderhealth = shaderhealth - 2;
                    Debug.Log("Goon 4 health = " + goon4health + "Shader health = " + shaderhealth);
                }
                if (Input.GetKey(KeyCode.H))
                {
                    shaderhealth = shaderhealth + 5;                            //goon heals if Shader heals
                    goon4health = goon4health + 1;
                    Debug.Log("Goon 4 health = " + goon4health + "Shader health = " + shaderhealth);
                }
            }

            if (goon4health == 0)
            {
                goon4.GetComponent<SpriteRenderer>().color = Color.red;
                Debug.Log("Goons all defeated. Level passed");
            }
        }
    }
}
