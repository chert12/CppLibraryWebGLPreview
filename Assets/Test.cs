using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(MathLibWrapper.add(10,5));
        Debug.Log(MathLibWrapper.subtract(10,5));
        Debug.Log(MathLibWrapper.multiply(10,5));
        Debug.Log(MathLibWrapper.divide(10,5));
    }
}
