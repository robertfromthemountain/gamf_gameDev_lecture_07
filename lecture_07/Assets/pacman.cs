using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pacman : MonoBehaviour
{
    int lifePoint = 10;
    public Image life;
    public Text lifeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MyStartClick(Image life, TextAlignment lifeText)
    {
        Debug.Log("Clicked...");
        lifePoint--;
        if (lifePoint == 0)
        {
            Destroy(gameObject);
        }

        life.rectTransform.localScale = new Vector3(lifePoint / 10.0f);
        lifeText.text = "Life: " + lifePoint.ToString();
    }
}
