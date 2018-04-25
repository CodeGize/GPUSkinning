using UnityEngine;
using System.Collections;

[System.Serializable]
public class GPUSkinningClip
{
    public string name = null;

    public float length = 0.0f;

    public int fps = 0;

    public GPUSkinningWrapMode wrapMode = GPUSkinningWrapMode.Once;

    public GPUSkinningFrame[] frames = null;

    public int pixelSegmentation = 0;

    public bool rootMotionEnabled = false;

    public bool individualDifferenceEnabled = false;

    public GPUSkinningAnimEvent[] events = null;

    /// <summary>
    /// default speed
    /// </summary>
    private float speed = 1;

    /// <summary>
    /// Speed
    /// </summary>
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }
}
