using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handgun : MonoBehaviour
{
    [SerializeField] AudioSource gunshot;
    [SerializeField] GameObject gun;
    [SerializeField] bool canFire = true;
    public GameObject decalPrefab;
    GameObject[] totalDecals;
    int actual_decal = 0;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            if (canFire==true)
            {
                ////new
                //RaycastHit hit;
                //if (Physics.Raycast(
                //    Camera.main.ViewportPointToRay(
                //        new Vector3(0.5f, 0.5f, 0)),
                //    out hit))
                //{
                //    // Destroy the old decal at this index if it exists
                //    Destroy(totalDecals[actual_decal]);

                //    // Instantiate new decal and store it
                //    totalDecals[actual_decal] = GameObject.Instantiate(
                //        decalPrefab,
                //        hit.point + hit.normal * 0.01f,
                //        Quaternion.FromToRotation(
                //            Vector3.forward,
                //            -hit.normal)
                //    ) as GameObject;

                //    //new
                //    actual_decal++;
                //    if (actual_decal == 10) actual_decal = 0;
                //    //old
                //    canFire = false;
                //    StartCoroutine(FiringGun());
                //}


                //old
                canFire = false;
                StartCoroutine(FiringGun());

            }
        }
        
    }

    IEnumerator FiringGun()
    {
       
        gunshot.Play();
        gun.GetComponent<Animator>().Play("gunFire");
        yield return new WaitForSeconds(0.5f);
        gun.GetComponent<Animator>().Play("New State");
        yield return new WaitForSeconds(0.1f);
        canFire = true;
    }
}
