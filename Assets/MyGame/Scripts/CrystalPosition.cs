using UnityEngine;

[RequireComponent(typeof(Collider))]
public class CrystalPosition : MonoBehaviour
{
    [Range(0, 2)]
    public int correspondingCrystalIndex = 0;

    private void OnTriggerEnter(Collider col)
    {
        // checking which crystal is entering the collider
        if (!col.CompareTag("c" + correspondingCrystalIndex.ToString())) return;

        // moving the crystal to its dedicated position
        col.transform.position = this.transform.position;
    }
}