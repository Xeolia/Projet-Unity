using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBoule : MonoBehaviour
{
    public Rigidbody maSphere;
    public float speed = 1000.0f;
    Vector3 originalPos;


    public Rigidbody sphere;
    // Start is called before the first frame update
    void Start()
    {
        //sphere = GetComponent<Rigidbody>();
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.Space)) //on recupere etat barre espace
       {
            sphere.AddForce(Vector3.forward * speed);
       }
       if (Input.GetKey(KeyCode.AltGr)) //on recupere etat AltGr pour supprimer boule
       {
           Destroy(gameObject);
       }
        if (Input.GetKey(KeyCode.LeftShift) ) //on recupere etat shift pour reset à la position de départ l'objet
        {
           // Instantiate(maSphere, new Vector3(0, 1, 0), Quaternion.identity);
            gameObject.transform.position = originalPos;
            sphere.AddForce(Vector3.forward);
            //Instantiate(maSphere, new Vector3(-0.29f, 1.15f, -5.83f), Quaternion.identity);
        }

    }


}
