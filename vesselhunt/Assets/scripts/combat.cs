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

    private int goon1health=40;                       //health for each goon, used in if statements below
    private int goon2health=50;
    private int goon3health=60;
    private int goon4health=70;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

 
    }

    // Update is called once per frame
    void Update()
    {
        //make all goons invisble at start
        shadery = Shader.position.y;
        shaderx = Shader.position.x;
        goon1x = goon1.transform.position.x;
        goon1y = goon1.transform.position.y;

        if (Math.Abs(shaderx-goon1x) < 5 && Math.Abs(shadery-goon1y) < 5)
        {
            //goon1 = visbile
            Debug.Log("Press J to damage enemies");
            if (Input.GetKey(KeyCode.J))
            {
                goon1health = goon1health - 10;
            }
        }

        if (goon1health == 0)
        {
            //goon1 colour = red
            //goon2 visible
            //debug goon1 ded
        }

        goon2x = goon2.transform.position.x;
        goon2y = goon2.transform.position.y;

        if (Math.Abs(shaderx - goon2x) < 5 && Math.Abs(shadery - goon2y) < 5)
        {
            if (Input.GetKey(KeyCode.J))
            {
                goon2health = goon2health - 10;
            }
        }

        if (goon2health == 0)
        {
            //goon2 colour = red
            //goon3 visible
        }
        goon3x = goon3.transform.position.x;
        goon3y = goon3.transform.position.y;

        if (Math.Abs(shaderx - goon3x) < 5 && Math.Abs(shadery - goon3y) < 5)
        {
            if (Input.GetKey(KeyCode.J))
            {
                goon3health = goon3health - 10;
            }
        }

        if (goon3health == 0)
        {
            //goon3 colour = red
            //goon4 visible
        }

        goon4x = goon4.transform.position.x;
        goon4y = goon4.transform.position.y;

        if (Math.Abs(shaderx - goon4x) < 5 && Math.Abs(shadery - goon4y) < 5)
        {
            if (Input.GetKey(KeyCode.J))
            {
                goon4health = goon4health - 10;
            }
        }
    }
}
