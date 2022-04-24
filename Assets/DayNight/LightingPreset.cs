// Code from: https://www.youtube.com/watch?app=desktop&v=m9hj9PdO328&feature=emb_title&ab_channel=ProbablySpoonie

using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName ="Lighting Preset", menuName ="Scriptables/Lighting Preset",order =1)]
public class LightingPreset : ScriptableObject
{
    public Gradient AmbientColor;
    public Gradient DirectionalColor;
    public Gradient FogColor;
}
