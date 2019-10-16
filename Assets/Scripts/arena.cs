using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arena : MonoBehaviour
{
    public GameObject derbee;
    public int derbeecount;
    public float xmin;
    public  float xmax;
    public float zmin;
    public float zmax;


    public static List<GameObject> carsList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (carsList.Count< derbeecount)
        {
            Vector3 location = new Vector3(Random.Range(xmin, xmax), 0.4f, Random.Range(zmin, zmax));
            GameObject newDerb = (GameObject)Instantiate(derbee, location, Quaternion.Euler(0, Random.Range(0, 360), 0));

            carsList.Add(newDerb);

        }
    }
}
