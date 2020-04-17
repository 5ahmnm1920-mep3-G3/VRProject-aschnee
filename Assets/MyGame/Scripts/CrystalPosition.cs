using UnityEngine;



[RequireComponent(typeof(Collider))]
public class CrystalPosition : MonoBehaviour
{
    [Range(0, 2)]
    public int correspondingCrystalIndex = 0;



    private void OnTriggerEnter(Collider col)
    {



    }
}