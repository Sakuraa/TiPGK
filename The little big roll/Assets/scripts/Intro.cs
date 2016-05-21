using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
	IEnumerator Start ()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("The little big ball");
	}
}
