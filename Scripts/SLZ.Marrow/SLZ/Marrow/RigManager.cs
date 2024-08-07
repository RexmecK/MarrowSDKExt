using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using SLZ.VRMK;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Marrow
{
	[SelectionBase]
	public class RigManager : MonoBehaviour
	{
		public enum BodyState
		{
			OnFoot = 0,
			Seated = 1,
			ActiveRagdoll = 2,
			Ragdoll = 3
		}

		private enum LeashType
		{
			Circle = 0,
			Rectangle = 1
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSwapAvatarCrate_003Ed__66 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public Barcode barcode;

			public Action<bool> callback;

			public bool cache;

			public RigManager _003C_003E4__this;

			private SLZ.VRMK.Avatar _003CavatarToSwapTo_003E5__2;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			private UniTask.Awaiter _003C_003Eu__3;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		private static ComponentCache<RigManager> _cache;

		[Header("Control")]
		public ControllerRig controllerRig;

		[Header("Remap")]
		public RemapRig remapHeptaRig;

		public AnimationRig animationRig;

		public InterpRig interpRig;

		public GameWorldSkeletonRig virtualHeptaRig;

		[Header("Physics")]
		public PhysicsRig physicsRig;

		[Header("Modules")]
		public Inventory inventory;

		public Health health;

		public Seat activeSeat;

		private BodyState _bodyState;

		private BodyState _bodyStateOnDeck;

		private bool _bodyStateDirty;

		[ReadOnly(false)]
		[Tooltip("Readonly field, to change which avatar is used in a scene, use \"Avatar Override\"")]
		[SerializeField]
		[Header("Avatar")]
		private SLZ.VRMK.Avatar _avatar;

		private SLZ.VRMK.Avatar _avatarOnDeck;

		private bool _avatarDirty;

		private string _avatarID;

		[SerializeField]
		[Tooltip("Overrides the avatar for the scene (overrides the loaded avatar)")]
		private AvatarCrateReference _avatarCrate;

		[SerializeField]
		private SLZ.VRMK.Avatar _calibrationAvatar;

		private string calibrationAvatarBarcode;

		public SerializableDictionary<Barcode, SLZ.VRMK.Avatar> _avatarCache;

		[HideInInspector]
		public WorldGrip worldGrip;

		public HandPose worldGripHandPose;

		[FormerlySerializedAs("inputRigs")]
		public Rig[] remapRigs;

		private bool _fixedRan;

		private bool _reEnable;

		public Action onAvatarSwapped;

		public Action<Barcode> onAvatarSwapped2;

		public Action OnPreAvatarEarlyUpdate;

		public Action OnPostLateUpdate;

		public Vector3 checkpointPosition;

		public Vector3 checkpointFwd;

		private SimpleTransform _queuedDestination;

		private bool _teleportQueued;

		private bool _zeroVelocity;

		private bool _leashed;

		private Vector3 _leashPositionWorld;

		private Quaternion _leashRotationWorld;

		private Vector2 _maxBounds;

		private Vector2 _minBounds;

		private ConfigurableJoint _leashJoint1;

		private ConfigurableJoint _leashJoint2;

		private LeashType _type;

		public static ComponentCache<RigManager> Cache => null;

		public ControllerRig ControllerRig => null;

		public BodyState bodyState
		{
			get
			{
				return default(BodyState);
			}
			set
			{
			}
		}

		public SLZ.VRMK.Avatar avatar
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public string avatarID => null;

		public bool HasInitialAvatar
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public AvatarCrateReference AvatarCrate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SLZ.VRMK.Avatar CalibrationAvatar
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isLeashed => false;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void EarlyUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public Rig GetPhysInputRig()
		{
			return null;
		}

		private void SwitchBodyState(BodyState bState)
		{
		}

		[AsyncStateMachine(typeof(_003CSwapAvatarCrate_003Ed__66))]
		public UniTask<bool> SwapAvatarCrate(Barcode barcode, bool cache = false, Action<bool> callback = null)
		{
			return default(UniTask<bool>);
		}

		public void SwapAvatar(SLZ.VRMK.Avatar newAvatar)
		{
		}

		private bool SwitchAvatar(SLZ.VRMK.Avatar newAvatar)
		{
			return false;
		}

		public void TeleportEvent(Transform trans)
		{
		}

		public bool Teleport(Vector3 feetDestinationWorld, bool zeroVelocity = true)
		{
			return false;
		}

		public bool Teleport(Vector3 feetDestinationWorld, Vector3 fwdSnap, bool zeroVelocity = true)
		{
			return false;
		}

		public bool Teleport(Transform destination, bool zeroVelocity = true)
		{
			return false;
		}

		private void InternalTeleport()
		{
		}

		public bool TeleportToPose(Vector3 feetDestinationWorld, Vector3 fwdSnap, bool zeroVelocity = true)
		{
			return false;
		}

		public bool LeashPlayerCircle(Vector3 positionWorld, float minRadius, float maxRadius)
		{
			return false;
		}

		public Vector3 UpdateLeashCircle(Vector3 headDelta)
		{
			return default(Vector3);
		}

		public Vector2 UpdateLeashCircle(Vector2 headDelta)
		{
			return default(Vector2);
		}

		public void UnleashPlayer()
		{
		}
	}
}
