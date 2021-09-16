using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{

    int type;
    float size;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        MakeObstacle();
    }

    private void MakeObstacle()
    {
        float x = Random.Range(-2.7f, 2.7f);
        float y = Random.Range(3.0f, 5.0f);
        transform.position = new Vector3(x, y, 0);

        type = Random.Range(1, 4);

        if(type == 1) 
        {
            size = 2.2f;
            score = 2;
            GetComponent<SpriteRenderer>().color = new Color(100 / 255f, 100 / 255f, 255 / 255f, 255 / 255f);
        }
        else if (type == 2)
        {
            size = 1.0f;
            score = 1;
            GetComponent<SpriteRenderer>().color = new Color(130 / 255f, 130 / 255f, 255 / 255f, 255 / 255f);
        }
        else 
        {
            size = 3.8f;
            score = 3;
            GetComponent<SpriteRenderer>().color = new Color(150 / 255f, 150 / 255f, 255 / 255f, 255 / 255f);
        }
        transform.localScale = new Vector3(size, size, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "balloon") 
        {
            Debug.Log("끝!");
            Destroy(gameObject);
        }    
        
        // if (coll.gameObject.tag == "charactor")
        // {
        //     gameManager.i.addScore(score);
        // }
    }
}
