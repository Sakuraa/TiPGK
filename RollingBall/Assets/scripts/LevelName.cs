using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelName : MonoBehaviour 
{
	void Start () 
    {
        TextMesh text = transform.GetComponent<TextMesh>();
        text.text = SceneManager.GetActiveScene().name;
    }
}
