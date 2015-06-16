using UnityEngine;
using System.Collections;

public class BustScript : MonoBehaviour {
    public GameObject eyes;
    private float dist;
    private bool active = false;
	// Use this for initialization
	void Start () {
        gameObject.GetComponent<SmoothLookAt>().enabled = false;
        eyes.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        gameObject.GetComponent<SmoothLookAt>().enabled = true;
        eyes.SetActive(true);
        //eyes.GetComponent<SmoothFollow>().enabled = true;

    }

    void OnTriggerStay(Collider col)
    {
      /*  if (col.gameObject.tag == "Player")
        {
            dist = Vector3.Distance(col.transform.position, transform.position)/2f;
            eyes.transform.localScale = new Vector3(eyes.transform.localScale.x * dist, eyes.transform.localScale.y * dist, eyes.transform.localScale.z * dist);
        }*/
    }
    void OnTriggerExit(Collider col)
    {
        gameObject.GetComponent<SmoothLookAt>().enabled = false;
        //eyes.GetComponent<SmoothFollow>().enabled = true;
        eyes.SetActive(false);

    }
}
