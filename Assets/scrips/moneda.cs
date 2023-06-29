using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coinController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Moneda");

        if (SceneManager.GetActiveScene().name == "pacmanrojo") {
            SceneManager.LoadScene("scenesecundaria");
        }
        else {
            SceneManager.LoadScene("pacmanrojo");
        }

    }
}