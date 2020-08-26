using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpText : MonoBehaviour {

    public Transform PlayerTransform;

    float showOnDistance = 12;

    private MeshRenderer textMesh;
    // Use this for initialization
    void Start () {
        textMesh = gameObject.GetComponent<MeshRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(transform.position, PlayerTransform.position) < showOnDistance)
            textMesh.enabled = true;
        else
            textMesh.enabled = false;
    }
}
