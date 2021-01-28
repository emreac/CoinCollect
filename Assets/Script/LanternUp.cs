using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternUp : MonoBehaviour
{

    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * movementSpeed);    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            this.gameObject.SetActive(false);
    }
}
