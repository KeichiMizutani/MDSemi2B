using UnityEngine;

public class GPUClothSimulation : MonoBehaviour
{
    [SerializeField] private ComputeShader kernel;
    public ComputeShader Kernel => kernel;
}


