using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeCounter : MonoBehaviour
{
    public Text txtTimeCounter;
    float elapsedTime;
    public GameObject myCube;
    float tiempo;
    float nextSpawnTime;
    float freqInSeconds;

    bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        tiempo = Time.deltaTime;
        elapsedTime = 0;
        isPaused = false;
        nextSpawnTime = 2;
        freqInSeconds = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isPaused = !isPaused;
        }

        if (isPaused == false)
        {
            elapsedTime += Time.deltaTime;
        }

        txtTimeCounter.text = Mathf.Floor(elapsedTime).ToString();

        if(nextSpawnTime < Time.time)
        {
            Instantiate(myCube);
            nextSpawnTime += freqInSeconds;
        }
    }
}
