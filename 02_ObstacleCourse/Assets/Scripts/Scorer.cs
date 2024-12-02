using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    public void Quit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; 
        #else
            Application.Quit();
        #endif
    }
    public void Restart() { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    int hits = 0;
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag != "Hit") {
            hits ++;
            Debug.Log("You've bumped into a thing this many times: " + hits);
        }
        if (other.gameObject.tag == "Finish") {
            print("Restart");
            // Quit();
            Restart();
        }
    }
}
