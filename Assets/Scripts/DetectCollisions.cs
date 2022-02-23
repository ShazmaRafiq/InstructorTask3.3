using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameObject secprefab;
    public static float counter = 0;
    // Start is called before the first frame update
    void Start()
    {
       // secprefab = GameObject.FindGameObjectWithTag("two");
        secprefab = GameObject.Find("Ball1");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {
       
        
       
        if (other.gameObject.tag == "one")
        {
            Debug.Log("collided with one ball");
            Instantiate(secprefab, new Vector3(transform.position.x -1, transform.position.y, transform.position.z), Quaternion.identity);
            Instantiate(secprefab, new Vector3(transform.position.x+1, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
      else  if (other.gameObject.tag == "two")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            counter += 1;
            Debug.Log(counter);
        }

    }
   
}
