using System.Collections;
using System.Collections.Generic;
//using UnityEngine;

//public class Shooter : MonoBehaviour
//{
//    public GameObject decalPrefab;

//    GameObject[] totalDecals;
//    int actual_decal = 0;


//    void Start()
//    {
//        totalDecals = new GameObject[10];
//    }

//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            RaycastHit hit;
//            if (Physics.Raycast(
//                Camera.main.ViewportPointToRay(
//                    new Vector3(0.5f, 0.5f, 0)),
//                out hit))
//            {
//                Destroy(totalDecals[actual_decal]);
//                totalDecals[actual_decal] =
//                    GameObject.Instantiate(
//                        decalPrefab,
//                        hit.point + hit.normal * 0.01f,
//                        Quaternion.FromToRotation(
//                            Vector3.forward,
//                            -hit.normal)
//                    ) as GameObject;

//                actual_decal++;
//                if (actual_decal == 10) actual_decal = 0;
//            }
//        }
//    }
//}

//using UnityEngine;

//public class Shooter : MonoBehaviour
//{
//    public GameObject decalPrefab;
//    public AudioSource fireSound;

//    GameObject[] totalDecals;
//    int actual_decal = 0;

//    void Start()
//    {
//        totalDecals = new GameObject[10];
//    }

//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            RaycastHit hit;
//            if (Physics.Raycast(
//                Camera.main.ViewportPointToRay(
//                    new Vector3(0.5f, 0.5f, 0)),
//                out hit))
//            {
//                // Destroy the old decal at this index if it exists
//                Destroy(totalDecals[actual_decal]);

//                // Instantiate new decal and store it
//                totalDecals[actual_decal] = GameObject.Instantiate(
//                    decalPrefab,
//                    hit.point + hit.normal * 0.01f,
//                    Quaternion.FromToRotation(
//                        Vector3.forward,
//                        -hit.normal)
//                ) as GameObject;

//                // Play the firing sound
//                fireSound.Play();

//                // Increment decal index
//                actual_decal++;
//                if (actual_decal == 10) actual_decal = 0;
//            }
//        }
//    }
//}

