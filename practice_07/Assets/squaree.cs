using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squaree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Right()
    {
        transform.Translate(Vector3.right);
    }
    public void Left()
    {
        transform.Translate(Vector3.left);
    }
    public void Up()
    {
        transform.Translate(Vector3.up);
    }
    public void Down()
    {
        transform.Translate(Vector3.down);
    }
}
