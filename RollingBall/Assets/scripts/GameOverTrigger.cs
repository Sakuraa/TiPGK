using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour 
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "ball")
        {
            string levelName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(levelName);
        }
    }
}
