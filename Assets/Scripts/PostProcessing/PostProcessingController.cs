using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingController : MonoBehaviour
{
    [SerializeField]
    private PostProcessVolume _postProcessVolume;
    private Bloom _bloomValue;
    void Awake()
    {
        _postProcessVolume.profile.TryGetSettings(out _bloomValue);
    }
    // Start is called before the first frame update
    void Start()
    {
        
        BloomOff();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BloomOff()
    {
        _bloomValue.active = false;
    }
}
