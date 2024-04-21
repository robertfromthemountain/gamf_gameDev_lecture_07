using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collider : MonoBehaviour
{
    public GameObject chreeyProto;

    float cherryCooldown = 5.0f;

    public Text lifeText;

    int result = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * 3.0f * Time.deltaTime);

        if (cherryCooldown > 0)
        {
            cherryCooldown -= Time.deltaTime;
        }
        else
        {
            GameObject cherry = Instantiate(chreeyProto);
            float xc = Random.Range(-9.0f, 7.0f);
            float yc = Random.Range(-5.0f, 5.0f);
            cherry.transform.position = new Vector3 (xc, yc, 0);
            cherryCooldown = 5.0f;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Food")
        {
            Destroy(collision.gameObject);
            lifeText.text = "result: " + result;
        }

        transform.Translate(Vector3.left * 0.1f)
;
        int randomDir = Random.Range(0,2);


        if (randomDir == 0)
        {
            transform.Rotate(Vector3.forward * 90);
        }else
        {
            transform.Rotate(-Vector3.forward * 90);
        }
    }
}
