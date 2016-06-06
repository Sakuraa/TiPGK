using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    int y = 0;
    void Start()
    {

        y = leaveCrystals();
    }

    void OnTriggerEnter(Collider collider)
    {
        TextMesh text = transform.GetComponent<TextMesh>();
        int x = PlayerPrefs.GetInt("points");
        text.text = x.ToString() + '/' + y.ToString();
    }

    int leaveCrystals()
    {
        Crystal[] crystals = Component.FindObjectsOfType<Crystal>();
        return crystals.Length;
    }

}
