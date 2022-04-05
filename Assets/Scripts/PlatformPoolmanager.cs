using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PoolItem
{
    public GameObject _prefab;
    public int amount;
    public bool expandable;
}
public class PlatformPoolmanager : MonoBehaviour
{
    /* [SerializeField]
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


     }*/
    public static PlatformPoolmanager _instance;
    public List<PoolItem> items;
    public List<GameObject> pooledItems;
    private GameObject tempGO;
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        pooledItems = new List<GameObject>();
        foreach (PoolItem item in items)
        {
            for (int i = 0; i < item.amount; i++)
            {
                GameObject gObj = Instantiate(item._prefab);
                gObj.SetActive(false);
                pooledItems.Add(gObj);
            }
        }
    }
    public GameObject getRandom()
    {
        Shuffle();
        for (int i = 0; i < pooledItems.Count; i++)
        {
            if (!pooledItems[i].activeInHierarchy)
            {
                return pooledItems[i];

            }
        }
        foreach (PoolItem item in items)
        {
            GameObject gObject = Instantiate(item._prefab);
            gObject.SetActive(false);
            pooledItems.Add(gObject);
            return gObject;

        }
        return null;
    }
    public void Shuffle()
    {
        for (int i = 0; i < pooledItems.Count; i++)
        {
            int rnd = Random.Range(0, pooledItems.Count);
            tempGO = pooledItems[rnd];
            pooledItems[rnd] = pooledItems[i];
            pooledItems[i] = tempGO;
        }
    }
}
