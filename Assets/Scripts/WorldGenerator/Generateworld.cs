using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generateworld : MonoBehaviour
{
    /*[SerializeField]
    private GameObject[] _platforms;*/
    static public GameObject dummyTraveller;
    static public GameObject lastPlatform;
    private void Awake()
    {
        dummyTraveller = new GameObject("dummy");
       
    }
    // Start is called before the first frame update
    void Start()
    {
      /*  for (int i = 0; i < 10; i++)
        {
            GameObject platform = PlatformPoolmanager._instance.getRandom();
            if (platform == null) return;
            platform.SetActive(true);
            platform.transform.position = dummyTraveller.transform.position;
            platform.transform.rotation = dummyTraveller.transform.rotation;
            if (platform.tag == "inclined")
            {
                dummyTraveller.transform.Translate(0, 5, 0);
            }
            else if (platform.tag == "declined")
            {
                dummyTraveller.transform.Translate(0, -5, 0);
                platform.transform.Rotate(new Vector3(0, 180, 0));
                platform.transform.position = dummyTraveller.transform.position;
            }
            else if (platform.tag == "T-section")
            {
                platform.transform.Rotate(new Vector3(0, 90, 0));
                dummyTraveller.transform.Translate(Vector3.forward * -20);
            }

            dummyTraveller.transform.Translate(Vector3.forward * +20);
        }*/


       /* for (int i = 0; i < 3; i++)
        {
           int platformNo = Random.Range(0, _platforms.Length);
            PlatformPoolmanager._instance.getObjectFromPool(_platforms[platformNo],pos, transform.rotation);
            
        }*/
       
        

    }
    public static void RunDummy()
    {
        GameObject platform = PlatformPoolmanager._instance.getRandom();
        if (platform == null) return;
        if(lastPlatform != null)
        {
            dummyTraveller.transform.position = lastPlatform.transform.position + PlayerController._player.transform.forward*80;
        }
        
        lastPlatform = platform;
        platform.SetActive(true);
        platform.transform.position = dummyTraveller.transform.position;
        platform.transform.rotation = dummyTraveller.transform.rotation;
    }



}
