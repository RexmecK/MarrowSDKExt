using System;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[Support(SupportFlags.Supported, "<b>Reminder</b>: Is there a better way to do this?")]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Event Adapter")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/EventAdapter")]
	public sealed class EventAdapter : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, ISerializationCallbackReceiver, IVoidLogicActuator
	{
		[SerializeField]
		[Obsolete("Replace with `_previousConnection`")]
		[Tooltip("Previous node in the chain")]
		[Interface(typeof(IVoidLogicSource), false)]
		private MonoBehaviour _previousNode;

		[SerializeField]
		private float lowThreshold;

		[SerializeField]
		private float highThreshold;

		[Header("Events")]
		[Tooltip("When the input value changes (EXPENSIVE, runs all callbacks on every value update)")]
		public UltEvent<EventAdapter, IVoidLogicSource, float> InputUpdated;

		[Tooltip("When the input value rises above the high threshold")]
		public UltEvent<EventAdapter, IVoidLogicSource, float> InputRose;

		[Tooltip("When the input value holds above the high threshold")]
		public UltEvent<EventAdapter, IVoidLogicSource, float> InputHeld;

		[Tooltip("When the input value lowers beneath the low threshold")]
		public UltEvent<EventAdapter, IVoidLogicSource, float> InputFell;

		[Tooltip("When the input value rises above the high threshold (for the first time only)")]
		public UltEvent<EventAdapter, IVoidLogicSource, float> InputRoseOneShot;

		private float _priorValue;

		private bool _isHigh;

		private bool _hasBeenHigh;

		private static readonly PortMetadata _portMetadata;

		public VoidLogicSubgraph Subgraph
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int InputCount => 0;

		public PortMetadata PortMetadata => default(PortMetadata);

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicActuator_002EActuate(ref NodeState nodeState)
		{
		}

		private void _invokeInputUpdated(IVoidLogicSource source, float f)
		{
		}

		private void _invokeInputRose(IVoidLogicSource source, float f)
		{
		}

		private void _invokeInputRoseOneShot(IVoidLogicSource source, float f)
		{
		}

		private void _invokeInputFell(IVoidLogicSource source, float f)
		{
		}

		private void _invokeInputHeld(IVoidLogicSource source, float f)
		{
		}

        public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
        {
            throw new NotImplementedException();
        }

        public void OnBeforeSerialize()
        {
            
        }

        public void OnAfterDeserialize()
        {
            
        }

        public void Actuate(ref NodeState nodeState)
        {
            
        }
    }
}
