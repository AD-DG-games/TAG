using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TriggerForCatch : MonoBehaviour
{
    //[Tooltip("Every object tagged with this tag will trigger game over")]
    [SerializeField] string triggeringTag;
    //[SerializeField] string nextlevalName;

    public void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            var audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            Debug.Log("started");
            //SceneManager.LoadScene(nextlevalName);
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }

}
