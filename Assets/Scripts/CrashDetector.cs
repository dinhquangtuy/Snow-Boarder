using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour {
    private float loadDelay = 0.3f;
    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Ground") {
            Debug.Log("Ouch, hit my head");
            Invoke("ReloadScene", loadDelay);
        }
    }
    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
