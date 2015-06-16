using UnityEngine;
using System.Collections;

public class VideoPlay : MonoBehaviour {

	// Use this for initialization
    public MovieTexture movTexture;
	void Start () {

        //renderer.material.mainTexture = movTexture;
	
	}
	
	// Update is called once per frame
	void Update () {

        movTexture.Play();

	
	}
}
