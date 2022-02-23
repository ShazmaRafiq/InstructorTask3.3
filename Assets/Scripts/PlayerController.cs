using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float horizontalInput;
    public float xRange = 10.0f;
    public GameObject missilePrefab;
    public Text gameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //keep the player in bounds
        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //  Launch a missile from the player
            Instantiate(missilePrefab, new Vector3(transform.position.x, transform.position.y + 3, transform.position.z), missilePrefab.transform.rotation);

            // Instantiate(missilePrefab, new Vector3(0, -4, -2), missilePrefab.transform.rotation);
        }



    }
    void OnCollisionEnter(Collision other)
    {

        Destroy(gameObject);
        Destroy(other.gameObject);
        gameOver.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
