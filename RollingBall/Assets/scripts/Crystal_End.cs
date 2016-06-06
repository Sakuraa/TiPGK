using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Crystal_End : MonoBehaviour
{
    public GameObject particle;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name != "ball")
        {
            return;
        }

        if (leaveCrystals() == 1)
        {
            string levelName = SceneManager.GetActiveScene().name;
            PlayerPrefs.SetInt(levelName + "_finished", 1);
            
            SceneManager.LoadScene("Menu");
        }



    }

    int leaveCrystals()
    {
        Crystal_End[] crystals = Component.FindObjectsOfType<Crystal_End>();
        return crystals.Length;
    }
 
}

    