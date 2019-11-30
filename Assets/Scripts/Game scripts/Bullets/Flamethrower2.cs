using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flamethrower2 : MonoBehaviour
{
    public int damage;
    public GameObject explosion;
    private GameController gameController;

    [Header("Sounds")]
    public AudioSource flam;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            flam.Play();
            gameController.player1HP -= damage;
            Instantiate(explosion, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
        if (other.tag == "Wall")
        {
            flam.Play();
            Instantiate(explosion, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
