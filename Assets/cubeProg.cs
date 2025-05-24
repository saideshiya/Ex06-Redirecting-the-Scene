using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coding : MonoBehaviour
{
    Rigidbody rb;
    public GameObject WinText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("level2");
            }
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Cube")
        {
            Destroy(other.gameObject);
            WinText.SetActive(true);
        }
    }
}
