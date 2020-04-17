using UnityEngine;
using Valve.VR.InteractionSystem;

[RequireComponent(typeof(Collider))]
public class CrystalPosition : MonoBehaviour
{
    [Range(0, 2)]
    public int correspondingCrystalIndex = 0;

    public Vector3 crystalOffset;
    public Vector3 crystalRotation;
   

    private void OnTriggerEnter(Collider col)
    {
        // checking which crystal is entering the collider
        if (!col.CompareTag("c" + correspondingCrystalIndex.ToString())) return; print(col.name);

        // disable physics and interactable scripts
        //col.GetComponent<Rigidbody>().
        Throwable throwable = col.GetComponent<Throwable>();
        Interactable interactable = col.GetComponent<Interactable>();

        Destroy(throwable);
        Destroy(interactable);
        Destroy(col.attachedRigidbody);

        // moving the crystal to its dedicated position
        col.transform.position = this.transform.position + crystalOffset;
        col.transform.rotation = Quaternion.Euler(crystalRotation);

    }
}