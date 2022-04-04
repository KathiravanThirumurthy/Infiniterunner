using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generateworld : MonoBehaviour
{
    /*[SerializeField]
    private GameObject[] _platforms;*/
    private GameObject dummyTraveller;
    private Vector3 pos= new Vector3(0, 0, 0);
    private void Awake()
    {
        dummyTraveller = new GameObject("dummy");
       
    }
    // Start is called before the first frame update
    void Start()
    {
        /*Vector3 pos = new Vector3(0, 0, 0);
        for(int i=0;i<3;i++)
        {
            PlatformPoolmanager._instance.getObjectFromPool(pos,transform.rotation);
           // Instantiate(_platforms[Random.Range(0,_platforms.Length)],pos,Quaternion.identity);
            pos.z += 20;
        }*/
       
        
      
        for (int i = 0; i < 3; i++)
        {
           /* int platformNo = Random.Range(0, _platforms.Length);
            PlatformPoolmanager._instance.getObjectFromPool(_platforms[platformNo],pos, transform.rotation);*/
            PlatformPoolmanager._instance.getObjectFromPool(pos, transform.rotation);
            // Instantiate(_platforms[Random.Range(0,_platforms.Length)],pos,Quaternion.identity);
            pos.z += 20;
        }
        

    }
    public static void RunDummy()
    {
       /* PlatformPoolmanager._instance.getObjectFromPool(pos, transform.rotation);
        pos.z += 20;*/
    }

    
}
