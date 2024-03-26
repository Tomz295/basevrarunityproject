using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using VelUtils;
using static VelUtils.Movement;

public class FixedMarkerSpawner : MonoBehaviour
{
    [Header("VR Settings")]
    [SerializeField]
    [Tooltip("Enable creation of markers using the VR controller")]
    bool enableControllerMarkSpawning = true;

    public Side side = Side.Right;

    [Tooltip("What to press to spawn objects")]
    public VRInput MarkerSpawnInput = VRInput.Trigger;



    [Header("Spawnobject Settings")]
    [SerializeField]
    [Tooltip("Reference object where the ghost will be spawned")]
    GameObject spawnPoint;

    [SerializeField]
    [Tooltip("Prefab of ghost to spawn")]
    GameObject markerPrefab;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enableControllerMarkSpawning && InputMan.GetDown(MarkerSpawnInput, side))
        {
            spawnMarker();
        }
    }

    public void spawnMarker()
    {
        //GameObject newMarker = GameObject.Instantiate(markerPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation); // Probably dont need to store new object
        GameObject.Instantiate(markerPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }
}
