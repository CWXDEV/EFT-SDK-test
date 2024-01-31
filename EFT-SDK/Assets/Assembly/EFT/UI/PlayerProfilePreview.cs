using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Utilities;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C44 RID: 11332
	[Serializable]
	public class PlayerProfilePreview : UIElement
	{
		// Token: 0x17002700 RID: 9984
		// (get) Token: 0x0600DF52 RID: 57170 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerModelView PlayerModelView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002701 RID: 9985
		// (get) Token: 0x0600DF53 RID: 57171 RVA: 0x00002050 File Offset: 0x00000250
		public XCoordRotation Rotator
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002702 RID: 9986
		// (get) Token: 0x0600DF54 RID: 57172 RVA: 0x00002050 File Offset: 0x00000250
		public DragTrigger DragTrigger
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002703 RID: 9987
		// (get) Token: 0x0600DF55 RID: 57173 RVA: 0x00002050 File Offset: 0x00000250
		public SideSelectionToggle HoverTrigger
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002704 RID: 9988
		// (get) Token: 0x0600DF56 RID: 57174 RVA: 0x00002050 File Offset: 0x00000250
		public EPlayerSide Side
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002705 RID: 9989
		// (get) Token: 0x0600DF57 RID: 57175 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DF58 RID: 57176 RVA: 0x00002050 File Offset: 0x00000250
		public Profile Profile
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600DF59 RID: 57177 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Show(Profile profile, float update = 0f)
		{
			throw null;
		}

		// Token: 0x0600DF5A RID: 57178 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task ChangeCameraPosition(PlayerProfilePreview.ECameraViewType viewType, float duration)
		{
			throw null;
		}

		// Token: 0x0600DF5B RID: 57179 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetVisibility(bool visible, float duration)
		{
			throw null;
		}

		// Token: 0x17002706 RID: 9990
		// (get) Token: 0x0600DF5C RID: 57180 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DF5D RID: 57181 RVA: 0x00002050 File Offset: 0x00000250
		public bool RotationEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002707 RID: 9991
		// (get) Token: 0x0600DF5E RID: 57182 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DF5F RID: 57183 RVA: 0x00002050 File Offset: 0x00000250
		public bool Selectable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600DF60 RID: 57184 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLightStatus(bool isOn)
		{
			throw null;
		}

		// Token: 0x0600DF61 RID: 57185 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGodLightStatus(bool active, float duration = 0.5f)
		{
			throw null;
		}

		// Token: 0x0600DF62 RID: 57186 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool isUnderCursor)
		{
			throw null;
		}

		// Token: 0x0600DF63 RID: 57187 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400E417 RID: 58391
		[SerializeField]
		private PlayerModelView _playerModelView;

		// Token: 0x0400E418 RID: 58392
		[SerializeField]
		private RectTransform _transform;

		// Token: 0x0400E419 RID: 58393
		[SerializeField]
		private XCoordRotation _rotator;

		// Token: 0x0400E41A RID: 58394
		[SerializeField]
		private DragTrigger _dragTrigger;

		// Token: 0x0400E41B RID: 58395
		[SerializeField]
		private SideSelectionToggle _hoverTrigger;

		// Token: 0x0400E41C RID: 58396
		[SerializeField]
		private EPlayerSide _side;

		// Token: 0x0400E41D RID: 58397
		[SerializeField]
		private Transform _cameraContainer;

		// Token: 0x0400E41E RID: 58398
		[SerializeField]
		private Camera _camera;

		// Token: 0x0400E41F RID: 58399
		[SerializeField]
		private CanvasGroup _godLight;

		// Token: 0x0400E420 RID: 58400
		[SerializeField]
		private List<GameObject> _lights;

		// Token: 0x0400E421 RID: 58401
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400E422 RID: 58402
		[SerializeField]
		private Dictionary<PlayerProfilePreview.ECameraViewType, Transform> _cameraPositions;

		// Token: 0x0400E423 RID: 58403
		[SerializeField]
		private Dictionary<PlayerProfilePreview.ECameraViewType, RectTransform> _viewportPositions;

		// Token: 0x0400E424 RID: 58404
		private bool _selected;

		// Token: 0x02002C45 RID: 11333
		public enum ECameraViewType
		{
			// Token: 0x0400E427 RID: 58407
			FullBody,
			// Token: 0x0400E428 RID: 58408
			Head
		}

		// Token: 0x02002C46 RID: 11334
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2696
		{
			// Token: 0x0600DF64 RID: 57188 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E429 RID: 58409
			public static readonly PlayerProfilePreview.Class2696 class2696_0;

			// Token: 0x0400E42A RID: 58410
			public static Action action_0;
		}
	}
}
