using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 100 * Time.deltaTime, 0, Space.Self);
    }
    public void ResetScene()
    {

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("scene");
    }

}