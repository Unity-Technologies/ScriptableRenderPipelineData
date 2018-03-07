using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour {

    private Color[] m_colors;
    private Renderer[] m_objects;
    private int m_count;



    // Use this for initialization
    void Start ()
    {
        m_objects = Object.FindObjectsOfType<Renderer>();
        m_colors = new Color[m_objects.Length];
        m_count = m_objects.Length;
        for (int n=0;n<m_objects.Length;n++)
        {
            m_colors[n] = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }


    // Update is called once per frame
    void Update ()
    {

        float f = Time.time * 5.0f;

        for (int n = 0; n < m_count; n++)
        {
            m_objects[n].sharedMaterial.SetColor("_Color", m_colors[n] * (Mathf.Sin(f + n) * 0.5f + 0.5f));
        }
    }
}
