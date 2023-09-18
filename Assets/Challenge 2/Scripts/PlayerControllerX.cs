using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 0.0f;
    private float cooldownReset = 0.6f;

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        Debug.Log(cooldown);
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) & cooldown <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = cooldownReset;
        }
    }
}
