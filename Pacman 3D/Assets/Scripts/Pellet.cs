using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Pellet : MonoBehaviour
{
    public int pelletValue = 50;
    public int cherryValue = 200;
    private ScoreKeeper scoreKeeper;
    public AudioClip pelletSFX;
    public AudioClip cherrySFX;
    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = GameObject.Find("Score").GetComponent<ScoreKeeper>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pellet")
        {
            scoreKeeper.Score(pelletValue);
            AudioSource.PlayClipAtPoint(pelletSFX, Camera.main.transform.position);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Cherry")
        {
            scoreKeeper.Score(cherryValue);
            AudioSource.PlayClipAtPoint(cherrySFX, Camera.main.transform.position);
            Destroy(other.gameObject);
        }
    }
}
