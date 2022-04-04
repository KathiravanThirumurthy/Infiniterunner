using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    [SerializeField]
    private GameObject _platformDestructionPoint;
    private float _distanceOfDeletion = -40.0f;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(this.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        destroyPlatform();
    }
    private void destroyPlatform()
    {
        if (this.transform.position.z < _platformDestructionPoint.transform.position.z)
        {
            //Destroy(this.gameObject);
            //this.gameObject.SetActive(false);
            PlatformPoolmanager._instance.ReturnObjecttoPool(this.gameObject);


        }
    }
}
