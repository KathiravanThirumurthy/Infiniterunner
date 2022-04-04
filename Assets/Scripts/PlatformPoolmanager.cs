using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPoolmanager : MonoBehaviour
{
    [SerializeField]
    private GameObject _trackPrefab;
    [SerializeField]
    private int trackpoolsize;
    [SerializeField]
    
    private List<GameObject> _trackPool;

    public static PlatformPoolmanager _instance;

    // Start is called before the first frame update
    private void Awake()
    {
        checkingForInstance();
        InitPool();
    }
    void Start()
    {
        _instance = this;
    }

    void checkingForInstance()
    {
        if (_instance == null)
        {
            _instance = this;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void InitPool()
    {
        _trackPool = new List<GameObject>();
        for (int i = 0; i < trackpoolsize; i++)
        {
            GameObject newTrack = Instantiate(_trackPrefab);
            _trackPool.Add(newTrack);
            newTrack.SetActive(false);


        }


    }

    public GameObject GetRandom()
    {
        // for(int i=0;i< )
        return null;
    }
    public GameObject getObjectFromPool(Vector3 targetPos, Quaternion rotation)
    {

        for (int i = 0; i < trackpoolsize; i++)
        {
            if (!_trackPool[i].activeInHierarchy)
            {
                _trackPool[i].SetActive(true);
                _trackPool[i].transform.position = targetPos;
                _trackPool[i].transform.rotation = rotation;
                return _trackPool[i];
            }


        }
        return null;
    }

    public void ReturnObjecttoPool(GameObject gObj)
    {
        _trackPool.Add(gObj);
        gObj.SetActive(false);
        //transform.parent.gameObject.SetActive(false);
       

    }
}
