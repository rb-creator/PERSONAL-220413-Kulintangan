using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    public List<Pool> pools;
    public Dictionary<string, Queue<GameObject>> poolDictionary; 
    //public static ObjectPooler currentInstance;
    //public GameObject pooledObject;
    //public int pooledAmount = 30;
    //public bool canGrow = true;

    //List<GameObject> pooledObjectCollection;

    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }

            poolDictionary.Add(pool.tag, objectPool);
        }
    }

    //private void Awake()
    //{
    //    currentInstance = this;
    //}

    //void Start()
    //{
    //    pooledObjectCollection = new List<GameObject>();
    //    GameObject tempObject;
    //    for (int i = 0; i < pooledAmount; i++)
    //    {
    //        tempObject = Instantiate(pooledObject);
    //        tempObject.SetActive(false);
    //        pooledObjectCollection.Add(tempObject);
    //    }
    //}

    //public GameObject GetPooledObject()
    //{
    //    for (int i = 0; i < pooledObjectCollection.Count; i++)
    //    {
    //        if (!pooledObjectCollection[i].activeInHierarchy)
    //        {
    //            return pooledObjectCollection[i];
    //        }
    //    }

        //    if (canGrow)
        //    {
        //        GameObject tempObject = (GameObject)Instantiate(pooledObject);
        //        pooledObjectCollection.Add(tempObject);
        //        return tempObject;
        //    }

        //    return null;
        //}

    }
