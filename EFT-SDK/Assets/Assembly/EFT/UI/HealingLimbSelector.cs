using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.HealthSystem;
using EFT.InputSystem;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x0200289A RID: 10394
	public sealed class HealingLimbSelector : UIInputNode
	{
		// Token: 0x17002517 RID: 9495
		// (get) Token: 0x0600CFA5 RID: 53157 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CFA6 RID: 53158 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<EBodyPart?> Show(IHealthController healthController, List<EBodyPart> bodyParts, Vector2 sourcePosition, DamageHistory damageHistory = null)
		{
			throw null;
		}

		// Token: 0x0600CFA7 RID: 53159 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool TryGetLimbsToHealByItem(Item item, IHealthController healthController, out List<EBodyPart> result)
		{
			throw null;
		}

		// Token: 0x0600CFA8 RID: 53160 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EBodyPart? GetSelectedLimb()
		{
			throw null;
		}

		// Token: 0x0600CFA9 RID: 53161 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600CFAA RID: 53162 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600CFAB RID: 53163 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600CFAC RID: 53164 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600CFAD RID: 53165 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(EBodyPart? result)
		{
			throw null;
		}

		// Token: 0x0600CFAE RID: 53166 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600CFAF RID: 53167 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600CFB0 RID: 53168 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(int value)
		{
			throw null;
		}

		// Token: 0x0600CFB1 RID: 53169 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Color method_4(bool selected)
		{
			throw null;
		}

		// Token: 0x0600CFB2 RID: 53170 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(int index, bool isSelected)
		{
			throw null;
		}

		// Token: 0x0600CFB3 RID: 53171 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool smethod_0(Type effectType)
		{
			throw null;
		}

		// Token: 0x0400D066 RID: 53350
		private static readonly Type[] type_0;

		// Token: 0x0400D067 RID: 53351
		[SerializeField]
		private HealingLimbSelector.BodyPartViewDictionary _bodyPartsViews;

		// Token: 0x0400D068 RID: 53352
		[SerializeField]
		private GameObject _cancelView;

		// Token: 0x0400D069 RID: 53353
		[SerializeField]
		private Image _cancelBackground;

		// Token: 0x0400D06A RID: 53354
		[SerializeField]
		private Vector2 _quickUseButtonOffset;

		// Token: 0x0400D06B RID: 53355
		[SerializeField]
		private Color _normalElementColor;

		// Token: 0x0400D06C RID: 53356
		[SerializeField]
		private Color _selectedElementColor;

		// Token: 0x0400D06D RID: 53357
		private int int_0;

		// Token: 0x0400D06E RID: 53358
		private int int_1;

		// Token: 0x0400D06F RID: 53359
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x0400D070 RID: 53360
		private TaskCompletionSource<EBodyPart?> taskCompletionSource_0;

		// Token: 0x0400D071 RID: 53361
		private readonly List<ValueTuple<EBodyPart, HealingLimbView>> list_0;

		// Token: 0x0200289B RID: 10395
		[Serializable]
		public class BodyPartViewDictionary : SerializableEnumDictionary<EBodyPart, HealingLimbView>
		{
		}
	}
}
