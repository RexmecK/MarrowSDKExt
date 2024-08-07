using SLZ.Marrow.AI;
using SLZ.Marrow.Combat;
using SLZ.Marrow.Data;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Marrow
{
	public class Projectile : MonoBehaviour
	{
		private Rigidbody rb;

		private bool isFinished;

		private int debugColorIdx;

		private Color[] debugColors;

		private int currentParticleSpawns;

		private float currentSpeed;

		private Vector3 _direction;

		public TrailRenderer trail;

		[Header("Projectile Attributes ")]
		[Tooltip("Bullet reference. Use stated values if empty")]
		private ProjectileData _data;

		[SerializeField]
		[Tooltip("Velocity in Meters per Second")]
		[Space(5f)]
		private float startSpeed;

		[SerializeField]
		[Tooltip("Mass in kg")]
		private float Mass;

		[SerializeField]
		private AttackType ammoAttribute;

		[SerializeField]
		private LayerMask collisionLayers;

		[SerializeField]
		private bool allowBulletDrop;

		[SerializeField]
		private bool applyRemainderForceToCollision;

		private TriggerRefProxy _proxy;

		[Tooltip("Max amount of impact particle systems allowed to spawn")]
		[Header("Pool Options")]
		[Range(0f, 19f)]
		[SerializeField]
		[Space(5f)]
		private int MaxParticleSpawns;

		[SerializeField]
		private UnityEventCollision onCollision;

		[SerializeField]
		private bool showDebugLines;

		private bool _frameDelay;

		private bool _simulate;

		private Attack _attack;

		private ExecuteEvents.EventFunction<IAttackReceiver> _executeEventAction;

		private int _lastFrameUdate;

		private void Awake()
		{
		}

		public void SetBulletObject(ProjectileData data, Transform startTransform, Vector3 locPos, Quaternion locRot, Rigidbody EmittingRigidbody = null, TriggerRefProxy proxy = null)
		{
		}

		public void EstablishVariables(string name = null, Transform EmittingTransform = null, TriggerRefProxy proxy = null)
		{
		}

		private void ExecuteEventCallback(IAttackReceiver handler, BaseEventData eventData)
		{
		}

		private void Update()
		{
		}

		public void OnEnable()
		{
		}
	}
}
