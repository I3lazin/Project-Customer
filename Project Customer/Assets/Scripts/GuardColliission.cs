using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuardColliission : MonoBehaviour
{
    GameManager manager;

    private void Start()
    {
        manager = GetComponent<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ++manager.timesCaught;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
