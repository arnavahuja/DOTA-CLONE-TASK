using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    private int RandNum1,c=0;
    private int RandNum2,RandNum3,d=0,e=0;
    public float minwait;
    public float maxwait;
    public float startwait1;
    //public float startwait2;
    //public float startwait3;
    public Vector3 spawnvalues;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnwave1());
        //StartCoroutine(spawnwave2());
        //StartCoroutine(spawnwave3());
    }
    // Update is called once per frame
    void Update()
    {
        
    }   

    IEnumerator spawnwave1()
    {
        yield return new WaitForSeconds(startwait1);
        while(c<10)
        {
            RandNum1 = Random.Range(0,3);
            Vector3 spawnplace = new Vector3 (Random.Range(-spawnvalues.x,spawnvalues.x),1,Random.Range(-spawnvalues.z,spawnvalues.z));
            Instantiate (enemies[RandNum1],spawnplace + transform.TransformPoint(0,0,0), gameObject.transform.rotation);
            yield return new WaitForSeconds(Random.Range(minwait,maxwait));
            c++;
        }
}
    /*IEnumerator spawnwave2()
    {
        yield return new WaitForSeconds(startwait2);
        while(d<10)
        {
            RandNum2 = Random.Range(0,2);
            Vector3 spawnplace = new Vector3 (Random.Range(-spawnvalues.x,spawnvalues.x),1,Random.Range(-spawnvalues.z,spawnvalues.z));
            Instantiate (enemies[RandNum2],spawnplace + transform.TransformPoint(0,0,0), gameObject.transform.rotation);
            yield return new WaitForSeconds(Random.Range(minwait,maxwait));
            d++;
        }
}
    IEnumerator spawnwave3()
    {
        yield return new WaitForSeconds(startwait3);
        while(e<10)
        {
            RandNum3 = Random.Range(0,3);
            Vector3 spawnplace = new Vector3 (Random.Range(-spawnvalues.x,spawnvalues.x),1,Random.Range(-spawnvalues.z,spawnvalues.z));
            Instantiate (enemies[RandNum3],spawnplace + transform.TransformPoint(0,0,0), gameObject.transform.rotation);
            yield return new WaitForSeconds(Random.Range(minwait,maxwait));
            e++;
        }
}*/
}
