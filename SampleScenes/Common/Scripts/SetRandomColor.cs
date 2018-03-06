using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRandomColor : MonoBehaviour {

    public bool createDifferentMaterial = true;

	// Use this for initialization
	void Start ()
    {
        Animator[] objA = FindObjectsOfType<Animator>();
        foreach (Animator o in objA)
        {
            float t = Random.value * 4.0f;
            o.Update(t);
        }



        UnityEngine.Object[] obj = Object.FindObjectsOfType(typeof (UnityEngine.SkinnedMeshRenderer));
        foreach (Object o in obj)
        {
            //             go.material.color = ;
            UnityEngine.SkinnedMeshRenderer r = (UnityEngine.SkinnedMeshRenderer)o;
            r.material.SetColor("_BaseColor", Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
        }

    }

    // Update is called once per frame
    void Update () {

	}
}
