using System.Threading.Tasks;
using UnityEngine;

public class Arrow : CellObject
{
    [SerializeField] private MeshRenderer meshRenderer;
    
    private Direction direction;

    public override async void HandleBeingObstacle()
    {
        AudioManager.Instance.PlayAudioClip(obstacleStateClip);

        meshRenderer.material = obstacleMaterial;

        await Task.Delay(500);

        meshRenderer.material = normalMaterial;
    }

    public void SetDirection(Direction newDirection)
    {
        direction = newDirection;
    }
    public override void AdjustTransformForSetup()
    {
        
    }

    public Direction GetDirection()
    {
        return direction;
    }

    public override void RotateByAngle(Vector3 angle)
    {
        transform.Translate(angle);
    }

}